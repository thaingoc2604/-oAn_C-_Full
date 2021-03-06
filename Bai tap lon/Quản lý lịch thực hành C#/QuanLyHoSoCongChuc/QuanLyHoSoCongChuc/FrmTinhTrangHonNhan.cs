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
    public partial class FrmTinhTrangHonNhan : Office2007Form
    {
        public FrmTinhTrangHonNhan()
        {
            InitializeComponent();
        }

        TinhTrangHonNhanControl m_TinhTrangHonNhanConTrol = new TinhTrangHonNhanControl();

        private void FrmTinhTrangHonNhan_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TinhTrangHonNhanConTrol.HienThi(DGVTinhTrangHonNhan, bindingNavigatorTinhTrangHonNhan, txtMaTinhTrangHonNhan, txtTenTinhTrangHonNhan);
           
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTinhTrangHonNhan.Enabled = val;
            txtTenTinhTrangHonNhan.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTinhTrangHonNhan.Enabled = val;
        }

        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TinhTrangHonNhanConTrol.ThemDongMoi();
            m_Row["MaTinhTrangHonNhan"] = "";
            m_Row["TenTinhTrangHonNhan"] = "";
          
            m_TinhTrangHonNhanConTrol.ThemTinhTrangHonNhan(m_Row);
            bindingNavigatorTinhTrangHonNhan.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTinhTrangHonNhan.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTinhTrangHonNhan.BindingSource.MoveNext();
       
            m_TinhTrangHonNhanConTrol.LuuTinhTrangHonNhan();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}