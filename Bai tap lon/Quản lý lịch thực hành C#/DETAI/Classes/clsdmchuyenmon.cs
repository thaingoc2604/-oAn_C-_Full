using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clsdmchuyenmon: clsdm1 
    {
        public DataTable  taocombocm()
        {
            clsdmchuyenmon c = new clsdmchuyenmon();
            c.sc.Open();
            string sql = "Select * from tbl_DMChuyenMon";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMChuyenMon");
            c.sc.Close();
            return c.ds.Tables["DMChuyenMon"];
        }
        
    }
}
