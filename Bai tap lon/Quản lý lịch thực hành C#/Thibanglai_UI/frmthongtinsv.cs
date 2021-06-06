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
    public partial class frmthongtinsv : Form
    {
        public frmthongtinsv()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        public delegate string MyDelegate1();
        public MyDelegate1 GetStringFromAnotherForm;
        private void frmthongtinsv_Load(object sender, EventArgs e)
        {
            label15.Visible = false;
            label11.Text = GetStringFromAnotherForm();
            label11.Visible = false;
            DataTable dt = objts.GetMonThi().Tables[0];
            comboBox_monthi.DisplayMember = "TenMon";
            comboBox_monthi.ValueMember = "MaMon";
            comboBox_monthi.DataSource = dt;
            DataTable dt2 = objts.GetThiSinh(label11.Text).Tables[0];
            foreach (DataRow dr in dt2.Rows)
            {
                label15.Text = dr[0].ToString();
                label8.Text = dr[1].ToString();
                label9.Text = dr[3].ToString();
                label10.Text = dr[2].ToString();
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult OK;
            OK = MessageBox.Show("Bạn không muốn bắt đầu bài thi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                frmdangnhap f = new frmdangnhap();
                f.ShowDialog();
                this.Close();
            }
            else
                return;
        }

        private void button_dongy_Click(object sender, EventArgs e)
        {
            string a = objts.KiemTraMon(comboBox_monthi.SelectedValue.ToString()).Tables[0].Rows[0][0].ToString();
            int b = Int32.Parse(a.ToString());
            if (b < 3)
            {
                MessageBox.Show("Hiện tại môn : " + comboBox_monthi.Text + " chưa đủ câu hỏi để tạo đề thi!");
                return;
            }
            else
            {
                frmthi f = new frmthi();
                f.Getten += delegate { return label8.Text; };
                f.Getngaysinh += delegate { return label9.Text; };
                f.Getmonthi += delegate { return comboBox_monthi.Text; };
                f.Getmamon += delegate { return comboBox_monthi.SelectedValue.ToString(); };
                f.GetMaTS += delegate { return label15.Text; };
                f.Show();
                this.Close();
            }
        }
        
    }
}