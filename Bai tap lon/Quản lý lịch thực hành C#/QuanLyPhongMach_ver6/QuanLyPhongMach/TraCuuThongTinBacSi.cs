using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyPhongMach
{
    public partial class frmTraCuuThongTinBacSi : Form
    {
        public frmTraCuuThongTinBacSi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BacSiBUS.SelectAllCacSiForTraCuu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
