using System;
using System.Windows.Forms;

namespace Demo_Layout
{
    public partial class QuanLyTaiKhoan : Form
    {
        private string tenDangNhap = "bichtramxinhdep";
        private string email = "bichtramxinhdep@gmail.com";

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            NapThongTinTaiKhoan();
        }

        private void NapThongTinTaiKhoan()
        {
            lblTenNguoiDung.Text = "Trần Bích Trâm";
            lblTenDangNhap.Text = "Tên đăng nhập: " + tenDangNhap;
            lblEmail.Text = "Email: " + email;
        }

        private void btnCapNhatMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                using (DoiMatKhau frm = new DoiMatKhau(tenDangNhap))
                {
                    var kq = frm.ShowDialog(this);
                    if (kq == DialogResult.OK)
                    {
                        string matKhauMoi = frm.MatKhauMoi;
                        MessageBox.Show("Mật khẩu đã được thay đổi thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form đổi mật khẩu: " + ex.Message);
            }
        }

        // XÓA TÀI KHOẢN
        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            var xacNhanYd = MessageBox.Show(
                "Bạn chắc chắn muốn xóa tài khoản này? Hành động không thể hoàn tác. Khi đã xóa tài khoản thì bạn sẽ vĩnh viễn không đăng nhập được vào tài khoản này!!!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (xacNhanYd != DialogResult.Yes) return;

            using (var frm = new XacNhanMatKhau())
            {
                if (frm.ShowDialog(this) != DialogResult.OK) return;

                string matKhauNhap = frm.MatKhauNhap;

                if (!KiemTraMatKhauHienTai(tenDangNhap, matKhauNhap))
                {
                    MessageBox.Show("Mật khẩu không chính xác. Không thể xóa tài khoản.",
                        "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Tài khoản đã bị xóa.",
                "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private bool KiemTraMatKhauHienTai(string tenNguoiDung, string matKhauNhap)
        {
            return matKhauNhap == "123456";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Bạn có chắc muốn đăng xuất?",
                "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Đã đăng xuất.",
                    "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
