using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DienGiai_DAO:DataProvider
    {
        public DataTable GetDSDG()
        {
            DataTable kq = new DataTable();

            kq = LoadData("sp_dsMaDG");

            DisConnect();

            return kq;
        }

        public void ThemMaDG(string madg, string diengiai)
        {


            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@diengiai", diengiai) };

            ExecuteScalar("sp_ThemMaDG",sqlParams);


        }

        public bool SuaDG(string madg, string diengiai)
        {

            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@madg", madg), new SqlParameter("@diengiai", diengiai) };
            int flag = ExecuteNonQuery("sp_SuaDG", sqlParams);
            if (flag == 1)
                return true;
            else
                return false;


        }
    }
}
