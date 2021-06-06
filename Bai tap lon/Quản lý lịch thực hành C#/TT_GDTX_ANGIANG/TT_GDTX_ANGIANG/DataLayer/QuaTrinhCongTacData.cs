using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhCongTacData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuaTrinhCongTac()
        public DataTable lay_dsQuaTrinhCongTac()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_CONGTAC");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuaTrinhCongTac()
        public DataTable lay_dsQuaTrinhCongTac( string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTCT, MANHANVIEN, NGAYBD, NGAYKT, NOICT, CHUCDANH, CHUCVUCAONHAT, MANV From QT_CONGTAC , NHANVIEN WHERE NHANVIEN.MANV = QT_CONGTAC.MANHANVIEN AND QT_CONGTAC.MANHANVIEN = @ma");
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

        #region CapNhatQTCongTac()
        public void CapNhatQTCongTac(QuaTrinhCongTacInfo QTCongTacInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_CONGTAC SET NGAYBD =@ngayBD, NGAYKT =@ngayKT,NOICT = @noiCT,CHUCDANH=@chucDanh,CHUCVUCAONHAT=@chucvucaonhat WHERE MAQTCT = @maqtct";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtct", SqlDbType.VarChar).Value = QTCongTacInfo.MaQuaTrinhCongTac;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = QTCongTacInfo.TuNgay;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = QTCongTacInfo.DenNgay;
            cmd.Parameters.Add("@noiCT", SqlDbType.NVarChar).Value = QTCongTacInfo.NoiCongTac;
            cmd.Parameters.Add("@chucDanh", SqlDbType.NVarChar).Value = QTCongTacInfo.ChucDanh;
            cmd.Parameters.Add("@chucvucaonhat", SqlDbType.NVarChar).Value = QTCongTacInfo.ChucVuCaoNhat;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhCongTac

        public void Xoa_QuaTrinhCongTac(String MaQTCT)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_CONGTAC where MAQTCT = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTCT;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhCongTacNV

        public void Xoa_QuaTrinhCongTacNV(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_CONGTAC where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
