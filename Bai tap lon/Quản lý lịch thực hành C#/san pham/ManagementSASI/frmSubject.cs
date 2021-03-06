using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
//using DevExpress.XtraGrid.Columns;
//using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmSubject : DevExpress.XtraEditors.XtraForm
    {
        public frmSubject()
        {
            InitializeComponent();
        }
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ManagementSASIDataContext db = new ManagementSASIDataContext();

        /// <summary>
        /// load gridcontrol
        /// </summary>
        void LoadGridControl()
        {
            var s = from c in db.Subjects
                    select c;
            gctSubject.DataSource = s;
        }

        /// <summary>
        /// kiem tra textbox rong
        /// </summary>
        /// <returns></returns>
        bool TestControl()
        {
            if (txtSubjectCode.Text == "" || txtSubjectName.Text == "")
                return false;
            return true;
        }

        bool TestID()
        {
            var id = from c in db.Subjects
                     select c.SubjectCode;
            foreach (var i in id)
            {
                if (txtSubjectCode.Text == i.ToString())
                    return false;
            }
            return true;
        }

        /// <summary>
        /// xoa text rong control
        /// </summary>
        void ClearControl()
        {
            txtSubjectCode.Text = "";
            txtSubjectName.Text = "";
           // txtNumber.Text = "";
            mmoDescription.Text = "";
            txtSubjectCode.Enabled = true;
            txtSubjectCode.Focus();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtSubjectCode.Enabled = true;
        }
        private void frmSubject_Load(object sender, EventArgs e)
        {
            LoadGridControl();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;
        }

        /// <summary>
        /// thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        /// <summary>
        /// click gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvSubject_Click(object sender, EventArgs e)
        {


            txtSubjectCode.Text = gvSubject.GetRowCellDisplayText(gvSubject.FocusedRowHandle, "SubjectCode");
            txtSubjectName.Text = gvSubject.GetRowCellDisplayText(gvSubject.FocusedRowHandle, "SubjectName");
            //txtNumber.Text = gvSubject.GetRowCellDisplayText(gvSubject.FocusedRowHandle, "Number");
            mmoDescription.Text = gvSubject.GetRowCellDisplayText(gvSubject.FocusedRowHandle, "Description");
            txtSubjectCode.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TestControl())
                {
                    if (TestID())
                    {
                        Subject sb = new Subject();
                        sb.SubjectCode = txtSubjectCode.Text;
                        sb.SubjectName = txtSubjectName.Text;
                        //sb.Number = int.Parse(txtNumber.Text);
                        sb.Description = mmoDescription.Text;
                        db.Subjects.InsertOnSubmit(sb);
                        db.SubmitChanges();
                        LoadGridControl();
                        frmTrain_Subject frm1 = new frmTrain_Subject();
                        frm1.strMaMonHoc = txtSubjectCode.Text;
                        frm1.strTenMonHoc = txtSubjectName.Text;
                        frm1.ShowDialog();
                        ClearControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                        groupControl1.Text += "  (Chú ý bạn phải phân hệ đào tạo cho môn này)";
                       
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã môn học đã tồn tại, mời bạn chọn mã khác !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSubjectCode.Text = "";
                        txtSubjectCode.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// sua mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TestControl())
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Subject sb = db.Subjects.SingleOrDefault(c => c.SubjectCode == txtSubjectCode.Text);
                        sb.SubjectName = txtSubjectName.Text;
                        // sb.Number = int.Parse(txtNumber.Text);
                        sb.Description = mmoDescription.Text;
                        db.SubmitChanges();
                        LoadGridControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                       
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (txtSubjectCode.Text != "")
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?",Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Subject sb = db.Subjects.SingleOrDefault(c => c.SubjectCode == txtSubjectCode.Text);
                        db.Subjects.DeleteOnSubmit(sb);
                        db.SubmitChanges();
                        LoadGridControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                       
                    }
                }

                else
                {
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        ///dong form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }
        }

        private void btnTrainToSubject_Click(object sender, EventArgs e)
        {
            //frmTrain_Subject t = new frmTrain_Subject();
            //frmSubject subject = new frmSubject();
            //subject.lue = new frmSubject.LoadLookUpEdit(LoadLookUpEditSubject);
            //subject.ShowDialog();
            
        }

        private void frmSubject_KeyDown(object sender, KeyEventArgs e)
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
    }
}