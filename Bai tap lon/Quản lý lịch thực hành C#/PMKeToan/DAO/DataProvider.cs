using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Aspose.Cells;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Security.Cryptography;
namespace DAO
{
    public class DataProvider
    {
        static StreamReader re;

        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        public DataTable ReadExelFile(string path)
        {
            Workbook workbook = new Workbook();

            //Open template
            //string path = MapPath("~");
            //path = path.Substring(0, path.LastIndexOf("\\"));
            //path += @"\designer\book1.xls";
            workbook.Open(path);

            //Get the first worksheet in the workbook
            Worksheet worksheet = workbook.Worksheets[0];

            //Create a datatable
            DataTable dataTable = new DataTable();

            //Export worksheet data to a DataTable object by calling either ExportDataTable or ExportDataTableAsString method of the Cells class		 	

            //MessageBox.Show(path);
            dataTable = worksheet.Cells.ExportDataTableAsString(0, 0, worksheet.Cells.MaxRow + 1,
                         worksheet.Cells.MaxColumn + 1);

            //Bind the DataGrid with DataTable
            return dataTable;

        }

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

        public static void UpdateConnectionString(string cn_string)
        {
            //Connectionstring = "data source=servergv;initial catalog=dataacc;user id=sa;password=chiphssv;";

            //Connectionstring = Readtextfile();

            System.Configuration.Configuration config =
   ConfigurationManager.OpenExeConfiguration
   (Application.StartupPath + "/Accounting.exe");

            config.AppSettings.Settings.Remove("dbConnectionString");


            config.AppSettings.Settings.Add("dbConnectionString",cn_string);

            config.Save();
            

        }

        public static string GetTenCyChuQuan()
        {

            System.Configuration.Configuration config =
   ConfigurationManager.OpenExeConfiguration
   (Application.StartupPath + "/Accounting.exe");

            return config.AppSettings.Settings["NameHead"].Value;

        }

        public static string GetTenCy()
        {
        
            System.Configuration.Configuration config =
   ConfigurationManager.OpenExeConfiguration
   (Application.StartupPath + "/Accounting.exe");

            return config.AppSettings.Settings["NameCompany"].Value;

        }

        public static void UpdateInfoComp(string trencty, string tendvichuquan)
        {
            //Connectionstring = "data source=servergv;initial catalog=dataacc;user id=sa;password=chiphssv;";

            //Connectionstring = Readtextfile();

            System.Configuration.Configuration config =
   ConfigurationManager.OpenExeConfiguration
   (Application.StartupPath + "/Accounting.exe");

            config.AppSettings.Settings.Remove("NameCompany");


            config.AppSettings.Settings.Add("NameCompany", trencty);

            config.AppSettings.Settings.Remove("NameHead");


            config.AppSettings.Settings.Add("NameHead", tendvichuquan);

            config.Save();


        }


        public static string ResetConnectionString()
        {
            //Connectionstring = "data source=servergv;initial catalog=dataacc;user id=sa;password=chiphssv;";

            //Connectionstring = Readtextfile();
            Connectionstring = ConfigurationSettings.AppSettings["dbConnectionString"];
          
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
            catch (SqlException e)
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

            if (Connect() == false)
                return 2;


            _Adapter = new SqlDataAdapter(ProcName, _Connection);
            _Command = _Adapter.SelectCommand;
            _Command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter Param in Params)
            {
                _Command.Parameters.Add(Param);
            }
            object ob = _Command.ExecuteScalar();

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