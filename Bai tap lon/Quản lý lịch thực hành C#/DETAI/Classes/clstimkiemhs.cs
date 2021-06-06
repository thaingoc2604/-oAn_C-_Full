using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clstimkiemhs
    {
        public SqlConnection sc = frmMain.me.libsql.getCon();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet laydl()
        {
            ds.Clear();
            string sel_ = "select * from V_ThongTin_NV";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "TC_NV");
            sc.Close();
            ds.WriteXmlSchema("TC_NV.xml");
            return ds;
        }
        public DataSet laydl(string chuoidk)
        {
            ds.Clear();
            string sel_ = "select * from V_ThongTin_NV where " + chuoidk;
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "TC_NV");
            sc.Close();
            ds.WriteXmlSchema("TC_NV.xml");
            return ds;
        }
    }
}
