using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TangDuLieu
{
   public class clsDuLieuSanPham:KetNoiCommon
    {
        public DataTable GetThongTinSP()
        {
            string sql = @"select * from SanPham ";
            return GetDataSet(sql, "SanPham").Tables[0];
        }

        public DataSet GetDataSetSP(string TenBang)
        {
            string sql = @"select * from " + TenBang;
            return GetDataSet(sql, TenBang);
        }

        public void CapNhatSP(DataSet ds, string TenBang)
        {
            CapNhat(ds, TenBang);
        }
    }
}
