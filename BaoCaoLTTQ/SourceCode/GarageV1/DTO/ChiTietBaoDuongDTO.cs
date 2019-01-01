using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBaoDuongDTO
    {
        #region Atrributes
        private String _MaCTBD;
        private bool _TrangThai;
        private int _Phi;
        private int _SoLuongPT;
        private int _DonGiaPT;
        private String _MaPT;
        private String _MaDV;
        private String _MaHD;
        private String _MaCV;

        #endregion

        #region Default Constructor

        public ChiTietBaoDuongDTO()
        {
            _MaCTBD = String.Empty;
            _TrangThai = false;
            _Phi = 0;
            _SoLuongPT = 0;
            _DonGiaPT = 0;
            _MaPT = String.Empty;
            _MaDV = String.Empty;
            _MaHD = String.Empty;
            _MaCV = String.Empty;

        }
        public ChiTietBaoDuongDTO(String maCTBD, bool trangThai, int phi, int soLuong, int donGia, String maPT, String maDV, String maHD, String maCV)
        {
            _MaCTBD = maCTBD;
            _TrangThai = trangThai;
            _Phi = phi;
            _SoLuongPT = soLuong;
            _DonGiaPT = donGia;
            _MaPT = maPT;
            _MaDV = maDV;
            _MaHD = maHD;
            _MaCV = maCV;
        }
        #endregion

        #region Properties
        public String MaCTBD { get; set; }
        public bool TrangThai { get; set; }
        public int Phi { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set;  }
        public String MaDV { get; set; }
        public String MaPT { get; set; }
        public String MaHD { get; set; }
        public String MaCV { get; set; }


        #endregion
    }
}
