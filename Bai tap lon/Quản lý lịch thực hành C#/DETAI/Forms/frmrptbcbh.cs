using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmrptbcbh : Form
    {
        public frmrptbcbh()
        {
            InitializeComponent();
            rptbcbaohiem r = new rptbcbaohiem();
            r.SetDataSource(frmchonbcluong.bcbaohiem(frmchonbcluong.thangbh, frmchonbcluong.nambh));
            this.rptbcbaohiem.ReportSource = r;
        }
    }
}