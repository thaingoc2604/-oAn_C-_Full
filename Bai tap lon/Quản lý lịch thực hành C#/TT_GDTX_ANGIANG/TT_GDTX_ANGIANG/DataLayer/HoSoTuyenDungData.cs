using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class HoSoTuyenDungData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsHoSo_TuyenDung()
        public DataTable lay_dsHoSo_TuyenDung()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HOSOTUYENDUNG where STATUS=0");
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

         

        #region lay_dsHoSoTD_TheoMa()
        public DataTable lay_dsHoSoTD_TheoMa(int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  HOSOTUYENDUNG Where STATUS = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = trangthai;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region Update_UngCuVien()
        public void Update_UngCuVien(string mahs, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Update HOSOTUYENDUNG Set STATUS = @tt Where MAHS = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = mahs;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion    

        #region DeleteList()
        public void DeleteList(String mahs)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "delete from HOSOTUYENDUNG where MAHS = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = mahs;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region lay_dsHoSo_TuyenDung_total        
       
        internal DataTable lay_dsHoSo_TuyenDung_total()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HOSOTUYENDUNG");
            Service.Load(cmd);
            return Service;
        }
        #endregion
    }
}
