using System.Drawing;
using System.Windows.Forms;

namespace Demo_Layout
{
    partial class XacNhanMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDe;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Button btnDongY;
        private Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblMatKhau = new Label();
            this.txtMatKhau = new TextBox();
            this.btnDongY = new Button();
            this.btnHuy = new Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTieuDe.Location = new Point(16, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(332, 25);
            this.lblTieuDe.Text = "Nhập mật khẩu để xác nhận xóa";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new Point(16, 60);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new Size(90, 20);
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new Point(120, 56);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new Size(260, 27);
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new Point(200, 105);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new Size(85, 32);
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new Point(295, 105);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new Size(85, 32);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // XacNhanMatKhau
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 160);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XacNhanMatKhau";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Xác nhận mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
