using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;

using System.Drawing;
using System.Data.SqlClient;
namespace TT_GDTX_ANGIANG.DataLayer
{
    public class HeSoLuongNhanVienData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsHeSoLuongNhanVien()
        public DataTable lay_dsHeSoLuongNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HESOLUONGNHANVIEN");
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

        #region lay_HeSoLuong
        public string lay_HeSoLuong(string tenNgach, string tenBac)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "Select HSLUONGNHANVIEN From HESOLUONGNHANVIEN Where TENNGACHLUONG= @ngach and TENBACLUONG = @bac ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ngach", SqlDbType.VarChar).Value = tenNgach;
            cmd.Parameters.Add("bac", SqlDbType.VarChar).Value = tenBac;
            cmd.CommandText = sql;
            Service.Load(cmd); string thongbao = "0";
            try
            {
                if (Convert.ToString(this.Service.Rows[0]["HSLUONGNHANVIEN"]) == null)
                {

                    return thongbao;
                }
                return Convert.ToString(this.Service.Rows[0]["HSLUONGNHANVIEN"]);
            }
            catch
            {
                return thongbao;
            }
        }
        #endregion
        #region CapNhatHeSoLuongNhanVien()
        public void CapNhatHeSoLuongNhanVien(HeSoLuongNhanVienInfo hsluongNVInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  HESOLUONGNHANVIEN SET TENNGACHLUONG =@tenngachluong, TENBACLUONG =@tenbacluong, HSLUONGNHANVIEN = @hsluongnhanvien WHERE MAHSLUONG = @mahsluong";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@mahsluong", SqlDbType.VarChar).Value = hsluongNVInfo.MaHeSoLuong;
            cmd.Parameters.Add("@tenngachluong", SqlDbType.VarChar).Value = hsluongNVInfo.TenNgach.MaNgach;
            cmd.Parameters.Add("@tenbacluong", SqlDbType.VarChar).Value = hsluongNVInfo.TenBac.MaBac;
            cmd.Parameters.Add("@hsluongnhanvien", SqlDbType.Float).Value = hsluongNVInfo.HeSoLuong;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
         #endregion


        #region XoaHeSoLuongNhanVien

        public void XoaHeSoLuongNhanVien(String MaHSLUONG)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from HESOLUONGNHANVIEN where MAHSLUONG = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaHSLUONG;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
