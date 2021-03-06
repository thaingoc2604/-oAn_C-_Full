
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmDonVi : DockContent
    {
        public FrmDonVi()
        {
            InitializeComponent();
        }
        LoaiDonViControl m_LoaiDonViCtrl = new LoaiDonViControl();
        DonViControl m_DonViControl = new DonViControl();
        private void FrmDonVi_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_LoaiDonViCtrl.HienThiComBoBox(cmbThuoc);
            m_DonViControl.HienThi(DGVDonVi, bindingNavigatorDonVi, txtMaDonVi, txtTenDonVi, cmbThuoc);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaDonVi.Enabled = val;
            txtTenDonVi.Enabled = val;
            cmbThuoc.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            toolStripLuu.Enabled = val;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DonViControl.ThemDongMoi();
            m_Row["MaDonVi"] = "";
            m_Row["TenDonVi"] = "";
            m_Row["MaLoaiDonVi"] = "";
            m_DonViControl.ThemDonVi(m_Row);
            bindingNavigatorDonVi.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDonVi.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorDonVi.BindingSource.MoveNext();
            m_DonViControl.LuuDonVi();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}