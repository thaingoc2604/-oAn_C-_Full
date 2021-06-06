using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TT_GDTX_ANGIANG.BusinessObject;

namespace TT_GDTX_ANGIANG.DataLayer
{
    public class NhanVienData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsNhanVien()
        public DataTable lay_dsNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NHANVIEN");
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

        #region TimNV_NghiViec()
        public DataTable TimNV_NghiViec(string manv, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From NHANVIEN Where MANV = @nv and STATUS = @tt";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("nv", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion    

        #region DeleteList()
        public void DeleteList(String manv)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("delete  from NHANVIEN  where  MANV = @manv");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = manv;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region lay_dsNV_PH(string maPH)
        public DataTable lay_dsNV_PH(string maPH, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From NHANVIEN Where PHONGBAN = @ma and STATUS = @tt ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maPH;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;            
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion    

        #region lay_dsTinhLuongNhanVien
        public DataTable lay_dsTinhLuongNhanVien(int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  NHANVIEN Where STATUS = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = trangthai;
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
            String sql = "Select * From  NHANVIEN Where MANV = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = manv;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }

        #endregion


        #region Update_NhanVien()
        public void Update_NhanVien(string manv, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Update NHANVIEN Set STATUS = @tt Where MANV = @nv";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            cmd.Parameters.Add("nv", SqlDbType.VarChar).Value = manv;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion    

        #region XoaNhanVien        
        
        public void XoaNhanVien(String nv)
        {
            if (Service == null)
                Service = new DataService();
            String sql = ("delete  from NHANVIEN  where  MANV = @nv");
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("nv", SqlDbType.VarChar).Value = nv;
            cmd.CommandText = sql;
            Service.Load(cmd);
        }
        #endregion

        #region ThongKe_TatCaNhanVien()
        public DataTable ThongKe_TatCaNhanVien(int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,TINHTRANGHONNHAN,CMND,NGAYCAPCMND,NOICAPCMND,PHONGBAN,STATUS From NHANVIEN nv,PHONGBAN Where PHONGBAN=MAPB and STATUS = @tt  ";
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;


            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region ThongKe_NhanVienTheoPhongBan()
        public DataTable ThongKe_NhanVienTheoPhongBan(string cboPHONGBAN, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,GIOITINH,TINHTRANGHONNHAN,CMND,NGAYCAPCMND,NOICAPCMND,NOISINH,QUEQUAN,NOIVAODANG,TINHTRANGSUCKHOE,STATUS From NHANVIEN nv,PHONGBAN Where PHONGBAN=MAPB   and  PHONGBAN = @maphong and STATUS = @tt ";
            cmd.Parameters.Add("maphong", SqlDbType.VarChar).Value = cboPHONGBAN;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
            

            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion


        #region ThongKe_TatCaNhanVienTren40Tuoi()
        public DataTable ThongKe_TatCaNhanVienTren40Tuoi(int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,TINHTRANGHONNHAN,CMND,NGAYCAPCMND,NOICAPCMND,PHONGBAN,STATUS From NHANVIEN ,PHONGBAN, TRINHDOHOCVAN, TRINHDOTINHOC, TRINHDONGOAINGU, NGOAINGU Where (YEAR(GETDATE())-YEAR(NGAYSINH))>40 and PHONGBAN=MAPB and TD_HOCVANNV = MATDHV and TD_TINHOCNV=MATDTH and NGOAINGUCHINHNV = MANN and TD_NGOAINGUNV= MATDNN and STATUS = @tt  ";
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;
           

            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region ThongKe_NhanVienTren40TuoiTheoPhongBan()
        public DataTable ThongKe_NhanVienTren40TuoiTheoPhongBan(string cboPHONGBAN, int trangthai)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,GIOITINH,TINHTRANGHONNHAN,CMND,NGAYCAPCMND,NOICAPCMND,NOISINH,QUEQUAN,NOIVAODANG,TINHTRANGSUCKHOE,STATUS From NHANVIEN nv,PHONGBAN Where PHONGBAN=MAPB and (YEAR(GETDATE())-YEAR(NGAYSINH))>40  and  PHONGBAN = @maphong and STATUS = @tt ";
            cmd.Parameters.Add("maphong", SqlDbType.VarChar).Value = cboPHONGBAN;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;


           

            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion


        #region ThongKe_NhanVienMoiPhongBanTheoTrinhDoHocVan()
        public DataTable ThongKe_NhanVienMoiPhongBanTheoTrinhDoHocVan(string cboPHONGBAN, int trangthai, string cboChon_HOCVAN, string cboHOCVAN)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,NOISINH,QUEQUAN, NGAYVAODOAN,NGAYVAODANG,NOIVAODANG,STATUS From NHANVIEN ,PHONGBAN,TRINHDOHOCVAN Where PHONGBAN=MAPB and TD_HOCVANNV =MATDHV and PHONGBAN = @maphong and STATUS = @tt ";
            cmd.Parameters.Add("maphong", SqlDbType.VarChar).Value = cboPHONGBAN;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;


            if (cboChon_HOCVAN != "NONE")
            {
                sql += cboChon_HOCVAN + " TD_HOCVANNV = @mahv ";
                cmd.Parameters.Add("mahv", SqlDbType.VarChar).Value = cboHOCVAN;
            }



            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region ThongKe_TatCaNhanVienTheoTrinhDoHocVan()
        public DataTable ThongKe_TatCaNhanVienTheoTrinhDoHocVan(int trangthai, string cboChon_HOCVAN, string cboHOCVAN)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,NOISINH,QUEQUAN, NGAYVAODOAN,NGAYVAODANG,NOIVAODANG,STATUS From NHANVIEN ,TRINHDOHOCVAN Where  TD_HOCVANNV =MATDHV and  STATUS = @tt ";
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;


            if (cboChon_HOCVAN != "NONE")
            {
                sql += cboChon_HOCVAN + " TD_HOCVANNV = @mahv ";
                cmd.Parameters.Add("mahv", SqlDbType.VarChar).Value = cboHOCVAN;
            }



            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region TraCuu_NhanVien()
        public DataTable TraCuu_NhanVien(string cboPHONGBAN, int trangthai,string cboChon_TENNV,string txtTENNV, string cboChon_CMND, string txtCMND, string cboChon_GIOITINH, int cboGIOITINH, string cboChon_HOCVAN, string cboHOCVAN, string cboChon_TINHOC, string cboTINHOC, string cboChon_NGOAINGU, string cboNGOAINGU, string cboTD_NGOAINGU)
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand();
            String sql = "Select MANV,HOTEN,BIDANH,NGAYSINH,TINHTRANGHONNHAN,CMND,NGAYCAPCMND,NOICAPCMND,PHONGBAN,STATUS From NHANVIEN ,PHONGBAN, TRINHDOHOCVAN, TRINHDOTINHOC, TRINHDONGOAINGU, NGOAINGU Where  PHONGBAN=MAPB and TD_HOCVANNV = MATDHV and TD_TINHOCNV=MATDTH and NGOAINGUCHINHNV = MANN and TD_NGOAINGUNV= MATDNN and PHONGBAN = @maphong and STATUS = @tt  ";
            cmd.Parameters.Add("maphong", SqlDbType.VarChar).Value = cboPHONGBAN;
            cmd.Parameters.Add("tt", SqlDbType.Int).Value = trangthai;

            if (cboChon_TENNV != "NONE")
            {
                sql += cboChon_TENNV + " HOTEN Like +'%'+@ht+'%' ";
                cmd.Parameters.Add("ht", SqlDbType.NVarChar).Value = txtTENNV;
            }
            if (cboChon_CMND != "NONE")
            {
                sql += cboChon_CMND + " CMND  = @cmnd ";
                cmd.Parameters.Add("cmnd", SqlDbType.NVarChar).Value = txtCMND;
            }
            if (cboChon_GIOITINH != "NONE")
            {
                sql += cboChon_GIOITINH + " GIOITINH = @gioitinh ";
                cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = cboGIOITINH;
            }
            if (cboChon_HOCVAN != "NONE")
            {
                sql += cboChon_HOCVAN + " TD_HOCVANNV = @mahv ";
                cmd.Parameters.Add("mahv", SqlDbType.VarChar).Value = cboHOCVAN;
            }
            if (cboChon_TINHOC != "NONE")
            {
                sql += cboChon_TINHOC + " TD_TINHOCNV = @math ";
                cmd.Parameters.Add("math", SqlDbType.VarChar).Value = cboTINHOC;
            }
            if (cboChon_NGOAINGU != "NONE")
            {
                sql += cboChon_NGOAINGU + " NGOAINGUCHINHNV = @mann and TD_NGOAINGUNV = @matdnn ";
                cmd.Parameters.Add("mann", SqlDbType.VarChar).Value = cboNGOAINGU;
                cmd.Parameters.Add("matdnn", SqlDbType.VarChar).Value = cboTD_NGOAINGU;
            }

            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion
    }
}
