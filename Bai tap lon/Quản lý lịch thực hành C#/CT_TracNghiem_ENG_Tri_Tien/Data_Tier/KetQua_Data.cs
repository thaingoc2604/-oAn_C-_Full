using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class KetQua_Data:All_In_One
    {
        public DataView Show_All_KQ_By_ID(String id)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_KetQua where id=@id", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_KetQua");
            da.Fill(ds, "tb_KetQua");
            DataView dv = new DataView(ds.Tables["tb_KetQua"]);
            return dv;
        }
        public int Luu_KetQua(String id, String ho, String ten, String made, double diem, DateTime ngaythi)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("insert into tb_ketqua values(@id,@ho,@ten,@made,@diem,@ngaythi)", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@made", SqlDbType.Char).Value = made;
            cmd.Parameters.Add("@diem", SqlDbType.Real).Value = diem;
            cmd.Parameters.Add("@ngaythi", SqlDbType.DateTime).Value = ngaythi;
            int n = cmd.ExecuteNonQuery();
            return n;
        }
    }
}
