using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class AboutCT : Form
    {
       
        public AboutCT()
        {
            InitializeComponent();
           
        }
        //public int i = 10;
        //private void timer1_Tick(object sender, EventArgs e)
        //{


        //    //label1.Left += i;
        //    //label2.Left += i;
        //    //label3.Left += i;
        //    //if (label1.Left >= this.Width - label1.Width || label1.Left <= 0)
        //    //    i = -i;

        //    label1.Top += i;
        //    label2.Top += i;
        //    label3.Top += i;
        //    if (label1.Top >= this.Height - label1.Height || label1.Top <= 0)
        //        i = -i;
            
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
