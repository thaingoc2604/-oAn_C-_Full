//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entities;
using Data_tier;
namespace BUI_tier
{
    public class B_MonAn
    {
        D_MonAn objMA = new D_MonAn();
        public DataTable gettbMonAn()
        {
            return objMA.getAllTable("MonAn").Tables["MonAn"];
        }

        public DataTable gettbMonAn_theo_MaMon(string strmamon)
        {
            return objMA.getMonAn_theo_mamon(strmamon).Tables["MonAn"];
        }

        public DataTable gettbMonAn_theo_MaLoai(string strmaloai)
        {
            return objMA.getMonAn_theo_maloai(strmaloai).Tables["MonAn"];
        }

        public int ThemMonAn(MonAn ma)
        {
            return objMA.ThemMoiMonAn(ma);
        }

        public int XoaMonAn_Theo_MaMon(string mamon)
        {
            return objMA.XoaMonAn(mamon);
        }

        public int SuaMonAn_TheoMaMon(MonAn monmoi, string mamon)
        {
            return objMA.SuaMonAn_TheoMaMon(monmoi, mamon);
        }

        public DataTable TimTenMon_TheoLoai(string tenmongandung, string maloai)
        {
            return objMA.TimTenMon_TheoLoai(tenmongandung, maloai).Tables["MonAn"];
        }
    }
}
