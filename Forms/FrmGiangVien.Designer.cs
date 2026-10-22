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
            this.statusStrip.SuspendLayout();
            this.pnlTim.SuspendLayout();
            this.pnlNut.SuspendLayout();
            this.pnlNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 370);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1329, 556);
            this.dgv.TabIndex = 3;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblTrangThai });
            this.statusStrip.Location = new System.Drawing.Point(0, 926);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(1329, 26);
            this.statusStrip.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(71, 20);
            this.lblTrangThai.Text = "Sẵn sàng.";
            // 
            // pnlTim
            // 
            this.pnlTim.Controls.Add(this.lblTim);
            this.pnlTim.Controls.Add(this.txtTim);
            this.pnlTim.Controls.Add(this.btnTim);
            this.pnlTim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTim.Location = new System.Drawing.Point(0, 303);
            this.pnlTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTim.Name = "pnlTim";
            this.pnlTim.Size = new System.Drawing.Size(1329, 67);
            this.pnlTim.TabIndex = 2;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(13, 20);
            this.lblTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(83, 23);
            this.lblTim.TabIndex = 19;
            this.lblTim.Text = "Tìm kiếm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(116, 15);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.MaxLength = 100;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(307, 30);
            this.txtTim.TabIndex = 20;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(442, 9);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 49);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // pnlNut
            // 
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Controls.Add(this.btnTaiLai);
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNut.Location = new System.Drawing.Point(0, 236);
            this.pnlNut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Size = new System.Drawing.Size(1329, 67);
            this.pnlNut.TabIndex = 1;
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(13, 9);
            this.btnNhapMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(129, 49);
            this.btnNhapMoi.TabIndex = 14;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(152, 9);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 49);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(291, 9);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 49);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(429, 9);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 49);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(568, 9);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(129, 49);
            this.btnTaiLai.TabIndex = 18;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // pnlNhap
            // 
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
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Size = new System.Drawing.Size(1329, 236);
            this.pnlNhap.TabIndex = 0;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(13, 23);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(122, 23);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã giảng viên:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(180, 18);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaGV.MaxLength = 10;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(333, 30);
            this.txtMaGV.TabIndex = 1;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(566, 23);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(53, 23);
            this.lblKhoa.TabIndex = 2;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(733, 18);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(385, 31);
            this.cboKhoa.TabIndex = 3;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(13, 75);
            this.lblHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(36, 23);
            this.lblHo.TabIndex = 4;
            this.lblHo.Text = "Họ:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(180, 71);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHo.MaxLength = 50;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(333, 30);
            this.txtHo.TabIndex = 5;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(566, 75);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(40, 23);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(733, 71);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.MaxLength = 20;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(385, 30);
            this.txtTen.TabIndex = 7;
            // 
            // lblHocVi
            // 
            this.lblHocVi.AutoSize = true;
            this.lblHocVi.Location = new System.Drawing.Point(13, 127);
            this.lblHocVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocVi.Name = "lblHocVi";
            this.lblHocVi.Size = new System.Drawing.Size(61, 23);
            this.lblHocVi.TabIndex = 8;
            this.lblHocVi.Text = "Học vị:";
            // 
            // txtHocVi
            // 
            this.txtHocVi.Location = new System.Drawing.Point(180, 123);
            this.txtHocVi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHocVi.MaxLength = 20;
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(333, 30);
            this.txtHocVi.TabIndex = 9;
            // 
            // lblHocHam
            // 
            this.lblHocHam.AutoSize = true;
            this.lblHocHam.Location = new System.Drawing.Point(566, 127);
            this.lblHocHam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocHam.Name = "lblHocHam";
            this.lblHocHam.Size = new System.Drawing.Size(83, 23);
            this.lblHocHam.TabIndex = 10;
            this.lblHocHam.Text = "Học hàm:";
            // 
            // txtHocHam
            // 
            this.txtHocHam.Location = new System.Drawing.Point(733, 123);
            this.txtHocHam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHocHam.MaxLength = 20;
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(385, 30);
            this.txtHocHam.TabIndex = 11;
            // 
            // lblChuyenMon
            // 
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Location = new System.Drawing.Point(13, 179);
            this.lblChuyenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.Size = new System.Drawing.Size(112, 23);
            this.lblChuyenMon.TabIndex = 12;
            this.lblChuyenMon.Text = "Chuyên môn:";
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Location = new System.Drawing.Point(180, 175);
            this.txtChuyenMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChuyenMon.MaxLength = 50;
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(333, 30);
            this.txtChuyenMon.TabIndex = 13;
            // 
            // FrmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 952);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlTim);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1101, 772);
            this.Name = "FrmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.FrmGiangVien_Load);
            this.Shown += new System.EventHandler(this.FrmGiangVien_Shown);
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
