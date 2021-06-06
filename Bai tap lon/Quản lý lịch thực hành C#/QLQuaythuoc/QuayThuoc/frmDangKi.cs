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
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        public void xoatext(){

            textBox2.Clear();
            textBox1.Clear();
             textBox3.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // dong chuong trinh
            this.Close();

        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // them nguoi dung
            // ketnoi 
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try{

            string chuoithem="insert into Login (ID,Name,Pass) values('"+textBox3.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;    
            cmd.CommandText=chuoithem;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Thanh Cong");
                xoatext();

                cmd.Dispose();
                con.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


                


        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoatext();

        }
    }
}
