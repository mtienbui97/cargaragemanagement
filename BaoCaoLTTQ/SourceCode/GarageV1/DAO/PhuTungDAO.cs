using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhuTungDAO
    {
        #region 1. Retrieving 
        public static DataTable SelectPhuTungAll()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM phutung");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable SelectPhuTungByMaCongViec(String MaCongViec)
        {
            DataTable dt = new DataTable();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaCV", MaCongViec));

                dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM phutung WHERE MoTa = @MaCV", parameters);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static PhuTungDTO SelectPhuTungById(String phutungID)
        {
            PhuTungDTO phutung = new PhuTungDTO();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPT", phutungID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM phutung WHERE MaPT = @MaPT", parameters);
                DataRow dr = dt.Rows[0];
                phutung.MaPT= dr["MaPT"].ToString();
                phutung.TenPT = dr["TenPT"].ToString();
                phutung.MoTa = dr["MoTa"].ToString();
                phutung.ThoiHanBH = int.Parse(dr["ThoiHanBH"].ToString());
                phutung.GiaPT = int.Parse(dr["GiaPT"].ToString());
                phutung.DonViTinh = dr["DVT"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return phutung;
        }
        #endregion
    }
}
