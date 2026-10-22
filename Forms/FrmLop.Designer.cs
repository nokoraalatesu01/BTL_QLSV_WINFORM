#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmLop
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
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTim = new System.Windows.Forms.Panel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new QLDSV_HTC.UI.ModernButton();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            this.btnThem = new QLDSV_HTC.UI.ModernButton();
            this.btnSua = new QLDSV_HTC.UI.ModernButton();
            this.btnXoa = new QLDSV_HTC.UI.ModernButton();
            this.btnTaiLai = new QLDSV_HTC.UI.ModernButton();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
                this.colMaLop,
                this.colTenLop,
                this.colKhoaHoc,
                this.colTenKhoa
            });

            // colMaLop
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.FillWeight = 20F;
            this.colMaLop.MinimumWidth = 100;
            this.colMaLop.ReadOnly = true;

            // colTenLop
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.FillWeight = 40F;
            this.colTenLop.MinimumWidth = 200;
            this.colTenLop.ReadOnly = true;

            // colKhoaHoc
            this.colKhoaHoc.Name = "colKhoaHoc";
            this.colKhoaHoc.DataPropertyName = "KhoaHoc";
            this.colKhoaHoc.HeaderText = "Khóa học";
            this.colKhoaHoc.FillWeight = 15F;
            this.colKhoaHoc.MinimumWidth = 100;
            this.colKhoaHoc.ReadOnly = true;

            // colTenKhoa
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.DataPropertyName = "TenKhoa";
            this.colTenKhoa.HeaderText = "Khoa quản lý";
            this.colTenKhoa.FillWeight = 25F;
            this.colTenKhoa.MinimumWidth = 150;
            this.colTenKhoa.ReadOnly = true;

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
            this.pnlTim.Controls.Add(this.lblTim);
            this.pnlTim.Controls.Add(this.txtTim);
            this.pnlTim.Controls.Add(this.btnTim);

            // lblTim
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(12, 15);
            this.lblTim.Text = "Tìm kiếm:";
            this.lblTim.TabIndex = 0;

            // txtTim
            this.txtTim.Name = "txtTim";
            this.txtTim.Location = new System.Drawing.Point(82, 12);
            this.txtTim.Size = new System.Drawing.Size(260, 23);
            this.txtTim.MaxLength = 100;
            this.txtTim.TabIndex = 1;
            this.txtTim.PlaceholderText = "Nhập mã lớp, tên lớp hoặc khóa học...";
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);

            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(352, 8);
            this.btnTim.Size = new System.Drawing.Size(95, 32);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Variant = QLDSV_HTC.UI.ButtonVariant.Soft;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

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
            this.pnlNhap.Controls.Add(this.lblMaLop);
            this.pnlNhap.Controls.Add(this.txtMaLop);
            this.pnlNhap.Controls.Add(this.lblTenLop);
            this.pnlNhap.Controls.Add(this.txtTenLop);
            this.pnlNhap.Controls.Add(this.lblKhoaHoc);
            this.pnlNhap.Controls.Add(this.txtKhoaHoc);
            this.pnlNhap.Controls.Add(this.lblKhoa);
            this.pnlNhap.Controls.Add(this.cboKhoa);

            // lblMaLop
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(12, 15);
            this.lblMaLop.Text = "Mã lớp (*):";
            this.lblMaLop.TabIndex = 0;

            // txtMaLop
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Location = new System.Drawing.Point(95, 12);
            this.txtMaLop.Size = new System.Drawing.Size(170, 23);
            this.txtMaLop.MaxLength = 10;
            this.txtMaLop.TabIndex = 1;

            // lblTenLop
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(290, 15);
            this.lblTenLop.Text = "Tên lớp (*):";
            this.lblTenLop.TabIndex = 2;

            // txtTenLop
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Location = new System.Drawing.Point(375, 12);
            this.txtTenLop.Size = new System.Drawing.Size(280, 23);
            this.txtTenLop.MaxLength = 50;
            this.txtTenLop.TabIndex = 3;

            // lblKhoaHoc
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Location = new System.Drawing.Point(12, 51);
            this.lblKhoaHoc.Text = "Khóa học:";
            this.lblKhoaHoc.TabIndex = 4;

            // txtKhoaHoc
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Location = new System.Drawing.Point(95, 48);
            this.txtKhoaHoc.Size = new System.Drawing.Size(170, 23);
            this.txtKhoaHoc.MaxLength = 9;
            this.txtKhoaHoc.PlaceholderText = "VD: 2021-2025";
            this.txtKhoaHoc.TabIndex = 5;

            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(290, 51);
            this.lblKhoa.Text = "Khoa (*):";
            this.lblKhoa.TabIndex = 6;

            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(375, 48);
            this.cboKhoa.Size = new System.Drawing.Size(280, 23);
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.TabIndex = 7;

            // ---- FrmLop ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmLop";
            this.Text = "Quản lý Lớp";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            this.Shown += new System.EventHandler(this.FrmLop_Shown);

            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.statusStrip);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private QLDSV_HTC.UI.ModernButton btnTim;
        private System.Windows.Forms.Panel pnlNut;
        private QLDSV_HTC.UI.ModernButton btnNhapMoi;
        private QLDSV_HTC.UI.ModernButton btnThem;
        private QLDSV_HTC.UI.ModernButton btnSua;
        private QLDSV_HTC.UI.ModernButton btnXoa;
        private QLDSV_HTC.UI.ModernButton btnTaiLai;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
    }
}
