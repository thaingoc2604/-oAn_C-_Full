using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhCongTacNuocNgoaiData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuaTrinhCongTacNuocNgoai()
        public DataTable lay_dsQuaTrinhCongTacNuocNgoai()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_CONGTACNUOCNGOAI");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuaTrinhCongTacNuocNgoai()
        public DataTable lay_dsQuaTrinhCongTacNuocNgoai(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTCTNN, MANHANVIEN, NGAYBD, NGAYKT, NUOCCONGTAC, TENCOQUAN, MUCDICH, MANV From QT_CONGTACNUOCNGOAI , NHANVIEN WHERE NHANVIEN.MANV = QT_CONGTACNUOCNGOAI.MANHANVIEN AND QT_CONGTACNUOCNGOAI.MANHANVIEN = @ma");
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

        #region CapNhatQuaTrinhCongTacNuocNgoai()
        public void CapNhatQuaTrinhCongTacNuocNgoai(QuaTrinhCongTacNuocNgoaiInfo nuocngoaiInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_CONGTACNUOCNGOAI SET NGAYBD =@ngayBD, NGAYKT =@ngayKT, NUOCCONGTAC =@noiBD, TENCOQUAN = @noidung, MUCDICH = @mucdich WHERE MAQTCTNN = @maqtbd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtbd", SqlDbType.VarChar).Value = nuocngoaiInfo.MaQuaTrinhCongTacNuocNgoai;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = nuocngoaiInfo.TuNgay;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = nuocngoaiInfo.DenNgay;
            cmd.Parameters.Add("@noiBD", SqlDbType.NVarChar).Value = nuocngoaiInfo.NuocCongTac;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = nuocngoaiInfo.TenCoQuan;
            cmd.Parameters.Add("@mucdich", SqlDbType.NVarChar).Value = nuocngoaiInfo.MucDich;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhCongTacNuocNgoai

        public void Xoa_QuaTrinhCongTacNuocNgoai(String MaQTCTNN)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_CONGTACNUOCNGOAI where MAQTCTNN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTCTNN;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhCongTacNuocNgoai_NhanVien

        public void Xoa_QuaTrinhCongTacNuocNgoai_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_CONGTACNUOCNGOAI where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
