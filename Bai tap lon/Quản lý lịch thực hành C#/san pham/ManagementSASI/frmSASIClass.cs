using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Configuration;
using DevExpress.XtraGrid.Views.Base;

namespace ManagementSASI
{
    public partial class frmSASIClass : DevExpress.XtraEditors.XtraForm
    {
        public frmSASIClass()
        {
            InitializeComponent();
        }
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ManagementSASIDataContext db = new ManagementSASIDataContext();
       
        /// <summary>
        /// kiem tra ma 
        /// </summary>
        /// <returns></returns>
     
        bool TestName()
        {
            var id = from c in db.SASIClasses
                     select c.SASIClassName;
            foreach (var id1 in id)
            {
                if (id1.ToString() == tedSASIClassName.Text)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// kiem tra controls rong
        /// </summary>
        /// <returns></returns>
       

        /// <summary>
        /// load du lieu len control
        /// </summary>
        void LoadGridControl()
        {
            var cl = from c in db.SASIClasses
                     select new { c.TrainingInformation.InfoName, c.SASIClassName, c.Teacher.TeacherName,c.StartDate,c.EndDate,c.Semester,c.ShoolYear, c.Description,c.Status,c.DateSASIClass,c.SASIClassID };
            gctSASIClass.DataSource = cl;
        }

        
        /// <summary>
        /// xoa rong control
        /// </summary>
        void ClearControl()
        {
            foreach (Control a in this.groupControl1.Controls)
            {
                if (a is TextEdit || a is ComboBoxEdit|| a is MemoEdit)
                {
                    a.Text = "";
                }
              

            }
            tedSASIClassName.Enabled = true;
            lueTeacher.EditValue = "";
            lueInfor.EditValue = "";
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            dtpEndDate.Enabled = false;
            dtpStarDate.Enabled = false;
            lueTeacher.Enabled = false;
            btnDelete.Enabled = false;
            lueInfor.Enabled = true;
        }

        private void frmSASIClass_Load(object sender, EventArgs e)
        {
            ClearControl();
            LoadGridControl(); 
            LoadLookUpEditTeachers();
            LoadLookUpEditInfor();                       
        }

        /// <summary>
        /// su kien lam moi control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        /// <summary>
        /// su kien click thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// load du lieuj vao lookupedit giao vien
        /// </summary>
        private void LoadLookUpEditTeachers()
        {

            var query = from c in db.Teachers
                        select new { c.TeacherCode, c.TeacherName };
            lueTeacher.Properties.DataSource = query;
        }
        public static bool testfrm = false;
        ErrorProvider erro = new ErrorProvider();

        /// <summary>
        /// them mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static string ClassID="";
        public static string ClassName = "";
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                    if (tedSASIClassName.Text == "")
                    {
                        erro.SetError(tedSASIClassName, "Bạn chưa nhập tên lớp học lại");

                    }
                    else
                    {
                        erro.Clear();
                        if (cboSemester.Text == "")
                        {
                            erro.SetError(cboSemester, "Bạn chưa chọn học kì");
                        }
                        else
                        {
                            erro.Clear();
                            if (cboShoolYear.Text == "")
                            {
                                erro.SetError(cboShoolYear, "Bạn chưa chọn số năm học");
                            }
                            else
                            {
                                erro.Clear();
                                DateTime dtend = DateTime.Parse(dtpEndDate.Text);
                                DateTime dtstart = DateTime.Parse(dtpStarDate.Text);
                                if (dtend.Day - dtstart.Day >= 0)
                                {
                                    if (tedSASIClassName.Text=="")
                                    {
                                           XtraMessageBox.Show("Tên lớp đã tồn tại, mời bạn chọn tên khác !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tedSASIClassName.Focus();
                                    }
                                    else
                                    {
                                        TestManageSASI test = new TestManageSASI();
                                        SASIClass cl = new SASIClass();
                                        cl.InfoID =int.Parse(lueInfor.EditValue.ToString());
                                        cl.SASIClassName =test.Standardized2( tedSASIClassName.Text);
                                        cl.Description = mmoDescription.Text;
                                        cl.Semester = int.Parse(cboSemester.Text);
                                        cl.Status = "Chưa phân lớp";
                                        cl.DateSASIClass = DateTime.Parse(DateTime.Now.ToShortDateString());
                                        cl.ShoolYear = cboShoolYear.Text;
                                        cl.StartDate = DateTime.Parse(dtpStarDate.Text);
                                        cl.EndDate = DateTime.Parse(dtpEndDate.Text);
                                        db.SASIClasses.InsertOnSubmit(cl);
                                        db.SubmitChanges();
                                        LoadGridControl();
                                       // ClearControl();
                                        try
                                        {
                                            lue();
                                        }
                                        catch { }


                                        var query = from c in db.SASIClasses
                                                    where c.SASIClassName == tedSASIClassName.Text
                                                    select new { c.SASIClassID,c.TrainingInformation.LearningType};
                                        foreach (var item in query)
                                        {
                                            ClassName = tedSASIClassName.Text;
                                            ClassID =item.SASIClassID.ToString();
                                         
                                        }


                                        TestManageSASI tm = new TestManageSASI();
                                        tm.ShowfrmStudentToRegisTer();
                                    }
                                }
                                else
                                {
                                    erro.SetError(dtpStarDate, "Bạn xem lại ngày bắt đầy học và ngày kết thúc học");
                                    erro.SetError(dtpEndDate, "Bạn xem lại ngày bắt đầy học và ngày kết thúc học");
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
        
        
        /// <summary>
        /// xua mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        public int CountStudentNumber()
        {
            var studentNumber = from sv in db.StudentToRegisters
                                where sv.SASIClassID == sasiClassID
                                select new { sv.StudentRG };
            int evenNumCount = studentNumber.Count();
            return evenNumCount;
        }
        public string GetSubjectCode()
        {
            string subCode = "";
            var a = from s1 in db.StudentToRegisters
                    where s1.SASIClassID == sasiClassID
                    select new { s1.SubjectCode };
            foreach (var ss1 in a)
            {
                subCode = ss1.SubjectCode.ToString();
            }
            return subCode;
        }
        public string GetSubjectName()
        {
            string subCode = GetSubjectCode();
            string subName = "";
            
            var b = from s2 in db.Subjects
                      where s2.SubjectCode==subCode
                      select new { s2.SubjectName};

            foreach (var ss2 in b)
            {
                subName = ss2.SubjectName.ToString();
            }
            return subName ;
        }
        public string GetTrainName()
        {
            string trainName = "";
      
            SqlConnection sqCon = new SqlConnection(stringconnect);
            DataSet ds = new DataSet();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "GetTrainName";
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Connection = sqCon;
            sqlCom.Parameters.Add(new SqlParameter("@SASIClassID", sasiClassID));
            SqlDataAdapter da = new SqlDataAdapter(sqlCom);
            da.Fill(ds, "GetTrainName");
            DataTable dt = ds.Tables["GetTrainName"];
            foreach (DataRow dr in dt.Rows)
            {
                trainName = dr[1].ToString();
            }
            return trainName;
        }
        public string GetTrainCode()
        {
           
            string trainCode = "";
            SqlConnection sqCon = new SqlConnection(stringconnect);
            DataSet ds = new DataSet();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "GetTrainName";
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Connection = sqCon;
            sqlCom.Parameters.Add(new SqlParameter("@SASIClassID", sasiClassID));
            SqlDataAdapter da = new SqlDataAdapter(sqlCom);
            da.Fill(ds, "GetTrainName");
            DataTable dt = ds.Tables["GetTrainName"];
            foreach (DataRow dr in dt.Rows)
            {

                trainCode = dr[0].ToString();
            }
            return trainCode;
        }
        static string stringconnect = ConfigurationManager.ConnectionStrings["ManagementSASI.Properties.Settings.SDGHYConnectionString"].ConnectionString;
        public int TestSubjectTrain()
        {

            int k = 0;
            SqlConnection sqCon = new SqlConnection(stringconnect);
            DataSet ds = new DataSet();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandText = "CountSubjectTrainID";
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Connection = sqCon;
            sqlCom.Parameters.Add(new SqlParameter("@SASIClassID", sasiClassID));
            SqlDataAdapter da = new SqlDataAdapter(sqlCom);
            da.Fill(ds, "CountSubjectTrainID");
            DataTable dt = ds.Tables["CountSubjectTrainID"];
            k = dt.Rows.Count;
            return k;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                if (CountStudentNumber() == 0)
                {
                    XtraMessageBox.Show("Chưa có sinh viên trong lớp học này !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (TestSubjectTrain() == 0)
                    {
                       
                        XtraMessageBox.Show("Môn học '" +GetSubjectName()+"' chưa được phân theo hệ đào tạo "+GetTrainName()+" !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        frmTrain_Subject frm = new frmTrain_Subject();
                        frm.strMaMonHoc = GetSubjectCode();
                        frm.strTenMonHoc = GetSubjectName();
                        frm.strMaHe = GetTrainCode();
                        frm.strTenHe = GetTrainName();
                        frm.ShowDialog();
                        //this.Dispose();
                    }
                    else
                    {
                        if (tedSASIClassName.Text == "")
                        {
                            XtraMessageBox.Show("Bạn chưa nhập tên lớp", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (lueTeacher.Text == "")
                            {
                                erro.SetError(lueTeacher, "Bạn chưa chọn giáo viên ");
                            }
                            else
                            {
                                erro.Clear();
                                if (cboSemester.Text == "")
                                {
                                    erro.SetError(cboSemester, "Bạn chưa chọn học kì");
                                }
                                else
                                {
                                    erro.Clear();
                                    if (cboShoolYear.Text == "")
                                    {
                                        erro.SetError(cboShoolYear, "Bạn chưa chọn số năm học");
                                    }
                                    else
                                    {
                                        var query = from c in db.SASIClasses
                                                    where c.SASIClassName == tedSASIClassName.Text
                                                    select new { c.SASIClassID };
                                        erro.Clear();
                                        DateTime dtend = DateTime.Parse(dtpEndDate.Text);
                                        DateTime dtstart = DateTime.Parse(dtpStarDate.Text);
                                        foreach (var item in query)
                                        {
                                            if (dtend > dtstart)
                                            {
                                                erro.Clear();
                                                SASIClass cl = db.SASIClasses.SingleOrDefault(c => c.SASIClassID == item.SASIClassID);
                                                cl.SASIClassName = tedSASIClassName.Text;
                                                cl.TeacherCode = lueTeacher.EditValue.ToString();
                                                cl.InfoID = int.Parse(lueInfor.EditValue.ToString());
                                                cl.Semester = int.Parse(cboSemester.Text);
                                                cl.Status = "Đã phân lớp";
                                                cl.ShoolYear = cboShoolYear.Text;
                                                cl.StartDate = DateTime.Parse(dtpStarDate.Text);
                                                cl.EndDate = DateTime.Parse(dtpEndDate.Text);
                                                cl.Description = mmoDescription.Text;
                                                db.SubmitChanges();
                                                LoadGridControl();
                                                dtpEndDate.Enabled = true;
                                                dtpStarDate.Enabled = true;
                                                lueTeacher.Enabled = true;
                                                ClearControl();
                                                try
                                                {
                                                    lue();
                                                }
                                                catch { }
                                                XtraMessageBox.Show("Bạn đã phân lớp cho giáo viên thành công !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                erro.SetError(dtpStarDate, "Bạn xem lại ngày bắt đầy học và ngày kết thúc học");
                                                erro.SetError(dtpEndDate, "Bạn xem lại ngày bắt đầy học và ngày kết thúc học");
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
        
    
        /// <summary>
        /// xoa mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var query = from c in db.SASIClasses
                                where c.SASIClassName == tedSASIClassName.Text
                                select new { c.SASIClassID };
                    foreach (var item in query)
                    {
                        SASIClass cl = db.SASIClasses.SingleOrDefault(c => c.SASIClassID == item.SASIClassID);
                        db.SASIClasses.DeleteOnSubmit(cl);
                        db.SubmitChanges();
                        LoadGridControl();
                        ClearControl(); 
                    }
                   
                    try
                    {
                        lue();
                    }
                    catch { }
                    XtraMessageBox.Show("Bạn đã xóa thành công !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// click du lieu len 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int sasiClassID = 0;
        private void gctSASIClass_Click(object sender, EventArgs e)
        {
            try
            {
                
                sasiClassID=int.Parse(gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "SASIClassID"));
                tedSASIClassName.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "SASIClassName");
                mmoDescription.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "Description");
                lueTeacher.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "TeacherName");
                dtpStarDate.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "StartDate");
                dtpEndDate.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "EndDate");
                cboShoolYear.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "ShoolYear");
                cboSemester.Text = gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "Semester");
                lueInfor.Text= gvSASIClass.GetRowCellDisplayText(gvSASIClass.FocusedRowHandle, "InfoName");
                lueTeacher.ClosePopup();
                btnInsert.Enabled = false;
                lueInfor.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                dtpEndDate.Enabled = true;
                dtpStarDate.Enabled = true;
                lueTeacher.Enabled = true;
                tedSASIClassName.Enabled = false;
            }
            catch { }
        }

        private void tedSASIClassName_TextChanged(object sender, EventArgs e)
        {
            if (tedSASIClassName.Text != "")
            {
                erro.Clear();
            }
        }

        private void lueTeacher_TextChanged(object sender, EventArgs e)
        {
            if (lueTeacher.Text != "")
            {
                erro.Clear();
            }

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher teacher = new frmTeacher();
            teacher.lue = new frmTeacher.LoadLookUpEdit(LoadLookUpEditTeachers);
            teacher.ShowDialog();
        }

        private void cboShoolYear_TextChanged(object sender, EventArgs e)
        {
            if (cboShoolYear.Text != "")
            {
                erro.Clear();
            }
        }

        private void cboSemester_TextChanged(object sender, EventArgs e)
        {
            if (cboSemester.Text != "")
            {
                erro.Clear();
            }
        }
        private void LoadLookUpEditInfor()
        {
            var query = from c in db.TrainingInformations
                        select new { c.InfoID, c.InfoName,c.LearningType,c.TrainType,c.TrainingType};
            lueInfor.Properties.DataSource = query;
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            frmTrainingInformation frm = new frmTrainingInformation();
            frm.lue = new frmTrainingInformation.LoadLookUpEdit(LoadLookUpEditInfor);
            frm.ShowDialog();
        }

        private void frmSASIClass_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.F6)
            {
                btnNew_Click(sender, e);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}