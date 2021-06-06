using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    public partial class frmSelectTableExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmSelectTableExcel()
        {
            InitializeComponent();
        }
        DataTable dtTable = new DataTable();
        string tableName = string.Empty;
        string[] Tables;
        bool DataTables = false;

        public frmSelectTableExcel(string[] strTable)
        {
            InitializeComponent();//Download source code tại Sharecode.vn
            Tables = strTable;
        }
        public frmSelectTableExcel(DataTable dt)
        {
            InitializeComponent();
            dtTable = dt;
            DataTables = true;
        }
        private void frmSelectTableExcel_Load(object sender, EventArgs e)
        {
            if (!DataTables)
            {
                if (Tables != null)
                {
                    for (int tables = 0; tables < Tables.Length; tables++)
                    {
                        try
                        {
                            ListViewItem lv = new ListViewItem();
                            lv.Text = Tables[tables].ToString();
                            lv.Tag = tables;
                            lstViewTables.Items.Add(lv);
                        }
                        catch
                        { }
                    }
                }
            }
            else
            {
                if (dtTable.Rows.Count > 0)
                {
                    for (int tables = 0; tables < dtTable.Rows.Count; tables++)
                    {
                        try
                        {
                            ListViewItem lv = new ListViewItem();
                            lv.Text = dtTable.Rows[tables][0].ToString();
                            lv.Tag = dtTable.Rows[tables][0];
                            lstViewTables.Items.Add(lv);
                        }
                        catch
                        { }
                    }
                }
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstViewTables.Items.Count > 0)
            {
                if (tableName != string.Empty)
                {
                   frmStudentToRegisters.SelectedTable = tableName;
                   frmStudent.SelectedTable1 = tableName;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Select a Table");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void lstViewTables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tableName = e.Item.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}