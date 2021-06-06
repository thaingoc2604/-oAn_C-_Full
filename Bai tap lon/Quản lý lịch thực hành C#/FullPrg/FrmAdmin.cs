using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;


namespace FullPrg
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string chuoi;

        string ketnoi = "server=(local);user=sa;password=sa;database=Pro10";
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // do du lieu vao datagrid xem thong tin hang
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from DangNhap";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                groupBox2.Text = "Số người sử dụng  : " + ds.Tables[0].Rows.Count.ToString();

                DataTable dat = new DataTable();
                    listView1.BeginUpdate();
              // listView1.begin
                    foreach (DataRow dr in dat.Rows)
                    {
                    ListViewItem listItem = new ListViewItem(dr["Name"].ToString());
                    listItem.ImageIndex = 0;
                    listView1.Items.Add(listItem);
                    }

                    if (listView1.Columns.Count == 0)
                    {
                    listView1.Columns.Add("Product", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Description", 100, HorizontalAlignment.Left);
                    }
                    listView1.EndUpdate();
                    












                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();


            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from DangNhap where Active='"+0+"'";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                groupBox2.Text = "Số người sử dụng  : " + ds.Tables[0].Rows.Count.ToString();

                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();


            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Điền mã người sử dụng và chức vụ sau đó nhấn connect để click hoạt chức năng thành viên");

            textBox1.Focus();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from DangNhap";


            try
            {
                chuoi = "update DangNhap set Active='" + 1+ "',ViTri='"+comboBox1.Text+"' where ID='" + textBox1.Text + "'";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã click hoạt tài khoản  ");
            //    textBox1.Visible = false;





                da = new SqlDataAdapter(xuat, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();


            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                string xoa = "delete from DangNhap where ID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = xoa;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Da xoa thanh cong ");
                // hiendulieu();
                textBox1.Text = "";
                textBox1.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from DangNhap";


            try
            {
                chuoi = "update DangNhap set Active='" + 0 + "',ViTri='" + comboBox1.Text + "' where ID='" + textBox1.Text + "'";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã click hoạt tài khoản  ");
               // textBox1.Visible = false;





                da = new SqlDataAdapter(xuat, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();


            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }
        }
    }
}
