using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyPhongMach
{
    public partial class SapGiuongBenh : Form
    {
        public int hehe;
        BenhNhanNamGiuong_DaXepChoDTO benhnhan_daxepcho = new BenhNhanNamGiuong_DaXepChoDTO();

        public SapGiuongBenh()
        {
            InitializeComponent();
        }

        private void Load_DataGridView()
        {
            this.dataGridView1.DataSource = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();
        }

        private void SapGiuongBenh_Load(object sender, EventArgs e)
        {
            Load_DataGridView();

            Load_DuLieu_GiuongBenh_BenhNhan();

            DragDrop_Control();
        }

        private void DragDrop_Control()
        {
            #region event textbox
            this.dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);

            this.textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            this.textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);

            this.textBox2.DragEnter += new DragEventHandler(textBox2_DragEnter);
            this.textBox2.DragDrop += new DragEventHandler(textBox2_DragDrop);

            this.textBox3.DragEnter += new DragEventHandler(textBox3_DragEnter);
            this.textBox3.DragDrop += new DragEventHandler(textBox3_DragDrop);

            this.textBox4.DragEnter += new DragEventHandler(textBox4_DragEnter);
            this.textBox4.DragDrop += new DragEventHandler(textBox4_DragDrop);

            this.textBox5.DragEnter += new DragEventHandler(textBox5_DragEnter);
            this.textBox5.DragDrop += new DragEventHandler(textBox5_DragDrop);

            this.textBox6.DragEnter += new DragEventHandler(textBox6_DragEnter);
            this.textBox6.DragDrop += new DragEventHandler(textBox6_DragDrop);

            this.textBox7.DragEnter += new DragEventHandler(textBox7_DragEnter);
            this.textBox7.DragDrop += new DragEventHandler(textBox7_DragDrop);
            #endregion
        }

        #region dragdrop textbox
        void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string temp;    

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox1.Text = benhnhan.Hoten;
                        this.picb1.Visible = true;
                        this.button1.Visible = true;
                        break;                        
                    }
                }
            }
            this.lb1sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong1.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox2.Text = benhnhan.Hoten;
                        this.picb2.Visible = true;
                        this.button2.Visible = true;
                        break;
                    }
                }
            }
            this.lb2sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGuong2.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox3.Text = benhnhan.Hoten;
                        this.picb3.Visible = true;
                        this.button3.Visible = true;
                        break;
                    }
                }
            }
            this.lb3sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong3.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox4_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox4.Text = benhnhan.Hoten;
                        this.picb4.Visible = true;
                        this.button4.Visible = true;
                        break;
                    }
                }
            }
            this.lb4sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong4.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox5_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox5.Text = benhnhan.Hoten;
                        this.picb5.Visible = true;
                        this.button5.Visible = true;
                        break;
                    }
                }
            }
            this.lb5sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong5.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox6_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox6.Text = benhnhan.Hoten;
                        this.picb6.Visible = true;
                        this.button6.Visible = true;
                        break;
                    }
                }
            }
            this.lb6sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong6.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        void textBox7_DragDrop(object sender, DragEventArgs e)
        {
            string temp;

            TextBox txtBox = (TextBox)sender;
            temp = (string)e.Data.GetData(DataFormats.Text);

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            listBenhNhan = BenhNhanBUS.SelectAllBenhNhanNamGiuong_ChuaXepCho();

            if (listBenhNhan.Count > 0)
            {
                foreach (BenhNhanDTO benhnhan in listBenhNhan)
                {
                    if (benhnhan.STTBN.ToString() == temp)
                    {
                        textBox7.Text = benhnhan.Hoten;
                        this.picb7.Visible = true;
                        this.button7.Visible = true;
                        break;
                    }
                }
            }
            this.lb7sttBN.Text = temp;
            benhnhan_daxepcho.STTBN = int.Parse(temp);
            benhnhan_daxepcho.sttGiuong = int.Parse(this.lbGiuong7.Text);

            BenhNhanNamGiuong_DaXepChoBUS.InsertBenhNhanNamGiuong_DaXepCho(benhnhan_daxepcho);
            Load_DataGridView();
        }

        #endregion
        #region dragenter
        void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void textBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion
        #region datagridview mousedown
        void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //this.dataGridView1.DoDragDrop(this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), DragDropEffects.Copy);
                this.dataGridView1.DoDragDrop(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), DragDropEffects.Copy);
            }
        }
        #endregion        
        #region Load dữ liệu những giường có bệnh nhân
        private void Load_DuLieu_GiuongBenh_BenhNhan()
        {
            DataTable dt = BenhNhanNamGiuong_DaXepChoBUS.SelectAllGiuongBenh_CoBenhNhan();

            if(dt.Rows.Count>0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    BenhNhanNamGiuong_DaXepChoDTO benhnhan_dxc = new BenhNhanNamGiuong_DaXepChoDTO();
                    benhnhan_dxc.STTBN = int.Parse(row["sttBN"].ToString());
                    benhnhan_dxc.Hoten = row["Tên Bệnh Nhân"].ToString();
                    benhnhan_dxc.sttGiuong = int.Parse(row["sttGB"].ToString());

                    if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong1.Text))
                    {
                        this.picb1.Visible = true;
                        this.textBox1.Text = benhnhan_dxc.Hoten;
                        this.button1.Visible = true;
                        this.lb1sttBN.Text = benhnhan_dxc.STTBN.ToString(); // chứa sttBN giường 1
                    }
                    else if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGuong2.Text))
                    {
                        this.picb2.Visible = true;
                        this.textBox2.Text = benhnhan_dxc.Hoten;
                        this.button2.Visible = true;
                        this.lb2sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                    else if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong3.Text))
                    {
                        this.picb3.Visible = true;
                        this.textBox3.Text = benhnhan_dxc.Hoten;
                        this.button3.Visible = true;
                        this.lb3sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                    else if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong4.Text))
                    {
                        this.picb4.Visible = true;
                        this.textBox4.Text = benhnhan_dxc.Hoten;
                        this.button4.Visible = true;
                        this.lb4sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                    else if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong5.Text))
                    {
                        this.picb5.Visible = true;
                        this.textBox5.Text = benhnhan_dxc.Hoten;
                        this.button5.Visible = true;
                        this.lb5sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                    else if (benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong6.Text))
                    {
                        this.picb6.Visible = true;
                        this.textBox6.Text = benhnhan_dxc.Hoten;
                        this.button6.Visible = true;
                        this.lb6sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                    else if(benhnhan_dxc.sttGiuong == int.Parse(this.lbGiuong7.Text))
                    {
                        this.picb7.Visible = true;
                        this.textBox7.Text = benhnhan_dxc.Hoten;
                        this.button7.Visible = true;
                        this.lb7sttBN.Text = benhnhan_dxc.STTBN.ToString();
                    }
                }
            }
        }
        #endregion
        #region button xóa click
        private void button1_Click(object sender, EventArgs e) // xóa dl trên giường 1
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb1sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 1;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb1.Visible = false;
                this.textBox1.Text = string.Empty;
                this.lb1sttBN.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb2sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 2;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb2.Visible = false;
                this.textBox2.Text = string.Empty;
                this.lb2sttBN.Text = string.Empty;
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb3sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 3;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb3.Visible = false;
                this.textBox3.Text = string.Empty;
                this.lb3sttBN.Text = string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb4sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 4;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb4.Visible = false;
                this.textBox4.Text = string.Empty;
                this.lb4sttBN.Text = string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb5sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 5;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb5.Visible = false;
                this.textBox5.Text = string.Empty;
                this.lb5sttBN.Text = string.Empty;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb6sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 6;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb6.Visible = false;
                this.textBox6.Text = string.Empty;
                this.lb6sttBN.Text = string.Empty;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bệnh nhân này...", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanNamGiuong_DaXepChoDTO benhnhanXC_DTO = new BenhNhanNamGiuong_DaXepChoDTO();
                benhnhanXC_DTO.STTBN = int.Parse(this.lb7sttBN.Text);
                benhnhanXC_DTO.sttGiuong = 7;

                BenhNhanNamGiuong_DaXepChoBUS.DeleteBenhNhanNamGiuong_DaXepCho(benhnhanXC_DTO);
                this.picb7.Visible = false;
                this.textBox7.Text = string.Empty;
                this.lb7sttBN.Text = string.Empty;
            }
        }
        #endregion        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }        
    }
}
