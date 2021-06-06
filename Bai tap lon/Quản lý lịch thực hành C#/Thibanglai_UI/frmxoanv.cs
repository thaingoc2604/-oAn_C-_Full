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
    public partial class frmxoanv : Form
    {
        public frmxoanv()
        {
            InitializeComponent();
        }
        nhanvienbs objnv = new nhanvienbs();
        public void LoadCombo()
        {
            DataTable dt = objnv.GetNhanVienL2().Tables[0];

            comboBox_hoten.DisplayMember = "hoten";
            comboBox_hoten.ValueMember = "manv";
            comboBox_hoten.DataSource = dt;
        }
        public void LoadText()
        {
            DataTable dt = objnv.GetNhanVien_Ma(comboBox_hoten.SelectedValue.ToString()).Tables[0];
            textBox_ma.Text = dt.Rows[0][0].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_dt.Text = dt.Rows[0][3].ToString();
            textBox_cv.Text = dt.Rows[0][4].ToString();

        }

        public void Cleartext()
        {
            textBox_cv.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
            textBox_ma.Text = "";
        }
        private void frmxoanv_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadText();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "")
            {
                MessageBox.Show("Chọn nhân viên muốn xóa");
            }
            else
            {


                DialogResult OK;
                OK = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên: " + comboBox_hoten.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (OK == DialogResult.Yes)
                {
                    if (textBox_cv.Text == "Điều hành")
                    {
                        MessageBox.Show("Bạn không thể xóa nhân viên Điều hành ");
                    }
                    else
                    {
                        objnv.DeleteNhanVien(comboBox_hoten.SelectedValue.ToString());

                        MessageBox.Show("Đã xóa nhân viên có tên: " + comboBox_hoten.Text);

                        LoadCombo();
                        Cleartext();
                    }
                }
                else
                {
                    Cleartext();
                    return;

                }

            }
        }

        private void comboBox_hoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadText();
        }
    }
}