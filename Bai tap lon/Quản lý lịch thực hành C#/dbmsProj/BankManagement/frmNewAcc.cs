using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmNewAcc : DevComponents.DotNetBar.Office2007Form
    {
        public frmNewAcc()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int nMaLoaiTK = int.Parse(cboAccTypes.SelectedValue.ToString());
            int nMaNganHang = int.Parse(cboBanks.SelectedValue.ToString());
            DateTime nNgayMo = cldOpenDate.Value;
            decimal nSoTienGui = (decimal)txtMoney.Value;
            string nHoTen = txtName.Text;
            string nSoCMND = txtID.Text;
            string nDienThoai = txtPhone.Text;
            string nEmail = txtEmail.Text;
            string nDiaChi = txtAddress.Text;
            string nGhiChu = txtNote.Text;
            Account acc = new Account(nHoTen, nSoCMND, nDiaChi, nDienThoai, nEmail, nNgayMo, nMaLoaiTK, nMaNganHang, nSoTienGui, nGhiChu);

            string err = acc.Validate();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            if (!acc.Add(ref err))
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            Program.ShowMsg(acc.Info);
            ClearForm();
            this.Cursor = Cursors.Default;
        }

        #region Code
        private void FillCombos()
        {
            bool rs = true;

            DataTable dtAccTypes = AccType.LoadAccTypes();
            if (dtAccTypes != null && dtAccTypes.Rows.Count > 0)
            {
                cboAccTypes.DataSource = dtAccTypes;
                cboAccTypes.DisplayMember = "TenLoaiTK";
                cboAccTypes.ValueMember = "MaLoaiTK";
                cboAccTypes.SelectedIndex = 0;
            }
            else rs = rs & false;

            DataTable dtBanks = Bank.LoadBanks();
            if (dtBanks != null && dtBanks.Rows.Count > 0)
            {
                cboBanks.DataSource = dtBanks;
                cboBanks.DisplayMember = "TenNganHang";
                cboBanks.ValueMember = "MaNganHang";
                cboBanks.SelectedIndex = 0;
            }
            else rs = rs & false;

            btnOK.Enabled = rs;
        }

        private void SetDefaultValue()
        {
            decimal money = Shared.allRules.SoDuTKToiThieu;
            txtMoney.Value = money;

            cldOpenDate.Value = DateTime.Today;
        }

        private void frmNewAcc_Load(object sender, EventArgs e)
        {
            FillCombos();
            SetDefaultValue();
        }

        private void ClearForm()
        {
            SetDefaultValue();
            Program.Clear(txtName, txtID, txtPhone, txtEmail, txtAddress, txtNote);
            txtName.Focus();
        }
        #endregion
    }
}