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
            dgv = new DataGridView();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            pnlTim = new Panel();
            lblTim = new Label();
            txtTim = new TextBox();
            btnTim = new QLDSV_HTC.UI.ModernButton();
            pnlNut = new Panel();
            btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            btnThem = new QLDSV_HTC.UI.ModernButton();
            btnSua = new QLDSV_HTC.UI.ModernButton();
            btnXoa = new QLDSV_HTC.UI.ModernButton();
            btnTaiLai = new QLDSV_HTC.UI.ModernButton();
            pnlNhap = new Panel();
            lblMaMH = new Label();
            txtMaMH = new TextBox();
            lblTenMH = new Label();
            txtTenMH = new TextBox();
            lblSoTietLT = new Label();
            numSoTietLT = new NumericUpDown();
            lblSoTietTH = new Label();
            numSoTietTH = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            statusStrip.SuspendLayout();
            pnlTim.SuspendLayout();
            pnlNut.SuspendLayout();
            pnlNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTietLT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoTietTH).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeight = 29;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 283);
            dgv.Margin = new Padding(4, 5, 4, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1286, 611);
            dgv.TabIndex = 3;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip.Location = new Point(0, 894);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(10, 0, 10, 0);
            statusStrip.Size = new Size(1286, 26);
            statusStrip.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(71, 20);
            lblTrangThai.Text = "Sẵn sàng.";
            // 
            // pnlTim
            // 
            pnlTim.BackColor = Color.White;
            pnlTim.Controls.Add(lblTim);
            pnlTim.Controls.Add(txtTim);
            pnlTim.Controls.Add(btnTim);
            pnlTim.Dock = DockStyle.Top;
            pnlTim.Location = new Point(0, 209);
            pnlTim.Margin = new Padding(4, 5, 4, 5);
            pnlTim.Name = "pnlTim";
            pnlTim.Padding = new Padding(10, 12, 10, 12);
            pnlTim.Size = new Size(1286, 74);
            pnlTim.TabIndex = 2;
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(15, 23);
            lblTim.Margin = new Padding(4, 0, 4, 0);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(83, 23);
            lblTim.TabIndex = 0;
            lblTim.Text = "Tìm kiếm:";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(105, 18);
            txtTim.Margin = new Padding(4, 5, 4, 5);
            txtTim.MaxLength = 100;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Nhập mã môn học hoặc tên môn học...";
            txtTim.Size = new Size(333, 30);
            txtTim.TabIndex = 1;
            txtTim.KeyDown += txtTim_KeyDown;
            // 
            // btnTim
            // 
            btnTim.CornerRadius = 6;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTim.Location = new Point(453, 12);
            btnTim.Margin = new Padding(4, 5, 4, 5);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(122, 49);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Variant = UI.ButtonVariant.Soft;
            btnTim.Click += btnTim_Click;
            // 
            // pnlNut
            // 
            pnlNut.BackColor = Color.White;
            pnlNut.Controls.Add(btnNhapMoi);
            pnlNut.Controls.Add(btnThem);
            pnlNut.Controls.Add(btnSua);
            pnlNut.Controls.Add(btnXoa);
            pnlNut.Controls.Add(btnTaiLai);
            pnlNut.Dock = DockStyle.Top;
            pnlNut.Location = new Point(0, 135);
            pnlNut.Margin = new Padding(4, 5, 4, 5);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(1286, 74);
            pnlNut.TabIndex = 1;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.CornerRadius = 6;
            btnNhapMoi.FlatStyle = FlatStyle.Flat;
            btnNhapMoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNhapMoi.Location = new Point(10, 11);
            btnNhapMoi.Margin = new Padding(4, 5, 4, 5);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(135, 52);
            btnNhapMoi.TabIndex = 0;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.UseVisualStyleBackColor = false;
            btnNhapMoi.Variant = UI.ButtonVariant.Secondary;
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // btnThem
            // 
            btnThem.CornerRadius = 6;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThem.Location = new Point(156, 11);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 52);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Variant = UI.ButtonVariant.Primary;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.CornerRadius = 6;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSua.Location = new Point(301, 11);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 52);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Variant = UI.ButtonVariant.Primary;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.CornerRadius = 6;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoa.Location = new Point(446, 11);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 52);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Variant = UI.ButtonVariant.Danger;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.CornerRadius = 6;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTaiLai.Location = new Point(591, 11);
            btnTaiLai.Margin = new Padding(4, 5, 4, 5);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(135, 52);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Variant = UI.ButtonVariant.Ghost;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
            pnlNhap.Controls.Add(lblMaMH);
            pnlNhap.Controls.Add(txtMaMH);
            pnlNhap.Controls.Add(lblTenMH);
            pnlNhap.Controls.Add(txtTenMH);
            pnlNhap.Controls.Add(lblSoTietLT);
            pnlNhap.Controls.Add(numSoTietLT);
            pnlNhap.Controls.Add(lblSoTietTH);
            pnlNhap.Controls.Add(numSoTietTH);
            pnlNhap.Dock = DockStyle.Top;
            pnlNhap.Location = new Point(0, 0);
            pnlNhap.Margin = new Padding(4, 5, 4, 5);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Padding = new Padding(15, 15, 15, 12);
            pnlNhap.Size = new Size(1286, 135);
            pnlNhap.TabIndex = 0;
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(15, 23);
            lblMaMH.Margin = new Padding(4, 0, 4, 0);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(133, 23);
            lblMaMH.TabIndex = 0;
            lblMaMH.Text = "Mã môn học (*):";
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(154, 18);
            txtMaMH.Margin = new Padding(4, 5, 4, 5);
            txtMaMH.MaxLength = 10;
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(205, 30);
            txtMaMH.TabIndex = 1;
            // 
            // lblTenMH
            // 
            lblTenMH.AutoSize = true;
            lblTenMH.Location = new Point(399, 23);
            lblTenMH.Margin = new Padding(4, 0, 4, 0);
            lblTenMH.Name = "lblTenMH";
            lblTenMH.Size = new Size(135, 23);
            lblTenMH.TabIndex = 2;
            lblTenMH.Text = "Tên môn học (*):";
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(534, 18);
            txtTenMH.Margin = new Padding(4, 5, 4, 5);
            txtTenMH.MaxLength = 100;
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(410, 30);
            txtTenMH.TabIndex = 3;
            // 
            // lblSoTietLT
            // 
            lblSoTietLT.AutoSize = true;
            lblSoTietLT.Location = new Point(15, 78);
            lblSoTietLT.Margin = new Padding(4, 0, 4, 0);
            lblSoTietLT.Name = "lblSoTietLT";
            lblSoTietLT.Size = new Size(134, 23);
            lblSoTietLT.TabIndex = 4;
            lblSoTietLT.Text = "Số tiết lý thuyết:";
            // 
            // numSoTietLT
            // 
            numSoTietLT.Location = new Point(154, 74);
            numSoTietLT.Margin = new Padding(4, 5, 4, 5);
            numSoTietLT.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numSoTietLT.Name = "numSoTietLT";
            numSoTietLT.Size = new Size(206, 30);
            numSoTietLT.TabIndex = 5;
            // 
            // lblSoTietTH
            // 
            lblSoTietTH.AutoSize = true;
            lblSoTietTH.Location = new Point(399, 78);
            lblSoTietTH.Margin = new Padding(4, 0, 4, 0);
            lblSoTietTH.Name = "lblSoTietTH";
            lblSoTietTH.Size = new Size(146, 23);
            lblSoTietTH.TabIndex = 6;
            lblSoTietTH.Text = "Số tiết thực hành:";
            // 
            // numSoTietTH
            // 
            numSoTietTH.Location = new Point(544, 71);
            numSoTietTH.Margin = new Padding(4, 5, 4, 5);
            numSoTietTH.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numSoTietTH.Name = "numSoTietTH";
            numSoTietTH.Size = new Size(206, 30);
            numSoTietTH.TabIndex = 7;
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 920);
            Controls.Add(dgv);
            Controls.Add(pnlTim);
            Controls.Add(pnlNut);
            Controls.Add(pnlNhap);
            Controls.Add(statusStrip);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMonHoc";
            Text = "Quản lý Môn học";
            Load += FrmMonHoc_Load;
            Shown += FrmMonHoc_Shown;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            pnlTim.ResumeLayout(false);
            pnlTim.PerformLayout();
            pnlNut.ResumeLayout(false);
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTietLT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoTietTH).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
