using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using TangDuLieu;

namespace TangXuLy
{
   public class clsXuLyNCC
    {
        public clsDuLieuNCC objNCC = new clsDuLieuNCC();

        public DataTable GetThongTinNCC(string TenBang)
        {
            return objNCC.GetThongtinNCC();

        }

        public DataSet GetNCC(string TenBang)
        {
            return objNCC.GetDataSetNCC(TenBang);

        }
        /// <summary>
        /// Gọi Tầng dữ liệu
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="TenBang"></param>
        public void CapNhatNhaCungCap(DataSet ds, string TenBang)
        {
            objNCC.CapNhatNCC(ds, TenBang);
        }
    }
}
