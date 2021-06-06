using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class DanhGiaCBCCData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsDanhGiaCBCC()
        public DataTable lay_dsDanhGiaCBCC()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From DANHGIACBCC");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsDanhGiaCBCC()
        public DataTable lay_dsDanhGiaCBCC(String ma)
        {

            if (Service == null)
                Service = new DataService();
            String sql = ("Select MADG, MANHANVIEN, DOTDG, NGAYDG, XEPLOAISUCKHOE, XEPLOAIDAODUC,XEPLOAITDCHUYENMON, XEPLOAICHUNG, NHANXET, MANV From DANHGIACBCC , NHANVIEN WHERE NHANVIEN.MANV = DANHGIACBCC.MANHANVIEN AND DANHGIACBCC.MANHANVIEN = @ma");
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

        #region CapNhatDanhGiaCanBoCongChuc()
        public void CapNhatDanhGiaCanBoCongChuc(DanhGiaCBCCInfo danhgiaInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  DANHGIACBCC SET DOTDG =@dotdg, NGAYDG =@ngaydg, XEPLOAISUCKHOE =@suckhoe, XEPLOAIDAODUC = @daoduc, XEPLOAITDCHUYENMON =@trinhdochuyenmon, XEPLOAICHUNG =@xeploaichu, NHANXET =@nhanxet WHERE MADG = @danhgia";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@danhgia", SqlDbType.VarChar).Value = danhgiaInfo.MaDanhGiaCBCC;
            cmd.Parameters.Add("@dotdg", SqlDbType.NVarChar).Value = danhgiaInfo.DotDanhGia;
            cmd.Parameters.Add("@ngaydg", SqlDbType.DateTime).Value = danhgiaInfo.NgayDanhGia;
            cmd.Parameters.Add("@suckhoe", SqlDbType.NVarChar).Value = danhgiaInfo.XepLoaiSucKhoe;
            cmd.Parameters.Add("@daoduc", SqlDbType.NVarChar).Value = danhgiaInfo.XepLoaiDaoDuc;
            cmd.Parameters.Add("@trinhdochuyenmon", SqlDbType.NVarChar).Value = danhgiaInfo.XepLoaiTDChuyenMon;
            cmd.Parameters.Add("@xeploaichu", SqlDbType.NVarChar).Value = danhgiaInfo.XepLoaiChung;
            cmd.Parameters.Add("@nhanxet", SqlDbType.NVarChar).Value = danhgiaInfo.NhanXet;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_DanhGia_CBCC

        public void Xoa_DanhGia_CBCC(String MaDG)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from DANHGIACBCC where MADG = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaDG;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_DanhGia_CBCC_NhanVien

        public void Xoa_DanhGia_CBCC_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from DANHGIACBCC where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
