using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace DataAccess_Layer
{
    public class dTinChi : ConnectDB
    {
        private ConnectDB cndb = new ConnectDB();

        private OleDbConnection con;

        public OleDbConnection Connection()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbCauHoi.accdb;Persist Security Info=True");
            return con;
        }
    }
}
