namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmLopKhoa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLop;
        private System.Windows.Forms.TabPage tabKhoa;

        // Tab Lop
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.GroupBox grbChiTietLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.Label lblKhoaCuaLop;
        private System.Windows.Forms.ComboBox cboKhoaCuaLop;
        private System.Windows.Forms.Panel pnlBtnLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnLuuLop;
        private System.Windows.Forms.Button btnHuyLop;

        // Tab Khoa
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.GroupBox grbChiTietKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblVanPhong;
        private System.Windows.Forms.TextBox txtVanPhong;
        private System.Windows.Forms.Label lblSDTKhoa;
        private System.Windows.Forms.TextBox txtSDTKhoa;
        private System.Windows.Forms.Panel pnlBtnKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnLuuKhoa;
        private System.Windows.Forms.Button btnHuyKhoa;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLop = new System.Windows.Forms.TabPage();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.pnlBtnLop = new System.Windows.Forms.Panel();
            this.btnHuyLop = new System.Windows.Forms.Button();
            this.btnLuuLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.grbChiTietLop = new System.Windows.Forms.GroupBox();
            this.cboKhoaCuaLop = new System.Windows.Forms.ComboBox();
            this.lblKhoaCuaLop = new System.Windows.Forms.Label();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.tabKhoa = new System.Windows.Forms.TabPage();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.pnlBtnKhoa = new System.Windows.Forms.Panel();
            this.btnHuyKhoa = new System.Windows.Forms.Button();
            this.btnLuuKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.grbChiTietKhoa = new System.Windows.Forms.GroupBox();
            this.txtSDTKhoa = new System.Windows.Forms.TextBox();
            this.lblSDTKhoa = new System.Windows.Forms.Label();
            this.txtVanPhong = new System.Windows.Forms.TextBox();
            this.lblVanPhong = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.pnlTieuDe.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.pnlBtnLop.SuspendLayout();
            this.grbChiTietLop.SuspendLayout();
            this.tabKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.pnlBtnKhoa.SuspendLayout();
            this.grbChiTietKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(984, 50);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(984, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ LỚP HỌC VÀ KHOA VIỆN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLop);
            this.tabControl.Controls.Add(this.tabKhoa);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 561);
            this.tabControl.TabIndex = 1;
            // 
            // tabLop
            // 
            this.tabLop.Controls.Add(this.dgvLop);
            this.tabLop.Controls.Add(this.pnlBtnLop);
            this.tabLop.Controls.Add(this.grbChiTietLop);
            this.tabLop.Location = new System.Drawing.Point(4, 26);
            this.tabLop.Name = "tabLop";
            this.tabLop.Padding = new System.Windows.Forms.Padding(3);
            this.tabLop.Size = new System.Drawing.Size(976, 531);
            this.tabLop.TabIndex = 0;
            this.tabLop.Text = "Quản lý Lớp";
            this.tabLop.UseVisualStyleBackColor = true;
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(3, 113);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(970, 365);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // pnlBtnLop
            // 
            this.pnlBtnLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlBtnLop.Controls.Add(this.btnHuyLop);
            this.pnlBtnLop.Controls.Add(this.btnLuuLop);
            this.pnlBtnLop.Controls.Add(this.btnXoaLop);
            this.pnlBtnLop.Controls.Add(this.btnSuaLop);
            this.pnlBtnLop.Controls.Add(this.btnThemLop);
            this.pnlBtnLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnLop.Location = new System.Drawing.Point(3, 478);
            this.pnlBtnLop.Name = "pnlBtnLop";
            this.pnlBtnLop.Size = new System.Drawing.Size(970, 50);
            this.pnlBtnLop.TabIndex = 1;
            // 
            // btnHuyLop
            // 
            this.btnHuyLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuyLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyLop.ForeColor = System.Drawing.Color.White;
            this.btnHuyLop.Location = new System.Drawing.Point(540, 8);
            this.btnHuyLop.Name = "btnHuyLop";
            this.btnHuyLop.Size = new System.Drawing.Size(100, 34);
            this.btnHuyLop.TabIndex = 4;
            this.btnHuyLop.Text = "&Hủy";
            this.btnHuyLop.UseVisualStyleBackColor = false;
            this.btnHuyLop.Click += new System.EventHandler(this.btnHuyLop_Click);
            // 
            // btnLuuLop
            // 
            this.btnLuuLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuuLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuLop.ForeColor = System.Drawing.Color.White;
            this.btnLuuLop.Location = new System.Drawing.Point(420, 8);
            this.btnLuuLop.Name = "btnLuuLop";
            this.btnLuuLop.Size = new System.Drawing.Size(100, 34);
            this.btnLuuLop.TabIndex = 3;
            this.btnLuuLop.Text = "&Lưu";
            this.btnLuuLop.UseVisualStyleBackColor = false;
            this.btnLuuLop.Click += new System.EventHandler(this.btnLuuLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(260, 8);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(100, 34);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "&Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSuaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(140, 8);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(100, 34);
            this.btnSuaLop.TabIndex = 1;
            this.btnSuaLop.Text = "&Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = false;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(20, 8);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(100, 34);
            this.btnThemLop.TabIndex = 0;
            this.btnThemLop.Text = "T&hêm";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // grbChiTietLop
            // 
            this.grbChiTietLop.Controls.Add(this.cboKhoaCuaLop);
            this.grbChiTietLop.Controls.Add(this.lblKhoaCuaLop);
            this.grbChiTietLop.Controls.Add(this.txtKhoaHoc);
            this.grbChiTietLop.Controls.Add(this.lblKhoaHoc);
            this.grbChiTietLop.Controls.Add(this.txtTenLop);
            this.grbChiTietLop.Controls.Add(this.lblTenLop);
            this.grbChiTietLop.Controls.Add(this.txtMaLop);
            this.grbChiTietLop.Controls.Add(this.lblMaLop);
            this.grbChiTietLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChiTietLop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbChiTietLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbChiTietLop.Location = new System.Drawing.Point(3, 3);
            this.grbChiTietLop.Name = "grbChiTietLop";
            this.grbChiTietLop.Size = new System.Drawing.Size(970, 110);
            this.grbChiTietLop.TabIndex = 0;
            this.grbChiTietLop.TabStop = false;
            this.grbChiTietLop.Text = "Thông tin Lớp học";
            // 
            // cboKhoaCuaLop
            // 
            this.cboKhoaCuaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaCuaLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhoaCuaLop.FormattingEnabled = true;
            this.cboKhoaCuaLop.Location = new System.Drawing.Point(620, 65);
            this.cboKhoaCuaLop.Name = "cboKhoaCuaLop";
            this.cboKhoaCuaLop.Size = new System.Drawing.Size(250, 24);
            this.cboKhoaCuaLop.TabIndex = 7;
            // 
            // lblKhoaCuaLop
            // 
            this.lblKhoaCuaLop.AutoSize = true;
            this.lblKhoaCuaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhoaCuaLop.ForeColor = System.Drawing.Color.Black;
            this.lblKhoaCuaLop.Location = new System.Drawing.Point(530, 68);
            this.lblKhoaCuaLop.Name = "lblKhoaCuaLop";
            this.lblKhoaCuaLop.Size = new System.Drawing.Size(65, 15);
            this.lblKhoaCuaLop.TabIndex = 6;
            this.lblKhoaCuaLop.Text = "Thuộc Khoa:";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhoaHoc.Location = new System.Drawing.Point(620, 25);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(250, 24);
            this.txtKhoaHoc.TabIndex = 5;
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhoaHoc.ForeColor = System.Drawing.Color.Black;
            this.lblKhoaHoc.Location = new System.Drawing.Point(530, 28);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(59, 15);
            this.lblKhoaHoc.TabIndex = 4;
            this.lblKhoaHoc.Text = "Khóa học:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenLop.Location = new System.Drawing.Point(100, 65);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(380, 24);
            this.txtTenLop.TabIndex = 3;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenLop.ForeColor = System.Drawing.Color.Black;
            this.lblTenLop.Location = new System.Drawing.Point(20, 68);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(49, 15);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaLop.Location = new System.Drawing.Point(100, 25);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(200, 24);
            this.txtMaLop.TabIndex = 1;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaLop.ForeColor = System.Drawing.Color.Black;
            this.lblMaLop.Location = new System.Drawing.Point(20, 28);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(47, 15);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // tabKhoa
            // 
            this.tabKhoa.Controls.Add(this.dgvKhoa);
            this.tabKhoa.Controls.Add(this.pnlBtnKhoa);
            this.tabKhoa.Controls.Add(this.grbChiTietKhoa);
            this.tabKhoa.Location = new System.Drawing.Point(4, 26);
            this.tabKhoa.Name = "tabKhoa";
            this.tabKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoa.Size = new System.Drawing.Size(976, 531);
            this.tabKhoa.TabIndex = 1;
            this.tabKhoa.Text = "Quản lý Khoa / Viện";
            this.tabKhoa.UseVisualStyleBackColor = true;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoa.Location = new System.Drawing.Point(3, 113);
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersVisible = false;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(970, 365);
            this.dgvKhoa.TabIndex = 5;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // pnlBtnKhoa
            // 
            this.pnlBtnKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlBtnKhoa.Controls.Add(this.btnHuyKhoa);
            this.pnlBtnKhoa.Controls.Add(this.btnLuuKhoa);
            this.pnlBtnKhoa.Controls.Add(this.btnXoaKhoa);
            this.pnlBtnKhoa.Controls.Add(this.btnSuaKhoa);
            this.pnlBtnKhoa.Controls.Add(this.btnThemKhoa);
            this.pnlBtnKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnKhoa.Location = new System.Drawing.Point(3, 478);
            this.pnlBtnKhoa.Name = "pnlBtnKhoa";
            this.pnlBtnKhoa.Size = new System.Drawing.Size(970, 50);
            this.pnlBtnKhoa.TabIndex = 4;
            // 
            // btnHuyKhoa
            // 
            this.btnHuyKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuyKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyKhoa.ForeColor = System.Drawing.Color.White;
            this.btnHuyKhoa.Location = new System.Drawing.Point(540, 8);
            this.btnHuyKhoa.Name = "btnHuyKhoa";
            this.btnHuyKhoa.Size = new System.Drawing.Size(100, 34);
            this.btnHuyKhoa.TabIndex = 4;
            this.btnHuyKhoa.Text = "&Hủy";
            this.btnHuyKhoa.UseVisualStyleBackColor = false;
            this.btnHuyKhoa.Click += new System.EventHandler(this.btnHuyKhoa_Click);
            // 
            // btnLuuKhoa
            // 
            this.btnLuuKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKhoa.ForeColor = System.Drawing.Color.White;
            this.btnLuuKhoa.Location = new System.Drawing.Point(420, 8);
            this.btnLuuKhoa.Name = "btnLuuKhoa";
            this.btnLuuKhoa.Size = new System.Drawing.Size(100, 34);
            this.btnLuuKhoa.TabIndex = 3;
            this.btnLuuKhoa.Text = "&Lưu";
            this.btnLuuKhoa.UseVisualStyleBackColor = false;
            this.btnLuuKhoa.Click += new System.EventHandler(this.btnLuuKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoa.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoa.Location = new System.Drawing.Point(260, 8);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoaKhoa.TabIndex = 2;
            this.btnXoaKhoa.Text = "&Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = false;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSuaKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKhoa.ForeColor = System.Drawing.Color.White;
            this.btnSuaKhoa.Location = new System.Drawing.Point(140, 8);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(100, 34);
            this.btnSuaKhoa.TabIndex = 1;
            this.btnSuaKhoa.Text = "&Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = false;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoa.ForeColor = System.Drawing.Color.White;
            this.btnThemKhoa.Location = new System.Drawing.Point(20, 8);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(100, 34);
            this.btnThemKhoa.TabIndex = 0;
            this.btnThemKhoa.Text = "T&hêm";
            this.btnThemKhoa.UseVisualStyleBackColor = false;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // grbChiTietKhoa
            // 
            this.grbChiTietKhoa.Controls.Add(this.txtSDTKhoa);
            this.grbChiTietKhoa.Controls.Add(this.lblSDTKhoa);
            this.grbChiTietKhoa.Controls.Add(this.txtVanPhong);
            this.grbChiTietKhoa.Controls.Add(this.lblVanPhong);
            this.grbChiTietKhoa.Controls.Add(this.txtTenKhoa);
            this.grbChiTietKhoa.Controls.Add(this.lblTenKhoa);
            this.grbChiTietKhoa.Controls.Add(this.txtMaKhoa);
            this.grbChiTietKhoa.Controls.Add(this.lblMaKhoa);
            this.grbChiTietKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChiTietKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbChiTietKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbChiTietKhoa.Location = new System.Drawing.Point(3, 3);
            this.grbChiTietKhoa.Name = "grbChiTietKhoa";
            this.grbChiTietKhoa.Size = new System.Drawing.Size(970, 110);
            this.grbChiTietKhoa.TabIndex = 3;
            this.grbChiTietKhoa.TabStop = false;
            this.grbChiTietKhoa.Text = "Thông tin Khoa / Viện";
            // 
            // txtSDTKhoa
            // 
            this.txtSDTKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSDTKhoa.Location = new System.Drawing.Point(620, 65);
            this.txtSDTKhoa.Name = "txtSDTKhoa";
            this.txtSDTKhoa.Size = new System.Drawing.Size(250, 24);
            this.txtSDTKhoa.TabIndex = 7;
            // 
            // lblSDTKhoa
            // 
            this.lblSDTKhoa.AutoSize = true;
            this.lblSDTKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSDTKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblSDTKhoa.Location = new System.Drawing.Point(530, 68);
            this.lblSDTKhoa.Name = "lblSDTKhoa";
            this.lblSDTKhoa.Size = new System.Drawing.Size(79, 15);
            this.lblSDTKhoa.TabIndex = 6;
            this.lblSDTKhoa.Text = "Số điện thoại:";
            // 
            // txtVanPhong
            // 
            this.txtVanPhong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtVanPhong.Location = new System.Drawing.Point(620, 25);
            this.txtVanPhong.Name = "txtVanPhong";
            this.txtVanPhong.Size = new System.Drawing.Size(250, 24);
            this.txtVanPhong.TabIndex = 5;
            // 
            // lblVanPhong
            // 
            this.lblVanPhong.AutoSize = true;
            this.lblVanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVanPhong.ForeColor = System.Drawing.Color.Black;
            this.lblVanPhong.Location = new System.Drawing.Point(530, 28);
            this.lblVanPhong.Name = "lblVanPhong";
            this.lblVanPhong.Size = new System.Drawing.Size(68, 15);
            this.lblVanPhong.TabIndex = 4;
            this.lblVanPhong.Text = "Văn phòng:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenKhoa.Location = new System.Drawing.Point(100, 65);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(380, 24);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhoa.Location = new System.Drawing.Point(20, 68);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(58, 15);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên Khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaKhoa.Location = new System.Drawing.Point(100, 25);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(200, 24);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhoa.Location = new System.Drawing.Point(20, 28);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(56, 15);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã Khoa:";
            // 
            // frmLopKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "frmLopKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lớp học và Khoa Viện";
            this.Load += new System.EventHandler(this.frmLopKhoa_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.pnlBtnLop.ResumeLayout(false);
            this.grbChiTietLop.ResumeLayout(false);
            this.grbChiTietLop.PerformLayout();
            this.tabKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.pnlBtnKhoa.ResumeLayout(false);
            this.grbChiTietKhoa.ResumeLayout(false);
            this.grbChiTietKhoa.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
