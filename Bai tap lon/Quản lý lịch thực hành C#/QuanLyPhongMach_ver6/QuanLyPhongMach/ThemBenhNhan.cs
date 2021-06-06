using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyPhongMach
{
    public partial class ThemBenhNhan : Form
    {
        public List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();
        public List<ListViewItem> List_Items_Added = new List<ListViewItem>();

        public ThemBenhNhan()
        {
            InitializeComponent();
        }

        private void ThemBenhNhan_Load(object sender, EventArgs e)
        {
            CreateListView();

            this.comboBox1.ValueMember = "sttBS";
            this.comboBox1.DisplayMember = "TenBacSi";
            this.comboBox1.DataSource = BacSiBUS.SelectAllBacSi();
        }

        private void CreateListView()
        {
            listView1.Columns.Add("", 0);
            listView1.Columns.Add("Họ Tên Bệnh Nhân",150, HorizontalAlignment.Center);
            listView1.Columns.Add("Số CMND",80, HorizontalAlignment.Center);
            listView1.Columns.Add("Địa Chỉ",140, HorizontalAlignment.Center);
            listView1.Columns.Add("Giới Tính",80, HorizontalAlignment.Center);
            listView1.Columns.Add("Ngày Khám",100, HorizontalAlignment.Center);
            listView1.Columns.Add("Bác sĩ Điều Trị", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Loại Bệnh Nhân", 110, HorizontalAlignment.Center);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 9)
            {
                MessageBox.Show("Số CMND phải gồm 9 chữ số!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                this.label8.Text=string.Empty;

                BenhNhanDTO BenhNhan = new BenhNhanDTO();

                BenhNhan.Hoten = this.textBox1.Text;
                BenhNhan.CMND = int.Parse(this.textBox2.Text);
                BenhNhan.DiaChi = this.textBox3.Text;
                BenhNhan.NgayKham = this.dateTimePicker1.Value;
                BenhNhan.BacSiPhuTrach = int.Parse(this.comboBox1.SelectedValue.ToString());
                if (rbNam.Checked == true)
                    BenhNhan.GioiTinh = "Nam";
                else
                    BenhNhan.GioiTinh = "Nữ";

                List_BenhNhan.Add(BenhNhan);

                ListViewItem lvItem = new ListViewItem();

                lvItem.SubItems.Add(BenhNhan.Hoten);
                lvItem.SubItems.Add(BenhNhan.CMND.ToString());
                lvItem.SubItems.Add(BenhNhan.DiaChi);
                lvItem.SubItems.Add(BenhNhan.GioiTinh);
               
                lvItem.SubItems.Add(BenhNhan.NgayKham.ToString());

                if (BenhNhan.BacSiPhuTrach == 1)
                    lvItem.SubItems.Add("Vũ Mạnh Tuấn");
                else if (BenhNhan.BacSiPhuTrach == 2)
                    lvItem.SubItems.Add("Trần Thị Thúy Hằng");
                else
                    lvItem.SubItems.Add("Nguyễn Duy Hoài Nam");

                if (rbBenhNhanThuong.Checked == true)
                    lvItem.SubItems.Add("Thường");
                else
                    lvItem.SubItems.Add("Nằm viện");

                listView1.Items.Add(lvItem);
                List_Items_Added.Add(lvItem);

                this.textBox1.Text = string.Empty;
                this.textBox3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Thông Tin Chưa Đầy Đủ...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemChinh_Click(object sender, EventArgs e)
        {
            foreach (BenhNhanDTO benhnhan in List_BenhNhan)
            {
                if (this.rbBenhNhanThuong.Checked == true)
                {
                    BenhNhanBUS.Insert_BenhNhanThuong(benhnhan);                    
                }
                else
                {
                    BenhNhanBUS.Insert_BenhNhanNamVien(benhnhan);
                    this.button1.Visible = true;
                }                    
            }            
            
            foreach (ListViewItem item in List_Items_Added)
            {
                item.Remove();
            }
        }

        private void btXoaBenhNhan_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in List_Items_Added)
            {
                item.Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SapGiuongBenh frm = new SapGiuongBenh();
            this.Close();
            frm.ShowDialog();
        }                     
    }
}
