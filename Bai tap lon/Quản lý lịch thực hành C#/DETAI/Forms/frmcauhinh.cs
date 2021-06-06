using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo ;

namespace DETAI
{
    public partial class frmcauhinh : Form
    {
        //khai báo biến toàn cục
        static public string server = "";
        static public string data = "";
        clsdocfile c = new clsdocfile();
        public frmcauhinh()
        {
            InitializeComponent();
            frmgioithieusp f = new frmgioithieusp();
            f.ShowDialog();
            f.BringToFront();
        }
        public void khoitao(string servername, string database, string usernamesa, string passsa)
        {
            string sqlcon = "server =" + servername + " ; database = " + database +
                "; uid = " + usernamesa + "; pwd =" + passsa;
            string sqlcon1 = "server =" + servername + " ; database = master" +
                "; uid = " + usernamesa + "; pwd =" + passsa;
            server = servername;
            data = database;
            SqlConnection sc = new SqlConnection(sqlcon);
            SqlConnection sc1 = new SqlConnection(sqlcon);
            SqlConnection sc2 = new SqlConnection(sqlcon1);
            //doc file script
            FileInfo file = new FileInfo(Application.StartupPath + "\\File\\script1.sql");
            string script = file.OpenText().ReadToEnd();
            Server servers = new Server(new ServerConnection(sc));
            servers.ConnectionContext.ExecuteNonQuery(script);
            sc.Close();

            //tao login va user u0
            sc2.Open();
            SqlCommand scmd0u0 = new SqlCommand("KiemTraLogin", sc2);
            SqlParameter ulogu0 = new SqlParameter("@loginname", "u0");
            scmd0u0.CommandType = CommandType.StoredProcedure;
            scmd0u0.Parameters.AddRange(new SqlParameter[] { ulogu0 });
            object o1u0 = scmd0u0.ExecuteScalar();
            sc2.Close();
            if (o1u0 == null)
            {
                sc1.Open();
                SqlCommand scmd2u0 = new SqlCommand("KiemTraUser", sc1);
                SqlParameter uu0 = new SqlParameter("@username", "u0");
                scmd2u0.CommandType = CommandType.StoredProcedure;
                scmd2u0.Parameters.AddRange(new SqlParameter[] { uu0 });
                object ou0 = scmd2u0.ExecuteScalar();
                sc1.Close();
                if (ou0 != null)
                {
                    sc1.Open();
                    SqlCommand scmd3u0 = new SqlCommand("Dropuser", sc1);
                    SqlParameter nameu0 = new SqlParameter("@username", "u0");
                    scmd3u0.CommandType = CommandType.StoredProcedure;
                    scmd3u0.Parameters.AddRange(new SqlParameter[] { nameu0 });
                    scmd3u0.ExecuteNonQuery();
                    sc1.Close();
                }
                sc1.Open();
                SqlCommand scmd1u0 = new SqlCommand("AddLogIn", sc1);
                SqlParameter maloginu0 = new SqlParameter("@name", "u0");
                SqlParameter passloginu0 = new SqlParameter("@pass", "123");
                scmd1u0.CommandType = CommandType.StoredProcedure;
                scmd1u0.Parameters.AddRange(new SqlParameter[] { maloginu0, passloginu0 });
                scmd1u0.ExecuteNonQuery();
                sc1.Close();

                sc1.Open();
                SqlCommand scmd4u0 = new SqlCommand("AddUser", sc1);
                SqlParameter loginnameu0 = new SqlParameter("@loginname", "u0");
                SqlParameter usernameu0 = new SqlParameter("@username", "u0");
                scmd4u0.CommandType = CommandType.StoredProcedure;
                scmd4u0.Parameters.AddRange(new SqlParameter[] { loginnameu0, usernameu0 });
                scmd4u0.ExecuteNonQuery();
                sc1.Close();
            }
            else
            {
                sc1.Open();
                SqlCommand scmd2u0 = new SqlCommand("KiemTraUser", sc1);
                SqlParameter uu0 = new SqlParameter("@username", "u0");
                scmd2u0.CommandType = CommandType.StoredProcedure;
                scmd2u0.Parameters.AddRange(new SqlParameter[] { uu0 });
                object ou0 = scmd2u0.ExecuteScalar();
                sc1.Close();
                if (ou0 != null)
                {
                    sc1.Open();
                    SqlCommand scmd3u0 = new SqlCommand("Dropuser", sc1);
                    SqlParameter nameu0 = new SqlParameter("@username", "u0");
                    scmd3u0.CommandType = CommandType.StoredProcedure;
                    scmd3u0.Parameters.AddRange(new SqlParameter[] { nameu0 });
                    scmd3u0.ExecuteNonQuery();
                    sc1.Close();

                    

                }
                sc1.Open();
                SqlCommand scmd4u0 = new SqlCommand("AddUser", sc1);
                SqlParameter loginnameu0 = new SqlParameter("@loginname", "u0");
                SqlParameter usernameu0 = new SqlParameter("@username", "u0");
                scmd4u0.CommandType = CommandType.StoredProcedure;
                scmd4u0.Parameters.AddRange(new SqlParameter[] { loginnameu0, usernameu0 });
                scmd4u0.ExecuteNonQuery();
                sc1.Close();
                

            }


            //kiem tra trong bang user va tao
            sc.Open();
            string sqluser = "select * from tbl_user";
            SqlCommand scmd = new SqlCommand(sqluser, sc);
            SqlDataReader sdr = scmd.ExecuteReader();

            while (sdr.Read())
            {
                string ma = sdr.GetString(0).Trim();
                string pass = sdr.GetString(1).Trim();
                string grp = sdr.GetString(2).Trim();
                sc2.Open();
                SqlCommand scmd0 = new SqlCommand("KiemTraLogin", sc2);
                SqlParameter ulog = new SqlParameter("@loginname", ma);
                scmd0.CommandType = CommandType.StoredProcedure;
                scmd0.Parameters.AddRange(new SqlParameter[] { ulog });
                object o1 = scmd0.ExecuteScalar();
                sc2.Close();
                if (o1 == null)
                {
                    sc1.Open();
                    SqlCommand scmd2 = new SqlCommand("KiemTraUser", sc1);
                    SqlParameter u = new SqlParameter("@username", ma);
                    scmd2.CommandType = CommandType.StoredProcedure;
                    scmd2.Parameters.AddRange(new SqlParameter[] { u });
                    object o = scmd2.ExecuteScalar();
                    sc1.Close();
                    if (o != null)
                    {
                        sc1.Open();
                        SqlCommand scmd3 = new SqlCommand("Dropuser", sc1);
                        SqlParameter name = new SqlParameter("@username", ma);
                        scmd3.CommandType = CommandType.StoredProcedure;
                        scmd3.Parameters.AddRange(new SqlParameter[] { name });
                        scmd3.ExecuteNonQuery();
                        sc1.Close();
                    }
                    sc1.Open();
                    SqlCommand scmd1 = new SqlCommand("AddLogIn", sc1);
                    SqlParameter malogin = new SqlParameter("@name", ma);
                    SqlParameter passlogin = new SqlParameter("@pass", pass);
                    scmd1.CommandType = CommandType.StoredProcedure;
                    scmd1.Parameters.AddRange(new SqlParameter[] { malogin, passlogin });
                    scmd1.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();
                    SqlCommand scmd4 = new SqlCommand("AddUser", sc1);
                    SqlParameter loginname = new SqlParameter("@loginname", ma);
                    SqlParameter username = new SqlParameter("@username", ma);
                    scmd4.CommandType = CommandType.StoredProcedure;
                    scmd4.Parameters.AddRange(new SqlParameter[] { loginname, username });
                    scmd4.ExecuteNonQuery();
                    sc1.Close();
                }
                else
                {
                    sc1.Open();
                    SqlCommand scmd2 = new SqlCommand("KiemTraUser", sc1);
                    SqlParameter u = new SqlParameter("@username", ma);
                    scmd2.CommandType = CommandType.StoredProcedure;
                    scmd2.Parameters.AddRange(new SqlParameter[] { u });
                    object o = scmd2.ExecuteScalar();
                    sc1.Close();
                    if (o != null)
                    {
                        sc1.Open();
                        SqlCommand scmd3 = new SqlCommand("Dropuser", sc1);
                        SqlParameter name = new SqlParameter("@username", ma);
                        scmd3.CommandType = CommandType.StoredProcedure;
                        scmd3.Parameters.AddRange(new SqlParameter[] { name });
                        scmd3.ExecuteNonQuery();
                        sc1.Close();
                        
                    }
                    
                    sc1.Open();
                    SqlCommand scmd5 = new SqlCommand("Droplogin", sc1);
                    SqlParameter ma_login = new SqlParameter("@loginname", ma);
                    scmd5.CommandType = CommandType.StoredProcedure;
                    scmd5.Parameters.AddRange(new SqlParameter[] { ma_login });
                    scmd5.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();
                    SqlCommand scmd1 = new SqlCommand("AddLogIn", sc1);
                    SqlParameter malogin = new SqlParameter("@name", ma);
                    SqlParameter passlogin = new SqlParameter("@pass", pass);
                    scmd1.CommandType = CommandType.StoredProcedure;
                    scmd1.Parameters.AddRange(new SqlParameter[] { malogin, passlogin });
                    scmd1.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();
                    SqlCommand scmd4 = new SqlCommand("AddUser", sc1);
                    SqlParameter loginname1 = new SqlParameter("@loginname", ma);
                    SqlParameter username = new SqlParameter("@username", ma);
                    scmd4.CommandType = CommandType.StoredProcedure;
                    scmd4.Parameters.AddRange(new SqlParameter[] { loginname1, username });
                    scmd4.ExecuteNonQuery();
                    sc1.Close();
                
                }

                if (ma != "administrator")
                {
                    sc1.Open();
                    SqlCommand scmd5 = new SqlCommand("AddRolesMember", sc1);
                    SqlParameter rolename = new SqlParameter("@rolesname", grp);
                    SqlParameter uname = new SqlParameter("@username", ma);
                    scmd5.CommandType = CommandType.StoredProcedure;
                    scmd5.Parameters.AddRange(new SqlParameter[] { rolename, uname });
                    scmd5.ExecuteNonQuery();
                    sc1.Close();
                }
                else
                {
                    sc1.Open();
                    SqlCommand scmd6 = new SqlCommand("AddVip", sc1);
                    SqlParameter useradmin = new SqlParameter("@useradmin", ma);
                    SqlParameter role = new SqlParameter("@rolename", grp);
                    scmd6.CommandType = CommandType.StoredProcedure;
                    scmd6.Parameters.AddRange(new SqlParameter[] { useradmin, role });
                    scmd6.ExecuteNonQuery();
                    sc1.Close();
                }
            }
            sc.Close();

        }
        private void frmcauhinh_Load(object sender, EventArgs e)
        {
            c.docfile();
            if(c.strLine1.Contains("server:")==true)txtserver.Text = c.strLine1.Substring(7);
            if (c.strLine2.Contains("database:") == true) txtdata.Text = c.strLine2.Substring(9);
            if (c.strLine3.Contains("username:") == true) txtuser.Text = c.strLine3.Substring(9);
            if (c.strLine4.Contains("pass:") == true) txtpass.Text = c.strLine4.Substring(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                khoitao(txtserver.Text.Trim(), txtdata.Text.Trim(), txtuser.Text.Trim(), txtpass.Text.Trim());                         
                frmMain f = new frmMain();
                f.Show();
                c.ghifile(txtserver.Text.Trim(), txtdata.Text.Trim(), txtuser.Text.Trim(), txtpass.Text.Trim());
                
            }
            
            catch(SqlException ex)
            {

                MessageBox.Show(""+ex.Number+ex.Message , "Thông báo");
                MessageBox.Show("Kết nối không thành công !!!","Thông báo");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}