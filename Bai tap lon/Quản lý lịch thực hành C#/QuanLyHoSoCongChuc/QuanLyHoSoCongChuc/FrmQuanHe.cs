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
    public partial class FrmQuanHe : Office2007Form
    {
        public FrmQuanHe()
        {
            InitializeComponent();
        }

        QuanHeControl m_QuanHeConTrol = new QuanHeControl();

        private void FrmQuanHe_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_QuanHeConTrol.HienThi(DGVQuanHe, bindingNavigatorQuanHe, txtMaQuanHe, txtTenQuanHe);
 
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaQuanHe.Enabled = val;
            txtTenQuanHe.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVQuanHe.Enabled = val;
        }

        //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_QuanHeConTrol.ThemDongMoi();
            m_Row["MaQuanHe"] = "";
            m_Row["TenQuanHe"] = "";
        
            m_QuanHeConTrol.ThemQuanHe(m_Row);
            bindingNavigatorQuanHe.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorQuanHe.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorQuanHe.BindingSource.MoveNext();
         
            m_QuanHeConTrol.LuuQuanHe();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}