using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignUp : Form
    {
       
        public SignUp()
        {
            InitializeComponent();
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO();
            taikhoan.MaNhanVien = txtMaNV.Text;
            taikhoan.UserName = txtUserName.Text;
            taikhoan.Password = txtPassword.Text;
            taikhoan.TinhTrang = true;
            if (BUS.TaiKhoanBUS.InsertTaiKhoan(taikhoan))
            {
                string message = "Tạo tài khoản thành công";
                string caption = "Thông báo";
                
                // Displays the MessageBox.
                MessageBox.Show(message, caption);
            }
        }

        private void Refresh( String nhanvienID)
        {
           
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (BUS.NhanVienBUS.SelectNhanVienById(txtMaNV.Text) == null)
            {
                //string message = "Mã nhân viên không tồn tại";
                //string caption = "Error Detected in Input";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result;

                //// Displays the MessageBox.

                //result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                NhanVienDTO nhanvien = new NhanVienDTO();
                nhanvien = BUS.NhanVienBUS.SelectNhanVienById(txtMaNV.Text);
                txtMaNV.Text = nhanvien.MaNV;
                txTenNV.Text = nhanvien.TenNV;
                txtChucVu.Text = BUS.ChucVuBUS.SelectChucVuById(nhanvien.ChucVu).TenCV;
            }
        }
    }
}
