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
            dgv = new DataGridView();
            lblTrungBinh = new Label();
            lblThongTin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersHeight = 29;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 43);
            dgv.Margin = new Padding(4, 5, 4, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1201, 715);
            dgv.TabIndex = 0;
            // 
            // lblTrungBinh
            // 
            lblTrungBinh.AutoSize = true;
            lblTrungBinh.Dock = DockStyle.Bottom;
            lblTrungBinh.Location = new Point(0, 758);
            lblTrungBinh.Margin = new Padding(4, 0, 4, 0);
            lblTrungBinh.Name = "lblTrungBinh";
            lblTrungBinh.Padding = new Padding(13, 9, 13, 9);
            lblTrungBinh.Size = new Size(26, 41);
            lblTrungBinh.TabIndex = 1;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Dock = DockStyle.Top;
            lblThongTin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblThongTin.Location = new Point(0, 0);
            lblThongTin.Margin = new Padding(4, 0, 4, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Padding = new Padding(13, 12, 13, 6);
            lblThongTin.Size = new Size(26, 43);
            lblThongTin.TabIndex = 2;
            // 
            // FrmBangDiemSV
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 799);
            Controls.Add(dgv);
            Controls.Add(lblTrungBinh);
            Controls.Add(lblThongTin);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(972, 619);
            Name = "FrmBangDiemSV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bảng điểm cá nhân";
            Load += FrmBangDiemSV_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblThongTin;
    }
}
