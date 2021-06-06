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
    /// Hợp đồng business
    /// </summary>
    class HopDongBUS
    {
        private dbEventsManagementDataContext db;
        public HopDongBUS()
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
        /// Load danh sách tất cả các hợp đồng
        /// </summary>
        /// <returns>Bảng các hợp đồng</returns>
        public Table<ChiTietCT> DanhSachHopDong()
        {
            try
            {
                return db.ChiTietCTs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Load tất cả các hợp đồng của 1 khách hàng được chỉ định
        /// </summary>
        /// <param name="maKH">mã khách hàng</param>
        public IQueryable<fc_thongTinHDResult> DanhSachHopDong(string maKH)
        {
            try
            {
                return db.fc_thongTinHD(maKH);
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
        /// Xóa 1 hợp đồng
        /// </summary>
        /// <param name="ID">Mã hợp đồng</param>
        public void Xoa(int ID)
        {
            try
            {
                db.ChiTietCTs.DeleteOnSubmit(db.ChiTietCTs.Single(ct => ct.ID == ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Sinh mã tự động cho 1 hợp đồng
        /// </summary>
        public string SinhMaTuDong()
        {
            try
            {
                return UtilitiesClass.SinhMaTuDong(TableNames.ChiTietCT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin của 1 hợp đồng
        /// </summary>
        /// <param name="ID">Mã hợp đồng</param>
        public ChiTietCT LayThongTin(int ID)
        {
            try
            {
                return db.ChiTietCTs.Single(ct => ct.ID == ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(ChiTietCT ct)
        {
            try
            {
                db.ChiTietCTs.InsertOnSubmit(ct);
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
                return (new DataProvider()).GetTable("Select * from ChiTietCT");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
