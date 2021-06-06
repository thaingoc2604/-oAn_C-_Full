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
    public partial class frmketqua : Form
    {
        public frmketqua()
        {
            InitializeComponent();
        }
        public delegate string GetKetQua();
        public GetKetQua GetTen;
        public GetKetQua GetCDD;
        public GetKetQua GetSoCau;
        public GetKetQua GetDiem;
        public GetKetQua GetTS;
        private void frmketqua_Load(object sender, EventArgs e)
        {
            lblten.Text = GetTen();
            lblsocaudung.Text = GetSoCau();
            if (lblsocaudung.Text == "12")
            {
                lblkq.Text = "Đậu";
            }
            else
            {
                lblkq.Text = "Rớt";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}