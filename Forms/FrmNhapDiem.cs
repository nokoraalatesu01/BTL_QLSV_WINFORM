using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

/// <summary>
/// Nhập điểm: chọn niên khóa / học kỳ / lớp tín chỉ → hiển thị danh sách sinh viên → nhập CC, GK, CK.
/// Điểm tổng kết tự tính = CC×0.1 + GK×0.3 + CK×0.6.
/// </summary>
public partial class FrmNhapDiem : BaseForm
{
    private const string TatCa = "(Tất cả)";

    private List<DiemRow> _rows = new List<DiemRow>();
    private LopTinChi? _ltcDangMo;
    private bool _daSua;
    private bool _dangKhoiTao;
    private string _giaTriTruocKhiSua = "";

    public FrmNhapDiem()
    {
        InitializeComponent();
        this.TaoCotLuoi();
    }

    /// <summary>
    /// Tạo cột lưới thủ công: chỉ CC, GK, CK được sửa (Mã SV, Họ tên, Lớp, Tổng kết chỉ đọc),
    /// nhờ vậy phím Enter chỉ nhảy qua các ô nhập điểm.
    /// </summary>
    private void TaoCotLuoi()
    {
        this.dgv.AutoGenerateColumns = false;
        this.dgv.Columns.Clear();
        this.ThemCot("MaSV", "Mã SV", 14, true, false);
        this.ThemCot("HoTen", "Họ và tên", 30, true, false);
        this.ThemCot("MaLop", "Lớp", 14, true, false);
        this.ThemCot("CC", "Chuyên cần", 12, false, true);
        this.ThemCot("GK", "Giữa kỳ", 12, false, true);
        this.ThemCot("CK", "Cuối kỳ", 12, false, true);
        this.ThemCot("TongKet", "Tổng kết", 12, true, true);
    }

