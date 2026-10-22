#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmGiangVien
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
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblHocVi = new System.Windows.Forms.Label();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.lblHocHam = new System.Windows.Forms.Label();
            this.txtHocHam = new System.Windows.Forms.TextBox();
            this.lblChuyenMon = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();

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
                this.colMaGV,
                this.colHoTen,
                this.colTenKhoa,
                this.colHocVi,
                this.colHocHam,
                this.colChuyenMon
            });

            // colMaGV
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.FillWeight = 12F;
            this.colMaGV.MinimumWidth = 90;
            this.colMaGV.ReadOnly = true;

            // colHoTen
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.FillWeight = 22F;
            this.colHoTen.MinimumWidth = 150;
            this.colHoTen.ReadOnly = true;

            // colTenKhoa
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.DataPropertyName = "TenKhoa";
            this.colTenKhoa.HeaderText = "Khoa";
            this.colTenKhoa.FillWeight = 20F;
            this.colTenKhoa.MinimumWidth = 140;
            this.colTenKhoa.ReadOnly = true;

            // colHocVi
            this.colHocVi.Name = "colHocVi";
            this.colHocVi.DataPropertyName = "HocVi";
            this.colHocVi.HeaderText = "Học vị";
            this.colHocVi.FillWeight = 14F;
            this.colHocVi.MinimumWidth = 90;
            this.colHocVi.ReadOnly = true;

            // colHocHam
            this.colHocHam.Name = "colHocHam";
            this.colHocHam.DataPropertyName = "HocHam";
            this.colHocHam.HeaderText = "Học hàm";
            this.colHocHam.FillWeight = 14F;
            this.colHocHam.MinimumWidth = 90;
            this.colHocHam.ReadOnly = true;

            // colChuyenMon
            this.colChuyenMon.Name = "colChuyenMon";
            this.colChuyenMon.DataPropertyName = "ChuyenMon";
            this.colChuyenMon.HeaderText = "Chuyên môn";
            this.colChuyenMon.FillWeight = 18F;
            this.colChuyenMon.MinimumWidth = 130;
            this.colChuyenMon.ReadOnly = true;

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
            this.txtTim.PlaceholderText = "Nhập mã, họ tên hoặc chuyên môn...";
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
            this.pnlNhap.Controls.Add(this.lblMaGV);
            this.pnlNhap.Controls.Add(this.txtMaGV);
            this.pnlNhap.Controls.Add(this.lblHo);
            this.pnlNhap.Controls.Add(this.txtHo);
            this.pnlNhap.Controls.Add(this.lblTen);
            this.pnlNhap.Controls.Add(this.txtTen);
            this.pnlNhap.Controls.Add(this.lblKhoa);
            this.pnlNhap.Controls.Add(this.cboKhoa);
            this.pnlNhap.Controls.Add(this.lblHocVi);
            this.pnlNhap.Controls.Add(this.txtHocVi);
            this.pnlNhap.Controls.Add(this.lblHocHam);
            this.pnlNhap.Controls.Add(this.txtHocHam);
            this.pnlNhap.Controls.Add(this.lblChuyenMon);
            this.pnlNhap.Controls.Add(this.txtChuyenMon);

            // lblMaGV
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(12, 15);
            this.lblMaGV.Text = "Mã GV (*):";
            this.lblMaGV.TabIndex = 0;

            // txtMaGV
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Location = new System.Drawing.Point(82, 12);
            this.txtMaGV.Size = new System.Drawing.Size(110, 23);
            this.txtMaGV.MaxLength = 10;
            this.txtMaGV.TabIndex = 1;

            // lblHo
            this.lblHo.Name = "lblHo";
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(210, 15);
            this.lblHo.Text = "Họ đệm (*):";
            this.lblHo.TabIndex = 2;

            // txtHo
            this.txtHo.Name = "txtHo";
            this.txtHo.Location = new System.Drawing.Point(284, 12);
            this.txtHo.Size = new System.Drawing.Size(140, 23);
            this.txtHo.MaxLength = 50;
            this.txtHo.TabIndex = 3;

            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(440, 15);
            this.lblTen.Text = "Tên (*):";
            this.lblTen.TabIndex = 4;

            // txtTen
            this.txtTen.Name = "txtTen";
            this.txtTen.Location = new System.Drawing.Point(490, 12);
            this.txtTen.Size = new System.Drawing.Size(100, 23);
            this.txtTen.MaxLength = 20;
            this.txtTen.TabIndex = 5;

            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(610, 15);
            this.lblKhoa.Text = "Khoa (*):";
            this.lblKhoa.TabIndex = 6;

            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(670, 12);
            this.cboKhoa.Size = new System.Drawing.Size(220, 23);
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.TabIndex = 7;

            // lblHocVi
            this.lblHocVi.Name = "lblHocVi";
            this.lblHocVi.AutoSize = true;
            this.lblHocVi.Location = new System.Drawing.Point(12, 51);
            this.lblHocVi.Text = "Học vị:";
            this.lblHocVi.TabIndex = 8;

            // txtHocVi
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Location = new System.Drawing.Point(82, 48);
            this.txtHocVi.Size = new System.Drawing.Size(110, 23);
            this.txtHocVi.MaxLength = 20;
            this.txtHocVi.PlaceholderText = "ThS, TS...";
            this.txtHocVi.TabIndex = 9;

            // lblHocHam
            this.lblHocHam.Name = "lblHocHam";
            this.lblHocHam.AutoSize = true;
            this.lblHocHam.Location = new System.Drawing.Point(210, 51);
            this.lblHocHam.Text = "Học hàm:";
            this.lblHocHam.TabIndex = 10;

            // txtHocHam
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Location = new System.Drawing.Point(284, 48);
            this.txtHocHam.Size = new System.Drawing.Size(140, 23);
            this.txtHocHam.MaxLength = 20;
            this.txtHocHam.PlaceholderText = "PGS, GS...";
            this.txtHocHam.TabIndex = 11;

            // lblChuyenMon
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Location = new System.Drawing.Point(440, 51);
            this.lblChuyenMon.Text = "Chuyên môn:";
            this.lblChuyenMon.TabIndex = 12;

            // txtChuyenMon
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Location = new System.Drawing.Point(525, 48);
            this.txtChuyenMon.Size = new System.Drawing.Size(365, 23);
            this.txtChuyenMon.MaxLength = 100;
            this.txtChuyenMon.TabIndex = 13;

            // ---- FrmGiangVien ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmGiangVien";
            this.Text = "Quản lý Giảng viên";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.Shown += new System.EventHandler(this.FrmGiangVien_Shown);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenMon;
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
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHocVi;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.Label lblHocHam;
        private System.Windows.Forms.TextBox txtHocHam;
        private System.Windows.Forms.Label lblChuyenMon;
        private System.Windows.Forms.TextBox txtChuyenMon;
    }
}
