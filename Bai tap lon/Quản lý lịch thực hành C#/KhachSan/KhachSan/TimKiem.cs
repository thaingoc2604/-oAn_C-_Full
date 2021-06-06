using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KetNoiDL;

namespace KhachSan
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || comboBox1.Text=="")
                MessageBox.Show("Chưa Nhập Thông Tin Cần Tìm");
            if (comboBox1.Text == "Phòng")
            {
                DataView dv = tt.getDataView("Phong");
                dataGridView1.DataSource = dv;
                dv.RowFilter = "MaPhong like'%" + textBox1.Text + "%'";
            }
            if (comboBox1.Text == "Mã Khách Hàng")
            {
                DataView dv = tt.getDataView("KhachHang");
                dataGridView1.DataSource = dv;
                dv.RowFilter = "MaKH like'%" + textBox1.Text + "%'";
            }
            if (comboBox1.Text == "Tên Khách Hàng")
            {
                DataView dv = tt.getDataView("KhachHang");
                dataGridView1.DataSource = dv;
                dv.RowFilter = "TenKH like'%" + textBox1.Text + "%'";
            }
        }
    }
}