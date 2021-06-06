using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tracnghiem_bs;

namespace Thibanglai_UI
{
    public partial class frmdangki : Form
    {
        thisinhbs objts=new thisinhbs();
        public frmdangki()
        {
            InitializeComponent();
        }

        public void Clearall()
        {
            textBox_ma.Text = "";
            textBox_ten.Text = "";
            textBox_dc.Text = "";
            textBox_ns.Text = "";
            textBox_tendn.Text = "";
            textBox_mk.Text = "";
        }

        private void button_xacnhan_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "" || textBox_ten.Text == "" || textBox_dc.Text == "" || textBox_ns.Text == "" || textBox_tendn.Text == "" || textBox_mk.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin đăng kí");
                textBox_ma.Focus();
            }
            else
            {
                try
                {
                    objts.dangki(textBox_ma.Text, textBox_ten.Text, textBox_dc.Text, textBox_ns.Text, textBox_tendn.Text, textBox_mk.Text);
                    DialogResult OK;
                    OK = MessageBox.Show("Đã đăng kí thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (OK == DialogResult.Yes)
                    {


                        this.Hide();
                    }
                    else
                    {
                        return;

                    }
                    this.Clearall();
                }
                catch (Exception)
                {

                    MessageBox.Show("Mã thí sinh này đã tồn tại...");
                }

            }
        }

        private void button_quay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}