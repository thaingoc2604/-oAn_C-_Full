//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace Data_tier
{
    public class General_data
    {

        public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=QuanLiThucAn.mdb");


        public DataSet getAllTable(string strTableName)
        {
            OleDbCommand cmd = new OleDbCommand("select * from "+ strTableName,conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strTableName);
            return ds;
        }
    }
}
