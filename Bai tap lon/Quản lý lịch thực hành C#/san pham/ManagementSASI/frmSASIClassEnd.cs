using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace ManagementSASI
{
    public partial class frmSASIClassEnd : DevExpress.XtraEditors.XtraForm
    {
        public frmSASIClassEnd()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();

        private void frmSASIClassEnd_Load(object sender, EventArgs e)
        {
            grvSASIClassEnd.DataSource = db.SASIClassEnd();            
        }
    }
}