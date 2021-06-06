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
    public class B_LoaiMon
    {
        D_LoaiMon objLM = new D_LoaiMon();
        public DataTable gettb_LoaiMon()
        {
            return objLM.getAllTable("LoaiMon").Tables["LoaiMon"];
        }
        public int XoaLoaiMon_Theo_MaLoai(string maloai)
        {
            return objLM.XoaLoaiMon(maloai);
        }
        public int ThemLoaiMon(LoaiMon lm)
        {
            return objLM.ThemLoaiMon(lm);
        }

    }
}
