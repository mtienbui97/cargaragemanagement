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
    public class NhanVienDAO
    {
        #region 1. Retrieving 
        public static List<NhanVienDTO> SelectNhanVienAll()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            try
            {
                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM nhanvien");
                foreach(DataRow dr in dt.Rows)
                {
                    NhanVienDTO nhanvien = new NhanVienDTO
                    {
                        MaNV = dr["MaNV"].ToString(),
                        TenNV = dr["TenNV"].ToString(),
                        NamSinh = dr["NamSinh"].ToString(),
                        SDT = dr["SDT"].ToString(),
                        DiaChi = dr["DiaChi"].ToString(),
                        ChucVu = dr["ChucVu"].ToString()
                    };
                    list.Add(nhanvien);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static NhanVienDTO SelectNhanVienById(String nhanvienID)
        {
            NhanVienDTO nhanvien = new NhanVienDTO();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaNV", nhanvienID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM nhanvien WHERE MaNV = @MaNV",parameters);
                DataRow dr = dt.Rows[0];
                nhanvien.MaNV = dr["MaNV"].ToString();
                nhanvien.TenNV = dr["TenNV"].ToString();
                nhanvien.NamSinh = dr["NamSinh"].ToString();
                nhanvien.SDT = dr["SDT"].ToString();
                nhanvien.DiaChi = dr["DiaChi"].ToString();
                nhanvien.ChucVu = dr["ChucVu"].ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return nhanvien;
        }

        public static List<NhanVienDTO> SelectNhanVienByTenNhanVien(String tenNV)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            try
            {
                // Create List Sql Parameter
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@TenNV", tenNV));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM nhanvien WHERE TenNV = @TenNV", parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    NhanVienDTO nhanvien = new NhanVienDTO
                    {
                        MaNV = dr["MaNV"].ToString(),
                        TenNV = dr["TenNV"].ToString(),
                        NamSinh = dr["NamSinh"].ToString(),
                        SDT = dr["SDT"].ToString(),
                        DiaChi = dr["DiaChi"].ToString(),
                        ChucVu = dr["ChucVu"].ToString()
                    };
                    list.Add(nhanvien);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static bool CheckNhanVienById(String nhanvienID)
        {
            bool result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaNV", nhanvienID));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT MaNV FROM nhanvien WHERE MaNV = @MaNV", parameters);
                if(dt.Rows.Count ==1)
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
        #endregion
    }
}
