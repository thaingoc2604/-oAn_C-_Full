using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class NgachData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsNgach()
        public DataTable lay_dsNgach()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NGACH");
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

        #region GetNgach()
        public NgachInfo GetNgach(string maNgach)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENNGACH From NGACH Where MANGACH = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maNgach;
            this.Service.Load(cmd);

            return new NgachInfo(maNgach, this.Service.Rows[0][0].ToString());
        }
        #endregion       
    }
}
