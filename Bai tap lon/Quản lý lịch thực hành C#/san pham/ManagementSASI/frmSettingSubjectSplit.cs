using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmSettingSubjectSplit : DevExpress.XtraEditors.XtraForm
    {
        public frmSettingSubjectSplit()
        {
            InitializeComponent();
        }

        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void frmSettingSubjectSplit_Load(object sender, EventArgs e)
        {
            rbEdit.Checked = false;
            btnLuu.Enabled = false;
            //btnDelete.Enabled = false;
            tedSecsionNC.Enabled = false ;
            tedSecsionTC.Enabled = false;
            tedTheoryNC.Enabled = false;
            tedTheoryTC.Enabled = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked == true)
            {
                btnLuu.Enabled = true;
                tedSecsionNC.Enabled = true;
                tedSecsionTC.Enabled = true;
                tedTheoryNC.Enabled = true;
                tedTheoryTC.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
                //btnDelete.Enabled = false;
                //tedSecsionNC.Enabled = false;
                //tedSecsionTC.Enabled = false;
                //tedTheoryNC.Enabled = false;
                //tedTheoryTC.Enabled = false;
            }
        }

        private void tedHoursTC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tedSecsionTC.Text != "" && tedTheoryTC.Text != "")
                {
                    SettingSubjectSplit ss1 = db.SettingSubjectSplits.SingleOrDefault(c => c.SubjectSplitName == lblName1.Text);
                    ss1.SectionNumber = int.Parse(tedSecsionTC.Text);
                    ss1.TheoryNumber = int.Parse(tedTheoryTC.Text);
                    db.SubmitChanges();
                    if (tedTheoryNC.Text != "" && tedSecsionNC.Text != "")
                    {
                        SettingSubjectSplit ss2 = db.SettingSubjectSplits.SingleOrDefault(c => c.SubjectSplitName == lblName2.Text);
                        ss2.SectionNumber = int.Parse(tedSecsionNC.Text);
                        ss2.TheoryNumber = int.Parse(tedTheoryNC.Text);
                        db.SubmitChanges();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thông tin không được để trống");
                    }
                    XtraMessageBox.Show("Bạn đã sửa thành công !");
                }
                else
                {
                    XtraMessageBox.Show("Thông tin không được để trống");
                }
            }
                  
        }

        private void frmSettingSubjectSplit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                rbEdit.Checked = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                rbEdit.Checked = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                btnLuu_Click(sender, e);
            }
        }

    }
}