#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmNhapDiem
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
            System.Windows.Forms.DataGridViewCellStyle cellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblLopTinChi = new System.Windows.Forms.Label();
            this.cboLopTinChi = new System.Windows.Forms.ComboBox();
            this.btnTai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
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
            this.dgv.ReadOnly = false;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.TabIndex = 2;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
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
            this.colHoTen.FillWeight = 26F;
            this.colHoTen.ReadOnly = true;
            // colMaLop
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Lớp";
            this.colMaLop.FillWeight = 14F;
            this.colMaLop.ReadOnly = true;
            // colCC
            cellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCC.DefaultCellStyle = cellStyle1;
            this.colCC.Name = "colCC";
            this.colCC.DataPropertyName = "CC";
            this.colCC.HeaderText = "Chuyên cần";
            this.colCC.FillWeight = 12F;
            this.colCC.ReadOnly = false;
            // colGK
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGK.DefaultCellStyle = cellStyle2;
            this.colGK.Name = "colGK";
            this.colGK.DataPropertyName = "GK";
            this.colGK.HeaderText = "Giữa kỳ";
            this.colGK.FillWeight = 12F;
            this.colGK.ReadOnly = false;
            // colCK
            cellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCK.DefaultCellStyle = cellStyle3;
            this.colCK.Name = "colCK";
            this.colCK.DataPropertyName = "CK";
            this.colCK.HeaderText = "Cuối kỳ";
            this.colCK.FillWeight = 12F;
            this.colCK.ReadOnly = false;
            // colTongKet
            cellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colTongKet.DefaultCellStyle = cellStyle4;
            this.colTongKet.Name = "colTongKet";
            this.colTongKet.DataPropertyName = "TongKet";
            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.FillWeight = 12F;
            this.colTongKet.ReadOnly = true;
            // pnlBottom
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(1034, 44);
            this.pnlBottom.TabIndex = 3;
            // btnLuu
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Location = new System.Drawing.Point(10, 6);
            this.btnLuu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu.Text = "Lưu điểm";
            this.btnLuu.TabIndex = 7;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // btnHuy
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Location = new System.Drawing.Point(118, 6);
            this.btnHuy.Size = new System.Drawing.Size(120, 32);
            this.btnHuy.Text = "Hủy thay đổi";
            this.btnHuy.TabIndex = 8;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // lblHuongDan
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Location = new System.Drawing.Point(255, 14);
            this.lblHuongDan.TabIndex = 9;
            this.lblHuongDan.Text = "Tổng kết = CC × 0.1 + GK × 0.3 + CK × 0.6.  CC: số nguyên 0–10;  GK, CK: 0–10, bước 0.5.  Để trống = chưa nhập.";
            // lblThongTin
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTin.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblThongTin.Text = "Chọn niên khóa, học kỳ và lớp tín chỉ rồi bấm 'Tải danh sách'.";
            this.lblThongTin.TabIndex = 1;
            // pnlTop
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1034, 44);
            this.pnlTop.TabIndex = 0;
            // lblNienKhoa
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(10, 14);
            this.lblNienKhoa.Text = "Niên khóa:";
            this.lblNienKhoa.TabIndex = 0;
            // cboNienKhoa
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Location = new System.Drawing.Point(85, 10);
            this.cboNienKhoa.TabIndex = 1;
            this.cboNienKhoa.Size = new System.Drawing.Size(110, 23);
            this.cboNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboNienKhoa_SelectedIndexChanged);
            // lblHocKy
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(210, 14);
            this.lblHocKy.Text = "Học kỳ:";
            this.lblHocKy.TabIndex = 2;
            // cboHocKy
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Location = new System.Drawing.Point(265, 10);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.Size = new System.Drawing.Size(70, 23);
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // lblLopTinChi
            this.lblLopTinChi.Name = "lblLopTinChi";
            this.lblLopTinChi.AutoSize = true;
            this.lblLopTinChi.Location = new System.Drawing.Point(350, 14);
            this.lblLopTinChi.Text = "Lớp tín chỉ:";
            this.lblLopTinChi.TabIndex = 4;
            // cboLopTinChi
            this.cboLopTinChi.Name = "cboLopTinChi";
            this.cboLopTinChi.Location = new System.Drawing.Point(430, 10);
            this.cboLopTinChi.TabIndex = 5;
            this.cboLopTinChi.Size = new System.Drawing.Size(400, 23);
            this.cboLopTinChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopTinChi.FormattingEnabled = true;
            // btnTai
            this.btnTai.Name = "btnTai";
            this.btnTai.Location = new System.Drawing.Point(845, 6);
            this.btnTai.Size = new System.Drawing.Size(130, 32);
            this.btnTai.Text = "Tải danh sách";
            this.btnTai.TabIndex = 6;
            this.btnTai.UseVisualStyleBackColor = true;
            this.btnTai.Click += new System.EventHandler(this.btnTai_Click);
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập điểm";
            this.Name = "FrmNhapDiem";
            this.Load += new System.EventHandler(this.FrmNhapDiem_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNhapDiem_FormClosing);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.pnlTop);
            this.dgv.Columns.Add(this.colMaSV);
            this.dgv.Columns.Add(this.colHoTen);
            this.dgv.Columns.Add(this.colMaLop);
            this.dgv.Columns.Add(this.colCC);
            this.dgv.Columns.Add(this.colGK);
            this.dgv.Columns.Add(this.colCK);
            this.dgv.Columns.Add(this.colTongKet);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.lblHuongDan);
            this.pnlTop.Controls.Add(this.lblNienKhoa);
            this.pnlTop.Controls.Add(this.cboNienKhoa);
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Controls.Add(this.lblLopTinChi);
            this.pnlTop.Controls.Add(this.cboLopTinChi);
            this.pnlTop.Controls.Add(this.btnTai);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblLopTinChi;
        private System.Windows.Forms.ComboBox cboLopTinChi;
        private System.Windows.Forms.Button btnTai;
    }
}
