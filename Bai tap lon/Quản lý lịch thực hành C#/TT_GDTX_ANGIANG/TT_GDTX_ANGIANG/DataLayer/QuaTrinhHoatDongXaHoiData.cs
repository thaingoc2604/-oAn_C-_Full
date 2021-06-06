using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhHoatDongXaHoiData
    {

        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuaTrinhHoatDongXaHoi()
        public DataTable lay_dsQuaTrinhHoatDongXaHoi()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_HOATDONGXAHOI");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuaTrinhHoatDongXaHoi()
        public DataTable lay_dsQuaTrinhHoatDongXaHoi(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTHDXH, MANHANVIEN, NGAYBD, NGAYKT, NOIDUNG, MANV From QT_HOATDONGXAHOI , NHANVIEN WHERE NHANVIEN.MANV = QT_HOATDONGXAHOI.MANHANVIEN AND QT_HOATDONGXAHOI.MANHANVIEN = @ma");
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

        #region CapNhatQTHoatDongXaHoi()
        public void CapNhatQTHoatDongXaHoi(QuaTrinhHoatDongXaHoiInfo QTHoatDongXHInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_HOATDONGXAHOI SET NGAYBD =@ngayBD, NGAYKT =@ngayKT, NOIDUNG = @noidung WHERE MAQTHDXH = @maqthdxh";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqthdxh", SqlDbType.VarChar).Value = QTHoatDongXHInfo.MaQTHoatDongXaHoi;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = QTHoatDongXHInfo.TuNgay;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = QTHoatDongXHInfo.DenNgay;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = QTHoatDongXHInfo.NoiDung;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhHoatDongXaHoi

        public void Xoa_QuaTrinhHoatDongXaHoi(String MaQTHDXH)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_HOATDONGXAHOI where MAQTHDXH = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTHDXH;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Xoa_QuaTrinhHoatDongXaHoi_NhanVien

        public void Xoa_QuaTrinhHoatDongXaHoi_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_HOATDONGXAHOI where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

    }
}
