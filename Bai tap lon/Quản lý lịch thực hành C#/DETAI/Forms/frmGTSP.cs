using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DETAI
{
    public partial class frmGTSP : Form
    {
        public frmGTSP()
        {
            InitializeComponent();
        }
        

        private void frmGTSP_Load(object sender, EventArgs e)
        {
            /*linkLabel1.Links.Add(1,27,"mailto:thanglong17061984@gmail.com");
            linkLabel2.Links.Add(1,22,"mailto:minhquan1704@yahoo.com");
            linkLabel3.Links.Add(1,18,"mailto:ngtrtruc@yahoo.com");*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Hello");*/
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Hello");*/
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Hello");*/
        }
    }
}