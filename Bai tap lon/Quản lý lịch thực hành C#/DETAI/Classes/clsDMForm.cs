using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.IO;

namespace DETAI
{
    class clsDMForm
    {
        SqlConnection sc = frmMain.me.libsql.getCon();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public DataSet  laydl()
        {
            string sqlSel = "Select * from tbl_DMForm ";
            sc.Open();
            SqlCommand cmdsel = new SqlCommand(sqlSel, sc);
            sda.SelectCommand = cmdsel;
            sda.Fill(ds, "DMform");
            sc.Close();
            return ds;
        }
        public void insert(string user, string idform, int b)
        {
            string ins = "insert tbl_user_form values ('" + user + "','"
                                               + idform + "'," + b + ")";
            sc.Open();
            SqlCommand scmd = new SqlCommand(ins, sc);
            scmd.ExecuteNonQuery();
            sc.Close();

        }
    }
}
