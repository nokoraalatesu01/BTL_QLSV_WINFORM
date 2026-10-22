using System.Globalization;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

/// <summary>
/// Nhập điểm: chọn niên khóa / học kỳ / lớp tín chỉ → hiển thị danh sách sinh viên → nhập CC, GK, CK.
/// Điểm tổng kết tự tính = CC×0.1 + GK×0.3 + CK×0.6.
/// </summary>
public partial class FrmNhapDiem : Form
{
    private const string TatCa = "(Tất cả)";

    private List<DiemRow> _rows = new();
    private LopTinChi? _ltcDangMo;
    private bool _daSua;
    private bool _dangKhoiTao;
    private string _giaTriTruocKhiSua = "";

    public FrmNhapDiem()
    {
        InitializeComponent();
    }

    // ------------------------------------------------------------------
    // Kiểm tra điểm (dùng chung cho hiển thị tổng kết, đánh dấu lỗi và lưu)
    // ------------------------------------------------------------------

    internal static string? KiemTraCC(string text, out decimal? value)
    {
        if (!DiemHelper.TryParse(text, out value))
            return "Chuyên cần phải là số.";
        if (value.HasValue
            && (!DiemHelper.LaDiemHopLe(value.Value, false) || value.Value != decimal.Truncate(value.Value)))
            return "Chuyên cần phải là số nguyên từ 0 đến 10.";
        return null;
    }

    internal static string? KiemTraGKCK(string text, string ten, out decimal? value)
    {
        if (!DiemHelper.TryParse(text, out value))
            return $"{ten} phải là số.";
        if (value.HasValue && !DiemHelper.LaDiemHopLe(value.Value, true))
            return $"{ten} phải từ 0 đến 10, bước 0.5.";
        return null;
    }

    private static string? KiemTraCot(DiemRow row, string cot) => cot switch
    {
        "CC" => KiemTraCC(row.CC, out _),
        "GK" => KiemTraGKCK(row.GK, "Giữa kỳ", out _),
        "CK" => KiemTraGKCK(row.CK, "Cuối kỳ", out _),
        _ => null,
    };

    private static string GiaTri(DiemRow row, string cot) => cot switch
    {
        "CC" => row.CC,
        "GK" => row.GK,
        "CK" => row.CK,
        _ => "",
    };

    private static string Dinh(decimal? value) =>
        value.HasValue ? value.Value.ToString("0.#", CultureInfo.InvariantCulture) : "";

    // ------------------------------------------------------------------
    // Sự kiện
    // ------------------------------------------------------------------

