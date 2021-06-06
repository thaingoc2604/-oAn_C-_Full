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
    public partial class frmThemBacSi : Form
    {
        public frmThemBacSi()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BacSiDTO bacsi = new BacSiDTO();

            bacsi.TenBacSi = this.textBox1.Text;
            bacsi.DiaChi = this.textBox2.Text;
            bacsi.SoDienThoai = float.Parse(this.textBox3.Text);
            bacsi.UserName = this.textBox4.Text;
            bacsi.PassWord = this.textBox5.Text;

            BacSiBUS.InsertBacSi(bacsi);
            this.label7.Visible = true;
        }
    }
}
