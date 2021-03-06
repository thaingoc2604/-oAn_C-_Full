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
    public partial class frmClass : DevExpress.XtraEditors.XtraForm
    {
        public frmClass()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;

        /// <summary>
        /// load du lieu len gridcontrol
        /// </summary>
        void LoadGridControl()
        {
            var cl = from c in db.Classes
                     select new { c.ClassCode,c.ClassName,c.Train.TrainName,c.Department.DepartmentName,c.StartYear,c.EndYear,c.Description};
            gctClass.DataSource = cl;
        }

        /// <summary>
        /// load du lieu vao lookupedit he dao tao
        /// </summary>
        void LoadLookUpEditTrain()
        {
            var t = from c in db.Trains
                    select new { c.TrainCode, c.TrainName,c.Description };
            lueTrain.Properties.DataSource = t;
        }

        /// <summary>
        /// load du lieu vaof lookupedit phong ban
        /// </summary>
        void LoadLookUpEditDepartment()
        {
            var t = from c in db.Departments
                    select new { c.DepartmentCode, c.DepartmentName };
            lueDepartment.Properties.DataSource = t;
        }

        /// <summary>
        /// xoa rong cac controls
        /// </summary>
        void ClearControl()
        {
            txtClassID.Enabled = true;
            tedClassName.Text = "";
            lueTrain.EditValue = "";
            //lueTrain.Properties.DisplayMember = "";
            lueDepartment.EditValue = "";
            cbeStartYear.Text = "";
            cbeEndYear.Text = "";
            mmoDescription.Text = "";
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
           // txtClassID.Focus();
            LoadShoolYearStar();
            LoadShoolYearend();
            lueDepartment.ClosePopup();
            lueTrain.ClosePopup();
            txtClassID.Text = "";

            lueTrain.Enabled = true;
            lueDepartment.Enabled = false;
            tedClassName.Enabled = false;
            txtClassID.Enabled = false;
            cbeEndYear.Enabled = false;
            cbeStartYear.Enabled = false;
            mmoDescription.Enabled = false;
            speClassID.Enabled = false;
            
        }

        /// <summary>
        /// kiem tra control rong
        /// </summary>
        /// <returns></returns>
        bool TestControl()
        {
            if (txtClassID.Text == "" || tedClassName.Text == "" || lueTrain.Text == "" || lueDepartment.Text == "")
                return false;
            return true;
        }

        /// <summary>
        /// kiem tra ma lop trung hay khong
        /// </summary>
        /// <returns></returns>
        bool TestID()
        {
            var cl = from c in db.Classes
                     select c.ClassCode;
            foreach (var cl1 in cl)
            {
                if (cl1.ToString() == txtClassID.Text)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// load nam bat dau vao comboboxedit
        /// </summary>
        private void LoadShoolYearStar()
        {
            cbeStartYear.Properties.Items.Clear();
            DateTime dt = DateTime.Now;
            for (int i = dt.Year - 5; i < dt.Year + 1; i++)
            {
                cbeStartYear.Properties.Items.Add(i);
              
            }
           // cbeStartYear.SelectedIndex = 4;
        }

        /// <summary>
        /// load nam ket thuc vao comboboxedit
        /// </summary>
        private void LoadShoolYearend()
        {
            cbeEndYear.Properties.Items.Clear();
            DateTime dt = DateTime.Now;
            for (int i = dt.Year - 4; i < dt.Year + 6; i++)
            {
                cbeEndYear.Properties.Items.Add(i);
            
            }
           // cbeEndYear.SelectedIndex = 7;
        }

      
        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadLookUpEditTrain();
            LoadLookUpEditDepartment();
            LoadGridControl();          
            ClearControl();

        }

        private void LoadClassID()
        {
            var query = from c in db.Trains
                        where c.TrainCode==lueTrain.EditValue.ToString()
                        select new { c.TrainCode};

            var query1 = from c in db.Departments
                         where c.DepartmentCode==lueDepartment.EditValue.ToString()
                         select new { c.DepartmentCode};
            string strNam = cbeStartYear.Text;
            string strHaiSoCuoi = strNam.Substring(2, 2);
           
            foreach (var item in query)
            {
                foreach (var item1 in query1)
                {
                    txtClassID.Text = item.TrainCode + item1.DepartmentCode+strHaiSoCuoi;
                }
            }
        }
        /// <summary>
        /// su kien click xoa rong du lieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
            lueTrain.ClosePopup();
            lueDepartment.ClosePopup();
        }

        private bool ID()
        {
            var query = from c in db.Classes
                        select new { c.ClassCode};
            foreach (var item in query)
            {
                if (item.ClassCode == txtClassID.Text + speClassID.Text)
                {
                    return false;                   
                }
            }
            return true;
        }
        /// <summary>
        /// them moi 1 ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (ID())
                {
                    if (TestControl())
                    {
                        if (TestID())
                        {
                            Class cl = new Class();
                            cl.ClassCode = txtClassID.Text + speClassID.Text;
                            cl.ClassName = tedClassName.Text.ToUpper();
                            cl.TrainCode= lueTrain.GetColumnValue("TrainCode").ToString();
                            cl.DepartmentCode = lueDepartment.GetColumnValue("DepartmentCode").ToString();

                            cl.StartYear = int.Parse(cbeStartYear.Text.Trim());
                            cl.EndYear = int.Parse(cbeEndYear.Text.Trim());
                            cl.Description = mmoDescription.Text;
                            db.Classes.InsertOnSubmit(cl);
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
                            XtraMessageBox.Show("Mã lớp đã tồn tại, mời bạn chọn mã khác !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtClassID.Text = "";
                           // txtClassID.Focus();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa nhập đầy đủ thông tin bắt buộc", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn nhập trùng mã ", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); speClassID.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?",Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Class cl = db.Classes.SingleOrDefault(c => c.ClassCode== (txtClassID.Text+speClassID.Text));
                        cl.ClassName = tedClassName.Text;
                        cl.TrainCode = lueTrain.GetColumnValue("TrainCode").ToString();
                        cl.DepartmentCode = lueDepartment.GetColumnValue("DepartmentCode").ToString();

                        cl.StartYear = int.Parse(cbeStartYear.Text.Trim());
                        cl.EndYear = int.Parse(cbeEndYear.Text.Trim());
                        cl.Description = mmoDescription.Text;
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
                if (txtClassID.Text != "")
                {
                    if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?",Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Class cl = db.Classes.SingleOrDefault(c => c.ClassCode == (txtClassID.Text+speClassID.Text));
                        db.Classes.DeleteOnSubmit(cl);
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
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// su kien click vao gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gctClass_Click(object sender, EventArgs e)
        {
            try
            {
               // txtClassID.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "ClassID");
                tedClassName.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "ClassName");

                lueTrain.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "TrainName");
                lueTrain.ClosePopup();
                lueDepartment.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "DepartmentName");
                lueDepartment.ClosePopup();
                cbeStartYear.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "StartYear");
                cbeEndYear.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "EndYear");
                mmoDescription.Text = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "Description");
                string strClassID = gvClass.GetRowCellDisplayText(gvClass.FocusedRowHandle, "ClassCode");
                txtClassID.Text = strClassID.Substring(0, 5);
                
                speClassID.Text = strClassID.Substring(5, 1);
                //txtClassID.Enabled = false;
                btnInsert.Enabled = false;

                btnUpdate.Enabled = true;

                btnDelete.Enabled = true;

                lueDepartment.Enabled = false;
                lueTrain.Enabled = false;
                mmoDescription.Enabled = true;
                cbeEndYear.Enabled = true;
                tedClassName.Enabled = true;
                cbeStartYear.Enabled = false;
                speClassID.Enabled = false;
            }
            catch { }
        }

        private void lueTrain_EditValueChanged(object sender, EventArgs e)
        {
            lueDepartment.Enabled = true;

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            frmTrain frmtrain = new frmTrain();
            frmtrain.lue = new frmTrain.LoadLookUpEdit(LoadLookUpEditTrain);
            frmtrain.ShowDialog();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment frmdepartment = new frmDepartment();
            frmdepartment.lue = new
             frmDepartment.LoadLookUpEdit(LoadLookUpEditDepartment);
            frmdepartment.ShowDialog();


        }

        private void frmClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }
        }

        private void lueTrain_TextChanged(object sender, EventArgs e)
        {
            lueDepartment.Enabled = true;
        }

        private void lueDepartment_TextChanged(object sender, EventArgs e)
        {
           
                tedClassName.Enabled = true;
                tedClassName.Enabled = false; 

        }

        private void lueTrain_Click(object sender, EventArgs e)
        {
            //lueDepartment.Enabled = true;
        }

        private void lueDepartment_Click(object sender, EventArgs e)
        {
          
            //cbeStartYear.Enabled = true;
            //tedClassName.Enabled = false; 
        }

       

        private void cbeStartYear_Click(object sender, EventArgs e)
        {
            //tedClassName.Enabled = true;
            //txtClassID.Enabled = true;
            //cbeEndYear.Enabled = true;
            //mmoDescription.Enabled = true;
            //tedClassName.Enabled = true;
        }

        private void cbeStartYear_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cbeStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lueTrain.Text == "")
            {
                XtraMessageBox.Show("bạn phải chọn mã hệ đào tạo trước", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (lueDepartment.Text == "")
                {
                    XtraMessageBox.Show("bạn phải chọn mã khoa trước", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    LoadClassID();
                    cbeEndYear.Enabled = true;
                }
            }
        }

        private void lueDepartment_EditValueChanged(object sender, EventArgs e)
        {
            cbeStartYear.Enabled = true;
        }

        private void cbeEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            tedClassName.Enabled = true;
            mmoDescription.Enabled = true;
            speClassID.Enabled = true;
        }
        string strClassID = "";
        private void speClassID_EditValueChanged(object sender, EventArgs e)
        {
            strClassID = txtClassID.Text + speClassID.Text;
        }

        private void frmClass_KeyDown(object sender, KeyEventArgs e)
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