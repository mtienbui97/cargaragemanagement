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
    public class HoaDonDAO
    {
        #region 1.Retrieving
        public static String GenerateMaHoaDon()
        {
            int newMaHoaDon = 0;
            try
            {
                System.Data.DataTable dt = MySqlDataAccessHelper.ExecuteQuery("select max(cast(replace(replace(MaHD, 'HD', ''), '', '') as unsigned)) + 1 as newMaHoaDon from hoadon");
                newMaHoaDon = dt.Rows[0]["NewMaHoaDon"].ToString() == "" ? 1 : int.Parse(dt.Rows[0]["NewMaHoaDon"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return string.Format("HD{0:000}", newMaHoaDon);
        }

        public static HoaDonDTO SelectHoaDonById(String hoadonID)
        {
            HoaDonDTO hoadon = new HoaDonDTO();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaHD", hoadonID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM hoadon WHERE MaHD = @MaHD", parameters);
                DataRow dr = dt.Rows[0];
                hoadon.MaHD = dr["MaHD"].ToString();
                hoadon.NgayLapHD = DateTime.Parse(dr["NgayLapHD"].ToString());
                hoadon.TongTien = int.Parse(dr["TongTien"].ToString());
                hoadon.MaKH = dr["FK_MaKH"].ToString();
                hoadon.GiamGia = int.Parse(dr["GiamGia"].ToString());
                hoadon.ThanhTien = int.Parse(dr["ThanhTien"].ToString());
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hoadon;
        }

        #endregion

        #region 2.Insert
        public static bool InsertHoaDon(HoaDonDTO hoadon)
        {
            bool result = false;
            try
            {
                //create a list parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                //parameters.Add(new MySqlParameter("@MaTK", taikhoan.MaTK));
                parameters.Add(new MySqlParameter("@MaHD", hoadon.MaHD));
                parameters.Add(new MySqlParameter("@NgayLapHD", hoadon.NgayLapHD));
                parameters.Add(new MySqlParameter("@TongTien", hoadon.TongTien));
                parameters.Add(new MySqlParameter("@MaKH", hoadon.MaKH));
                parameters.Add(new MySqlParameter("@ThanhTien", hoadon.ThanhTien));
                parameters.Add(new MySqlParameter("@GiamGia", hoadon.GiamGia));
               

                //call store Procedure
                int n = MySqlDataAccessHelper.ExecuteNonQuery("INSERT INTO hoadon (MaHD, NgayLapHD, TongTien, FK_MaKH, GiamGia, ThanhTien) VALUES(@MaHD, @NgayLapHD, @TongTien, @MaKH, @GiamGia, @ThanhTien)", parameters);
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
