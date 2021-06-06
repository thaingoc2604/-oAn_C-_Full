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
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
//using System.Drawing.Printing;



namespace FullPrg
{
    public partial class FrmBUY : Form
    {
        public FrmBUY()
        {
            InitializeComponent();
        }
        //int soluong1;
        //int soluong2;

        //int gia1;
        //int gia2;

        int tien1;
        int tien2;
        int so11;
        int so12;
        int so21;
        int so22;
        double tong;
        double tongfull;
        int so31;
        int so32;

        // bien dung chung

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string ketnoi="server=(local);user=sa;password=sa;database=Pro10";
        //DataTable dta;
       
                       string chuoi;

        /*
         *  tien1= soluong1 x gia 1
         *  tien2= soluong2 x gia 2
         *  
         *  soluong1 = textBox7
         *  gia1= textbox 6
         *  soluong2= textBox8
         *  gia2=textbox9
         *  /
         *  */
        public void tinhtien1()
        {
            try
            {
                so11 = int.Parse(textBox6.Text);
                so12 = int.Parse(textBox7.Text);
                tien1 = so11 * so12;
                // tinh tien san pham 1
                toolStripStatusLabel2.Text = Convert.ToString(tien1);
                toolStripStatusLabel4.Text = Convert.ToString(tien2);
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }
        public void tinhtien2()
        {
            try
            {
                so21 = int.Parse(textBox9.Text);
                so22 = int.Parse(textBox8.Text);
                tien2 = so22 * so21;
                // tinh tien san pham 2
                toolStripStatusLabel3.Text = Convert.ToString(tien2);
            }
            catch (Exception edd)
            {
                MessageBox.Show("Nhap so vao nhe :" + edd.Message);
            }

        }
       
        public void tientien()
        {
            //tong = int.Parse(tien1 + tien2);
        }

        public void tongtien()
        {
            so31 = int.Parse(label33.Text);
            so32 = int.Parse(label47.Text);
            tongfull = so31 + so32;
          //  label55.Text = Convert.ToString(tongfull);
      //      toolStripStatusLabel4.Text = Convert.ToString(tongfull);
            
            tong = tongfull;
            // gia 1 =33
            // gia 2 =47
            toolStripStatusLabel4.Text = Convert.ToString(tong);
            label49.Text = Convert.ToString(tongfull);
        }
        private void FrmBUY_Load(object sender, EventArgs e)
        {




            groupBox5.Enabled = false;
            // this.Height=433;
            //this.Width=457;
          //  Application.DoEvents();
            tabControl1.Height=457;
            tabControl1.Width=433;

            // check combobox
            //if (comboBox1.TextChanged = "")
            //{
            //    textBox6.Text= "000";
            //}
            //if (comboBox1.TextChanged == "DVD")
            //{
            //    textBox6.Text = "12000";
            //}
            //if (comboBox1.TextChanged == "VCD")
            //{
            //    textBox6.Text = "6000";
            //}
            //if (comboBox1.TextChanged == "Other")
            //{
            //    textBox6.Text = "5000";
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == ">>")
            {
                groupBox6.Visible = true;
                groupBox2.Visible = true;
                groupBox4.Visible = true;
                button2.Text = "<<";
            }
            else
            {
                groupBox6.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                button2.Text = ">>";
            }
            //float i = 0;
            //if (button2.Text == "button2")
            //{
            //    while (this.Height > 457)
            //    {
            //        i += 0.5f;
            //        this.Height -= (int)i;
            //        Application.DoEvents();
            //        button2.Text = "HE";
            //    }
            //}
            //else
            //{
            //    while (this.Height < 200)
            //    {
            //        i -= 0.5f;
            //        this.Height += (int)i;
            //        Application.DoEvents();
            //        button2.Text = "button2";
            //    }

            }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
             //check combobox
            if (comboBox1.Text == "")
            {
                textBox6.Text= "000";
                label44.Text = comboBox1.Text;
                label29.Text = textBox6.Text;


            }
            if (comboBox1.Text == "DVD")
            {
                textBox6.Text = "12000";
                label44.Text = comboBox1.Text;
                label29.Text = textBox6.Text;
            }
            if (comboBox1.Text == "VCD")
            {
                textBox6.Text = "6000";
                label44.Text = comboBox1.Text;
                label29.Text = textBox6.Text;
            }
            if (comboBox1.Text == "Other")
            {
                textBox6.Text = "5000";
                label44.Text = comboBox1.Text;
                label29.Text = textBox6.Text;
            }
            label54.Text = comboBox1.Text + ", " + comboBox2.Text;
            textBox7.Enabled = true;
            tinhtien1();
        //    label55.Text = Convert.ToString(tien1)+"+ ";
               
