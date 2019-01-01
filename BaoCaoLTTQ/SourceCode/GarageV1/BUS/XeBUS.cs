using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class XeBUS
    {
        #region 1. Retrieving 
        public static DataTable SelectXeAll()
        {
            return DAO.XeDAO.SelectXeAll();
        }
        public static DataTable SelectXeByKhachHangId(String khachhangID)
        {
            return DAO.XeDAO.SelectXeByKhachHangId(khachhangID);
        }



        #endregion
    }
}
