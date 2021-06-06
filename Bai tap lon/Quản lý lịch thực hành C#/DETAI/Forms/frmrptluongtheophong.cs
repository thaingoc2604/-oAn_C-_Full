using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmrptluongtheophong : Form
    {
        clsbangluong cluong = new clsbangluong();
        public frmrptluongtheophong()
        {
            InitializeComponent();
            if (frmchonbcluong.mato == "")
            {
                rptluongtheophong r = new rptluongtheophong();
                r.SetDataSource(cluong.laydlgird(frmchonbcluong.thangbc, frmchonbcluong.nambc, frmchonbcluong.maphong));
                this.rptluongnhanvien.ReportSource = r;
            }
            else
            {
                rptluongtheoto r = new rptluongtheoto();
                r.SetDataSource(cluong.laydlgird(frmchonbcluong.thangbc, frmchonbcluong.nambc, frmchonbcluong.maphong,frmchonbcluong.mato));
                this.rptluongnhanvien.ReportSource = r;
            }
        }
    }
}