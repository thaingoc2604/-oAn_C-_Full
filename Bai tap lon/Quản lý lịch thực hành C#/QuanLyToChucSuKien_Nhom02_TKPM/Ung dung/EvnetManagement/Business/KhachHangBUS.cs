using System;
using System.Collections.Generic;
using System.Linq;
using EventManager.DataAccess;
using EventManager.Utilities;
using EventManager.Enums;
using System.Data.Linq;
using System.Text;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Khách hàng Business
    /// </summary>
    class KhachHangBUS
    {
        private dbEventsManagementDataContext db;
        public KhachHangBUS()
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
        /// Load danh sách tất cả các khách hàng
        /// </summary>
        /// <returns>Bảng các khách hàng</returns>
        public Table<KhachHang> DanhSachKhachHang()
        {
            try
            {
                return db.KhachHangs;
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
        /// Xóa 1 khách hàng
        /// </summary>
        /// <param name="maKH">Mã khách hàng</param>
        public void Xoa(string maKH)
        {
            try
            {
                db.KhachHangs.DeleteOnSubmit(db.KhachHangs.Single(kh => kh.MaKH == maKH));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Sinh mã tự động cho 1 khách hàng
        /// </summary>
        public string SinhMaTuDong()
        {
            try
            {
                return UtilitiesClass.SinhMaTuDong(TableNames.KhachHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin của 1 khách hàng
        /// </summary>
        /// <param name="maKH">Mã khách hàng</param>
        public KhachHang LayThongTin(string maKH)
        {
            try
            {
                return db.KhachHangs.Single(kh => kh.MaKH == maKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(KhachHang kh)
        {
            try
            {
                db.KhachHangs.InsertOnSubmit(kh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Table<view_ThongTinKH> ThongTinTongHop()
        {
            try
            {
                return db.view_ThongTinKHs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayLoaiKH(string maKH)
        {
            try
            {
                return db.view_ThongTinKHs.Single(kh => kh.MaKH == maKH).XepLoai;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimKiemNangCao(List<string> truong, List<string> giaTri, List<string> dieuKien, List<string> toanTu)
        {
            try
            {
                string query = TaoTruyVan(truong, giaTri, dieuKien, toanTu);
                return (new DataProvider()).GetTable(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimKiemNangCao(string cauTruyVan)
        {
            try
            {
                return (new DataProvider()).GetTable(cauTruyVan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string TaoTruyVan(List<string> truong, List<string> giaTri, List<string> dieuKien, List<string> toanTu)
        {
            try
            {
                StringBuilder query = new StringBuilder("select * from view_ThongTinKH where ");
                for (int i = 0; i < giaTri.Count; i++)
                {
                    query.Append(truong[i] + " " + dieuKien[i] + " " + giaTri[i] + " " + toanTu[i] + " ");
                }
                if (toanTu[toanTu.Count - 1] == "and")
                    query.Remove(query.Length - 5, 5);
                else
                    query.Remove(query.Length - 4, 4);
                return query.ToString();
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
                return (new DataProvider()).GetTable("Select * from KhachHang");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void NhapTuExcel(string duongDan)
        {
            try
            {
                (new DataProvider()).ImportDataFromExcel(duongDan, "KhachHang", "Select MaKH, TenKH, DiaChi, DienThoai, Email from [KhachHang$]");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
