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
    public partial class FrmKhach : Form
    {
        public FrmKhach()
        {
            InitializeComponent();
        }

        private void FrmKhach_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand sqlcom = new SqlCommand();
             



                string xuat1 = "select*from KhachHang";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }

            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into KhachHang(MaKH,Ten,NgaySinh,DiaChi,SoDT,BenhAn) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
                // xoatext();

                string xuat1 = "select*from KhachHang";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


                cmd.Dispose();
                con.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "delete from KhachHang where MaKH='" + textBox1.Text + "'";//set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Xoa thanh cong");


                string xuat1 = "select*from KhachHang";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }

            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
       

            try
            {
                // sua theo ten thuoc


                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "update KhachHang set Ten='" + textBox2.Text + "' where MaKH='" + textBox1.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from KhachHang";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhap các thông tin vào ");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSDL đã được backup");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }

            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from KhachHang where MaKH like '%" + textBox1.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from KhachHang where Ten like '%" + textBox2.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from KhachHang where DiaChi like '%" + textBox4.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            } 
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from KhachHang where SoDT like '%" + textBox5.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from KhachHang where BenhAn like '%" + textBox6.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
