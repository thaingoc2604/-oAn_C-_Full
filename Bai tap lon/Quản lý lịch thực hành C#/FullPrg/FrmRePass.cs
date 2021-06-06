using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

namespace FullPrg
{
    public partial class FrmRePass : Form
    {
        public FrmRePass()
        {
            InitializeComponent();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();//this close
          
        }
    }
}
