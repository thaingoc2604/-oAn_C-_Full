using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class TrinhDo_HocVanData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsTDHocVan()
        public DataTable lay_dsTDHocVan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From TRINHDOHOCVAN");
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

        #region GetTrinhDoHocVan()
        public TrinhDo_HocVanInfo GetTrinhDoHocVan(string maTDHV)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENTDHV From TRINHDOHOCVAN Where MATDHV = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDHV;
            this.Service.Load(cmd);

            return new TrinhDo_HocVanInfo(maTDHV, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocTrinhDoHocVan
        public DataTable lay_dsNhanVienThuocTrinhDoHocVan(string maTDHV)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where TD_HOCVAN = @ma or TD_HOCVANNV = @ma ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDHV;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

       

        #region XoaTrinhDoHocVan

        public void XoaTrinhDoHocVan(String MaTDHV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from TRINHDOHOCVAN where MATDHV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaTDHV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
