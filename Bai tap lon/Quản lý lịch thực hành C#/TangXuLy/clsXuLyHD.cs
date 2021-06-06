using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using TangDuLieu;

namespace TangXuLy
{
    public class clsXuLyHD
    {
        clsDuLieuHD objHD = new clsDuLieuHD();

        public DataTable GetThongTinHD()
        {
            return objHD.GetThongtinHD();
        }

        #region" Lấy Dữ Liệu Tầng Dưới"

        public DataSet GetHoaDon(string TenBang)
        {
            return objHD.GetDataSetHD(TenBang);
        }

        #endregion

        #region "Cập Nhật Cho Hoa Don(Thêm-Xóa-Sửa)"

        public void CapNhatHoaDon(DataSet ds, string TenBang)
        {
            objHD.CapNhatHD(ds, TenBang);
        }


        #endregion
    }
}
