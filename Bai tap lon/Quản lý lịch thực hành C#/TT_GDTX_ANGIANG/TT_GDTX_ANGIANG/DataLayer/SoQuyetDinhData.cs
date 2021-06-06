using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class SoQuyetDinhData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsSoQuyetDinh()
        public DataTable lay_dsSoQuyetDinh()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From SOQUYETDINH");
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


        #region GetSoQuyetDinh()
        public SoQuyetDinhInfo GetSoQuyetDinh(string maSoQD)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select MASQD From SOQUYETDINH Where MASQD = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maSoQD;
            this.Service.Load(cmd);

            return new SoQuyetDinhInfo(maSoQD, this.Service.Rows[0][0].ToString());
        }
        #endregion       

       
    }
}
