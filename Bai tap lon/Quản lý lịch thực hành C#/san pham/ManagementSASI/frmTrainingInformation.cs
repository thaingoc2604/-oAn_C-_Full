using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace ManagementSASI
{
    public partial class frmTrainingInformation : DevExpress.XtraEditors.XtraForm
    {
        public frmTrainingInformation()
        {
            InitializeComponent();
        }
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        bool TestID()
        {
            var id = from c in db.TrainingInformations
                     select new { c.TrainType, c.TrainingType, c.LearningType };
            foreach (var id1 in id)
            {
                if (id1.TrainType.ToString() == cboTrainType.Text && id1.TrainingType.ToString() == cboTrainingType.Text&&id1.LearningType==cboLearningType.Text)
                    return false;
            }
            return true;
        }
        bool TestInfoName()
        {
            var id = from c in db.TrainingInformations
                     select new { c.InfoName };
            foreach (var id1 in id)
            {
                if (id1.InfoName==tedInfoName.Text)
                    return false;
            }
            return true;
        }
        bool TestControl()
        {
            foreach (Control c in groupTrainInfo.Controls)
            {
                if (c is ComboBoxEdit || c is TextEdit)
                {
                    if (c.Text == "")
                        return false;
                }
            }
            return true;
        }
        void ClearControl()
        {
            foreach (Control c in groupTrainInfo.Controls)
            {
                if (c is ComboBoxEdit || c is TextEdit)
                {
                    c.Text = "";
                }
            }

        }
        void LoadTrainingInfomation()
        {
            var id = from c in db.TrainingInformations
                     select new {  c.InfoName, c.TrainType, c.TrainingType, c.LearningType };
            grcTrainingInformation.DataSource = id;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TestControl())
            {
                if (TestInfoName())
                {
                    if (TestID())
                    {
                        TrainingInformation ti = new TrainingInformation();
                        ti.InfoName = tedInfoName.Text;
                        ti.TrainType = cboTrainType.Text;
                        ti.TrainingType = cboTrainingType.Text;
                        ti.LearningType = cboLearningType.Text;
                        db.TrainingInformations.InsertOnSubmit(ti);
                        db.SubmitChanges();
                        LoadTrainingInfomation(); 
                        try
                        {
                            lue();
                        }
                        catch { }
                    }
                    else
                        XtraMessageBox.Show("Đã tồn tại hệ đào tạo, loại hình đào tạo và loại học như trên");
                }
                else
                {
                    XtraMessageBox.Show("Tên thông tin đã tồn tại, bạn vui lòng chọn thông tin khác");
                    tedInfoName.Focus();
                }
            }
            else
                XtraMessageBox.Show("Dữ liệu không được phép để trống !");
        }

        private void frmTrainingInformation_Load(object sender, EventArgs e)
        {
            LoadTrainingInfomation();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TestControl())
            {
                //if (TestID())
                //{
                    TrainingInformation ti = db.TrainingInformations.SingleOrDefault(c => c.InfoName == tedInfoName.Text);
                    ti.TrainType = cboTrainType.Text;
                    ti.TrainingType = cboTrainingType.Text;
                    ti.LearningType = cboLearningType.Text;
                    db.SubmitChanges();
                    LoadTrainingInfomation();
                    try
                    {
                        lue();
                    }
                    catch { }
                //}
                //else
                //    XtraMessageBox.Show("Đã tồn tại hệ đào tạo, loại hình đào tạo và loại học như trên");
            }
            else
                XtraMessageBox.Show("Dữ liệu không được phép để trống !");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
            btnAdd.Enabled = true;
            tedInfoName.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void grvTrainingInformation_Click(object sender, EventArgs e)
        {
            try
            {
                tedInfoName.Text = grvTrainingInformation.GetRowCellDisplayText(grvTrainingInformation.FocusedRowHandle, "InfoName");
                cboTrainType.Text = grvTrainingInformation.GetRowCellDisplayText(grvTrainingInformation.FocusedRowHandle, "TrainType");
                cboTrainingType.Text = grvTrainingInformation.GetRowCellDisplayText(grvTrainingInformation.FocusedRowHandle, "TrainingType");
                cboLearningType.Text = grvTrainingInformation.GetRowCellDisplayText(grvTrainingInformation.FocusedRowHandle, "LearningType");
                btnAdd.Enabled = false;
                tedInfoName.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?",Application.ProductName.ToString(),MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                TrainingInformation ti = db.TrainingInformations.SingleOrDefault(c => c.InfoName == tedInfoName.Text);
                db.TrainingInformations.DeleteOnSubmit(ti);
                db.SubmitChanges();
                LoadTrainingInfomation();
                try
                {
                    lue();
                }
                catch { }
            }
        }

        private void frmTrainingInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }
        }

        private void frmTrainingInformation_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F3)
            {
                btnAdd_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnEdit_Click(sender, e);
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

        private void groupTrainInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}