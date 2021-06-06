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
    
        
    public partial class FrmHang : Form
    {
        public FrmHang()
        {
            InitializeComponent();
        }
        int gianum;
        int luongnum;
        int tong;
        string tongs;
      //  int ttt;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string ketnoi = "server=(local);user=sa;password=sa;database=Pro10";
       // DataTable dta;
        public void xemhang()
        {
            // do du lieu vao datagrid xem thong tin hang
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from HangInfo";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                // toolStripStatusLabel1.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
                label18.Text = "Tổng số hàng: " + ds.Tables[0].Rows.Count.ToString();
                label10.Text = " Mã phiếu : " + textBox1.Text;
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
        string chuoi;
        public void thanhtien()
        {
            try
            {
                
                //if (radioButton1.Checked == true)
                //{
                //    gianum = gianum * 100;
                //}
                //if (radioButton2.Checked == true)
                //{
                //    gianum = gianum * 1000;
                //}

                gianum = int.Parse(textBox5.Text);
                luongnum = int.Parse(textBox6.Text);
                tong = gianum * luongnum;
                tongs = Convert.ToString(tong);

            }
            catch (Exception exx)
            {
                MessageBox.Show("Tran so " + exx.Message);
            }

        }
        public void hien()
        {


            // do du lieu vao datagrid xem thong tin hang
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from HoaDonNhap";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
               // toolStripStatusLabel1.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
                label18.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
                label10.Text = " Mã phiếu : " + textBox1.Text;
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
        public void xoatat()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // MA HOA DON

           // label10.Text =" Mã phiếu : "+ textBox1.Text;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // NHA CUNG CAP
            if (comboBox1.Text == "Other")
            {
                // show txt iput name 
                textBox2.Visible = true;
                label12.Text = "Nhà cung cấp : " + textBox2.Text;

            }
            if (comboBox1.Text == "Quang Ninh")
            {
                label12.Text = "Nhà cung cấp : " + comboBox1.Text;
                textBox2.Visible = false;

            }
            if (comboBox1.Text == "Vinh Phuc")
            {
                label12.Text = "Nhà cung cấp : " + comboBox1.Text;
                textBox2.Visible = false;

            }
            if (comboBox1.Text == "Ha Noi")
            {
                label12.Text = "Nhà cung cấp : " + comboBox1.Text;
                textBox2.Visible = false;
                groupBox6.Enabled = true;
                groupBox7.Visible = true;
                textBox14.Text = comboBox1.Text;

            }

            textBox14.Text = comboBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label12.Text = "Nhà cung cấp : " + textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label13.Text = " Mã sản phẩm : " + textBox3.Text;
            textBox9.Text = textBox3.Text;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label14.Text = " Tên sản phẩm : " + textBox4.Text;
            textBox10.Text = textBox4.Text;

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "DVD")
            {
                label15.Text = "Loại sản phẩm : "+comboBox2.Text;

            }
            if (comboBox2.Text == "VCD/CD")
            {
                label15.Text = "Loại sản phẩm : " + comboBox2.Text;
            }
            if (comboBox2.Text == "Other")
            {
                label15.Text = "Loại sản phẩm : " + comboBox2.Text;
            }
            // thực ra chỉ cần dòng lệnh label15.Text = "Loại sản phẩm : "+comboBox2.Text; là xong :)) 
            textBox11.Text = comboBox2.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label16.Text = "Giá : " + textBox5.Text;
                textBox12.Text = textBox5.Text;

                if (radioButton1.Checked == true)
                {
                    
                    textBox7.Text = tongs + ",000";
                }
                if (radioButton2.Checked == true)
                {
                    
                    textBox7.Text = tongs + "0,000";
                }
                thanhtien();
                textBox7.Text = tongs;
                label20.Text = "Tong tien : " + textBox7.Text;
               // textBox12.Text = textBox7.Text;
                //textBox12.Text = textBox7.Text;


            }
            catch (Exception eee)
            {
                MessageBox.Show("Tran so rui " + eee.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked == true)
                {

                    textBox7.Text = tongs + ",000 vnd ";
                }
                if (radioButton2.Checked == true)
                {

                    textBox7.Text = tongs + "0,000 vnd ";
                }
                label17.Text = "Số lượng : " + textBox6.Text;
                // tinh tien nao :))

                thanhtien();
            
                textBox7.Text = tongs;
                label20.Text = "Tong tien : " + textBox7.Text;
                textBox13.Text = textBox6.Text;

            }
            catch (Exception dd)
            {
                MessageBox.Show(" Lôi rùi " + dd.Message);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            //textBox5.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gianum = gianum * 100;
                textBox7.Text = tongs + ",000 vnd";
                label20.Text = "Tong tien : " + textBox7.Text;

            }
            if (radioButton2.Checked == true)
            {
                gianum = gianum * 1000;
                textBox7.Text = tongs + "0,000 vnd ";
                label20.Text = "Tong tien : " + textBox7.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gianum = gianum * 100;
                textBox7.Text = tongs + ",000 vnd";
                label20.Text = "Tong tien : " + textBox7.Text;

            }
            if (radioButton2.Checked == true)
            {
                gianum = gianum * 1000;
                textBox7.Text = tongs + "0,000 vnd ";
                label20.Text = "Tong tien : " + textBox7.Text;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = "Ngày lập : " +dateTimePicker1.Value.ToShortDateString();
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

        private void FrmHang_Load(object sender, EventArgs e)
        {
            hien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoatat();
           // textBox1.Enabled = true;
            textBox2.Enabled = true;

            textBox3.Enabled = true;

            textBox4.Enabled = true;

            textBox5.Enabled = true;
            textBox6.Enabled = true;

            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // them

            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HoaDonNhap";


            try
            {
                chuoi = "insert into HoaDonNhap(NCC,Ngay,MaSP,TenSP,Loai,Gia,SoLuong,ThanhTien) values ('" + comboBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";//,'" + dateTimePicker1.Value.ToShortDateString + "')";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them moi thanh cong ");

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

        private void button7_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HoaDonNhap";


            try
            {
                chuoi = "update HoaDonNhap set TenSP='" + textBox4.Text + "',NCC='"+comboBox1.Text+"',Ngay='"+dateTimePicker1.Value.ToShortDateString()+"' where IDNhap='" + textBox1.Text + "'";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sua thanh cong ");
                textBox1.Visible = false;





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
            textBox1.Enabled = true;

            comboBox2.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = false;
            button7.Enabled = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == ">>")
            {
                this.Height = 637;
                this.Width = 766;
                button6.Text = "<<";
            }
            else{
               
                    this.Height=637;
                this.Width=514;
                button6.Text = ">>";


            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // do du lieu vao datagrid xem thong tin hang
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from HangInfo";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                // toolStripStatusLabel1.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
                label18.Text = "Tổng số hàng: " + ds.Tables[0].Rows.Count.ToString();
                label10.Text = " Mã phiếu : " + textBox1.Text;
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

        private void button11_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            button12.Enabled = true;
          //  textBox12.Enabled = true;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HangInfo";

            //

           
            try
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Nhập mã hàng cần xóa ");
                    textBox8.Focus();
                }
                else
                {

                    string xoa = "delete from HangInfo where IDHang='" + textBox8.Text + "'";
                    // SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = xoa;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Da xoa thanh cong ");



                    textBox8.Enabled = false;

                    da = new SqlDataAdapter(xuat, con);
                    ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    con.Dispose();
                    cmd.Dispose();
                    ds.Dispose();
                    da.Dispose();
                    xemhang();
                }

            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // them

            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HangInfo";


            try
            {
                chuoi = "insert into HangInfo(MaSp,TenSP,Loai,Gia,SoLuongNhap,NCC) values ('" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text+ "','"+textBox14.Text+"')";//,'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";//,'" + dateTimePicker1.Value.ToShortDateString + "')";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them moi thanh cong ");

                da = new SqlDataAdapter(xuat, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();

                xemhang();
            }
            catch (Exception eee)
            {
                MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nhấn Yes để đóng cửa sổ làm việc ", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == ">>")
            {
                this.Height = 637;
                this.Width = 766;
                button13.Text = "<<";
            }
            else
            {

                this.Height = 637;
                this.Width = 514;
                button13.Text = ">>";


            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Xem thông tin hóa đơn nhập  +\n";

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label19.Text = " xóa các ô nhập liệu +\n hỗ trợ cho việc thêm dữ liệu";
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Thêm hóa đơn hàng vào kho+\n";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label19.Text = " Điền thông tin vào và nhấn nút save để có hiệu lực +\n";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Lưu thông tin thay đổi+\n lưu";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  In hóa đơn nhập +\nBáo cáo chi tiết";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Phóng to+\n Thu nhỏ cửa sổ làm việc";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label19.Text = " Bạn sẽ thoát khởi chương trình +\n";
        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Tăng giá tiền lên 1000+\n Nhấn cái này sau khi nhập giá tiền mới có hiệu lực";
        }

        private void radioButton2_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Tăng giá tiền lên 10.000 +\n Nhấn sau khi điền giá tiền nhé";
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Thêm mới nhà cung cấp +\nChỉ admin mới có quyền thêm";
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Chọn nhà cung cấp hàng+\n";
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            label19.Text = " Lựa chọn mặt hàng +\n";
        }

        private void tabControl1_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "  Thêm hàng vào kho hàng... +\n Dữ liệu được truyền từ phiếu nhập vào";
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Thông tin đĩa trong kho +\n";
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Thêm số lượng nhập vào kho +\n";
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Xóa thông tin đĩa nhập +\n Nhấn lưu để có hiệu quả";
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Lưu lại các thay đổi trong kho hàng+\n";
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Thoát khỏi khu vực nhập hàng+\n";
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
             label19.Text = "  Thu nhỏ cửa sổ+\n";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
             label19.Text = " Chức năng đang xây dựng  +\n, hình ảnh chỉ mang tính mình họa";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";

        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
             label19.Text = "O la la. Chuong trình quản lý cửa hàng băng đĩa";
        }
    }
}
