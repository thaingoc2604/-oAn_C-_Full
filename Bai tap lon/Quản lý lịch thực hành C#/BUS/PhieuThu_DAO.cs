using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class PhieuThu_DAO : DataProvider
    {
        public int LapPhieu(PHIEUTHU_DTO phieuthu_DTO)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@maphieuthu", phieuthu_DTO.Maphieuthu.ToString()),
                new SqlParameter("@DIACHI", phieuthu_DTO.Diachi),
                new SqlParameter("@Maloaiphieu", phieuthu_DTO.Maloaiphieu),
                new SqlParameter("@SOTIEN", phieuthu_DTO.Sotien),
                new SqlParameter("@NGAYLAP", phieuthu_DTO.Ngaylap),
                new SqlParameter("@TON", phieuthu_DTO.Ton),
                new SqlParameter("@DIENGIAI", phieuthu_DTO.Diengiai) };


            return ExecuteNonQuery("sp_LapPhieutHU", sqlParams);



        }

       

        public int getIDMax()
        {
             SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@Username", ""), new SqlParameter("@Pass", "") };
            int id=(int)ExecuteScalar("sp_IDPhieuThuMax", sqlParams) ;

            return id;
        }
    }
}
