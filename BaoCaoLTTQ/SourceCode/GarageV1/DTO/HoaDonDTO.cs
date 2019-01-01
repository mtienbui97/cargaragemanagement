using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        #region Atrributes
        private String _MaHD;
        private DateTime _NgayLapHD;
        private int _TongTien;
        private int _GiamGia;
        private int _ThanhTien;
        private String _MaKH;


        #endregion

        #region Default Constructor

        public HoaDonDTO()
        {
            _MaHD = String.Empty;
            _NgayLapHD = DateTime.Now;
            _TongTien = 0;
            _MaKH = String.Empty;
            _GiamGia = 0;
            _ThanhTien = 0;


        }
        public HoaDonDTO(String maHD, DateTime ngay, int tien, String maKH, int giamGia, int thanhTien)
        {
            _MaHD = maHD;
            _NgayLapHD = ngay;
            _TongTien = tien;
            _MaKH = maKH;
            _ThanhTien = thanhTien;
            _GiamGia = giamGia;
        }
        #endregion

        #region Properties
        public String MaHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public String MaKH { get; set; }
        public int TongTien { get; set; }
        public int ThanhTien { get; set; }  
        public int GiamGia { get; set; }

        #endregion
    }
}
