using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmGeneralReceiptMoney : DevExpress.XtraEditors.XtraForm
    {
        public frmGeneralReceiptMoney()
        {
            InitializeComponent();
        }

        private void frmGeneralReceiptMoney_Load(object sender, EventArgs e)
        {
            //Download source code tại Sharecode.vn
            this.reportViewer1.RefreshReport();
        }
    }
}