    private void ThemCot(string thuocTinh, string tieuDe, float doRong, bool chiDoc, bool canGiua)
    {
        var cot = new DataGridViewTextBoxColumn
        {
            DataPropertyName = thuocTinh,
            Name = "col" + thuocTinh,
            HeaderText = tieuDe,
            FillWeight = doRong,
            ReadOnly = chiDoc,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };
        if (canGiua)
        {
            cot.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cot.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        this.dgv.Columns.Add(cot);
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

    private static string? KiemTraCot(DiemRow row, string cot)
    {
        switch (cot)
        {
            case "CC":
                return KiemTraCC(row.CC, out _);
            case "GK":
                return KiemTraGKCK(row.GK, "Giữa kỳ", out _);
            case "CK":
                return KiemTraGKCK(row.CK, "Cuối kỳ", out _);
            default:
                return null;
        }
    }

    private static string GiaTri(DiemRow row, string cot)
    {
        switch (cot)
        {
            case "CC":
                return row.CC;
            case "GK":
                return row.GK;
            case "CK":
                return row.CK;
            default:
                return "";
        }
    }

    private static string Dinh(decimal? value)
    {
        return value.HasValue ? value.Value.ToString("0.#", CultureInfo.InvariantCulture) : "";
    }

    // ------------------------------------------------------------------
    // Sự kiện
    // ------------------------------------------------------------------

    private void FrmNhapDiem_Load(object sender, EventArgs e)
    {
        try
        {
            this._dangKhoiTao = true;
            try
            {
                this.cboHocKy.Items.Clear();
                this.cboHocKy.Items.AddRange(new object[] { TatCa, "1", "2", "3" });
                this.cboHocKy.SelectedIndex = 0;

                this.cboNienKhoa.Items.Clear();
                this.cboNienKhoa.Items.Add(TatCa);
                foreach (var nk in DiemBLL.LayNienKhoa())
                {
                    this.cboNienKhoa.Items.Add(nk);
                }
                this.cboNienKhoa.SelectedIndex = this.cboNienKhoa.Items.Count > 1 ? 1 : 0; // mặc định niên khóa mới nhất
            }
            finally
            {
                this._dangKhoiTao = false;
            }

            this.NapLopTinChi();
            this.CapNhatTrangThaiNut();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi nạp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!this._dangKhoiTao)
        {
            try
            {
                this.NapLopTinChi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!this._dangKhoiTao)
        {
            try
            {
                this.NapLopTinChi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnTai_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.cboLopTinChi.SelectedItem is not LopTinChi ltc)
            {
                MessageBox.Show("Hãy chọn một lớp tín chỉ để xem danh sách điểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.MoLopTinChi(ltc);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi tải điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        try
        {
            this.Luu();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi lưu điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        try
        {
            if (this._ltcDangMo == null) return;
            if (MessageBox.Show("Hủy các thay đổi chưa lưu và tải lại điểm từ cơ sở dữ liệu?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            this.MoLopTinChi(this._ltcDangMo);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXuatExcel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this._ltcDangMo == null)
            {
                MessageBox.Show("Hãy tải danh sách điểm của một lớp tín chỉ trước khi xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this._daSua && MessageBox.Show(
                    "Còn điểm chưa lưu. File Excel chỉ chứa điểm ĐÃ LƯU trong cơ sở dữ liệu.\n\nVẫn tiếp tục xuất?",
                    "Xác nhận xuất Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            // Lấy lại từ BLL để vẫn kiểm tra quyền / phạm vi lớp tín chỉ như khi xem điểm.
            var ds = DiemBLL.LayDanhSachDiem(this._ltcDangMo.MaLTC);

            using var hop = new SaveFileDialog
            {
                Title = "Xuất bảng điểm ra Excel",
                Filter = "Excel (*.xlsx)|*.xlsx",
                DefaultExt = "xlsx",
                AddExtension = true,
                FileName = ExcelExporter.TenFileGoiY(this._ltcDangMo),
            };
            if (hop.ShowDialog(this) != DialogResult.OK) return;

            ExcelExporter.XuatBangDiem(hop.FileName, this._ltcDangMo, ds);

            if (MessageBox.Show("Đã xuất bảng điểm thành công!\n\nMở file ngay bây giờ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(hop.FileName) { UseShellExecute = true });
            }
        }
        catch (IOException)
        {
            MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel — hãy đóng file rồi thử lại.", "Lỗi xuất Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi xuất Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < this._rows.Count)
        {
            this._giaTriTruocKhiSua = GiaTri(this._rows[e.RowIndex], this.dgv.Columns[e.ColumnIndex].DataPropertyName);
        }
    }

    private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= this._rows.Count) return;

        var row = this._rows[e.RowIndex];
        var cot = this.dgv.Columns[e.ColumnIndex].DataPropertyName;

        this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = KiemTraCot(row, cot) ?? "";
        if (GiaTri(row, cot) != this._giaTriTruocKhiSua)
        {
            this.DatDaSua(true);
        }

        this.dgv.InvalidateRow(e.RowIndex); // cập nhật cột Tổng kết
    }

    private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.ThrowException = false;
    }

    private void FrmNhapDiem_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (this._daSua && MessageBox.Show("Còn điểm chưa lưu. Bạn có chắc muốn đóng cửa sổ và bỏ các thay đổi không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            e.Cancel = true;
        }
    }

    // ------------------------------------------------------------------
    // Nạp dữ liệu
    // ------------------------------------------------------------------

    private void NapLopTinChi()
    {
        var nk = this.cboNienKhoa.SelectedItem as string;
        string? nienKhoa = (nk == null || nk == TatCa) ? null : nk;

        int? hocKy = null;
        if (this.cboHocKy.SelectedItem is string hk && hk != TatCa)
        {
            hocKy = int.Parse(hk);
        }

        var ds = DiemBLL.LayLopTinChi(nienKhoa, hocKy);
        this.cboLopTinChi.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cboLopTinChi.DisplayMember = "HienThi";
        this.cboLopTinChi.ValueMember = "MaLTC";
        this.cboLopTinChi.DataSource = ds;
        if (ds.Count == 0)
        {
            this.cboLopTinChi.SelectedIndex = -1;
        }
    }

    private void MoLopTinChi(LopTinChi ltc)
    {
        var ds = DiemBLL.LayDanhSachDiem(ltc.MaLTC);

        this._rows = ds.Select(d => new DiemRow
        {
            MaSV = d.MaSV,
            HoTen = d.HoTen,
            MaLop = d.MaLop,
            CC = Dinh(d.DiemCC),
            GK = Dinh(d.DiemGK),
            CK = Dinh(d.DiemCK),
        }).ToList();

        this.dgv.DataSource = null;
        this.dgv.DataSource = this._rows;
        this.dgv.ClearSelection();

        this._ltcDangMo = ltc;
        this.lblThongTin.Text =
            $"Môn: {ltc.TenMH}  |  Nhóm {ltc.Nhom}  |  Giảng viên: {ltc.TenGV}  |  " +
            $"Niên khóa {ltc.NienKhoa}, học kỳ {ltc.HocKy}  |  Số sinh viên: {this._rows.Count}";
        this.DatDaSua(false);
    }

    private void DatDaSua(bool daSua)
    {
        this._daSua = daSua;
        this.CapNhatTrangThaiNut();
    }

    private void CapNhatTrangThaiNut()
    {
        bool coGhi = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Ghi);
        this.btnLuu.Enabled = coGhi && this._ltcDangMo != null && this._daSua;
        this.btnHuy.Enabled = this._ltcDangMo != null && this._daSua;

        // Xuất Excel: PGV, KHOA, GV (mọi vai trò được xem điểm); phạm vi lớp do BLL kiểm soát.
        this.btnXuatExcel.Visible = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Xem);
        this.btnXuatExcel.Enabled = this._ltcDangMo != null;
        this.dgv.ReadOnly = !coGhi;

        // Đang có thay đổi chưa lưu: khóa bộ chọn để không lẫn điểm giữa hai lớp.
        bool khoa = this._daSua;
        this.cboNienKhoa.Enabled = !khoa;
        this.cboHocKy.Enabled = !khoa;
        this.cboLopTinChi.Enabled = !khoa;
        this.btnTai.Enabled = !khoa;
    }

    private void Luu()
    {
        this.dgv.EndEdit();
        if (this._ltcDangMo == null) return;

        var loi = new List<string>();
        var ds = new List<DiemSinhVien>();

        foreach (var r in this._rows)
        {
            var e1 = KiemTraCC(r.CC, out var cc);
            var e2 = KiemTraGKCK(r.GK, "Giữa kỳ", out var gk);
            var e3 = KiemTraGKCK(r.CK, "Cuối kỳ", out var ck);
            foreach (var thongBao in new[] { e1, e2, e3 })
            {
                if (thongBao != null)
                {
                    loi.Add($"{r.MaSV} ({r.HoTen}): {thongBao}");
                }
            }

            ds.Add(new DiemSinhVien
            {
                MaLTC = this._ltcDangMo.MaLTC,
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
            {
                hienThi.Add($"... và {loi.Count - hienThi.Count} lỗi khác.");
            }
            MessageBox.Show("Chưa lưu được vì điểm không hợp lệ:\n\n" + string.Join("\n", hienThi), "Lỗi điểm không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DiemBLL.LuuDiem(this._ltcDangMo.MaLTC, ds);
        this.MoLopTinChi(this._ltcDangMo);
        MessageBox.Show("Đã lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
