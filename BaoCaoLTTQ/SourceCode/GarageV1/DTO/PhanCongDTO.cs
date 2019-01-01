using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongDTO
    {
        #region Atrributes
        private String _MaPC;
        private DateTime _ThoiGian;
        private String _GhiChu;
        private String _MaNV;
        private String _MaDV;
        private String _MaCV;
        #endregion
           
        #region Default Constructor

        public PhanCongDTO()
        {
            _MaPC = String.Empty;
            _ThoiGian = DateTime.Now;
            _GhiChu = String.Empty;
            _MaDV = String.Empty;
            _MaNV = String.Empty;
            _MaCV = String.Empty;

        }
        public PhanCongDTO(String maPC, DateTime thoiGian, String ghiChu, String maNV, String maDV, String maCV)
        {
            _MaPC = maPC;
            _ThoiGian = thoiGian;
            _GhiChu = ghiChu;
            _MaNV = maNV;
            _MaDV = maDV;
            _MaCV = maCV;
        }
        #endregion

        #region Properties
        public DateTime ThoiGian { get; set; }
        public String GhiChu { get; set; }
        public String MaNV { get; set; }
        public String MaDV { get; set; }
        public String MaPC { get; set; }
        public String MaCV { get; set; }
        #endregion
    }
}
