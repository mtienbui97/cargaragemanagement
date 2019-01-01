using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        #region Atrributes
        private String _MaKH;
        private String _TenKH;
        private String _NamSinh;
        private String _DiaChi;
        private String _SDT;

        #endregion

        #region Default Constructor

        public KhachHangDTO()
        {
            _MaKH = String.Empty;
            _TenKH = String.Empty;
            _NamSinh = String.Empty;
            _DiaChi = String.Empty;
            _SDT = String.Empty;
        }

        public KhachHangDTO(String maKH, String tenKH, String namSinh, String diaChi, String sDT)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _NamSinh = namSinh;
            _DiaChi = diaChi;
            _SDT = sDT;
           
        }
        #endregion

        #region Properties
        public String MaKH { get; set; }
        public String TenKH { get; set; }
        public String NamSinh { get; set; }
        public String DiaChi { get; set; }
        public String SDT { get; set; }
        #endregion
    }
}
