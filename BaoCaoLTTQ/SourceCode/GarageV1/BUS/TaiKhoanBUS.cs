using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        #region 1. Inserting 
        public static bool InsertTaiKhoan(TaiKhoanDTO taikhoan)
        {
            return TaiKhoanDAO.InsertTaiKhoan(taikhoan);
        }
        #endregion

        #region 2. Retrieving 
        public static bool CheckTaiKhoanByUserNameAndPassword(String username, String password)
        {
            return DAO.TaiKhoanDAO.CheckTaiKhoanByUserNameAndPassword(username, password);
        }
        #endregion
    }
}