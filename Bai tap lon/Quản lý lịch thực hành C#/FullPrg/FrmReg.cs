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
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        string chuoi;
        //SqlDataAdapter da;
     /// <summary>
     /// 
     /// </summary>
 //  DataSet ds;
        public void buzz(int rate)
        {
            // vị trí lúc đầu của Form
            int _locationX = this.Location.X;
            int _locationY = this.Location.Y;

            for (int i = 0; i < rate; i++)
            {
                this.Location = new Point(_locationX + 5, _locationY + 5);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX + 10, _locationY + 10);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX + 7, _locationY + 3);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(_locationX, _locationY);

            }
        }

        string ketnoi = "server=(local);user=sa;password=sa;database=Pro10";

        private void FrmReg_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            //string xuat = "select *from DangNhap";

            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show(" 2 ô mật khẩu ko giống nhau, vui lòng nhập lại ");
                textBox1.Focus();
                buzz(4);
                
            }
            else
            {

                try
                {
                    chuoi = "insert into DangNhap(Name,Pass,ViTri,Active) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";//,'" + dateTimePicker1.Value.ToShortDateString + "')";

                    cmd.CommandText = chuoi;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản mới vào CSDL.  " + textBox1.Text + "  cần chờ Admin click hoạt tài khoản mới dùng được . Thân ");

                    //da = new SqlDataAdapter(xuat, con);
                    //ds = new DataSet();
                    //da.Fill(ds);
                    //dataGridView1.DataSource = ds.Tables[0];

                    con.Dispose();
                    cmd.Dispose();
                    //ds.Dispose();
                    //da.Dispose();


                }
                catch (Exception eee)
                {
                    MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
                }
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với cửa hàng kinh doanh băng đĩa ");
            buzz(8);

        }

     
    }
}
