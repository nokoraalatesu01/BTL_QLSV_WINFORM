using System.Globalization;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.Forms;

/// <summary>Sinh viên xem thông tin và bảng điểm của chính mình (chỉ đọc).</summary>
public partial class FrmBangDiemSV : Form
{
    public FrmBangDiemSV()
    {
        InitializeComponent();
    }

    private void FrmBangDiemSV_Load(object? sender, EventArgs e) => UiHelper.Run(NapDuLieu);

    private void NapDuLieu()
    {
        var sv = BangDiemBLL.LayThongTinCaNhan();
        lblThongTin.Text = $"{sv.MaSV} - {sv.HoTen}   |   Lớp: {sv.TenLop}";

        var bangDiem = BangDiemBLL.LayBangDiem();
        dgv.DataSource = bangDiem;
        dgv.ClearSelection();

        var coDiem = bangDiem.Where(d => d.DiemTK.HasValue).ToList();
        if (coDiem.Count == 0)
        {
            lblTrungBinh.Text = "Chưa có môn nào đủ điểm để tính tổng kết.";
            return;
        }

        var tb = coDiem.Average(d => d.DiemTK!.Value);
        lblTrungBinh.Text =
            $"Số môn đã có điểm tổng kết: {coDiem.Count}/{bangDiem.Count}   |   " +
            $"Điểm trung bình (trung bình cộng các môn): {tb.ToString("0.00", CultureInfo.InvariantCulture)}";
    }
}
