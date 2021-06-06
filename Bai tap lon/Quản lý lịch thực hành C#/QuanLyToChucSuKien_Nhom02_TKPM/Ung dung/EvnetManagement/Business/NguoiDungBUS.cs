using System;
using System.Collections.Generic;
using System.Linq;
using EventManager.DataAccess;
using EventManager.Utilities;
using System.Data.Linq;
using System.Data;

namespace EventManager.Business
{
    /// <summary>
    /// Người dùng business
    /// </summary>
    class NguoiDungBUS
    {
        private dbEventsManagementDataContext db;
        public NguoiDungBUS()
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
        /// Load danh sách tất cả các người dùng
        /// </summary>
        /// <returns>Bảng các người dùng</returns>
        public Table<NguoiDung> DanhSachNguoiDung()
        {
            try
            {
                return db.NguoiDungs;
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
        /// Xóa 1 người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        public void Xoa(string tenDangNhap)
        {
            try
            {
                db.NguoiDungs.DeleteOnSubmit(db.NguoiDungs.Single(nd => nd.Username == tenDangNhap));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Lấy thông tin của 1 người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        public NguoiDung LayThongTin(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Single(nd => nd.Username == tenDangNhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Kiểm tra người dùng có tồn tại không
        /// </summary>
        /// <param name="tenDangNhap">tên đăng nhập</param>
        /// <returns>True: tồn tại. Flase: không tồn tại</returns>
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Any(nd => nd.Username == tenDangNhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayMatKhau(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Single(nd => nd.Username == tenDangNhap).Password;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            try
            {
                if (KiemTraTenDangNhap(tenDangNhap))
                {
                    NguoiDung nguoiDung = db.NguoiDungs.Single(nd => nd.Username == tenDangNhap);
                    if(nguoiDung.Password == UtilitiesClass.MaHoaMD5(matKhauCu))
                    {
                        nguoiDung.Password = UtilitiesClass.MaHoaMD5(matKhauMoi);
                        db.SubmitChanges();
                        return true;
                    }
                    else
                        throw new Exception("Mật khẩu cũ không chính xác.");
                }
                else
                    throw new Exception("Không tồn tại người dùng \"" + tenDangNhap + "\"");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Them(NguoiDung nguoiDung)
        {
            try
            {
                db.NguoiDungs.InsertOnSubmit(nguoiDung);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThietLapLaiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                db.NguoiDungs.Single(nd => nd.Username == tenDangNhap).Password = UtilitiesClass.MaHoaMD5(matKhauMoi);
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
                return (new DataProvider()).GetTable("Select Username, TenNguoiDung, Quyen, MoTaQuyen from NguoiDung");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
