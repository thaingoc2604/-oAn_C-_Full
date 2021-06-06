using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class QuanHeGiaDinhData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsQuanHeGiaDinh()
        public DataTable lay_dsQuanHeGiaDinh()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QUANHEGIADINH");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsQuanHeGiaDinh()
        public DataTable lay_dsQHGiaDinh(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQHGD, MANHANVIEN, MOIQH, QUANHEGIADINH.HOTEN, NAMSINH, QUANHEGIADINH.QUEQUAN,QUANHEGIADINH.NOIOHIENNAY,NGHENGHIEP,DONVICONGTAC,QUANHEGIADINH.CHUCVU From QUANHEGIADINH , NHANVIEN WHERE NHANVIEN.MANV = QUANHEGIADINH.MANHANVIEN AND QUANHEGIADINH.MANHANVIEN = @ma");
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

        #region Xoa_QuanHeGiaDinh

        public void Xoa_QuanHeGiaDinh(String MaQHGD)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QUANHEGIADINH where MAQHGD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQHGD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region CapNhatQHGiaDinh()
        public void CapNhatQHGiaDinh(QuanHeGiaDinhInfo QHGiaDinhInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QUANHEGIADINH SET MOIQH =@moiQH,HOTEN =@hoten,NAMSINH= @namsinh,QUEQUAN=@quequan,NOIOHIENNAY=@noiohiennay,NGHENGHIEP=@nghenghiep,DONVICONGTAC=@donvicongtac,CHUCVU=@chucvu WHERE MAQHGD = @maqhgd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqhgd", SqlDbType.VarChar).Value = QHGiaDinhInfo.MaQuanHeGiaDinh;
            cmd.Parameters.Add("@moiQH", SqlDbType.NVarChar).Value = QHGiaDinhInfo.MoiQuanHe;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = QHGiaDinhInfo.HoTen;
            cmd.Parameters.Add("@namsinh", SqlDbType.DateTime).Value = QHGiaDinhInfo.NamSinh;
            cmd.Parameters.Add("@quequan", SqlDbType.NVarChar).Value = QHGiaDinhInfo.QueQuan;
            cmd.Parameters.Add("@noiohiennay", SqlDbType.NVarChar).Value = QHGiaDinhInfo.NoiOHienNay;
            cmd.Parameters.Add("@nghenghiep", SqlDbType.NVarChar).Value = QHGiaDinhInfo.NgheNghiep;
            cmd.Parameters.Add("@donvicongtac", SqlDbType.NVarChar).Value = QHGiaDinhInfo.DonViCongTac;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = QHGiaDinhInfo.ChucVu;

            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuanHeGiaDinh_NhanVien

        public void Xoa_QuanHeGiaDinh_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QUANHEGIADINH where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
