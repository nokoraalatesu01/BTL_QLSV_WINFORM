using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms
{
    /// <summary>
    /// Form chính UTC Portal: sidebar cố định Navy, header, content panel.
    /// Form con được nhúng TopLevel=false vào pnlContent, không dùng MDI.
    /// </summary>
    public partial class FrmMain : BaseForm
    {
        /// <summary>true nếu người dùng chọn "Đăng xuất".</summary>
        public bool DangXuat { get; private set; }

        private FrmDashboard? _dashboard;
        private SidebarButton? _nutDangChon;
        private Control? _controlHienTai;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                TaiLogo();

                var nd = Quyen.HienTai;
                this.lblNguoiDung.Text = "  " + nd.TenHienThi + "   |   " + nd.VaiTroText + "  ";
                CenNguoiDung();

                // Ẩn/hiện menu theo quyền
                bool coKhoa = Quyen.CoQuyen(ChucNang.Khoa, HanhDong.Xem);
                bool coLop = Quyen.CoQuyen(ChucNang.Lop, HanhDong.Xem);
                bool coSinhVien = Quyen.CoQuyen(ChucNang.SinhVien, HanhDong.Xem);
                bool coMonHoc = Quyen.CoQuyen(ChucNang.MonHoc, HanhDong.Xem);
                bool coGiangVien = Quyen.CoQuyen(ChucNang.GiangVien, HanhDong.Xem);
                bool coLopTinChi = Quyen.CoQuyen(ChucNang.LopTinChi, HanhDong.Xem);
                bool coNhapDiem = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Xem);
                bool coDiemCaNhan = Quyen.CoQuyen(ChucNang.DiemCaNhan, HanhDong.Xem);
                bool coHoSo = Quyen.CoQuyen(ChucNang.HoSoCaNhan, HanhDong.Xem);

                this.btnNavKhoa.Visible = coKhoa;
                this.btnNavLop.Visible = coLop;
                this.btnNavSinhVien.Visible = coSinhVien;
                this.btnNavMonHoc.Visible = coMonHoc;
                this.btnNavGiangVien.Visible = coGiangVien;
                this.btnNavLopTinChi.Visible = coLopTinChi;
                this.btnNavNhapDiem.Visible = coNhapDiem;
                this.btnNavBangDiem.Visible = coDiemCaNhan;
                this.btnNavHoSo.Visible = coHoSo;

                NapAnhHeader();

                // Mở Dashboard mặc định
                DenTrangDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Điều hướng sidebar ──────────────────────────────────────────────
        private void btnNavDashboard_Click(object sender, EventArgs e) => DenTrangDashboard();
        private void btnNavKhoa_Click(object sender, EventArgs e) => DenTrangForm("Quản lý khoa", this.btnNavKhoa, () => new FrmKhoa());
        private void btnNavLop_Click(object sender, EventArgs e) => DenTrangForm("Quản lý lớp", this.btnNavLop, () => new FrmLop());
        private void btnNavSinhVien_Click(object sender, EventArgs e) => DenTrangForm("Quản lý sinh viên", this.btnNavSinhVien, () => new FrmSinhVien());
        private void btnNavMonHoc_Click(object sender, EventArgs e) => DenTrangForm("Quản lý môn học", this.btnNavMonHoc, () => new FrmMonHoc());
        private void btnNavGiangVien_Click(object sender, EventArgs e) => DenTrangForm("Quản lý giảng viên", this.btnNavGiangVien, () => new FrmGiangVien());
        private void btnNavLopTinChi_Click(object sender, EventArgs e) => DenTrangForm("Lớp tín chỉ", this.btnNavLopTinChi, () => new FrmLopTinChi());
        private void btnNavNhapDiem_Click(object sender, EventArgs e) => DenTrangForm("Nhập điểm", this.btnNavNhapDiem, () => new FrmNhapDiem());
        private void btnNavBangDiem_Click(object sender, EventArgs e) => DenTrangForm("Bảng điểm cá nhân", this.btnNavBangDiem, () => new FrmBangDiemSV());

        private void btnNavHoSo_Click(object sender, EventArgs e) => DenTrangForm("Hồ sơ cá nhân", this.btnNavHoSo, () =>
        {
            var f = new FrmHoSoCaNhan();
            f.AnhDaiDienDaCapNhat += CapNhatAnhHeader;   // đồng bộ ảnh trên thanh tài khoản ngay khi lưu
            return f;
        });

        private void btnNavDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                using var f = new FrmDoiMatKhau();
                f.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản hiện tại không?",
                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AuthBLL.DangXuat();
                this.DangXuat = true;
                this.Close();
            }
        }

        // ── Lõi điều hướng ─────────────────────────────────────────────────

        /// <summary>Chuyển sang Dashboard, tạo nếu chưa có.</summary>
        private void DenTrangDashboard()
        {
            try
            {
                DatActiveNut(this.btnNavDashboard);
                this.lblPageTitle.Text = "Tổng quan hệ thống";

                // Xóa control đang hiển thị (nếu không phải dashboard)
                XoaControlHienTai(giu: false);

                // Tạo hoặc tái dùng dashboard
                if (_dashboard == null || _dashboard.IsDisposed)
                {
                    _dashboard = new FrmDashboard { Dock = DockStyle.Fill };
                }

                if (!this.pnlContent.Controls.Contains(_dashboard))
                    this.pnlContent.Controls.Add(_dashboard);

                _dashboard.Visible = true;
                _dashboard.BringToFront();
                _dashboard.TaiDuLieu();
                _controlHienTai = _dashboard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nhúng Form con vào pnlContent với TopLevel=false.
        /// Form con giữ nguyên toàn bộ logic nghiệp vụ, chỉ bỏ border Form.
        /// </summary>
        private void DenTrangForm(string tieuDe, SidebarButton nut, Func<Form> taoForm)
        {
            try
            {
                DatActiveNut(nut);
                this.lblPageTitle.Text = tieuDe;

                // Xóa control hiện tại
                XoaControlHienTai(giu: false);

                // Ẩn dashboard nếu đang hiện
                if (_dashboard != null && !_dashboard.IsDisposed)
                    _dashboard.Visible = false;

                // Tạo form mới, nhúng vào content panel
                var form = taoForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.BackColor = Palette.Canvas;
                // Xóa padding mặc định của form con nếu có (để content panel quản lý)
                form.Padding = new Padding(20, 16, 20, 8);

                this.pnlContent.Controls.Add(form);
                form.Show();
                _controlHienTai = form;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở giao diện", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Ảnh đại diện trên thanh tài khoản (chỉ sinh viên) ───────────────
        private void NapAnhHeader()
        {
            var nd = Quyen.HienTai;
            bool laSinhVien = nd.VaiTro == VaiTro.SV && !string.IsNullOrWhiteSpace(nd.MaSV);
            this.picAvatar.Visible = laSinhVien;
            if (laSinhVien) AnhHelper.CatTron(this.picAvatar);   // ảnh tròn

            if (laSinhVien)
            {
                Image anh;
                try
                {
                    var data = HoSoSinhVienBLL.LayAnhDaiDien();
                    anh = data != null ? AnhHelper.TuBytes(data) : AnhHelper.TaoAnhMacDinh(this.picAvatar.Width);
                }
                catch
                {
                    anh = AnhHelper.TaoAnhMacDinh(this.picAvatar.Width);
                }
                CapNhatAnhHeader(anh);
            }
            CenNguoiDung();
        }

        private void CapNhatAnhHeader(Image? anh)
        {
            var moi = anh ?? AnhHelper.TaoAnhMacDinh(this.picAvatar.Width);
            var cu = this.picAvatar.Image;
            this.picAvatar.Image = moi;
            cu?.Dispose();
        }

        private void DatActiveNut(SidebarButton nut)
        {
            if (_nutDangChon != null && !_nutDangChon.IsDisposed)
                _nutDangChon.Active = false;
            nut.Active = true;
            _nutDangChon = nut;
        }

        private void XoaControlHienTai(bool giu)
        {
            if (_controlHienTai == null || _controlHienTai.IsDisposed) return;
            if (_controlHienTai is FrmDashboard)
            {
                _controlHienTai.Visible = false;
                return;
            }
            this.pnlContent.Controls.Remove(_controlHienTai);
            if (!giu) _controlHienTai.Dispose();
            _controlHienTai = null;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose control hiện tại khi đóng
            XoaControlHienTai(giu: false);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenNguoiDung();
        }

        private void CenNguoiDung()
        {
            if (lblNguoiDung == null || pnlHeader == null) return;
            int choAnh = 0;
            if (picAvatar != null && picAvatar.Visible)
            {
                picAvatar.Location = new Point(
                    pnlHeader.Width - picAvatar.Width - 20, (pnlHeader.Height - picAvatar.Height) / 2);
                choAnh = picAvatar.Width + 12;
            }
            lblNguoiDung.Location = new Point(
                pnlHeader.Width - lblNguoiDung.Width - 16 - choAnh, 0);
        }

        private void TaiLogo()
        {
            try
            {
                SaoChepLogo();
                var logo = LayHinhAnh("LogoUTC.png") ?? LayHinhAnh("logo_login.png");
                if (logo != null && this.picLogo != null)
                {
                    this.picLogo.Image = logo;
                }
            }
            catch { }
        }

        private static void SaoChepLogo()
        {
            try
            {
                string[] cacNguon = new string[]
                {
                    Path.Combine(Application.StartupPath, "GUIMage", "LogoUTC.png"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GUIMage", "LogoUTC.png"),
                    Path.Combine(Application.StartupPath, "..", "..", "..", "GUIMage", "LogoUTC.png"),
                    Path.Combine(Directory.GetCurrentDirectory(), "GUIMage", "LogoUTC.png")
                };

                string[] cacDich = new string[]
                {
                    Path.Combine(Application.StartupPath, "Resources", "img", "LogoUTC.png"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "img", "LogoUTC.png"),
                    Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "img", "LogoUTC.png"),
                    Path.Combine(Directory.GetCurrentDirectory(), "Resources", "img", "LogoUTC.png")
                };

                string? src = null;
                foreach (var s in cacNguon)
                {
                    if (File.Exists(s)) { src = s; break; }
                }

                if (src != null)
                {
                    foreach (var d in cacDich)
                    {
                        try
                        {
                            string dir = Path.GetDirectoryName(d)!;
                            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                            if (!File.Exists(d)) File.Copy(src, d, true);
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private static Image? LayHinhAnh(string tenTep)
        {
            try
            {
                string[] cacDuongDan = new string[]
                {
                    Path.Combine(Application.StartupPath, "Resources", "img", tenTep),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "img", tenTep),
                    Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "img", tenTep),
                    Path.Combine(Directory.GetCurrentDirectory(), "Resources", "img", tenTep),
                    Path.Combine(Application.StartupPath, "GUIMage", tenTep),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GUIMage", tenTep),
                    Path.Combine(Application.StartupPath, "..", "..", "..", "GUIMage", tenTep),
                    Path.Combine(Directory.GetCurrentDirectory(), "GUIMage", tenTep)
                };

                foreach (var duongDan in cacDuongDan)
                {
                    if (File.Exists(duongDan))
                    {
                        using (var fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
                        {
                            return Image.FromStream(fs);
                        }
                    }
                }
            }
            catch { }
            return null;
        }
    }
}
