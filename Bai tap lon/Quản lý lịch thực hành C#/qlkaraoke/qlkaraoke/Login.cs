using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{    
    public partial class fLogin : Form
    {        
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLoginBtnLogin_Click(object sender, EventArgs e)
        {
            //-- set label alert null
            fLoginLbAlert.Text = "";
            //-- get value 
            string strUser = fLoginTxtUserName.Text;
            string strPass = fLoginTxtPassword.Text;
            //-- use function dataset chech username and password
            qlkaraoke.DataSet1.EmployeeDataTable emp = employeeTableAdapter1.GetDataByUser(strUser,strPass);
            //-- check num row
            if (emp.Rows.Count > 0)
            {
                string strPermission = emp.Rows[0]["Permission"].ToString();
                if (strPermission != "Admin")
                {
                    Visible = false;
                    fMainUser fUser = new fMainUser(strUser);
                    fUser.Show();
                }
                else
                {
                    Visible = false;
                    fMainAdmin fAdmin = new fMainAdmin();
                    fAdmin.Show();
                }
            }
            else
            {
                fLoginLbAlert.Text = " Invaild UserName or Password, please try again ! ";
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            //employeeTableAdapter1.Fill(dataSet11.Employee);
        }

        private void fLoginBtnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLoginBtnLogin_MouseEnter(object sender, EventArgs e)
        {
            fLoginBtnLogin.Image = Properties.Resources.btn21;
        }

        private void fLoginBtnLogin_MouseLeave(object sender, EventArgs e)
        {
            fLoginBtnLogin.Image = Properties.Resources.btn11;
        }

        private void fLoginBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fLoginBtnClose.Image = Properties.Resources.btn21;
        }

        private void fLoginBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fLoginBtnClose.Image = Properties.Resources.btn11;
        }
    }
}