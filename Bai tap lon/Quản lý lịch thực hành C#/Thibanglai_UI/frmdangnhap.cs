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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        nhanvienbs objnv = new nhanvienbs();
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            textBox_dn.Focus();
            groupBox1.Enabled = false;
            button_dk.Visible = true;
        }

        private void radioButton_quanli_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "Lương Ngọc Tâm";
            textBox_pa.Text = "1111";
            label1.Text = "Tên người quản lý:";
            groupBox1.Text = "Thông tin người quản lý";

            button_dk.Visible = false;
            groupBox1.Enabled = true;
        }

        private void radioButton_thisinh_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            label1.Text = "Tên thí sinh:";
            groupBox1.Text = "Thông tin thí sinh:";

            button_dk.Visible = true;
            groupBox1.Enabled = true;
        }

        private void button_dn_Click(object sender, EventArgs e)
        {
            if (radioButton_thisinh.Checked == true)
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của thí sinh");
                    textBox_dn.Focus();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = objts.GetThiSinhDN(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        frmthongtinsv ts = new frmthongtinsv();
                        ts.GetStringFromAnotherForm += delegate { return textBox_pa.Text; };
                        ts.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại");
                    }


                }
            }
            else
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của người quản lý");
                    textBox_dn.Focus();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = objnv.DangNhapNV(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dt.Rows[0];
                        frmdieuhanh d = new frmdieuhanh();
                        d.GetStringFromAnotherFormdn += delegate { return textBox_pa.Text; };
                        d.GetStringFromAnotherFormdn2 += delegate { return dr[0].ToString(); };
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
            }
        }

        private void button_dk_Click(object sender, EventArgs e)
        {
                this.Close();
                frmdangki dk = new frmdangki();
                dk.Show();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}