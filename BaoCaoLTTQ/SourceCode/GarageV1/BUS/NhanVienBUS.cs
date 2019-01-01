using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        #region 1. Retrieving 
        public static List<NhanVienDTO> SelectNhanVienAll()
        {
            return DAO.NhanVienDAO.SelectNhanVienAll();
        }

        public static NhanVienDTO SelectNhanVienById(String nhanvienID)
        {
            return !NhanVienDAO.CheckNhanVienById(nhanvienID) ? null : NhanVienDAO.SelectNhanVienById(nhanvienID);
        }

        public static List<NhanVienDTO> SelectNhanVienByTenNhanVien(String tenNV)
        {
            return DAO.NhanVienDAO.SelectNhanVienByTenNhanVien(tenNV);
        }

        #endregion
    }
}
