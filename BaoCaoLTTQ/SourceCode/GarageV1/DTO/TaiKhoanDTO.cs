using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private String _MaTK;
        private String _UserName;
        private String _Password;
        private Boolean _TinhTrang;
        private String _MaNhanVien;

        public TaiKhoanDTO(String maTK, String userName, String passWord, Boolean tinhTrang, String maNhanVien)
        {
            _MaTK = maTK;
            _UserName = userName;
            _Password = passWord;
            _TinhTrang = tinhTrang;
            _MaNhanVien = maNhanVien;
        }

        public TaiKhoanDTO()
        {
            _MaTK = String.Empty;
            _UserName = String.Empty;
            _Password = String.Empty;
            _TinhTrang = false;
            _MaNhanVien = String.Empty;
        }

        public String MaTK { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public Boolean TinhTrang { get; set; }
        public String MaNhanVien { get; set; }
    }
}
