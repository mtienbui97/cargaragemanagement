using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChucVuBUS
    {
        #region 1. Retrieving
        public static ChucVuDTO SelectChucVuById(String chucvuID)
        {
            return DAO.ChucVuDAO.SelectChucVuById(chucvuID);
        }
        #endregion
    }
}
