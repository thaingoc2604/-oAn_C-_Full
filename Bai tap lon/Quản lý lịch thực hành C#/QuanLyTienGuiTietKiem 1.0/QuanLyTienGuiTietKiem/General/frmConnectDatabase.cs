using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyTienGuiTietKiem.General
{
    public partial class frmConnectDatabase : Office2007Form
    {
        public frmConnectDatabase()
        {
            InitializeComponent();
        }
        String m_FilenameAccess = "";
        String m_NameAccess = "";
        private void frmConnectDatabase_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedIndex = 0;
            cmbKetNoi.SelectedIndex = 0;
            txtpassword.Enabled = false;
            txtUserName.Enabled = false;
        }

        private void cmbKetNoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKetNoi.SelectedIndex == 0)
            {
                btnBrower.Hide();
                txtBrower.Hide();

                lblAuthentication.Show();
                lblDatabase.Show();
                lblPassword.Show();
                lblServer.Show();
                lblUserName.Show();

                txtpassword.Show();
                txtSever.Show();
                txtUserName.Show();

                cmbAuthentication.Show();
                cmbDatabase.Show();

                btnTest.Show();

            }
            if (cmbKetNoi.SelectedIndex == 1)
            {
                btnBrower.Show();
                txtBrower.Show();

                lblAuthentication.Hide();
                lblDatabase.Hide();
                lblPassword.Hide();
                lblServer.Hide();
                lblUserName.Hide();

                txtpassword.Hide();
                txtSever.Hide();
                txtUserName.Hide();

                cmbAuthentication.Hide();
                cmbDatabase.Hide();

                btnTest.Hide();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Quyen window
            if (cmbAuthentication.SelectedIndex == 0)
            {
                cmbDatabase.Items.Clear();
                SqlConnection m_SqlConnection = new SqlConnection("Data Source=" + txtSever.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_SqlConnection);
                SqlDataReader m_DReader;

                try
                {
                    m_SqlConnection.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException Sqle)
                {
                    MessageBoxEx.Show(Sqle.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_SqlConnection.State == ConnectionState.Open)
                        m_SqlConnection.Close();
                    m_SqlConnection.Dispose();
                    m_Cmd.Dispose();
                }

            }
            //Quyen Sql server
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbDatabase.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtSever.Text + ";Initial Catalog=master;User Id=" + txtUserName.Text + ";Password=" + txtpassword.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBoxEx.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            OpenFileDialog m_OpenFile = new OpenFileDialog();
            if (m_OpenFile.ShowDialog() == DialogResult.OK)
            {
                m_FilenameAccess = m_OpenFile.FileName;
                txtBrower.Text = m_OpenFile.FileName;
                //m_NameAccess = m_OpenFile.SafeFileName;
                StringBuilder str = new StringBuilder(m_NameAccess);
                str.Replace(".mdb", "");
                m_NameAccess = str.ToString();
            }
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtpassword.Enabled = false;
                txtUserName.Enabled = false;
            }
            else
            {
                txtpassword.Enabled = true;
                txtUserName.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 1)
            {
                XML.WriteXml("Connection.xml", txtSever.Text, cmbDatabase.Text, "true");
            }
            else
            {
                XML.XMLWriter("Connection.xml", txtSever.Text, txtUserName.Text, txtpassword.Text, cmbDatabase.Text, "false");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}