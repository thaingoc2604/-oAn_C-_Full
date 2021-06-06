using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class DienGiai_BUS
    {
        public DataTable GetDSDG()
        {
            DataTable kq = new DataTable();
            DienGiai_DAO dg = new DienGiai_DAO();
            kq = dg.GetDSDG();
            return kq;
        }

        public void ThemMaDG(string madg,string diengiai)
        {
            DienGiai_DAO dg = new DienGiai_DAO();

            dg.ThemMaDG(madg, diengiai);
        }

        public bool SuaDG(string madg, string diengiai)
        {
            DienGiai_DAO dg = new DienGiai_DAO();

            return dg.SuaDG(madg, diengiai);
        }
        
    }
}
