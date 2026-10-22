using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QLDSV_HTC.BLL;

namespace QLDSV_HTC.Forms
{
    /// <summary>Sinh viên xem thông tin và bảng điểm của chính mình (chỉ đọc).</summary>
    public partial class FrmBangDiemSV : Form
    {
        public FrmBangDiemSV()
        {
            InitializeComponent();
        }

        private void FrmBangDiemSV_Load(object sender, EventArgs e)
        {
            try
            {
                this.NapDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp bảng điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapDuLieu()
        {
            var sv = BangDiemBLL.LayThongTinCaNhan();
            this.lblThongTin.Text = $"{sv.MaSV} - {sv.HoTen}   |   Lớp: {sv.TenLop}";

            var bangDiem = BangDiemBLL.LayBangDiem();
            this.dgv.DataSource = null;
            this.dgv.DataSource = bangDiem;
            this.dgv.ClearSelection();

            var coDiem = bangDiem.Where(d => d.DiemTK.HasValue).ToList();
            if (coDiem.Count == 0)
            {
                this.lblTrungBinh.Text = "Chưa có môn nào đủ điểm để tính tổng kết.";
                return;
            }

            var tb = coDiem.Average(d => d.DiemTK!.Value);
            this.lblTrungBinh.Text =
                $"Số môn đã có điểm tổng kết: {coDiem.Count}/{bangDiem.Count}   |   " +
                $"Điểm trung bình (trung bình cộng các môn): {tb.ToString("0.00", CultureInfo.InvariantCulture)}";
        }
    }
}
