using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace Accounting
{
    public partial class Form_Confirm : Office2007Form
    {
        string _mess = "";
        public Form_Confirm(string mess)
        {
            InitializeComponent();

            _mess = mess;
        }

        private void Form_Comfirm_Load(object sender, EventArgs e)
        {
            label1.Text = _mess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}