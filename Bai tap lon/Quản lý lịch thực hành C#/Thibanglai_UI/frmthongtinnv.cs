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
    public partial class frmthongtinnv : Form
    {
        public frmthongtinnv()
        {
            InitializeComponent();
        }
        nhanvienbs objnv = new nhanvienbs();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnv.GetNhanVien().Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnv.GetNhanVienCV("Điều hành").Tables[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnv.GetNhanVienCV("Quản Lý").Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnv.GetNhanVienCV("Nhân Viên").Tables[0];
        }
    }
}