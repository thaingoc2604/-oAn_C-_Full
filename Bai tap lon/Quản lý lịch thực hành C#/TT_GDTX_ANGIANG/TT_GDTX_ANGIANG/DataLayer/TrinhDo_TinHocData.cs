using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class TrinhDo_TinHocData
    {

        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsTrinhDoTinHoc()
        public DataTable lay_dsTrinhDoTinHoc()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From TRINHDOTINHOC");
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

        #region GetTrinhDoTinHoc()
        public TrinhDo_TinHocInfo GetTrinhDoTinHoc(string maTDTH)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENTDTH From TRINHDOTINHOC Where MATDTH = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDTH;
            this.Service.Load(cmd);

            return new TrinhDo_TinHocInfo(maTDTH, this.Service.Rows[0][0].ToString());
        }
        #endregion       

        #region lay_dsNhanVienThuocTrinhDoTinHoc
        public DataTable lay_dsNhanVienThuocTrinhDoTinHoc(string maTDTH)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG, NHANVIEN Where TD_TINHOC = @ma or TD_TINHOCNV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maTDTH;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region XoaTrinhDoTinHoc

        public void XoaTrinhDoTinHoc(String MaTDTH)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from TRINHDOTINHOC where MATDTH = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaTDTH;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
