using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class NghiViecData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsNghiViec()
        public DataTable lay_dsNghiViec()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NGHIVIEC");
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

        #region Tim_MaNghiViec        
       
        public DataTable Tim_MaNghiViec(String maNV)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  NGHIVIEC Where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_MaNhanVien()
        public DataTable lay_MaNhanVien(String manv)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  NGHIVIEC Where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = manv;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region Xoa_NhanVienNghiViec

        public void Xoa_NhanVienNghiViec(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from NGHIVIEC where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
