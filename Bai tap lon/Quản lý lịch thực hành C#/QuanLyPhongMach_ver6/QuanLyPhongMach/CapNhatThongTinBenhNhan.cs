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
    public partial class frmCapNhatThongTinBenhNhan : Form
    {
        public BenhNhanDTO benhnhan = new BenhNhanDTO();

        public frmCapNhatThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void frmCapNhatThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            this.comboBox1.DisplayMember = "TenBacSi";
            this.comboBox1.ValueMember = "sttBS";
            this.comboBox1.DataSource = BacSiBUS.SelectAllBacSi();

            this.textBox1.Text = benhnhan.STTBN.ToString();
            this.textBox2.Text = benhnhan.Hoten;
            this.textBox3.Text = benhnhan.CMND.ToString();
            this.textBox4.Text = benhnhan.DiaChi;
            if (benhnhan.GioiTinh == "Nữ")
                radioButton2.Checked = true;
            if (benhnhan.BacSiPhuTrach == 1)
                this.comboBox1.SelectedValue = 1;
            else if (benhnhan.BacSiPhuTrach == 2)
                this.comboBox1.SelectedValue = 2;
            else
                this.comboBox1.SelectedValue = 3;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            BenhNhanDTO benhnhanNEW = new BenhNhanDTO();

            benhnhanNEW.STTBN = int.Parse(this.textBox1.Text);
            benhnhanNEW.Hoten = this.textBox2.Text;
            benhnhanNEW.CMND = int.Parse(this.textBox3.Text);
            benhnhanNEW.DiaChi = this.textBox4.Text;
            if (radioButton1.Checked == true)
                benhnhanNEW.GioiTinh = "Nam";
            else
                benhnhanNEW.GioiTinh = "Nữ";
            benhnhanNEW.BacSiPhuTrach = int.Parse(this.comboBox1.SelectedValue.ToString());

            BenhNhanBUS.UpdateBenhNhan(benhnhanNEW);
            this.label8.Visible = true;
        }        
    }
}
