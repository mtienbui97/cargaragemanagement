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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        DataTable tableCar = new DataTable();
        private void LoadXe()
        {


            tableCar = BUS.XeBUS.SelectXeAll();


            tableCar.Columns[0].ColumnName = "Số xe";
            tableCar.Columns[1].ColumnName = "Hãng sản xuất";
            tableCar.Columns[2].ColumnName = "Tên xe";
            tableCar.Columns[3].ColumnName = "Năm sản xuất";
            tableCar.Columns[4].ColumnName = "Mã Khách hàng";


            dataGridView1.DataSource = tableCar;
        }
        private void Car_Load(object sender, EventArgs e)
        {
            LoadXe();
        }
    }
}
