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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace ManagementSASI
{
    public partial class frmTrain : DevExpress.XtraEditors.XtraForm
    {
        public frmTrain()
        {
            InitializeComponent();
        }

        ManagementSASIDataContext db = new ManagementSASIDataContext();
        public delegate void LoadLookUpEdit();
        public LoadLookUpEdit lue;
        ErrorProvider error = new ErrorProvider();
            
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtTrainCode.Focus();
        }
       
        /// <summary>
        /// load du lieu len gridcontrol
        /// </summary>
        private void LoadGridControl()
        {
            var query = from c in db.Trains
                        select new { c.TrainCode, c.TrainName, c.Description };
            grcTrain.DataSource = query;
        }

        /// <summary>
        /// xoa rong control
        /// </summary>
        private void ClearControls()
        {
            txtTrainCode.Enabled = true;
            foreach (Control c in this.groupControl1.Controls)
            {
                if (c is TextEdit || c is ComboBoxEdit)
                {
                    c.Text = "";
                }
            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
        }
       

        private void frmTrain_Load(object sender, EventArgs e)
        {
            LoadGridControl(); 
            ClearControls();
        }

        /// <summary>
        /// su kien click vao gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grcTrain_Click(object sender, EventArgs e)
        {
            txtTrainCode.Text = grvTrain.GetRowCellDisplayText(grvTrain.FocusedRowHandle, "TrainCode");
          txtTrainName.Text = grvTrain.GetRowCellDisplayText(grvTrain.FocusedRowHandle, "TrainName");
            medDescription.Text = grvTrain.GetRowCellDisplayText(grvTrain.FocusedRowHandle, "Description");
            txtTrainCode.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
        }
      
        /// <summary>
        /// them moi mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtTrainCode.Text == "")
                {
                    error.SetError(txtTrainCode, "Bạn chưa nhập mã hệ đào tạo");
                }
                else
                {
                    if (txtTrainName.Text== "")
                    {
                        error.SetError(txtTrainName, "Bạn chưa nhập tên hệ đào tạo");
                    }
                    else
                    {
                        if (TestID(txtTrainCode.Text))
                        {
                            if ((XtraMessageBox.Show("Bạn đã chắc chắn muốn thêm khi thêm vào bạn sẽ không được xóa", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK))
                            {
                                Train tr = new Train();
                                tr.TrainCode = txtTrainCode.Text.Trim();
                                tr.TrainName = txtTrainName.Text;
                                tr.Description = medDescription.Text;
                                db.Trains.InsertOnSubmit(tr);
                                db.SubmitChanges();
                                LoadGridControl();
                               
                                ClearControls();
                                try
                                {
                                    lue();
                                }
                                catch { }
                            }
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(string.Format(Properties.Resources.TestID, lblTrainID.Text), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTrainCode.Focus();
                            ClearControls();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// sua mot ban ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrainCode.Text == "")
                {
                    error.SetError(txtTrainCode, "Bạn chưa nhập mã hệ đào tạo");
                }
                else
                {
                    if ((XtraMessageBox.Show("Bạn đã chắc chắn muốn sửa", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK))
                    {
                        Train tr = db.Trains.SingleOrDefault(c => c.TrainCode == txtTrainCode.Text);
                        if (tr != null)
                        {
                            tr.TrainName = txtTrainName.Text;
                            tr.Description = medDescription.Text;
                            db.SubmitChanges();
                            LoadGridControl();

                            ClearControls();
                            try
                            {
                                lue();
                            }
                            catch { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       /// <summary>
       /// kiem tra ma
       /// </summary>
       /// <param name="strID"></param>
       /// <returns></returns>
        private bool TestID(string strID)
        {
            var query = from c in db.Trains
                        select new { c.TrainCode };
            foreach (var sub in query)
            {
                if (sub.TrainCode==strID)
                {
                    return false;
                }
                else
                    return true;
            }
            return true;
        }

      
        bool indi = true;
        /// <summary>
        /// viet chu "hang " tren tung gridcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvTrain_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText =e.RowHandle.ToString();
                if (!indi)
                {
                    e.Info.ImageIndex = -1;
                }
            }
        }
      
        private void grvTrain_ShowFilterPopupListBox(object sender, FilterPopupListBoxEventArgs e)
        {
            //for (int i = 0; i < e.ComboBox.Items.Count; i++)
            //    if (e.ComboBox.Items[i] is FilterItem)
            //        if (((FilterItem)e.ComboBox.Items[i]).Text == GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom))
            //        {
            //            e.ComboBox.Items.Insert(i, new FilterItem(ItemCondition.ConditionsName, 4));
            //            break;
            //        }
        }
        public class MyGridView : GridView
        {
            public static bool IsCondition(GridColumn column)
            {
                if (column == null) return false;
                foreach (DevExpress.XtraGrid.StyleFormatCondition c in column.View.FormatConditions)
                    if (c.Column.Equals(column)) return true;
                return false;
            }
        }
        private void grvTrain_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (MyGridView.IsCondition(e.Column))
            {
                Font headerFont = grvTrain.PaintAppearance.HeaderPanel.Font;
                e.Appearance.Font = new Font(headerFont, headerFont.Bold ? FontStyle.Underline | FontStyle.Bold : FontStyle.Underline);
            }
        }

      
        private void grvTrain_KeyDown(object sender, KeyEventArgs e)
        {
    
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
                if (txtTrainCode.Text == "")
                {
                    error.SetError(txtTrainCode, "Bạn chưa nhập mã hệ đào tạo");
                }
                else
                {
                    if (txtTrainCode.Text != "")
                    {
                        if (XtraMessageBox.Show("Bạn có muốn xóa không?", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Train tr = db.Trains.SingleOrDefault(c => c.TrainCode == txtTrainCode.Text);
                            if (tr != null)
                            {
                                db.Trains.DeleteOnSubmit(tr);
                                db.SubmitChanges();
                            }
                            LoadGridControl();
                            ClearControls();
                            try
                            {
                                lue();
                            }
                            catch { }
                            XtraMessageBox.Show("Bạn đã xóa thành công", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        error.SetError(txtTrainCode, "Bạn chưa nhập mã hệ đào tạo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        DevExpress.Utils.WaitDialogForm dlg = null;
        private void CreateWaitDialog()
        {
            dlg = new DevExpress.Utils.WaitDialogForm();
            SetWaitDialogCaption("Loading Component ...");
        }

        private void SetWaitDialogCaption(string fCaption)
        {
            if (dlg != null)
                dlg.Caption = fCaption;
        }

        private void frmTrain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lue();
            }
            catch { }
        }

        private void txtTrainID_TextChanged(object sender, EventArgs e)
        {
            if (txtTrainCode.Text != "")
            {
                error.Clear();
            }
        }

        private void txtTrainName_TextChanged(object sender, EventArgs e)
        {
            if (txtTrainName.Text != "")
            {
                error.Clear();
            }
        }
    }


}