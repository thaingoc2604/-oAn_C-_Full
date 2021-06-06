using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuayThuoc
{
    public partial class FrmMua : Form
    {
        public FrmMua()
        {
            InitializeComponent();
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

        private void FrmMua_Load(object sender, EventArgs e)
        {
            groupBox9.Enabled = false;
          //  groupBox13.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton2.Checked = false;


            groupBox9.Enabled = false;
   
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try
            {

                string chuoithem = "insert into DonPhieuMua(ID,MaKH,LoaiThuocMua,TongMua,DonGiaMua,ThanhTien) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = chuoithem;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thanh Cong");
                // xoatext();

                string xuat1 = "select*from DonPhieuMua";

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand sqlcom = new SqlCommand();
                SqlCommand cmd = new SqlCommand();
                string str1 = "delete from DonPhieuMua where ID='" + textBox1.Text + "'";//set HSD='" + dateTimePicker2.Value.ToShortDateString() + "' where MaThuoc='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Xoa thanh cong");


                string xuat1 = "select*from DonPhieuMua";

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
                string str1 = "update DonPhieuMua set ID='" + textBox1.Text + "' where LoaiThuocMua='" + textBox3.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = str1;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Sua thanh cong");


                string xuat1 = "select*from DonPhieuMua";

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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSDL đã được backup. Bạn có thể xem thống kê hóa đơn");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }
    }
}
