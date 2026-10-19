namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmDiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblDiemQuaTrinh;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label lblDiemTongKet;
        private System.Windows.Forms.TextBox txtDiemTongKet;
        private System.Windows.Forms.Label lblDiemChu;
        private System.Windows.Forms.TextBox txtDiemChu;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblLocSV;
        private System.Windows.Forms.ComboBox cboLocSV;
        private System.Windows.Forms.Button btnTatCaDiem;

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
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.txtDiemChu = new System.Windows.Forms.TextBox();
            this.lblDiemChu = new System.Windows.Forms.Label();
            this.txtDiemTongKet = new System.Windows.Forms.TextBox();
            this.lblDiemTongKet = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.lblDiemQuaTrinh = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.btnTatCaDiem = new System.Windows.Forms.Button();
            this.cboLocSV = new System.Windows.Forms.ComboBox();
            this.lblLocSV = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.pnlLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1050, 50);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1050, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ ĐIỂM VÀ KẾT QUẢ HỌC TẬP";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlChucNang.Controls.Add(this.btnThoat);
            this.pnlChucNang.Controls.Add(this.btnXuatExcel);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 555);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1050, 56);
            this.pnlChucNang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(925, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(400, 10);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 36);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất &Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(260, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "T&hêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.BackColor = System.Drawing.Color.White;
            this.grbChiTiet.Controls.Add(this.btnHuy);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.btnTinhDiem);
            this.grbChiTiet.Controls.Add(this.txtDiemChu);
            this.grbChiTiet.Controls.Add(this.lblDiemChu);
            this.grbChiTiet.Controls.Add(this.txtDiemTongKet);
            this.grbChiTiet.Controls.Add(this.lblDiemTongKet);
            this.grbChiTiet.Controls.Add(this.txtDiemThi);
            this.grbChiTiet.Controls.Add(this.lblDiemThi);
            this.grbChiTiet.Controls.Add(this.txtDiemQuaTrinh);
            this.grbChiTiet.Controls.Add(this.lblDiemQuaTrinh);
            this.grbChiTiet.Controls.Add(this.cboMonHoc);
            this.grbChiTiet.Controls.Add(this.lblMonHoc);
            this.grbChiTiet.Controls.Add(this.cboSinhVien);
            this.grbChiTiet.Controls.Add(this.lblSinhVien);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbChiTiet.Location = new System.Drawing.Point(700, 50);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(350, 505);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Nhập và tính điểm học phần";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(220, 420);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 36);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(95, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 36);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "&Lưu điểm";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTinhDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhDiem.ForeColor = System.Drawing.Color.White;
            this.btnTinhDiem.Location = new System.Drawing.Point(125, 250);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(200, 32);
            this.btnTinhDiem.TabIndex = 12;
            this.btnTinhDiem.Text = "Tính điểm tổng kết";
            this.btnTinhDiem.UseVisualStyleBackColor = false;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // txtDiemChu
            // 
            this.txtDiemChu.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDiemChu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtDiemChu.ForeColor = System.Drawing.Color.Red;
            this.txtDiemChu.Location = new System.Drawing.Point(125, 355);
            this.txtDiemChu.Name = "txtDiemChu";
            this.txtDiemChu.ReadOnly = true;
            this.txtDiemChu.Size = new System.Drawing.Size(200, 27);
            this.txtDiemChu.TabIndex = 11;
            // 
            // lblDiemChu
            // 
            this.lblDiemChu.AutoSize = true;
            this.lblDiemChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemChu.ForeColor = System.Drawing.Color.Black;
            this.lblDiemChu.Location = new System.Drawing.Point(15, 360);
            this.lblDiemChu.Name = "lblDiemChu";
            this.lblDiemChu.Size = new System.Drawing.Size(61, 15);
            this.lblDiemChu.TabIndex = 10;
            this.lblDiemChu.Text = "Điểm chữ:";
            // 
            // txtDiemTongKet
            // 
            this.txtDiemTongKet.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDiemTongKet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtDiemTongKet.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDiemTongKet.Location = new System.Drawing.Point(125, 305);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.ReadOnly = true;
            this.txtDiemTongKet.Size = new System.Drawing.Size(200, 27);
            this.txtDiemTongKet.TabIndex = 9;
            // 
            // lblDiemTongKet
            // 
            this.lblDiemTongKet.AutoSize = true;
            this.lblDiemTongKet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemTongKet.ForeColor = System.Drawing.Color.Black;
            this.lblDiemTongKet.Location = new System.Drawing.Point(15, 310);
            this.lblDiemTongKet.Name = "lblDiemTongKet";
            this.lblDiemTongKet.Size = new System.Drawing.Size(85, 15);
            this.lblDiemTongKet.TabIndex = 8;
            this.lblDiemTongKet.Text = "Điểm tổng kết:";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiemThi.Location = new System.Drawing.Point(125, 205);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(200, 24);
            this.txtDiemThi.TabIndex = 7;
            this.txtDiemThi.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemThi.ForeColor = System.Drawing.Color.Black;
            this.lblDiemThi.Location = new System.Drawing.Point(15, 208);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(81, 15);
            this.lblDiemThi.TabIndex = 6;
            this.lblDiemThi.Text = "Điểm thi (70%):";
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(125, 155);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(200, 24);
            this.txtDiemQuaTrinh.TabIndex = 5;
            this.txtDiemQuaTrinh.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // lblDiemQuaTrinh
            // 
            this.lblDiemQuaTrinh.AutoSize = true;
            this.lblDiemQuaTrinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemQuaTrinh.ForeColor = System.Drawing.Color.Black;
            this.lblDiemQuaTrinh.Location = new System.Drawing.Point(15, 158);
            this.lblDiemQuaTrinh.Name = "lblDiemQuaTrinh";
            this.lblDiemQuaTrinh.Size = new System.Drawing.Size(84, 15);
            this.lblDiemQuaTrinh.TabIndex = 4;
            this.lblDiemQuaTrinh.Text = "Điểm QT (30%):";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(125, 100);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(200, 24);
            this.cboMonHoc.TabIndex = 3;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMonHoc.ForeColor = System.Drawing.Color.Black;
            this.lblMonHoc.Location = new System.Drawing.Point(15, 103);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(58, 15);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // cboSinhVien
            // 
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinhVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboSinhVien.FormattingEnabled = true;
            this.cboSinhVien.Location = new System.Drawing.Point(125, 45);
            this.cboSinhVien.Name = "cboSinhVien";
            this.cboSinhVien.Size = new System.Drawing.Size(200, 24);
            this.cboSinhVien.TabIndex = 1;
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSinhVien.ForeColor = System.Drawing.Color.Black;
            this.lblSinhVien.Location = new System.Drawing.Point(15, 48);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(58, 15);
            this.lblSinhVien.TabIndex = 0;
            this.lblSinhVien.Text = "Sinh viên:";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvDiem);
            this.grbDanhSach.Controls.Add(this.pnlLoc);
            this.grbDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbDanhSach.Location = new System.Drawing.Point(0, 50);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(695, 505);
            this.grbDanhSach.TabIndex = 3;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Bảng điểm sinh viên";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(3, 65);
            this.dgvDiem.MultiSelect = false;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(689, 437);
            this.dgvDiem.TabIndex = 1;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // pnlLoc
            // 
            this.pnlLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlLoc.Controls.Add(this.btnTatCaDiem);
            this.pnlLoc.Controls.Add(this.cboLocSV);
            this.pnlLoc.Controls.Add(this.lblLocSV);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(3, 20);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(689, 45);
            this.pnlLoc.TabIndex = 0;
            // 
            // btnTatCaDiem
            // 
            this.btnTatCaDiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTatCaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCaDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTatCaDiem.ForeColor = System.Drawing.Color.White;
            this.btnTatCaDiem.Location = new System.Drawing.Point(400, 8);
            this.btnTatCaDiem.Name = "btnTatCaDiem";
            this.btnTatCaDiem.Size = new System.Drawing.Size(120, 28);
            this.btnTatCaDiem.TabIndex = 2;
            this.btnTatCaDiem.Text = "Xem tất cả";
            this.btnTatCaDiem.UseVisualStyleBackColor = false;
            this.btnTatCaDiem.Click += new System.EventHandler(this.btnTatCaDiem_Click);
            // 
            // cboLocSV
            // 
            this.cboLocSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocSV.FormattingEnabled = true;
            this.cboLocSV.Location = new System.Drawing.Point(150, 11);
            this.cboLocSV.Name = "cboLocSV";
            this.cboLocSV.Size = new System.Drawing.Size(230, 23);
            this.cboLocSV.TabIndex = 1;
            this.cboLocSV.SelectedIndexChanged += new System.EventHandler(this.cboLocSV_SelectedIndexChanged);
            // 
            // lblLocSV
            // 
            this.lblLocSV.AutoSize = true;
            this.lblLocSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocSV.ForeColor = System.Drawing.Color.Black;
            this.lblLocSV.Location = new System.Drawing.Point(15, 15);
            this.lblLocSV.Name = "lblLocSV";
            this.lblLocSV.Size = new System.Drawing.Size(113, 15);
            this.lblLocSV.TabIndex = 0;
            this.lblLocSV.Text = "Lọc theo Sinh viên:";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(695, 50);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 505);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 611);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "frmDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Điểm & Tra cứu Kết quả học tập";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlChucNang.ResumeLayout(false);
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
