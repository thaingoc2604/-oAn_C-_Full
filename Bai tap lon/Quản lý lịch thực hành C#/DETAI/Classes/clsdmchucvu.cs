using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;


namespace DETAI
{
    class clsdmchucvu : clsdm1 
    {
        
        public DataSet taocombo()
        {
            clsdmchucvu  c = new clsdmchucvu() ;
            c.sc.Open();
            string sql1 = "Select * from tbl_DMChucVu";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMChucVu");
            c.sc.Close();
            return c.ds;
        }
        //lấy tên chức vụ từ mã chức vụ
        public string laytenCV(string macv)
        {
            if (macv == "") return "";
            clsdmchucvu c = new clsdmchucvu();
            c.sc.Open();
            string sql1 = "Select tenchucvu from tbl_DMChucVu where machucvu='"+macv+"'";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            object ten = scmd.ExecuteScalar();
            c.sc.Close();
            return ten.ToString();
        }
    }
}
