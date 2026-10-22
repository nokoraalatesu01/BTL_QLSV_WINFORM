#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmLopTinChi
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colMaLTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSVToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTim = new System.Windows.Forms.Panel();
            this.lblLocNienKhoa = new System.Windows.Forms.Label();
            this.cboLocNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblLocHocKy = new System.Windows.Forms.Label();
            this.cboLocHocKy = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblMaLTC = new System.Windows.Forms.Label();
            this.txtMaLTC = new System.Windows.Forms.TextBox();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.numHocKy = new System.Windows.Forms.NumericUpDown();
            this.lblNhom = new System.Windows.Forms.Label();
            this.numNhom = new System.Windows.Forms.NumericUpDown();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.lblSVToiThieu = new System.Windows.Forms.Label();
            this.numSVToiThieu = new System.Windows.Forms.NumericUpDown();
            this.lblHuyLop = new System.Windows.Forms.Label();
            this.chkHuyLop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSVToiThieu)).BeginInit();
            this.pnlTim.SuspendLayout();
            this.pnlNut.SuspendLayout();
            this.pnlNhap.SuspendLayout();
            this.SuspendLayout();
            // dgv
            this.dgv.Name = "dgv";
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.TabIndex = 3;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // colMaLTC
            this.colMaLTC.Name = "colMaLTC";
            this.colMaLTC.DataPropertyName = "MaLTC";
            this.colMaLTC.HeaderText = "Mã LTC";
            this.colMaLTC.FillWeight = 7F;
            this.colMaLTC.ReadOnly = true;
            // colNienKhoa
            this.colNienKhoa.Name = "colNienKhoa";
            this.colNienKhoa.DataPropertyName = "NienKhoa";
            this.colNienKhoa.HeaderText = "Niên khóa";
            this.colNienKhoa.FillWeight = 10F;
            this.colNienKhoa.ReadOnly = true;
            // colHocKy
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.FillWeight = 7F;
            this.colHocKy.ReadOnly = true;
            // colTenMH
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Môn học";
            this.colTenMH.FillWeight = 24F;
            this.colTenMH.ReadOnly = true;
            // colNhom
            this.colNhom.Name = "colNhom";
            this.colNhom.DataPropertyName = "Nhom";
            this.colNhom.HeaderText = "Nhóm";
            this.colNhom.FillWeight = 6F;
            this.colNhom.ReadOnly = true;
            // colTenGV
            this.colTenGV.Name = "colTenGV";
            this.colTenGV.DataPropertyName = "TenGV";
            this.colTenGV.HeaderText = "Giảng viên";
            this.colTenGV.FillWeight = 20F;
            this.colTenGV.ReadOnly = true;
            // colSoSV
            this.colSoSV.Name = "colSoSV";
            this.colSoSV.DataPropertyName = "SoSV";
            this.colSoSV.HeaderText = "Số SV";
            this.colSoSV.FillWeight = 7F;
            this.colSoSV.ReadOnly = true;
            // colSoSVToiThieu
            this.colSoSVToiThieu.Name = "colSoSVToiThieu";
            this.colSoSVToiThieu.DataPropertyName = "SoSVToiThieu";
            this.colSoSVToiThieu.HeaderText = "SV tối thiểu";
            this.colSoSVToiThieu.FillWeight = 10F;
            this.colSoSVToiThieu.ReadOnly = true;
            // colTrangThai
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.FillWeight = 10F;
            this.colTrangThai.ReadOnly = true;
            // statusStrip
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.TabIndex = 4;
            // lblTrangThai
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Sẵn sàng.";
            // pnlTim
            this.pnlTim.Name = "pnlTim";
            this.pnlTim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTim.Size = new System.Drawing.Size(1034, 44);
            this.pnlTim.TabIndex = 2;
            // lblLocNienKhoa
            this.lblLocNienKhoa.Name = "lblLocNienKhoa";
            this.lblLocNienKhoa.AutoSize = true;
            this.lblLocNienKhoa.Location = new System.Drawing.Point(10, 13);
            this.lblLocNienKhoa.Text = "Niên khóa:";
            this.lblLocNienKhoa.TabIndex = 23;
            // cboLocNienKhoa
            this.cboLocNienKhoa.Name = "cboLocNienKhoa";
            this.cboLocNienKhoa.Location = new System.Drawing.Point(98, 10);
            this.cboLocNienKhoa.TabIndex = 24;
            this.cboLocNienKhoa.Size = new System.Drawing.Size(120, 23);
            this.cboLocNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocNienKhoa.FormattingEnabled = true;
            // lblLocHocKy
            this.lblLocHocKy.Name = "lblLocHocKy";
            this.lblLocHocKy.AutoSize = true;
            this.lblLocHocKy.Location = new System.Drawing.Point(232, 13);
            this.lblLocHocKy.Text = "Học kỳ:";
            this.lblLocHocKy.TabIndex = 25;
            // cboLocHocKy
            this.cboLocHocKy.Name = "cboLocHocKy";
            this.cboLocHocKy.Location = new System.Drawing.Point(296, 10);
            this.cboLocHocKy.TabIndex = 26;
            this.cboLocHocKy.Size = new System.Drawing.Size(90, 23);
            this.cboLocHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocHocKy.FormattingEnabled = true;
            // btnLoc
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Location = new System.Drawing.Point(400, 6);
            this.btnLoc.Size = new System.Drawing.Size(100, 32);
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TabIndex = 27;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // pnlNut
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNut.Size = new System.Drawing.Size(1034, 44);
            this.pnlNut.TabIndex = 1;
            // btnNhapMoi
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Location = new System.Drawing.Point(10, 6);
            this.btnNhapMoi.Size = new System.Drawing.Size(100, 32);
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.TabIndex = 18;
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(118, 6);
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.TabIndex = 19;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(226, 6);
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.TabIndex = 20;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(334, 6);
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TabIndex = 21;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnTaiLai
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Location = new System.Drawing.Point(442, 6);
            this.btnTaiLai.Size = new System.Drawing.Size(100, 32);
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.TabIndex = 22;
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // pnlNhap
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Size = new System.Drawing.Size(1034, 188);
            this.pnlNhap.TabIndex = 0;
            // lblMaLTC
            this.lblMaLTC.Name = "lblMaLTC";
            this.lblMaLTC.AutoSize = true;
            this.lblMaLTC.Location = new System.Drawing.Point(10, 15);
            this.lblMaLTC.Text = "Mã lớp tín chỉ:";
            this.lblMaLTC.TabIndex = 0;
            // txtMaLTC
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Location = new System.Drawing.Point(140, 12);
            this.txtMaLTC.TabIndex = 1;
            this.txtMaLTC.Size = new System.Drawing.Size(260, 23);
            this.txtMaLTC.MaxLength = 10;
            this.txtMaLTC.ReadOnly = true;
            // lblNienKhoa
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(440, 15);
            this.lblNienKhoa.Text = "Niên khóa:";
            this.lblNienKhoa.TabIndex = 2;
            // txtNienKhoa
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Location = new System.Drawing.Point(570, 12);
            this.txtNienKhoa.TabIndex = 3;
            this.txtNienKhoa.Size = new System.Drawing.Size(300, 23);
            this.txtNienKhoa.MaxLength = 9;
            this.txtNienKhoa.PlaceholderText = "ví dụ 2023-2024";
            // lblHocKy
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(10, 49);
            this.lblHocKy.Text = "Học kỳ:";
            this.lblHocKy.TabIndex = 4;
            // numHocKy
            this.numHocKy.Name = "numHocKy";
            this.numHocKy.Location = new System.Drawing.Point(140, 46);
            this.numHocKy.TabIndex = 5;
            this.numHocKy.Size = new System.Drawing.Size(100, 23);
            this.numHocKy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHocKy.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numHocKy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // lblNhom
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.AutoSize = true;
            this.lblNhom.Location = new System.Drawing.Point(440, 49);
            this.lblNhom.Text = "Nhóm:";
            this.lblNhom.TabIndex = 6;
            // numNhom
            this.numNhom.Name = "numNhom";
            this.numNhom.Location = new System.Drawing.Point(570, 46);
            this.numNhom.TabIndex = 7;
            this.numNhom.Size = new System.Drawing.Size(100, 23);
            this.numNhom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNhom.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.numNhom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // lblMonHoc
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(10, 83);
            this.lblMonHoc.Text = "Môn học:";
            this.lblMonHoc.TabIndex = 8;
            // cboMonHoc
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Location = new System.Drawing.Point(140, 80);
            this.cboMonHoc.TabIndex = 9;
            this.cboMonHoc.Size = new System.Drawing.Size(260, 23);
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(440, 83);
            this.lblKhoa.Text = "Khoa mở lớp:";
            this.lblKhoa.TabIndex = 10;
            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(570, 80);
            this.cboKhoa.TabIndex = 11;
            this.cboKhoa.Size = new System.Drawing.Size(300, 23);
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // lblGiangVien
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(10, 117);
            this.lblGiangVien.Text = "Giảng viên:";
            this.lblGiangVien.TabIndex = 12;
            // cboGiangVien
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Location = new System.Drawing.Point(140, 114);
            this.cboGiangVien.TabIndex = 13;
            this.cboGiangVien.Size = new System.Drawing.Size(260, 23);
            this.cboGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiangVien.FormattingEnabled = true;
            // lblSVToiThieu
            this.lblSVToiThieu.Name = "lblSVToiThieu";
            this.lblSVToiThieu.AutoSize = true;
            this.lblSVToiThieu.Location = new System.Drawing.Point(440, 117);
            this.lblSVToiThieu.Text = "Số SV tối thiểu:";
            this.lblSVToiThieu.TabIndex = 14;
            // numSVToiThieu
            this.numSVToiThieu.Name = "numSVToiThieu";
            this.numSVToiThieu.Location = new System.Drawing.Point(570, 114);
            this.numSVToiThieu.TabIndex = 15;
            this.numSVToiThieu.Size = new System.Drawing.Size(100, 23);
            this.numSVToiThieu.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numSVToiThieu.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numSVToiThieu.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // lblHuyLop
            this.lblHuyLop.Name = "lblHuyLop";
            this.lblHuyLop.AutoSize = true;
            this.lblHuyLop.Location = new System.Drawing.Point(10, 151);
            this.lblHuyLop.Text = "Trạng thái:";
            this.lblHuyLop.TabIndex = 16;
            // chkHuyLop
            this.chkHuyLop.Name = "chkHuyLop";
            this.chkHuyLop.Location = new System.Drawing.Point(140, 148);
            this.chkHuyLop.TabIndex = 17;
            this.chkHuyLop.AutoSize = true;
            this.chkHuyLop.Text = "Hủy lớp";
            this.chkHuyLop.UseVisualStyleBackColor = true;
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý lớp tín chỉ";
            this.Name = "FrmLopTinChi";
            this.Load += new System.EventHandler(this.FrmLopTinChi_Load);
            this.Shown += new System.EventHandler(this.FrmLopTinChi_Shown);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.dgv.Columns.Add(this.colMaLTC);
            this.dgv.Columns.Add(this.colNienKhoa);
            this.dgv.Columns.Add(this.colHocKy);
            this.dgv.Columns.Add(this.colTenMH);
            this.dgv.Columns.Add(this.colNhom);
            this.dgv.Columns.Add(this.colTenGV);
            this.dgv.Columns.Add(this.colSoSV);
            this.dgv.Columns.Add(this.colSoSVToiThieu);
            this.dgv.Columns.Add(this.colTrangThai);
            this.statusStrip.Items.Add(this.lblTrangThai);
            this.pnlTim.Controls.Add(this.lblLocNienKhoa);
            this.pnlTim.Controls.Add(this.cboLocNienKhoa);
            this.pnlTim.Controls.Add(this.lblLocHocKy);
            this.pnlTim.Controls.Add(this.cboLocHocKy);
            this.pnlTim.Controls.Add(this.btnLoc);
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Controls.Add(this.btnTaiLai);
            this.pnlNhap.Controls.Add(this.lblMaLTC);
            this.pnlNhap.Controls.Add(this.txtMaLTC);
            this.pnlNhap.Controls.Add(this.lblNienKhoa);
            this.pnlNhap.Controls.Add(this.txtNienKhoa);
            this.pnlNhap.Controls.Add(this.lblHocKy);
            this.pnlNhap.Controls.Add(this.numHocKy);
            this.pnlNhap.Controls.Add(this.lblNhom);
            this.pnlNhap.Controls.Add(this.numNhom);
            this.pnlNhap.Controls.Add(this.lblMonHoc);
            this.pnlNhap.Controls.Add(this.cboMonHoc);
            this.pnlNhap.Controls.Add(this.lblKhoa);
            this.pnlNhap.Controls.Add(this.cboKhoa);
            this.pnlNhap.Controls.Add(this.lblGiangVien);
            this.pnlNhap.Controls.Add(this.cboGiangVien);
            this.pnlNhap.Controls.Add(this.lblSVToiThieu);
            this.pnlNhap.Controls.Add(this.numSVToiThieu);
            this.pnlNhap.Controls.Add(this.lblHuyLop);
            this.pnlNhap.Controls.Add(this.chkHuyLop);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSVToiThieu)).EndInit();
            this.pnlTim.ResumeLayout(false);
            this.pnlNut.ResumeLayout(false);
            this.pnlNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSVToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlTim;
        private System.Windows.Forms.Label lblLocNienKhoa;
        private System.Windows.Forms.ComboBox cboLocNienKhoa;
        private System.Windows.Forms.Label lblLocHocKy;
        private System.Windows.Forms.ComboBox cboLocHocKy;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label lblMaLTC;
        private System.Windows.Forms.TextBox txtMaLTC;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.NumericUpDown numHocKy;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.NumericUpDown numNhom;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.Label lblSVToiThieu;
        private System.Windows.Forms.NumericUpDown numSVToiThieu;
        private System.Windows.Forms.Label lblHuyLop;
        private System.Windows.Forms.CheckBox chkHuyLop;
    }
}
