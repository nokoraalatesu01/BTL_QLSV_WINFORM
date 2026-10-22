#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmBangDiemSV
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
            this.colNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTrungBinh = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
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
            this.dgv.TabIndex = 1;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNienKhoa,
                this.colHocKy,
                this.colMaMH,
                this.colTenMH,
                this.colNhom,
                this.colDiemCC,
                this.colDiemGK,
                this.colDiemCK,
                this.colDiemTK
            });

            // colNienKhoa
            this.colNienKhoa.Name = "colNienKhoa";
            this.colNienKhoa.DataPropertyName = "NienKhoa";
            this.colNienKhoa.HeaderText = "Niên khóa";
            this.colNienKhoa.FillWeight = 11F;
            this.colNienKhoa.ReadOnly = true;

            // colHocKy
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.FillWeight = 7F;
            this.colHocKy.ReadOnly = true;

            // colMaMH
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Mã môn học";
            this.colMaMH.FillWeight = 12F;
            this.colMaMH.ReadOnly = true;

            // colTenMH
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Tên môn học";
            this.colTenMH.FillWeight = 32F;
            this.colTenMH.ReadOnly = true;

            // colNhom
            this.colNhom.Name = "colNhom";
            this.colNhom.DataPropertyName = "Nhom";
            this.colNhom.HeaderText = "Nhóm";
            this.colNhom.FillWeight = 6F;
            this.colNhom.ReadOnly = true;

            // colDiemCC
            cellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDiemCC.DefaultCellStyle = cellStyle1;
            this.colDiemCC.Name = "colDiemCC";
            this.colDiemCC.DataPropertyName = "DiemCC";
            this.colDiemCC.HeaderText = "Chuyên cần";
            this.colDiemCC.FillWeight = 10F;
            this.colDiemCC.ReadOnly = true;

            // colDiemGK
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDiemGK.DefaultCellStyle = cellStyle2;
            this.colDiemGK.Name = "colDiemGK";
            this.colDiemGK.DataPropertyName = "DiemGK";
            this.colDiemGK.HeaderText = "Giữa kỳ";
            this.colDiemGK.FillWeight = 10F;
            this.colDiemGK.ReadOnly = true;

            // colDiemCK
            cellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDiemCK.DefaultCellStyle = cellStyle3;
            this.colDiemCK.Name = "colDiemCK";
            this.colDiemCK.DataPropertyName = "DiemCK";
            this.colDiemCK.HeaderText = "Cuối kỳ";
            this.colDiemCK.FillWeight = 10F;
            this.colDiemCK.ReadOnly = true;

            // colDiemTK
            cellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle4.Font = QLDSV_HTC.UI.Palette.FontSemiBold;
            cellStyle4.ForeColor = QLDSV_HTC.UI.Palette.Primary;
            this.colDiemTK.DefaultCellStyle = cellStyle4;
            this.colDiemTK.Name = "DiemTK";
            this.colDiemTK.DataPropertyName = "DiemTK";
            this.colDiemTK.HeaderText = "Tổng kết";
            this.colDiemTK.FillWeight = 12F;
            this.colDiemTK.ReadOnly = true;

            // ---- pnlTop ----
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1000, 52);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlTop.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlTop.Controls.Add(this.lblIcon);
            this.pnlTop.Controls.Add(this.lblThongTin);

            // lblIcon
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblIcon.Location = new System.Drawing.Point(12, 8);
            this.lblIcon.Size = new System.Drawing.Size(36, 36);
            this.lblIcon.Text = "🎓";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblThongTin
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = QLDSV_HTC.UI.Palette.FontH3;
            this.lblThongTin.ForeColor = QLDSV_HTC.UI.Palette.Navy;
            this.lblThongTin.Location = new System.Drawing.Point(52, 16);
            this.lblThongTin.Text = "Đang nạp thông tin sinh viên...";
            this.lblThongTin.TabIndex = 0;

            // ---- pnlBottom ----
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(1000, 48);
            this.pnlBottom.TabIndex = 2;
            this.pnlBottom.BackColor = QLDSV_HTC.UI.Palette.PrimarySoft;
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlBottom.Controls.Add(this.lblTrungBinh);

            // lblTrungBinh
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Font = QLDSV_HTC.UI.Palette.FontSemiBold;
            this.lblTrungBinh.ForeColor = QLDSV_HTC.UI.Palette.PrimaryDarker;
            this.lblTrungBinh.Location = new System.Drawing.Point(16, 14);
            this.lblTrungBinh.Text = "Đang tính điểm trung bình...";
            this.lblTrungBinh.TabIndex = 0;

            // ---- FrmBangDiemSV ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(860, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng điểm cá nhân";
            this.Name = "FrmBangDiemSV";
            this.Load += new System.EventHandler(this.FrmBangDiemSV_Load);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTK;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTrungBinh;
    }
}
