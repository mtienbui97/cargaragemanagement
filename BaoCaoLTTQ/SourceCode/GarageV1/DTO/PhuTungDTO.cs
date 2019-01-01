using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuTungDTO
    {
        #region Atrributes
        private String _MaPT;
        private String _TenPT;
        private String _MoTa;
        private String _HangSX;
        private int _GiaPT;
        private int _ThoiHanBH;
        private String _DVT;

        #endregion

        #region Default Constructor

        public PhuTungDTO()
        {
            _MaPT = String.Empty;
            _TenPT = String.Empty;
            _MoTa = String.Empty;
            _HangSX = String.Empty;
            _GiaPT = 0;
            _ThoiHanBH = 0;
            _DVT = String.Empty;

        }
        public PhuTungDTO(String maPT, String tenPT, String moTa, String hangSX, int giaPT, int thoiHanBH, String dVT)
        {
            _MaPT = maPT;
            _TenPT = tenPT;
            _MoTa = moTa;
            _HangSX = hangSX;
            _GiaPT = giaPT;
            _ThoiHanBH = thoiHanBH;
            _DVT = dVT;
        }
        #endregion

        #region Properties
        public String MaPT { get; set; }
        public String TenPT { get; set; }
        public String MoTa { get; set; }
        public String HangSanXuat { get; set; }
        public int GiaPT { get; set; }
        public int ThoiHanBH{ get; set; }
        public String DonViTinh { get; set; }

        #endregion
    }
}
