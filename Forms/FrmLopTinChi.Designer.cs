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
            this.btnLoc = new QLDSV_HTC.UI.ModernButton();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            this.btnThem = new QLDSV_HTC.UI.ModernButton();
            this.btnSua = new QLDSV_HTC.UI.ModernButton();
            this.btnXoa = new QLDSV_HTC.UI.ModernButton();
            this.btnTaiLai = new QLDSV_HTC.UI.ModernButton();
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
            this.statusStrip.SuspendLayout();
            this.pnlTim.SuspendLayout();
            this.pnlNut.SuspendLayout();
            this.pnlNhap.SuspendLayout();
            this.SuspendLayout();

            // ---- dgv ----
            this.dgv.Name = "dgv";
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.TabIndex = 3;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaLTC,
                this.colNienKhoa,
                this.colHocKy,
                this.colTenMH,
                this.colNhom,
                this.colTenGV,
                this.colSoSV,
                this.colSoSVToiThieu,
                this.colTrangThai
            });

            // colMaLTC
            this.colMaLTC.Name = "colMaLTC";
            this.colMaLTC.DataPropertyName = "MaLTC";
            this.colMaLTC.HeaderText = "Mã LTC";
            this.colMaLTC.FillWeight = 8F;
            this.colMaLTC.MinimumWidth = 65;
            this.colMaLTC.ReadOnly = true;

            // colNienKhoa
            this.colNienKhoa.Name = "colNienKhoa";
            this.colNienKhoa.DataPropertyName = "NienKhoa";
            this.colNienKhoa.HeaderText = "Niên khóa";
            this.colNienKhoa.FillWeight = 11F;
            this.colNienKhoa.MinimumWidth = 95;
            this.colNienKhoa.ReadOnly = true;

            // colHocKy
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.FillWeight = 8F;
            this.colHocKy.MinimumWidth = 70;
            this.colHocKy.ReadOnly = true;

            // colTenMH
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Môn học";
            this.colTenMH.FillWeight = 23F;
            this.colTenMH.MinimumWidth = 180;
            this.colTenMH.ReadOnly = true;

            // colNhom
            this.colNhom.Name = "colNhom";
            this.colNhom.DataPropertyName = "Nhom";
            this.colNhom.HeaderText = "Nhóm";
            this.colNhom.FillWeight = 7F;
            this.colNhom.MinimumWidth = 60;
            this.colNhom.ReadOnly = true;

            // colTenGV
            this.colTenGV.Name = "colTenGV";
            this.colTenGV.DataPropertyName = "TenGV";
            this.colTenGV.HeaderText = "Giảng viên";
            this.colTenGV.FillWeight = 19F;
            this.colTenGV.MinimumWidth = 150;
            this.colTenGV.ReadOnly = true;

            // colSoSV
            this.colSoSV.Name = "colSoSV";
            this.colSoSV.DataPropertyName = "SoSV";
            this.colSoSV.HeaderText = "Số SV";
            this.colSoSV.FillWeight = 7F;
            this.colSoSV.MinimumWidth = 65;
            this.colSoSV.ReadOnly = true;

            // colSoSVToiThieu
            this.colSoSVToiThieu.Name = "colSoSVToiThieu";
            this.colSoSVToiThieu.DataPropertyName = "SoSVToiThieu";
            this.colSoSVToiThieu.HeaderText = "SV tối thiểu";
            this.colSoSVToiThieu.FillWeight = 9F;
            this.colSoSVToiThieu.MinimumWidth = 90;
            this.colSoSVToiThieu.ReadOnly = true;

            // colTrangThai
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.FillWeight = 8F;
            this.colTrangThai.MinimumWidth = 80;
            this.colTrangThai.ReadOnly = true;

            // ---- statusStrip ----
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Items.Add(this.lblTrangThai);

            // lblTrangThai
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Sẵn sàng.";

            // ---- pnlTim ----
            this.pnlTim.Name = "pnlTim";
            this.pnlTim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTim.Height = 48;
            this.pnlTim.TabIndex = 2;
            this.pnlTim.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlTim.Padding = new System.Windows.Forms.Padding(8);
            this.pnlTim.Controls.Add(this.lblLocNienKhoa);
            this.pnlTim.Controls.Add(this.cboLocNienKhoa);
            this.pnlTim.Controls.Add(this.lblLocHocKy);
            this.pnlTim.Controls.Add(this.cboLocHocKy);
            this.pnlTim.Controls.Add(this.btnLoc);

            // lblLocNienKhoa
            this.lblLocNienKhoa.Name = "lblLocNienKhoa";
            this.lblLocNienKhoa.AutoSize = true;
            this.lblLocNienKhoa.Location = new System.Drawing.Point(12, 15);
            this.lblLocNienKhoa.Text = "Niên khóa:";
            this.lblLocNienKhoa.TabIndex = 0;

            // cboLocNienKhoa
            this.cboLocNienKhoa.Name = "cboLocNienKhoa";
            this.cboLocNienKhoa.Location = new System.Drawing.Point(82, 12);
            this.cboLocNienKhoa.Size = new System.Drawing.Size(140, 23);
            this.cboLocNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocNienKhoa.TabIndex = 1;

            // lblLocHocKy
            this.lblLocHocKy.Name = "lblLocHocKy";
            this.lblLocHocKy.AutoSize = true;
            this.lblLocHocKy.Location = new System.Drawing.Point(240, 15);
            this.lblLocHocKy.Text = "Học kỳ:";
            this.lblLocHocKy.TabIndex = 2;

            // cboLocHocKy
            this.cboLocHocKy.Name = "cboLocHocKy";
            this.cboLocHocKy.Location = new System.Drawing.Point(295, 12);
            this.cboLocHocKy.Size = new System.Drawing.Size(90, 23);
            this.cboLocHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocHocKy.TabIndex = 3;

            // btnLoc
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Location = new System.Drawing.Point(400, 8);
            this.btnLoc.Size = new System.Drawing.Size(95, 32);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.Variant = QLDSV_HTC.UI.ButtonVariant.Soft;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);

            // ---- pnlNut ----
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNut.Height = 48;
            this.pnlNut.TabIndex = 1;
            this.pnlNut.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Controls.Add(this.btnTaiLai);

            // btnNhapMoi
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Location = new System.Drawing.Point(8, 7);
            this.btnNhapMoi.Size = new System.Drawing.Size(105, 34);
            this.btnNhapMoi.TabIndex = 0;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.Variant = QLDSV_HTC.UI.ButtonVariant.Secondary;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);

            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(121, 7);
            this.btnThem.Size = new System.Drawing.Size(105, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Variant = QLDSV_HTC.UI.ButtonVariant.Primary;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(234, 7);
            this.btnSua.Size = new System.Drawing.Size(105, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Variant = QLDSV_HTC.UI.ButtonVariant.Primary;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(347, 7);
            this.btnXoa.Size = new System.Drawing.Size(105, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Variant = QLDSV_HTC.UI.ButtonVariant.Danger;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnTaiLai
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Location = new System.Drawing.Point(460, 7);
            this.btnTaiLai.Size = new System.Drawing.Size(105, 34);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Variant = QLDSV_HTC.UI.ButtonVariant.Ghost;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);

            // ---- pnlNhap ----
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Height = 88;
            this.pnlNhap.TabIndex = 0;
            this.pnlNhap.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlNhap.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
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

            // lblMaLTC
            this.lblMaLTC.Name = "lblMaLTC";
            this.lblMaLTC.AutoSize = true;
            this.lblMaLTC.Location = new System.Drawing.Point(12, 15);
            this.lblMaLTC.Text = "Mã:";
            this.lblMaLTC.TabIndex = 0;

            // txtMaLTC
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Location = new System.Drawing.Point(45, 12);
            this.txtMaLTC.Size = new System.Drawing.Size(55, 23);
            this.txtMaLTC.ReadOnly = true;
            this.txtMaLTC.TabIndex = 1;

            // lblNienKhoa
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(115, 15);
            this.lblNienKhoa.Text = "Niên khóa (*):";
            this.lblNienKhoa.TabIndex = 2;

            // txtNienKhoa
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Location = new System.Drawing.Point(200, 12);
            this.txtNienKhoa.Size = new System.Drawing.Size(95, 23);
            this.txtNienKhoa.MaxLength = 9;
            this.txtNienKhoa.PlaceholderText = "2023-2024";
            this.txtNienKhoa.TabIndex = 3;

            // lblHocKy
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(310, 15);
            this.lblHocKy.Text = "Học kỳ:";
            this.lblHocKy.TabIndex = 4;

            // numHocKy
            this.numHocKy.Name = "numHocKy";
            this.numHocKy.Location = new System.Drawing.Point(365, 12);
            this.numHocKy.Size = new System.Drawing.Size(50, 23);
            this.numHocKy.Minimum = 1;
            this.numHocKy.Maximum = 3;
            this.numHocKy.Value = 1;
            this.numHocKy.TabIndex = 5;

            // lblNhom
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.AutoSize = true;
            this.lblNhom.Location = new System.Drawing.Point(430, 15);
            this.lblNhom.Text = "Nhóm:";
            this.lblNhom.TabIndex = 6;

            // numNhom
            this.numNhom.Name = "numNhom";
            this.numNhom.Location = new System.Drawing.Point(480, 12);
            this.numNhom.Size = new System.Drawing.Size(50, 23);
            this.numNhom.Minimum = 1;
            this.numNhom.Maximum = 50;
            this.numNhom.Value = 1;
            this.numNhom.TabIndex = 7;

            // lblMonHoc
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(545, 15);
            this.lblMonHoc.Text = "Môn học (*):";
            this.lblMonHoc.TabIndex = 8;

            // cboMonHoc
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Location = new System.Drawing.Point(625, 12);
            this.cboMonHoc.Size = new System.Drawing.Size(260, 23);
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.TabIndex = 9;

            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(12, 51);
            this.lblKhoa.Text = "Khoa:";
            this.lblKhoa.TabIndex = 10;

            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(60, 48);
            this.cboKhoa.Size = new System.Drawing.Size(160, 23);
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.TabIndex = 11;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);

            // lblGiangVien
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(235, 51);
            this.lblGiangVien.Text = "Giảng viên (*):";
            this.lblGiangVien.TabIndex = 12;

            // cboGiangVien
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Location = new System.Drawing.Point(325, 48);
            this.cboGiangVien.Size = new System.Drawing.Size(205, 23);
            this.cboGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiangVien.TabIndex = 13;

            // lblSVToiThieu
            this.lblSVToiThieu.Name = "lblSVToiThieu";
            this.lblSVToiThieu.AutoSize = true;
            this.lblSVToiThieu.Location = new System.Drawing.Point(545, 51);
            this.lblSVToiThieu.Text = "SV tối thiểu:";
            this.lblSVToiThieu.TabIndex = 14;

            // numSVToiThieu
            this.numSVToiThieu.Name = "numSVToiThieu";
            this.numSVToiThieu.Location = new System.Drawing.Point(625, 48);
            this.numSVToiThieu.Size = new System.Drawing.Size(70, 23);
            this.numSVToiThieu.Maximum = 1000;
            this.numSVToiThieu.TabIndex = 15;

            // lblHuyLop
            this.lblHuyLop.Name = "lblHuyLop";
            this.lblHuyLop.AutoSize = true;
            this.lblHuyLop.Location = new System.Drawing.Point(715, 51);
            this.lblHuyLop.Text = "Hủy lớp:";
            this.lblHuyLop.TabIndex = 16;

            // chkHuyLop
            this.chkHuyLop.Name = "chkHuyLop";
            this.chkHuyLop.Location = new System.Drawing.Point(775, 50);
            this.chkHuyLop.Size = new System.Drawing.Size(80, 20);
            this.chkHuyLop.Text = "Đã hủy";
            this.chkHuyLop.TabIndex = 17;

            // ---- FrmLopTinChi ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmLopTinChi";
            this.Text = "Quản lý Lớp tín chỉ";
            this.Load += new System.EventHandler(this.FrmLopTinChi_Load);
            this.Shown += new System.EventHandler(this.FrmLopTinChi_Shown);

            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.statusStrip);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSVToiThieu)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlTim.ResumeLayout(false);
            this.pnlTim.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            this.pnlNhap.ResumeLayout(false);
            this.pnlNhap.PerformLayout();
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
        private QLDSV_HTC.UI.ModernButton btnLoc;
        private System.Windows.Forms.Panel pnlNut;
        private QLDSV_HTC.UI.ModernButton btnNhapMoi;
        private QLDSV_HTC.UI.ModernButton btnThem;
        private QLDSV_HTC.UI.ModernButton btnSua;
        private QLDSV_HTC.UI.ModernButton btnXoa;
        private QLDSV_HTC.UI.ModernButton btnTaiLai;
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
