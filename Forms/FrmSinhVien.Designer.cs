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
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colTenLop = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
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
            dtpNgaySinh = new DateTimePicker();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblNghiHoc = new Label();
            chkNghiHoc = new CheckBox();
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
            dgv.Location = new Point(0, 338);
            dgv.Margin = new Padding(4, 5, 4, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1286, 648);
            dgv.TabIndex = 3;
            dgv.AutoGenerateColumns = false;
            dgv.SelectionChanged += dgv_SelectionChanged;
            dgv.Columns.AddRange(new DataGridViewColumn[] {
                colMaSV,
                colHoTen,
                colTenLop,
                colGioiTinh,
                colNgaySinh,
                colDiaChi,
                colTrangThai
            });
            // 
            // colMaSV
            // 
            colMaSV.Name = "colMaSV";
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.FillWeight = 15F;
            colMaSV.MinimumWidth = 90;
            colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.Name = "colHoTen";
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.FillWeight = 25F;
            colHoTen.MinimumWidth = 140;
            colHoTen.ReadOnly = true;
            // 
            // colTenLop
            // 
            colTenLop.Name = "colTenLop";
            colTenLop.DataPropertyName = "TenLop";
            colTenLop.HeaderText = "Lớp";
            colTenLop.FillWeight = 18F;
            colTenLop.MinimumWidth = 110;
            colTenLop.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.FillWeight = 10F;
            colGioiTinh.MinimumWidth = 70;
            colGioiTinh.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.FillWeight = 14F;
            colNgaySinh.MinimumWidth = 95;
            colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgaySinh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.Name = "colDiaChi";
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.FillWeight = 22F;
            colDiaChi.MinimumWidth = 130;
            colDiaChi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.Name = "colTrangThai";
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.FillWeight = 14F;
            colTrangThai.MinimumWidth = 95;
            colTrangThai.ReadOnly = true;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip.Location = new Point(0, 986);
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
            pnlTim.Controls.Add(lblLocLop);
            pnlTim.Controls.Add(cboLocLop);
            pnlTim.Controls.Add(btnTim);
            pnlTim.Dock = DockStyle.Top;
            pnlTim.Location = new Point(0, 264);
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
            lblTim.Size = new Size(75, 23);
            lblTim.TabIndex = 0;
            lblTim.Text = "Từ khóa:";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(96, 18);
            txtTim.Margin = new Padding(4, 5, 4, 5);
            txtTim.MaxLength = 100;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Nhập mã SV, họ tên hoặc địa chỉ...";
            txtTim.Size = new Size(295, 30);
            txtTim.TabIndex = 1;
            txtTim.KeyDown += txtTim_KeyDown;
            // 
            // lblLocLop
            // 
            lblLocLop.AutoSize = true;
            lblLocLop.Location = new Point(418, 23);
            lblLocLop.Margin = new Padding(4, 0, 4, 0);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(42, 23);
            lblLocLop.TabIndex = 2;
            lblLocLop.Text = "Lớp:";
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.Location = new Point(469, 18);
            cboLocLop.Margin = new Padding(4, 5, 4, 5);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(359, 31);
            cboLocLop.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.CornerRadius = 6;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTim.Location = new Point(849, 12);
            btnTim.Margin = new Padding(4, 5, 4, 5);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(122, 49);
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
            pnlNut.Location = new Point(0, 190);
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
            // btnXuatExcel
            // 
            btnXuatExcel.CornerRadius = 6;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(736, 11);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(135, 52);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Variant = UI.ButtonVariant.Success;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // pnlNhap
            // 
            pnlNhap.BackColor = Color.White;
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
            pnlNhap.Controls.Add(dtpNgaySinh);
            pnlNhap.Controls.Add(lblDiaChi);
            pnlNhap.Controls.Add(txtDiaChi);
            pnlNhap.Controls.Add(lblNghiHoc);
            pnlNhap.Controls.Add(chkNghiHoc);
            pnlNhap.Dock = DockStyle.Top;
            pnlNhap.Location = new Point(0, 0);
            pnlNhap.Margin = new Padding(4, 5, 4, 5);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Padding = new Padding(15, 15, 15, 12);
            pnlNhap.Size = new Size(1286, 190);
            pnlNhap.TabIndex = 0;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(15, 23);
            lblMaSV.Margin = new Padding(4, 0, 4, 0);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(132, 23);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên (*):";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(148, 18);
            txtMaSV.Margin = new Padding(4, 5, 4, 5);
            txtMaSV.MaxLength = 10;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(217, 30);
            txtMaSV.TabIndex = 1;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(399, 23);
            lblLop.Margin = new Padding(4, 0, 4, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(64, 23);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp (*):";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(469, 18);
            cboLop.Margin = new Padding(4, 5, 4, 5);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(397, 31);
            cboLop.TabIndex = 3;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(15, 78);
            lblHo.Margin = new Padding(4, 0, 4, 0);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(97, 23);
            lblHo.TabIndex = 4;
            lblHo.Text = "Họ đệm (*):";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(148, 74);
            txtHo.Margin = new Padding(4, 5, 4, 5);
            txtHo.MaxLength = 50;
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(217, 30);
            txtHo.TabIndex = 5;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(399, 78);
            lblTen.Margin = new Padding(4, 0, 4, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(62, 23);
            lblTen.TabIndex = 6;
            lblTen.Text = "Tên (*):";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(469, 74);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.MaxLength = 20;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(153, 30);
            txtTen.TabIndex = 7;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(900, 23);
            lblGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(79, 23);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Location = new Point(977, 18);
            cboGioiTinh.Margin = new Padding(4, 5, 4, 5);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(115, 31);
            cboGioiTinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(656, 78);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(90, 23);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(746, 74);
            dtpNgaySinh.Margin = new Padding(4, 5, 4, 5);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.ShowCheckBox = true;
            dtpNgaySinh.Size = new Size(179, 30);
            dtpNgaySinh.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(15, 133);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(66, 23);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(148, 129);
            txtDiaChi.Margin = new Padding(4, 5, 4, 5);
            txtDiaChi.MaxLength = 100;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(719, 30);
            txtDiaChi.TabIndex = 13;
            // 
            // lblNghiHoc
            // 
            lblNghiHoc.AutoSize = true;
            lblNghiHoc.Location = new Point(958, 78);
            lblNghiHoc.Margin = new Padding(4, 0, 4, 0);
            lblNghiHoc.Name = "lblNghiHoc";
            lblNghiHoc.Size = new Size(91, 23);
            lblNghiHoc.TabIndex = 14;
            lblNghiHoc.Text = "Trạng thái:";
            // 
            // chkNghiHoc
            // 
            chkNghiHoc.AutoSize = true;
            chkNghiHoc.Location = new Point(1054, 77);
            chkNghiHoc.Margin = new Padding(4, 5, 4, 5);
            chkNghiHoc.Name = "chkNghiHoc";
            chkNghiHoc.Size = new Size(125, 27);
            chkNghiHoc.TabIndex = 15;
            chkNghiHoc.Text = "Đã nghỉ học";
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 1012);
            Controls.Add(dgv);
            Controls.Add(pnlTim);
            Controls.Add(pnlNut);
            Controls.Add(pnlNhap);
            Controls.Add(statusStrip);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1101, 834);
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
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNghiHoc;
        private System.Windows.Forms.CheckBox chkNghiHoc;
    }
}
