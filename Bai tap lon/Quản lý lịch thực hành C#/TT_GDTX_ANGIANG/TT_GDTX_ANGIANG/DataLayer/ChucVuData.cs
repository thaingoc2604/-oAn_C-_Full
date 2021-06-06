using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class ChucVuData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsChucVu()
        public DataTable lay_dsChucVu()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From CHUCVU");
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

        #region GetChucVu()
        public ChucVuInfo GetChucVu(string maCV)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENCV From CHUCVU Where MACV = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maCV;
            this.Service.Load(cmd);

            return new ChucVuInfo(maCV, this.Service.Rows[0][0].ToString());
        }
        #endregion       
    }
}
