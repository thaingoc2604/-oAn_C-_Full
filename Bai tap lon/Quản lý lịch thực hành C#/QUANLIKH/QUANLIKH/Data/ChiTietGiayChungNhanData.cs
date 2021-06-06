using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
   public  class ChiTietGiayChungNhanData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from CHITIETGIAYCHUNGNHAN");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow anchi)
        {
            dp.Rows.Add(anchi);
        }
       public void Delete(ChiTietGiayChungNhan anchi)
        {

        }

       public DataTable SelectAnChiXuat(string mq)
       {
           SqlCommand cmd = new SqlCommand("select MAQUYEN,SOSERI,MATINHTRANG,THUEVAT,CHUATHUE from CHITIETGIAYCHUNGNHAN where @mq=MAQUYEN");
           cmd.Parameters.Add("@mq", SqlDbType.NVarChar).Value = mq;
           dp.Load(cmd);
           return dp;
       }
       public DataTable SelectAnChiTheoTinhTrang(string mtt)
       {
           SqlCommand cmd = new SqlCommand("select MAQUYEN,SOSERI from CHITIETGIAYCHUNGNHAN where @mtt=MATINHTRANG");
           cmd.Parameters.Add("@mtt", SqlDbType.NVarChar).Value = mtt;
           dp.Load(cmd);
           return dp;
       }
       public DataTable SelectThuAnChi(string mq)
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETGIAYCHUNGNHAN where @mq=MAQUYEN");
           cmd.Parameters.Add("@mq", SqlDbType.NVarChar).Value = mq;
           dp.Load(cmd);
           return dp;
       }
    
       public DataTable LayChuaThue(String t)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM CHITIETGIAYCHUNGNHAN WHERE CHUATHUE=@chuathue");
           cmd.Parameters.Add("@chuathue", SqlDbType.SmallInt).Value =Convert.ToInt16 (t);
           dp.Load(cmd);
           return dp;
       }
    }
}
