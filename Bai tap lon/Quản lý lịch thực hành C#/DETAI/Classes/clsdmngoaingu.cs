using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clsdmngoaingu:clsdm1 
    {
        public DataTable taocombonn()
        {
            clsdmngoaingu c = new clsdmngoaingu();
            c.sc.Open();
            string sql = "Select * from tbl_DMNgoaiNgu";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.ds.Clear();
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMNgoaiNgu");
            c.sc.Close();
            return c.ds.Tables["DMNgoaiNgu"];
        }

        public DataTable taocombonn(string mann)
        {
           
            clsdmngoaingu c = new clsdmngoaingu();
            c.sc.Open();
            string sql = "Select * from tbl_DMNgoaiNgu where mangoaingu ='"+mann+"'";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.ds.Clear();
            c.sda.Fill(c.ds, "DMNgoaiNgu");
            c.sc.Close();
            return c.ds.Tables["DMNgoaiNgu"];
        }
    }
}
