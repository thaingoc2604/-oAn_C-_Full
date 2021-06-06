using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class KyLuatData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsKyLuat()
        public DataTable lay_dsKyLuat()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_KYLUAT");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsKyLuat()
        public DataTable lay_dsKyLuat(String ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTKL, MANHANVIEN, SOQUYETDINH, NGAYKL, COQUANKL, HINHTHUCKL, LYDOKL, NGUOIKY, GHICHU, MANV From QT_KYLUAT , NHANVIEN WHERE NHANVIEN.MANV = QT_KYLUAT.MANHANVIEN AND QT_KYLUAT.MANHANVIEN = @ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region CapNhatQTKyLuat()
        public void CapNhatQTKyLuat(KyLuatInfo kLuatInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_KYLUAT SET SOQUYETDINH=@soQD,NGAYKL = @ngayQD, COQUANKL =@coquankt, HINHTHUCKL =@hinhthuc, LYDOKL =@lydo, NGUOIKY=@nguoiky, GHICHU=@ghichu WHERE MAQTKL = @maqtkt";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtkt", SqlDbType.VarChar).Value = kLuatInfo.MaQuaTrinhKyLuat;
            cmd.Parameters.Add("@soQD", SqlDbType.NVarChar).Value = kLuatInfo.SoQuyetDinh.MaSoQuyetDinh;
            cmd.Parameters.Add("@ngayQD", SqlDbType.DateTime).Value = kLuatInfo.NgayQuyetDinh;
            cmd.Parameters.Add("@coquankt", SqlDbType.NVarChar).Value = kLuatInfo.CoQuanKyLuat;
            cmd.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = kLuatInfo.HinhThuc;
            cmd.Parameters.Add("@lydo", SqlDbType.Text).Value = kLuatInfo.LyDo;
            cmd.Parameters.Add("@nguoiky", SqlDbType.NVarChar).Value = kLuatInfo.NguoiKy;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = kLuatInfo.GhiChu;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Update()
        public bool Update()
        {
            return Service.Update();
        }
        #endregion

        #region Xoa_KyLuat

        public void Xoa_KyLuat(String MaKL)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_KYLUAT where MAQTKL = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaKL;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_KyLuat_NhanVien

        public void Xoa_KyLuat_NhanVien(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_KYLUAT where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
