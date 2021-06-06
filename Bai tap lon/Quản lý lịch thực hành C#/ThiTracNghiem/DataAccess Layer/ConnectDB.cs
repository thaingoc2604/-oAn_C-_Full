using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace DataAccess_Layer
{
    public class ConnectDB
    {
        public  OleDbConnection connect=new OleDbConnection();
        string str_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbCauHoi.accdb;Persist Security Info=True";

        public ConnectDB()
        {
            try
            {
                connect = new OleDbConnection(str_con);
            }
            catch(Exception )
            {
                throw new Exception("Lỗi kết nối !");
            }

        }
        public void Moketnoi()
        {
            connect.Open();
        }

        public void Dongketnoi()
        {
            connect.Close();
        }

        public DataSet get_All_Table(string tablename)
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + tablename, connect);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tablename);
            return ds;
        }
    }   
}
