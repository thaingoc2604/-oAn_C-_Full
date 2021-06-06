using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TangDuLieu
{
   public class clsDuLieuHD:KetNoiCommon
    {
        public DataTable GetThongtinHD()
        {
            string sql = @"select * from HoaDon ";
            return GetDataSet(sql, "HoaDon").Tables[0];
        }
        public DataSet GetDataSetHD(string TenBang)
        {
            string sql = @"select * from " + TenBang;
            return GetDataSet(sql, "HoaDon");
        }

        #region" Tạo Kết Nối Để Cập Nhật Xuống CSDL"

        public void CapNhatHD(DataSet ds, string TenBang)
        {
            CapNhat(ds, TenBang);

        }

        #endregion
    }
}
