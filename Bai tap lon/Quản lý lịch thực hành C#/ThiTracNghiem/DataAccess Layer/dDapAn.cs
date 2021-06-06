using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace DataAccess_Layer
{
    public class dDapAn : ConnectDB
    {
        private ConnectDB cndb = new ConnectDB();

        private OleDbConnection con;

        public OleDbConnection Connection()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbCauHoi.accdb;Persist Security Info=True");
            return con;
        }
        public DataSet SelectFrom(string tablename)
        {
            OleDbCommand cmd = new OleDbCommand("Select * from " + tablename, connect);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tablename);
            return ds;
        }
    }
}
