using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class PhongBanData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsPhongBan()
        public DataTable lay_dsPhongBan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From PHONGBAN");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region Update()
        public bool Update()
        {
            return Service.Update();
        }
        #endregion

       

        #region lay_dsNhanVienCoTrongPhongBan
        public DataTable lay_dsNhanVienCoTrongPhongBan(string maPH)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From NHANVIEN Where PHONGBAN = @ma  ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maPH;           
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion   
 
        #region XoaPhongBan

        public void XoaPhongBan(String MaPB)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from PHONGBAN where MAPB = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaPB;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region GetPhongBan()
        public PhongBanInfo GetPhongBan(string maPH)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENPB From PHONGBAN Where MAPB = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maPH;
            this.Service.Load(cmd);

            return new PhongBanInfo(maPH, this.Service.Rows[0][0].ToString());
        }
        #endregion       
    }
}
