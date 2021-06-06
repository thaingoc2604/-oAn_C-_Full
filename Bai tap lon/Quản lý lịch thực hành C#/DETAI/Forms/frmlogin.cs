using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmlogin : Form
    {
        
        public frmlogin()        {
            InitializeComponent();
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdconnection_Click_1(object sender, EventArgs e)
        {
            string u = txtusername.Text.Trim();
            string p = txtpassword.Text.Trim();
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(
            "select ID,pass from tbl_user where " +
            " ID = '" + u + "' and " +
            " pass = '" + p + "' ", sc);
            SqlDataReader sdr =
                scmd.ExecuteReader();

            if (sdr.Read())
            {
                string dbu = sdr.GetString(0).Trim();
                string dbp = sdr.GetString(1).Trim();
                sdr.Close();
                sc.Close();

                frmMain.me.libsql =
                     new mysql(frmcauhinh.server,frmcauhinh.data, dbu, dbp);
                frmMain.me.menuStrip1.Visible = true;
                frmMain.me.menubaomat.Enabled  = true;
                if (dbu != "administrator")
                    frmMain.me.menubaomat.Enabled= false;
                frmMain.me.toolStripStatusLabel2.Text = "Người đăng nhập :" + u;
                frmMain.me.trangthai.Text = "Trạng Thái : Sẳn Sàng";
                frmMain.me.trangthai.Image = null;
                this.Close();

            }
            else
            {
                sdr.Close();
                sc.Close();
                MessageBox.Show("Bạn Chưa đăng ký hoặc mật mã không đúng","Thông báo");

            }
        }

        private void cmdexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}