using System;
using System.Collections.Generic;
using System.Linq;
using EventManager.DataAccess;
using System.Data.Linq;
using EventManager.Enums;
using EventManager.Utilities;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Chương trình Business
    /// </summary>
    class ChuongTrinhBUS
    {
        private dbEventsManagementDataContext db;

        public ChuongTrinhBUS()
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
        /// Lấy danh sách các chương trình
        /// </summary>
        public Table<ChuongTrinh> DanhSachChuongTrinh()
        {
            try
            {
                return db.ChuongTrinhs;
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
        /// Xóa 1 chương trình
        /// </summary>
        /// <param name="maCT">Mã chương trình</param>
        public void Xoa(string maCT)
        {
            try
            {
                db.ChuongTrinhs.DeleteOnSubmit(db.ChuongTrinhs.Single(nv => nv.MaCT == maCT));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Sinh mã tự động cho 1 chương trình
        /// </summary>
        public string SinhMaTuDong()
        {
            try
            {
                return UtilitiesClass.SinhMaTuDong(TableNames.ChuongTrinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin của 1 chương trình
        /// </summary>
        /// <param name="maCT">Mã chương trình</param>
        public ChuongTrinh LayThongTin(string maCT)
        {
            try
            {
                return db.ChuongTrinhs.Single(ct => ct.MaCT == maCT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(ChuongTrinh ct)
        {
            try
            {
                db.ChuongTrinhs.InsertOnSubmit(ct);
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
                return (new DataProvider()).GetTable("Select * from ChuongTrinh");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
