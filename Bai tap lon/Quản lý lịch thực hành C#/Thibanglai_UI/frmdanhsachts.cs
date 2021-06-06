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
    public partial class frmdanhsachts : Form
    {
        public frmdanhsachts()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        private void frmdanhsachts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objts.GetThiSinh().Tables[0];
            comboBox_ten.DisplayMember = "HoTen";
            comboBox_ten.ValueMember = "MaThiSinh";
            comboBox_ten.DataSource = dt;
            comboBox_ma.DisplayMember = "MaThiSinh";
            comboBox_ma.ValueMember = "MaThiSinh";
            comboBox_ma.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBox_ma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox_ten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}