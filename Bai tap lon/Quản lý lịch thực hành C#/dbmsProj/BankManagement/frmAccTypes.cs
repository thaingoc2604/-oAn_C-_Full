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
    public partial class frmAccTypes : DevComponents.DotNetBar.Office2007Form
    {
        public frmAccTypes()
        {
            InitializeComponent();
        }

        private void frmAccTypes_Load(object sender, EventArgs e)
        {
            LoadAccTypes();
        }

        #region Code
        DataTable dtAccTypes = null;
        private void LoadAccTypes()
        {
            dtAccTypes = AccType.LoadAccTypes();
            if (dtAccTypes != null && dtAccTypes.Rows.Count > 0)
            {
                grdLoaiTK.SetDataBinding(dtAccTypes, "");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            grdLoaiTK.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            grdLoaiTK.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            ButtonState(true);
            this.Cursor = Cursors.Default;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dtChanges = dtAccTypes.GetChanges();
            if (dtChanges == null || dtChanges.Rows.Count == 0)
            {
                Program.ShowMsg("Không có gì mới từ CSDL cũ!", true);
                this.Cursor = Cursors.Default;
                return;
            }
            dtChanges.Dispose();

            string msg = "";
            ArrayList errRows = new ArrayList();
            foreach (DataRow row in dtAccTypes.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Added:
                        string nTenLoaiTK = row["TenLoaiTK"].ToString();
                        float nLaiSuat = float.Parse(row["LaiSuat"].ToString());
                        int nKyHan = int.Parse(row["KyHan"].ToString());
                        string nGhiChu = row["GhiChu"].ToString();
                        AccType type = new AccType(0, nTenLoaiTK, nLaiSuat, nKyHan, nGhiChu);
                        string err = "";
                        if (!type.Add(ref err))
                        {
                            msg += nTenLoaiTK + ": " + err + "\n";
                            //add invalid new row into an array list, delete after ('cause can't delete that row here)
                            errRows.Add(row);
                        }
                        else row["MaLoaiTK"] = type.MaLoaiTK;
                        break;
                    case DataRowState.Modified:
                        int nMaLoaiTK = int.Parse(row["MaLoaiTK"].ToString());
                        nTenLoaiTK = row["TenLoaiTK"].ToString();
                        nLaiSuat = float.Parse(row["LaiSuat"].ToString());
                        nKyHan = int.Parse(row["KyHan"].ToString());
                        nGhiChu = row["GhiChu"].ToString();
                        type = new AccType(nMaLoaiTK, nTenLoaiTK, nLaiSuat, nKyHan, nGhiChu);
                        err = "";
                        if (!type.Update(ref err))
                        {
                            msg += nTenLoaiTK + ": " + err + "\n";
                            row.RejectChanges();
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (DataRow row in errRows) row.Delete();
            errRows.Clear();
            dtAccTypes.AcceptChanges();
            if (msg == "") msg = "Lưu thành công.";
            Program.ShowMsg(msg);            

            grdLoaiTK.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            grdLoaiTK.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dtAccTypes.RejectChanges();
            grdLoaiTK.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            grdLoaiTK.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            ButtonState(false);
            this.Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            GridEXRow[] rows = grdLoaiTK.GetCheckedRows();
            if (rows.Length == 0)
            {
                Program.ShowMsg("Chưa chọn loại tài khoản!", true);
                this.Cursor = Cursors.Default;
                return;
            }

            foreach (GridEXRow row in rows)
            {
                int typeID = int.Parse(row.Cells["MaLoaiTK"].Value.ToString());
                AccType.DelAccType(typeID);
                row.Delete();
            }
            this.Cursor = Cursors.Default;
        }
    }
}