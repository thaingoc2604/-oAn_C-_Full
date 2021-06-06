using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class BacData
    {

        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsBac()
        public DataTable lay_dsBac()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From BAC");
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

        #region GetBac()
        public BacInfo GetBac(string maBac)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENBAC From BAC Where MABAC = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maBac;
            this.Service.Load(cmd);

            return new BacInfo(maBac, this.Service.Rows[0][0].ToString());
        }
        #endregion       
    }
}
