using System;
using System.Collections.Generic;
using System.Linq;
using EventManager.DataAccess;
using System.Data.Linq;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Kế hoạch chi trả business
    /// </summary>
    class KeHoachChiTraBUS
    {
        private dbEventsManagementDataContext db;

        public KeHoachChiTraBUS()
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
        /// Load danh sách tất cả các kế hoạch chi trả
        /// </summary>
        public Table<KeHoachChiTra> DanhSachKeHoachChiTra()
        {
            try
            {
                return db.KeHoachChiTras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Load kế hoạch chi trả của 1 hợp đồng cùng các thông tin phí phạt
        /// </summary>
        /// <param name="soHopDong">số hợp đồng</param>
        public IQueryable KeHoachChiTra(int soHopDong)
        {
            try
            {
                return (from k in db.KeHoachChiTras
                        join p in db.PhiPhats
                        on new { k.IdCTCT, k.GiaiDoan } equals new { p.IdCTCT, p.GiaiDoan }
                        into temp
                        from t in temp.DefaultIfEmpty()
                        where k.IdCTCT == soHopDong
                        select new
                        {
                            GiaiDoan = k.GiaiDoan,
                            Phi = k.Phi,
                            MoTaPhi = k.MoTaPhi,
                            PhuongThucTT = k.PhuongThucTT,
                            NgayTTTheoKH = k.NgayTTTheoKH,
                            NgayThatSuTT = k.NgayThatSuTT,
                            PhiPhat = (t == null ? 0 : t.PhiPhat1)
                        });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(KeHoachChiTra keHoach)
        {
            try
            {
                db.KeHoachChiTras.InsertOnSubmit(keHoach);
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
        /// Lấy thông tin của 1 kế hoạch chi trả
        /// </summary>
        /// <paparam name="soHD">số hợp đồng</paparam>
        /// <param name="giaiDoan">giai đoạn</param>
        public KeHoachChiTra LayThongTin(int soHD, int giaiDoan)
        {
            try
            {
                return db.KeHoachChiTras.Single(i => i.IdCTCT == soHD && i.GiaiDoan == giaiDoan);
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
                return (new DataProvider()).GetTable("Select * from KeHoachChiTra");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
