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
    public partial class FrmBan : Form
    {
        public FrmBan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmBan_Load(object sender, EventArgs e)
        {
            groupBox9.Enabled = false;
            groupBox13.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                        string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into DongPhieuBan(ID,MaNhaCC,LoaiThuocBan,TongBan,DonGiaBan,TongTien) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
                // xoatext();

                string xuat1 = "select*from DongPhieuBan";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];


                cmd.Dispose();
                con.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
                  if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
                  if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
                  if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {
            
                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
              string str1 = "delete from DongPhieuBan where ID='" + textBox1.Text + "'";//set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Xoa thanh cong");


                string xuat1 = "select*from DongPhieuBan";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

        }

            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            try
            {
                // sua theo ten thuoc


                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "update DongPhieuBan set ID='" + textBox1.Text + "' where LoaiThuocBan='" + textBox3.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from DongPhieuBan";

                SqlDataAdapter da = new SqlDataAdapter(xuat1, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];


            }

            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui long dien thong tin vao truoc khi su dung chuc nang khac ");

            }
            else
            {
                groupBox9.Enabled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox9.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSDL đã được backup. Bạn có thể xem thống kê hóa đơn");
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                MessageBox.Show("Vui long dien thong tin vao truoc khi su dung chuc nang khac ");

            }
            else
            {
                groupBox13.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox13.Enabled = false;
            textBox1.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox9.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;

            textBox10.Text = "";
            textBox11.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox12.Text = "";
            textBox7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into DongPhieuBan(ID,MaNhaCC,LoaiThuocBan,TongBan,DonGiaBan,TongTien) values('" + textBox12.Text + "','" + textBox11.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
                // xoatext();

                string xuat1 = "select*from DongPhieuBan";

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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "delete from DongPhieuBan where ID='" + textBox12.Text + "'";//set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Xoa thanh cong");


                string xuat1 = "select*from DongPhieuBan";

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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            try
            {
                // sua theo ten thuoc


                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "update DongPhieuBan set ID='" + textBox12.Text + "' where LoaiThuocBan='" + textBox9.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from DongPhieuBan";

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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuc nang đang được xây đựng");

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
