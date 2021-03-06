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
    public partial class frmAnChiXuat : Office2007Form
    {
        public frmAnChiXuat()
        {
            InitializeComponent();
        }
        DaiLyControl dl = new DaiLyControl();
        QuyenSoControl qsctrl = new QuyenSoControl();
        NhanVienControl nvctrl = new NhanVienControl();
        ChiTietGiayChungNhanControl anchictrl = new ChiTietGiayChungNhanControl();
        private void cmbDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDaiLy.SelectedValue!=null)
            qsctrl.HienThiLenComboBox(cmbQuyenSo,cmbDaiLy.SelectedValue.ToString());
        }

        private void frmAnChiXuat_Load(object sender, EventArgs e)
        {
           
            nvctrl.HienThiLenComboBox(cmbChonNhanVien);
            dl.HienThiLenComboBox(cmbDaiLy);
            qsctrl.HienThiLenComboBox(cmbQuyenSo);
        }

        private void cmbNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl.HienThiLenComboBox(cmbDaiLy, cmbChonNhanVien.SelectedValue.ToString());
        }

        private void cmbQuyenSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbQuyenSo.SelectedValue !=null )
            anchictrl.HienThiTheoQuyen(dgv, bn, cmbQuyenSo);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            anchictrl.CapNhat();
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
        frmQuyenSo qs = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (qs == null || qs.IsDisposed)
            {
                qs = new frmQuyenSo();
                
                qs.MaNhanVien = cmbChonNhanVien.SelectedValue.ToString();
                qs.MaDaiLy = cmbDaiLy.SelectedValue.ToString();
                qs.Show();
                qs.MdiParent = (frmMain)this.ParentForm;
                qs.WindowState = FormWindowState.Maximized;
            }
        }


        
    }
}
