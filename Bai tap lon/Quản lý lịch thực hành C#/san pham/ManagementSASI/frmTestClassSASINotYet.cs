using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using System.Xml;

namespace ManagementSASI
{
    public partial class frmTestClassSASINotYet : DevExpress.XtraEditors.XtraForm
    {
        public frmTestClassSASINotYet()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtMoneySASI.Text != "")
                //{
                    //var thu = from c in db.Configs
                    //          select new {c. };
                    var query = db.ShowSASIClassesNotYet();
                    gctSASIClass.DataSource = query;
                //}
                //else
                //{
                //    XtraMessageBox.Show("Bạn chưa nhập tiền để kiểm tra", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }
            catch (Exception ex)
            {
              XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvSASIClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gctSASIClass_Click(object sender, EventArgs e)
        {
            txtSASIClassName.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "SASIClassName");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            if (XtraMessageBox.Show("Bạn chắc muốn xóa dữ liệu sẽ bị mất", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SASIClass c = db.SASIClasses.SingleOrDefault(p => p.SASIClassName == txtSASIClassName.Text);
                if (c != null)
                {
                    db.SASIClasses.DeleteOnSubmit(c);
                    db.SubmitChanges();
                }
                gctSASIClass_Click(sender, e);
                txtSASIClassName.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "SASIClassName");
            }
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TestClassSASINotYet_Load(object sender, EventArgs e)
        {
            //ManagementSASI.Properties.Settings.Default.MoneySA = txtMoneySASI.Text;
            
        }
    }
}