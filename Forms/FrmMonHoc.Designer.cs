#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmMonHoc
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
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTietLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTietTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblMaMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lblSoTietLT = new System.Windows.Forms.Label();
            this.numSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.lblSoTietTH = new System.Windows.Forms.Label();
            this.numSoTietTH = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).BeginInit();
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
                this.colMaMH,
                this.colTenMH,
                this.colSoTietLT,
                this.colSoTietTH,
                this.colTongSoTiet
            });

            // colMaMH
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Mã môn học";
            this.colMaMH.FillWeight = 16F;
            this.colMaMH.MinimumWidth = 100;
            this.colMaMH.ReadOnly = true;

            // colTenMH
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Tên môn học";
            this.colTenMH.FillWeight = 48F;
            this.colTenMH.MinimumWidth = 250;
            this.colTenMH.ReadOnly = true;

            // colSoTietLT
            this.colSoTietLT.Name = "colSoTietLT";
            this.colSoTietLT.DataPropertyName = "SoTietLT";
            this.colSoTietLT.HeaderText = "Số tiết LT";
            this.colSoTietLT.FillWeight = 12F;
            this.colSoTietLT.MinimumWidth = 85;
            this.colSoTietLT.ReadOnly = true;

            // colSoTietTH
            this.colSoTietTH.Name = "colSoTietTH";
            this.colSoTietTH.DataPropertyName = "SoTietTH";
            this.colSoTietTH.HeaderText = "Số tiết TH";
            this.colSoTietTH.FillWeight = 12F;
            this.colSoTietTH.MinimumWidth = 85;
            this.colSoTietTH.ReadOnly = true;

            // colTongSoTiet
            this.colTongSoTiet.Name = "colTongSoTiet";
            this.colTongSoTiet.DataPropertyName = "TongSoTiet";
            this.colTongSoTiet.HeaderText = "Tổng số tiết";
            this.colTongSoTiet.FillWeight = 12F;
            this.colTongSoTiet.MinimumWidth = 95;
            this.colTongSoTiet.ReadOnly = true;

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
            this.txtTim.PlaceholderText = "Nhập mã môn học hoặc tên môn học...";
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
            this.pnlNhap.Controls.Add(this.lblMaMH);
            this.pnlNhap.Controls.Add(this.txtMaMH);
            this.pnlNhap.Controls.Add(this.lblTenMH);
            this.pnlNhap.Controls.Add(this.txtTenMH);
            this.pnlNhap.Controls.Add(this.lblSoTietLT);
            this.pnlNhap.Controls.Add(this.numSoTietLT);
            this.pnlNhap.Controls.Add(this.lblSoTietTH);
            this.pnlNhap.Controls.Add(this.numSoTietTH);

            // lblMaMH
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(12, 15);
            this.lblMaMH.Text = "Mã môn học (*):";
            this.lblMaMH.TabIndex = 0;

            // txtMaMH
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Location = new System.Drawing.Point(120, 12);
            this.txtMaMH.Size = new System.Drawing.Size(160, 23);
            this.txtMaMH.MaxLength = 10;
            this.txtMaMH.TabIndex = 1;

            // lblTenMH
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(310, 15);
            this.lblTenMH.Text = "Tên môn học (*):";
            this.lblTenMH.TabIndex = 2;

            // txtTenMH
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Location = new System.Drawing.Point(415, 12);
            this.txtTenMH.Size = new System.Drawing.Size(320, 23);
            this.txtTenMH.MaxLength = 100;
            this.txtTenMH.TabIndex = 3;

            // lblSoTietLT
            this.lblSoTietLT.Name = "lblSoTietLT";
            this.lblSoTietLT.AutoSize = true;
            this.lblSoTietLT.Location = new System.Drawing.Point(12, 51);
            this.lblSoTietLT.Text = "Số tiết lý thuyết:";
            this.lblSoTietLT.TabIndex = 4;

            // numSoTietLT
            this.numSoTietLT.Name = "numSoTietLT";
            this.numSoTietLT.Location = new System.Drawing.Point(120, 48);
            this.numSoTietLT.Size = new System.Drawing.Size(160, 23);
            this.numSoTietLT.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numSoTietLT.TabIndex = 5;

            // lblSoTietTH
            this.lblSoTietTH.Name = "lblSoTietTH";
            this.lblSoTietTH.AutoSize = true;
            this.lblSoTietTH.Location = new System.Drawing.Point(310, 51);
            this.lblSoTietTH.Text = "Số tiết thực hành:";
            this.lblSoTietTH.TabIndex = 6;

            // numSoTietTH
            this.numSoTietTH.Name = "numSoTietTH";
            this.numSoTietTH.Location = new System.Drawing.Point(415, 48);
            this.numSoTietTH.Size = new System.Drawing.Size(160, 23);
            this.numSoTietTH.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numSoTietTH.TabIndex = 7;

            // ---- FrmMonHoc ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmMonHoc";
            this.Text = "Quản lý Môn học";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            this.Shown += new System.EventHandler(this.FrmMonHoc_Shown);

            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.statusStrip);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTietLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTietTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoTiet;
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
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblSoTietLT;
        private System.Windows.Forms.NumericUpDown numSoTietLT;
        private System.Windows.Forms.Label lblSoTietTH;
        private System.Windows.Forms.NumericUpDown numSoTietTH;
    }
}
