using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmAdministrator
{
    public partial class frmThoiGianChoCauHoi : Form
    {
        public frmThoiGianChoCauHoi()
        {
            InitializeComponent();
        }
        public delegate void pass(int time);
        public pass pa;
        private void frmThoiGianChoCauHoi_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.cbsecond.Text != "")
            {
                try
                {
                    int n = int.Parse(this.cbsecond.Text);
                    if (n > 60 || n < 5) MessageBox.Show("Chỉ được nhập từ 5 đến 60");
                    else
                    {
                        if (pa != null) pa(n);
                        this.Close();
                    }
                }
                catch { MessageBox.Show("Phải nhập số nguyên dương từ 5 đến 60"); };
            }
        }
        public void settime(int time)
        {
            this.cbsecond.Text = time.ToString();
        }
        public int gettime()
        {
            try
            {
                return int.Parse(this.cbsecond.Text);
            }
            catch { return 0; };
        }
    }
}
