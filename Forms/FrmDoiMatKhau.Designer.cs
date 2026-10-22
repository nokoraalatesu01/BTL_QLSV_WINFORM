#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmDoiMatKhau
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
            this.lblCu = new System.Windows.Forms.Label();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.lblMoi = new System.Windows.Forms.Label();
            this.txtMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblCu
            this.lblCu.Name = "lblCu";
            this.lblCu.AutoSize = true;
            this.lblCu.Location = new System.Drawing.Point(15, 24);
            this.lblCu.Text = "Mật khẩu hiện tại:";
            this.lblCu.TabIndex = 0;
            // txtCu
            this.txtCu.Name = "txtCu";
            this.txtCu.Location = new System.Drawing.Point(190, 20);
            this.txtCu.Size = new System.Drawing.Size(190, 23);
            this.txtCu.MaxLength = 100;
            this.txtCu.UseSystemPasswordChar = true;
            this.txtCu.TabIndex = 1;
            // lblMoi
            this.lblMoi.Name = "lblMoi";
            this.lblMoi.AutoSize = true;
            this.lblMoi.Location = new System.Drawing.Point(15, 64);
            this.lblMoi.Text = "Mật khẩu mới:";
            this.lblMoi.TabIndex = 2;
            // txtMoi
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.Location = new System.Drawing.Point(190, 60);
            this.txtMoi.Size = new System.Drawing.Size(190, 23);
            this.txtMoi.MaxLength = 100;
            this.txtMoi.UseSystemPasswordChar = true;
            this.txtMoi.TabIndex = 3;
            // lblXacNhan
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Location = new System.Drawing.Point(15, 104);
            this.lblXacNhan.Text = "Nhập lại mật khẩu mới:";
            this.lblXacNhan.TabIndex = 4;
            // txtXacNhan
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Location = new System.Drawing.Point(190, 100);
            this.txtXacNhan.Size = new System.Drawing.Size(190, 23);
            this.txtXacNhan.MaxLength = 100;
            this.txtXacNhan.UseSystemPasswordChar = true;
            this.txtXacNhan.TabIndex = 5;
            // btnDoi
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Location = new System.Drawing.Point(160, 152);
            this.btnDoi.Size = new System.Drawing.Size(110, 32);
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.TabIndex = 6;
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // btnHuy
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Location = new System.Drawing.Point(280, 152);
            this.btnHuy.Size = new System.Drawing.Size(100, 32);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TabIndex = 7;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // this
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.AcceptButton = this.btnDoi;
            this.CancelButton = this.btnHuy;
            this.Name = "FrmDoiMatKhau";
            this.Controls.Add(this.lblCu);
            this.Controls.Add(this.txtCu);
            this.Controls.Add(this.lblMoi);
            this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.btnHuy);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCu;
        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.Label lblMoi;
        private System.Windows.Forms.TextBox txtMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Button btnHuy;
    }
}
