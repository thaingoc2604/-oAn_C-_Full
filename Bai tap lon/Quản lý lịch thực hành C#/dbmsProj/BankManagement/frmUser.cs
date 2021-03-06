using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace BankManagement
{
    public partial class frmUser : DevComponents.DotNetBar.Office2007Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        #region Code
        DataTable dtUsers = null;
        private void LoadUsers()
        {
            dtUsers = User.LoadUsers();
            if (dtUsers != null && dtUsers.Rows.Count > 0)
            {
                grdUser.SetDataBinding(dtUsers, "");
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
            GridEXRow[] rows = grdUser.GetCheckedRows();
            if (rows.Length == 0)
            {
                Program.ShowMsg("Chưa chọn user", true);
                this.Cursor = Cursors.Default;
                return;
            }

            foreach (GridEXRow row in rows)
            {
                string uid = row.Cells["f_Username"].Value.ToString();
                User.DelUser(uid);
                row.Delete();
            }
            this.Cursor = Cursors.Default;
        } 
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            ButtonState(true);
            this.Cursor = Cursors.Default;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dtChanges = dtUsers.GetChanges();
            if (dtChanges == null && dtChanges.Rows.Count == 0)
            {
                Program.ShowMsg("Không có gì mới từ CSDL cũ!", true);
                this.Cursor = Cursors.Default;
                return;
            }
            dtChanges.Dispose();

            string msg = "";
            ArrayList errRows= new ArrayList();
            foreach (DataRow row in dtUsers.Rows)
                if (row.RowState==DataRowState.Modified)
                {
                    string uid = row["f_Username"].ToString();
                    string pwd = row["f_Password"].ToString();
                    bool permit = (bool)(row["f_Permit"]);
                    User u = new User(uid, pwd, permit);
                    string err = "";
                    if (!u.Update())
                    {
                        msg += uid + ": " + err + "\n";
                        row.RejectChanges();
                    }
                }

            foreach (DataRow row in errRows) row.Delete();
            errRows.Clear();
            if (msg == "") msg = "Lưu thành công.";
            Program.ShowMsg(msg);
            dtUsers.AcceptChanges();

            grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dtUsers.RejectChanges();
            grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }
    }
}