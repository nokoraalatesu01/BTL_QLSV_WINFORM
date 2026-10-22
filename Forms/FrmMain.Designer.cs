#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmMain
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.sepHeThong = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaoTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopTinChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoanSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangDiemCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepTang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiaNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiaDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDongTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // statusStrip
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.TabIndex = 1;
            // lblNguoiDung
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Text = "";
            // menuStrip
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.MdiWindowListItem = this.mnuCuaSo;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.TabIndex = 0;
            // mnuHeThong
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Text = "Hệ thống";
            // mnuDoiMatKhau
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // mnuDangXuat
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // sepHeThong
            this.sepHeThong.Name = "sepHeThong";
            // mnuThoat
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // mnuDanhMuc
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Text = "Danh mục";
            // mnuKhoa
            this.mnuKhoa.Name = "mnuKhoa";
            this.mnuKhoa.Text = "Khoa";
            this.mnuKhoa.Click += new System.EventHandler(this.mnuKhoa_Click);
            // mnuLop
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // mnuSinhVien
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Text = "Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // mnuMonHoc
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Text = "Môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);
            // mnuGiangVien
            this.mnuGiangVien.Name = "mnuGiangVien";
            this.mnuGiangVien.Text = "Giảng viên";
            this.mnuGiangVien.Click += new System.EventHandler(this.mnuGiangVien_Click);
            // mnuDaoTao
            this.mnuDaoTao.Name = "mnuDaoTao";
            this.mnuDaoTao.Text = "Đào tạo";
            // mnuLopTinChi
            this.mnuLopTinChi.Name = "mnuLopTinChi";
            this.mnuLopTinChi.Text = "Lớp tín chỉ";
            this.mnuLopTinChi.Click += new System.EventHandler(this.mnuLopTinChi_Click);
            // mnuNhapDiem
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // mnuTaiKhoanSV
            this.mnuTaiKhoanSV.Name = "mnuTaiKhoanSV";
            this.mnuTaiKhoanSV.Text = "Sinh viên";
            // mnuBangDiemCaNhan
            this.mnuBangDiemCaNhan.Name = "mnuBangDiemCaNhan";
            this.mnuBangDiemCaNhan.Text = "Bảng điểm cá nhân";
            this.mnuBangDiemCaNhan.Click += new System.EventHandler(this.mnuBangDiemCaNhan_Click);
            // mnuCuaSo
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Text = "Cửa sổ";
            // mnuXepTang
            this.mnuXepTang.Name = "mnuXepTang";
            this.mnuXepTang.Text = "Xếp tầng";
            this.mnuXepTang.Click += new System.EventHandler(this.mnuXepTang_Click);
            // mnuChiaNgang
            this.mnuChiaNgang.Name = "mnuChiaNgang";
            this.mnuChiaNgang.Text = "Chia đôi ngang";
            this.mnuChiaNgang.Click += new System.EventHandler(this.mnuChiaNgang_Click);
            // mnuChiaDoc
            this.mnuChiaDoc.Name = "mnuChiaDoc";
            this.mnuChiaDoc.Text = "Chia đôi dọc";
            this.mnuChiaDoc.Click += new System.EventHandler(this.mnuChiaDoc_Click);
            // mnuDongTatCa
            this.mnuDongTatCa.Name = "mnuDongTatCa";
            this.mnuDongTatCa.Text = "Đóng tất cả";
            this.mnuDongTatCa.Click += new System.EventHandler(this.mnuDongTatCa_Click);
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Text = "Quản lý điểm sinh viên - QLDSV_HTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.statusStrip.Items.Add(this.lblNguoiDung);
            this.menuStrip.Items.Add(this.mnuHeThong);
            this.menuStrip.Items.Add(this.mnuDanhMuc);
            this.menuStrip.Items.Add(this.mnuDaoTao);
            this.menuStrip.Items.Add(this.mnuTaiKhoanSV);
            this.menuStrip.Items.Add(this.mnuCuaSo);
            this.mnuHeThong.DropDownItems.Add(this.mnuDoiMatKhau);
            this.mnuHeThong.DropDownItems.Add(this.mnuDangXuat);
            this.mnuHeThong.DropDownItems.Add(this.sepHeThong);
            this.mnuHeThong.DropDownItems.Add(this.mnuThoat);
            this.mnuDanhMuc.DropDownItems.Add(this.mnuKhoa);
            this.mnuDanhMuc.DropDownItems.Add(this.mnuLop);
            this.mnuDanhMuc.DropDownItems.Add(this.mnuSinhVien);
            this.mnuDanhMuc.DropDownItems.Add(this.mnuMonHoc);
            this.mnuDanhMuc.DropDownItems.Add(this.mnuGiangVien);
            this.mnuDaoTao.DropDownItems.Add(this.mnuLopTinChi);
            this.mnuDaoTao.DropDownItems.Add(this.mnuNhapDiem);
            this.mnuTaiKhoanSV.DropDownItems.Add(this.mnuBangDiemCaNhan);
            this.mnuCuaSo.DropDownItems.Add(this.mnuXepTang);
            this.mnuCuaSo.DropDownItems.Add(this.mnuChiaNgang);
            this.mnuCuaSo.DropDownItems.Add(this.mnuChiaDoc);
            this.mnuCuaSo.DropDownItems.Add(this.mnuDongTatCa);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDung;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator sepHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDaoTao;
        private System.Windows.Forms.ToolStripMenuItem mnuLopTinChi;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoanSV;
        private System.Windows.Forms.ToolStripMenuItem mnuBangDiemCaNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
        private System.Windows.Forms.ToolStripMenuItem mnuChiaNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuChiaDoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTatCa;
    }
}
