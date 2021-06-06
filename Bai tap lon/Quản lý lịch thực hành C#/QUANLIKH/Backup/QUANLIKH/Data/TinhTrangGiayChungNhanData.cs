using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QUANLIKH.BusinessObject;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
    public class TinhTrangGiayChungNhanData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from TINHTRANGGIAYCHUNGNHAN");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow tt)
        {
            dp.Rows.Add(tt);
        }
        public void Delete(TinhTrangGiayChungNhan tt)
        {

        }
    }
}
