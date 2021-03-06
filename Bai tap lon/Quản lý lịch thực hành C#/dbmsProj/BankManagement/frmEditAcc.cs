using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace BankManagement
{
    public partial class frmEditAcc : DevComponents.DotNetBar.Office2007Form
    {
        Account _acc;
        GridEXRow _row;

        public frmEditAcc(Account nAcc,GridEXRow nRow)
        {
            InitializeComponent();
            _acc = nAcc;
            _row = nRow;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditAcc_Load(object sender, EventArgs e)
        {
            FillCombos();
            DisplayAcc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SaveAcc();
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

            btnSave.Enabled = rs;
        }

        public void DisplayAcc()
        {
            txtAccNo.Text = _acc.SoTaiKhoan;
            txtPIN.Text = _acc.PinCode;
            cboAccTypes.SelectedValue = _acc.MaLoaiTK;
            cboBanks.SelectedValue = _acc.MaNganHang;
            cldOpenDate.Value = _acc.NgayMo;
            txtMoney.Value = _acc.SoDuTK;
            txtName.Text = _acc.HoTen;
            txtID.Text = _acc.SoCMND;
            txtPhone.Text = _acc.DienThoai;
            txtEmail.Text = _acc.Email;
            txtAddress.Text = _acc.DiaChi;
            txtNote.Text = _acc.GhiChu;
            if (_acc.NgayDaoHan == new DateTime(1900, 1, 1)) cldExpired.IsNullDate = true;
            else cldExpired.Value = _acc.NgayDaoHan;
            chkIsClosed.Checked = _acc.DaDong;
        }

        private void SaveAcc()
        {
            _acc.HoTen = txtName.Text;
            _acc.SoCMND = txtID.Text;
            _acc.DiaChi = txtAddress.Text;
            _acc.DienThoai = txtPhone.Text;
            _acc.Email = txtEmail.Text;
            _acc.GhiChu = txtNote.Text;

            string err = _acc.Validate();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                return;
            }

            if (!_acc.Update())
            {
                Program.ShowMsg("Cập nhật không được!", true);
                return;
            }

            _row.Cells["HoTen"].Value = _acc.HoTen;
            _row.Cells["SoCMND"].Value = _acc.SoCMND;
            _row.Cells["DiaChi"].Value = _acc.DiaChi;
            _row.Cells["DienThoai"].Value = _acc.DienThoai;
            _row.Cells["Email"].Value = _acc.Email;
            _row.Cells["GhiChu"].Value = _acc.GhiChu;

            Program.ShowMsg("Đã cập nhật thông tin tài khoản.");
        }
        #endregion
    }
}