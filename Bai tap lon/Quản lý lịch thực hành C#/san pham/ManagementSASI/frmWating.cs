using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmWating : DevExpress.XtraEditors.XtraForm
    {
        public frmWating()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 1;
        }
    }
}