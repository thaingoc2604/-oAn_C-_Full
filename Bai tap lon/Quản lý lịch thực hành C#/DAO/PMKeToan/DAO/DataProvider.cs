using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DevComponents.DotNetBar;
using System.Windows.Forms;
namespace DAO
{
    public class DataProvider
    {
        static StreamReader re;

        public void Writetextfile()
        {
            FileInfo t = new FileInfo("Collin.txt");
            StreamWriter Tex = t.CreateText();
            Tex.WriteLine("Collin has launced another article");
            Tex.WriteLine("csharpfriends is the new url for c-sharp");
            Tex.Write(Tex.NewLine);
            Tex.Close();
            Console.WriteLine(" The Text file named Collin is created ");

        }

        public static string Readtextfile()
        {
            
            try
            {

               re = new StreamReader(Application.StartupPath + "\\config.txt");

            }

            catch (IOException e)
            {
                MessageBox.Show("File not found!!!");

                return "";
            }
            string input = null;

            input = re.ReadLine();

            return input;
            
        }

        #region Connection
        private static string _Connectionstring = string.Empty;
        private SqlConnection _Connection;
        private SqlCommand _Command;
        private static SqlDataAdapter _Adapter;
        #endregion
        public static string Connectionstring
        {
            get { return DataProvider._Connectionstring; }
            set { DataProvider._Connectionstring = value; }
        }
        public static SqlDataAdapter Adapter
        {
            get { return DataProvider._Adapter; }
            set { DataProvider._Adapter = value; }
        }

        #region Reset ConnectionString
        public static string ResetConnectionString()
        {
            //Connectionstring = "data source=servergv;initial catalog=dataacc;user id=sa;password=chiphssv;";

            Connectionstring = Readtextfile();

            return Connectionstring;
        }
        #endregion Connection


        protected SqlCommand Command
        {
            get { return _Command; }
            set { _Command = value; }
        }
        protected SqlConnection Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
        public bool Connect()
        {
            try
            {
               
                _Connection = new SqlConnection(Connectionstring);
                _Connection.Open();
            }
            catch (SqlException e)
            {
                MessageBoxEx.Show("Vui lòng kiểm tra Server", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
        public void Connect(string Catalog)
        {
            Connectionstring = string.Format("Data Source=.;Initial Catalog={0};Integrated Security=True", Catalog);
            _Connection = new SqlConnection(Connectionstring);
            _Connection.Open();

        }
        public void DisConnect()
        {
            try
            {

                _Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("System eror!!!");
            }
        }
        #region ExecuteQuery
        public SqlDataReader ExecuteQuery(string _sql, bool rs)
        {
            using (_Command =
                    new SqlCommand(_sql, _Connection))
                return _Command.ExecuteReader();
        }
        //public void ExecuteNonQuery(string _sql)
        //{
        //    using (_Command =
        //            new SqlCommand(_sql, _Connection))
        //        _Command.ExecuteNonQuery();
        //}

        public SqlCommand CreateCommand(string ProcName)
        {
            _Command = new SqlCommand(ProcName, _Connection);
            _Command.CommandType = CommandType.StoredProcedure;
            return _Command;
        }

        public DataTable LoadData(string ProcName, params SqlParameter[] Params)
        {
            if (!Connect()) return null;

            _Adapter = new SqlDataAdapter(ProcName, _Connection);
            _Command = _Adapter.SelectCommand;
            _Command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter Param in Params)
            {
                _Command.Parameters.Add(Param);
            }

            DataTable dt = new DataTable();
            _Adapter.Fill(dt);

           DisConnect();

            return dt;
        }
        public DataSet DExecuteQuery(string _sql)
        {
            DataSet ds = new DataSet();
            using (_Adapter =
                        new SqlDataAdapter(_sql, _Connection))
            {
                _Adapter.Fill(ds);
            }
            return ds;
        }
        public object ExecuteScalar(string ProcName, params SqlParameter[] Params)
        {
            
            Connect();
            

            _Adapter = new SqlDataAdapter(ProcName, _Connection);
            _Command = _Adapter.SelectCommand;
            _Command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter Param in Params)
            {
                _Command.Parameters.Add(Param);
            }
            object ob = _Command.ExecuteScalar() ;

            DisConnect();

            return ob;
        }

        public int ExecuteNonQuery(string ProcName, params SqlParameter[] Params)
        {

            Connect();


            _Adapter = new SqlDataAdapter(ProcName, _Connection);
            _Command = _Adapter.SelectCommand;
            _Command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter Param in Params)
            {
                _Command.Parameters.Add(Param);
            }
            int count = _Command.ExecuteNonQuery();

            DisConnect();

            return count;
        }
        #endregion
    }
}