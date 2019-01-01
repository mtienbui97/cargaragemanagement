using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        HoaDonDTO hoadon = new HoaDonDTO();

        private void Report_Load(object sender, EventArgs e, String MaHoaDon)
        {

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.DataBindings = 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string _txtMaHoaDon
        {
            set { txtMaHD.Text = value; }
        }

        private void LoadForm ()
        {
            HoaDonDTO hoadon = DAO.HoaDonDAO.SelectHoaDonById(txtMaHD.Text);
            List<ChiTietBaoDuongDTO> list = DAO.ChiTietBaoDuongDAO.SelectChiTietBaoDuongByMaHoaDon(txtMaHD.Text);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
