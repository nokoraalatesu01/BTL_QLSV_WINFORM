using System;
using System.Drawing;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmMain : Form
    {
        private SinhVienDAL svDAL = new SinhVienDAL();
        private LopDAL lopDAL = new LopDAL();
        private KhoaDAL khoaDAL = new KhoaDAL();
        private MonHocDAL mhDAL = new MonHocDAL();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Cập nhật người dùng hiện tại lên thanh trạng thái
            if (SessionManager.CurrentUser != null)
            {
                tslblNguoiDung.Text = $"Người dùng: {SessionManager.CurrentUser.HoTen} ({SessionManager.CurrentUser.Quyen})";
            }
            else
            {
                tslblNguoiDung.Text = "Người dùng: Khách";
            }

            // Trạng thái CSDL
            if (DataBaseProcess.IsUsingSqlServer)
            {
                tslblCSDL.Text = "● CSDL: SQL Server (Trực tuyến)";
                tslblCSDL.ForeColor = Color.Green;
            }
            else
            {
                tslblCSDL.Text = "● CSDL: Dữ liệu Cục bộ (Local Mode)";
                tslblCSDL.ForeColor = Color.DarkOrange;
            }

            CapNhatDashboard();
            CapNhatThoiGian();
        }

        public void CapNhatDashboard()
        {
            try
            {
                int soSV = svDAL.GetAllSinhVien().Rows.Count;
                int soLop = lopDAL.GetAllLop().Rows.Count;
                int soKhoa = khoaDAL.GetAllKhoa().Rows.Count;
                int soMon = mhDAL.GetAllMonHoc().Rows.Count;

                lblCountSV.Text = soSV.ToString();
                lblCountLop.Text = soLop.ToString();
                lblCountKhoa.Text = soKhoa.ToString();
                lblCountMon.Text = soMon.ToString();
            }
            catch
            {
                // Bỏ qua lỗi cập nhật dashboard
            }
        }

        private void CapNhatThoiGian()
        {
            tslblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerThoiGian_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGian();
        }

        // ============================================================
        // MỞ CÁC FORM CHỨC NĂNG (CHUẨN BÀI THỰC HÀNH TUẦN 3)
        // ============================================================

        private void mnuQLSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            frm.FormClosed += (s, args) => CapNhatDashboard();
            frm.ShowDialog();
        }

        private void mnuQLLopKhoa_Click(object sender, EventArgs e)
        {
            frmLopKhoa frm = new frmLopKhoa();
            frm.FormClosed += (s, args) => CapNhatDashboard();
            frm.ShowDialog();
        }

        private void mnuQLMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.FormClosed += (s, args) => CapNhatDashboard();
            frm.ShowDialog();
        }

        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            frmDiem frm = new frmDiem();
            frm.ShowDialog();
        }

        private void mnuThongKeTongHop_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuThongTinNhom_Click(object sender, EventArgs e)
        {
            frmThongTinNhom frm = new frmThongTinNhom();
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.ClearSession();
                this.Hide();
                frmDangNhap login = new frmDangNhap();
                login.Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
