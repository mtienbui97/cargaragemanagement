using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        #region Atrributes
        private String _MaDV;
        private DateTime _NgayDV;
        private String _SoXe;


        #endregion

        #region Default Constructor

        public DichVuDTO()
        {
            _MaDV = String.Empty;
            _NgayDV = DateTime.Now;
            _SoXe = String.Empty;

        }
        public DichVuDTO(String maDV, DateTime ngayDV, String soXe)
        {
            _MaDV = maDV;
            _NgayDV = ngayDV;
            _SoXe = soXe;
        }
        #endregion

        #region Properties
        public String MaDV { get; set; }
        public DateTime NgayDV { get; set; }
        public String SoXe { get; set; }


        #endregion
    }
}
