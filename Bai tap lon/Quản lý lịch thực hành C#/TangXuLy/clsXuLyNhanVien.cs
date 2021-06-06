using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using TangDuLieu;

namespace TangXuLy
{
   public class clsXuLyNhanVien
    {
        clsDuLieuNhanVien objNV = new clsDuLieuNhanVien();

        public DataTable GetThongTinNV()
        {
            return objNV.GetThongtinNV();
        }

        #region" Lấy Dữ Liệu Tầng Dưới"

        public DataSet GetNhanVien(string TenBang)
        {
            return objNV.GetDataSetNV(TenBang);
        }

        #endregion

        #region "Cập Nhật Cho Sinh Viên(Thêm-Xóa-Sửa)"

        public void CapNhatNhanVien(DataSet ds, string TenBang)
        {
            objNV.CapNhatNV(ds, TenBang);
        }

        public void XoaDataNV()
        {
            objNV.XoaData();
        }
        #endregion

        #region "Hàm Hủy Kết Nối"
        //public void huyketnoidata()
        //{
        //    clsDuLieuNhanVien.Close(); // Đóng kết nối
        //    clsDuLieuNhanVien.Dispose(); // Giải phóng tài nguyên
        //    clsDuLieuNhanVien = null; // Hủy đối tượng
        //}
        #endregion
    }
}
