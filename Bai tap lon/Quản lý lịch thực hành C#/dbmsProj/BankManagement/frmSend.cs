using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmSend : DevComponents.DotNetBar.Office2007Form
    {
        public frmSend()
        {
            InitializeComponent();
        }

        private void frmSend_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string nAccNo = txtAccNo.Text;
            DateTime nTransDate = cldSendDate.Value;
            decimal nMoney = (decimal)txtMoney.Value;
            string nNote = txtNote.Text;
            string nHoTen = txtName.Text;
            string nSoCMND = txtID.Text;
            string nDienThoai = txtAddress.Text;
            string nEmail = txtEmail.Text;
            string nDiaChi = txtAddress.Text;

            SendTrans trans = new SendTrans(nAccNo, nTransDate, nMoney, nNote, nHoTen, nSoCMND, nDiaChi, nDienThoai, nEmail);
            string err = trans.Validate();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            err = "";
            if (!trans.Add(ref err))
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            Program.ShowMsg("Gửi thành công.");
            ClearForm();

            this.Cursor = Cursors.Default;
        }

        private void txtAccNo_ButtonClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CheckAcc();
            this.Cursor = Cursors.Default;
        }

        private void txtAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if(e.KeyData==Keys.Enter) CheckAcc();
            this.Cursor = Cursors.Default;
        }

        #region Code
        private void SetDefault()
        {
            cldSendDate.Value = DateTime.Today;
            txtMoney.Value = Shared.allRules.SoTienGuiToiThieu;
        }

        private void ClearForm()
        {
            SetDefault();
            Program.Clear(txtAccNo, txtName, txtID, txtPhone, txtEmail, txtAddress, txtNote);
            txtAccNo.Focus();
        }

        private void CheckAcc()
        {
            string accNo = txtAccNo.Text;
            Account acc = new Account(accNo, "");
            Program.ShowMsg(acc.GetAccInfo());
        }
        #endregion
    }
}