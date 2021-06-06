using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace QuayThuoc
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                string chuoi = "select*from Login where Name='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'";
                cmd.CommandText = chuoi;
                //SqlDataAdapter da = cmd.ExecuteReader();
                SqlDataReader sqldr = cmd.ExecuteReader();
                if (sqldr.Read())
                {
                    MessageBox.Show("okie ");
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Loi rui");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDangKi call = new frmDangKi();
            call.Show();

        }
    }
}
