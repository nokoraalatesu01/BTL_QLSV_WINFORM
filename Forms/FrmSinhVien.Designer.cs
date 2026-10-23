#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmSinhVien
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
            lblLocLop = new Label();
            cboLocLop = new ComboBox();
            btnTim = new QLDSV_HTC.UI.ModernButton();
            pnlNut = new Panel();
            btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            btnThem = new QLDSV_HTC.UI.ModernButton();
            btnSua = new QLDSV_HTC.UI.ModernButton();
            btnXoa = new QLDSV_HTC.UI.ModernButton();
            btnTaiLai = new QLDSV_HTC.UI.ModernButton();
            btnXuatExcel = new QLDSV_HTC.UI.ModernButton();
            pnlNhap = new Panel();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            lblHo = new Label();
            txtHo = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblNgaySinh = new Label();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblNghiHoc = new Label();
            chkNghiHoc = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            statusStrip.SuspendLayout();
            pnlTim.SuspendLayout();
            pnlNut.SuspendLayout();
            pnlNhap.SuspendLayout();
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
            dgv.Location = new Point(0, 411);
            dgv.Margin = new Padding(5, 6, 5, 6);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1572, 789);
            dgv.TabIndex = 3;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip.Location = new Point(0, 1200);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(12, 0, 12, 0);
            statusStrip.Size = new Size(1572, 32);
            statusStrip.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(88, 25);
            lblTrangThai.Text = "Sẵn sàng.";
            // 
            // pnlTim
            // 
            pnlTim.BackColor = Color.White;
            pnlTim.Controls.Add(lblTim);
            pnlTim.Controls.Add(txtTim);
            pnlTim.Controls.Add(lblLocLop);
            pnlTim.Controls.Add(cboLocLop);
            pnlTim.Controls.Add(btnTim);
            pnlTim.Dock = DockStyle.Top;
            pnlTim.Location = new Point(0, 321);
            pnlTim.Margin = new Padding(5, 6, 5, 6);
            pnlTim.Name = "pnlTim";
            pnlTim.Padding = new Padding(12, 15, 12, 15);
            pnlTim.Size = new Size(1572, 90);
            pnlTim.TabIndex = 2;
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(18, 28);
            lblTim.Margin = new Padding(5, 0, 5, 0);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(86, 28);
            lblTim.TabIndex = 0;
            lblTim.Text = "Từ khóa:";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(117, 22);
            txtTim.Margin = new Padding(5, 6, 5, 6);
            txtTim.MaxLength = 100;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Nhập mã SV, họ tên hoặc địa chỉ...";
            txtTim.Size = new Size(360, 34);
            txtTim.TabIndex = 1;
            txtTim.KeyDown += txtTim_KeyDown;
            // 
            // lblLocLop
            // 
            lblLocLop.AutoSize = true;
            lblLocLop.Location = new Point(511, 28);
            lblLocLop.Margin = new Padding(5, 0, 5, 0);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(49, 28);
            lblLocLop.TabIndex = 2;
            lblLocLop.Text = "Lớp:";
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.Location = new Point(573, 22);
            cboLocLop.Margin = new Padding(5, 6, 5, 6);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(438, 36);
            cboLocLop.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.CornerRadius = 6;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTim.Location = new Point(1038, 15);
            btnTim.Margin = new Padding(5, 6, 5, 6);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(149, 60);
            btnTim.TabIndex = 4;
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
            pnlNut.Controls.Add(btnXuatExcel);
            pnlNut.Dock = DockStyle.Top;
            pnlNut.Location = new Point(0, 231);
            pnlNut.Margin = new Padding(5, 6, 5, 6);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(1572, 90);
            pnlNut.TabIndex = 1;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.CornerRadius = 6;
            btnNhapMoi.FlatStyle = FlatStyle.Flat;
            btnNhapMoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNhapMoi.Location = new Point(12, 13);
            btnNhapMoi.Margin = new Padding(5, 6, 5, 6);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(165, 63);
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
            btnThem.Location = new Point(191, 13);
            btnThem.Margin = new Padding(5, 6, 5, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 63);
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
            btnSua.Location = new Point(368, 13);
            btnSua.Margin = new Padding(5, 6, 5, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(165, 63);
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
            btnXoa.Location = new Point(545, 13);
            btnXoa.Margin = new Padding(5, 6, 5, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(165, 63);
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
            btnTaiLai.Location = new Point(722, 13);
            btnTaiLai.Margin = new Padding(5, 6, 5, 6);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(165, 63);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Variant = UI.ButtonVariant.Ghost;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.CornerRadius = 6;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(900, 13);
            btnXuatExcel.Margin = new Padding(5, 6, 5, 6);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(165, 63);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Variant = UI.ButtonVariant.Success;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
            pnlNhap.Controls.Add(dtpNgaySinh);
            pnlNhap.Controls.Add(lblMaSV);
            pnlNhap.Controls.Add(txtMaSV);
            pnlNhap.Controls.Add(lblLop);
            pnlNhap.Controls.Add(cboLop);
            pnlNhap.Controls.Add(lblHo);
            pnlNhap.Controls.Add(txtHo);
            pnlNhap.Controls.Add(lblTen);
            pnlNhap.Controls.Add(txtTen);
            pnlNhap.Controls.Add(lblGioiTinh);
            pnlNhap.Controls.Add(cboGioiTinh);
            pnlNhap.Controls.Add(lblNgaySinh);
            pnlNhap.Controls.Add(lblDiaChi);
            pnlNhap.Controls.Add(txtDiaChi);
            pnlNhap.Controls.Add(lblNghiHoc);
            pnlNhap.Controls.Add(chkNghiHoc);
            pnlNhap.Dock = DockStyle.Top;
            pnlNhap.Location = new Point(0, 0);
            pnlNhap.Margin = new Padding(5, 6, 5, 6);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Padding = new Padding(18, 18, 18, 15);
            pnlNhap.Size = new Size(1572, 231);
            pnlNhap.TabIndex = 0;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(18, 28);
            lblMaSV.Margin = new Padding(5, 0, 5, 0);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(150, 28);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên (*):";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(181, 22);
            txtMaSV.Margin = new Padding(5, 6, 5, 6);
            txtMaSV.MaxLength = 10;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(264, 34);
            txtMaSV.TabIndex = 1;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(488, 28);
            lblLop.Margin = new Padding(5, 0, 5, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(74, 28);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp (*):";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(573, 22);
            cboLop.Margin = new Padding(5, 6, 5, 6);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(484, 36);
            cboLop.TabIndex = 3;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(18, 95);
            lblHo.Margin = new Padding(5, 0, 5, 0);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(111, 28);
            lblHo.TabIndex = 4;
            lblHo.Text = "Họ đệm (*):";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(181, 90);
            txtHo.Margin = new Padding(5, 6, 5, 6);
            txtHo.MaxLength = 50;
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(264, 34);
            txtHo.TabIndex = 5;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(488, 95);
            lblTen.Margin = new Padding(5, 0, 5, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(70, 28);
            lblTen.TabIndex = 6;
            lblTen.Text = "Tên (*):";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(573, 90);
            txtTen.Margin = new Padding(5, 6, 5, 6);
            txtTen.MaxLength = 20;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(186, 34);
            txtTen.TabIndex = 7;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(1100, 28);
            lblGioiTinh.Margin = new Padding(5, 0, 5, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(91, 28);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Location = new Point(1194, 22);
            cboGioiTinh.Margin = new Padding(5, 6, 5, 6);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(140, 36);
            cboGioiTinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(818, 94);
            lblNgaySinh.Margin = new Padding(5, 0, 5, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(103, 28);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(18, 162);
            lblDiaChi.Margin = new Padding(5, 0, 5, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(75, 28);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(181, 157);
            txtDiaChi.Margin = new Padding(5, 6, 5, 6);
            txtDiaChi.MaxLength = 100;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(878, 34);
            txtDiaChi.TabIndex = 13;
            // 
            // lblNghiHoc
            // 
            lblNghiHoc.AutoSize = true;
            lblNghiHoc.Location = new Point(1171, 95);
            lblNghiHoc.Margin = new Padding(5, 0, 5, 0);
            lblNghiHoc.Name = "lblNghiHoc";
            lblNghiHoc.Size = new Size(102, 28);
            lblNghiHoc.TabIndex = 14;
            lblNghiHoc.Text = "Trạng thái:";
            // 
            // chkNghiHoc
            // 
            chkNghiHoc.AutoSize = true;
            chkNghiHoc.Location = new Point(1288, 94);
            chkNghiHoc.Margin = new Padding(5, 6, 5, 6);
            chkNghiHoc.Name = "chkNghiHoc";
            chkNghiHoc.Size = new Size(143, 32);
            chkNghiHoc.TabIndex = 15;
            chkNghiHoc.Text = "Đã nghỉ học";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(935, 90);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(149, 34);
            dtpNgaySinh.TabIndex = 16;
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 1232);
            Controls.Add(dgv);
            Controls.Add(pnlTim);
            Controls.Add(pnlNut);
            Controls.Add(pnlNhap);
            Controls.Add(statusStrip);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1341, 1003);
            Name = "FrmSinhVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý sinh viên";
            Load += FrmSinhVien_Load;
            Shown += FrmSinhVien_Shown;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            pnlTim.ResumeLayout(false);
            pnlTim.PerformLayout();
            pnlNut.ResumeLayout(false);
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblLocLop;
        private System.Windows.Forms.ComboBox cboLocLop;
        private QLDSV_HTC.UI.ModernButton btnTim;
        private System.Windows.Forms.Panel pnlNut;
        private QLDSV_HTC.UI.ModernButton btnNhapMoi;
        private QLDSV_HTC.UI.ModernButton btnThem;
        private QLDSV_HTC.UI.ModernButton btnSua;
        private QLDSV_HTC.UI.ModernButton btnXoa;
        private QLDSV_HTC.UI.ModernButton btnTaiLai;
        private QLDSV_HTC.UI.ModernButton btnXuatExcel;
        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNghiHoc;
        private System.Windows.Forms.CheckBox chkNghiHoc;
        private DateTimePicker dtpNgaySinh;
    }
}
