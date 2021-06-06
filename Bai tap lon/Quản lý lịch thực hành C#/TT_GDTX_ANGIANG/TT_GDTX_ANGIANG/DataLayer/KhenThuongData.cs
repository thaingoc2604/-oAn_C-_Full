using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class KhenThuongData
    {

        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsKhenThuong()
        public DataTable lay_dsKhenThuong(String ma)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("Select MAQTKT, MANHANVIEN, SOQUYETDINH, NGAYQUYETDINH, COQUANKT, HINHTHUC, LYDO, NGUOIKY, GHICHU, MANV From QT_KHENTHUONG , NHANVIEN WHERE NHANVIEN.MANV = QT_KHENTHUONG.MANHANVIEN AND QT_KHENTHUONG.MANHANVIEN = @ma");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_dsKhenThuong()
        public DataTable lay_dsKhenThuong()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From QT_KHENTHUONG");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region CapNhatQTKhenThuong()
        public void CapNhatQTKhenThuong(KhenThuongInfo thuongInfo)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "UPDATE  QT_KHENTHUONG SET SOQUYETDINH=@soQD,NGAYQUYETDINH = @ngayQD, COQUANKT =@coquankt, HINHTHUC=@hinhthuc, LYDO =@lydo, NGUOIKY=@nguoiky, GHICHU=@ghichu WHERE MAQTKT = @maqtkt";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("@maqtkt", SqlDbType.VarChar).Value = thuongInfo.MaQuaTrinhKhenThuong;
            cmd.Parameters.Add("@soQD", SqlDbType.NVarChar).Value = thuongInfo.SoQuyetDinh.MaSoQuyetDinh;
            cmd.Parameters.Add("@ngayQD", SqlDbType.DateTime).Value = thuongInfo.NgayQuyetDinh;
            cmd.Parameters.Add("@coquankt", SqlDbType.NVarChar).Value = thuongInfo.CoQuanKhenThuong;
            cmd.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = thuongInfo.HinhThuc;
            cmd.Parameters.Add("@lydo", SqlDbType.Text).Value = thuongInfo.LyDo;
            cmd.Parameters.Add("@nguoiky", SqlDbType.NVarChar).Value = thuongInfo.NguoiKy;
            cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = thuongInfo.GhiChu;
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

        #region Xoa_QuaTrinhKhenThuongNV

        public void Xoa_QuaTrinhKhenThuongNV(String MaNV)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_KHENTHUONG where MANHANVIEN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaNV;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region Xoa_QuaTrinhKhenThuong

        public void Xoa_QuaTrinhKhenThuong(String MaQTKT)
        {

            if (Service == null)
                Service = new DataService();
            String sql = "delete from QT_KHENTHUONG where MAQTKT = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = MaQTKT;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion
    }
}
