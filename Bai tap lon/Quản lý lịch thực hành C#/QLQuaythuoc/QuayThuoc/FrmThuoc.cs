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
    public partial class FrmThuoc : Form
    {
        public FrmThuoc()
        {
            InitializeComponent();
        }
        public void timkiemtheoHSD()
        {


            // tim kiem
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from Thuoc where HSD like '%" + textBox6.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void timkiemtheonam()
        {


            // tim kiem
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from Thuoc where NamSX like '%" + textBox5.Text + "%'";
                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void timkiem()
        {


            // tim kiem
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                SqlCommand sqlcom = new SqlCommand();
                string str = "select*from Thuoc where TenThuoc like '%" + textBox1.Text + "%'";
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

        public void xoa123()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        public void radiocheck()
        {
            if (radioButton1.Checked == true)
            {// hien no len
                groupBox3.Visible = true;
                groupBox7.Visible = true;
              //  
                groupBox9.Visible = true;

                groupBox3.Enabled = true;
                groupBox7.Enabled = true;
                groupBox9.Enabled = true;
                button6.Enabled = true;
                button2.Enabled = true;

                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox8.Visible = false;

            }
            if (radioButton2.Checked == true)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                groupBox7.Enabled = false;
                groupBox10.Visible= true;

                groupBox7.Visible = false;

                groupBox8.Visible = false;

                groupBox9.Visible = false;
                groupBox11.Visible = false;

               



            }
            if (radioButton3.Checked == true)
            {
                textBox3.Enabled = false;
                groupBox8.Enabled = true;
                groupBox8.Visible = true;
                groupBox3.Visible = true;
                groupBox7.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
            }



        }



        public void sua()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                // sua theo ten thuoc


                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                 string str1 = "update Thuoc set TenThuoc='" + textBox4.Text + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();

    
                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from Thuoc";

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
        public void xoa1()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                // them truong ngay vao hoa don ban


                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                //  string str = "update Thuoc set NamSX='" + dateTimePicker1.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                string str1 = "delete from Thuoc where MaThuoc='"+textBox2.Text+"'";//set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();

         
                MessageBox.Show("Xoa thanh cong");


                string xuat1 = "select*from Thuoc";

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

        public void capnhat2()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                // them truong ngay vao hoa don ban
          

                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
              //  string str = "update Thuoc set NamSX='" + dateTimePicker1.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                 string str1 = "update Thuoc set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();

                sqlcom.Connection = con;
                sqlcom.CommandText = str1;
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from Thuoc";

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
        public void capnhat1()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
                // them truong ngay vao hoa don ban
              

                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str = "update Thuoc set NamSX='" + dateTimePicker1.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text+ "'";
               // string str1 = "update Thuoc set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

                sqlcom.Connection = con;
                sqlcom.CommandText = str;
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from Thuoc";

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
        public void xuat2()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //  string chuoi = "select*from Login where Name='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'";
                string xem = "select*from Thuoc";

                SqlDataAdapter da = new SqlDataAdapter(xem, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

                cmd.CommandText = xem;
                //MessageBox.Show("Thanh cong");

                SqlDataReader sqldr = cmd.ExecuteReader();
                con.Dispose();
                da.Dispose();
                ds.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void xuat()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //  string chuoi = "select*from Login where Name='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'";
                string xem = "select*from Thuoc";

                SqlDataAdapter da = new SqlDataAdapter(xem, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                cmd.CommandText = xem;
                //MessageBox.Show("Thanh cong");

                SqlDataReader sqldr = cmd.ExecuteReader();
                con.Dispose();
                da.Dispose();
                ds.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void dis234()
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

        }
        public void en234()
        {

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
        public void enthoihandungthuoc()
        {
            // thoi han su dung thuoc
            groupBox7.Enabled = false;
        }
        public void disthoihandungthuoc()
        {
            groupBox7.Enabled = true;

        }
        public void them3()
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into Thuoc(MaThuoc,MaNhaCC,TenThuoc) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
               // xoatext();

                cmd.Dispose();
                con.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void them()
        {

            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into Login(ID,Name,Pass) values('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
               // xoatext();

                cmd.Dispose();
                con.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            // tim kiem
            timkiem();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            // xem

            xuat();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // thêm

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // xóa

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sửa

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            // lưu



            them3();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // đóng
            this.Close();

        }

        private void FrmThuoc_Load(object sender, EventArgs e)
        {
            radioButton5.Checked = true;

            button2.Enabled = false;
            button6.Enabled = false;
            groupBox3.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;


            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            capnhat1();
           // capnhat();
            capnhat2();
            xoa123();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiocheck();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiocheck();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radiocheck();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sua();
            textBox3.Text = "";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            xoa1();
            textBox2.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timkiem();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            xuat2();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            timkiemtheoHSD();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            timkiemtheonam();

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
            timkiemtheonam();


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
            timkiemtheoHSD();

        }
    }
}
