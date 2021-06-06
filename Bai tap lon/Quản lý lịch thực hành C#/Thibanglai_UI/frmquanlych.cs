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
    public partial class frmquanlych : Form
    {
        public frmquanlych()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        nhanvienbs objnv = new nhanvienbs();
        public delegate string MyGet();
        
        private void frmquanlych_Load(object sender, EventArgs e)
        {
            Manv();

            label_a.Visible = false;
            label_b.Visible = false;
            label_c.Visible = false;
            label_d.Visible = false;

            Radio(false);
            Enl(false);
            Data();

            DataTable dt = objts.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;
        }
        public void HienDA()
        {
            DataTable dt = objts.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            txtdapan1.Text = dt.Rows[0][0].ToString();
            txtdapan2.Text = dt.Rows[1][0].ToString();
            txtdapan3.Text = dt.Rows[2][0].ToString();
            txtdapan4.Text = dt.Rows[3][0].ToString();

        }
        public void Manv()
        {
            DataTable dt = objnv.GetNhanVien().Tables[0];
            label1.Text = dt.Rows[0][0].ToString();
        }

        private void radioButton_a_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "1";
            label_b.Text = "0";
            label_c.Text = "0";
            label_d.Text = "0";
        }

        private void radioButton_b_CheckedChanged(object sender, EventArgs e)
        {

            label_a.Text = "0";
            label_b.Text = "1";
            label_c.Text = "0";
            label_d.Text = "0";
        }

        private void radioButton_c_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "0";
            label_b.Text = "0";
            label_c.Text = "1";
            label_d.Text = "0";
        }

        private void radioButton_d_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "0";
            label_b.Text = "0";
            label_c.Text = "0";
            label_d.Text = "1";
        }
        public void ClearAll()
        {
            textBox1.Text = "";
            txtdapan1.Text = "";
            txtdapan2.Text = "";
            txtdapan3.Text = "";
            txtdapan4.Text = "";
            txtma.Text = "";
            
        }
        public void Enl(bool b)
        {
            txtma.Enabled = b;
          
        }
        public void Radio(bool a)
        {
            rdkieu1.Enabled = a;
            rdkieu2.Enabled = a;
            rdkieu3.Enabled = a;
            rdkieu4.Enabled = a;
            button_luu.Enabled = a;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (button_them.Text == "Thêm câu hỏi")
            {
                Radio(true);
                Enl(true);
                ClearAll();
                button_them.Text = "Hủy";
            }
            else
            {
                Radio(false);
                button_them.Text = "Thêm câu hỏi";
                Enl(false);
            }
        }
        public void Data()
        {
            DataTable dt = objts.GetCauHoi().Tables[0];
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienDA();
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtdapan1.Text == "" || txtdapan2.Text == "" || txtdapan3.Text == "" || txtdapan4.Text == "" || txtma.Text == "" || label_a.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ! Chọn câu trả lời đúng");
            }
            else
            {
                try
                {
                    objts.ThemCauHoi(txtma.Text, textBox1.Text, label1.Text, comboBox_mon.SelectedValue.ToString(),"image/"+txthinh.Text);
                    objts.ThemDapan(txtdapan1.Text, txtma.Text, label_a.Text);
                    objts.ThemDapan(txtdapan2.Text, txtma.Text, label_b.Text);
                    objts.ThemDapan(txtdapan3.Text, txtma.Text, label_c.Text);
                    objts.ThemDapan(txtdapan4.Text, txtma.Text, label_d.Text);
                    ClearAll();
                    Enl(false);
                    Radio(false);
                    rdkieu1.Checked = false;
                    rdkieu2.Checked = false;
                    rdkieu3.Checked = false;
                    rdkieu4.Checked = false;
                    label_a.Text = "";
                    label_b.Text = "";
                    label_c.Text = "";
                    label_d.Text = "";
                    MessageBox.Show("Thêm thành công");
                    Data();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "   Trùng mã câu hỏi hoặc câu trả lời !! ");
                    ClearAll();
                    Enl(false);
                    Radio(false);
                    Data();
                }
            }
        }
    }
}