using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace tracnghiem_da
{
    public class tracnghiem_data
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;data source=db1.mdb;");
        public DataSet executeQuery(string sql, string tablename)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, tablename);
            return ds;
        }
    }
}
