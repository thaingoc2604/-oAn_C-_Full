using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class SODu_BUS : DataProvider
    {
        public Int64 get_So_Du_Theo_Ngay(DateTime nt)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.Get_SoDu_Theo_Ngay(nt);
        }

        public Int64 get_So_Thu_Theo_Ngay(DateTime nt)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.Get_SoThu_Theo_Ngay(nt);
        }

        public Int64 get_So_Chi_Theo_Ngay(DateTime nt)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.Get_SoChi_Theo_Ngay(nt);
        }

        public int kt_ton_tai_so_Du_Theo_Ngay(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.kt_ton_tai_so_Du_Theo_Ngay(nt);
        }

        public int kt_ton_tai_so_Chi_Theo_Ngay(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.kt_ton_tai_so_Chi_Theo_Ngay(nt);
        }

        public int kt_ton_tai_so_Thu_Theo_Ngay(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.kt_ton_tai_so_Thu_Theo_Ngay(nt);
        }



        public int CapNhatSODu(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.capnhatSoDu(nt,sodu);
        }

        public int CapNhatSOThu(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.capnhatSoThu(nt, sodu);
        }

        public int CapNhatSOChi(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.capnhatSoChi(nt, sodu);
        }

        public int ThemSoDu(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.ThemSoDu(nt,sodu);
        }

        public int ThemSoChi(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.ThemSoChi(nt, sodu);
        }

        public int ThemSoThu(DateTime nt, Int64 sodu)
        {
            SoDu_DAO pt = new SoDu_DAO();

            return pt.ThemSoThu(nt, sodu);
        }

        public DataTable DsSoTon()
        {
            SoDu_DAO sd_DAO= new SoDu_DAO();

            return sd_DAO.DsSoTon();
        }

        public DataTable DsSoTon_Theo_Thang(int thang, int nam)
        {
            SoDu_DAO sd_DAO= new SoDu_DAO();

            return sd_DAO.DsSoTon_Theo_Thang(thang,nam);
        }

    }

}
