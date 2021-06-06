using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QUANLIKH.BusinessObject;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
   public  class ChucVuData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from CHUCVU");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow chucvu)
        {
            dp.Rows.Add(chucvu);
        }
       public void Delete(ChucVu chucvu)
        {

        }
    }
}
