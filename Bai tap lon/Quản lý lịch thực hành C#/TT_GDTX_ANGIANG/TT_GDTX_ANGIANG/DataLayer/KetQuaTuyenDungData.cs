using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class KetQuaTuyenDungData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsKetQua_TuyenDung()
        public DataTable lay_dsKetQua_TuyenDung()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From KETQUATUYENDUNG");
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

        #region DeleteList()
        public void DeleteList(String maKQTD)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "delete from KETQUATUYENDUNG where MAKQTD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maKQTD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Update_NhanVien()
        public void Update_NhanVien(string maKQTD, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Update KETQUATUYENDUNG Set STATUS = @tt Where MAKQTD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maKQTD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion    

        #region KiemTra()
        public DataTable KiemTra(String maHS)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  KETQUATUYENDUNG kq, PHONGBAN pb, CHUCVU cv Where kq.PHONGBAN = pb.MAPH and kq.CHUCVU = cv.MACV and kq.MAHOSO = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maHS;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region HienThi()
        public DataTable HienThi(String maHS)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  KETQUATUYENDUNG Where MAHOSO = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maHS;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region TestStatus()
        public DataTable TestStatus(string maHS ,int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  KETQUATUYENDUNG Where MAHOSO = @ma and STATUS = @tt";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maHS;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region TestMaHoSo()
        public DataTable TestMaHoSo(string maHS)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  KETQUATUYENDUNG Where MAHOSO = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maHS;            
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsTrungTuyen()
        public DataTable lay_dsTrungTuyen(int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            //String sql = "Select * From  KETQUATUYENDUNG kq, HOSOTUYENDUNG hs , CHUCVU cv, PHONGBAN pb Where kq.MAHOSO = hs.MAHS and kq.CHUCVU=cv.MACV and kq.PHONGBAN=pb.MAPB and kq.STATUS = @ma ";
            String sql = "Select * From  KETQUATUYENDUNG kq, CHUCVU cv, PHONGBAN pb Where kq.CHUCVU=cv.MACV and kq.PHONGBAN=pb.MAPB and kq.STATUS = @ma ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = trangthai;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region CapNhat()
        public DataTable CapNhat(string maHS)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Update KETQUATUYENDUNG Set MANHANVIEN='', PHONGBAN='',DONVI='', CHUCVU='', SOQD='', NGAYTD='', GHICHU='', STATUS='0' Where MAHOSO = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maHS;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region DeleteMaHS()
        public void DeleteMaHS(String mahs)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "delete from KETQUATUYENDUNG where MAHOSO = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = mahs;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
