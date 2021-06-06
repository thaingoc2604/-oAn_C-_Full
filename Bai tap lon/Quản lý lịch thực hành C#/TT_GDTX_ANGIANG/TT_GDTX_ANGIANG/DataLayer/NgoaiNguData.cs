using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class NgoaiNguData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsNgoaiNgu()
        public DataTable lay_dsNgoaiNgu()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NGOAINGU");
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

        #region GetNgoaiNgu()
        public NgoaiNguInfo GetNgoaiNgu(string maNN)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENNN From NGOAINGU Where MANN = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maNN;
            this.Service.Load(cmd);

            return new NgoaiNguInfo(maNN, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocNgoaiNgu
        public DataTable lay_dsNhanVienThuocNgoaiNgu(string maNN)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where NGOAINGUCHINH = @ma or NGOAINGUCHINHNV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maNN;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region XoaNgoaiNgu

        public void XoaNgoaiNgu(String MaNN)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from NGOAINGU where MANN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNN;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
