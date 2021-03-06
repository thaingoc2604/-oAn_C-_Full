using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using System.Collections;
using DevComponents.DotNetBar;

namespace QUANLIKH.GiaoDien
{
    public partial class frmTinhtrangGiayChungNhan : Office2007Form
    {
        public frmTinhtrangGiayChungNhan()
        {
            InitializeComponent();
        }

        TinhTrangGiayChungNhanControl ctrl = new TinhTrangGiayChungNhanControl();

        private void frmTinhtrangGiayChungNhan_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(dgv, bn, txtMaTinhTrang, txtTenTinhTrang);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            ctrl.CapNhat();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }
            }
        }

        private void dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }

            }
            else e.Cancel = true;
        }
    }
}