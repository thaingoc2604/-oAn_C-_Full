using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmrptbcnhanvien : Form
    {
        public frmrptbcnhanvien()
        {
            //frmchonbcnv.bcnhanvien(frmchonbcnv.maphong, frmchonbcnv.mato);
            InitializeComponent();
            if (frmchonbcnv.mato == "")
            {
                rptdsnvtheophong1  r = new rptdsnvtheophong1();
                r.SetDataSource(frmchonbcnv.bcnhanvien(frmchonbcnv.maphong));
                this.rptbcnhanvien.ReportSource = r;
            }
            else
            {
                rptbcnvtheoto r = new rptbcnvtheoto();
                r.SetDataSource(frmchonbcnv.bcnhanvien(frmchonbcnv.maphong, frmchonbcnv.mato));
                this.rptbcnhanvien.ReportSource = r;
            }
        }

        private void frmrptbcnhanvien_Leave(object sender, EventArgs e)
        {
            
        }
    }
}