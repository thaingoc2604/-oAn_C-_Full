using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;
namespace TT_GDTX_ANGIANG.DataLayer
{
   
    public class NhatKyData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        public void NhatKy(String MaND, String TenDN, String TenDayDu, String date)
        {

            if (Service == null)
                Service = new DataService();
            //SqlCommand s = new SqlCommand("INSERT INTO CANBO(MACBQL,TENCBQL,DIACHI) VALUES(@ma,@ten,@diachi)");
            String sql = "INSERT INTO NHATKY(MANKY,TENDANGNHAP,TENDAYDU,NGAYDANGNHAP) VALUES(@ma,@tendn,@tendaydu,@ngaydangnhap)";
            SqlCommand cmd = new SqlCommand(sql);
            //SqlCommand cmd = new SqlCommand("INSERT INTO NHATKY(MANKY,TENDANGNHAP,TENDAYDU,NGAYDANGNHAP,LYDO)VALUES('" + MaND + "',N'" + TenDN + "',N'" + TenDayDu + "',N'" + date + "',N'" + LyDo + "')");
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = MaND;
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = TenDN;
            cmd.Parameters.Add("@tendaydu", SqlDbType.NVarChar).Value = TenDayDu;
            cmd.Parameters.Add("@ngaydangnhap", SqlDbType.NVarChar).Value = date;
           
            cmd.CommandText = sql;
            Service.Load(cmd);
        }

        //public DataTable TimKiem()
        //{
        //    if (Service == null)
        //        Service = new DataService();
        //    SqlCommand cmd = new SqlCommand("Select * From NHATKY");
        //    Service.Load(cmd);
        //    return Service;
        //}

        #region Update()
        public bool Update()
        {
            return Service.Update();
        }
        #endregion
    }
}
