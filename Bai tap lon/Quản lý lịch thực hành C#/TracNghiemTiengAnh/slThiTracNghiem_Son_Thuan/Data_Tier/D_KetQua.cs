using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class D_KetQua:General_Data
    {

        //-------------Lưu Kết quả thí sinh thi xuống csdl-------------
        public int LuuKetQua(KetQua KQ)
        {
            
                ketnoi();
                CMD = new SqlCommand("insert  into TB_KETQUA values('" + KQ.MaThiSinh + "','" + KQ.TenThiSinh + "' ,'" + KQ.MaMon + "'," + KQ.Diem + ",'" + KQ.NgayThi + "')", con);
                //DA = new SqlDataAdapter(CMD);
                int n = CMD.ExecuteNonQuery();
                con.Close();
                return n;
            
        }

        public DataSet XemDiem_D(string mathisinh)
        {
            CMD = new SqlCommand("select * from TB_KETQUA where mathisinh='"+mathisinh+"' ",con);
            DA = new SqlDataAdapter(CMD);
            ds = new DataSet();
            DA.Fill(ds,"TB_KETQUA");
            return ds;
        }

        public DataSet XemDiem_AllD()
        {
            CMD = new SqlCommand("select * from TB_KETQUA ", con);
            DA = new SqlDataAdapter(CMD);
            ds = new DataSet();
            DA.Fill(ds, "TB_KETQUA");
            return ds;
        }


    }
}
