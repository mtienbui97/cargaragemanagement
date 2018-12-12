using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class TaiKhoanDAO
    {
        #region 1.Insert
        public static bool InsertTaiKhoan(TaiKhoanDTO taikhoan)
        {
            bool result = false;
            try
            {
                //create a list parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                //parameters.Add(new MySqlParameter("@MaTK", taikhoan.MaTK));
                parameters.Add(new MySqlParameter("@UserName", taikhoan.UserName));
                parameters.Add(new MySqlParameter("@Password", taikhoan.Password));
                parameters.Add(new MySqlParameter("@FK_NV", taikhoan.MaNhanVien));
                parameters.Add(new MySqlParameter("@TinhTrang", taikhoan.TinhTrang));
                //call store Procedure
                int n = MySqlDataAccessHelper.ExecuteNonQuery("INSERT INTO taikhoan (UserName, Password, FK_NV, TinhTrang) VALUES(@UserName, @Password, @FK_NV, @TinhTrang)", parameters);
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

        #region 2. Retrieving 
        public static bool CheckTaiKhoanByUserNameAndPassword(string username, string password)
        {
            bool result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@UserName", username));
                parameters.Add(new MySqlParameter("@Password", password));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT FK_NV FROM taikhoan WHERE UserName = @UserName AND Password= Password", parameters);
                if(dt.Rows.Count == 1)
                {
                    result = true;
                }
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