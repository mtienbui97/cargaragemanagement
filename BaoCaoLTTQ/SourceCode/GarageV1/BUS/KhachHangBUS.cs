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
    public class KhachHangBUS
    {
        #region 1. Retrieving 

        public static DataTable SelectKhachHangAll()
        {
            return DAO.KhachHangDAO.SelectKhachHangAll();
        }
        public static KhachHangDTO SelectKhachHangById(String khachhangID)
        {
            return !KhachHangDAO.CheckKhachHangById(khachhangID) ? null : KhachHangDAO.SelectKhachHangById(khachhangID);
        }


        public static List<KhachHangDTO> SelectKhachHangByTenKhachHang(String tenKhachHang)
        {
            return !KhachHangDAO.CheckKhachHangByTenKhachHang(tenKhachHang) ? null : KhachHangDAO.SelectKhachHangByTenKhachHang(tenKhachHang);
        }


        #endregion

    }
}
