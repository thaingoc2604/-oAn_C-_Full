using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    class DataAccessHelper
    {
        private static string _ConnectionString;

        public static string ConnectionString
        {
            get
            {
                if (_ConnectionString == null)
                    _ConnectionString = GetConnectionString("ConnectionString.xml");

                return _ConnectionString;
            }
        }

        private static string GetConnectionString(string xml_file_Name)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xml_file_Name);
                XmlElement root = doc.DocumentElement;
                string connectionString = root.InnerText;
                return connectionString;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }        

        public static DataTable ExcuteQuery(string SpName, List<SqlParameter> sqlParams)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                try
                {

                    SqlCommand Command = Conn.CreateCommand();

                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = SpName;

                    if (sqlParams != null)
                    {
                        foreach (SqlParameter para in sqlParams)
                        {
                            Command.Parameters.Add(para);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(Command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static DataTable ExcuteQuery(string SpName)
        {
            return ExcuteQuery(SpName, null);
        }

        public static int ExcuteNonQuery(string spName, List<SqlParameter> sqlParams)
        {
            int n;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                try
                {
                    SqlCommand command = conn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    foreach (SqlParameter para in sqlParams)
                    {
                        command.Parameters.Add(para);
                    }

                    n = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return n;
        }
    }
}
