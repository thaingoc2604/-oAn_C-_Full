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
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }     
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void LoadGridControl()
        {
            var query = from c in db.SettingMoneyRates
                        select new { c.MoneyRatesName, c.TrainingInformation.InfoName, c.NumberStudy, c.TheoryMoney, c.PracticeMoney };
            grcSettingMoney.DataSource = query;
        }
        private void LoadLookUpEditMoney()
        {
            var query = from c in db.TrainingInformations
                        select new { c.InfoName, c.TrainType, c.TrainingType, c.LearningType, c.InfoID };
            lueInfo.Properties.DataSource = query;
            lueInfo.Properties.DisplayMember = "InfoName";
            lueInfo.Properties.ValueMember = "InfoID";

        }
        ErrorProvider erro = new ErrorProvider();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        //    try
        //    {
                Config c = db.Configs.SingleOrDefault(k => k.ID == ManagementSASI.Properties.Settings.Default.UserName);
                c.Dean = txtDead.Text;
                c.Trainbueau = txtTrainbueau.Text;
                c.Departmentfinance = txtDepartmentfinance.Text;
                c.DepartmentTrain = txtDepartmentTrain.Text;
                c.MoneyExam = txtMoneyExam.Text;
                c.MoneyProctor = txtMoneyProctor.Text;
                c.Rector = txtRector.Text;
                c.AssociateDean = txtAssociatedean.Text;
                c.RetakeATestCenter = int.Parse(txtMoneyRetakeATestCenter.Text);
                c.RetakeATestEnd = int.Parse(txtMoneyRetakeATestEnd.Text);
                db.SubmitChanges();
                XtraMessageBox.Show("Cập nhật thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //catch
            //{ }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lueInfo.Text == "")
            {
                erro.SetError(lueInfo, "Chưa nhập thông tin");
            }
            else
            {
                if (txtMoneyRatesName.Text == "")
                {
                    erro.SetError(txtMoneyRatesName, "Tên phân hệ tiền");

                }
                else
                {
                    if (cboNumberStudy.Text == "")
                    {
                        erro.SetError(cboNumberStudy, "Số lần học lại");
                    }
                    else
                    {
                        if (txtPracticeMoney.Text == "")
                        {
                            erro.SetError(txtPracticeMoney, "Tiền học thực hành");
                        }
                        else
                        {
                            if (txtTheoryMoney.Text == "")
                            {
                                erro.SetError(txtTheoryMoney, "Tiền học lý thuyết");
                            }
                            else
                            {
                                SettingMoneyRate s = new SettingMoneyRate();
                                s.InfoID = int.Parse(lueInfo.EditValue.ToString());
                                s.MoneyRatesName = txtMoneyRatesName.Text;
                                s.NumberStudy = int.Parse(cboNumberStudy.Text);
                                s.PracticeMoney = int.Parse(txtPracticeMoney.Text);
                                s.TheoryMoney = int.Parse(txtTheoryMoney.Text);
                                db.SettingMoneyRates.InsertOnSubmit(s);
                                db.SubmitChanges();
                                LoadGridControl();
                              
                            }
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            SettingMoneyRate s = db.SettingMoneyRates.SingleOrDefault(c => c.MoneyRatesName == txtMoneyRatesName.Text);
            s.InfoID = int.Parse(lueInfo.EditValue.ToString());
            s.NumberStudy = int.Parse(cboNumberStudy.Text);
            s.PracticeMoney = int.Parse(txtPracticeMoney.Text);
            s.TheoryMoney = int.Parse(txtTheoryMoney.Text);
            db.SubmitChanges();
            LoadGridControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thực sự xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SettingMoneyRate s = db.SettingMoneyRates.SingleOrDefault(c => c.MoneyRatesName == txtMoneyRatesName.Text);
                db.SettingMoneyRates.DeleteOnSubmit(s);
                db.SubmitChanges();
                LoadGridControl();
            }
        }

        private void lueInfo_TextChanged(object sender, EventArgs e)
        {
            if (lueInfo.Text != "")
            {
                erro.Clear();
            }
        }

        private void grcSettingMoney_Click(object sender, EventArgs e)
        {
            
            lueInfo.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "InfoName");
            txtMoneyRatesName.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "MoneyRatesName");
            cboNumberStudy.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "NumberStudy");
            txtPracticeMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "PracticeMoney");
            txtTheoryMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "TheoryMoney");
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
            txtMoneyRatesName.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (ManagementSASI.Properties.Settings.Default.Dean == "" || ManagementSASI.Properties.Settings.Default.Rector == "" || ManagementSASI.Properties.Settings.Default.Departmentfinance == "" || ManagementSASI.Properties.Settings.Default.DepartmentTrain == "" || ManagementSASI.Properties.Settings.Default.Trainbueau == "")
            {
                xtraTabControl1.SelectedTabPageIndex = 1;
            }
            LoadLookUpEditMoney();
            LoadGridControl();

           var query = from c in db.Configs
                       select new { c.MoneyExam,c.MoneyProctor,c.Rector,c.RetakeATestCenter,c.RetakeATestEnd,c.Trainbueau,c.AssociateDean,c.Dean,c.Departmentfinance,c.DepartmentTrain};
           foreach (var item in query)
           {
               txtDead.Text =item.Dean;
               txtTrainbueau.Text = item.Trainbueau;
               txtDepartmentfinance.Text = item.Departmentfinance;
               txtDepartmentTrain.Text = item.DepartmentTrain;
               txtMoneyExam.Text = item.MoneyExam;
               txtMoneyProctor.Text = item.MoneyProctor;
               txtRector.Text = item.Rector;
               txtAssociatedean.Text = item.AssociateDean;
               txtMoneyRetakeATestCenter.Text = item.RetakeATestCenter.ToString();

               txtMoneyRetakeATestEnd.Text= item.RetakeATestEnd.ToString();

           }
            ///////////////

           btnAdd.Enabled = true;
           btnEdit.Enabled = false;
           btnDelete.Enabled = false;
           tedMoneyRatesName.Enabled = false;
           LoadLookUpTrainingInfo();
           LoadMoneyRates();
        }

        private void group_Paint(object sender, PaintEventArgs e)
        {

        }

        bool TestID()
        {
            var id = from c in db.MoneyRatesByClassSASIs
                     select new { c.TrainingInformation.InfoName, c.StudentNumberStart, c.StudentNumberEnd, c.TheoryMoney, c.PracticeMoney };
            foreach (var id1 in id)
            {
                if (id1.InfoName == lueInfoTrain.Text && id1.StudentNumberStart == int.Parse(cboStudentStart.Text) && id1.StudentNumberEnd == int.Parse(txtStudentEnd.Text) && id1.TheoryMoney == int.Parse(cboTheoryMoney.Text) && id1.PracticeMoney == int.Parse(tedPracticeMoney.Text))
                    return false;
            }
            return true;
        }
        bool TestControl()
        {
            foreach (Control c in group.Controls)
            {
                if (c is ComboBoxEdit || c is LookUpEdit)
                {
                    if (c.Text == "")
                        return false;
                }
            }
            return true;
        }
        void ClearControl()
        {
            foreach (Control c in group.Controls)
            {
                if (c is ComboBoxEdit || c is LookUpEdit)
                {
                    c.Text = "";
                }
            }
            txtStudentEnd.Text = "";
            tedPracticeMoney.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }
        void LoadMoneyRates()
        {
            var id = from c in db.MoneyRatesByClassSASIs
                     select new { c.MoneyRatesName, c.TrainingInformation.InfoName, c.StudentNumberStart, c.StudentNumberEnd, c.TheoryMoney, c.PracticeMoney };
            grcMoneyRates.DataSource = id;
        }
        void LoadLookUpTrainingInfo()
        {
            var ti = from c in db.TrainingInformations
                     select new { c.InfoID, c.InfoName, c.TrainType, c.TrainingType, c.LearningType };
            lueInfoTrain.Properties.DataSource = ti;
        }
        string SetName()
        {
            string MoneyRatesName = "";
            int i = grvMoneyRates.RowCount;
            tedMoneyRatesName.Text = (i + 1).ToString();
            MoneyRatesName = lblMuc.Text + " " + tedMoneyRatesName.Text;
            return MoneyRatesName;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ClearControl();
            lueInfoTrain.ClosePopup();
        }
        string muc = "";
        private void grvMoneyRates_Click(object sender, EventArgs e)
        {
            try
            {
                lueInfoTrain.ClosePopup();
                muc = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "MoneyRatesName");
                string[] so = muc.Split(' ');
                tedMoneyRatesName.Text = so[1];
                lueInfoTrain.Text = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "InfoName");
                lueInfoTrain.ClosePopup();
                cboStudentStart.Text = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "StudentNumberStart");

                txtStudentEnd.Text = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "StudentNumberEnd");
                cboTheoryMoney.Text = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "TheoryMoney");
                tedPracticeMoney.Text = grvMoneyRates.GetRowCellDisplayText(grvMoneyRates.FocusedRowHandle, "PracticeMoney");
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;


            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TestControl())
            {
                //if (TestInfoName())
                //{
                if (TestID())
                {
                    MoneyRatesByClassSASI mr = new MoneyRatesByClassSASI();

                    mr.MoneyRatesName = SetName();
                    mr.InfoID = int.Parse(lueInfoTrain.GetColumnValue("InfoID").ToString());
                    mr.StudentNumberStart = int.Parse(cboStudentStart.Text);
                    mr.StudentNumberEnd = int.Parse(txtStudentEnd.Text);
                    mr.TheoryMoney = float.Parse(cboTheoryMoney.Text);
                    mr.PracticeMoney = float.Parse(tedPracticeMoney.Text);
                    db.MoneyRatesByClassSASIs.InsertOnSubmit(mr);
                    db.SubmitChanges();
                    LoadMoneyRates();

                }
                else
                    XtraMessageBox.Show("Đã tồn tại thông tin đào tạo, số sinh viên và số tiền như bạn đã chọn");
                //}
                //else
                //{
                //    XtraMessageBox.Show("Tên thông tin đã tồn tại, bạn vui lòng chọn thông tin khác");
                //    tedInfoName.Focus();
                //}
            }
            else
                XtraMessageBox.Show("Dữ liệu không được phép để trống !");
        }

        private void cboStudentStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TrainingType = lueInfoTrain.GetColumnValue("TrainingType").ToString();
            string TrainType = lueInfoTrain.GetColumnValue("TrainType").ToString();
            if (TrainType == "Đại học - Cao đẳng")
            {
                if (TrainingType == "Tín chỉ")
                {
                    if (cboStudentStart.Text == "8")
                    {
                        txtStudentEnd.Text = "40";
                        cboTheoryMoney.Text = "35000";
                        tedPracticeMoney.Text = "15000";
                    }
                    if (cboStudentStart.Text == "41")
                    {
                        txtStudentEnd.Text = "60";
                        cboTheoryMoney.Text = "40000";
                        tedPracticeMoney.Text = "15000";
                    }
                    if (cboStudentStart.Text == "61")
                    {
                        txtStudentEnd.Text = "100";
                        tedPracticeMoney.Text = "15000";
                        cboTheoryMoney.Text = "";
                    }
                }
                else
                {
                    if (cboStudentStart.Text == "8")
                    {
                        txtStudentEnd.Text = "40";
                        cboTheoryMoney.Text = "30000";
                        tedPracticeMoney.Text = "15000";
                    }
                    if (cboStudentStart.Text == "41")
                    {
                        txtStudentEnd.Text = "60";
                        cboTheoryMoney.Text = "35000";
                        tedPracticeMoney.Text = "15000";
                    }
                    if (cboStudentStart.Text == "61")
                    {
                        txtStudentEnd.Text = "100";
                        tedPracticeMoney.Text = "15000";
                        cboTheoryMoney.Text = "";
                    }
                }
            }
            else
            {
                if (cboStudentStart.Text == "8")
                {
                    txtStudentEnd.Text = "40";
                    cboTheoryMoney.Text = "20000";
                    tedPracticeMoney.Text = "15000";
                }
                if (cboStudentStart.Text == "41")
                {
                    txtStudentEnd.Text = "60";
                    cboTheoryMoney.Text = "25000";
                    tedPracticeMoney.Text = "15000";
                }
                if (cboStudentStart.Text == "61")
                {
                    txtStudentEnd.Text = "100";
                    tedPracticeMoney.Text = "15000";
                    cboTheoryMoney.Text = "";
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TestControl())
                {

                    MoneyRatesByClassSASI mr = db.MoneyRatesByClassSASIs.SingleOrDefault(c => c.MoneyRatesName == muc);
                    mr.InfoID = int.Parse(lueInfoTrain.GetColumnValue("InfoID").ToString());
                    mr.StudentNumberStart = int.Parse(cboStudentStart.Text);
                    mr.StudentNumberEnd = int.Parse(txtStudentEnd.Text);
                    // MessageBox.Show(tedPracticeMoney.Text);
                    mr.TheoryMoney = float.Parse(cboTheoryMoney.Text);
                    mr.PracticeMoney = float.Parse(tedPracticeMoney.Text);
                    db.SubmitChanges();
                    LoadMoneyRates();


                }
                else
                    XtraMessageBox.Show("Dữ liệu không được phép để trống !");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MoneyRatesByClassSASI mr = db.MoneyRatesByClassSASIs.SingleOrDefault(c => c.MoneyRatesName == muc);
                db.MoneyRatesByClassSASIs.DeleteOnSubmit(mr);
                db.SubmitChanges();
                LoadMoneyRates();
            }
        }

        private void frmConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnInsert_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
               btnEdit_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnDelete_Click(sender, e);
            }
            //if (e.KeyCode == Keys.F6)
            //{
            //  (sender, e);
            //}
            if (e.KeyCode == Keys.F7)
            {
                btnAdd_Click(sender, e);
            }
            if (e.KeyCode == Keys.F8)
            {
                simpleButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F9)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void grvSettingMoney_Click(object sender, EventArgs e)
        {
            try
            {
                lueInfo.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "InfoName");
                txtMoneyRatesName.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "MoneyRatesName");
                cboNumberStudy.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "NumberStudy");
                txtPracticeMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "PracticeMoney");
                txtTheoryMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "TheoryMoney");
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMoneyRatesName.Enabled = true;
        }
    }
}