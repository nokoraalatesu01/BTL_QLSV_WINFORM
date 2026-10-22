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
            this.colHocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTim = new System.Windows.Forms.Panel();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHocVi = new System.Windows.Forms.Label();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.lblHocHam = new System.Windows.Forms.Label();
            this.txtHocHam = new System.Windows.Forms.TextBox();
            this.lblChuyenMon = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
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
            // colMaGV
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.FillWeight = 10F;
            this.colMaGV.ReadOnly = true;
            // colHoTen
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.FillWeight = 22F;
            this.colHoTen.ReadOnly = true;
            // colHocVi
            this.colHocVi.Name = "colHocVi";
            this.colHocVi.DataPropertyName = "HocVi";
            this.colHocVi.HeaderText = "Học vị";
            this.colHocVi.FillWeight = 11F;
            this.colHocVi.ReadOnly = true;
            // colHocHam
            this.colHocHam.Name = "colHocHam";
            this.colHocHam.DataPropertyName = "HocHam";
            this.colHocHam.HeaderText = "Học hàm";
            this.colHocHam.FillWeight = 9F;
            this.colHocHam.ReadOnly = true;
            // colChuyenMon
            this.colChuyenMon.Name = "colChuyenMon";
            this.colChuyenMon.DataPropertyName = "ChuyenMon";
            this.colChuyenMon.HeaderText = "Chuyên môn";
            this.colChuyenMon.FillWeight = 24F;
            this.colChuyenMon.ReadOnly = true;
            // colTenKhoa
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.DataPropertyName = "TenKhoa";
            this.colTenKhoa.HeaderText = "Khoa";
            this.colTenKhoa.FillWeight = 24F;
            this.colTenKhoa.ReadOnly = true;
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
            this.lblTim.Text = "Tìm kiếm:";
            this.lblTim.TabIndex = 19;
            // txtTim
            this.txtTim.Name = "txtTim";
            this.txtTim.Location = new System.Drawing.Point(90, 10);
            this.txtTim.TabIndex = 20;
            this.txtTim.Size = new System.Drawing.Size(240, 23);
            this.txtTim.MaxLength = 100;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(344, 6);
            this.btnTim.Size = new System.Drawing.Size(100, 32);
            this.btnTim.Text = "Tìm";
            this.btnTim.TabIndex = 21;
            this.btnTim.UseVisualStyleBackColor = true;
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
            this.btnNhapMoi.TabIndex = 14;
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(118, 6);
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(226, 6);
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.TabIndex = 16;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(334, 6);
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TabIndex = 17;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnTaiLai
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Location = new System.Drawing.Point(442, 6);
            this.btnTaiLai.Size = new System.Drawing.Size(100, 32);
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.TabIndex = 18;
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // pnlNhap
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Size = new System.Drawing.Size(1034, 154);
            this.pnlNhap.TabIndex = 0;
            // lblMaGV
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(10, 15);
            this.lblMaGV.Text = "Mã giảng viên:";
            this.lblMaGV.TabIndex = 0;
            // txtMaGV
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Location = new System.Drawing.Point(140, 12);
            this.txtMaGV.TabIndex = 1;
            this.txtMaGV.Size = new System.Drawing.Size(260, 23);
            this.txtMaGV.MaxLength = 10;
            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(440, 15);
            this.lblKhoa.Text = "Khoa:";
            this.lblKhoa.TabIndex = 2;
            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(570, 12);
            this.cboKhoa.TabIndex = 3;
            this.cboKhoa.Size = new System.Drawing.Size(300, 23);
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
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
            // lblHocVi
            this.lblHocVi.Name = "lblHocVi";
            this.lblHocVi.AutoSize = true;
            this.lblHocVi.Location = new System.Drawing.Point(10, 83);
            this.lblHocVi.Text = "Học vị:";
            this.lblHocVi.TabIndex = 8;
            // txtHocVi
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Location = new System.Drawing.Point(140, 80);
            this.txtHocVi.TabIndex = 9;
            this.txtHocVi.Size = new System.Drawing.Size(260, 23);
            this.txtHocVi.MaxLength = 20;
            // lblHocHam
            this.lblHocHam.Name = "lblHocHam";
            this.lblHocHam.AutoSize = true;
            this.lblHocHam.Location = new System.Drawing.Point(440, 83);
            this.lblHocHam.Text = "Học hàm:";
            this.lblHocHam.TabIndex = 10;
            // txtHocHam
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Location = new System.Drawing.Point(570, 80);
            this.txtHocHam.TabIndex = 11;
            this.txtHocHam.Size = new System.Drawing.Size(300, 23);
            this.txtHocHam.MaxLength = 20;
            // lblChuyenMon
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Location = new System.Drawing.Point(10, 117);
            this.lblChuyenMon.Text = "Chuyên môn:";
            this.lblChuyenMon.TabIndex = 12;
            // txtChuyenMon
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Location = new System.Drawing.Point(140, 114);
            this.txtChuyenMon.TabIndex = 13;
            this.txtChuyenMon.Size = new System.Drawing.Size(260, 23);
            this.txtChuyenMon.MaxLength = 50;
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý giảng viên";
            this.Name = "FrmGiangVien";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.Shown += new System.EventHandler(this.FrmGiangVien_Shown);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.dgv.Columns.Add(this.colMaGV);
            this.dgv.Columns.Add(this.colHoTen);
            this.dgv.Columns.Add(this.colHocVi);
            this.dgv.Columns.Add(this.colHocHam);
            this.dgv.Columns.Add(this.colChuyenMon);
            this.dgv.Columns.Add(this.colTenKhoa);
            this.statusStrip.Items.Add(this.lblTrangThai);
            this.pnlTim.Controls.Add(this.lblTim);
            this.pnlTim.Controls.Add(this.txtTim);
            this.pnlTim.Controls.Add(this.btnTim);
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Controls.Add(this.btnTaiLai);
            this.pnlNhap.Controls.Add(this.lblMaGV);
            this.pnlNhap.Controls.Add(this.txtMaGV);
            this.pnlNhap.Controls.Add(this.lblKhoa);
            this.pnlNhap.Controls.Add(this.cboKhoa);
            this.pnlNhap.Controls.Add(this.lblHo);
            this.pnlNhap.Controls.Add(this.txtHo);
            this.pnlNhap.Controls.Add(this.lblTen);
            this.pnlNhap.Controls.Add(this.txtTen);
            this.pnlNhap.Controls.Add(this.lblHocVi);
            this.pnlNhap.Controls.Add(this.txtHocVi);
            this.pnlNhap.Controls.Add(this.lblHocHam);
            this.pnlNhap.Controls.Add(this.txtHocHam);
            this.pnlNhap.Controls.Add(this.lblChuyenMon);
            this.pnlNhap.Controls.Add(this.txtChuyenMon);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTim.ResumeLayout(false);
            this.pnlNut.ResumeLayout(false);
            this.pnlNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
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
