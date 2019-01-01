using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
       public static bool InsertHoaDon(HoaDonDTO hoaDon)
        {
            return DAO.HoaDonDAO.InsertHoaDon(hoaDon);
        }

        public static String GenerateMaHoaDon()
        {
            return DAO.HoaDonDAO.GenerateMaHoaDon();
        }

        public static HoaDonDTO SelectHoaDonById(String hoadonID)
        {
            return HoaDonDAO.SelectHoaDonById(hoadonID);
        }

    }
}
