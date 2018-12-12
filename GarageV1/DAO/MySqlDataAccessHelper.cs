using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DAO
{
    public class MySqlDataAccessHelper
    {
        #region ConnectionString
        protected static String connectionString;
        public static String ConnectionString
        {
            set
            {
                connectionString = "server=localhost;user id=root;database=quanlygarageoto;password=1234567890;persistsecurityinfo=True";
            }
            get
            {
                return connectionString;
            }
        }
        #endregion
        #region ExecuteQuery

        public static DataTable ExecuteQuery(string query, List<MySqlParameter> parameters = null)
        {
            var dt = new DataTable();
            try
            {
                var connect = new MySqlConnection("server=localhost;user id=root;database=quanlygarageoto;password=1234567890;persistsecurityinfo=True");
                connect.Open();

                try
                {
                    var ds = new DataSet();
                    ds.Reset();
                    var adapter = new MySqlDataAdapter(query, connect);
                    if (parameters != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    }
                    adapter.Fill(ds);
                    dt = ds.Tables[0];
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        #endregion
        #region ExecuteNonQuery
        public static int ExecuteNonQuery(string query, List<MySqlParameter> parameters = null)
        {
            int n;
            try
            {
                MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=quanlygarageoto;password=3725141531;persistsecurityinfo=True");
                connect.Open();
                try
                {
                    var command = connect.CreateCommand();
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }
                    command.CommandText = query;
                    n = command.ExecuteNonQuery();
                }

                catch (MySqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;

        }
        #endregion

    }
}