    private void FrmNhapDiem_Load(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            _dangKhoiTao = true;
            try
            {
                cboHocKy.Items.AddRange(new object[] { TatCa, "1", "2", "3" });
                cboHocKy.SelectedIndex = 0;

                cboNienKhoa.Items.Add(TatCa);
                foreach (var nk in DiemBLL.LayNienKhoa())
                    cboNienKhoa.Items.Add(nk);
                cboNienKhoa.SelectedIndex = cboNienKhoa.Items.Count > 1 ? 1 : 0; // mặc định niên khóa mới nhất
            }
            finally
            {
                _dangKhoiTao = false;
            }
            NapLopTinChi();
            CapNhatTrangThaiNut();
        });
    }

    private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_dangKhoiTao) UiHelper.Run(NapLopTinChi);
    }

    private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_dangKhoiTao) UiHelper.Run(NapLopTinChi);
    }

    private void btnTai_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            if (cboLopTinChi.SelectedItem is not LopTinChi ltc)
            {
                UiHelper.ShowWarning("Hãy chọn một lớp tín chỉ.");
                return;
            }
            MoLopTinChi(ltc);
        });
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        UiHelper.Run(Luu);
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            if (_ltcDangMo == null) return;
            if (!UiHelper.Confirm("Hủy các thay đổi chưa lưu và tải lại điểm từ cơ sở dữ liệu?")) return;
            MoLopTinChi(_ltcDangMo);
        });
    }

    private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < _rows.Count)
            _giaTriTruocKhiSua = GiaTri(_rows[e.RowIndex], dgv.Columns[e.ColumnIndex].DataPropertyName);
    }

    private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _rows.Count) return;

        var row = _rows[e.RowIndex];
        var cot = dgv.Columns[e.ColumnIndex].DataPropertyName;

        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = KiemTraCot(row, cot) ?? "";
        if (GiaTri(row, cot) != _giaTriTruocKhiSua)
            DatDaSua(true);

        dgv.InvalidateRow(e.RowIndex); // cập nhật cột Tổng kết
    }

    private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.ThrowException = false;
    }

    private void FrmNhapDiem_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_daSua && !UiHelper.Confirm("Còn điểm chưa lưu. Đóng cửa sổ và bỏ các thay đổi?"))
            e.Cancel = true;
    }

    // ------------------------------------------------------------------
    // Nạp dữ liệu
    // ------------------------------------------------------------------

    private void NapLopTinChi()
    {
        var nk = cboNienKhoa.SelectedItem as string;
        string? nienKhoa = nk == null || nk == TatCa ? null : nk;

        int? hocKy = null;
        if (cboHocKy.SelectedItem is string hk && hk != TatCa)
            hocKy = int.Parse(hk);

        var ds = DiemBLL.LayLopTinChi(nienKhoa, hocKy);
        cboLopTinChi.DisplayMember = "HienThi";
        cboLopTinChi.ValueMember = "MaLTC";
        cboLopTinChi.DataSource = ds;
        if (ds.Count == 0)
            cboLopTinChi.SelectedIndex = -1;
    }

    private void MoLopTinChi(LopTinChi ltc)
    {
        var ds = DiemBLL.LayDanhSachDiem(ltc.MaLTC);

        _rows = ds.Select(d => new DiemRow
        {
            MaSV = d.MaSV,
            HoTen = d.HoTen,
            MaLop = d.MaLop,
            CC = Dinh(d.DiemCC),
            GK = Dinh(d.DiemGK),
            CK = Dinh(d.DiemCK),
        }).ToList();

        dgv.DataSource = null;
        dgv.DataSource = _rows;
        dgv.ClearSelection();

        _ltcDangMo = ltc;
        lblThongTin.Text =
            $"Môn: {ltc.TenMH}  |  Nhóm {ltc.Nhom}  |  Giảng viên: {ltc.TenGV}  |  " +
            $"Niên khóa {ltc.NienKhoa}, học kỳ {ltc.HocKy}  |  Số sinh viên: {_rows.Count}";
        DatDaSua(false);
    }

    private void DatDaSua(bool daSua)
    {
        _daSua = daSua;
        CapNhatTrangThaiNut();
    }

    private void CapNhatTrangThaiNut()
    {
        bool coGhi = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Ghi);
        btnLuu.Enabled = coGhi && _ltcDangMo != null && _daSua;
        btnHuy.Enabled = _ltcDangMo != null && _daSua;
        dgv.ReadOnly = !coGhi;

        // Đang có thay đổi chưa lưu: khóa bộ chọn để không lẫn điểm giữa hai lớp.
        bool khoa = _daSua;
        cboNienKhoa.Enabled = !khoa;
        cboHocKy.Enabled = !khoa;
        cboLopTinChi.Enabled = !khoa;
        btnTai.Enabled = !khoa;
    }

    private void Luu()
    {
        dgv.EndEdit();
        if (_ltcDangMo == null) return;

        var loi = new List<string>();
        var ds = new List<DiemSinhVien>();

        foreach (var r in _rows)
        {
            var e1 = KiemTraCC(r.CC, out var cc);
            var e2 = KiemTraGKCK(r.GK, "Giữa kỳ", out var gk);
            var e3 = KiemTraGKCK(r.CK, "Cuối kỳ", out var ck);
            foreach (var thongBao in new[] { e1, e2, e3 })
            {
                if (thongBao != null) loi.Add($"{r.MaSV} ({r.HoTen}): {thongBao}");
            }

            ds.Add(new DiemSinhVien
            {
                MaLTC = _ltcDangMo.MaLTC,
                MaSV = r.MaSV,
                HoTen = r.HoTen,
                MaLop = r.MaLop,
                DiemCC = cc,
                DiemGK = gk,
                DiemCK = ck,
            });
        }

        if (loi.Count > 0)
        {
            var hienThi = loi.Take(10).ToList();
            if (loi.Count > hienThi.Count)
                hienThi.Add($"... và {loi.Count - hienThi.Count} lỗi khác.");
            UiHelper.ShowWarning("Chưa lưu được vì điểm không hợp lệ:\n\n" + string.Join("\n", hienThi));
            return;
        }

        DiemBLL.LuuDiem(_ltcDangMo.MaLTC, ds);
        MoLopTinChi(_ltcDangMo);
        UiHelper.ShowInfo("Đã lưu điểm.");
    }
}
