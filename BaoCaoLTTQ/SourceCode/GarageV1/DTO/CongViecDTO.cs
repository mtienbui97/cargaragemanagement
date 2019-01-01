using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongViecDTO
    {
        #region Atrributes
        private String _MaCV;
        private String _TenCV;
        private String _MoTa;


        #endregion

        #region Default Constructor

        public CongViecDTO()
        {
            _MaCV = String.Empty;
            _TenCV = String.Empty;
            _MoTa = String.Empty;

        }
        public CongViecDTO(String maCV, String tenCV, String moTa)
        {
            _MaCV= maCV;
            _TenCV = tenCV;
            _MoTa = moTa;
        }
        #endregion

        #region Properties
        public String MaCV { get; set; }
        public String TenCV { get; set; }
        public String MoTa { get; set; }
       

        #endregion
    }
}
