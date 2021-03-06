using System;
using System.Collections.Generic;
using System.Text;
using QUANLIKH.BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIKH.Data
{
   public  class NhanVienData
    {
        DataProvider dp = new DataProvider();
        public DataTable SelectAll()
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIENQUANLYDAILY");
            dp.Load(cmd);
            return dp;
        }
        public void Update()
        {
            dp.Update();
        }
        public void Insert(DataRow nv)
        {
            dp.Rows.Add(nv);
        }
        public void Delete(NhanVien nv)
        {

        }

       internal DataTable Find(string tennv, int phai, string chonphai, string diachi, string chondiachi)
       {
           //throw new Exception("The method or operation is not implemented.");
           SqlCommand cmd = new SqlCommand();
           string sql = "select * from NHANVIENQUANLYDAILY WHERE HOVATEN LIKE '%' + @tennv + '%'  ";

           //-----gan gia tri can tim vào 2 biến @tenncc và @diachi
           cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = tennv;

           cmd.Parameters.Add("@phai", SqlDbType.NVarChar).Value = phai;
           cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
          
           //---nối vào sql tùy chọn AND hay OR hay NOT AND
           if (!chonphai.Equals("NONE"))
               sql += chonphai + "  PHAI = @phai ";
           if (!chondiachi.Equals("NONE"))
               sql += chondiachi + "  DIACHI LIKE '%' + @diachi +'%'";
         



           cmd.CommandText = sql;
           dp.Load(cmd);
           return dp;
       }
    }
}
