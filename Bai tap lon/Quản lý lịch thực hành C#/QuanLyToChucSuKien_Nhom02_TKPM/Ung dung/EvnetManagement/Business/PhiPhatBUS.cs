using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.DataAccess;
using System.Data.Linq;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Phí phạt business
    /// </summary>
    class PhiPhatBUS
    {
        private dbEventsManagementDataContext db;
        public PhiPhatBUS()
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
        /// Load danh sách tất cả các phí phạt
        /// </summary>
        public Table<PhiPhat> DanhSachPhiPhat()
        {
            try
            {
                return db.PhiPhats;
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

        public DataTable LayDuLieu()
        {
            try
            {
                return (new DataProvider()).GetTable("Select * from PhiPhat");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
