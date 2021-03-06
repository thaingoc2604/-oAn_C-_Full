using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmNgachCongChuc : Office2007Form
    {
        public FrmNgachCongChuc()
        {
            InitializeComponent();
        }

        NgachCongChucControl TrinhDoChinhTriControl = new NgachCongChucControl();

        private void FrmNgachCongChuc_Load_1(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            TrinhDoChinhTriControl.HienThi(DGVNgachCongChuc, bindingNavigatorNgachCongChuc, txtMaNgachCongChuc, txtTenNgachCongChuc);
            
            this.Allow(false);
        }   
        void Allow(bool val)
        {
            txtMaNgachCongChuc.Enabled = val;
            txtTenNgachCongChuc.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVNgachCongChuc.Enabled = val;
        }       

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = TrinhDoChinhTriControl.ThemDongMoi();
            m_Row["MaNgachCongChuc"] = "";
            m_Row["TenNgachCongChuc"] = "";
  
            TrinhDoChinhTriControl.ThemNgachCongChuc(m_Row);
            bindingNavigatorNgachCongChuc.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNgachCongChuc.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorNgachCongChuc.BindingSource.MoveNext();
        
            TrinhDoChinhTriControl.LuuNgachCongChuc();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();           
        }         
    }
}