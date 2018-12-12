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
    public class XeDAO
    {
        #region 1. Retrieving 
       public static DataTable SelectXeByKhachHangId(String khachhangID)
        {
            //List<XeDTO> list = new List<XeDTO>(); 
            DataTable dt = new DataTable();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaKH", khachhangID));

                 dt = DAO.MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM xe WHERE MaKH = @MaKH", parameters);
                //foreach(DataRow dr in dt.Rows)
                //{
                //    XeDTO xe = new XeDTO();
                //    xe.SoXe = dr["SoXe"].ToString();
                //    xe.TenXe = dr["TenXe"].ToString();
                //    xe.HangSanXuat = dr["HangSX"].ToString();
                //    xe.NamSanXuat = dr["NamSX"].ToString();
                //    xe.MaKhachHang = dr["MaKH"].ToString();
                    
                //    list.Add(xe);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion
    }
}
