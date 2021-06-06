using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmrpthsnhanvien : Form
    {
        clsnhanvien cnhanvien = new clsnhanvien();
        public frmrpthsnhanvien()
        {           
            InitializeComponent();
            rpthsnhanvien1 r = new rpthsnhanvien1();
            r.SetDataSource(cnhanvien.laydl1(frmNhanvien.bienmanv));
            this.rpthsnhanvien.ReportSource= r;           
        }
    }
}