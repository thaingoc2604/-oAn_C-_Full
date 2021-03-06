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
    public partial class frmQuyenSo : Office2007Form
    {
        public frmQuyenSo()
        {
            InitializeComponent();
        }
        //-- các tham số truyền Tạo quyển cho Đại lý
        private string _MaNhanVien;

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        private string _MaDaiLy;

        public string MaDaiLy
        {
            get { return _MaDaiLy; }
            set { _MaDaiLy = value; }
        }

        DaiLyControl dlctrl = new DaiLyControl();
        QuyenSoControl qsctrl = new QuyenSoControl();
        private void frmQuyenSo_Load(object sender, EventArgs e)
        {
            
         
            dlctrl.HienThiLenComboBox(cmbMaDaiLy);
            cmbMaDaiLy.SelectedIndex = 0;
            if (MaDaiLy != null)
            {
                cmbMaDaiLy.SelectedValue = MaDaiLy;
                
            }
            qsctrl.HienThi(dgv, bn, txtMaQuyen, cmbMaDaiLy.SelectedValue.ToString(), dtNgayNhan, dtnNgayQuyetToan, txtTuSo, txtDenSo, txtMaSoThanhToan, txtGhiChu);
            
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            qsctrl.CapNhat();
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

        private void dtNgayNhan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
              if(cmbMaDaiLy.SelectedIndex!=0)
              qsctrl.HienThi(dgv, bn, txtMaQuyen, cmbMaDaiLy.SelectedValue.ToString(), dtNgayNhan, dtnNgayQuyetToan, txtTuSo, txtDenSo, txtMaSoThanhToan, txtGhiChu);
            
        
        }

        private void cmbMaDaiLy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}