using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class NhanVienDTO
    {
        #region Atrributes
        private String _MaNV;
        private String _TenNV;
        private String _NamSinh;
        private String _DiaChi;
        private String _SDT;
        private String _ChucVu;
        #endregion

        #region Default Constructor

        public NhanVienDTO()
        {
            _MaNV = String.Empty;
            _TenNV = String.Empty;
            _NamSinh = String.Empty;
            _DiaChi = String.Empty;
            _SDT = String.Empty;
            _ChucVu = String.Empty;
        }
        public NhanVienDTO(String maNV, String tenNV, String namSinh, String diaChi, String sDT, String chucVu)
        {
            _MaNV = maNV;
            _TenNV = tenNV;
            _NamSinh = namSinh;
            _DiaChi = diaChi;
            _SDT = sDT;
            _ChucVu = chucVu;
        }
        #endregion

        #region Properties
        public String MaNV { get; set; }
        public String TenNV { get; set; }
        public String NamSinh { get; set; }
        public String DiaChi { get; set; }
        public String SDT { get; set; }
        public String ChucVu { get; set; }
        #endregion
    }
}
