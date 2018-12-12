using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhuTungBUS
    {
        public static DataTable SelectPhuTungAll()
        {
            return DAO.PhuTungDAO.SelectPhuTungAll();
        }

        public static DataTable SelectPhuTungByMaCongViec(String maCongViec)
        {
            return DAO.PhuTungDAO.SelectPhuTungByMaCongViec(maCongViec);
        }

        public static PhuTungDTO SelectPhuTungById(String phutungID)
        {
            return DAO.PhuTungDAO.SelectPhuTungById(phutungID);
        }
    }
}
