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
    public partial class FrmFind : Form
    {
        public FrmFind()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string ketnoi = "server=(local);user=sa;password=sa;database=Pro10";
       // string chuoi;
        public void tenkhach()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();

            try
            {

                string chuoi = "select*from HoaDonBan1 where TenKhach like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
             //   label4.Text = "Dang kiem thong tin khach tai hoa don ";
                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void nhacungcap()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonNhap where NCC like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();

                //sqlcom.ExecuteNonQuery();
                label3.Text = "Dang tim trong Hoa Don Nhap ";

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
             //   dataGridView1.DataSource = ds.Tables[0];
                //label4.Text = "Đang tìm thông tin về nhà cung cấp tại Hóa đơn nhập ";

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void donban()
        {

            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand(); 
            con.Open();

            try
            {

                string chuoi = "select*from HoaDonBan1 where Loai like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();

                //sqlcom.ExecuteNonQuery();
                //label3.Text = "Dang kiem thong tin hoa don ban ";

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
 //               dataGridView1.DataSource = ds.Tables[0];
  //              dataGridView2.DataSource = ds.Tables[0];
                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void donnhap()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonNhap where TenSP like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                //label4.Text = "Đang tìm thông tin theo tên sản phẩm trong hóa đơn nhập hàng ";

                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
   //             dataGridView1.DataSource = ds.Tables[0];

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void tenSP()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonBan1 where MaSP like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                //cmd.ExecuteNonQuery();
                //label3.Text = "Đang tìm thông tin theo mã sản phẩm của hóa đơn bán ";

                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
 //               dataGridView1.DataSource = ds.Tables[0];

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void maSP()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonBan1 where MaSP like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                //label4.Text = "Đang tìm thông tin theo mã sản phẩm tại hóa đơn nhập ";
                //label3.Text = "Đang tìm thông tin theo mã sản phẩm tại hóa đơn nhập ";
                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
  //              dataGridView1.DataSource = ds.Tables[0];

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void gia()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonNhap where Gia like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();

                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
  //              dataGridView1.DataSource = ds.Tables[0];
                //label3.Text = "Đang tìm thông tin theo giá , trong hóa đơn nhập ";
                //label4.Text = "Đang tìm thông tin theo giá , trong hóa đơn nhập ";
                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void thoigian()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonBan1 where Ngay like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();

                //sqlcom.ExecuteNonQuery();
                //label3.Text = "Đang tìm thông tin theo thời gian của hóa đơn bán ";
                //label4.Text = "Đang tìm thông tin theo thời gian của hóa đơn bán ";
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
  //              dataGridView1.DataSource = ds.Tables[0];

                // hiendulieu();
                // xoatx();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void id()
        {
              con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonBan1 where IDHoaDon like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();

                //sqlcom.ExecuteNonQuery();
                //label3.Text = "Đang tìm thông tin theo mã đơn bán hàng ";
                //label4.Text = "Đang tìm thông tin theo mã đơn bán hàng ";
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
 //               dataGridView2.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void loaisp()
        {
            con = new SqlConnection(ketnoi);
            cmd = new SqlCommand();
            con.Open();
            try
            {

                string chuoi = "select*from HoaDonNhap where Loai like '%" + textBox1.Text + "%'";// where DiaID='" + textBox2.Text + "'";//and RePass='"+txtpassmoi2.Text+"'";
                //where tensv like %"+txtTen.Text+"%";
                cmd.Connection = con;
                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                //label3.Text = "Đang tìm thông tin theo loại sản phẩm ( DVD, CD, ....) ";
                //label4.Text = "Đang tìm thông tin theo loại sản phẩm ( DVD, CD, ....) ";
                //sqlcom.ExecuteNonQuery();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                //               dataGridView2.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmFind_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {//
           /*
            Nha Cung Cap
Khach Hang
Don Ban
Don Nhap
Ten San Pham
Loai San Pham
Gia
Ngay
            * */

    //

            if (comboBox1.Text == "Nha Cung Cap")
            {
                nhacungcap();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Đang tìm thông tin về nhà cung cấp tại Hóa đơn nhập ";
                id();
                dataGridView2.DataSource = ds.Tables[0];
                tenkhach();
                donban();
                donnhap();
                maSP();
                tenSP();
                gia();
                thoigian();
                loaisp();




            }

            if (comboBox1.Text == "Khach Hang")
            {
                nhacungcap();
                dataGridView2.DataSource = ds.Tables[0];
                label4.Text = "Đang tìm thông tin về nhà cung cấp tại Hóa đơn nhập ";
                id();
                tenkhach();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Dang kiem thong tin khach tai hoa don ";
                donban();
                donnhap();
                maSP(); loaisp();
                tenSP();
                gia();
                thoigian();
            }

            if (comboBox1.Text == "Don Ban")
            {
                nhacungcap();
                dataGridView2.DataSource = ds.Tables[0];
                label4.Text = "Đang tìm thông tin về nhà cung cấp tại Hóa đơn nhập ";
                id();
                tenkhach();
                donban(); 
                loaisp();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Dang kiem thong tin hoa don ban ";

                donnhap();
                maSP();
                tenSP();
                gia();
                thoigian();
            }

            if (comboBox1.Text == "Don Nhap")
            {
                nhacungcap();
                dataGridView2.DataSource = ds.Tables[0];
                label4.Text = "Đang tìm thông tin về nhà cung cấp tại Hóa đơn nhập ";
                id();
                tenkhach();
                donban(); 
                loaisp();

                donnhap();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Đang tìm thông tin theo tên sản phẩm trong hóa đơn nhập hàng ";
                maSP();
                tenSP();
                gia();
                thoigian();
            }

            if (comboBox1.Text == "Ten San Pham")
            {
                nhacungcap();
                id(); 
                loaisp();
                tenkhach();
                dataGridView2.DataSource = ds.Tables[0];
                donban();
                donnhap();
                maSP();
                tenSP();
                dataGridView1.DataSource = ds.Tables[0];

                label3.Text = "Đang tìm thông tin theo mã sản phẩm của hóa đơn bán ";
                gia();

                thoigian();
            }

            if (comboBox1.Text == "Gia")
            {
                nhacungcap();
                id();
                dataGridView2.DataSource = ds.Tables[0];
                label4.Text = "Đang tìm thông tin theo mã đơn bán hàng ";
                tenkhach();
                donban(); 
                loaisp(); 
             
                donnhap();
                maSP();
                tenSP();
                gia();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Đang tìm thông tin theo giá , trong hóa đơn nhập ";
                thoigian();
                //dataGridView2.DataSource = ds.Tables[0];
            }
            if (comboBox1.Text == "Loai San Pham")
            {
                loaisp(); 
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Đang tìm thông tin theo loại sản phẩm ( DVD, CD, ....) ";
                nhacungcap();
                id();
                tenkhach();
                donban();
                donnhap();
                maSP();
                dataGridView2.DataSource = ds.Tables[0];

                tenSP();
                gia();
                thoigian();
            }
            if (comboBox1.Text == "Ngay")
            {
                nhacungcap();
                id();
                tenkhach(); loaisp();
                donban();
                dataGridView2.DataSource = ds.Tables[0];

                label4.Text = "Dang kiem thong tin hoa don ban ";
                donnhap();
                maSP();
                tenSP();
                gia();
                thoigian();
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Đang tìm thông tin theo thời gian của hóa đơn bán ";

            }








        }
    }
}
