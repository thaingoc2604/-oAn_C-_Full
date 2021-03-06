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
    public partial class frmSettingMoney : DevExpress.XtraEditors.XtraForm
    {
        public frmSettingMoney()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void LoadGridControl()
        {
            var query = from c in db.SettingMoneyRates
                        select new { c.MoneyRatesName,c.TrainingInformation.InfoName,c.NumberStudy,c.TheoryMoney,c.PracticeMoney};
            grcSettingMoney.DataSource = query;
        }
        private void LoadLookUpEditMoney()
        {
            var query = from c in db.TrainingInformations
                        select new { c.InfoName, c.TrainType, c.TrainingType, c.LearningType ,c.InfoID};
            lueInfo.Properties.DataSource = query;
            lueInfo.Properties.DisplayMember = "InfoName";
            lueInfo.Properties.ValueMember = "InfoID";

        }
        private void frmSettingMoney_Load(object sender, EventArgs e)
        {
            LoadLookUpEditMoney();
            LoadGridControl();
        }
        ErrorProvider erro = new ErrorProvider();
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

        private void grcSettingMoney_Click(object sender, EventArgs e)
        {
            lueInfo.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "InfoName");
            txtMoneyRatesName.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "MoneyRatesName");
            cboNumberStudy.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "NumberStudy");
            txtPracticeMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "PracticeMoney");
            txtTheoryMoney.Text = grvSettingMoney.GetRowCellDisplayText(grvSettingMoney.FocusedRowHandle, "TheoryMoney");
     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

    }
}