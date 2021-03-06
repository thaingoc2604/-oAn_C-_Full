using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmTrain_Subject : DevExpress.XtraEditors.XtraForm
    {
        public frmTrain_Subject()
        {
            InitializeComponent();
        }

        ManagementSASIDataContext db = new ManagementSASIDataContext();
        void ClearControl()
        {
            lueSubject.EditValue = "";
            lueTrain.EditValue = "";
          
            lueTrain.Enabled = true;
            lueSubject.Enabled = true;
            lueSettingSubjectSplit.Enabled = true;
            lueTrain.ClosePopup();
            lueSubject.ClosePopup();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //lueSubject.EditValue = "";
            //Download source code tại Sharecode.vn
        }
        bool TestControl()
        {
            if (lueSubject.Text == "" || lueTrain.Text == ""||lueSettingSubjectSplit.Text=="")
                return false;
            return true;
          
        }
      
        bool TestID()
        {
            var id = from c in db.SubjectTrains
                     select new { c.TrainCode, c.SubjectCode,c.SubjectSplitName};
            foreach (var id1 in id)
            {
                if (id1.TrainCode.ToString() == lueTrain.GetColumnValue("TrainCode").ToString() && id1.SubjectCode.ToString() == lueSubject.GetColumnValue("SubjectCode").ToString() && id1.SubjectSplitName == lueSettingSubjectSplit.GetColumnValue("SubjectSplitName").ToString())
                    return false;
            }
            return true;
        }

        void LoadLookUpEditTrain()
        {
            var t = from c in db.Trains
                    select new { c.TrainCode, c.TrainName,c.Description };
            lueTrain.Properties.DataSource = t;
        }
        void LoadLookUpEditSubject()
        {
            var s = from c in db.Subjects
                    select new { c.SubjectCode, c.SubjectName };
            lueSubject.Properties.DataSource = s;
        }
        void LoadLookUpEditSubjectSplit()
        {
            var s = from c in db.SettingSubjectSplits
                    select new { c.SubjectSplitName,c.TrainingType,c.TheoryNumber,c.SectionNumber};
            lueSettingSubjectSplit.Properties.DataSource = s;
        }

        void LoadGridControl()
        {
            var ts = from c in db.SubjectTrains
                     select new { c.Train.TrainName, c.Subject.SubjectName, c.TheoryNumber, c.PracticeNumber,c.SubjectSplitName,c.SectionTheory,c.SectionPractice };
            gctTrainSubject.DataSource = ts;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
            
        }
        public string strTenMonHoc;
        public string strMaMonHoc;
        public string strMaHe;
        public string strTenHe;
        private void frmTrain_Subject_Load(object sender, EventArgs e)
        {
            LoadGridControl();
            LoadLookUpEditTrain();
            LoadLookUpEditSubject();
            LoadLookUpEditSubjectSplit();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            lueSubject.Text = strTenMonHoc;
            lueSubject.EditValue = strMaMonHoc;
            lueTrain.Text = strTenHe;
            lueTrain.EditValue = strMaHe;
        }

        private void gctTrainSubject_Click(object sender, EventArgs e)
        {
            lueTrain.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "TrainName");
            lueSubject.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "SubjectName");
            lueSettingSubjectSplit.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "SubjectSplitName");
            lueTrain.ClosePopup();
            lueSubject.ClosePopup();
            lueSettingSubjectSplit.ClosePopup();
            lueTrain.Enabled = false ;
            lueSubject.Enabled = false;
            //lueSettingSubjectSplit.Enabled = false;
            spinLT.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "TheoryNumber");
            spinTH.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "PracticeNumber");
            txtSectionTheory.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "SectionTheory");
            txtSectionPractice.Text = gvTrainSubject.GetRowCellDisplayText(gvTrainSubject.FocusedRowHandle, "SectionPractice");
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        ErrorProvider error = new ErrorProvider();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (lueTrain.Text == "")
                {
                    error.SetError(lueTrain, "Bạn chưa chọn hệ đào tạo");

                }
                else
                {
                    if (lueSubject.Text != "")
                    {

                        if (TestID())
                        {
                            SubjectTrain ts = new SubjectTrain();
                            ts.TrainCode = lueTrain.GetColumnValue("TrainCode").ToString();
                            ts.SubjectCode = lueSubject.GetColumnValue("SubjectCode").ToString();
                            ts.SubjectSplitName = lueSettingSubjectSplit.GetColumnValue("SubjectSplitName").ToString();
                            ts.TheoryNumber = int.Parse(spinLT.Text);
                            ts.PracticeNumber = int.Parse(spinTH.Text);
                            if (lueSettingSubjectSplit.Text != "")
                            {
                                int theoryNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("TheoryNumber").ToString());
                                int practiceNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("SectionNumber").ToString());
                                string trainType = lueSettingSubjectSplit.GetColumnValue("TrainingType").ToString();
                                int practice = 0;
                                if (trainType == "Tín chỉ")
                                {
                                    practice = (practiceNumber * 60) / 40;
                                }
                                if (trainType == "Niên chế")
                                {
                                    practice = (practiceNumber * 60) / 45;
                                }
                                int LT = int.Parse(spinLT.Text);
                                int TH = int.Parse(spinTH.Text);
                                txtSectionTheory.Text = (theoryNumber * LT).ToString();
                                txtSectionPractice.Text = (practice * TH).ToString();
                            }
                            else
                            {
                                XtraMessageBox.Show("Bạn chưa chọn mức chia số tiết cho môn !");
                            }
                            ts.SectionTheory = int.Parse(txtSectionTheory.Text);
                            ts.SectionPractice = int.Parse(txtSectionPractice.Text);
                            db.SubjectTrains.InsertOnSubmit(ts);
                            db.SubmitChanges();
                            LoadGridControl();
                            ClearControl();
                        }
                        else
                        {
                            XtraMessageBox.Show("Môn học của hệ đào tạo này đã được phân chia theo mức bạn chọn !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        error.SetError(lueSubject, "Bạn chưa chọn môn học");
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (lueTrain.Text == "")
                {
                    error.SetError(lueTrain, "Bạn chưa chọn hệ đào tạo");

                }
                else
                {
                    if (lueSubject.Text != "")
                    {

                        if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SubjectTrain ts = db.SubjectTrains.SingleOrDefault(c => (c.SubjectCode == lueSubject.EditValue.ToString() && c.TrainCode == lueTrain.EditValue.ToString() && c.SubjectSplitName==lueSettingSubjectSplit.EditValue.ToString()));
                            ts.TheoryNumber = int.Parse(spinLT.Text);
                            ts.PracticeNumber = int.Parse(spinTH.Text);
                            if (lueSettingSubjectSplit.Text != "")
                            {
                                int theoryNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("TheoryNumber").ToString());
                                int practiceNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("SectionNumber").ToString());
                                string trainType = lueSettingSubjectSplit.GetColumnValue("TrainingType").ToString();
                                int practice = 0;
                                if (trainType == "Tín chỉ")
                                {
                                    practice = (practiceNumber * 60) / 40;
                                }
                                if (trainType == "Niên chế")
                                {
                                    practice = (practiceNumber * 60) / 45;
                                }
                                int LT = int.Parse(spinLT.Text);
                                int TH = int.Parse(spinTH.Text);
                                txtSectionTheory.Text = (theoryNumber * LT).ToString();
                                txtSectionPractice.Text = (practice * TH).ToString();
                            }
                            else
                                XtraMessageBox.Show("Bạn chưa chọn mức chia số tiết cho môn !");
                            ts.SectionTheory =int.Parse( txtSectionTheory.Text);
                            ts.SectionPractice = int.Parse(txtSectionPractice.Text);
                            db.SubmitChanges();
                            LoadGridControl();
                        }
                      
                    }
                    else
                    {
                        error.SetError(lueSubject, "Bạn chưa chọn môn học");
                    }

                }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lueTrain.Text == "")
                {
                    error.SetError(lueTrain, "Bạn chưa chọn hệ đào tạo");

                }
                else
                {
                    if (lueSubject.Text != "")
                    {

                        if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SubjectTrain ts = db.SubjectTrains.SingleOrDefault(c => (c.SubjectCode == lueSubject.EditValue.ToString() && c.TrainCode == lueTrain.EditValue.ToString() && c.SubjectSplitName == lueSettingSubjectSplit.EditValue.ToString()));
                            db.SubjectTrains.DeleteOnSubmit(ts);
                            db.SubmitChanges();
                            LoadGridControl();
                            ClearControl();
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lueTrain_TextChanged(object sender, EventArgs e)
        {
            if (lueTrain.Text != "")
            {
                error.Clear();
            }
        }

        private void lueSubject_TextChanged(object sender, EventArgs e)
        {
            if (lueSubject.Text != "")
            {
                error.Clear();
            }
        }
       // string strTrainType = "";

        private void spinLT_EditValueChanged(object sender, EventArgs e)
        {
            //if (lueSettingSubjectSplit.Text != "")
            //{
            //    int theoryNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("TheoryNumber").ToString());
            //    int practiceNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("SectionNumber").ToString());
            //    string trainType = lueSettingSubjectSplit.GetColumnValue("TrainingType").ToString();
            //    int practice = 0;
            //    if (trainType == "Tín chỉ")
            //    {
            //        practice = (practiceNumber * 60) / 40;
            //    }
            //    if (trainType == "Niên chế")
            //    {
            //        practice = (practiceNumber * 60) / 45;
            //    }
            //    int LT = int.Parse(spinLT.Text);
            //    int TH = int.Parse(spinTH.Text);
            //    txtSectionTheory.Text = (theoryNumber * LT).ToString();
            //    txtSectionPractice.Text = (practice * TH).ToString();
            //}
            //else
            //    XtraMessageBox.Show("Bạn chưa chọn mức chia số tiết cho môn !");
        }

        private void txtHoursNumber_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueSettingSubjectSplit_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSettingSubjectSplit.Text != "")
            {
                int theoryNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("TheoryNumber").ToString());
                int practiceNumber = int.Parse(lueSettingSubjectSplit.GetColumnValue("SectionNumber").ToString());
                string trainType = lueSettingSubjectSplit.GetColumnValue("TrainingType").ToString();
                int practice = 0;
                if (trainType == "Tín chỉ")
                {
                    practice = (practiceNumber * 60) / 40;
                }
                if (trainType == "Niên chế")
                {
                    practice = (practiceNumber * 60) / 45;
                }
                int LT = int.Parse(spinLT.Text);
                int TH = int.Parse(spinTH.Text);
                txtSectionTheory.Text = (theoryNumber * LT).ToString();
                txtSectionPractice.Text = (practice * TH).ToString();
            }
            else
                XtraMessageBox.Show("Bạn chưa chọn mức chia số tiết cho môn !");
        }

        private void lueSettingSubjectSplit_Click(object sender, EventArgs e)
        {
           
        }

        private void frmTrain_Subject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
               btnInsert_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnUpdate_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnDelete_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnNew_Click(sender, e);
            }
        }

        private void spinLT_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}