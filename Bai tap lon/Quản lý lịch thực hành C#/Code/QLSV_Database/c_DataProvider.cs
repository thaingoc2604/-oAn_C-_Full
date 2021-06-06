using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class c_DataProvider
    {
        string strCn = @"Data Source=.\SQLEXPRESS2k8;AttachDbFilename=D:\BaiTap\Phong Thi Nghiem\C#\QuanLySV\Database\QLSV.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public SqlConnection OpenCN()
        { 
            SqlConnection cn = new SqlConnection(strCn);
            try{
                cn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi  " + ex.ToString(),"Thông báo! ");
            }
            return cn;
        }
        public void CloseCN(SqlConnection cn)
        {

            try
            {
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không đóng được kết nối " + ex.ToString());
            }
           
        }
        
    }
}
