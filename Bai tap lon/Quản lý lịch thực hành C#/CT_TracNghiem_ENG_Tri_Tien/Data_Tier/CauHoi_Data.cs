using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class CauHoi_Data:All_In_One
    {
        
        public DataSet Show_CauHoi(String macauhoi)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_cauhoi where macauhoi=@macauhoi", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_CauHoi");
            da.Fill(ds, "tb_CauHoi");
            return ds;
        }
        public DataView Show_CauHoi_ID(String id)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_cauhoi where id=@id", cnn);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_cauhoi");
            da.Fill(ds, "tb_cauhoi");
            DataView dv = new DataView(ds.Tables["tb_cauhoi"]);
            return dv;
        }
        public int Add_Update_CauHoi(String macauhoi, String id, String noidungcauhoi)
        {
            
            String sql = "";
            if (Check_MaCauHoi(macauhoi)>0)
                sql = "update tb_CauHoi set id=@id,noidungcauhoi=@noidungcauhoi where macauhoi='" + macauhoi + "'";
            else
                sql = "insert into tb_cauhoi values(@macauhoi,@id,@noidungcauhoi)";
            
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (Check_MaCauHoi(macauhoi) == 0)
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@noidungcauhoi", SqlDbType.Char).Value = noidungcauhoi;
            KetNoi();
            int n= cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
        public int Delete_CauHoi(String macauhoi)
        {
            try
            {
                KetNoi();
                SqlCommand cmd = new SqlCommand("delete from tb_cauhoi where macauhoi=@macauhoi", cnn);
                cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
                int n = cmd.ExecuteNonQuery();
                NgatKetNoi();
                return n;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
