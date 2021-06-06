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
    public partial class frmnganhangcauhoi : Form
    {
        public frmnganhangcauhoi()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        nhanvienbs objnv = new nhanvienbs();
        private void frmnganhangcauhoi_Load(object sender, EventArgs e)
        {
            DataTable dt = objts.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

            DataTable dt2 = objnv.GetNhanVien().Tables[0];

            dataGridView1.DataSource = objts.GetCauHoi().Tables[0];
        }

        private void comboBox_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objts.GetCauHoi_Mon(comboBox_mon.SelectedValue.ToString()).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                richTextBox_cauhoi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienthiDA();
            }
        }
        public void HienthiDA()
        {
            DataTable dt = objts.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            richTextBox1.Text = dt.Rows[0][0].ToString();
            richTextBox2.Text = dt.Rows[1][0].ToString();
            richTextBox3.Text = dt.Rows[2][0].ToString();
            richTextBox4.Text = dt.Rows[3][0].ToString();
            richTextBox5.Text = objts.GetDapAnDung(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString();
        }
    }
}