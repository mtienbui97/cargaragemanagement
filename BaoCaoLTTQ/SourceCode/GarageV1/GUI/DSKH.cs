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
    public partial class DSKH : Form
    {
        public DSKH()
        {
            InitializeComponent();
        }
        DataTable tableDSKH = new DataTable();
        private void LoadDSKH()
        {


            tableDSKH = BUS.KhachHangBUS.SelectKhachHangAll();


            tableDSKH.Columns[0].ColumnName = "Mã";
            tableDSKH.Columns[1].ColumnName = "Tên";
            tableDSKH.Columns[2].ColumnName = "Năm sinh";
            tableDSKH.Columns[3].ColumnName = "Địa chỉ";
            tableDSKH.Columns[4].ColumnName = "SDT";
            

            dataGridView1.DataSource = tableDSKH;
        }

        private void DSKH_Load(object sender, EventArgs e)
        {
            LoadDSKH();
        }
    }
    
}
