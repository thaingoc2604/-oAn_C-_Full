using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using TangDuLieu;

namespace TangXuLy
{
  public  class clsXuLySanPham
    {
        clsDuLieuSanPham objSP = new clsDuLieuSanPham();
        public DataTable GetThongTinSP()
        {
            return objSP.GetThongTinSP();
        }
        public DataSet GetSanPham(string TenBang)
        {
            return objSP.GetDataSetSP(TenBang);
        }

        public void CapNhatSanPham(DataSet ds, string TenBang)
        {
            objSP.CapNhatSP(ds, TenBang);
        }
    }
}
