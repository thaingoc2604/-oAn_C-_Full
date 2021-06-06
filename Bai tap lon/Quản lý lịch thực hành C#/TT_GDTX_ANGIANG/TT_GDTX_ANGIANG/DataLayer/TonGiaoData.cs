using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class TonGiaoData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region Table
        private DataTable m_Table;
        public DataTable Table
        {
            get { return m_Table; }
            set { m_Table = value; }
        }
         #endregion

        #region lay_dsTonGiao()
        public DataTable lay_dsTonGiao()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From TONGIAO");
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

        #region GetTonGiao()
        public TonGiaoInfo GetTonGiao(string maTG)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENTG From TONGIAO Where MATG = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTG;
            this.Service.Load(cmd);

            return new TonGiaoInfo(maTG, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocTonGiao
        public DataTable lay_dsNhanVienThuocTonGiao(string maTG)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where TONGIAO = @ma or TONGIAONV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTG;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion       

        #region XoaTonGiao

        public void XoaTonGiao(String MaTG)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from TONGIAO where MATG = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaTG;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
       
    }
}
