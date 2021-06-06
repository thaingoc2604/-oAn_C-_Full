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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = "";
            s = this.Text.Substring(0, 1);
            this.Text = this.Text.Insert(this.Text.Length, s);
            this.Text = this.Text.Remove(0, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
