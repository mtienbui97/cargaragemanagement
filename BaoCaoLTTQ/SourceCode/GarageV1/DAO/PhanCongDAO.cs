using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class PhanCongDAO
    {
        #region 1.Insert
        public static bool InsertPhanCong(PhanCongDTO phancong)
        {
            bool result = false;
            try
            {
                //create a list parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                //parameters.Add(new MySqlParameter("@MaTK", taikhoan.MaTK));
                parameters.Add(new MySqlParameter("@MaPC", phancong.MaPC));
                parameters.Add(new MySqlParameter("@ThoiGian",phancong.ThoiGian));
                parameters.Add(new MySqlParameter("@GhiChu",phancong.GhiChu));
                parameters.Add(new MySqlParameter("@FK_MaCV", phancong.MaCV));
                parameters.Add(new MySqlParameter("@FK_MaNV", phancong.MaNV));
                parameters.Add(new MySqlParameter("@FK_MaDV", phancong.MaDV));
                //call store Procedure
                int n = MySqlDataAccessHelper.ExecuteNonQuery("INSERT INTO phancong (MaPC, NgayPC, GhiChu, MaCV, MaNV, MaDV) VALUES(@MaPC, @ThoiGian, @GhiChu, @FK_MaCV, @FK_MaNV, @FK_MaDV)", parameters);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;


        }

        public static String GenerateMaPhanCong()
        {
            int newMaPhanCong = 0;
            try
            {
                System.Data.DataTable dt = MySqlDataAccessHelper.ExecuteQuery("select max(cast(replace(replace(MaPC, 'PC', ''), '', '') as unsigned)) + 1 as newMaPhanCong from phancong");
                newMaPhanCong = dt.Rows[0]["NewMaPhanCong"].ToString() == "" ? 1 : int.Parse(dt.Rows[0]["NewMaPhanCong"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return string.Format("PC{0:000}", newMaPhanCong);
        }
        #endregion
    }
}
