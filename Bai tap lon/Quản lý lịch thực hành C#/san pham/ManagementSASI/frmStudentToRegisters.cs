using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.OleDb;
using ADOX;
using System.Xml;

namespace ManagementSASI
{
    public partial class frmStudentToRegisters : DevExpress.XtraEditors.XtraForm
    {
        public frmStudentToRegisters()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        ErrorProvider error = new ErrorProvider();
        TestManageSASI tm = new TestManageSASI();

        private void LoadLookUpEditMoney()
        {
            var query = from c in db.SettingMoneyRates
                        select new { c.NumberStudy, c.TrainingInformation.InfoName, c.PracticeMoney, c.TheoryMoney, c.TrainingInformation.TrainingType, c.TrainingInformation.LearningType };
            lueNumberLearning.Properties.DataSource = query;
            lueNumberLearning.Properties.DisplayMember = "NumberStudy";
        }
        public int TinhTien()
        {
            //try
            //{
                
                string theoryMoney = lueNumberLearning.GetColumnValue("TheoryMoney").ToString();
                string practiceMoney = lueNumberLearning.GetColumnValue("PracticeMoney").ToString();
                string subjectCode = lueSubject.GetColumnValue("SubjectCode").ToString();
                string classCode = lueClass.GetColumnValue("ClassCode").ToString();
                string trainingType = lueNumberLearning.GetColumnValue("TrainingType").ToString();
                var trainCode = from h in db.Classes
                                where h.ClassCode == classCode
                                select new { h.TrainCode };
                string strTrainCode = "";
                foreach (var h1 in trainCode)
                {
                    strTrainCode = h1.TrainCode.ToString();
                }
                var st = from c in db.SubjectTrains
                         where c.SubjectCode == subjectCode && c.TrainCode == strTrainCode
                         select new { c.TheoryNumber, c.PracticeNumber };
                string theory = "", practice = "";
                foreach (var d in st)
                {
                    theory = d.TheoryNumber.ToString();
                    practice = d.PracticeNumber.ToString();
                }
                int moneyTotal = int.Parse(theoryMoney) * int.Parse(theory) + int.Parse(practiceMoney) * int.Parse(practice);
                
            //}
            //catch
            //{ }
            return moneyTotal;
        }
        private void lueNumberLearning_TextChanged(object sender, EventArgs e)
        {
            ////var querysubject = from c in db.Classes
            ////                   where c.ClassName==lueClass.Text
            ////                   select new { c.TrainID};

            //var queryClasses = from c in db.SubjectTrains
            //                   where c.Subject.SubjectName == lueSubject.Text
            //                   select new { c.TrainCode, c.TheoryNumber, c.PracticeNumber };
            //LoadLookUpEditMoney();
            //var query = from c in db.SettingMoneyRates
            //            select new { c.NumberStudy, c.TrainingInformation.InfoName, c.PracticeMoney, c.TheoryMoney };

            //var querySASIClasses = from c in db.SASIClasses
            //                       select new { c.TrainingInformation.InfoName };
            //if (lueNumberLearning.Text != "")
            //{
            //    foreach (var item in query)
            //    {
            //        if (item.NumberStudy == int.Parse(lueNumberLearning.Text))
            //        {

            //            foreach (var l in queryClasses)
            //            {
            //                XtraMessageBox.Show("1");
            //                foreach (var g in querySASIClasses)
            //                {
            //                    //  XtraMessageBox.Show("3");
            //                    if (g.InfoName == item.InfoName)
            //                    {
            //                        // XtraMessageBox.Show("5");
            //                        if (item.NumberStudy == int.Parse(lueNumberLearning.Text))
            //                        {
            //                            //  XtraMessageBox.Show("6");
            //                            txtMoney.Text = (l.PracticeNumber * item.PracticeMoney + l.TheoryNumber * item.TheoryMoney).ToString();

            //                        }
            //                        //}
            //                    }
            //                }

            //                //}
            //            }

            //        }
            //    }
            //}
        }
        //private void thu1()
        //{
        //    StringBuilder s =new StringBuilder( txtMoney.Text);

        //    if (s.Length >3|| s.Length <6 )
        //    {
        //        s.Insert(3, ",");
        //        if (s.Length < 10 || s.Length > 8)
        //        {
        //            s.Insert(7, ",");
        //        }
        //    }

