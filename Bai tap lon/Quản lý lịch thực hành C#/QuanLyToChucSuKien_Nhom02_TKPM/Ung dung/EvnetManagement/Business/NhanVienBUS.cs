using System;
using System.Collections.Generic;
using System.Linq;
using EventManager.DataAccess;
using EventManager.Utilities;
using EventManager.Enums;
using System.Data.Linq;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Nhân viên Business
    /// </summary>
    class NhanVienBUS
    {
        private dbEventsManagementDataContext db;
        public NhanVienBUS()
        {
            try
            {
                db = new dbEventsManagementDataContext();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Load danh sách tất cả các nhân viên
        /// </summary>
        /// <returns>Bảng các nhân viên</returns>
        public Table<NhanVien> DanhSachNhanVien()
        {
            try
            {
                return db.NhanViens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lưu các thay đổi vào CSDL
        /// </summary>
        public void LuuThayDoi()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Xóa 1 nhân viên
        /// </summary>
        /// <param name="maKH">Mã nhân viên</param>
        public void Xoa(string maNV)
        {
            try
            {
                db.NhanViens.DeleteOnSubmit(db.NhanViens.Single(nv => nv.MaNV == maNV));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Sinh mã tự động cho 1 nhân viên
        /// </summary>
        public string SinhMaTuDong()
        {
            try
            {
                return UtilitiesClass.SinhMaTuDong(TableNames.NhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin của 1 nhân viên
        /// </summary>
        /// <param name="maNV">Mã nhân viên</param>
        public NhanVien LayThongTin(string maNV)
        {
            try
            {
                return db.NhanViens.Single(nv => nv.MaNV == maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Table<view_ThongTinNV> ThongTinNV()
        {
            try
            {
                return db.view_ThongTinNVs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDuLieu()
        {
            try
            {
                return (new DataProvider()).GetTable("Select * from NhanVien");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
