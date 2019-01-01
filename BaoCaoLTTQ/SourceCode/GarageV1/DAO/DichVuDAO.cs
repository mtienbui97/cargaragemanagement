using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DichVuDAO
    {
        #region 1.Retrieving
        public static String GenerateMaDichVu()
        {
            int newMaDichVu = 0;
            try
            {
                System.Data.DataTable dt = MySqlDataAccessHelper.ExecuteQuery("select max(cast(replace(replace(MaDV, 'DV', ''), '', '') as unsigned)) + 1 as newMaDichVu from dichvu");
                newMaDichVu = dt.Rows[0]["NewMaDichVu"].ToString() == "" ? 1 : int.Parse(dt.Rows[0]["NewMaDichVu"].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return string.Format("DV{0:000}", newMaDichVu);
        }

        //public static List<DichVuDTO> SelectDichVuByMaXe(String xeID)
        //{
        //    List<DichVuDTO> list = new List<DichVuDTO>();
        //    try
        //    {
        //        // Create List Sql Parameter
        //        List<MySqlParameter> parameters = new List<MySqlParameter>();
        //        parameters.Add(new MySqlParameter("@MaXe", xeID));

        //        DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM dichvu WHERE FK_SoXe = @MaXe", parameters);
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            DichVuDTO dichvu = new DichVuDTO
        //            {
        //                MaDV = dr["MaDV"].ToString(),
        //                NgayDV = DateTime.Parse(dr["NgayBD"].ToString()),
        //                SoXe = dr["FK_SoXe"].ToString()
        //            };
        //            list.Add(dichvu);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return list;
        //}

        public static DataTable SelectDichVuByMaXe(String MaXe)
        {
            DataTable dt = new DataTable();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaXe", MaXe));

                dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM dichvu WHERE FK_SoXe = @MaXe", parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion

        #region 2.Insert
        public static bool InsertDichVu(DichVuDTO dichvu)
        {
            bool result = false;
            try
            {
                //create a list parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                //parameters.Add(new MySqlParameter("@MaTK", taikhoan.MaTK));
                parameters.Add(new MySqlParameter("@MaDV", dichvu.MaDV));
                parameters.Add(new MySqlParameter("@NgayBD", dichvu.NgayDV));
                parameters.Add(new MySqlParameter("@FK_SoXe", dichvu.SoXe));
                
                //call store Procedure
                int n = MySqlDataAccessHelper.ExecuteNonQuery("INSERT INTO dichvu (MaDV, NgayBD, FK_SoXE) VALUES(@MaDV, @NgayBD, @FK_SoXe)", parameters);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion
    }
}