        //    MessageBox.Show(s.ToString());
        //}
        private void frmStudentToRegisters_Load(object sender, EventArgs e)
        {
            rdbManyStudent.Checked = true;
            lueSASIClass.Enabled = false;

            LoadLookUpEditMoney();
            LoadLookUpEditSubject();
            LoadLookUpEditSASIClass();
            LoadLookUpEditClasses();
            lueSubject.Enabled = false;
            btnImport.Enabled = false;
            btnAdd.Enabled = false;
            if (frmSASIClass.ClassID != "" && frmSASIClass.ClassName != "")
            {
                lueSubject.Enabled = true;
                lueSASIClass.Enabled = true;
                lueSASIClass.EditValue = frmSASIClass.ClassID;
                lueSASIClass.Text = frmSASIClass.ClassName;
                //rdbManyStudent.Checked = false;
                lueSubject.Enabled = true;

                //----------------------------------------
                var query = from c in db.SASIClasses
                            where c.SASIClassID == int.Parse(frmSASIClass.ClassID)
                            select new { c.SASIClassID, c.TrainingInformation.LearningType };
                foreach (var item in query)
                {
                    if (item.LearningType == "Học lại, cải thiện")
                    {
                        rdbSASI.Checked = true;
                    }
                    if (item.LearningType == "Cải thiện")
                    {
                        rdbSI.Checked = true;
                    }
                    if (item.LearningType == "Học lại")
                    {
                        rdbSA.Checked = true;
                    }
                    if (item.LearningType == "Thi lại kết thúc học phần")
                    {
                        rdbRetakeATestEnd.Checked = true;
                    }

                    if (item.LearningType == "Thi lại giữa học phần")
                    {
                        rdbRetakeATestCenter.Checked = true;
                    }
                }



            }

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            //  thu = true;
            grOneStudent.Visible = false;
            btnAdd.Enabled = false;
            grcManyStudent.Dock = DockStyle.Top;

        }

        /// <summary>
        /// load du lieu vao lookupedit lop hoc lai
        /// </summary>
        public void LoadLookUpEditSASIClass()
        {
            if (rdbRetakeATestCenter.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại giữ học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbRetakeATestEnd.Checked == true)
            {
                //var query = from c in db.SASIClasses
                //            join h in db.StudentToRegisters
                //            on
                //            new { c.SASIClassID }
                //           equals
                //            new { h.SASIClassID }
                //            where h.MoneyRetakeATestEnd != 0
                //            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID,c.TrainingInformation.LearningType,c.TrainingInformation.TrainingType };
                //lueSASIClass.Properties.DataSource = query;
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại kết thúc học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbSA.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbSI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbSASI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại, cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
        }

        /// <summary>
        /// load du lieu vao lookupedit giao vien
        /// </summary>


        /// <summary>
        /// load du lieu vao lookupedit lop 
        /// </summary>
        private void LoadLookUpEditClasses()
        {
            var query = from c in db.Classes
                        orderby c.ClassCode descending
                        select new { c.ClassCode, c.ClassName };
            lueClass.Properties.DataSource = query;
        }

        /// <summary>
        ///load du lieu vao lookupedit mon 
        /// </summary>
        private void LoadLookUpEditSubject()
        {
            var query = from c in db.Subjects
                        orderby c.SubjectCode descending
                        select new { c.SubjectCode, c.SubjectName };
            lueSubject.Properties.DataSource = query;
        }

        // /// <summary>
        // /// load du lieu vao gridcontrol
        // /// </summary>
        public void LoadGridControl()
        {
            grcStudentToRegister.DataSource = db.SelectStudentToRegister();
        }



        // /// <summary>
        // /// su kien click lay du lieu
        // /// </summary>
        // /// <param name="sender"></param>
        // /// <param name="e"></param>
        private void grcStudentToRegister_Click(object sender, EventArgs e)
        {
            try
            {
                lueSubject.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "SubjectName");
                lueClass.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "ClassName");
                //lueTeacher.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "TeacherName");
                txtStudentID.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Mã_sinh_viên").Substring(0, 5);
                txtID.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Mã_sinh_viên").Substring(5, 3);
                txtStudentName.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tên_sinh_viên");
                lueSASIClass.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "SASIClassName");
                var query = from c in db.StudentToRegisters
                            where c.SubjectCode == grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Mã_sinh_viên").ToString()
                            select new { c.BirthDay, c.Description, c.PeoplePay };
                foreach (var item in query)
                {
                    dtpBirthDay.Text = item.BirthDay.ToShortDateString();
                    mmeDescription.Text = item.Description;
                    txtPeoplePay.Text = item.PeoplePay;
                }

                lueNumberLearning.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Số_lần_học");

