using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class LuongNhanVienData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsLuongNhanVien()
        public DataTable lay_dsLuongNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From LUONGNHANVIEN ");
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsLuongNhanVienListLuong()
        public DataTable lay_dsLuongNhanVienListLuong()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select NHANVIEN.MANV,NHANVIEN.HOTEN,NHANVIEN.NGAYSINH,NHANVIEN.CMND,LUONGNHANVIEN.LUONG,LUONGNHANVIEN.TRUCACKHOAN,LUONGNHANVIEN.LUONGCONLAI,LUONGNHANVIEN.DANGPHI,LUONGNHANVIEN.LUONGTHUCLANH,LUONGNHANVIEN.GIAOVIEN,LUONGNHANVIEN.NVVANPHONG,LUONGNHANVIEN.MALNV From LUONGNHANVIEN,NHANVIEN WHERE LUONGNHANVIEN.MANHANVIEN=NHANVIEN.MANV AND LUONGNHANVIEN.DANHDAU='1'");
            Service.Load(cmd);
            return Service;
        }
         #endregion

        #region lay_dsLuongNhanVien_total
        
       
        internal DataTable lay_dsLuongNhanVien_total()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From LUONGNHANVIEN");
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsLuongNhanVienDS


        internal DataTable lay_dsLuongNhanVienDS(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MALNV From LUONGNHANVIEN WHERE MANHANVIEN=@ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsLuongNhanVienMaNV

        internal DataTable lay_dsLuongNhanVienMaNV(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MANHANVIEN From LUONGNHANVIEN WHERE  MALNV=@ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsLuongNhanVienDSxoa
        internal DataTable lay_dsLuongNhanVienDSxoa(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select * From LUONGNHANVIEN WHERE MANHANVIEN=@ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsLuongNhanVienDS


        public DataTable lay_dsLuongNhanVienDS1(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select * From LUONGNHANVIEN WHERE MALNV=@ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsLuongNhanVien()//xem lai
        public DataTable lay_dsLuongNhanVien(String ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MALNV, MANHANVIEN,TENNGACH,GIAOVIEN,CHONGV,CHONNVVP, CHONTHUVIEC, NVVANPHONG, NGAYBD, NGAYKT,BACLUONG, HESOLUONG,LUONGCOBAN,HSPCCHUCVU, TRUCACKHOAN, LUONG, LUONGCONLAI, DANGPHI, LUONGTHUCLANH, MANV ,CHON2NAM,CHON3NAM From LUONGNHANVIEN , NHANVIEN WHERE NHANVIEN.MANV = LUONGNHANVIEN.MANHANVIEN  AND LUONGNHANVIEN.MANHANVIEN = @ma");
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

        #region CapNhatLuongNhanVien()
        public void CapNhatLuongNhanVien(LươngNhanVienInfo luongNV_Info)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  LUONGNHANVIEN SET TENNGACH =@tenngach, BACLUONG = @bacluong, HESOLUONG =@hesoluong, LUONGCOBAN =@luongcoban,NGAYBD =@ngayBD, NGAYKT =@ngayKT, HSPCCHUCVU = @hspcchucvu, LUONG =@luong, TRUCACKHOAN =@trucackhoan, LUONGCONLAI =@luongconlai, DANGPHI =@dangphi, LUONGTHUCLANH =@luongthuclanh, GIAOVIEN =@giaovien, NVVANPHONG =@nvvanphong, CHONGV =@chongv, CHONNVVP =@chonnvvp, CHONTHUVIEC =@chonthuviec ,CHON2NAM=@chon2nam,CHON3NAM=@chon3nam WHERE MALNV = @malnv";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@malnv", SqlDbType.VarChar).Value = luongNV_Info.MaLuong;
            cmd.Parameters.Add("@tenngach", SqlDbType.NVarChar).Value = luongNV_Info.TenNgach;
            cmd.Parameters.Add("@bacluong", SqlDbType.Int).Value = luongNV_Info.BacLuong;
            cmd.Parameters.Add("@hesoluong", SqlDbType.Float).Value = luongNV_Info.HeSoLuong;
            cmd.Parameters.Add("@luongcoban", SqlDbType.Float).Value = luongNV_Info.LuongCoBan;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = luongNV_Info.NgayBatDau;
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = luongNV_Info.NgayKetThuc;
            cmd.Parameters.Add("@hspcchucvu", SqlDbType.Float).Value = luongNV_Info.HeSoPCChucVu;
            cmd.Parameters.Add("@luong", SqlDbType.Float).Value = luongNV_Info.Luong;
            cmd.Parameters.Add("@trucackhoan", SqlDbType.Float).Value = luongNV_Info.TruCacKhoan;
            cmd.Parameters.Add("@luongconlai", SqlDbType.Float).Value = luongNV_Info.LuongConLai;
            cmd.Parameters.Add("@dangphi", SqlDbType.Float).Value = luongNV_Info.DangPhi;
            cmd.Parameters.Add("@luongthuclanh", SqlDbType.Float).Value = luongNV_Info.LuongThucLanh;
            cmd.Parameters.Add("@giaovien", SqlDbType.Float).Value = luongNV_Info.GiaoVien;
            cmd.Parameters.Add("@nvvanphong", SqlDbType.Float).Value = luongNV_Info.NhanVienVanPhong;
            cmd.Parameters.Add("@chongv", SqlDbType.Int).Value = luongNV_Info.ChonGiaoVien;
            cmd.Parameters.Add("@chonnvvp", SqlDbType.Int).Value = luongNV_Info.ChonNhanVienVanPhong;
            cmd.Parameters.Add("@chonthuviec", SqlDbType.Int).Value = luongNV_Info.ChonThuViec;
            cmd.Parameters.Add("@chon2nam", SqlDbType.Int).Value = luongNV_Info.Chon2Nam;
            cmd.Parameters.Add("@chon3nam", SqlDbType.Int).Value = luongNV_Info.Chon3Nam;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region CapNhatLuongNhanVienDanhDau()
        public void CapNhatLuongNhanVienDanhDau(int danhdau, string maL)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE LUONGNHANVIEN SET DANHDAU=@danhdau WHERE MALNV = @malnv";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@malnv", SqlDbType.VarChar).Value = maL;
            cmd.Parameters.Add("@danhdau", SqlDbType.Int).Value = danhdau;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_Luong

        public void Xoa_Luong(String MaQTHL)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from LUONGNHANVIEN where MALNV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTHL;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_Luong_NhanVien

        public void Xoa_Luong_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from LUONGNHANVIEN where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
