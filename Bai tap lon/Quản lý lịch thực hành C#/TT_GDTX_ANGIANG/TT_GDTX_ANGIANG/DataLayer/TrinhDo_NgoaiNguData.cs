using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class TrinhDo_NgoaiNguData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsTrinhDoNgoaiNgu()
        public DataTable lay_dsTrinhDoNgoaiNgu()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From TRINHDONGOAINGU");
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

        #region GetTrinhDoNgoaiNgu()
        public TrinhDo_NgoaiNguInfo GetTrinhDoNgoaiNgu(string maTDNN)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENTDNN From TRINHDONGOAINGU Where MATDNN = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDNN;
            this.Service.Load(cmd);

            return new TrinhDo_NgoaiNguInfo(maTDNN, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocTrinhDoNgoaiNgu
        public DataTable lay_dsNhanVienThuocTrinhDoNgoaiNgu(string maTDNN)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where TD_NGOAINGU = @ma or TD_NGOAINGUNV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDNN;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region XoaTonGiao

        public void XoaTrinhDoNgoaiNgu(String MaTDNN)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from TRINHDONGOAINGU where MATDNN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaTDNN;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
