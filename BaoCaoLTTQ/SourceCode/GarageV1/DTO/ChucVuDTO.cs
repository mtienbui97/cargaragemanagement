using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        private String _MaCV;
        private String _TenCV;

        public ChucVuDTO()
        {
            _MaCV = String.Empty;
            _TenCV = String.Empty;
        }

        public ChucVuDTO(String maCV, String tenCV)
        {
            _MaCV = maCV;
            _TenCV = tenCV;
        }

        public String MaCV { get; set; }
        public String TenCV { get; set; }
    }
}
