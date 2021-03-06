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
    public partial class frmAccs : DevComponents.DotNetBar.Office2007Form
    {
        public frmAccs(frmMain nParent)
        {
            InitializeComponent();
            this.MdiParent = nParent;
            nParent.pnClient.Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            frmMain f = this.MdiParent as frmMain;
            if (f.MdiChildren.Length == 1) f.pnClient.Visible = true;
        }

        private void frmAccs_Load(object sender, EventArgs e)
        {
            FillCols();
            FormatGrid();
            FillGrid();            
        }

        private void biClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdAccs_SelectionChanged(object sender, EventArgs e)
        {
            GridEXRow row = grdAccs.GetRow();
            if (row != null && row.RowType == RowType.Record)
            {
                string accID = row.Cells["SoTaiKhoan"].Value.ToString();
                DataSet dsTrans = Account.Transactions(accID);
                if (dsTrans != null && dsTrans.Tables.Count > 0)
                {
                    grdSend.SetDataBinding(dsTrans.Tables[0], "");
                    grdWithdraw.SetDataBinding(dsTrans.Tables[1], "");
                    grdTransfer.SetDataBinding(dsTrans.Tables[2], "");
                }
            }
        }

        private void biDelAcc_Click(object sender, EventArgs e)
        {
            this.MdiParent.Cursor = Cursors.WaitCursor;
            DelAccs();
            this.MdiParent.Cursor = Cursors.Default;
        }

        private void biEditAcc_Click(object sender, EventArgs e)
        {
            this.MdiParent.Cursor = Cursors.WaitCursor;
            EditAcc();
            this.MdiParent.Cursor = Cursors.Default;
        }

        private void grdAccs_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            this.MdiParent.Cursor = Cursors.WaitCursor;
            EditAcc();
            this.MdiParent.Cursor = Cursors.Default;
        }

        #region Code
        private void FillCols()
        {
            GridEXColumn col = null;
            DataTable dtAccTypes = AccType.LoadAccTypes();
            if (dtAccTypes != null && dtAccTypes.Rows.Count > 0)
            {
                col = grdAccs.RootTable.Columns["MaLoaiTK"];
                col.ValueList.PopulateValueList(dtAccTypes.DefaultView, "MaLoaiTK", "TenLoaiTK");
            }

            DataTable dtBanks = Bank.LoadBanks();
            if (dtBanks != null && dtBanks.Rows.Count > 0)
            {
                col = grdAccs.RootTable.Columns["MaNganHang"];
                col.ValueList.PopulateValueList(dtBanks.DefaultView, "MaNganHang", "TenNganHang");
            }
        }

        private void FormatGrid()
        {
            GridEXColumn col = grdAccs.RootTable.Columns["DaDong"];
            GridEXFormatCondition condition = new GridEXFormatCondition(col, ConditionOperator.Equal, true);
            condition.FormatStyle.FontStrikeout = TriState.True;
            condition.FormatStyle.ForeColor = Color.Gray;
            grdAccs.RootTable.FormatConditions.Add(condition);
        }

        private void FillGrid()
        {
            DataTable dtAccs = Account.LoadAccounts();
            if (dtAccs != null && dtAccs.Rows.Count > 0)
                grdAccs.SetDataBinding(dtAccs, "");
        }

        private void DelAccs()
        {
            GridEXRow[] rows = grdAccs.GetCheckedRows();
            if (rows.Length == 0)
            {
                Program.ShowMsg("Chưa chọn tài khoản để xoá!", true);
                return;
            }

            sb.Panels[0].Text = "Đang xoá...";
            int i = 1;
            foreach (GridEXRow row in rows)
                if (row.RowType == RowType.Record)
                {
                    string accID = row.Cells["SoTaiKhoan"].Value.ToString();
                    Account.DelAcc(accID);
                    row.Delete();

                    sb.Panels[1].ProgressBarValue = i;
                }

            sb.Panels[1].ProgressBarValue = 0;
            sb.Panels[0].Text = "Ready.";
        }

        private void EditAcc()
        {
            GridEXRow row = grdAccs.GetRow();
            if (row != null && row.RowType == RowType.Record)
            {
                string nSoTaiKhoan = row.Cells["SoTaiKhoan"].Value.ToString();
                string nPinCode = row.Cells["PinCode"].Value.ToString();
                string nHoTen = row.Cells["HoTen"].Value.ToString();
                string nSoCMND = row.Cells["SoCMND"].Value.ToString();
                string nDiaChi = row.Cells["DiaChi"].Value.ToString();
                string nDienThoai = row.Cells["DienThoai"].Value.ToString();
                string nEmail = row.Cells["Email"].Value.ToString();
                DateTime nNgayMo = (DateTime)(row.Cells["NgayMo"].Value);

                DateTime nNgayDaoHan;
                object obj = row.Cells["NgayDaoHan"].Value;
                if (obj.GetType() == typeof(DBNull)) nNgayDaoHan = new DateTime(1900,1,1);
                else nNgayDaoHan = (DateTime)(row.Cells["NgayDaoHan"].Value);

                int nMaLoaiTK = int.Parse(row.Cells["MaLoaiTK"].Value.ToString());
                int nMaNganHang = int.Parse(row.Cells["MaNganHang"].Value.ToString());
                decimal nSoDuTK = (decimal)(row.Cells["SoDuTK"].Value);
                bool nDaDong = (bool)(row.Cells["DaDong"].Value);
                string nGhiChu = row.Cells["GhiChu"].Value.ToString();
                Account acc = new Account(nSoTaiKhoan, nPinCode, nHoTen, nSoCMND, nDiaChi, nDienThoai,
                    nEmail, nNgayMo, nNgayDaoHan, nMaLoaiTK, nMaNganHang, nSoDuTK, nDaDong, nGhiChu);
                frmEditAcc f = new frmEditAcc(acc, row);
                f.ShowDialog();
            }
            else Program.ShowMsg("Chưa chọn tài khoản!", true);
        }
        #endregion
    }
}