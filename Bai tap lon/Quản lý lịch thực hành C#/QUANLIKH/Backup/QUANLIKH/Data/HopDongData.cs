using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QUANLIKH.BusinessObject;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
   public  class HopDongData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from HOPDONG");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow hd)
        {
            dp.Rows.Add(hd);
        }
        public void Delete(HopDong hd)
        {

        }

       public DataTable Find(String sohd, String chonmadaily, String madaily)
       {
           SqlCommand cmd = new SqlCommand();
           String sql = "select* from HOPDONG WHERE SOHOPDONG LIKE '%'+ @sohd +'%'";

           cmd.Parameters.Add("@sohd", SqlDbType.NVarChar).Value = sohd;
           cmd.Parameters.Add("@madaily", SqlDbType.NVarChar).Value = madaily;

           if (!chonmadaily.Equals("NONE"))
               sql += chonmadaily + " MADAILY LIKE '%'+ @madaily+'%'";
          
           cmd.CommandText = sql;
           dp.Load(cmd);
           return dp;





       }
      

    }
}
