using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class DichVuBUS
    {
        public static String GenerateMaDichVu()
        {
            return DAO.DichVuDAO.GenerateMaDichVu();
        }

        public static bool  InsertDich(DichVuDTO dichvu)
        {
            return DAO.DichVuDAO.InsertDichVu(dichvu);
        }

        public static DataTable SelectDichVuByMaXe(String maXe)
        {
            return DAO.DichVuDAO.SelectDichVuByMaXe(maXe);
        }
    }
}
