using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clsdmtongiao:clsdm1
    {
        public DataSet taocombo()
        {
            clsdmtongiao  c = new clsdmtongiao() ;
            c.sc.Open();
            string sql1 = "Select * from tbl_DMTonGiao";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMTonGiao");
            c.sc.Close();
            return c.ds;
        }
    }
}
