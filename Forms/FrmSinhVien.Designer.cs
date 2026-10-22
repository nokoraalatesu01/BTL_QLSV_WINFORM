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
            System.Windows.Forms.DataGridViewCellStyle cellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTim = new System.Windows.Forms.Panel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblLocLop = new System.Windows.Forms.Label();
            this.cboLocLop = new System.Windows.Forms.ComboBox();
            this.btnTim = new QLDSV_HTC.UI.ModernButton();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new QLDSV_HTC.UI.ModernButton();
            this.btnThem = new QLDSV_HTC.UI.ModernButton();
            this.btnSua = new QLDSV_HTC.UI.ModernButton();
            this.btnXoa = new QLDSV_HTC.UI.ModernButton();
            this.btnTaiLai = new QLDSV_HTC.UI.ModernButton();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNghiHoc = new System.Windows.Forms.Label();
            this.chkNghiHoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            // colMaSV
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.DataPropertyName = "MaSV";
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.FillWeight = 12F;
            this.colMaSV.ReadOnly = true;
            // colHoTen
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.FillWeight = 22F;
            this.colHoTen.ReadOnly = true;
            // colTenLop
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Lớp";
            this.colTenLop.FillWeight = 22F;
            this.colTenLop.ReadOnly = true;
            // colGioiTinh
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.FillWeight = 9F;
            this.colGioiTinh.ReadOnly = true;
            // colNgaySinh
            cellStyle1.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = cellStyle1;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.FillWeight = 12F;
            this.colNgaySinh.ReadOnly = true;
            // colDiaChi
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.FillWeight = 15F;
            this.colDiaChi.ReadOnly = true;
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
            // lblTim
            this.lblTim.Name = "lblTim";
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(10, 13);
            this.lblTim.Text = "Từ khóa:";
            this.lblTim.TabIndex = 21;
            // txtTim
            this.txtTim.Name = "txtTim";
            this.txtTim.Location = new System.Drawing.Point(82, 10);
            this.txtTim.TabIndex = 22;
            this.txtTim.Size = new System.Drawing.Size(220, 23);
            this.txtTim.MaxLength = 100;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // lblLocLop
            this.lblLocLop.Name = "lblLocLop";
            this.lblLocLop.AutoSize = true;
            this.lblLocLop.Location = new System.Drawing.Point(316, 13);
            this.lblLocLop.Text = "Lớp:";
            this.lblLocLop.TabIndex = 23;
            // cboLocLop
            this.cboLocLop.Name = "cboLocLop";
            this.cboLocLop.Location = new System.Drawing.Point(356, 10);
            this.cboLocLop.TabIndex = 24;
            this.cboLocLop.Size = new System.Drawing.Size(280, 23);
            this.cboLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLop.FormattingEnabled = true;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(650, 6);
            this.btnTim.Size = new System.Drawing.Size(100, 32);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TabIndex = 25;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            this.btnNhapMoi.TabIndex = 16;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(118, 6);
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.TabIndex = 17;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(226, 6);
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.TabIndex = 18;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(334, 6);
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnTaiLai
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Location = new System.Drawing.Point(442, 6);
            this.btnTaiLai.Size = new System.Drawing.Size(100, 32);
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.TabIndex = 20;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // pnlNhap
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Size = new System.Drawing.Size(1034, 154);
            this.pnlNhap.TabIndex = 0;
            // lblMaSV
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(10, 15);
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.TabIndex = 0;
            // txtMaSV
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Location = new System.Drawing.Point(140, 12);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.Size = new System.Drawing.Size(260, 23);
            this.txtMaSV.MaxLength = 10;
            // lblLop
            this.lblLop.Name = "lblLop";
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(440, 15);
            this.lblLop.Text = "Lớp:";
            this.lblLop.TabIndex = 2;
            // cboLop
            this.cboLop.Name = "cboLop";
            this.cboLop.Location = new System.Drawing.Point(570, 12);
            this.cboLop.TabIndex = 3;
            this.cboLop.Size = new System.Drawing.Size(300, 23);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            // lblHo
            this.lblHo.Name = "lblHo";
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(10, 49);
            this.lblHo.Text = "Họ:";
            this.lblHo.TabIndex = 4;
            // txtHo
            this.txtHo.Name = "txtHo";
            this.txtHo.Location = new System.Drawing.Point(140, 46);
            this.txtHo.TabIndex = 5;
            this.txtHo.Size = new System.Drawing.Size(260, 23);
            this.txtHo.MaxLength = 50;
            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(440, 49);
            this.lblTen.Text = "Tên:";
            this.lblTen.TabIndex = 6;
            // txtTen
            this.txtTen.Name = "txtTen";
            this.txtTen.Location = new System.Drawing.Point(570, 46);
            this.txtTen.TabIndex = 7;
            this.txtTen.Size = new System.Drawing.Size(300, 23);
            this.txtTen.MaxLength = 20;
            // lblGioiTinh
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(10, 83);
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.TabIndex = 8;
            // cboGioiTinh
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Location = new System.Drawing.Point(140, 80);
            this.cboGioiTinh.TabIndex = 9;
            this.cboGioiTinh.Size = new System.Drawing.Size(100, 23);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            // lblNgaySinh
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(440, 83);
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.TabIndex = 10;
            // dtpNgaySinh
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Location = new System.Drawing.Point(570, 80);
            this.dtpNgaySinh.TabIndex = 11;
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 23);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.ShowCheckBox = true;
            // lblDiaChi
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(10, 117);
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.TabIndex = 12;
            // txtDiaChi
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Location = new System.Drawing.Point(140, 114);
            this.txtDiaChi.TabIndex = 13;
            this.txtDiaChi.Size = new System.Drawing.Size(260, 23);
            this.txtDiaChi.MaxLength = 100;
            // lblNghiHoc
            this.lblNghiHoc.Name = "lblNghiHoc";
            this.lblNghiHoc.AutoSize = true;
            this.lblNghiHoc.Location = new System.Drawing.Point(440, 117);
            this.lblNghiHoc.Text = "Trạng thái:";
            this.lblNghiHoc.TabIndex = 14;
            // chkNghiHoc
            this.chkNghiHoc.Name = "chkNghiHoc";
            this.chkNghiHoc.Location = new System.Drawing.Point(570, 114);
            this.chkNghiHoc.TabIndex = 15;
            this.chkNghiHoc.AutoSize = true;
            this.chkNghiHoc.Text = "Đã nghỉ học";
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sinh viên";
            this.Name = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.Shown += new System.EventHandler(this.FrmSinhVien_Shown);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.dgv.Columns.Add(this.colMaSV);
            this.dgv.Columns.Add(this.colHoTen);
            this.dgv.Columns.Add(this.colTenLop);
            this.dgv.Columns.Add(this.colGioiTinh);
            this.dgv.Columns.Add(this.colNgaySinh);
            this.dgv.Columns.Add(this.colDiaChi);
            this.dgv.Columns.Add(this.colTrangThai);
            this.statusStrip.Items.Add(this.lblTrangThai);
            this.pnlTim.Controls.Add(this.lblTim);
            this.pnlTim.Controls.Add(this.txtTim);
            this.pnlTim.Controls.Add(this.lblLocLop);
            this.pnlTim.Controls.Add(this.cboLocLop);
            this.pnlTim.Controls.Add(this.btnTim);
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Controls.Add(this.btnTaiLai);
            this.pnlNhap.Controls.Add(this.lblMaSV);
            this.pnlNhap.Controls.Add(this.txtMaSV);
            this.pnlNhap.Controls.Add(this.lblLop);
            this.pnlNhap.Controls.Add(this.cboLop);
            this.pnlNhap.Controls.Add(this.lblHo);
            this.pnlNhap.Controls.Add(this.txtHo);
            this.pnlNhap.Controls.Add(this.lblTen);
            this.pnlNhap.Controls.Add(this.txtTen);
            this.pnlNhap.Controls.Add(this.lblGioiTinh);
            this.pnlNhap.Controls.Add(this.cboGioiTinh);
            this.pnlNhap.Controls.Add(this.lblNgaySinh);
            this.pnlNhap.Controls.Add(this.dtpNgaySinh);
            this.pnlNhap.Controls.Add(this.lblDiaChi);
            this.pnlNhap.Controls.Add(this.txtDiaChi);
            this.pnlNhap.Controls.Add(this.lblNghiHoc);
            this.pnlNhap.Controls.Add(this.chkNghiHoc);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTim.ResumeLayout(false);
            this.pnlNut.ResumeLayout(false);
            this.pnlNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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
