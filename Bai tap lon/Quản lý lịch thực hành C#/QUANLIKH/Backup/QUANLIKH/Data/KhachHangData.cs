using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace QUANLIKH.Data
{
    public class KhachHangData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow kh)
        {
            dp.Rows.Add(kh);
        }
        public void Delete(KhachHang kh)
        {

        }
        /*internal DataTable Find(string tendvct, string chondiachi, string diachi)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = "select * from DONVICONGTAC WHERE TENDVCT LIKE '%' + @tendvct + '%'  ";

            //-----gan gia tri can tim vào 2 biến @tenncc và @diachi
            cmd.Parameters.Add("@tendvct", SqlDbType.NVarChar).Value = tendvct;

            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            //---nối vào sql tùy chọn AND hay OR hay NOT AND
            if (!chondiachi.Equals("NONE"))
                sql += chondiachi + "  DIACHI LIKE '%' + @diachi +'%'";

            cmd.CommandText = sql;
            dp.Load(cmd);
            return dp;
        }*/
        public DataTable Find(String tenkh, String chondiachi, String diachi, String chonbienso, String bienso, String chonsokhung, String sokhung, String chonsomay, String somay)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "select* from KHACHHANG WHERE HOVATEN LIKE '%'+ @tenkh +'%'";

            cmd.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@bienso", SqlDbType.NVarChar).Value = bienso;
            cmd.Parameters.Add("@sokhung", SqlDbType.NVarChar).Value = sokhung;
            cmd.Parameters.Add("@somay", SqlDbType.NVarChar).Value = somay;
            if (!chondiachi.Equals("NONE"))
                sql += chondiachi + " DIACHI LIKE '%'+ @diachi+'%'";
            if (!chonbienso.Equals("NONE"))
                sql += chonbienso + "  BIENSO LIKE '%' + @bienso +'%'";
            if (!chonsokhung.Equals("NONE"))
                sql += chonsokhung + " SOKHUNG LIKE '%' + @sokhung +'%'";

            if (!chonsomay.Equals("NONE"))
                sql += chonsomay + " SOMAY LIKE '%' + @somay +'%'";

            cmd.CommandText = sql;
            dp.Load(cmd);
            return dp;





        }
      

       
    }
}
