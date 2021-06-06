using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Thibanglai_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string st = lbl2.Text;
            lbl2.Text = st.Substring(1, st.Length - 1) + st.Substring(0, 1);        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmdangnhap f = new frmdangnhap();
            f.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult OK;
            OK = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}