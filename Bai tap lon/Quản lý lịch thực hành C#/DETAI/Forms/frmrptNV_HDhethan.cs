using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmrptNV_HDhethan : Form
    {
        clschitiethopdong chopdong = new clschitiethopdong();
        public frmrptNV_HDhethan()
        {
            InitializeComponent();
            rptHopDongHetHan r = new rptHopDongHetHan();
            r.SetDataSource(chopdong.layNV_HDhethan(frmKiemTraHDHetHan.dk));
            this.rvNV_HDhethan.ReportSource = r;
        }       
    }
}