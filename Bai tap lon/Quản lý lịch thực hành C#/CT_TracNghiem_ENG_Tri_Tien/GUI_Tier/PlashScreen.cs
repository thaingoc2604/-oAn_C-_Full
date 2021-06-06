using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tier
{
    public partial class PlashScreen : Form
    {
        public PlashScreen()
        {
            InitializeComponent();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            this.DialogResult=DialogResult.OK;
        }
    }
}
