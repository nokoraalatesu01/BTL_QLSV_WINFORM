#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmKhoa
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
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            this.btnThem = new QLDSV_HTC.UI.ModernButton();
            this.btnSua = new QLDSV_HTC.UI.ModernButton();
            this.btnXoa = new QLDSV_HTC.UI.ModernButton();
            this.btnTaiLai = new QLDSV_HTC.UI.ModernButton();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            this.dgv.TabIndex = 2;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaKhoa,
                this.colTenKhoa
            });

            // colMaKhoa
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.DataPropertyName = "MaKhoa";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.FillWeight = 25F;
            this.colMaKhoa.MinimumWidth = 120;
            this.colMaKhoa.ReadOnly = true;

            // colTenKhoa
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.DataPropertyName = "TenKhoa";
            this.colTenKhoa.HeaderText = "Tên khoa";
            this.colTenKhoa.FillWeight = 75F;
            this.colTenKhoa.MinimumWidth = 250;
            this.colTenKhoa.ReadOnly = true;

            // ---- statusStrip ----
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Items.Add(this.lblTrangThai);

            // lblTrangThai
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Sẵn sàng.";

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
            this.pnlNhap.Height = 56;
            this.pnlNhap.TabIndex = 0;
            this.pnlNhap.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlNhap.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            this.pnlNhap.Controls.Add(this.lblMaKhoa);
            this.pnlNhap.Controls.Add(this.txtMaKhoa);
            this.pnlNhap.Controls.Add(this.lblTenKhoa);
            this.pnlNhap.Controls.Add(this.txtTenKhoa);

            // lblMaKhoa
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(12, 18);
            this.lblMaKhoa.Text = "Mã khoa (*):";
            this.lblMaKhoa.TabIndex = 0;

            // txtMaKhoa
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Location = new System.Drawing.Point(95, 15);
            this.txtMaKhoa.Size = new System.Drawing.Size(160, 23);
            this.txtMaKhoa.MaxLength = 10;
            this.txtMaKhoa.TabIndex = 1;

            // lblTenKhoa
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(280, 18);
            this.lblTenKhoa.Text = "Tên khoa (*):";
            this.lblTenKhoa.TabIndex = 2;

            // txtTenKhoa
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Location = new System.Drawing.Point(365, 15);
            this.txtTenKhoa.Size = new System.Drawing.Size(340, 23);
            this.txtTenKhoa.MaxLength = 50;
            this.txtTenKhoa.TabIndex = 3;

            // ---- FrmKhoa ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Name = "FrmKhoa";
            this.Text = "Quản lý Khoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            this.Shown += new System.EventHandler(this.FrmKhoa_Shown);

            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.statusStrip);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            this.pnlNhap.ResumeLayout(false);
            this.pnlNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlNut;
        private QLDSV_HTC.UI.ModernButton btnNhapMoi;
        private QLDSV_HTC.UI.ModernButton btnThem;
        private QLDSV_HTC.UI.ModernButton btnSua;
        private QLDSV_HTC.UI.ModernButton btnXoa;
        private QLDSV_HTC.UI.ModernButton btnTaiLai;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
    }
}