            //label55.Text = Convert.ToString(tong);
       //     toolStripStatusLabel2.Text = Convert.ToString(tien1);

        tongtien();

          //toolStripStatusLabel4.Text = Convert.ToString(tong);
        }
             
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)||!char.IsNumber(e.KeyChar))
            {

                e.Handled=true;
        }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            //check combobox
            if (comboBox2.Text == "")
            {
                textBox9.Text = "000";
                label45.Text = comboBox2.Text;
                label42.Text = textBox9.Text;
            }
            if (comboBox2.Text == "DVD")
            {
                textBox9.Text = "12000";
                //label54.Text = comboBox2.Text+", "+comboBox1.Text;
                label42.Text = textBox9.Text;
                label45.Text = comboBox2.Text;
            }
            if (comboBox2.Text == "VCD")
            {
                textBox9.Text = "6000";
                label42.Text = textBox9.Text;
                label45.Text = comboBox2.Text;
            }
            if (comboBox2.Text == "Other")
            {
                textBox9.Text = "5000";
                label45.Text = comboBox2.Text;

            }
            label54.Text = comboBox1.Text + ", " + comboBox2.Text;
            tinhtien2();
            //label56.Text = Convert.ToString(tien2);
            toolStripStatusLabel3.Text = Convert.ToString(tien2);
            tongtien();

     //  toolStripStatusLabel4.Text = Convert.ToString(tong);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled= true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       //     label19.Text = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label22.Text = textBox3.Text;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label35.Text = dateTimePicker1.Value.ToShortDateString();
            //label1.Text = dateTimePicker1.Value.ToShortDateString();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label23.Text = textBox4.Text;
            label51.Text = textBox4.Text + ", " + textBox11.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label25.Text = textBox5.Text;
            label52.Text = textBox5.Text + ", " + textBox10.Text;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label27.Text = textBox7.Text;
            // tinh gia tien luon
          // gia tinh theo :  textBox6.Text
            tinhtien1();
            label33.Text = Convert.ToString(tien1);
            label49.Text = Convert.ToString(tong);
          //  toolStripStatusLabel2.Text = Convert.ToString(tien1);
          //  tongfull();
            //tinhtien2();
          //  tongfull();
            
          //  tinhtien1();
          //  label55.Text = Convert.ToString(tien1)+" +";
          // label55.Text = label49.Text;
            label53.Text = textBox7.Text + ", " + textBox8.Text;

            tongtien();

          //  gia1 = int.Parse(tongfull);


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
            // tinh gia tin luon

            label41.Text = textBox8.Text;
            tinhtien2();
            label47.Text = Convert.ToString(tien2);
            label53.Text = textBox7.Text + ", " + textBox8.Text;
            toolStripStatusLabel3.Text = Convert.ToString(tien2);
            //label55.Text = Convert.ToString(tong);
            tinhtien2();
            ////label56.Text = Convert.ToString(tien2);
            tongtien();


            //tongtien();
            //label55.Text = label49.Text;
            //label55.Text = Convert.ToString(tong);
           
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label38.Text = textBox11.Text;

            label51.Text = textBox4.Text + ", " + textBox11.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label40.Text = textBox10.Text;
            label52.Text = textBox5.Text + ", " + textBox10.Text;

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tongtien();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = CreateGraphics();
            Image memImage = new Bitmap(Size.Width, Size.Height, graphic);
            Graphics memGraphic = Graphics.FromImage(memImage);

            IntPtr dc1 = graphic.GetHdc();
            IntPtr dc2 = memGraphic.GetHdc();
          // graphic(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);

       //     BitBlt(dc2, 0, 0, ClientRectangle.Width,ClientRectangle.Height, dc1, 0, 0, 13369376);

            graphic.ReleaseHdc(dc1);
            memGraphic.ReleaseHdc(dc2);
            e.Graphics.DrawImage(memImage, 0, 0);


        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // do du lieu vao datagrid xem thong tin hang
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            chuoi = "select*from HoaDonBan1";
            cmd.CommandText = chuoi;
            try
            {
                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
                con.Dispose();
                cmd.Dispose();
                ds.Dispose();
                da.Dispose();
                textBox1.Text = "";
               // textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

               // textBox6.Text = "";
               // textBox7.Text = "";

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
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HoaDonBan1";


            try
            {
                chuoi = "insert into HoaDonBan1(TenKhach,Ngay,MaSP,TenSP,Loai,SoLuong,ThanhTien) values ('" + textBox3.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + label51.Text + "','" + label52.Text + "','" + label54.Text + "','" + label53.Text + "','" + toolStripStatusLabel4.Text + "')";//,'" + dateTimePicker1.Value.ToShortDateString + "')";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong ");

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

        private void label49_TextChanged(object sender, EventArgs e)
        {
         //   label55.Text = label49.Text;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tinhtien1();
            //label55.Text = Convert.ToString(tien1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HoaDonBan1";


            try
            {
                chuoi = "update HoaDonBan1 set TenKhach='" + textBox3.Text + "',MaSP='" + label51.Text + "',TenSP='" + label52.Text + "',Loai='" + label54.Text + "',SoLuong='" + label53.Text + "',ThanhTien='" + toolStripStatusLabel4.Text + "',Ngay='" + dateTimePicker1.Value.ToShortDateString() + "' where IDHoaDon='" + textBox1.Text + "'";

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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
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
                dataGridView1.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = "Tổng số hóa đơn : " + ds.Tables[0].Rows.Count.ToString();
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

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Visible= true;
            textBox7.Enabled = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string xuat = "select *from HangInfo ";


            try
            {
                chuoi = "update HangInfo set SoLuongBan='" + textBox7.Text+ "' where IDHang='" + textBox1.Text + "'";

                cmd.CommandText = chuoi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm vào kho rùi : >");
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text= "Chức năng này dùng để xem thông tin dữ liệu trong hóa đơn hàng. Bạn có thể biêt về số lượng hóa đơn đã bán. Chức năng này còn xóa hết dữ liệu trong các ô textbox bên trái màn hỉnh. Giúp bạn thao tác dễ dàng hơn trong quá trình thêm mới hóa đơn vào.";

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
             richTextBox1.Visible = false;

             richTextBox1.Text = "";

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
             richTextBox1.Visible = true;

             richTextBox1.Text = "Bạn sẽ thêm hóa đơn bán vào cơ sở dữ liệu nếu nhấn nút này. Lưu ý là bạn hãy điền hết thông tin dữ liệu vào các ô bên tay trái của mình. Thêm thông tin sản phẩm 1 vào . nếu có thêm sản phẩm nữa bạn hãy click vào nut thêm Sp. Tiếp theo bạn hãy điền thông tin của sản phẩm 2 vào là ok. Lưu ý: điền số lượng sản phẩm 2 rùi mới được click vào nút x1000 hay x10.000. Khi điền đầy đủ thông tin vào thì bạn hãy nhấn nút thêm sẽ thấy kết quả trong csdl";

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Nhấn vào đây để sửa thông tin hóa đơn, Chức năng này chỉ sửa thông tin theo mã ID, do vậy bạn cần điền đúng mã ID vào ô tương ứng, Ban có thể xem mã này trong phần thông tin hóa đơn bằng cách nhấn vào chức năng xem, Sau khi điền thông tin vào hãy nhấn vào nút lưu để việc thay đổi dữ liệu được click hoạt.";
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

             richTextBox1.Text = "Chức năng này sẽ lưu lại quá trình bạn thay đổi dữ liệu";

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

             richTextBox1.Text = "Mở kho hàng để thêm thông tin về số lượng đĩa bán và mã đĩa bán vào kho. Nhằm quản lý số lượng đĩa còn trong kho";

        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

             richTextBox1.Text = "Bạn sẽ thêm danh sách hàng bán vào dữ liệu đĩa, ( ko phải là dữ liệu hóa đơn bán )Mọi thay đổi có hiệu lực khi bạn nhấn vào nút kho ---- :>>>>";

        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

             richTextBox1.Text = "Xem thông tin kho, thêm dữ liệu hàng bán vào trong kho.... Phải nhấn nút này sau khi click vào + và điền đầy đủ thông tin cần thiết vào các ô text bên trái màn hình";

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Bạn sẽ thoát khỏi chương trình đấy ";

        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Chọn loại sản phẩm khách mua ";

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Thêm sản phẩm thứ 2 vào trong một hóa đơn";

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
           richTextBox1.Visible = true;

           richTextBox1.Text = "Chức năng thu nhỏ và phóng to cửa sổ làm việc ";

        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Danh sách hàng";

        }

        private void tabPage2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;

            richTextBox1.Text = "Nhấn vào người lập phiếu để in hóa đơn cho khách ";

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void tabPage2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            richTextBox1.Text = "";
        }

      

       
    }
}
