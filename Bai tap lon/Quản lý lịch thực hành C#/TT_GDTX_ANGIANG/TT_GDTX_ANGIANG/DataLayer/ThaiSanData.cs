using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class ThaiSanData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsThaiSan()
        public DataTable lay_dsThaiSan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_THAISAN");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuaTrinhThaiSan
        public DataTable lay_dsQuaTrinhThaiSan(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTTS, MANHANVIEN, NGAYBD, NGAYKT,NGAYQUYETDINH, SOQUYETDINH, SINHCONTHU, NGUOIKY,NOIDUNG From QT_THAISAN , NHANVIEN WHERE NHANVIEN.MANV = QT_THAISAN.MANHANVIEN AND QT_THAISAN.MANHANVIEN = @ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region CapNhatQTThaiSan()
        public void CapNhatQTThaiSan(ThaiSanInfo QTThaiSanInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_THAISAN SET NGAYBD =@ngayBD, NGAYKT =@ngayKT,NGAYQUYETDINH = @ngayQD,NGUOIKY=@nguoiky,NOIDUNG=@noidung,SOQUYETDINH=@soQD,SINHCONTHU=@sinhconthu WHERE MAQTTS = @maqtts";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtts", SqlDbType.VarChar).Value = QTThaiSanInfo.MaQuaTrinhThaiSan ;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = QTThaiSanInfo.NgayBatDau;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = QTThaiSanInfo.NgayKetThuc;
            cmd.Parameters.Add("@ngayQD", SqlDbType.DateTime).Value = QTThaiSanInfo.NgayQuyetDinh;
            cmd.Parameters.Add("@nguoiky", SqlDbType.NVarChar).Value = QTThaiSanInfo.NguoiKy;
            cmd.Parameters.Add("@noidung", SqlDbType.Text).Value = QTThaiSanInfo.NoiDung;
            cmd.Parameters.Add("@soQD", SqlDbType.NVarChar).Value = QTThaiSanInfo.SoQuyetDinh.MaSoQuyetDinh;
            
            cmd.Parameters.Add("@sinhconthu", SqlDbType.NVarChar).Value = QTThaiSanInfo.SinhConThuMay;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Update()
        public bool Update()
        {
            return Service.Update();
        }
        #endregion

        #region Xoa_ThaiSan

        public void Xoa_ThaiSan(String MaTS)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_THAISAN where MAQTTS = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaTS;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_ThaiSan_NhanVien

        public void Xoa_ThaiSan_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_THAISAN where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
