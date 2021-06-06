using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class DapAn_Data:All_In_One
    {
        public DataSet Show_DapAn(String macauhoi)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_DapAn where macauhoi=@macauhoi", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_DapAn");
            da.Fill(ds, "tb_DapAn");
            return ds;
        }
        public DataSet Show_DapAn_Ran(String macauhoi)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_DapAn where macauhoi=@macauhoi order by NEWID()", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("tb_DapAn");
            da.Fill(ds, "tb_DapAn");
            return ds;
        }
        public int Add_Update_DapAn(String macauhoi, String madapan, String noidungdapan, int dapandung,bool trangthai)
        {
            
            String sql = "";
            if (trangthai==false)
                sql = "update tb_Dapan set noidungdapan=@noidungdapan,dapandung=@dapandung where macauhoi='" + macauhoi + "' and madapan='"+madapan+"'";
            else
                sql = "insert into tb_dapan values(@macauhoi,@madapan,@noidungdapan,@dapandung)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (trangthai == true)
            {
                cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
                cmd.Parameters.Add("@madapan", SqlDbType.Char).Value = madapan;
            }
                cmd.Parameters.Add("@noidungdapan", SqlDbType.Char).Value = noidungdapan;
                cmd.Parameters.Add("@dapandung", SqlDbType.Int).Value = dapandung;
            
            KetNoi();
            int n= cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
        public int Delete_DapAn(String macauhoi)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("delete from tb_dapan where macauhoi=@macauhoi", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            int n = cmd.ExecuteNonQuery();
            NgatKetNoi();
            return n;
        }
    }
}
