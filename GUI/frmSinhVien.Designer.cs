namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmSinhVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Splitter spliterPhai;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Splitter spliterTren;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ErrorProvider errChiTiet;

        // Chi tiết controls
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoDem;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        // Tìm kiếm controls
        private System.Windows.Forms.Label lblTKMaSV;
        private System.Windows.Forms.TextBox txtTKMaSV;
        private System.Windows.Forms.Label lblTKHoTen;
        private System.Windows.Forms.TextBox txtTKHoTen;
        private System.Windows.Forms.Label lblTKLop;
        private System.Windows.Forms.ComboBox cboTKLop;
        private System.Windows.Forms.Label lblTKKhoa;
        private System.Windows.Forms.ComboBox cboTKKhoa;
        private System.Windows.Forms.Button btnThucHienTK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.lblHoDem = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.spliterPhai = new System.Windows.Forms.Splitter();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnThucHienTK = new System.Windows.Forms.Button();
            this.cboTKKhoa = new System.Windows.Forms.ComboBox();
            this.lblTKKhoa = new System.Windows.Forms.Label();
            this.cboTKLop = new System.Windows.Forms.ComboBox();
            this.lblTKLop = new System.Windows.Forms.Label();
            this.txtTKHoTen = new System.Windows.Forms.TextBox();
            this.lblTKHoTen = new System.Windows.Forms.Label();
            this.txtTKMaSV = new System.Windows.Forms.TextBox();
            this.lblTKMaSV = new System.Windows.Forms.Label();
            this.spliterTren = new System.Windows.Forms.Splitter();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTieuDe (1)
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1184, 50);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1184, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChucNang (2)
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.pnlChucNang.Controls.Add(this.btnThoat);
            this.pnlChucNang.Controls.Add(this.btnXuatExcel);
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.btnTimKiem);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 661);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1184, 60);
            this.pnlChucNang.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(20, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 36);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(145, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "T&hêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(270, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(395, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Teal;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(520, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 36);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(645, 12);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 36);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất &Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1054, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbChiTiet (3)
            // 
            this.grbChiTiet.BackColor = System.Drawing.Color.White;
            this.grbChiTiet.Controls.Add(this.btnHuy);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.btnChonAnh);
            this.grbChiTiet.Controls.Add(this.picAvatar);
            this.grbChiTiet.Controls.Add(this.cboLop);
            this.grbChiTiet.Controls.Add(this.lblLop);
            this.grbChiTiet.Controls.Add(this.txtEmail);
            this.grbChiTiet.Controls.Add(this.lblEmail);
            this.grbChiTiet.Controls.Add(this.txtSoDienThoai);
            this.grbChiTiet.Controls.Add(this.lblSoDienThoai);
            this.grbChiTiet.Controls.Add(this.txtQueQuan);
            this.grbChiTiet.Controls.Add(this.lblQueQuan);
            this.grbChiTiet.Controls.Add(this.rdoNu);
            this.grbChiTiet.Controls.Add(this.rdoNam);
            this.grbChiTiet.Controls.Add(this.lblGioiTinh);
            this.grbChiTiet.Controls.Add(this.dtpNgaySinh);
            this.grbChiTiet.Controls.Add(this.lblNgaySinh);
            this.grbChiTiet.Controls.Add(this.txtTen);
            this.grbChiTiet.Controls.Add(this.lblTen);
            this.grbChiTiet.Controls.Add(this.txtHoDem);
            this.grbChiTiet.Controls.Add(this.lblHoDem);
            this.grbChiTiet.Controls.Add(this.txtMaSV);
            this.grbChiTiet.Controls.Add(this.lblMaSV);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbChiTiet.Location = new System.Drawing.Point(834, 50);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(350, 611);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết sinh viên";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(225, 550);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(105, 550);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 36);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonAnh.Location = new System.Drawing.Point(235, 120);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(90, 26);
            this.btnChonAnh.TabIndex = 20;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(235, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 90);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 19;
            this.picAvatar.TabStop = false;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(105, 495);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(220, 24);
            this.cboLop.TabIndex = 18;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.ForeColor = System.Drawing.Color.Black;
            this.lblLop.Location = new System.Drawing.Point(15, 498);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(53, 15);
            this.lblLop.TabIndex = 17;
            this.lblLop.Text = "Lớp học:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(105, 445);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 24);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(15, 448);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(105, 395);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(220, 24);
            this.txtSoDienThoai.TabIndex = 14;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoai.Location = new System.Drawing.Point(15, 398);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(79, 15);
            this.lblSoDienThoai.TabIndex = 13;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtQueQuan.Location = new System.Drawing.Point(105, 345);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(220, 24);
            this.txtQueQuan.TabIndex = 12;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQueQuan.ForeColor = System.Drawing.Color.Black;
            this.lblQueQuan.Location = new System.Drawing.Point(15, 348);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(62, 15);
            this.lblQueQuan.TabIndex = 11;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoNu.ForeColor = System.Drawing.Color.Black;
            this.rdoNu.Location = new System.Drawing.Point(180, 298);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(41, 19);
            this.rdoNu.TabIndex = 10;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoNam.ForeColor = System.Drawing.Color.Black;
            this.rdoNam.Location = new System.Drawing.Point(105, 298);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(51, 19);
            this.rdoNam.TabIndex = 9;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 300);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(105, 245);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 24);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 250);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTen.Location = new System.Drawing.Point(105, 195);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(220, 24);
            this.txtTen.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(15, 198);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 15);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên:";
            // 
            // txtHoDem
            // 
            this.txtHoDem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoDem.Location = new System.Drawing.Point(105, 145);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(220, 24);
            this.txtHoDem.TabIndex = 3;
            // 
            // lblHoDem
            // 
            this.lblHoDem.AutoSize = true;
            this.lblHoDem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoDem.ForeColor = System.Drawing.Color.Black;
            this.lblHoDem.Location = new System.Drawing.Point(15, 148);
            this.lblHoDem.Name = "lblHoDem";
            this.lblHoDem.Size = new System.Drawing.Size(53, 15);
            this.lblHoDem.TabIndex = 2;
            this.lblHoDem.Text = "Họ đệm:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSV.Location = new System.Drawing.Point(105, 45);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(115, 24);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSV.ForeColor = System.Drawing.Color.Black;
            this.lblMaSV.Location = new System.Drawing.Point(15, 48);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(43, 15);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // spliterPhai
            // 
            this.spliterPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.spliterPhai.Location = new System.Drawing.Point(829, 50);
            this.spliterPhai.Name = "spliterPhai";
            this.spliterPhai.Size = new System.Drawing.Size(5, 611);
            this.spliterPhai.TabIndex = 3;
            this.spliterPhai.TabStop = false;
            // 
            // grbTimKiem (4)
            // 
            this.grbTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.grbTimKiem.Controls.Add(this.btnThucHienTK);
            this.grbTimKiem.Controls.Add(this.cboTKKhoa);
            this.grbTimKiem.Controls.Add(this.lblTKKhoa);
            this.grbTimKiem.Controls.Add(this.cboTKLop);
            this.grbTimKiem.Controls.Add(this.lblTKLop);
            this.grbTimKiem.Controls.Add(this.txtTKHoTen);
            this.grbTimKiem.Controls.Add(this.lblTKHoTen);
            this.grbTimKiem.Controls.Add(this.txtTKMaSV);
            this.grbTimKiem.Controls.Add(this.lblTKMaSV);
            this.grbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbTimKiem.Location = new System.Drawing.Point(0, 50);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(829, 90);
            this.grbTimKiem.TabIndex = 4;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Bộ lọc và Tìm kiếm sinh viên";
            // 
            // btnThucHienTK
            // 
            this.btnThucHienTK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThucHienTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucHienTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHienTK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThucHienTK.ForeColor = System.Drawing.Color.White;
            this.btnThucHienTK.Location = new System.Drawing.Point(715, 30);
            this.btnThucHienTK.Name = "btnThucHienTK";
            this.btnThucHienTK.Size = new System.Drawing.Size(95, 36);
            this.btnThucHienTK.TabIndex = 8;
            this.btnThucHienTK.Text = "Lọc dữ liệu";
            this.btnThucHienTK.UseVisualStyleBackColor = false;
            this.btnThucHienTK.Click += new System.EventHandler(this.btnThucHienTK_Click);
            // 
            // cboTKKhoa
            // 
            this.cboTKKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTKKhoa.FormattingEnabled = true;
            this.cboTKKhoa.Location = new System.Drawing.Point(545, 45);
            this.cboTKKhoa.Name = "cboTKKhoa";
            this.cboTKKhoa.Size = new System.Drawing.Size(150, 23);
            this.cboTKKhoa.TabIndex = 7;
            this.cboTKKhoa.SelectedIndexChanged += new System.EventHandler(this.cboTKKhoa_SelectedIndexChanged);
            // 
            // lblTKKhoa
            // 
            this.lblTKKhoa.AutoSize = true;
            this.lblTKKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTKKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblTKKhoa.Location = new System.Drawing.Point(545, 25);
            this.lblTKKhoa.Name = "lblTKKhoa";
            this.lblTKKhoa.Size = new System.Drawing.Size(68, 15);
            this.lblTKKhoa.TabIndex = 6;
            this.lblTKKhoa.Text = "Theo Khoa:";
            // 
            // cboTKLop
            // 
            this.cboTKLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTKLop.FormattingEnabled = true;
            this.cboTKLop.Location = new System.Drawing.Point(375, 45);
            this.cboTKLop.Name = "cboTKLop";
            this.cboTKLop.Size = new System.Drawing.Size(150, 23);
            this.cboTKLop.TabIndex = 5;
            this.cboTKLop.SelectedIndexChanged += new System.EventHandler(this.cboTKLop_SelectedIndexChanged);
            // 
            // lblTKLop
            // 
            this.lblTKLop.AutoSize = true;
            this.lblTKLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTKLop.ForeColor = System.Drawing.Color.Black;
            this.lblTKLop.Location = new System.Drawing.Point(375, 25);
            this.lblTKLop.Name = "lblTKLop";
            this.lblTKLop.Size = new System.Drawing.Size(60, 15);
            this.lblTKLop.TabIndex = 4;
            this.lblTKLop.Text = "Theo Lớp:";
            // 
            // txtTKHoTen
            // 
            this.txtTKHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTKHoTen.Location = new System.Drawing.Point(180, 45);
            this.txtTKHoTen.Name = "txtTKHoTen";
            this.txtTKHoTen.Size = new System.Drawing.Size(175, 23);
            this.txtTKHoTen.TabIndex = 3;
            // 
            // lblTKHoTen
            // 
            this.lblTKHoTen.AutoSize = true;
            this.lblTKHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTKHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblTKHoTen.Location = new System.Drawing.Point(180, 25);
            this.lblTKHoTen.Name = "lblTKHoTen";
            this.lblTKHoTen.Size = new System.Drawing.Size(61, 15);
            this.lblTKHoTen.TabIndex = 2;
            this.lblTKHoTen.Text = "Họ và tên:";
            // 
            // txtTKMaSV
            // 
            this.txtTKMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTKMaSV.Location = new System.Drawing.Point(20, 45);
            this.txtTKMaSV.Name = "txtTKMaSV";
            this.txtTKMaSV.Size = new System.Drawing.Size(140, 23);
            this.txtTKMaSV.TabIndex = 1;
            // 
            // lblTKMaSV
            // 
            this.lblTKMaSV.AutoSize = true;
            this.lblTKMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTKMaSV.ForeColor = System.Drawing.Color.Black;
            this.lblTKMaSV.Location = new System.Drawing.Point(20, 25);
            this.lblTKMaSV.Name = "lblTKMaSV";
            this.lblTKMaSV.Size = new System.Drawing.Size(77, 15);
            this.lblTKMaSV.TabIndex = 0;
            this.lblTKMaSV.Text = "Mã sinh viên:";
            // 
            // spliterTren
            // 
            this.spliterTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.spliterTren.Location = new System.Drawing.Point(0, 140);
            this.spliterTren.Name = "spliterTren";
            this.spliterTren.Size = new System.Drawing.Size(829, 5);
            this.spliterTren.TabIndex = 5;
            this.spliterTren.TabStop = false;
            // 
            // grbKetQua (5)
            // 
            this.grbKetQua.Controls.Add(this.dgvSinhVien);
            this.grbKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbKetQua.Location = new System.Drawing.Point(0, 145);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(829, 516);
            this.grbKetQua.TabIndex = 6;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Danh sách sinh viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 20);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(823, 493);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // errChiTiet
            // 
            this.errChiTiet.ContainerControl = this;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.spliterTren);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.spliterPhai);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên - Môn LTTQ";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlChucNang.ResumeLayout(false);
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
