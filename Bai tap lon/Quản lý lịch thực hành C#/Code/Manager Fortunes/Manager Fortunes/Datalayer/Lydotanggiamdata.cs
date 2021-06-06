using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTS.BusinessObject;

namespace Manager_Fortunes.Datalayer
{
   public class Lydotanggiamdata
    {
        SqlCommand sqlCommand;
        DataService m_DanhmucTS = new DataService();
        public DataTable DanhSachLyDoTangGiam()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LYDOTANGGIAM ");
            m_DanhmucTS.Load(cmd);
            return m_DanhmucTS;
        }
        public DataTable MaLyDoTanGiam(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LYDOTANGGIAM WHERE MALYDOTANGGIAM=@id ");

            cmd.Parameters.Add("id", OleDbType.Integer).Value = id;
            return m_DanhmucTS;

        }

        public DataTable TimTheoMa(String makh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LYDOTANGGIAM WHERE MALYDOTANGGIAM LIKE N'%" + makh + "%'");
            //cmd.Parameters.Add("ten", OleDbType.VarChar).Value = diachi;
            m_DanhmucTS.Load(cmd);

            return m_DanhmucTS;
        }
        public DataTable TimTheoTen(String tenkh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LYDOTANGGIAM WHERE TENLYDOTANGGIAM LIKE N'%" + tenkh + "%'");
            //cmd.Parameters.Add("maloaiphong", OleDbType.VarChar).Value = maloaiphong;
            m_DanhmucTS.Load(cmd);

            return m_DanhmucTS;
        }
        //public void SuaThongTinTaiSan(TaisanObject taisanObj)
        //{
        //    sqlCommand = new SqlCommand();
        //    sqlCommand.CommandText = "UPDATE HANG_HOA SET TEN_HH = @tenhh, MODEL = @model, SO_SERIAL = @soserial, MA_HANG_SX = @mahangsx,"
        //    + " NGAY_SX = @ngaysx, MA_DVT = @madvt, MA_NCC = @mancc, NGAY_NHAP = @ngaynhap, DON_GIA_NHAP = @dongianhap,"
        //    + " DON_GIA_BAN = @dongiaban, SO_LUONG_GIAM = @soluonggiam, TY_LE_GIAM = @tylegiam, MA_THOI_GIAN_BAO_HANH = @mathoigianbaohanh,"
        //    + " MA_NOI_BAO_HANH = @manoibaohanh, GHI_CHU = @ghichu"
        //    + " WHERE  MA_HH = @mahh;";
        //    sqlCommand.Parameters.Add("@s", SqlDbType.VarChar, 6).Value = taisanObj.m
        //    sqlCommand.Parameters.Add("@tenhh", SqlDbType.NVarChar, 50).Value = taisanObj.TenHang;
        //    sqlCommand.Parameters.Add("@model", SqlDbType.NText).Value = taisanObj.Model;
        //    sqlCommand.Parameters.Add("@soserial", SqlDbType.NText).Value = taisanObj.SoSerial;
        //    sqlCommand.Parameters.Add("@mahangsx", SqlDbType.VarChar, 6).Value = taisanObj.HangSX.MaHangSX;
        //    sqlCommand.Parameters.Add("@ngaysx", SqlDbType.DateTime).Value = taisanObj.NgaySanXuat;
        //    sqlCommand.Parameters.Add("@madvt", SqlDbType.VarChar, 2).Value = taisanObj.DonViTinh.MaDonViTinh;
        //    sqlCommand.Parameters.Add("@mancc", SqlDbType.VarChar, 6).Value = taisanObj.NhaCungCap.MaNhaCC;
        //    sqlCommand.Parameters.Add("@ngaynhap", SqlDbType.DateTime).Value = taisanObj.NgayNhap;
        //    sqlCommand.Parameters.Add("@dongianhap", SqlDbType.Int).Value = taisanObj.DonGiaNhap;
        //    sqlCommand.Parameters.Add("@dongiaban", SqlDbType.Int).Value = taisanObj.DonGiaBan;
        //    sqlCommand.Parameters.Add("@soluonggiam", SqlDbType.Int).Value = taisanObj.SoLuongGiam;
        //    sqlCommand.Parameters.Add("@tylegiam", SqlDbType.Int).Value = taisanObj.TyLeGiam;
        //    sqlCommand.Parameters.Add("@mathoigianbaohanh", SqlDbType.VarChar, 6).Value = taisanObj.ThoiGianBaoHanh.MaThoiGianBaoHanh;
        //    sqlCommand.Parameters.Add("@manoibaohanh", SqlDbType.VarChar, 6).Value = taisanObj.NoiBaoHanh.MaNoiBaoHanh;
        //    sqlCommand.Parameters.Add("@ghichu", SqlDbType.NText).Value = taisanObj.GhiChu;
        //    m_DanhmucTS.Load(m_DanhmucTS);
        //}
        public bool Save()
        {
            return m_DanhmucTS.ExecuteNoneQuery() > 0;
        }
        public DataRow NewRow()
        {
            return m_DanhmucTS.NewRow();
        }
        public void Add(DataRow row)
        {
            m_DanhmucTS.Rows.Add(row);
        }
    }
}
