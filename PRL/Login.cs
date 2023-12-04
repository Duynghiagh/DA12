using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Length == 0 && txtMK.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
            }
            else if (txtTK.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được bỏ trống!");
            }
            else if (txtMK.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!");
            }
            else
            {
                if (txtTK.Text == "admin" && txtMK.Text == "admin")
                {
                    this.Hide();
                    HoaDon f2 = new HoaDon();
                    f2.ShowDialog();
                    this.Close();
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tài khoản không đúng");
                }
            }
        }
        private bool isPasswordVisible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMK.UseSystemPasswordChar = !isPasswordVisible;
        }
    }
}
