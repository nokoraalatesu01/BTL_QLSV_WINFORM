using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms
{
    /// <summary>Form chính (MDI): menu hiển thị theo quyền của người dùng đang đăng nhập.</summary>
    public partial class FrmMain : BaseForm
    {
        private readonly Dictionary<Type, Form> _formDangMo = new Dictionary<Type, Form>();

        /// <summary>true nếu người dùng chọn "Đăng xuất" (Program sẽ hiện lại màn hình đăng nhập).</summary>
        public bool DangXuat { get; private set; }

        public FrmMain()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient mc)
                    mc.BackColor = Palette.Canvas;
            }
            this.lblNguoiDung.Font = Palette.FontSmall;
            this.lblNguoiDung.ForeColor = Palette.Muted;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                var nd = Quyen.HienTai;
                this.lblNguoiDung.Text = "Người dùng: " + nd.TenHienThi + "  |  Vai trò: " + nd.VaiTroText + "  |  Tài khoản: " + nd.TenDangNhap;

                // Ẩn menu theo quyền (tầng BLL vẫn kiểm tra lại mỗi khi gọi dữ liệu).
                bool coKhoa = Quyen.CoQuyen(ChucNang.Khoa, HanhDong.Xem);
                bool coLop = Quyen.CoQuyen(ChucNang.Lop, HanhDong.Xem);
                bool coSinhVien = Quyen.CoQuyen(ChucNang.SinhVien, HanhDong.Xem);
                bool coMonHoc = Quyen.CoQuyen(ChucNang.MonHoc, HanhDong.Xem);
                bool coGiangVien = Quyen.CoQuyen(ChucNang.GiangVien, HanhDong.Xem);
                bool coLopTinChi = Quyen.CoQuyen(ChucNang.LopTinChi, HanhDong.Xem);
                bool coNhapDiem = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Xem);
                bool coDiemCaNhan = Quyen.CoQuyen(ChucNang.DiemCaNhan, HanhDong.Xem);

                this.mnuKhoa.Available = coKhoa;
                this.mnuLop.Available = coLop;
                this.mnuSinhVien.Available = coSinhVien;
                this.mnuMonHoc.Available = coMonHoc;
                this.mnuGiangVien.Available = coGiangVien;
                this.mnuLopTinChi.Available = coLopTinChi;
                this.mnuNhapDiem.Available = coNhapDiem;
                this.mnuBangDiemCaNhan.Available = coDiemCaNhan;

                this.mnuDanhMuc.Available = coKhoa || coLop || coSinhVien || coMonHoc || coGiangVien;
                this.mnuDaoTao.Available = coLopTinChi || coNhapDiem;
                this.mnuTaiKhoanSV.Available = coDiemCaNhan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------- Menu Hệ thống ----------------
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmDoiMatKhau f = new FrmDoiMatKhau())
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản hiện tại không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DongTatCaCuaSoCon();
                if (this.MdiChildren.Length > 0)
                {
                    return; // Một cửa sổ con từ chối đóng (ví dụ còn điểm chưa lưu)
                }

                AuthBLL.DangXuat();
                this.DangXuat = true;
                this.Close();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ---------------- Menu chức năng ----------------
        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmKhoa), () => new FrmKhoa());
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmLop), () => new FrmLop());
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmSinhVien), () => new FrmSinhVien());
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmMonHoc), () => new FrmMonHoc());
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmGiangVien), () => new FrmGiangVien());
        }

        private void mnuLopTinChi_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmLopTinChi), () => new FrmLopTinChi());
        }

        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmNhapDiem), () => new FrmNhapDiem());
        }

        private void mnuBangDiemCaNhan_Click(object sender, EventArgs e)
        {
            this.MoForm(typeof(FrmBangDiemSV), () => new FrmBangDiemSV());
        }

        // ---------------- Menu Cửa sổ ----------------
        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuChiaNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuChiaDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            this.DongTatCaCuaSoCon();
        }

        /// <summary>Mở form con; nếu loại form đó đã mở thì đưa lên phía trước.</summary>
        private void MoForm(Type loai, Func<Form> tao)
        {
            try
            {
                if (this._formDangMo.TryGetValue(loai, out var daMo) && !daMo.IsDisposed)
                {
                    daMo.Activate();
                    return;
                }

                Form form = tao();
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.FormClosed += (s, e) => this._formDangMo.Remove(loai);
                this._formDangMo[loai] = form;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở giao diện", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DongTatCaCuaSoCon()
        {
            foreach (var con in this.MdiChildren)
            {
                con.Close();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng chương trình/đăng xuất: nếu cửa sổ con còn việc dở (nhập điểm chưa lưu) thì hủy thoát.
            foreach (var con in this.MdiChildren)
            {
                con.Close();
                if (!con.IsDisposed)
                {
                    e.Cancel = true;
                    this.DangXuat = false;
                    return;
                }
            }
        }
    }
}
