using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuocTichData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuocTich()
        public DataTable lay_dsQuocTich()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QUOCTICH");
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

        #region GetQuocTich()
        public QuocTichInfo GetQuocTich(string maQT)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENQT From QUOCTICH Where MAQT = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maQT;
            this.Service.Load(cmd);

            return new QuocTichInfo(maQT, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocQuocTich
        public DataTable lay_dsNhanVienThuocQuocTich(string maQT)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where QUOCTICH = @ma or QUOCTICHNV =@ma ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maQT;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

       

        #region XoaQuocTich

        public void XoaQuocTich(String MaQT)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QUOCTICH where MAQT = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQT;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
       
    }
}
