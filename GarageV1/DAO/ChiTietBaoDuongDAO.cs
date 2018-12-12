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
    public class ChiTietBaoDuongDAO
    {
        #region 1.Insert
        public static bool InsertChiTietBaoDuong(ChiTietBaoDuongDTO chitietbaoduong)
        {
            bool result = false;
            try
            {
                //create a list parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                //parameters.Add(new MySqlParameter("@MaTK", taikhoan.MaTK));
                parameters.Add(new MySqlParameter("@MaCTBD", chitietbaoduong.MaCTBD));
                parameters.Add(new MySqlParameter("@TrangThai", chitietbaoduong.TrangThai));
               
                parameters.Add(new MySqlParameter("@Phi", chitietbaoduong.Phi));
                parameters.Add(new MySqlParameter("@FK_MaPT", chitietbaoduong.MaPT));
                parameters.Add(new MySqlParameter("@FK_MaDV_CTBD", chitietbaoduong.MaDV));
                parameters.Add(new MySqlParameter("@FK_MaHD", chitietbaoduong.MaHD));
                parameters.Add(new MySqlParameter("@FK_MaCV", chitietbaoduong.MaCV));
                parameters.Add(new MySqlParameter("@SoLuong", chitietbaoduong.SoLuong));
                parameters.Add(new MySqlParameter("@DonGia", chitietbaoduong.DonGia));

                //call store Procedure
                int n = MySqlDataAccessHelper.ExecuteNonQuery("INSERT INTO chitietbaoduong (MaCTBD, TrangThai,  Phi, FK_MaPT, FK_MaDV_CTBD, FK_MaHD, FK_MaCV,SoLuong, DonGia) VALUES(@MaCTBD, @TrangThai,  @Phi, @FK_MaPT, @FK_MaDV_CTBD, @FK_MaHD, @FK_MaCV, @SoLuong, @DonGia)", parameters);
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

        #region 2. Retrieve
        public static String GenerateMaCTBD()
        {
            int newMaChiTiet = 0;
            try
            {
                System.Data.DataTable dt = MySqlDataAccessHelper.ExecuteQuery("select max(cast(replace(replace(MaCTBD, 'CT', ''), '', '') as unsigned)) + 1 as newMaChiTiet from chitietbaoduong");
                newMaChiTiet = dt.Rows[0]["NewMaChiTiet"].ToString() == "" ? 1 : int.Parse(dt.Rows[0]["NewMaChiTiet"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return string.Format("CT{0:000}", newMaChiTiet);
        }

        public static DataTable SelectChiTietBaoDuongByMaDichVu(String MaDichVu)
        {
            DataTable dt = new DataTable();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaDV", MaDichVu));
           
                dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM chitietbaoduong WHERE FK_MaDV_CTBD = @MaDV", parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public static List<ChiTietBaoDuongDTO> SelectChiTietBaoDuongByMaHoaDon(String MaHoaDon)
        {
            List<ChiTietBaoDuongDTO> list = new List<ChiTietBaoDuongDTO>();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@FK_MaHD", MaHoaDon));

                DataTable dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM chitietbaoduong WHERE FK_MaHD = @MaHD", parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    ChiTietBaoDuongDTO chiTiet = new ChiTietBaoDuongDTO();
                    chiTiet.MaCTBD = dr["MaCTBD"].ToString();
                    chiTiet.MaCV = dr["FK_MaCV"].ToString();
                    chiTiet.MaDV = dr["FK_MaDV_CTBD"].ToString();
                    chiTiet.MaPT = dr["FK_MaPT"].ToString();
                    chiTiet.Phi =int.Parse( dr["Phi"].ToString());
                    chiTiet.SoLuong =int.Parse( dr["SoLuong"].ToString());
                    chiTiet.TrangThai = bool.Parse(dr["TrangThai"].ToString());
                    chiTiet.MaHD = dr["FK_MaHD"].ToString();
                    chiTiet.DonGia = int.Parse(dr["DonGia"].ToString());

                    list.Add(chiTiet);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        #endregion
    }
}
