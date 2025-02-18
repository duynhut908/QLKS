using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string a = "a";
            string b = "a";
            if (txtPass.Text == a && txtPass.Text == b)
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập, vui lòng nhâp lại!!");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
