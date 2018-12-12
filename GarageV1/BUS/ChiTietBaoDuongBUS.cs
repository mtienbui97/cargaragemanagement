using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ChiTietBaoDuongBUS
    {
        public static String GenerateMaChiTietBaoDuong()
        {
            return DAO.ChiTietBaoDuongDAO.GenerateMaCTBD();
                
        }

        public static bool InsertChiTietBaoDuong(ChiTietBaoDuongDTO chiTiet)
        {
            return DAO.ChiTietBaoDuongDAO.InsertChiTietBaoDuong(chiTiet);
        }

        public static DataTable SelectChiTietBaoDuongByMaDichVu(String maDichVu)
        {
            return DAO.ChiTietBaoDuongDAO.SelectChiTietBaoDuongByMaDichVu(maDichVu);
        }

        public static List<ChiTietBaoDuongDTO> SelectChiTietBaoDuongByMaHoaDon(String maHoaDon)
        {
            return DAO.ChiTietBaoDuongDAO.SelectChiTietBaoDuongByMaHoaDon(maHoaDon);
        }
    }
}
