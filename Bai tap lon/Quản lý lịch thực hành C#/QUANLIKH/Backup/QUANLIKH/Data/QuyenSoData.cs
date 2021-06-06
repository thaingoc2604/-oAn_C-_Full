using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
    public class QuyenSoData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from QUYENSO");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow quyenso)
        {
            dp.Rows.Add(quyenso);
        }
        public void Delete(QuyenSo quyenso)
        {

        }

        public DataTable SelectAll(string daily)
        {
            SqlCommand cmd = new SqlCommand("select * from QUYENSO where @daily=MADAILY");
            cmd.Parameters.Add("@daily", SqlDbType.NVarChar).Value = daily;
            dp.Load(cmd);
            return dp;
        }
    }
}
