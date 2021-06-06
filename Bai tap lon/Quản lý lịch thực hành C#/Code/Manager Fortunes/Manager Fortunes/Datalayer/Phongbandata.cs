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
   public class Phongbandata
    {
        OleDbCommand sqlCommand;
        DataService m_DanhmucTS = new DataService();
        public DataTable DanhSachPhongBan()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN ");
            m_DanhmucTS.Load(cmd);
            return m_DanhmucTS;
        }
        public DataTable MaPhongBan(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN WHERE MAPHONGBAN=@id ");

            cmd.Parameters.Add("id", OleDbType.Integer).Value = id;
            return m_DanhmucTS;

        }
       public DataTable MaDiaDiem(String id)
       {
           OleDbCommand cmd = new OleDbCommand("SELECT * FROM DIADIEM WHERE MADIADIEM=@id ");
           cmd.Parameters.Add("id", OleDbType.Integer).Value = id;
           return m_DanhmucTS;

       }

        public DataTable TimTheoMa(String makh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN WHERE MAPHONGBAN LIKE N'%" + makh + "%'");
            //cmd.Parameters.Add("ten", OleDbType.VarChar).Value = diachi;
            m_DanhmucTS.Load(cmd);

            return m_DanhmucTS;
        }
        public DataTable TimTheoTen(String tenkh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN WHERE TENPHONGBAN LIKE N'%" + tenkh + "%'");
            //cmd.Parameters.Add("maloaiphong", OleDbType.VarChar).Value = maloaiphong;
            m_DanhmucTS.Load(cmd);

            return m_DanhmucTS;
        }
       //public void SuaThongTinPhongBan(PhongbanObject phongbanObj)
       //{
       //    sqlCommand = new OleDbCommand();
       //    sqlCommand.CommandText = "UPDATE PHONGBAN SET MADIADIEM = @madiadiem, MAPHONGBAN = @maphongban, TENPHONGBAN = @tenphongban, SODIENTHOAI = @sodienthoai"
       //          + " WHERE  MAPHONGBAN = @maphongban;";
       //    sqlCommand.Parameters.Add("@madiadiem", SqlDbType.NChar, 10).Value = phongbanObj.Madiadiem;
       //    sqlCommand.Parameters.Add("@maphongban", SqlDbType.NChar, 10).Value = phongbanObj.Maphongban;
       //    sqlCommand.Parameters.Add("@tenphongban", SqlDbType.NVarChar, 100).Value = phongbanObj.Tenphongban;
       //    sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.NChar, 12).Value = phongbanObj.Sodienthoai;
       //    sqlCommand.Parameters.Add("@mahangsx", SqlDbType.VarChar, 6).Value = phongbanObj.HangSX.MaHangSX;
       //    sqlCommand.Parameters.Add("@ngaysx", SqlDbType.DateTime).Value = phongbanObj.NgaySanXuat;
       //    sqlCommand.Parameters.Add("@madvt", SqlDbType.VarChar, 2).Value = phongbanObj.DonViTinh.MaDonViTinh;
       //    sqlCommand.Parameters.Add("@mancc", SqlDbType.VarChar, 6).Value = phongbanObj.NhaCungCap.MaNhaCC;
       //    sqlCommand.Parameters.Add("@ngaynhap", SqlDbType.DateTime).Value = phongbanObj.NgayNhap;
       //    sqlCommand.Parameters.Add("@dongianhap", SqlDbType.Int).Value = phongbanObj.DonGiaNhap;
       //    sqlCommand.Parameters.Add("@dongiaban", SqlDbType.Int).Value = phongbanObj.DonGiaBan;
       //    sqlCommand.Parameters.Add("@soluonggiam", SqlDbType.Int).Value = phongbanObj.SoLuongGiam;
       //    sqlCommand.Parameters.Add("@tylegiam", SqlDbType.Int).Value = phongbanObj.TyLeGiam;
       //    sqlCommand.Parameters.Add("@mathoigianbaohanh", SqlDbType.VarChar, 6).Value = phongbanObj.ThoiGianBaoHanh.MaThoiGianBaoHanh;
       //    sqlCommand.Parameters.Add("@manoibaohanh", SqlDbType.VarChar, 6).Value = phongbanObj.NoiBaoHanh.MaNoiBaoHanh;
       //    sqlCommand.Parameters.Add("@ghichu", SqlDbType.NText).Value = phongbanObj.GhiChu;
       //    m_DanhmucTS.Load(sqlCommand);
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
