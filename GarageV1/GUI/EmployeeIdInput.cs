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
    public partial class EmployeeIdInput : Form
    {
        private String nhanvienID;
        public String NhanvienID
        {
            get { return nhanvienID; }
            set { nhanvienID = value; }
        }

        public EmployeeIdInput()
        {
            InitializeComponent();
        }

        private void btnNhapMaNV_Click(object sender, EventArgs e)
        {
            if(BUS.NhanVienBUS.SelectNhanVienById(txtMaNhanVien.Text) ==null)
            {
                string message = "Mã nhân viên không tồn tại";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                NhanvienID = txtMaNhanVien.Text;

                 
            }
        }
    }
}
