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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.dgv.Location = new System.Drawing.Point(0, 43);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1201, 715);
            this.dgv.TabIndex = 0;
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrungBinh.Location = new System.Drawing.Point(0, 758);
            this.lblTrungBinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.lblTrungBinh.Size = new System.Drawing.Size(26, 41);
            this.lblTrungBinh.TabIndex = 1;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Padding = new System.Windows.Forms.Padding(13, 12, 13, 6);
            this.lblThongTin.Size = new System.Drawing.Size(26, 43);
            this.lblThongTin.TabIndex = 2;
            // 
            // FrmBangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 799);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.lblThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(972, 619);
            this.Name = "FrmBangDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng điểm cá nhân";
            this.Load += new System.EventHandler(this.FrmBangDiemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblThongTin;
    }
}
