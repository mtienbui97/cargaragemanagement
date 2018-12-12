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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadListCongViec();
            LoadPhuTungTable();
            txtMaDV.Text = BUS.DichVuBUS.GenerateMaDichVu();
            txtMaHD.Text = BUS.HoaDonBUS.GenerateMaHoaDon();
            LoadListNhanVien();
            LoadTableCongViec();
            LoadTableChiTietBaoDuong();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtMaKH_timkiem.Text != "")
            {
                KhachHangDTO khachhang = new KhachHangDTO();
                khachhang = BUS.KhachHangBUS.SelectKhachHangById(txtMaKH_timkiem.Text);
                if (khachhang == null)
                {
                    string message = "Mã khách hàng không tồn tại";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;


                    // Displays the MessageBox.

                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    txtTenKH.Text = khachhang.TenKH;
                    comboBoxMaKH.Text = khachhang.MaKH;
                    txtDienThoai.Text = khachhang.SDT;
                    txtDiaChi.Text = khachhang.DiaChi;
                }
            }
            else if (txtTenKH_timkiem.Text != "")
            {
                List<KhachHangDTO> list = new List<KhachHangDTO>();
                list = BUS.KhachHangBUS.SelectKhachHangByTenKhachHang(txtTenKH_timkiem.Text);

                if (list == null)
                {
                    string message = "Tên khách hàng không tồn tại";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;


                    // Displays the MessageBox.

                    MessageBox.Show(message, caption, buttons);
                }
                else if (list.Count == 1)
                {
                    var khachhang = list[0];
                    comboBoxMaKH.Text = khachhang.MaKH;
                }
                else
                {
                    foreach (KhachHangDTO khachhang in list)
                    {
                        comboBoxMaKH.Items.Add(khachhang.MaKH);
                    }
                    comboBoxMaKH.Text = list[0].MaKH;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxMaKH.Text = comboBoxMaKH.SelectedItem.ToString();
        }

        private void txtTenKH_timkiem_TextChanged(object sender, EventArgs e)
        {

            RefreshThongTinKhachHang();
        }

        private void RefreshThongTinKhachHang()
        {
            comboBoxMaKH.Items.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        private void txtTenKH_timkiem_Click(object sender, EventArgs e)
        {
            RefreshThongTinKhachHang();
        }


        private void comboBoxMaKH_TextChanged(object sender, EventArgs e)
        {
            RefreshThongTinXe();
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang = BUS.KhachHangBUS.SelectKhachHangById(comboBoxMaKH.Text);
            txtTenKH.Text = khachhang.TenKH;
            comboBoxMaKH.Text = khachhang.MaKH;
            txtDienThoai.Text = khachhang.SDT;
            txtDiaChi.Text = khachhang.DiaChi;

            DataTable table = new DataTable();

            table = BUS.XeBUS.SelectXeByKhachHangId(khachhang.MaKH);


            table.Columns[0].ColumnName = "Mã xe";
            table.Columns[1].ColumnName = "Tên xe";
            table.Columns[2].ColumnName = "Hãng";
            table.Columns[3].ColumnName = "Năm sản xuất";
            table.Columns[4].ColumnName = "Mã khách hàng";
            xeTable_dgridview.DataSource = table;
        }

        private void txtMaKH_timkiem_TextChanged(object sender, EventArgs e)
        {
            RefreshThongTinKhachHang();
            RefreshThongTinXe();


        }

        private void xeTable_dgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = xeTable_dgridview.Rows[rowIndex];
            txtBienSoXe.Text = row.Cells[0].Value.ToString();
            txtTenXe.Text = row.Cells[2].Value.ToString();
            txtHangXe.Text = row.Cells[1].Value.ToString();
            txtNamSX.Text = row.Cells[3].Value.ToString();
            dataGridViewLichSu.DataSource = BUS.DichVuBUS.SelectDichVuByMaXe(row.Cells[0].Value.ToString());

        }

        private void RefreshThongTinXe()
        {
            txtBienSoXe.Clear();
            txtTenXe.Clear();
            txtHangXe.Clear();
            txtNamSX.Clear();
        }

        private void txtTenKH_timkiem_TextChanged_1(object sender, EventArgs e)
        {

        }

        DataTable tablePhuTung = new DataTable();
        private void LoadPhuTungTable()
        {


            tablePhuTung = BUS.PhuTungBUS.SelectPhuTungAll();


            tablePhuTung.Columns[0].ColumnName = "Mã";
            tablePhuTung.Columns[1].ColumnName = "Tên";
            tablePhuTung.Columns[2].ColumnName = "Hãng";
            tablePhuTung.Columns[3].ColumnName = "Giá";
            tablePhuTung.Columns[4].ColumnName = "Hạn BH (tháng)";
            tablePhuTung.Columns[5].ColumnName = "ĐVT";
            tablePhuTung.Columns[6].ColumnName = "Mô tả";

            phutung_datagridview.DataSource = tablePhuTung;
        }

        private void LoadListCongViec()
        {
            List<CongViecDTO> list = BUS.CongViecBUS.SelectCongViecAll();
            foreach (CongViecDTO congviec in list)
            {
                cbCongViec.Items.Add(congviec.TenCV);
                cbCongViec.Text = list[0].TenCV;
            }
        }

        private void LoadListNhanVien()
        {
            List<NhanVienDTO> list = BUS.NhanVienBUS.SelectNhanVienAll();
            foreach (NhanVienDTO nhanvien in list)
            {
                nhanViencomboBox.Items.Add(nhanvien.TenNV);
                nhanViencomboBox.Text = list[0].TenNV;
            }
        }


        //update table 'cong viec'
        DataTable tableCV = new DataTable();
        private void LoadTableCongViec()
        {

            tableCV.Columns.Add("STT", typeof(int));
            tableCV.Columns.Add("Mã CV", typeof(String));
            tableCV.Columns.Add("Công việc", typeof(String));
            tableCV.Columns.Add("Bảo hành", typeof(bool));
            tableCV.Columns.Add("Chọn", typeof(bool));
            tableCV.Columns.Add("Nhân viên", typeof(String));
            tableCV.Columns.Add("Mã NV", typeof(String));
            tableCV.Columns.Add("Ghi chú", typeof(String));



            congViecdataGridView.DataSource = tableCV;
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            String maCV = BUS.CongViecBUS.SelectCongViecByTenCongViec(cbCongViec.Text)[0].MaCV;
            tableCV.Rows.Add((tableCV.Rows.Count + 1).ToString(), cbCongViec.Text, maCV,true, true, nhanViencomboBox.Text, BUS.NhanVienBUS.SelectNhanVienByTenNhanVien(nhanViencomboBox.Text)[0].MaNV,txtGhiChu.Text);
            congViecdataGridView.DataSource = tableCV;
        }

        private void congViecdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void congViecdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemPT.Enabled = true;
            //int congviecRowIndex_Clicked = e.RowIndex;
            selectedRow = e.RowIndex;
            DataGridViewRow row = congViecdataGridView.Rows[selectedRow];
            String maCV = BUS.CongViecBUS.SelectCongViecByTenCongViec(row.Cells[1].Value.ToString())[0].MaCV;
            //DataTable dt = BUS.PhuTungBUS.SelectPhuTungByMaCongViec(maCV);
            String tenCongViec = row.Cells["Công việc"].Value.ToString();

            LoadPhuTungTable();
            HighlightRow(phutung_datagridview, maCV, 6);


        }

        private void HighlightRow(DataGridView dataGridView, String value, int cellIndex)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells[cellIndex].Value) == value)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        String maCongViec;
        private void phutung_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = phutung_datagridview.Rows[selectedRow];
            txtMaPT.Text = row.Cells["Mã"].Value.ToString();
            txtTenPT.Text = row.Cells["Tên"].Value.ToString();
            txtDonViTinh.Text = row.Cells["ĐVT"].Value.ToString();
            txtDonGia.Text = row.Cells["Giá"].Value.ToString();
            maCongViec = row.Cells["Mô tả"].Value.ToString();
        }

        private void soLuongUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadThanhTien();
        }

        private void LoadThanhTien()
        {

            txtThanhTien.Text = cbbGhiChu.Text == "BH" ? (decimal.Parse(txtDonGia.Text) * soLuongUpDown1.Value * 0).ToString() :
                (decimal.Parse(txtDonGia.Text) * soLuongUpDown1.Value * 1).ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            LoadThanhTien();
        }

        private void cbbGhiChu_TextChanged(object sender, EventArgs e)
        {
            LoadThanhTien();
        }


        //update table 'chitietbaoduong'
        DataTable tablePT = new DataTable();
        private void btnThemPT_Click(object sender, EventArgs e)
        {
            tablePT.Rows.Add((tablePT.Rows.Count + 1).ToString(), txtMaPT.Text, txtTenPT.Text, cbbGhiChu.Text, soLuongUpDown1.Value.ToString(), txtDonGia.Text, txtThanhTien.Text, BUS.PhuTungBUS.SelectPhuTungById(txtMaPT.Text).MoTa);
            phuTungChiTietBDdataGridView.DataSource = tablePT;
            btnSuaPT.Enabled = true;
            btnXoaPT.Enabled = true;
        }


        private void LoadTableChiTietBaoDuong()
        {

            tablePT.Columns.Add("STT", typeof(int));
            tablePT.Columns.Add("MãPT", typeof(String));
            tablePT.Columns.Add("TênPT", typeof(String));
            tablePT.Columns.Add("Bảo hành", typeof(String));
            tablePT.Columns.Add("Số lượng", typeof(String));
            tablePT.Columns.Add("Giá", typeof(String));
            tablePT.Columns.Add("Thành tiền", typeof(String));
            tablePT.Columns.Add("Mã CV", typeof(String));

            phuTungChiTietBDdataGridView.DataSource = tablePT;
        }

        // them, xoa , sua, dataGridViewCongViec
        int selectedRow;
        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            selectedRow = congViecdataGridView.CurrentCell.RowIndex;
            congViecdataGridView.Rows.RemoveAt(selectedRow);
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = congViecdataGridView.Rows[selectedRow];
            newRow.Cells[1].Value = cbCongViec.Text;
            newRow.Cells["Nhân viên"].Value = nhanViencomboBox.Text;
            newRow.Cells["Ghi chú"].Value = txtGhiChu.Text;
            
        }



        // them, xoa, sua dataGridChiTietBaoDuong
        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            selectedRow = phuTungChiTietBDdataGridView.CurrentCell.RowIndex;
            phuTungChiTietBDdataGridView.Rows.RemoveAt(selectedRow);
           
        }

        private void btnSuaPT_Click(object sender, EventArgs e)
        {
           


        }

        private void btnSuaPT_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow newRow = phuTungChiTietBDdataGridView.Rows[selectedRow];
            newRow.Cells[1].Value = txtMaPT.Text;
            newRow.Cells[2].Value = txtTenPT.Text;
            newRow.Cells[3].Value = cbbGhiChu.Text;
            newRow.Cells[4].Value = soLuongUpDown1.Value;
            newRow.Cells[5].Value = txtDonGia.Text;
            newRow.Cells[6].Value = txtThanhTien.Text;
            newRow.Cells[7].Value = BUS.PhuTungBUS.SelectPhuTungById(txtMaPT.Text).MoTa;
        }

        /*
         1. btn_addHd click 
            + insert dichvu
                        -maDV :txtMaDV
                        -ngay: datepicker
                        -soXe: txtSoxe
            + insert hoadon
                        -maHD: txtMaHoaDon
                        -ngay: datepicker
                        -tongtien: txtTongtien
                        -giamgia: txtTienGiam
                        -ThanhTienTong: txtThanhTienTong
                        -MaKH: cbMaKH
            + insert phan cong
                        - Thoigian: datapicker
                        - ghichu: txtGhiChu
                        - maNV: cbNhanVien
                        - maCV: cbCongViec (only insert congviec was chosen)

            + insert chitietbaoduong
                        -MaCTBD: generate in code
                        -TrangThai: chosen or not congviecTable cell[4]
                        -if not
                            maPT null
                            soluong null
                            dongia null
                            thanhtien null
                            maHD null
                        - maDV : txt maDV
                        - maCV : congviecTable cell[2]
                        
         */
        private void label31_Click(object sender, EventArgs e)
        {

        }

        public bool InsertPhanCong() {
            //List<PhanCongDTO> listPhanCong = new List<PhanCongDTO>();
            foreach(DataGridViewRow row in congViecdataGridView.Rows)
            {
                if(bool.Parse(row.Cells["Chọn"].Value.ToString())== true)
                {
                    PhanCongDTO phancong = new PhanCongDTO();
                    phancong.MaPC = BUS.PhanCongBUS.GenerateMaPhanCong();
                    phancong.MaDV = txtMaDV.Text;
                    phancong.MaNV = BUS.NhanVienBUS.SelectNhanVienByTenNhanVien(row.Cells["Nhân viên"].Value.ToString())[0].MaNV;
                    phancong.MaCV = (row.Cells["Công việc"].Value.ToString());
                    phancong.ThoiGian = dtbNgayLapHD.Value;
                    phancong.GhiChu = row.Cells["Ghi Chú"].Value.ToString();
                    if (!BUS.PhanCongBUS.InsertPhanCong(phancong))
                    {
                        return false;
                    };
                }
                else
                {
                    ChiTietBaoDuongDTO chiTiet = new ChiTietBaoDuongDTO
                    {
                        MaCTBD = BUS.ChiTietBaoDuongBUS.GenerateMaChiTietBaoDuong(),
                        MaPT = null,
                        SoLuong = 0,
                        DonGia =0,
                        Phi = 0,
                        TrangThai = false,
                        MaHD =null,
                        MaCV = row.Cells["Mã CV"].Value.ToString(),
                        MaDV = txtMaDV.Text
                    };
                }
            }
            return true;
        }

        public bool InsertDichVu()
        {
            DichVuDTO dichvu = new DichVuDTO();
            dichvu.MaDV = txtMaDV.Text;
            dichvu.NgayDV = DateTime.Parse(dtbNgayLapHD.Text);
            dichvu.SoXe = txtBienSoXe.Text;
            
              return  BUS.DichVuBUS.InsertDich(dichvu);
        }

        public bool InsertHoaDon()
        {
            HoaDonDTO hoadon = new HoaDonDTO();
            hoadon.MaHD = BUS.HoaDonBUS.GenerateMaHoaDon();
            hoadon.NgayLapHD = DateTime.Parse(dtbNgayLapHD.Text);
            hoadon.MaKH = comboBoxMaKH.Text;
            hoadon.TongTien = int.Parse(txtTongTien.Text);
            hoadon.GiamGia = int.Parse(txtTienDuocGiamGia.Text);
            hoadon.ThanhTien = int.Parse(txtThanhTienTong.Text);

            return BUS.HoaDonBUS.InsertHoaDon(hoadon);
        }

        public bool InsertChiTietBaoDuong()
        {
            foreach(DataGridViewRow row in phuTungChiTietBDdataGridView.Rows )
            {
                ChiTietBaoDuongDTO chiTiet = new ChiTietBaoDuongDTO
                {
                    MaCTBD = BUS.ChiTietBaoDuongBUS.GenerateMaChiTietBaoDuong(),
                    MaPT = row.Cells["MãPT"].Value.ToString(),
                    SoLuong = int.Parse(row.Cells["Số lượng"].Value.ToString()),
                    DonGia = int.Parse(row.Cells["Giá"].Value.ToString()),
                    Phi = int.Parse(row.Cells["Thành tiền"].Value.ToString()),
                    TrangThai = true,
                    MaHD = txtMaHD.Text,
                    MaCV = row.Cells["Mã CV"].Value.ToString(),
                    MaDV = txtMaDV.Text
                };
                if (!BUS.ChiTietBaoDuongBUS.InsertChiTietBaoDuong(chiTiet))
                {
                    return false;
                };
            }
            return true;
        }

        private int GetTienHang()
        {
            int result = 0;

            foreach (DataGridViewRow row in phuTungChiTietBDdataGridView.Rows)
            {

                if (!int.TryParse(Convert.ToString(row.Cells["Thành tiền"].Value), out int val))
                {
                    return result;
                }
                else {
                    result = result + int.Parse(Convert.ToString(row.Cells["Thành tiền"].Value));
                }
                
            }

            return result;
        }
        private void LoadThanhToan()
        {


            int tiencong = phuTungChiTietBDdataGridView.CurrentCell.RowIndex > 3 ? (phuTungChiTietBDdataGridView.CurrentCell.RowIndex * 150000) : 600000;
            int tienhang = GetTienHang();
            int tongtien = tiencong + tienhang;
            decimal giamgia = giamGianumericUpDown.Value;
            int tiengiam = tongtien * decimal.ToInt32(giamgia) / 100;
            int tiensaugiam = tongtien - tiengiam;
            int tienthua=0;
            if (int.TryParse(txtTienThanhToan.Text, out int val))
            {
                tienthua= int.Parse(Convert.ToString(txtTienThanhToan.Text)) - tiensaugiam;
            }
            txtTienCong.Text = tiencong.ToString();
            txtTienhang.Text = tienhang.ToString();
            txtTongTien.Text = tongtien.ToString();
            txtTienDuocGiamGia.Text = tiengiam.ToString();
            txtThanhTienTong.Text = tiensaugiam.ToString();
            txtTienThua.Text = tienthua.ToString();
           
        }

        private void txtTienCong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            if(InsertChiTietBaoDuong() &&
            InsertDichVu() &&
            InsertHoaDon() &&
            InsertPhanCong() )
            {
                MessageBox.Show("Thông báo", "Thành công");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadThanhToan();
        }

        private void dataGridViewLichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewLichSu.Rows[selectedRow];
            dataGridViewChiTietPT.DataSource = BUS.ChiTietBaoDuongBUS.SelectChiTietBaoDuongByMaDichVu(row.Cells[0].Value.ToString());
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm._txtMaHoaDon = _txtMaHD;
            reportForm.Show();
        }

        public string _txtMaHD
        {
            get { return txtMaHD.Text; }
        }
    }
       
}
