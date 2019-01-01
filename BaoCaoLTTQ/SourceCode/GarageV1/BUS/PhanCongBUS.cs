using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhanCongBUS
    {
        public static bool InsertPhanCong(PhanCongDTO phancong)
        {
            return DAO.PhanCongDAO.InsertPhanCong(phancong);
        }

        public static String GenerateMaPhanCong()
        {
            return DAO.PhanCongDAO.GenerateMaPhanCong();
        }
    }

   
}
