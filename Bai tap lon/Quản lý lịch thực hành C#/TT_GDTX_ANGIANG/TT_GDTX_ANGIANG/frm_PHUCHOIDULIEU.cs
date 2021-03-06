using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_PHUCHOIDULIEU : Form
    {
        public frm_PHUCHOIDULIEU()
        {
            InitializeComponent();
        }

        private void buttonXDongY_Click(object sender, EventArgs e)
        {
            DataService ser = new DataService();
            SqlCommand com = new SqlCommand("RESTORE  DATABASE QLNSTL_TTGDTX_AG  FROM DISK ='" + txtDuongDan.Text + "' with REPLACE ");
           
            MessageBox.Show("Phục hồi Thành công.", "Restore");
            this.Dispose();
        }

        private void buttonXDuongDan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File database|*.db";
            openFileDialog1.Title = "Phuc Hoi CSDL";
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = openFileDialog1.FileName;
            if (txtDuongDan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đường dẫn!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuongDan.Text = "C:\\bkdbQLNSTL" + ".db";
            }
        }

        private void frm_PHUCHOIDULIEU_Load(object sender, EventArgs e)
        {
            txtDuongDan.Text = "C:\\bkdbQLNSTL" + ".db";
            txtDuongDan.Focus();
        }

        private void buttonXBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}