using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace QLTKB
{
    class ConnectDB
    {
        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;

        public ConnectDB()
        {
            SqlConnection con = new SqlConnection("Data Source=P2SHARE; Initial Catalog=QLTKB; Integrated Security=True");
        }

        public SqlConnection getcon()
        {
            return new SqlConnection("Data Source=P2SHARE; Initial Catalog=QLTKB; Integrated Security=True");
        }

        public DataTable taobang(string sql)
        {
            con = getcon();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            con = getcon();
            sqlcom = new SqlCommand(sql, con);
            con.Open();
            sqlcom.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }
        public string LoadLable(string sql)
        {
            string ketqua = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            con.Close();
            return ketqua;
        }
        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(SQL, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            con.Close();
        }
        public bool kiemtra(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
