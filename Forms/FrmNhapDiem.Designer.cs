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
            dgv = new QLDSV_HTC.UI.EnterGridView();
            pnlBottom = new Panel();
            btnLuu = new QLDSV_HTC.UI.ModernButton();
            btnHuy = new QLDSV_HTC.UI.ModernButton();
            btnXuatExcel = new QLDSV_HTC.UI.ModernButton();
            lblHuongDan = new Label();
            lblThongTin = new Label();
            pnlTop = new Panel();
            lblNienKhoa = new Label();
            cboNienKhoa = new ComboBox();
            lblHocKy = new Label();
            cboHocKy = new ComboBox();
            lblLopTinChi = new Label();
            cboLopTinChi = new ComboBox();
            btnTai = new QLDSV_HTC.UI.ModernButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
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
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.Location = new Point(0, 129);
            dgv.Margin = new Padding(4, 5, 4, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1329, 749);
            dgv.TabIndex = 2;
            dgv.CellBeginEdit += dgv_CellBeginEdit;
            dgv.CellEndEdit += dgv_CellEndEdit;
            dgv.DataError += dgv_DataError;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnLuu);
            pnlBottom.Controls.Add(btnHuy);
            pnlBottom.Controls.Add(btnXuatExcel);
            pnlBottom.Controls.Add(lblHuongDan);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 878);
            pnlBottom.Margin = new Padding(4, 5, 4, 5);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1329, 74);
            pnlBottom.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.CornerRadius = 6;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLuu.Location = new Point(15, 12);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(141, 49);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "💾 Lưu điểm";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Variant = UI.ButtonVariant.Success;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.CornerRadius = 6;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHuy.Location = new Point(167, 12);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(141, 49);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy thay đổi";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Variant = UI.ButtonVariant.Secondary;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.CornerRadius = 6;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(319, 12);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(161, 49);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = "📊 Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Variant = UI.ButtonVariant.Primary;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // lblHuongDan
            // 
            lblHuongDan.AutoSize = true;
            lblHuongDan.ForeColor = Color.FromArgb(113, 128, 150);
            lblHuongDan.Location = new Point(496, 25);
            lblHuongDan.Margin = new Padding(4, 0, 4, 0);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(743, 23);
            lblHuongDan.TabIndex = 10;
            lblHuongDan.Text = "Công thức: Tổng kết = CC × 0.1 + GK × 0.3 + CK × 0.6. CC: 0-10 nguyên; GK, CK: 0-10 bước 0.5.";
            // 
            // lblThongTin
            // 
            lblThongTin.BackColor = Color.FromArgb(232, 239, 253);
            lblThongTin.Dock = DockStyle.Top;
            lblThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblThongTin.ForeColor = Color.FromArgb(22, 62, 154);
            lblThongTin.Location = new Point(0, 74);
            lblThongTin.Margin = new Padding(4, 0, 4, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Padding = new Padding(15, 12, 15, 12);
            lblThongTin.Size = new Size(1329, 55);
            lblThongTin.TabIndex = 1;
            lblThongTin.Text = "Chọn niên khóa, học kỳ và lớp tín chỉ rồi bấm 'Tải danh sách'.";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblNienKhoa);
            pnlTop.Controls.Add(cboNienKhoa);
            pnlTop.Controls.Add(lblHocKy);
            pnlTop.Controls.Add(cboHocKy);
            pnlTop.Controls.Add(lblLopTinChi);
            pnlTop.Controls.Add(cboLopTinChi);
            pnlTop.Controls.Add(btnTai);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 5, 4, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10, 12, 10, 12);
            pnlTop.Size = new Size(1329, 74);
            pnlTop.TabIndex = 0;
            // 
            // lblNienKhoa
            // 
            lblNienKhoa.AutoSize = true;
            lblNienKhoa.Location = new Point(15, 21);
            lblNienKhoa.Margin = new Padding(4, 0, 4, 0);
            lblNienKhoa.Name = "lblNienKhoa";
            lblNienKhoa.Size = new Size(92, 23);
            lblNienKhoa.TabIndex = 0;
            lblNienKhoa.Text = "Niên khóa:";
            // 
            // cboNienKhoa
            // 
            cboNienKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNienKhoa.Location = new Point(105, 17);
            cboNienKhoa.Margin = new Padding(4, 5, 4, 5);
            cboNienKhoa.Name = "cboNienKhoa";
            cboNienKhoa.Size = new Size(140, 31);
            cboNienKhoa.TabIndex = 1;
            cboNienKhoa.SelectedIndexChanged += cboNienKhoa_SelectedIndexChanged;
            // 
            // lblHocKy
            // 
            lblHocKy.AutoSize = true;
            lblHocKy.Location = new Point(264, 21);
            lblHocKy.Margin = new Padding(4, 0, 4, 0);
            lblHocKy.Name = "lblHocKy";
            lblHocKy.Size = new Size(65, 23);
            lblHocKy.TabIndex = 2;
            lblHocKy.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            cboHocKy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHocKy.Location = new Point(332, 17);
            cboHocKy.Margin = new Padding(4, 5, 4, 5);
            cboHocKy.Name = "cboHocKy";
            cboHocKy.Size = new Size(82, 31);
            cboHocKy.TabIndex = 3;
            cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged;
            // 
            // lblLopTinChi
            // 
            lblLopTinChi.AutoSize = true;
            lblLopTinChi.Location = new Point(431, 21);
            lblLopTinChi.Margin = new Padding(4, 0, 4, 0);
            lblLopTinChi.Name = "lblLopTinChi";
            lblLopTinChi.Size = new Size(94, 23);
            lblLopTinChi.TabIndex = 4;
            lblLopTinChi.Text = "Lớp tín chỉ:";
            // 
            // cboLopTinChi
            // 
            cboLopTinChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopTinChi.Location = new Point(525, 17);
            cboLopTinChi.Margin = new Padding(4, 5, 4, 5);
            cboLopTinChi.Name = "cboLopTinChi";
            cboLopTinChi.Size = new Size(487, 31);
            cboLopTinChi.TabIndex = 5;
            // 
            // btnTai
            // 
            btnTai.CornerRadius = 6;
            btnTai.FlatStyle = FlatStyle.Flat;
            btnTai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTai.Location = new Point(1029, 11);
            btnTai.Margin = new Padding(4, 5, 4, 5);
            btnTai.Name = "btnTai";
            btnTai.Size = new Size(161, 49);
            btnTai.TabIndex = 6;
            btnTai.Text = "Tải danh sách";
            btnTai.UseVisualStyleBackColor = false;
            btnTai.Variant = UI.ButtonVariant.Primary;
            btnTai.Click += btnTai_Click;
            // 
            // FrmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 952);
            Controls.Add(dgv);
            Controls.Add(lblThongTin);
            Controls.Add(pnlTop);
            Controls.Add(pnlBottom);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1101, 772);
            Name = "FrmNhapDiem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập điểm";
            FormClosing += FrmNhapDiem_FormClosing;
            Load += FrmNhapDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private QLDSV_HTC.UI.EnterGridView dgv;
        private System.Windows.Forms.Panel pnlBottom;
        private QLDSV_HTC.UI.ModernButton btnLuu;
        private QLDSV_HTC.UI.ModernButton btnHuy;
        private QLDSV_HTC.UI.ModernButton btnXuatExcel;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblLopTinChi;
        private System.Windows.Forms.ComboBox cboLopTinChi;
        private QLDSV_HTC.UI.ModernButton btnTai;
    }
}
