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
            pnlCard = new Panel();
            lblHeader = new Label();
            lblCu = new Label();
            txtCu = new TextBox();
            lblMoi = new Label();
            txtMoi = new TextBox();
            lblXacNhan = new Label();
            txtXacNhan = new TextBox();
            btnDoi = new QLDSV_HTC.UI.ModernButton();
            btnHuy = new QLDSV_HTC.UI.ModernButton();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblHeader);
            pnlCard.Controls.Add(lblCu);
            pnlCard.Controls.Add(txtCu);
            pnlCard.Controls.Add(lblMoi);
            pnlCard.Controls.Add(txtMoi);
            pnlCard.Controls.Add(lblXacNhan);
            pnlCard.Controls.Add(txtXacNhan);
            pnlCard.Controls.Add(btnDoi);
            pnlCard.Controls.Add(btnHuy);
            pnlCard.Location = new Point(26, 31);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(540, 383);
            pnlCard.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(32, 57, 111);
            lblHeader.Location = new Point(26, 23);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(489, 43);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "🔒 THAY ĐỔI MẬT KHẨU";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCu
            // 
            lblCu.AutoSize = true;
            lblCu.Location = new Point(26, 92);
            lblCu.Margin = new Padding(4, 0, 4, 0);
            lblCu.Name = "lblCu";
            lblCu.Size = new Size(148, 23);
            lblCu.TabIndex = 0;
            lblCu.Text = "Mật khẩu hiện tại:";
            // 
            // txtCu
            // 
            txtCu.Location = new Point(219, 86);
            txtCu.Margin = new Padding(4, 5, 4, 5);
            txtCu.MaxLength = 100;
            txtCu.Name = "txtCu";
            txtCu.Size = new Size(288, 30);
            txtCu.TabIndex = 1;
            txtCu.UseSystemPasswordChar = true;
            // 
            // lblMoi
            // 
            lblMoi.AutoSize = true;
            lblMoi.Location = new Point(26, 153);
            lblMoi.Margin = new Padding(4, 0, 4, 0);
            lblMoi.Name = "lblMoi";
            lblMoi.Size = new Size(120, 23);
            lblMoi.TabIndex = 2;
            lblMoi.Text = "Mật khẩu mới:";
            // 
            // txtMoi
            // 
            txtMoi.Location = new Point(219, 147);
            txtMoi.Margin = new Padding(4, 5, 4, 5);
            txtMoi.MaxLength = 100;
            txtMoi.Name = "txtMoi";
            txtMoi.Size = new Size(288, 30);
            txtMoi.TabIndex = 3;
            txtMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Location = new Point(26, 215);
            lblXacNhan.Margin = new Padding(4, 0, 4, 0);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(155, 23);
            lblXacNhan.TabIndex = 4;
            lblXacNhan.Text = "Nhập lại mật khẩu:";
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(219, 209);
            txtXacNhan.Margin = new Padding(4, 5, 4, 5);
            txtXacNhan.MaxLength = 100;
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(288, 30);
            txtXacNhan.TabIndex = 5;
            txtXacNhan.UseSystemPasswordChar = true;
            // 
            // btnDoi
            // 
            btnDoi.CornerRadius = 6;
            btnDoi.FlatStyle = FlatStyle.Flat;
            btnDoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDoi.Location = new Point(219, 284);
            btnDoi.Margin = new Padding(4, 5, 4, 5);
            btnDoi.Name = "btnDoi";
            btnDoi.Size = new Size(154, 55);
            btnDoi.TabIndex = 6;
            btnDoi.Text = "Đổi mật khẩu";
            btnDoi.UseVisualStyleBackColor = false;
            btnDoi.Variant = UI.ButtonVariant.Primary;
            btnDoi.Click += btnDoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.CornerRadius = 6;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHuy.Location = new Point(386, 284);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(122, 55);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Variant = UI.ButtonVariant.Secondary;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmDoiMatKhau
            // 
            AcceptButton = btnDoi;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 252);
            CancelButton = btnHuy;
            ClientSize = new Size(591, 445);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDoiMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu tài khoản";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
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
