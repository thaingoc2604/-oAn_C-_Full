using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TangDuLieu
{
   public class clsDuLieuNCC:KetNoiCommon
    {
        public DataTable GetThongtinNCC()
        {
            string sql = @"select * from NhaCungCap ";
            return GetDataSet(sql, "NhaCungCap").Tables[0];
        }

        public DataSet GetDataSetNCC(string TenBang)
        {
            string sql = @"select * from  " + TenBang;
            return GetDataSet(sql, "NhaCungCap");
        }

        public void CapNhatNCC(DataSet ds, string TenBang)
        {
            CapNhat(ds, TenBang);

        }
    }
}
