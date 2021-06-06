using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Data_Tier
{
    public class All_In_One
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename="+@"|DataDirectory|TL_TracNghiem4A.mdf"+";Integrated Security=True;Connect Timeout=30;User Instance=True;");
        public void KetNoi()
        {   
            if (cnn != null && cnn.State==ConnectionState.Closed)
                cnn.Open();
        }
        public void NgatKetNoi()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataView Show_All(String strTableName)
        {
            SqlCommand cmd = new SqlCommand("select * from "+strTableName,cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet(strTableName);
            da.Fill(ds, strTableName);
            DataView dv = new DataView(ds.Tables[strTableName]);
            return dv;
        }
        public int Check_MaCauHoi(String macauhoi)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_CauHoi where macauhoi=@macauhoi", cnn);
            cmd.Parameters.Add("@macauhoi", SqlDbType.Char).Value = macauhoi;
            int n = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return n;
        }
    }
}