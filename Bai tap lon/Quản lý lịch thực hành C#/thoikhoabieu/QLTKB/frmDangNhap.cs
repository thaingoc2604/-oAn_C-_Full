using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTKB
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlkt = "select count(*) from tblLogin where Id=N'" + txttk.Text + "' and Pass=N'" + txtmk.Text + "'";
            int kq = int.Parse(cn.LoadLable(sqlkt));
            string quyen = "select Quyen from tblLogin where Id=N'" + txttk.Text + "' and Pass=N'" + txtmk.Text + "'";
            if (kq == 1)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công");
                frmMain fr = new frmMain();
                fr.QUYEN = cn.LoadLable(quyen);
                this.Hide();
                fr.Show();

            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
