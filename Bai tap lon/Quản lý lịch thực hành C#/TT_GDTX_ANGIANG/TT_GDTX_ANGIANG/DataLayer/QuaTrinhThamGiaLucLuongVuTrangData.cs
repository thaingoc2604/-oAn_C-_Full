using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhThamGiaLucLuongVuTrangData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQTTGLucLuongVuTrang()
        public DataTable lay_dsQTTGLucLuongVuTrang()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_THAMGIALUCLUONGVUTRANG");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQTTGLucLuongVuTrang()
        public DataTable lay_dsQTTGLucLuongVuTrang(String ma)
        {

            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTTGLLVT, MANHANVIEN, NGAYNN, NGAYXN, CHUCVUVUTRANG, QUANHAM, MANV From QT_THAMGIALUCLUONGVUTRANG , NHANVIEN WHERE NHANVIEN.MANV = QT_THAMGIALUCLUONGVUTRANG.MANHANVIEN AND QT_THAMGIALUCLUONGVUTRANG.MANHANVIEN = @ma");//CHUCVU
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
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

        #region CapNhatQuaTrinhThamGiaHoatDongVuTrang()
        public void CapNhatQuaTrinhThamGiaHoatDongVuTrang(QuaTrinhThamGiaLucLuongVuTrangInfo boiduongInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_THAMGIALUCLUONGVUTRANG SET NGAYNN =@ngayBD, NGAYXN =@ngayKT, CHUCVUVUTRANG =@noiBD, QUANHAM = @noidung WHERE MAQTTGLLVT = @maqtbd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtbd", SqlDbType.VarChar).Value = boiduongInfo.MaQuaTrinhThamGiaLucLuongVuTrang;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = boiduongInfo.NgayNN;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = boiduongInfo.NgayXN;
            cmd.Parameters.Add("@noiBD", SqlDbType.NVarChar).Value = boiduongInfo.ChucVu;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = boiduongInfo.QuanHamCaoNhat;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhThamGiaLLVT

        public void Xoa_QuaTrinhThamGiaLLVT(String MaQTTGLLVT)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_THAMGIALUCLUONGVUTRANG where MAQTTGLLVT = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTTGLLVT;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhThamGiaLLVT_NHANVIEN

        public void Xoa_QuaTrinhThamGiaLLVT_NHANVIEN(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_THAMGIALUCLUONGVUTRANG where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
