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
    /// Form con được nhúng TopLevel=false vào pnlContent.
    /// </summary>
    public partial class FrmMain : BaseForm
    {
        /// <summary>true nếu người dùng chọn "Đăng xuất".</summary>
        public bool DangXuat { get; private set; }

        private SidebarButton? _nutDangChon;
        private Control? _controlHienTai;

        public FrmMain()
        {
            InitializeComponent();
            if (this.pnlWelcome != null)
            {
                this.pnlWelcome.Resize += (s, e) => CanChinhLayoutWelcome();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                TaiLogo();

                var nd = Quyen.HienTai;
                this.lblNguoiDung.Text = "  " + nd.TenHienThi + "   |   " + nd.VaiTroText + "  ";
                CenNguoiDung();

                // Cập nhật lời chào mừng tương ứng với từng tài khoản/vai trò
                CapNhatLoiChao(nd);

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

                // Mở trang Tổng quan mặc định
                if (Quyen.HienTai.VaiTro == VaiTro.GV)
                {
                    this.btnNavLichDay.Visible = true;
                    this.btnNavDiemDanh.Visible = true;
                    this.btnNavThongKe.Visible = true;
                    this.btnNavThongBao.Visible = true;
                    this.btnNavThongTinCaNhan.Visible = true;
                }
                else
                {
                    this.btnNavLichDay.Visible = false;
                    this.btnNavDiemDanh.Visible = false;
                    this.btnNavThongKe.Visible = false;
                    this.btnNavThongBao.Visible = false;
                    this.btnNavThongTinCaNhan.Visible = false;
                }

                if (Quyen.HienTai.VaiTro == VaiTro.SV)
                {
                    this.btnNavLichHoc.Visible = true;
                    this.btnNavDiemDanhSV.Visible = true;
                    this.btnNavThongKeSV.Visible = true;
                    this.btnNavThongBaoSV.Visible = true;
                    this.btnNavThongTinCaNhanSV.Visible = true;
                }
                else
                {
                    this.btnNavLichHoc.Visible = false;
                    this.btnNavDiemDanhSV.Visible = false;
                    this.btnNavThongKeSV.Visible = false;
                    this.btnNavThongBaoSV.Visible = false;
                    this.btnNavThongTinCaNhanSV.Visible = false;
                }

                // Mở Dashboard mặc định
                DenTrangDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>In ra lời chào riêng biệt theo từng đối tượng tài khoản (Sinh viên, Giảng viên, Khoa, PGV).</summary>
        private void CapNhatLoiChao(NguoiDung nd)
        {
            if (nd.VaiTro == VaiTro.SV)
            {
                this.lblWelcomeHello.Text = $"Xin chào Sinh viên {nd.TenHienThi}!";
                this.lblWelcomeSub.Text = "Chào mừng bạn đến với Cổng thông tin sinh viên — Trường Đại học Giao thông Vận tải (UTC).";
                this.lblWelcomeRole.Text = $"Tài khoản: {nd.TenDangNhap}   |   Vai trò: Sinh viên";
                this.lblWelcomeTip.Text = "💡 Hướng dẫn: Bạn hãy chọn 'Bảng điểm cá nhân' ở thanh menu bên trái để tra cứu kết quả học tập.";
            }
            else if (nd.VaiTro == VaiTro.GV)
            {
                string tenGv = nd.TenHienThi.StartsWith("GV ") ? nd.TenHienThi.Substring(3).Trim() : nd.TenHienThi;
                this.lblWelcomeHello.Text = $"Xin chào Giảng viên {tenGv}!";
                this.lblWelcomeSub.Text = "Chào mừng Giảng viên đến với Cổng thông tin đào tạo — Trường Đại học Giao thông Vận tải (UTC).";
                this.lblWelcomeRole.Text = $"Tài khoản: {nd.TenDangNhap}   |   Vai trò: Giảng viên";
                this.lblWelcomeTip.Text = "💡 Hướng dẫn: Giảng viên chọn 'Lớp tín chỉ' hoặc 'Nhập điểm' ở menu bên trái để thực hiện quản lý điểm số.";
            }
            else if (nd.VaiTro == VaiTro.KHOA)
            {
                this.lblWelcomeHello.Text = $"Xin chào Ban chủ nhiệm {nd.TenHienThi}!";
                this.lblWelcomeSub.Text = "Hệ thống quản lý đào tạo cấp Khoa — Trường Đại học Giao thông Vận tải (UTC).";
                this.lblWelcomeRole.Text = $"Tài khoản: {nd.TenDangNhap}   |   Vai trò: Quản lý Khoa";
                this.lblWelcomeTip.Text = "💡 Hướng dẫn: Chọn các chức năng Lớp học, Sinh viên, Môn học bên trái để quản lý danh mục khoa.";
            }
            else
            {
                this.lblWelcomeHello.Text = $"Xin chào, {nd.TenHienThi}!";
                this.lblWelcomeSub.Text = "Hệ thống Quản trị đào tạo & Quản lý sinh viên theo tín chỉ — UTC Portal.";
                this.lblWelcomeRole.Text = $"Tài khoản: {nd.TenDangNhap}   |   Vai trò: {nd.VaiTroText}";
                this.lblWelcomeTip.Text = "💡 Hướng dẫn: Bạn có toàn quyền quản trị và thiết lập danh mục ở menu bên trái.";
            }
        }
        // ── Menu giao diện minh hoạ (chỉ dành cho giảng viên) ──────────────
        private void MoGiaoDienDangPhatTrien(string tieuDe, SidebarButton nut)
        {
            try
            {
                DatActiveNut(nut);
                this.lblPageTitle.Text = tieuDe;

                XoaControlHienTai(giu: false);
                if (this.pnlWelcome != null)
                    this.pnlWelcome.Visible = false;

                var lbl = new Label
                {
                    Text = "Chức năng đang phát triển. Vui lòng chờ các bản cập nhật mới.",
                    Dock = DockStyle.Fill,
                    Font = new Font(Palette.FontFamily, 14F, FontStyle.Italic),
                    ForeColor = Palette.Muted,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Palette.Canvas
                };
                this.pnlContent.Controls.Add(lbl);
                _controlHienTai = lbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnNavLichDay_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Lịch giảng dạy", this.btnNavLichDay);
        private void btnNavDiemDanh_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Điểm danh sinh viên", this.btnNavDiemDanh);
        private void btnNavThongKe_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thống kê kết quả", this.btnNavThongKe);
        private void btnNavThongBao_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thông báo", this.btnNavThongBao);
        private void btnNavThongTinCaNhan_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thông tin cá nhân", this.btnNavThongTinCaNhan);

        private void btnNavLichHoc_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Lịch học", this.btnNavLichHoc);
        private void btnNavDiemDanhSV_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Điểm danh", this.btnNavDiemDanhSV);
        private void btnNavThongKeSV_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thống kê kết quả", this.btnNavThongKeSV);
        private void btnNavThongBaoSV_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thông báo", this.btnNavThongBaoSV);
        private void btnNavThongTinCaNhanSV_Click(object sender, EventArgs e) => MoGiaoDienDangPhatTrien("Thông tin cá nhân", this.btnNavThongTinCaNhanSV);

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

        /// <summary>Chuyển sang trang Tổng quan chào mừng được kéo thả trong Designer.</summary>
        private void DenTrangDashboard()
        {
            try
            {
                DatActiveNut(this.btnNavDashboard);
                this.lblPageTitle.Text = "Tổng quan";

                // Xóa form con đang hiển thị
                XoaControlHienTai(giu: false);

                // Hiển thị panel chào mừng
                if (this.pnlWelcome != null)
                {
                    this.pnlWelcome.Visible = true;
                    this.pnlWelcome.BringToFront();
                    CanChinhLayoutWelcome();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở tổng quan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Tự động căn chỉnh hai thẻ pnlWelcomeCard và pnlInfoCard phủ 100% chiều rộng màn hình, không bị cắt xén chữ.</summary>
        private void CanChinhLayoutWelcome()
        {
            if (this.pnlWelcome == null || this.pnlWelcomeCard == null || this.pnlInfoCard == null) return;

            int padding = 35;
            int cardWidth = this.pnlWelcome.ClientSize.Width - (padding * 2);
            if (cardWidth < 600) cardWidth = 600;

            this.pnlWelcomeCard.Left = padding;
            this.pnlWelcomeCard.Top = 30;
            this.pnlWelcomeCard.Width = cardWidth;

            if (this.pnlWelcomeDivider != null)
            {
                this.pnlWelcomeDivider.Left = 36;
                this.pnlWelcomeDivider.Width = Math.Max(200, this.pnlWelcomeCard.ClientSize.Width - 72);
            }

            this.pnlInfoCard.Left = padding;
            this.pnlInfoCard.Top = this.pnlWelcomeCard.Bottom + 25;
            this.pnlInfoCard.Width = cardWidth;
        }

        /// <summary>
        /// Nhúng Form con vào pnlContent với TopLevel=false.
        /// </summary>
        private void DenTrangForm(string tieuDe, SidebarButton nut, Func<Form> taoForm)
        {
            try
            {
                DatActiveNut(nut);
                this.lblPageTitle.Text = tieuDe;

                // Xóa form con hiện tại
                XoaControlHienTai(giu: false);

                // Ẩn panel chào mừng
                if (this.pnlWelcome != null)
                {
                    this.pnlWelcome.Visible = false;
                }

                // Tạo form mới, nhúng vào content panel
                var form = taoForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.BackColor = Palette.Canvas;
                form.Padding = new Padding(20, 16, 20, 8);

                this.pnlContent.Controls.Add(form);
                form.Show();
                form.BringToFront();
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
            if (_controlHienTai == this.pnlWelcome) return;

            this.pnlContent.Controls.Remove(_controlHienTai);
            if (!giu) _controlHienTai.Dispose();
            _controlHienTai = null;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                var logo = LayHinhAnh("LogoUTC.png") ?? LayHinhAnh("logo_login.png");
                if (logo != null && this.picLogo != null)
                {
                    this.picLogo.Image = logo;
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
                    Path.Combine(Directory.GetCurrentDirectory(), "Resources", "img", tenTep)
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
