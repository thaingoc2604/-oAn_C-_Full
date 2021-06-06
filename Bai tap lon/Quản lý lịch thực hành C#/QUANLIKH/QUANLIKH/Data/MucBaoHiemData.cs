using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QUANLIKH.BusinessObject;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
    public class MucBaoHiemData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from MUCBAOHIEM");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow mucbh)
        {
            dp.Rows.Add(mucbh);
        }
        public void Delete(MucBaoHiem mucbh)
        {

        }
    }
}
