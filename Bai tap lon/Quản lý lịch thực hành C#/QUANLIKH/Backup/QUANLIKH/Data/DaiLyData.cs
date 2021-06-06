using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
    public class DaiLyData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll(string mnv)
        {
            SqlCommand cmd = new SqlCommand("select * from THONGTINDAILY where @manv=MANVQL");
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = mnv;
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow dl)
        {
            dp.Rows.Add(dl);
        }
        public void Delete(DaiLy dl)
        {

        }

        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from THONGTINDAILY");
            dp.Load(cmd);
            return dp;
        }
        public DataTable Find(String tendaily, String chonmnv, String nv, String chondiachi, String diachi)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "select* from THONGTINDAILY WHERE HOVATEN LIKE '%'+ @tendaily +'%'";

            cmd.Parameters.Add("@tendaily", SqlDbType.NVarChar).Value = tendaily;
            cmd.Parameters.Add("@nv", SqlDbType.NVarChar).Value = nv;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            //cmd.Parameters.Add("@bienso", SqlDbType.NVarChar).Value = bienso;
            //cmd.Parameters.Add("@sokhung", SqlDbType.NVarChar).Value = sokhung;
            //cmd.Parameters.Add("@somay", SqlDbType.NVarChar).Value = somay;
            if (!chonmnv.Equals("NONE"))
                sql += chonmnv + " MANVQL LIKE '%'+ @nv+'%'";
            if (!chondiachi.Equals("NONE"))
                sql += chondiachi + " DIACHI LIKE '%'+ @diachi+'%'";
            //if (!chonbienso.Equals("NONE"))
            //    sql += chonbienso + "  BIENSO LIKE '%' + @bienso +'%'";
            //if (!chonsokhung.Equals("NONE"))
            //    sql += chonsokhung + " SOKHUNG LIKE '%' + @sokhung +'%'";

            //if (!chonsomay.Equals("NONE"))
            //    sql += chonsomay + "SOMAY LIKE '%' + @somay +'%'";

            cmd.CommandText = sql;
            dp.Load(cmd);
            return dp;


        }
    }
}