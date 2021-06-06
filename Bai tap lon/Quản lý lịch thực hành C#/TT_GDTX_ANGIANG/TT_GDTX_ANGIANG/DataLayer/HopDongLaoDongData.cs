using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class HopDongLaoDongData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsHopDongLaoDong()
        public DataTable lay_dsHopDongLaoDong(String ma)
        {

            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAHDLD, MANHANVIEN,LOAIHDLD, TUNGAY, DENNGAY, DIADIEMLAMVIEC, CHUCDANHCHUYENMON, NHIEMVU, THOIGIANLAMVIEC, TRANGBIPHUONGTIEN, NGACH, BAC, HESOLUONG, PHUCAP, NGUOIKY, HOPDONGLAODONG.CHUCVU, NGAYKY,BHYT, BHXH, MANV From HOPDONGLAODONG , NHANVIEN WHERE NHANVIEN.MANV = HOPDONGLAODONG.MANHANVIEN AND HOPDONGLAODONG.MANHANVIEN = @ma");//CHUCVU, BHYT, BHXH
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsHopDongLaoDong()
        public DataTable lay_dsHopDongLaoDong()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HOPDONGLAODONG");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsHopDongDS


        internal DataTable lay_dsHopDongDS(string ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAHDLD From HOPDONGLAODONG WHERE MANHANVIEN=@ma");
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

        #region CapNhatHopDongLaoDong()
        public void CapNhatHopDongLaoDong(HopDongLaoDongInfo hopdongLD_Info)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  HOPDONGLAODONG SET LOAIHDLD =@loaihd, TUNGAY = @tungay, DENNGAY =@denngay, DIADIEMLAMVIEC =@diadiemlamviec,CHUCDANHCHUYENMON =@chucdanhchuyenmon, NHIEMVU =@nhiemvu, THOIGIANLAMVIEC = @thoigianlamviec, TRANGBIPHUONGTIEN =@trangbiphuongtien, NGACH =@ngach, BAC =@bac, HESOLUONG =@hesoluong, PHUCAP =@phucap, NGUOIKY =@nguoiky, NGAYKY =@ngayky, CHUCVU =@chucvunguoiky, BHYT =@bhyt, BHXH =@bhxh WHERE MAHDLD = @mahdld";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@mahdld", SqlDbType.VarChar).Value = hopdongLD_Info.MaHopDongLaoDong;
            cmd.Parameters.Add("@loaihd", SqlDbType.NVarChar).Value = hopdongLD_Info.LoaiHopDong;
            cmd.Parameters.Add("@tungay", SqlDbType.DateTime).Value = hopdongLD_Info.TuNgay;
            cmd.Parameters.Add("@denngay", SqlDbType.DateTime).Value = hopdongLD_Info.DenNgay;
            cmd.Parameters.Add("@diadiemlamviec", SqlDbType.NVarChar).Value = hopdongLD_Info.DiaDiemLamViec;
            cmd.Parameters.Add("@chucdanhchuyenmon", SqlDbType.NVarChar).Value = hopdongLD_Info.ChucDanhChuyenMon;
            cmd.Parameters.Add("@nhiemvu", SqlDbType.NVarChar).Value = hopdongLD_Info.NhiemVu;
            cmd.Parameters.Add("@thoigianlamviec", SqlDbType.NVarChar).Value = hopdongLD_Info.ThoiGianLamViec;
            cmd.Parameters.Add("@trangbiphuongtien", SqlDbType.NVarChar).Value = hopdongLD_Info.TrangBiPhuongTien;
            cmd.Parameters.Add("@ngach", SqlDbType.NVarChar).Value = hopdongLD_Info.Ngach;
            cmd.Parameters.Add("@bac", SqlDbType.Int).Value = hopdongLD_Info.Bac;
            cmd.Parameters.Add("@hesoluong", SqlDbType.Float).Value = hopdongLD_Info.HeSoLuong;
            cmd.Parameters.Add("@phucap", SqlDbType.NVarChar).Value = hopdongLD_Info.PhuCap;
            cmd.Parameters.Add("@nguoiky", SqlDbType.NVarChar).Value = hopdongLD_Info.NguoiKy;
            cmd.Parameters.Add("@chucvunguoiky", SqlDbType.NVarChar).Value = hopdongLD_Info.ChucVu;
            cmd.Parameters.Add("@ngayky", SqlDbType.DateTime).Value = hopdongLD_Info.NgayKy;
            cmd.Parameters.Add("@bhyt", SqlDbType.Int).Value = hopdongLD_Info.ChonBHYT;
            cmd.Parameters.Add("@bhxh", SqlDbType.Int).Value = hopdongLD_Info.ChonBHXH;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion


        #region Xoa_HopDongLaoDong

        public void Xoa_HopDongLaoDong(String MaHDLD)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from HOPDONGLAODONG where MAHDLD = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaHDLD;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_HopDongLaoDong_NhanVien

        public void Xoa_HopDongLaoDong_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from HOPDONGLAODONG where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
