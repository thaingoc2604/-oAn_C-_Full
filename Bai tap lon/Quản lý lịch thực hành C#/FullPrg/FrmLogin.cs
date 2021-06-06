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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
     //   SqlDataAdapter da;
     //   DataSet ds;
        
       // DataTable dtb;
        string ketnoi = "server=(local);user=sa;password=sa;database=Pro10";
        string chuoi;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Bạn đăng nhập với toàn quyền sử dụng ", "Admin access to data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain obj = (FrmMain)this.MdiParent;
                obj.enablefull();
                obj.mnnguoidung.Text = "Người sử dụng: "+textBox1.Text;
                this.Close();

            }
            else{
                try
                {
                    con = new SqlConnection(ketnoi);
                    con.Open();
                    cmd = new SqlCommand();
                    chuoi="select*from DangNhap where Name='"+textBox1.Text+"'and Pass='"+textBox2.Text+"'and ViTri='"+comboBox1.Text+"'and Active='"+textBox3.Text+"'";
                    cmd.CommandText = chuoi;
                    cmd.Connection = con;
                    SqlDataReader sqldr = cmd.ExecuteReader();
                    if (sqldr.Read())
                    {
                        MessageBox.Show("Đăng nhập thành công, bạn có thể sử dụng các chức năng của chương trình");
                        if (comboBox1.Text == "Mod")
                        {
                            FrmMain frm = (FrmMain)this.MdiParent;
                            frm.enablenhaphang();
                            frm.enabletimkiem();
                            frm.dangxuathien();
                            frm.mnnguoidung.Text = "Người sử dụng: " + textBox1.Text;
                            frm.enablebanhang();
                            this.Close();
                        
                        }
                        if (comboBox1.Text == "NV BH")
                        {
                            FrmMain obj = (FrmMain)this.MdiParent;
                            obj.enablebanhang();
                            obj.mnnguoidung.Text = "Người sử dụng: " + textBox1.Text;
                            obj.dangxuathien();
                            this.Close();


                        }
                        if (comboBox1.Text == "NV NH")
                        {
                            FrmMain obj = (FrmMain)this.MdiParent;
                            obj.enablenhaphang();
                            obj.dangxuathien();
                            obj.mnnguoidung.Text = "Người sử dụng: " + textBox1.Text;
                            this.Close();

                        }
                        if (comboBox1.Text == "Khach")
                        {
                            FrmMain obj = (FrmMain)this.MdiParent;
                            obj.enablekhach();
                            obj.dangxuathien();
                            obj.mnnguoidung.Text = "Người sử dụng: " + textBox1.Text;
                         //   obj.mnnguoidung.Text = textBox1.Text;
                            this.Close();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại các thông tin đi nào"," K ế t nối thất bại ");
                    }
                    con.Dispose();
                    cmd.Dispose();
                    //da.Dispose();
                    sqldr.Dispose();


                }
                catch (Exception i)
                {
                    MessageBox.Show("Lỗi do người dùng  .....^^ " + i.Message);
                }



            }



        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            
            timer1.Enabled = true;

            textBox1.Focus();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           // textBox4.Text = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Focus();

        }
        int index = -1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < imageList1.Images.Count - 1) index++;

            timer1.Enabled = false;
            timer1.Interval = 1200;
            
            pictureBox1.Image = imageList1.Images[index];
            //pictureBox1.Image = imageList1.Images[index];
            //  pictureBox1.Image = imageList1.Images[index];
            timer1.Enabled = true;

            //Hiển thị Form chính sau 7 giây
            if (index == 64)
            {
                //timer1.Stop();
                //this.Hide();
                index = 1;
                //   frmMain frmM = new frmMain();
                // frmM.ShowDialog();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (index < imageList1.Images.Count - 1) index++;

            timer1.Enabled = false;
            timer1.Interval = 1200;

            pictureBox1.Image = imageList1.Images[index];
            //pictureBox1.Image = imageList1.Images[index];
            //  pictureBox1.Image = imageList1.Images[index];
            timer1.Enabled = true;

            //Hiển thị Form chính sau 7 giây
            if (index == 36)
            {
                //timer1.Stop();
                //this.Hide();
                index = 1;
                //   frmMain frmM = new frmMain();
                // frmM.ShowDialog();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
