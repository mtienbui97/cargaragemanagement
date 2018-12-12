using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(TaiKhoanBUS.CheckTaiKhoanByUserNameAndPassword(txtUsername.Text, txtPassword.Text) == false)
            {
                string message = "Username hoặc Password của bạn không đúng!";
                string caption = "Thông báo";
                MessageBox.Show(message, caption);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }
    }
}
