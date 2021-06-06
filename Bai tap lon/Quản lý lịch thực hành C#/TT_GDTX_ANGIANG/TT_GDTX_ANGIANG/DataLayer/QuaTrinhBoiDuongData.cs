using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhBoiDuongData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuaTrinhBoiDuong()
        public DataTable lay_dsQuaTrinhBoiDuong( String ma)
        {            

            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTBD, MANHANVIEN, NGAYBD, NGAYKT, NOIBD, NOIDUNGBD, MANV From QT_BOIDUONG , NHANVIEN WHERE NHANVIEN.MANV = QT_BOIDUONG.MANHANVIEN AND QT_BOIDUONG.MANHANVIEN = @ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsQuaTrinhBoiDuong()
        public DataTable lay_dsQuaTrinhBoiDuong()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_BOIDUONG");
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

        #region CapNhatQuaTrinhBoiDuong()
        public void CapNhatQuaTrinhBoiDuong(QuaTrinhBoiDuongInfo boiduongInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_BOIDUONG SET NGAYBD =@ngayBD, NGAYKT =@ngayKT, NOIBD =@noiBD, NOIDUNGBD = @noidung WHERE MAQTBD = @maqtbd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtbd", SqlDbType.VarChar).Value = boiduongInfo.MaQTBD;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = boiduongInfo.NgayBatDau;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = boiduongInfo.NgayKetThuc;
            cmd.Parameters.Add("@noiBD", SqlDbType.NVarChar).Value = boiduongInfo.NoiBoiDUong;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = boiduongInfo.NoiDungBoiDUong;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Xoa_QuaTrinhBoiDuong        
        
        public void Xoa_QuaTrinhBoiDuong(String MaQTBD)
        {           

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_BOIDUONG where MAQTBD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTBD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhBoiDuongNV

        public void Xoa_QuaTrinhBoiDuongNV(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_BOIDUONG where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


    }
}
