namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.NumericUpDown numSoTinChi;
        private System.Windows.Forms.Label lblSoTietLT;
        private System.Windows.Forms.NumericUpDown numSoTietLT;
        private System.Windows.Forms.Label lblSoTietTH;
        private System.Windows.Forms.NumericUpDown numSoTietTH;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.NumericUpDown numHocKy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Splitter splitter;

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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.numHocKy = new System.Windows.Forms.NumericUpDown();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.numSoTietTH = new System.Windows.Forms.NumericUpDown();
            this.lblSoTietTH = new System.Windows.Forms.Label();
            this.numSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.lblSoTietLT = new System.Windows.Forms.Label();
            this.numSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(950, 50);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(950, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ DANH MỤC MÔN HỌC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlChucNang.Controls.Add(this.btnThoat);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 505);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(950, 56);
            this.pnlChucNang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(825, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(260, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
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
            this.btnSua.Size = new System.Drawing.Size(100, 36);
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
            this.btnThem.Size = new System.Drawing.Size(100, 36);
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
            this.grbChiTiet.Controls.Add(this.numHocKy);
            this.grbChiTiet.Controls.Add(this.lblHocKy);
            this.grbChiTiet.Controls.Add(this.numSoTietTH);
            this.grbChiTiet.Controls.Add(this.lblSoTietTH);
            this.grbChiTiet.Controls.Add(this.numSoTietLT);
            this.grbChiTiet.Controls.Add(this.lblSoTietLT);
            this.grbChiTiet.Controls.Add(this.numSoTinChi);
            this.grbChiTiet.Controls.Add(this.lblSoTinChi);
            this.grbChiTiet.Controls.Add(this.txtTenMH);
            this.grbChiTiet.Controls.Add(this.lblTenMH);
            this.grbChiTiet.Controls.Add(this.txtMaMH);
            this.grbChiTiet.Controls.Add(this.lblMaMH);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbChiTiet.Location = new System.Drawing.Point(630, 50);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(320, 455);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết môn học";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(190, 390);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 34);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(75, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 34);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // numHocKy
            // 
            this.numHocKy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numHocKy.Location = new System.Drawing.Point(115, 310);
            this.numHocKy.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numHocKy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHocKy.Name = "numHocKy";
            this.numHocKy.Size = new System.Drawing.Size(175, 24);
            this.numHocKy.TabIndex = 11;
            this.numHocKy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHocKy.ForeColor = System.Drawing.Color.Black;
            this.lblHocKy.Location = new System.Drawing.Point(15, 313);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(47, 15);
            this.lblHocKy.TabIndex = 10;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // numSoTietTH
            // 
            this.numSoTietTH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoTietTH.Location = new System.Drawing.Point(115, 255);
            this.numSoTietTH.Name = "numSoTietTH";
            this.numSoTietTH.Size = new System.Drawing.Size(175, 24);
            this.numSoTietTH.TabIndex = 9;
            this.numSoTietTH.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblSoTietTH
            // 
            this.lblSoTietTH.AutoSize = true;
            this.lblSoTietTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTietTH.ForeColor = System.Drawing.Color.Black;
            this.lblSoTietTH.Location = new System.Drawing.Point(15, 258);
            this.lblSoTietTH.Name = "lblSoTietTH";
            this.lblSoTietTH.Size = new System.Drawing.Size(65, 15);
            this.lblSoTietTH.TabIndex = 8;
            this.lblSoTietTH.Text = "Số tiết TH:";
            // 
            // numSoTietLT
            // 
            this.numSoTietLT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoTietLT.Location = new System.Drawing.Point(115, 200);
            this.numSoTietLT.Name = "numSoTietLT";
            this.numSoTietLT.Size = new System.Drawing.Size(175, 24);
            this.numSoTietLT.TabIndex = 7;
            this.numSoTietLT.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblSoTietLT
            // 
            this.lblSoTietLT.AutoSize = true;
            this.lblSoTietLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTietLT.ForeColor = System.Drawing.Color.Black;
            this.lblSoTietLT.Location = new System.Drawing.Point(15, 203);
            this.lblSoTietLT.Name = "lblSoTietLT";
            this.lblSoTietLT.Size = new System.Drawing.Size(62, 15);
            this.lblSoTietLT.TabIndex = 6;
            this.lblSoTietLT.Text = "Số tiết LT:";
            // 
            // numSoTinChi
            // 
            this.numSoTinChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoTinChi.Location = new System.Drawing.Point(115, 145);
            this.numSoTinChi.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numSoTinChi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(175, 24);
            this.numSoTinChi.TabIndex = 5;
            this.numSoTinChi.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTinChi.ForeColor = System.Drawing.Color.Black;
            this.lblSoTinChi.Location = new System.Drawing.Point(15, 148);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(60, 15);
            this.lblSoTinChi.TabIndex = 4;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenMH.Location = new System.Drawing.Point(115, 90);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(175, 24);
            this.txtTenMH.TabIndex = 3;
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenMH.ForeColor = System.Drawing.Color.Black;
            this.lblTenMH.Location = new System.Drawing.Point(15, 93);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(80, 15);
            this.lblTenMH.TabIndex = 2;
            this.lblTenMH.Text = "Tên môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaMH.Location = new System.Drawing.Point(115, 35);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(175, 24);
            this.txtMaMH.TabIndex = 1;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaMH.ForeColor = System.Drawing.Color.Black;
            this.lblMaMH.Location = new System.Drawing.Point(15, 38);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(78, 15);
            this.lblMaMH.TabIndex = 0;
            this.lblMaMH.Text = "Mã môn học:";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvMonHoc);
            this.grbDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grbDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbDanhSach.Location = new System.Drawing.Point(0, 50);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(625, 455);
            this.grbDanhSach.TabIndex = 3;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(3, 20);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(619, 432);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(625, 50);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 455);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 561);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlChucNang.ResumeLayout(false);
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
