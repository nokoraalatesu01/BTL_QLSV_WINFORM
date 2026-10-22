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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCu = new System.Windows.Forms.Label();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.lblMoi = new System.Windows.Forms.Label();
            this.txtMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnDoi = new QLDSV_HTC.UI.ModernButton();
            this.btnHuy = new QLDSV_HTC.UI.ModernButton();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ---- pnlCard ----
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.BackColor = QLDSV_HTC.UI.Palette.Surface;
            this.pnlCard.Location = new System.Drawing.Point(20, 20);
            this.pnlCard.Size = new System.Drawing.Size(420, 250);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Controls.Add(this.lblHeader);
            this.pnlCard.Controls.Add(this.lblCu);
            this.pnlCard.Controls.Add(this.txtCu);
            this.pnlCard.Controls.Add(this.lblMoi);
            this.pnlCard.Controls.Add(this.txtMoi);
            this.pnlCard.Controls.Add(this.lblXacNhan);
            this.pnlCard.Controls.Add(this.txtXacNhan);
            this.pnlCard.Controls.Add(this.btnDoi);
            this.pnlCard.Controls.Add(this.btnHuy);

            // lblHeader
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Font = QLDSV_HTC.UI.Palette.FontH3;
            this.lblHeader.ForeColor = QLDSV_HTC.UI.Palette.Navy;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Size = new System.Drawing.Size(380, 28);
            this.lblHeader.Text = "🔒 THAY ĐỔI MẬT KHẨU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblCu
            this.lblCu.Name = "lblCu";
            this.lblCu.AutoSize = true;
            this.lblCu.Location = new System.Drawing.Point(20, 60);
            this.lblCu.Text = "Mật khẩu hiện tại:";
            this.lblCu.TabIndex = 0;

            // txtCu
            this.txtCu.Name = "txtCu";
            this.txtCu.Location = new System.Drawing.Point(170, 56);
            this.txtCu.Size = new System.Drawing.Size(225, 23);
            this.txtCu.MaxLength = 100;
            this.txtCu.UseSystemPasswordChar = true;
            this.txtCu.TabIndex = 1;

            // lblMoi
            this.lblMoi.Name = "lblMoi";
            this.lblMoi.AutoSize = true;
            this.lblMoi.Location = new System.Drawing.Point(20, 100);
            this.lblMoi.Text = "Mật khẩu mới:";
            this.lblMoi.TabIndex = 2;

            // txtMoi
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.Location = new System.Drawing.Point(170, 96);
            this.txtMoi.Size = new System.Drawing.Size(225, 23);
            this.txtMoi.MaxLength = 100;
            this.txtMoi.UseSystemPasswordChar = true;
            this.txtMoi.TabIndex = 3;

            // lblXacNhan
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Location = new System.Drawing.Point(20, 140);
            this.lblXacNhan.Text = "Nhập lại mật khẩu:";
            this.lblXacNhan.TabIndex = 4;

            // txtXacNhan
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Location = new System.Drawing.Point(170, 136);
            this.txtXacNhan.Size = new System.Drawing.Size(225, 23);
            this.txtXacNhan.MaxLength = 100;
            this.txtXacNhan.UseSystemPasswordChar = true;
            this.txtXacNhan.TabIndex = 5;

            // btnDoi
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Location = new System.Drawing.Point(170, 185);
            this.btnDoi.Size = new System.Drawing.Size(120, 36);
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.Variant = QLDSV_HTC.UI.ButtonVariant.Primary;
            this.btnDoi.TabIndex = 6;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);

            // btnHuy
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Location = new System.Drawing.Point(300, 185);
            this.btnHuy.Size = new System.Drawing.Size(95, 36);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Variant = QLDSV_HTC.UI.ButtonVariant.Secondary;
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // ---- FrmDoiMatKhau ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = QLDSV_HTC.UI.Palette.Canvas;
            this.ClientSize = new System.Drawing.Size(460, 290);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu tài khoản";
            this.AcceptButton = this.btnDoi;
            this.CancelButton = this.btnHuy;
            this.Name = "FrmDoiMatKhau";
            this.Controls.Add(this.pnlCard);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCu;
        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.Label lblMoi;
        private System.Windows.Forms.TextBox txtMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;
        private QLDSV_HTC.UI.ModernButton btnDoi;
        private QLDSV_HTC.UI.ModernButton btnHuy;
    }
}
