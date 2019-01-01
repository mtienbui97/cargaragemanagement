using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XeDTO
    {
        #region Atrributes
        private String _SoXe;
        private String _TenXe;
        private String _HangSX;
        private String _NamSX;
        private String _MaKH;

        #endregion

        #region Default Constructor

        public XeDTO()
        {
            _SoXe = String.Empty;
            _TenXe = String.Empty;
            _HangSX = String.Empty;
            _NamSX = String.Empty;
            _MaKH= String.Empty;
            
        }
        public XeDTO(String soXe, String tenXe, String hangSX, String namSX, String maKH)
        {
            _SoXe = soXe;
            _TenXe = tenXe;
            _HangSX = hangSX;
            _NamSX = namSX;
            _MaKH = maKH;
        }
        #endregion

        #region Properties
        public String SoXe { get; set; }
        public String TenXe { get; set; }
        public String NamSanXuat { get; set; }
        public String HangSanXuat { get; set; }
        public String MaKhachHang { get; set; }
        
        #endregion
    }
}
