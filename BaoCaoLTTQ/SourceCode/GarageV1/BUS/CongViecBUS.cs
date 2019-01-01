using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CongViecBUS
    {
        public static List<CongViecDTO> SelectCongViecAll()
        {
            return DAO.CongViecDAO.SelectCongViecAll();
        }

        public static List<CongViecDTO> SelectCongViecByTenCongViec(String tenCV)
        {
            return DAO.CongViecDAO.SelectCongViecByTenCongViec(tenCV);
        }
    }
}
