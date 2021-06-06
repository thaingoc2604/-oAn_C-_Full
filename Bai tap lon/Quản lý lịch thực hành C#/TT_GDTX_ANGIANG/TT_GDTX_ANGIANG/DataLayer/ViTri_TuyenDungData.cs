using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class ViTri_TuyenDungData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsVTTuyenDung()
        public DataTable lay_dsVTTuyenDung()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From VITRITUYENDUNG");
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

        #region GetViTriTuyen()
        public ViTri_TuyenDungInfo GetViTriTuyen(string maVTTD)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENVTTD From VITRITUYENDUNG Where MAVTTD = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maVTTD;
            this.Service.Load(cmd);

            return new ViTri_TuyenDungInfo(maVTTD, this.Service.Rows[0][0].ToString());
        }
        #endregion


        #region lay_dsHoSoThuocViTriTuyenDung
        public DataTable lay_dsHoSoThuocViTriTuyenDung(string maVTTD)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From HOSOTUYENDUNG Where VITRITUYEN = @ma ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maVTTD;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region XoaViTriTuyenDung

        public void XoaViTriTuyenDung(String MaVTTD)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from VITRITUYENDUNG where MAVTTD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaVTTD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
