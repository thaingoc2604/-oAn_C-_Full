using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;


namespace TT_GDTX_ANGIANG.DataLayer
{
    public class HopDongLaoDong_ThoiViec_Data
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsHopDongLaoDong_ThoiViec()
        public DataTable lay_dsHopDongLaoDong_ThoiViec(String ma)
        {

            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAHD, MANHANVIEN,LOAIHD, TUNGAY, DENNGAY, DIADIEMLAMVIEC, CHUCDANHCHUYENMON, NHIEMVU, THOIGIANLAMVIEC, TRANGBIPHUONGTIEN, NGUOIKY, HOPDONGLAODONG_THOIVIEC.CHUCVU, NGAYKY, BHYT, BHXH, SOQDINH, NGAYQD, NGUOIKYTV, NGAYTV,LYDOTV, MANV From HOPDONGLAODONG_THOIVIEC , NHANVIEN WHERE NHANVIEN.MANV = HOPDONGLAODONG_THOIVIEC.MANHANVIEN AND HOPDONGLAODONG_THOIVIEC.MANHANVIEN = @ma");//CHUCVU, BHYT, BHXH
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsHopDongLaoDong_ThoiViec()
        public DataTable lay_dsHopDongLaoDong_ThoiViec()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HOPDONGLAODONG_THOIVIEC");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsHopDong_ThoiViecDS


        internal DataTable lay_dsHopDong_ThoiViecDS(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAHD From HOPDONGLAODONG_THOIVIEC WHERE MANHANVIEN=@ma");
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

        #region CapNhatHopDongLaoDong_ThoiViec()
        public void CapNhatHopDongLaoDong_ThoiViec(HopDongLaoDong_ThoiViec_Info hopdongLD_Info)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  HOPDONGLAODONG_THOIVIEC SET LOAIHD =@loaihd, TUNGAY = @tungay, DENNGAY =@denngay, DIADIEMLAMVIEC =@diadiemlamviec,CHUCDANHCHUYENMON =@chucdanhchuyenmon, NHIEMVU =@nhiemvu, THOIGIANLAMVIEC = @thoigianlamviec, TRANGBIPHUONGTIEN =@trangbiphuongtien,  NGUOIKY =@nguoiky, NGAYKY =@ngayky, CHUCVU =@chucvunguoiky, BHYT =@bhyt, BHXH =@bhxh, SOQDINH =@soquyetdinh, NGAYQD =@ngayquyetdinh, NGUOIKYTV =@nguoikythoiviec, NGAYTV =@ngaythoiviec, LYDOTV =@lydothoiviec WHERE MAHD = @mahd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = hopdongLD_Info.MaHopDongLaoDong;
            cmd.Parameters.Add("@loaihd", SqlDbType.NVarChar).Value = hopdongLD_Info.LoaiHopDong;
            cmd.Parameters.Add("@tungay", SqlDbType.DateTime).Value = hopdongLD_Info.TuNgay;
            cmd.Parameters.Add("@denngay", SqlDbType.DateTime).Value = hopdongLD_Info.DenNgay;
            cmd.Parameters.Add("@diadiemlamviec", SqlDbType.NVarChar).Value = hopdongLD_Info.DiaDiemLamViec;
            cmd.Parameters.Add("@chucdanhchuyenmon", SqlDbType.NVarChar).Value = hopdongLD_Info.ChucDanhChuyenMon;
            cmd.Parameters.Add("@nhiemvu", SqlDbType.NVarChar).Value = hopdongLD_Info.NhiemVu;
            cmd.Parameters.Add("@thoigianlamviec", SqlDbType.NVarChar).Value = hopdongLD_Info.ThoiGianLamViec;
            cmd.Parameters.Add("@trangbiphuongtien", SqlDbType.NVarChar).Value = hopdongLD_Info.TrangBiPhuongTien;
            cmd.Parameters.Add("@nguoiky", SqlDbType.NVarChar).Value = hopdongLD_Info.NguoiKy;
            cmd.Parameters.Add("@chucvunguoiky", SqlDbType.NVarChar).Value = hopdongLD_Info.ChucVu;
            cmd.Parameters.Add("@ngayky", SqlDbType.DateTime).Value = hopdongLD_Info.NgayKy;
            cmd.Parameters.Add("@bhyt", SqlDbType.Int).Value = hopdongLD_Info.ChonBHYT;
            cmd.Parameters.Add("@bhxh", SqlDbType.Int).Value = hopdongLD_Info.ChonBHXH;

            ////////////////
            cmd.Parameters.Add("@soquyetdinh", SqlDbType.NVarChar).Value = hopdongLD_Info.SoQuyetDinh;
            cmd.Parameters.Add("@ngayquyetdinh", SqlDbType.DateTime).Value = hopdongLD_Info.NgayQuyetDinh;
            cmd.Parameters.Add("@nguoikythoiviec", SqlDbType.NVarChar).Value = hopdongLD_Info.NguoiKyThoiViec;
            cmd.Parameters.Add("@ngaythoiviec", SqlDbType.DateTime).Value = hopdongLD_Info.NgayThoiViec;
            cmd.Parameters.Add("@lydothoiviec", SqlDbType.NVarChar).Value = hopdongLD_Info.LyDoTV;
            /////////////////////////
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Xoa_HopDongLaoDong_ThoiViec

        public void Xoa_HopDongLaoDong_ThoiViec(String MaHDLD)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from HOPDONGLAODONG_THOIVIEC where MAHD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaHDLD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_HopDongLaoDong_ThoiViec_NhanVien

        public void Xoa_HopDongLaoDong_ThoiViec_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from HOPDONGLAODONG_THOIVIEC where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region BENCHAMDUTHOPDONGLAODONG        
        
        #region Tim_MaNghiViec

        public DataTable Tim_MaNghiViec(String maNV)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  HOPDONGLAODONG_THOIVIEC Where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_MaNhanVien()
        public DataTable lay_MaNhanVien(String manv)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  HOPDONGLAODONG_THOIVIEC Where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = manv;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #endregion
    }
}
