using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuaTrinhDaoTaoData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuaTrinhDaoTao()
        public DataTable lay_dsQuaTrinhDaoTao()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_DAOTAO");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuaTrinhDaoTao()
        public DataTable lay_dsQuaTrinhDaoTao(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTDT, MANHANVIEN, NAMNHAPHOC,TOTNGHIEPNAM,  NOIDT, NGANHDT,HINHTHUCDT, BANGDUOCCAP, MANV From QT_DAOTAO , NHANVIEN WHERE NHANVIEN.MANV = QT_DAOTAO.MANHANVIEN AND QT_DAOTAO.MANHANVIEN = @ma");
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

        #region CapNhatQuaTrinhDaoTao()
        public void CapNhatQuaTrinhDaoTao(QuaTrinhDaoTaoInfo daotaoInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_DAOTAO SET NAMNHAPHOC =@namnhaphoc, TOTNGHIEPNAM= @namtotnghiep,  NOIDT = @noiDT, NGANHDT =@nganhDT, HINHTHUCDT =@hinhthucDT, BANGDUOCCAP =@bangduoccap WHERE MAQTDT = @maqtdt";//NAMTOTNGHIEP =@namtotnghiep,
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtdt", SqlDbType.VarChar).Value = daotaoInfo.MaQuaTrinhDaoTao;
            cmd.Parameters.Add("@namnhaphoc", SqlDbType.NVarChar).Value = daotaoInfo.NamNhapHoc;
            cmd.Parameters.Add("@namtotnghiep", SqlDbType.NVarChar).Value = daotaoInfo.NamTotNghiep;
            cmd.Parameters.Add("@noiDT", SqlDbType.NVarChar).Value = daotaoInfo.NoiDaoTao;
            cmd.Parameters.Add("@nganhDT", SqlDbType.NVarChar).Value = daotaoInfo.NganhDaoTao;
            cmd.Parameters.Add("@hinhthucDT", SqlDbType.NVarChar).Value = daotaoInfo.HinhThucDaoTao;
            cmd.Parameters.Add("@bangduoccap", SqlDbType.NVarChar).Value = daotaoInfo.BangDuocCap;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Xoa_QuaTrinhDaoTaoNV        
        
        public void Xoa_QuaTrinhDaoTaoNV(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_DAOTAO where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhDaoTao
        public void Xoa_QTDaoTao(String MaQTDT)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_DAOTAO where MAQTDT = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTDT;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
