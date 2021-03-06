using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;
using System.Collections;

namespace QUANLIKH.GiaoDien
{
    public partial class frmMucBaoHiem : Office2007Form
    {
        public frmMucBaoHiem()
        {
            InitializeComponent();
        }
        MucBaoHiemControl ctrl = new MucBaoHiemControl();
        private void frmMucBaoHiem_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(dgv, bn, txtMaLoai, txtPhiBaoHiem, txtMucTrachNhiem, txtDienGiai);
            
        }

        private void luu_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dgv.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dgv.Rows.Remove(row);
                }
            }
        }

    }
}