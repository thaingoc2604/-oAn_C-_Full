using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Collections;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_SAOLUUDULIEU : Form
    {
        //QLHoSoGiaoViec.Controller.CSDLController ctrlCSDL = new QLHoSoGiaoViec.Controller.CSDLController();

        
        public frm_SAOLUUDULIEU()
        {
            InitializeComponent();
        }

        private void frm_SAOLUUDULIEU_Load(object sender, EventArgs e)
        {
            txtDuongDan.Text = "C:\\bkdbQLNSTL" + ".db";
            txtDuongDan.Focus();
        }

        private void buttonXDongY_Click(object sender, EventArgs e)
        {
            DataService ser = new DataService();
            SqlCommand com = new SqlCommand("BACKUP DATABASE QLNSTL_TTGDTX_AG TO DISK = '" + txtDuongDan.Text + "' WITH INIT , NOUNLOAD , NOSKIP , STATS = 10  , NOFORMAT");
            ser.Load(com);
            MessageBox.Show("Sao lưu Thành công.", "backup");
            this.Dispose();

        }

        private void buttonXDuongDan_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File database|*.db";
            saveFileDialog1.Title = "Sao Luu CSDL";
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = saveFileDialog1.FileName;
            if (txtDuongDan.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập đường dẫn!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuongDan.Text = "C:\\bkdbQLNSTL" + ".db";
            }
        }

        private void buttonXBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}