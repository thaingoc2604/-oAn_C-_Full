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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
            }
            else
            {
                if (tt.KiemTraNV(textBox1.Text, textBox2.Text))
                    this.DialogResult = DialogResult.Yes;
                else
                    this.DialogResult = DialogResult.No;
            }
        }
    }
}