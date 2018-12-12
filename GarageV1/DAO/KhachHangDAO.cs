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
    public class KhachHangDAO
    {
        #region 1. Retrieving 
        public static KhachHangDTO SelectKhachHangById(String khachhangID)
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaKH", khachhangID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM khachhang WHERE MaKH = @MaKH", parameters);
                DataRow dr = dt.Rows[0];
                khachhang.MaKH = dr["MaKH"].ToString();
                khachhang.TenKH = dr["TenKH"].ToString();
                khachhang.NamSinh = dr["NamSinh"].ToString();
                khachhang.SDT = dr["SDT"].ToString();
                khachhang.DiaChi = dr["DiaChi"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return khachhang;
        }

        public static bool CheckKhachHangById(String khachhangID)
        {
            bool result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaKH", khachhangID));

                DataTable dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT MaKH FROM khachhang WHERE MaKH = @MaKH", parameters);
                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static List<KhachHangDTO> SelectKhachHangByTenKhachHang(String tenKhachHang)
        {
            
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@TenKH", tenKhachHang));

                

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM khachhang WHERE TenKH = @TenKH", parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    KhachHangDTO khachhang = new KhachHangDTO();
                    khachhang.MaKH = dr["MaKH"].ToString();
                    khachhang.TenKH = dr["TenKH"].ToString();
                    khachhang.NamSinh = dr["NamSinh"].ToString();
                    khachhang.SDT = dr["SDT"].ToString();
                    khachhang.DiaChi = dr["DiaChi"].ToString();

                    list.Add(khachhang);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static bool CheckKhachHangByTenKhachHang(String tenKhachHang)
        {
            bool result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@TenKH", tenKhachHang));

                DataTable dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT TenKH FROM khachhang WHERE TenKH = @TenKH", parameters);
                if (dt.Rows.Count != 0)
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
