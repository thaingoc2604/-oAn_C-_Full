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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Enabled = false;
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (prgTienTrinh.Value < prgTienTrinh.Maximum - 8)
                prgTienTrinh.Value += 8;
            else
                prgTienTrinh.Value = prgTienTrinh.Maximum;
            if (!tmr1.Enabled)
                tmr2.Enabled = false;
        }

    }
}
