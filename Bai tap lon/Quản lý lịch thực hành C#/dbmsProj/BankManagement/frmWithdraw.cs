using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.Common;

namespace BankManagement
{
    public partial class frmWithdraw : DevComponents.DotNetBar.Office2007Form
    {
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            SetDefault();
            flag = true;
        }

        #region Code
        bool flag = false;
        private void SetDefault()
        {
            Rule r = Shared.allRules;
            cldWithdrawDate.Value = DateTime.Today;
            txtMoney.Value = r.SoTienRutToiThieuGD;

            if (!flag)
            {
                SuperTipSettings settings = new SuperTipSettings();
                settings.ToolTipStyle = ToolTipStyle.Office2007;
                string msg = string.Format("{0:C} < Số tiền rút < {1:C}", r.SoTienRutToiThieuGD, r.SoTienRutToiDaGD);
                settings.Text = msg;
                jsp.SetSuperTip(txtMoney, settings);
            }
        }

        private void ClearForm()
        {
            SetDefault();
            Program.Clear(txtAccNo, txtPin, txtNote);
            txtAccNo.Focus();
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string accNo = txtAccNo.Text;
            string pin = txtPin.Text;
            Account acc = new Account(accNo, pin);
            string err = "";
            int KyHan = 0;
            if (!acc.IsValidAcc(ref err, ref KyHan))
            {
                Program.ShowMsg(err, true);
                txtAccNo.Focus();
                this.Cursor = Cursors.Default;
                return;
            }

            decimal nMoney = (decimal)txtMoney.Value;
            Transaction trans = new Transaction(accNo, cldWithdrawDate.Value, nMoney, txtNote.Text);
            err = trans.Validate();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                txtMoney.Focus();
                this.Cursor = Cursors.Default;
                return;
            }

            err = "";
            if (!trans.Add(ref err, KyHan > 0))
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }
            ClearForm();
            this.Cursor = Cursors.Default;
        }
    }
}