using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Janus.Windows.GridEX;

namespace BankManagement
{
    public partial class frmBank : DevComponents.DotNetBar.Office2007Form
    {
        public frmBank()
        {
            InitializeComponent();
        }

        private void frmDSNganHang_Load(object sender, EventArgs e)
        {
            LoadBanks();
        }

        #region Code
        DataTable dtBanks = null;
        private void LoadBanks()
        {
            dtBanks = Bank.LoadBanks();
            if (dtBanks != null && dtBanks.Rows.Count > 0)
            {
                grdBanks.SetDataBinding(dtBanks, "");
            }
        }

        private void ButtonState(bool status)
        {
            btnCancel.Enabled = status;
            btnOK.Enabled = status;
            btnEdit.Enabled = !status;
            btnDelete.Enabled = !status;
        }
        #endregion

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            GridEXRow[] rows = grdBanks.GetCheckedRows();
            if (rows.Length == 0)
            {
                Program.ShowMsg("Chưa chọn ngân hàng!!!", true);
                this.Cursor = Cursors.Default;
                return;
            }

            foreach (GridEXRow row in rows)
            {
                int bankID = int.Parse(row.Cells["MaNganHang"].Value.ToString());
                Bank.DelBank(bankID);
                row.Delete();
            }
            this.Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grdBanks.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            grdBanks.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            ButtonState(true);
            this.Cursor = Cursors.Default;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dtChanges = dtBanks.GetChanges();
            if (dtChanges == null && dtChanges.Rows.Count == 0)
            {
                Program.ShowMsg("Không có gì mới từ CSDL cũ!", true);
                this.Cursor = Cursors.Default;
                return;
            }
            dtChanges.Dispose();
            string msg = "";
            ArrayList errRows = new ArrayList();
            foreach (DataRow row in dtBanks.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Added:
                        string nTenNganHang = row["TenNganHang"].ToString();
                        string nGhiChu = row["GhiChu"].ToString();
                        Bank b = new Bank(0, nTenNganHang, nGhiChu);

                        string err = "";
                        if (!b.Add(ref err))
                        {
                            errRows.Add(row);
                            msg += nTenNganHang + ": " + err + "\n";
                        }
                        else row["MaNganHang"] = b.MaNganHang;
                        break;
                    case DataRowState.Modified:
                        int nMaNganHang = int.Parse(row["MaNganHang"].ToString());
                        nTenNganHang = row["TenNganHang"].ToString();
                        nGhiChu = row["GhiChu"].ToString();
                        b = new Bank(nMaNganHang, nTenNganHang, nGhiChu);
                        err = "";
                        if (!b.Update(ref err)) 
                        {
                            msg += nTenNganHang + ": " + err + "\n";
                            row.RejectChanges();
                        }                        
                        break;
                    default:
                        break;
                }
            }

            foreach (DataRow row in errRows) row.Delete();
            errRows.Clear();
            dtBanks.AcceptChanges();
            if (msg == "") msg = "Lưu thành công.";
            Program.ShowMsg(msg);

            grdBanks.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            grdBanks.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grdBanks.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            grdBanks.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }
    }
}