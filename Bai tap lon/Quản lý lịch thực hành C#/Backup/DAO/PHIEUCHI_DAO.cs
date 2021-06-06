using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class PHIEUCHI_DAO : DataProvider
    {
        

        public int LapPhieu(PHIEUCHI_DTO PhieuchiDTO)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@maphieuchi", PhieuchiDTO.Maphieuchi.ToString()),
                new SqlParameter("@DIACHI", PhieuchiDTO.Diachi),
                new SqlParameter("@Maloaiphieu", PhieuchiDTO.Maloaiphieu),
                new SqlParameter("@SOTIEN", PhieuchiDTO.Sotien),
                new SqlParameter("@NGAYLAP", PhieuchiDTO.Ngaylap),
                new SqlParameter("@TON", PhieuchiDTO.Ton),
                new SqlParameter("@DIENGIAI", PhieuchiDTO.Diengiai) };

            return ExecuteNonQuery("sp_LapPhieuchi", sqlParams);


        }

        public int getIDMax()
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Username", "a"), new SqlParameter("@Pass", "a") };
            int id = (int)ExecuteScalar("sp_IDPhieuChiMax", sqlParams);

            return id;
        }
    }
}
