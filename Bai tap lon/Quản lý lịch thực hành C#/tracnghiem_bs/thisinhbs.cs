using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using tracnghiem_da;

namespace tracnghiem_bs
{
    public class thisinhbs
    {
        thisinhda objts = new thisinhda();
        public DataSet dangki(string ma, string hoten, string diachi, string ngaysinh, string tendangnhap, string mk)
        {
            return objts.dangki(ma,hoten,diachi,ngaysinh,tendangnhap,mk);
        }
        public DataSet GetThiSinh(string pass)
        {
            return objts.GetThiSinh(pass);
        }
        public DataSet GetThiSinhDN(string user, string pass)
        {
            return objts.GetThiSinhDN(user, pass);
        }
        public DataSet GetMatKhau(string ma, string tendn)
        {
            return objts.GetMatKhau(ma, tendn);
        }
        public DataSet GetThiSinh()
        {
            return objts.GetThiSinh();
        }
        public DataSet GetThiSinhTen(string hoten)
        {
            return objts.GetThiSinhTen(hoten);
        }
        public DataSet GetThiSinhMa(string ma)
        {
            return objts.GetThiSinhMa(ma);
        }
       public DataSet GetMonThi()
        {
            return objts.GetMonThi();
        }
        public DataSet GetDapAn(string macauhoi)
        {
            return objts.GetDapAn(macauhoi);
        }
        public DataSet GetCauHoi_Mon(string mon)
        {
            return objts.GetCauHoi_Mon(mon);
        }
        public DataSet GetCauHoi()
        {
            return objts.GetCauHoi();
        }
        //public DataSet RDGetCauHoi()
        //{
        //    return objts.RDGetCauHoi();
        //}

        public DataSet GetDapAnDung(string macauhoi)
        {
            return objts.GetDapAnDung(macauhoi);
        }
        public DataSet GetCauHoiNV(string manv)
        {
            return objts.GetCauHoiNV(manv);
        }
        public DataSet ThemCauHoi(string mach,string noidungch,string manv, string mamon,string hinh)
        {
            return objts.ThemCauHoi(mach, noidungch, manv, mamon, hinh);
        }
        public DataSet ThemDapan(string ndtrl, string mach, string kieu)
        {
            return objts.ThemDapan(ndtrl,mach,kieu);
        }
        public DataSet GetCauHoiNV_Mon(string mand, string mamon)
        {
            return objts.GetCauHoiNV_Mon(mand, mamon);
        }
        public DataSet GetCauHoi_Ghichu(string ghichu)
        {
            return objts.GetCauHoi_Ghichu(ghichu);
        }
        public DataSet SoCH_Mon(string mamon)
        {
            return objts.SoCH_Mon(mamon);
        }
        public DataSet ThemMon(string mamon, string tenmon)
        {
            return objts.ThemMon(mamon, tenmon);
        }
        public DataSet KiemTraMon(string mamon)
        {
            return objts.KiemTraMon(mamon);
        }
        public DataSet ThemKetQua(string mats, string ketqua, string mamon)
        {
            return objts.ThemKetQua(mats, ketqua, mamon);
        }

        
    }
}
