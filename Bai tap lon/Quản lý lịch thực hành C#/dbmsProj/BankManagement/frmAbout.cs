using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.ClientSize = new Size(478, 289);
            picAbout.Image = Properties.Resources.Splash;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) this.Close();
        }
    }
}