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

namespace ManagementSASI
{
    public partial class frmTeacher : DevExpress.XtraEditors.XtraForm
    {
        public frmTeacher()
        {
            InitializeComponent();//Download source code tại Sharecode.vn
        }
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ManagementSASIDataContext db = new ManagementSASIDataContext();

        /// <summary>
        /// xoa rong cac controls
        /// </summary>
        void ClearControl()
        {
            txtTeacherCode.Text = "";
            txtTeacherName.Text = "";
            dateBirthday.Text = "";
            txtPhoneNumber.Text = "";
            txtHomeTown.Text = "";
            mmoDescription.Text = "";
            txtTeacherCode.Enabled = true;
            txtTeacherCode.Focus();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// kiem tra cac control
        /// </summary>
        /// <returns></returns>
        bool TestControl()
        {
            if (txtTeacherCode.Text == "" || txtTeacherName.Text == "")
                return false;
            return true;
        }

        /// <summary>
        /// kiem tra ma giao vien
        /// </summary>
        /// <returns></returns>
        bool TestID()
        {
            var id = from c in db.Teachers
                     select c.TeacherCode;
            foreach (var m in id)
            {
                if (txtTeacherCode.Text == m.ToString())
                    return false;
            }
            return true;
        }

        /// <summary>
        /// load du lieu len  gridcontrol
        /// </summary>
        void LoadGridControl()
        {
            var t = from c in db.Teachers
                    select c;
            gctTeacher.DataSource = t;
        }

        /// <summary>
        /// su kien click lam  rong control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        /// <summary>
        /// su kien click vao gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click(object sender, EventArgs e)
        {

            txtTeacherCode.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "TeacherCode");
            txtTeacherName.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "TeacherName");
            dateBirthday.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "BirthDay");
            txtHomeTown.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "HomeTown");
            txtPhoneNumber.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "PhoneNumber");
            mmoDescription.Text = gvTeacher.GetRowCellDisplayText(gvTeacher.FocusedRowHandle, "Description");

            txtTeacherCode.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        /// <summary>
        /// them mot ban ghi
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
                        Teacher t = new Teacher();
                        t.TeacherCode = txtTeacherCode.Text;
                        t.TeacherName = txtTeacherName.Text;
                        t.HomeTown = txtHomeTown.Text;
                        t.PhoneNumber = txtPhoneNumber.Text;
                        t.Description = mmoDescription.Text;
                        db.Teachers.InsertOnSubmit(t);
                        db.SubmitChanges();
                        LoadGridControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                        ClearControl();
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã giáo viên đã tồn tại, mời bạn chọn mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTeacherCode.Text = "";
                        txtTeacherCode.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
/// <summary>
///  chi cho nhap so
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            LoadGridControl();
            ClearControl();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

                    if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Teacher t = db.Teachers.SingleOrDefault(c => c.TeacherCode == txtTeacherCode.Text);
                        t.TeacherName = txtTeacherName.Text;
                        t.PhoneNumber = txtPhoneNumber.Text;
                        t.HomeTown = txtHomeTown.Text;
                        t.Description = mmoDescription.Text;
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
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Teacher t = db.Teachers.SingleOrDefault(c => c.TeacherCode == txtTeacherCode.Text);
                    db.Teachers.DeleteOnSubmit(t);
                    db.SubmitChanges();
                    LoadGridControl();
                    ClearControl();
                    try
                    {
                        lue();
                    }
                    catch { }
                   
                }
            }
            catch (Exception ex)
            {
              XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }
        }

        private void frmTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void frmTeacher_KeyDown(object sender, KeyEventArgs e)
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