                txtReceipt.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Receipt");
                //txtPeoplePay.Text = grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "PeoplePay");
                if (grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_thi_lại_kết_thúc_học_kì") != "0")
                {
                    rdbRetakeATestEnd.Checked = true;
                    txtMoney.Text = String.Format("{0,0:0}", float.Parse(grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_thi_lại_kết_thúc_học_kì")));
                }
                if (grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_thi_lại_giữa_học_kì") != "0")
                {
                    rdbRetakeATestCenter.Checked = true;
                    txtMoney.Text = String.Format("{0,0:0}", float.Parse(grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_thi_lại_giữa_học_kì")));
                }
                if (grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_học_lại") != "0")
                {
                    rdbSA.Checked = true;
                    txtMoney.Text = String.Format("{0,0:0}", float.Parse(grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_học_lại")));
                }
                if (grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_học_cải_thiện") != "0")
                {
                    rdbSI.Checked = true;
                    txtMoney.Text = String.Format("{0,0:0}", float.Parse(grvSudentToRegister.GetRowCellDisplayText(grvSudentToRegister.FocusedRowHandle, "Tiền_học_cải_thiện")));

                }
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                lueSubject.Enabled = false;
                lueSubject.ClosePopup();
                btnImport.Enabled = false;
                lueSASIClass.ClosePopup();
                lueNumberLearning.ClosePopup();
            }
            catch { }
        }

        // /// <summary>
        // /// kiem tra ma trung
        // /// </summary>
        // /// <param name="classes"></param>
        // /// <param name="money"></param>
        // /// <param name="student"></param>
        // /// <param name="subject"></param>
        // /// <param name="teacher"></param>
        // /// <returns></returns>
        private bool TestID(int sasiclasses, string student)
        {
            var query = from c in db.StudentToRegisters
                        select new { c.SASIClassID, c.StudentCode };
            foreach (var c in query)
            {
                if (student == c.StudentCode && sasiclasses == c.SASIClassID)
                {
                    return false;
                }
            }
            return true;
        }

        private void cboNumberStudy_TextChanged(object sender, EventArgs e)
        {
            if (lueNumberLearning.Text != "")
            {
                error.Clear();
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text != "")
            {
                error.Clear();
            }
        }


        /// <summary>
        /// header cua gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvSudentToRegister_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (ManagementSASI.frmTrain.MyGridView.IsCondition(e.Column))
            {
                Font headerFont = grvSudentToRegister.PaintAppearance.HeaderPanel.Font;
                e.Appearance.Font = new Font(headerFont, headerFont.Bold ? FontStyle.Underline | FontStyle.Bold : FontStyle.Underline);
            }
        }
        bool indi = true;
        private void grvSudentToRegister_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = "TT:" + (int.Parse(e.RowHandle.ToString()) + 1).ToString();
                if (!indi)
                {
                    e.Info.ImageIndex = -1;
                }
            }

        }


        private void btnSubject_Click(object sender, EventArgs e)
        {
            frmSubject t = new frmSubject();
            t.ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher t = new frmTeacher();
            t.ShowDialog();
        }

        // private void mmeDescription_EditValueChanged(object sender, EventArgs e)
        // {

        // }

        // /// <summary>
        // /// Import du lieu
        // /// </summary>
        // /// <param name="sender"></param>
        // /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (lueSASIClass.Text == "")
            {
                error.SetError(lueSASIClass, "Bạn chưa nhập lớp học lại "); lueSASIClass.Focus();
            }
            else
            {
                if (lueSubject.Text == "")
                {
                    error.SetError(lueSubject, "Bạn chưa nhập môn học "); lueSubject.Focus();
                }
                else
                {

                    if (txtReceipt.Text == "")
                    {
                        error.SetError(txtReceipt, "Bạn chưa chọn lớp"); txtReceipt.Focus();
                    }
                    else
                    {
                        if (txtPeoplePay.Text == "")
                        {
                            error.SetError(txtPeoplePay, "Bạn chưa chọn lớp"); txtPeoplePay.Focus();
                        }
                        else
                        {
                            OpenFileDialog fdlg = new OpenFileDialog();
                            fdlg.Title = "Chọn file";
                            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
                            fdlg.FilterIndex = 1;
                            fdlg.RestoreDirectory = true;
                            if (fdlg.ShowDialog() == DialogResult.OK)
                            {
                                string fileName = fdlg.FileName;
                                int viTriBatDau = fileName.LastIndexOf('\\') + 1;
                                string tenFile = fileName.Substring(viTriBatDau);
                                string path = fileName.Replace("\\", "\\\\");
                                Import(path);
                                Application.DoEvents();
                                int j = 0;
                                double Total = 0;
                                for (int i = 0; i < grvSudentToRegister.RowCount; i++)
                                {
                                    StudentToRegister t = new StudentToRegister();
                                    bool ok = true;
                                    bool ok1 = true;
                                    var query = from c in db.StudentToRegisters
                                                select new { c.StudentCode, c.Class.ClassName, c.ClassCode, c.SubjectCode, c.NumberStudy, c.SASIClassID };
                                    foreach (var item in query)
                                    {
                                        if (item.StudentCode == grvSudentToRegister.GetRowCellDisplayText(i, "Mã_sinh_viên").ToString() && item.SASIClassID == int.Parse(lueSASIClass.EditValue.ToString()))
                                        {
                                            XtraMessageBox.Show("Sinh viên " + grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString() + "," + grvSudentToRegister.GetRowCellValue(i, "Tên_sinh_viên").ToString() + " này đã đăng kí rồi", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ok = false;
                                            break;

                                            if (item.ClassCode == grvSudentToRegister.GetRowCellDisplayText(i, "Mã_lớp").ToString().ToUpper())
                                            {
                                                ok1 = true;
                                                break;
                                            }
                                        }
                                    }
                                    bool ok2 = true;
                                    var query1 = db.StudentTimeStudy();
                                    foreach (var item in query1)
                                    {
                                        if (item.StudentCode == grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString() && item.subjectCode == lueSubject.EditValue.ToString() && item.NumberTimeStudy >= 3)
                                        {
                                            ok2 = false;
                                            break;
                                        }
                                    }


                                    if (ok2 == true)
                                    {
                                        if (ok == true)
                                        {
                                            if (ok1 == true)
                                            {
                                                if (grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString().Length == 8)
                                                {
                                                    t.StudentCode = grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString();
                                                    t.StudentName = tm.Standardized(grvSudentToRegister.GetRowCellValue(i, "Tên_sinh_viên").ToString());
                                                    t.ClassCode = grvSudentToRegister.GetRowCellValue(i, "Mã_lớp").ToString();
                                                    t.SASIClassID = int.Parse(lueSASIClass.EditValue.ToString());
                                                    t.BirthDay = DateTime.Parse(grvSudentToRegister.GetRowCellValue(i, "Ngày_sinh").ToString());
                                                    t.SubjectCode = lueSubject.EditValue.ToString();
                                                    t.NumberStudy = int.Parse(grvSudentToRegister.GetRowCellValue(i, "Số_lần_học").ToString());
                                                    t.RegisterDay = DateTime.Now;
                                                    t.PeoplePay = txtPeoplePay.Text;
                                                    t.MoneySA = int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_học_lại").ToString());
                                                    t.MoneySI = int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_học_cải_thiện").ToString());
                                                    t.MoneyRetakeATestCenter = int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_thi_lại_giữa_học_kì").ToString());
                                                    t.MoneyRetakeATestEnd = int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_thi_lại_kết_thúc_học_kì").ToString());
                                                    t.Receipt = int.Parse(txtReceipt.Text);
                                                    t.Description = grvSudentToRegister.GetRowCellValue(i, "Ghi_chú").ToString();
                                                    db.StudentToRegisters.InsertOnSubmit(t);
                                                    db.SubmitChanges();
                                                    j++;
                                                    Total = Total + (int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_học_lại").ToString()) + int.Parse(grvSudentToRegister.GetRowCellValue(i, "Tiền_học_cải_thiện").ToString()));
                                                }

                                                else
                                                {
                                                    XtraMessageBox.Show("Mã sinh viên " + grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString() + "," + grvSudentToRegister.GetRowCellValue(i, "Tên_sinh_viên").ToString() + " này sai mã không đủ 6 ký tự", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }

                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("Lớp này không tồn tại " + grvSudentToRegister.GetRowCellValue(i, "Mã_lớp").ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }


                                        }
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Mã sinh viên " + grvSudentToRegister.GetRowCellValue(i, "Mã_sinh_viên").ToString() + "," + grvSudentToRegister.GetRowCellValue(i, "Tên_sinh_viên").ToString() + " này đã quá 3 lần", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }


                                }

                                LoadStudentToRegisterToSASIClassName();
                                //ClearControls();
                            }
                        }

                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
        public static string SelectedTable = string.Empty;




        public void Import(string strPart)
        {
            //try
            //{
            string[] strTable = GetTableExcel(strPart);
            frmSelectTableExcel frm = new frmSelectTableExcel(strTable);
            frm.ShowDialog(this);
            frm.Dispose();
            if ((SelectedTable != string.Empty) && (SelectedTable != null))
            {
                #region
                //DataTable dtbHocSinhExcel = DataTableExcel(path, SelectedTable);
                //DataTable hocSinhTable = DataTableStudent();
                //BindingSource bS = new BindingSource();
                //bS.DataSource = DataTableStudent();
                //dGV.DataSource = bS;
                //int rowSuccess = 0;
                //for (int i = 0; i < dtbHocSinhExcel.Rows.Count; i++)
                //{

                //    bool t = false;
                //    if (hocSinhTable.Rows.Count == 0)
                //        t = true;
                //    else
                //        t = false;
                //    for (int j = 0; j < hocSinhTable.Rows.Count; j++)
                //    {
                //        if (dtbHocSinhExcel.Rows[i][0].ToString() != hocSinhTable.Rows[j][0].ToString())
                //        {
                //            t = true;
                //        }
                //        else
                //        {
                //            t = false;
                //            j = hocSinhTable.Rows.Count;
                //        }
                //    }
                //    if (t)
                //    {
                //        DataRow rowthem = hocSinhTable.NewRow();
                //        rowthem[0] = dtbHocSinhExcel.Rows[i][0];
                //        rowthem[1] = dtbHocSinhExcel.Rows[i][1];
                //            rowthem[3] = dtbHocSinhExcel.Rows[i][2];
                //            rowthem[4] = dtbHocSinhExcel.Rows[i][3];
                //            hocSinhTable.Rows.Add(rowthem);
                //            rowSuccess++;
                //    }
                //}
                //MessageBox.Show("Số dòng đã được thêm: " + rowSuccess.ToString() + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
                DataTable dt = GetDataTableExcel(strPart, SelectedTable);
                grcStudentToRegister.DataSource = dt.DefaultView;
            }
            //}
            //catch { }


        }

        // /// <summary>
        // /// lay ban trong excle
        // /// </summary>
        // /// <param name="strFileName"></param>
        // /// <returns></returns>
        // /// 
        // //string url = op.FileName.ToString();
        // //            string connectExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + url + "';Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\""
        public static String[] GetTableExcel(string strFileName)
        {
            string[] strTables = new string[100];
            Catalog oCatlog = new Catalog();
            ADOX.Table otable = new ADOX.Table();
            ADODB.Connection oconn = new ADODB.Connection();
            string re = strFileName.Substring(strFileName.Length - 3);
            if (re == "xls")
            {
                oconn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);

            }
            else
            {
                oconn.Open("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);
            }
            oCatlog.ActiveConnection = oconn;
            if (oCatlog.Tables.Count > 0)
            {
                int item = 0;
                foreach (ADOX.Table tab in oCatlog.Tables)
                {
                    if (tab.Type == "TABLE")
                    {
                        strTables[item] = tab.Name;
                        item++;
                    }
                }
            }
            return strTables;
        }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="strFileName"></param>
        // /// <param name="Table"></param>
        // /// <returns></returns>
        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            string re = strFileName.Substring(strFileName.Length - 3);
            OleDbConnection conn;
            if (re == "xls")
            {
                conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            }
            else
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            }
            conn.Open();
            string strQuery = "SELECT*FROM [" + Table + "]";
            OleDbDataAdapter da = new OleDbDataAdapter(strQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        // /// <summary>
        // /// xoa rong control 
        // /// </summary>
        private void ClearControls()
        {
            lueSASIClass.EditValue = -1;

            lueSubject.EditValue = "";
            lueNumberLearning.EditValue = 0;
            foreach (Control a in this.grOneStudent.Controls)
            {
                if (a is DevExpress.XtraEditors.TextEdit)
                {
                    a.Text = "";
                }
            }
            lueClass.EditValue = "";
            txtReceipt.Text = "";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            //lueSASIClass.Enabled = true;

            lueSubject.Enabled = false;
            if (rdbManyStudent.Checked == true)
            {
                btnImport.Enabled = true;
                btnAdd.Enabled = false;
            }
            if (rdbOnceStudent.Checked == true)
            {
                btnImport.Enabled = false;
                btnAdd.Enabled = true;
            }

        }

        private void btnClearText_Click_1(object sender, EventArgs e)
        {

            ClearControls();
            LoadLookUpEditSASIClass();
            LoadLookUpEditSubject();

            if (rdbSA.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbSI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbSASI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại, cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbRetakeATestCenter.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại giữa học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
            if (rdbRetakeATestEnd.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại kết thúc học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
            }
        }



        // private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        // {
        //     DateTime dt = DateTime.Parse(dtpBirthDay.Text);
        //     DateTime dt1 = DateTime.Now;
        //     if (dt1.Year - dt.Year > 16)
        //     {

        //         error.Clear();
        //     }
        // }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                error.Clear();
            }
        }

        TestManageSASI testmana = new TestManageSASI();
        static bool test = true;




        private void btnSubject_Click_1(object sender, EventArgs e)
        {
            frmSubject subject = new frmSubject();
            subject.lue = new frmSubject.LoadLookUpEdit(LoadLookUpEditSubject);
            subject.ShowDialog();
        }
        public static bool thu = false;
        static frmSASIClass frmSASIclass = null;
        private void btnSASIClass_Click(object sender, EventArgs e)
        {
            this.Dispose();
            testmana.ShowfrmSASIClass();
        }

        private void lueSASIClass_TextChanged(object sender, EventArgs e)
        {
            bool ok = true;
            var query = from c in db.StudentToRegisters
                        select new { c.ClassCode, c.SASIClassID, c.SubjectCode };
            foreach (var item in query)
            {
                if (item.SASIClassID == int.Parse(lueSASIClass.EditValue.ToString()))
                {
                    lueSubject.Enabled = false;
                    ok = false;
                    lueSubject.EditValue = item.SubjectCode; ;

                }
            }
            if (ok == false)
            {
                lueSubject.Enabled = false;
            }
            if (ok == true)
            {
                lueSubject.Enabled = true;
                lueSubject.EditValue = "";

            }
            LoadStudentToRegisterToSASIClassName();
        }


        private void LoadStudentToRegisterToSASIClassName()
        {
            var query = db.SelectStudentToRegisterToSASIClassName(lueSASIClass.Text);
            grcStudentToRegister.DataSource = query;
        }

        private void btnNotClassSASI_Click(object sender, EventArgs e)
        {
            frmTestClassSASINotYet t = new frmTestClassSASINotYet();
            t.ShowDialog();
        }

        private void lueSASIClass_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void lueClass_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                if (lueNumberLearning.Text == "" || int.Parse(lueNumberLearning.Text) <= 0)
                {
                    error.SetError(lueNumberLearning, "Bạn xem lại số lần học lại"); lueNumberLearning.Focus();
                }
                else
                {
                    error.Clear();

                    error.Clear();
                    if (txtStudentName.Text == "")
                    {
                        error.SetError(txtStudentName, "Bạn chưa nhập sinh viên hoặc nhập sai tên sinh viên"); txtStudentName.Focus();
                    }
                    else
                    {

                        error.Clear();
                        if (lueSubject.Text == "")
                        {
                            error.SetError(lueSubject, "Bạn chưa nhập môn học "); lueSubject.Focus();
                        }
                        else
                        {
                            error.Clear();

                            if (txtMoney.Text == "")
                            {
                                error.SetError(txtMoney, "Bạn chưa nhập tiền học lai"); txtMoney.Focus();
                            }
                            else
                            {
                                if (txtReceipt.Text == "")
                                {
                                    error.SetError(txtReceipt, "Bạn chưa chọn lớp"); txtReceipt.Focus();
                                }
                                else
                                {
                                        error.Clear();
                                        DateTime dt = DateTime.Parse(dtpBirthDay.Text);
                                        DateTime dt1 = DateTime.Now;
                                        if (dt1.Year - dt.Year <= 15 || dt1.Year - dt.Year > 85)
                                        {
                                            error.SetError(dtpBirthDay, "Bạn xem lại ngày sinh"); txtMoney.Focus();
                                        }
                                        else
                                        {
                                            bool ok2 = true;
                                            var query1 = db.StudentTimeStudy();
                                            foreach (var item in query1)
                                            {
                                                if (item.StudentCode == txtStudentID.Text + txtID.Text && item.subjectCode == lueSubject.EditValue.ToString() && item.NumberTimeStudy >= 3)
                                                {
                                                    ok2 = false;
                                                    break;
                                                }
                                            }


                                            if (ok2 == true)
                                            {

                                                if (TestID(int.Parse(lueSASIClass.EditValue.ToString()), (txtStudentID.Text + txtID.Text)))
                                                {
                                                    StudentToRegister s = new StudentToRegister();
                                                    s.StudentCode = (txtStudentID.Text + txtID.Text);
                                                    s.StudentName = tm.Standardized(txtStudentName.Text);
                                                    s.BirthDay = DateTime.Parse(dtpBirthDay.Text);
                                                    s.ClassCode = lueClass.EditValue.ToString();
                                                    if (rdbSI.Checked == true)
                                                    {
                                                        s.MoneySI = int.Parse(txtMoney.Text);
                                                        s.MoneyRetakeATestCenter = 0;
                                                        s.MoneyRetakeATestEnd = 0;
                                                        s.MoneySA = 0;
                                                    }
                                                    if (rdbSA.Checked == true)
                                                    {
                                                        s.MoneySA = int.Parse(txtMoney.Text);
                                                        s.MoneyRetakeATestCenter = 0;
                                                        s.MoneyRetakeATestEnd = 0;
                                                        s.MoneySI = 0;
                                                    }
                                                    if (rdbRetakeATestEnd.Checked == true)
                                                    {
                                                        s.MoneyRetakeATestEnd = int.Parse(txtMoney.Text);
                                                        s.MoneyRetakeATestCenter = 0;
                                                        s.MoneySA = 0;
                                                        s.MoneySI = 0;
                                                    }
                                                    if (rdbRetakeATestCenter.Checked == true)
                                                    {
                                                        s.MoneyRetakeATestCenter = int.Parse(txtMoney.Text);
                                                        s.MoneySA = 0;
                                                        s.MoneyRetakeATestEnd = 0;
                                                        s.MoneySI = 0;
                                                    }
                                                    s.PeoplePay = txtStudentName.Text;
                                                    s.Receipt = int.Parse(txtReceipt.Text);
                                                    s.NumberStudy = int.Parse(lueNumberLearning.Text);
                                                    s.RegisterDay = DateTime.Now;
                                                    s.Description = mmeDescription.Text;
                                                    s.SubjectCode = lueSubject.EditValue.ToString();
                                                    s.SASIClassID = int.Parse(lueSASIClass.EditValue.ToString());
                                                    db.StudentToRegisters.InsertOnSubmit(s);
                                                    db.SubmitChanges();
                                                    LoadStudentToRegisterToSASIClassName();

                                                }
                                                else
                                                {
                                                    XtraMessageBox.Show("Bạn hãy xem lại thông tin lớp của sinh viên không được trùng nhau", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("Mã sinh viên " + txtStudentID.Text + txtID.Text + "," + txtStudentName.Text + " này đã quá 3 lần", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                if (lueNumberLearning.Text == "" || int.Parse(lueNumberLearning.Text) <= 0)
                {
                    error.SetError(lueNumberLearning, "Bạn xem lại số lần học lại"); lueNumberLearning.Focus();
                }
                else
                {
                    error.Clear();

                    error.Clear();
                    if (txtStudentName.Text == "")
                    {
                        error.SetError(txtStudentName, "Bạn chưa nhập sinh viên hoặc nhập sai tên sinh viên"); txtStudentName.Focus();
                    }
                    else
                    {

                        error.Clear();
                        if (lueSubject.Text == "")
                        {
                            error.SetError(lueSubject, "Bạn chưa nhập môn học "); lueSubject.Focus();
                        }
                        else
                        {
                            error.Clear();

                            if (txtMoney.Text == "")
                            {
                                error.SetError(txtMoney, "Bạn chưa nhập tiền học lai"); txtMoney.Focus();
                            }
                            else
                            {
                                if (txtReceipt.Text == "")
                                {
                                    error.SetError(txtReceipt, "Bạn chưa chọn lớp"); txtReceipt.Focus();
                                }
                                else
                                {
                                    if (txtPeoplePay.Text == "")
                                    {
                                        error.SetError(txtPeoplePay, "Bạn chưa chọn lớp"); txtPeoplePay.Focus();
                                    }
                                    else
                                    {
                                        error.Clear();
                                        DateTime dt = DateTime.Parse(dtpBirthDay.Text);
                                        DateTime dt1 = DateTime.Now;
                                        if (dt1.Year - dt.Year <= 15 || dt1.Year - dt.Year > 85)
                                        {
                                            error.SetError(dtpBirthDay, "Bạn xem lại ngày sinh"); txtMoney.Focus();
                                        }
                                        else
                                        {
                                            if (XtraMessageBox.Show("Bạn có muốn thực sự sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                            {
                                                StudentToRegister s = db.StudentToRegisters.SingleOrDefault(c => c.StudentCode == (txtStudentID.Text + txtID.Text) && c.StudentCode == lueSubject.EditValue.ToString() && c.NumberStudy == int.Parse(lueNumberLearning.Text));
                                                if (s != null)
                                                {
                                                    s.StudentName = tm.Standardized(txtStudentName.Text);
                                                    s.BirthDay = DateTime.Parse(dtpBirthDay.Text);
                                                    s.ClassCode = lueClass.EditValue.ToString();
                                                    if (rdbSI.Checked == true)
                                                    {
                                                        s.MoneySI = int.Parse(txtMoney.Text);
                                                    }
                                                    if (rdbSA.Checked == true)
                                                    {
                                                        s.MoneySA = int.Parse(txtMoney.Text);
                                                    }
                                                    if (rdbRetakeATestEnd.Checked == true)
                                                    {
                                                        s.MoneyRetakeATestEnd = int.Parse(txtMoney.Text);
                                                    }
                                                    if (rdbRetakeATestCenter.Checked == true)
                                                    {
                                                        s.MoneyRetakeATestCenter = int.Parse(txtMoney.Text);
                                                    }
                                                    s.PeoplePay = txtPeoplePay.Text;
                                                    s.Receipt = int.Parse(txtReceipt.Text);
                                                    s.RegisterDay = DateTime.Now;
                                                    s.Description = mmeDescription.Text;
                                                    db.SubmitChanges();
                                                    LoadStudentToRegisterToSASIClassName();
                                                    ClearControls();
                                                }

                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                if (lueNumberLearning.Text == "" || int.Parse(lueNumberLearning.Text) <= 0)
                {
                    error.SetError(lueNumberLearning, "Bạn xem lại số lần học lại"); lueNumberLearning.Focus();
                }
                else
                {
                    error.Clear();
                    if (lueSubject.Text == "")
                    {
                        error.SetError(lueSubject, "Bạn chưa nhập môn học "); lueSubject.Focus();
                    }
                    else
                    {
                        if (TestID(int.Parse(lueSASIClass.EditValue.ToString()), (txtStudentID.Text + txtID.Text)) == false)
                        {
                            if (XtraMessageBox.Show("Bạn chắc muốn xóa không", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            {

                                StudentToRegister s = db.StudentToRegisters.SingleOrDefault(c => c.StudentCode == (txtStudentID.Text + txtID.Text) && c.SASIClassID == int.Parse(lueSASIClass.EditValue.ToString()));

                                if (s != null)
                                {
                                    db.StudentToRegisters.DeleteOnSubmit(s);
                                    db.SubmitChanges();
                                    LoadStudentToRegisterToSASIClassName();
                                    //ClearControls();
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Xóa không thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rdbSA_Click(object sender, EventArgs e)
        {
            //lueSASIClass.Enabled = true;
            //lueNumberLearning.EditValue= "";
            //txtMoney.Text = "";
        }

        private void rdbSI_Click(object sender, EventArgs e)
        {
            lueSASIClass.Enabled = true; lueNumberLearning.EditValue = "";
            txtMoney.Text = "";
        }

        private void rdbRetakeATestEnd_Click(object sender, EventArgs e)
        {

        }

        private void rdbRetakeATestCenter_Click(object sender, EventArgs e)
        {

        }

        private void txtReceipt_TextChanged(object sender, EventArgs e)
        {
            if (txtReceipt.Text != "")
            {
                error.Clear();
            }
        }

        private void txtPeoplePay_TextChanged(object sender, EventArgs e)
        {
            if (txtPeoplePay.Text != "")
            {
                error.Clear();
            }
        }

        private void lueClass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueTeacher_EditValueChanged(object sender, EventArgs e)
        {
            txtReceipt.Focus();
        }

        private void rdbRetakeATestEnd_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRetakeATestEnd.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại kết thúc học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
                var money = from c in db.Configs
                            select new { c.RetakeATestEnd};
                txtMoney.Text = money.ToString();
            }
            lueSASIClass.Enabled = true;
            lueNumberLearning.Text = "1";
            lueNumberLearning.ClosePopup();

            //var query = db.LoadSASIClassRetakeTest();
            //lueSASIClass.Properties.DataSource = query;

        }

        private void rdbRetakeATestCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRetakeATestCenter.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Thi lại giữa học phần"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID };
                lueSASIClass.Properties.DataSource = query;
                var money = from c in db.Configs
                            select new { c.RetakeATestCenter };
                txtMoney.Text = money.ToString();

            }
            lueSASIClass.Enabled = true;
            lueNumberLearning.Text = "1";
            lueNumberLearning.ClosePopup();
        }

        private void rdbSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSA.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
                lueSASIClass.Enabled = true;
            }
            if (rdbSI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            join h in db.StudentToRegisters
                            on
                            new { c.SASIClassID }
                           equals
                            new { h.SASIClassID }
                            where h.MoneySA != 0 || h.MoneySI != 0
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
                lueSASIClass.Enabled = true;
            }

            lueNumberLearning.EditValue = "";
            lueNumberLearning.Text = "";
            txtMoney.Text = "";

        }

        private void rdbSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbSI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
            }
            lueSASIClass.Enabled = true;
            lueNumberLearning.EditValue = "";
            lueNumberLearning.Text = "";
            txtMoney.Text = "";
        }

        private void frmStudentToRegisters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F2)
            {
                btnImport_Click(sender, e);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                btnAdd_Click(sender, e);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                btnEdit_Click(sender, e);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                btnDelete_Click(sender, e);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F6)
            {
                btnClearText_Click_1(sender, e);
            }
            if (e.KeyCode == System.Windows.Forms.Keys.F7)
            {
                btnNotClassSASI_Click(sender, e);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //foreach (Control c in groupControl1.Controls)
            //{
            //    if (c is DevExpress.XtraEditors.TextEdit || c is DevExpress.XtraEditors.LookUpEdit)
            //        c.Text = "";
            //}           
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadClassID()
        {
            //try
            //{
                string s = "";
                var query = from c in db.Classes
                            where c.ClassName==lueClass.Text
                            select new { c.ClassCode };
                foreach (var item in query)
                {
                    txtStudentID.Text = item.ClassCode.Substring(0, 5);
                    s = item.ClassCode;
                }
            //}
            //catch { }
            //return s.Substring(0, 5);
        }
        private void lueClass_TextChanged(object sender, EventArgs e)
        {
            loadClassID();
        }

        private void rdbManyStudent_CheckedChanged(object sender, EventArgs e)
        {
            grOneStudent.Visible = false;
            grcManyStudent.Dock = DockStyle.Top;
            lueSASIClass.Enabled = false;
            rdbSI.Checked = false;
            rdbSA.Checked = false;
            rdbRetakeATestCenter.Checked = false;
            rdbRetakeATestEnd.Checked = false;
            rdbSASI.Checked = false;
            lueSASIClass.Enabled = false;
            lueSubject.Enabled = false;
            txtReceipt.Enabled = false;
            txtPeoplePay.Enabled = false;
            ClearControls();
            //grcManyStudent.Enabled = false;
            // groupControl1.Anchor = AnchorStyles.Right;
        }

        private void rdbOnceStudent_CheckedChanged(object sender, EventArgs e)
        {
            grOneStudent.Visible = true;
            lueClass.Enabled = false;
            txtID.Enabled = false;
            txtStudentName.Enabled = false;
            lueNumberLearning.Enabled = false;
            dtpBirthDay.Enabled = false;
            mmeDescription.Enabled = false;
            grcManyStudent.Dock = DockStyle.None;
            lueSASIClass.Enabled = false;
            rdbSI.Checked = false;
            rdbSA.Checked = false;
            rdbRetakeATestCenter.Checked = false;
            rdbRetakeATestEnd.Checked = false;
            rdbSASI.Checked = false;
            btnAdd.Enabled = true;
            btnImport.Enabled = false;
            txtPeoplePay.Enabled = false;
            ClearControls();

        }

        private void rdbSASI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSASI.Checked == true)
            {
                var query = from c in db.SASIClasses
                            where c.TrainingInformation.LearningType == "Học lại, cải thiện"
                            select new { c.SASIClassName, c.Status, c.Semester, c.ShoolYear, c.DateSASIClass, c.SASIClassID, c.TrainingInformation.LearningType, c.TrainingInformation.TrainingType };
                lueSASIClass.Properties.DataSource = query;
            }

            lueSASIClass.Enabled = true;
            lueNumberLearning.EditValue = "";
            lueNumberLearning.Text = "";
            txtMoney.Text = "";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var query = from c in db.Students
                        select new { c.Birthday, c.StudentCode, c.FullName };
            foreach (var item in query)
            {
                if (txtStudentID.Text + txtID.Text == item.StudentCode)
                {
                    txtStudentName.Text = item.FullName;
                    dtpBirthDay.Text = item.Birthday;
                }
            }
        }

        private void lueSASIClass_EditValueChanged(object sender, EventArgs e)
        {
            lueSubject.Enabled = true;
        }

        private void lueSubject_EditValueChanged(object sender, EventArgs e)
        {
            txtReceipt.Enabled = true;

        }

        private void txtReceipt_EditValueChanged(object sender, EventArgs e)
        {
            if (rdbManyStudent.Checked == true)
            {
                txtPeoplePay.Enabled = true;
            }
            if (rdbOnceStudent.Checked == true)
            {
                txtPeoplePay.Enabled = false;
                lueClass.Enabled = true;
            }
        }

        private void lueClass_EditValueChanged_1(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            loadClassID();
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            txtStudentName.Enabled = true;
        }

        private void txtStudentName_EditValueChanged(object sender, EventArgs e)
        {
            dtpBirthDay.Enabled = true;
            lueNumberLearning.Enabled = true;
        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            lueNumberLearning.Enabled = true;
        }

        private void lueNumberLearning_EditValueChanged(object sender, EventArgs e)
        {
            mmeDescription.Enabled = true;
            btnAdd.Enabled = true;
            try
            {
                txtMoney.Text = TinhTien().ToString();
            }
            catch { }

        }

        private void txtPeoplePay_EditValueChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = true;
        }

        private void lueNumberLearning_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtReceipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void grOneStudent_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}