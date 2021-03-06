using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace ManagementSASI
{
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        TestManageSASI test = new TestManageSASI();

        /// <summary>
        /// xoa rong control
        /// </summary>
        void ClearControl()
        {
            txtDepartmentCode.Enabled = true;
            txtDepartmentName.Text = "";
            txtPhoneNumber.Text = "";
            grcDepartment.Text = "";
            txtDepartmentCode.Text = "";
            txtDepartmentCode.Focus();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            medDescription.Text = "";
        }
        
        /// <summary>
        /// kiem tra ma phong ban da ton tai chua
        /// </summary>
        /// <returns></returns>
        bool TestID()
        {
            var iD = from c in db.Departments
                     select c.DepartmentCode;
            foreach (var i in iD)
            {
                if (txtDepartmentCode.Text == i.ToString())
                    return false;
            }
            return true;
        }

        /// <summary>
        /// kiem tra cac control xem co rong hay khong
        /// </summary>
        /// <returns></returns>
        bool TestControl()
        {
            if (txtDepartmentCode.Text == "" || txtDepartmentName.Text == "" || txtPhoneNumber.Text == "")
                return false;
            return true;
        }

        /// <summary>
        /// load du lieu len gridcontrol
        /// </summary>
        void LoadGridControl()
        {
            var query = from c in db.Departments
                        select c;
            gctDepartment.DataSource = query;
        }

        /// <summary>
        /// su kien chi cho phep nhap so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void frmDepartment_Load(object sender, EventArgs e)
        {
            ClearControl();
            txtDepartmentCode.Focus();
            LoadGridControl();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
         
        /// <summary>
        /// sy kien click vao gridcontrol load du lieu len control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gctDepartment_Click(object sender, EventArgs e)
        {
            txtDepartmentCode.Text = gvDepartment.GetRowCellDisplayText(gvDepartment.FocusedRowHandle, "DepartmentCode");
            txtDepartmentName.Text = gvDepartment.GetRowCellDisplayText(gvDepartment.FocusedRowHandle, "DepartmentName");
            txtPhoneNumber.Text = gvDepartment.GetRowCellDisplayText(gvDepartment.FocusedRowHandle, "PhoneNumber");
            medDescription.Text = gvDepartment.GetRowCellDisplayText(gvDepartment.FocusedRowHandle, "Description");

            txtDepartmentCode.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
        }

        /// <summary>
        /// sua du lieu
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
                        Department dp = db.Departments.SingleOrDefault(c => c.DepartmentCode == txtDepartmentCode.Text);
                        dp.DepartmentName = test.Standardized2(txtDepartmentName.Text);
                        dp.PhoneNumber = txtPhoneNumber.Text;
                        dp.Description = medDescription.Text;
                        db.SubmitChanges();
                        LoadGridControl();
                        ClearControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                       // XtraMessageBox.Show("Bạn đã sửa thành công !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// them du lieu
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
                        Department dp = new Department();
                        dp.DepartmentCode = txtDepartmentCode.Text;
                        dp.DepartmentName =test.Standardized2(txtDepartmentName.Text);
                        dp.PhoneNumber = txtPhoneNumber.Text;
                        dp.Description = medDescription.Text;
                        db.Departments.InsertOnSubmit(dp);
                        db.SubmitChanges();
                        LoadGridControl();
                        ClearControl();
                        try
                        {
                            lue();
                        }
                        catch { }
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã khoa đã tồn tại, mời bạn chọn mã khác !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      
                       txtDepartmentCode.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin bắt buộc", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// xoa mot ba ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Department dp = db.Departments.SingleOrDefault(c => c.DepartmentCode == txtDepartmentCode.Text);
                    db.Departments.DeleteOnSubmit(dp);
                    db.SubmitChanges();
                    LoadGridControl();
                    ClearControl();
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

        private void frmDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }

        }

        /// <summary>
        /// xoa rong cac control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void txtDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}