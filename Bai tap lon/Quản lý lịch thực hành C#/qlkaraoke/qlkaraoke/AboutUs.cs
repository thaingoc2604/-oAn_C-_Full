using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fAboutUs : Form
    {
        public fAboutUs()
        {
            InitializeComponent();
        }

        private void fAboutUsLlbClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}