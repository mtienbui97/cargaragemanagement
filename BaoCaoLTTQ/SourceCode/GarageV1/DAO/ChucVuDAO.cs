using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChucVuDAO
    {
        #region 1. Retrieving 
       
        public static ChucVuDTO SelectChucVuById(String chucvuID)
        {
            ChucVuDTO chucvu = new ChucVuDTO();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaCV", chucvuID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM chucvu WHERE (MaCV = @MaCV)", parameters);
                DataRow dr = dt.Rows[0];
                chucvu.MaCV = dr["MaCV"].ToString();
                chucvu.TenCV = dr["TenCV"].ToString();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chucvu;
        }
        #endregion
    }
}
