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
    public class CongViecDAO
    {
        public static List<CongViecDTO> SelectCongViecAll()
        {
            List<CongViecDTO> list = new List<CongViecDTO>();
            try
            {

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM congviec");
                foreach (DataRow dr in dt.Rows)
                {
                    CongViecDTO congviec = new CongViecDTO();
                    congviec.MaCV = dr["MaCV"].ToString();
                    congviec.TenCV = dr["TenCV"].ToString();
                    congviec.MoTa = dr["MoTa"].ToString();
                    list.Add(congviec);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static List<CongViecDTO> SelectCongViecByTenCongViec(String tenCV)
        {
            List<CongViecDTO> list = new List<CongViecDTO>();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@TenCV", tenCV));

                DataTable dt = MySqlDataAccessHelper.ExecuteQuery("SELECT * FROM congviec where TenCV = @TenCV", parameters);
                foreach (DataRow dr in dt.Rows)
                {
                    CongViecDTO congviec = new CongViecDTO();
                    congviec.MaCV = dr["MaCV"].ToString();
                    congviec.TenCV = dr["TenCV"].ToString();
                    congviec.MoTa = dr["MoTa"].ToString();
                    list.Add(congviec);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
    
}
