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
    public partial class frmquanlynv : Form
    {
        public frmquanlynv()
        {
            InitializeComponent();
        }
        nhanvienbs objnv = new nhanvienbs();
        private void frmquanlynv_Load(object sender, EventArgs e)
        {
            LoadComBo();
            textBox_ten.Visible = false;
            comboBox_cv.Visible = false;
            LoadData();
        }
        public void LoadComBo()
        {
            DataTable dt = objnv.GetNhanVienL2().Tables[0];
            comboBox_ten.DisplayMember = "hoten";
            comboBox_ten.ValueMember = "manv";
            comboBox_ten.DataSource = dt;

        }
        public void LoadData()
        {
            DataTable dt = objnv.GetNhanVien_Ma(comboBox_ten.SelectedValue.ToString()).Tables[0];
            textBox_ma.Text = dt.Rows[0][0].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_dt.Text = dt.Rows[0][3].ToString();
            textBox_cv.Text = dt.Rows[0][4].ToString();
            if (textBox_cv.Text.ToString().Trim() == "quan ly")
            {

                textBox_cv.Text = "Quản lý";
            }
            if (textBox_cv.Text.ToString().Trim() == "dieu hanh")
            {

                textBox_cv.Text = "Điều hành";
            }
            if (textBox_cv.Text.ToString().Trim() == "nhan vien")
            {

                textBox_cv.Text = "Nhân viên";
            }
            txtmk.Text = dt.Rows[0][5].ToString();
        }

        public void Status()
        {
            textBox_ten.Visible = true;
            comboBox_ten.Visible = false;
            textBox_ten.Text = "";
            textBox_ma.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
        }
        
        public void Clear()
        {
            textBox_ma.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
            comboBox_cv.Text = "";
            comboBox_ten.Visible = false;
            txtmk.Text = "";
            textBox_ten.Visible = true;
            textBox_cv.Visible = false;
            comboBox_cv.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Thêm")
            {
                Status();
                button1.Text = "Hủy";
                comboBox_cv.Visible = true;
                textBox_cv.Visible = false;
                txtmk.Text = "";
            }
            else
            {
                comboBox_ten.Visible = true;
                textBox_ten.Visible = false;                
                LoadComBo();
                comboBox_cv.Text = "";
                Clear();
                button1.Text = "Thêm";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (textBox_ten.Text == "" || textBox_ma.Text == "" || textBox_dc.Text == "" )
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                        objnv.ThemNV(textBox_ma.Text,textBox_ten.Text,textBox_dc.Text,textBox_dt.Text,comboBox_cv.Text,txtmk.Text);
                        MessageBox.Show("Đã thêm nhân viên mới");

                        comboBox_ten.Visible = true;
                        textBox_ten.Visible = false;
                        Clear();
                        LoadComBo();
                        button1.Text = "Thêm";

                        this.Close();

                       

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ " Trùng mã nhân viên");
                   
                        comboBox_ten.Visible = true;
                        textBox_ten.Visible = false;
                        Clear();
                        LoadComBo();
                        button1.Text = "Thêm";
                }
            }
        
        }

        private void textBox_ten_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}