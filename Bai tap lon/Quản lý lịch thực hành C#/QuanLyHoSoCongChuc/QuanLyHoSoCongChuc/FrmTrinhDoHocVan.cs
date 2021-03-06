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
    public partial class FrmTrinhDoHocVan : Office2007Form
    {
        public FrmTrinhDoHocVan()
        {
            InitializeComponent();
        }

        TrinhDoHocVanControl m_TrinhDoHocVanConTrol = new TrinhDoHocVanControl();

        private void FrmTrinhDoHocVan_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TrinhDoHocVanConTrol.HienThi(DGVTrinhDoHocVan, bindingNavigatorTrinhDoHocVan, txtMaTrinhDoHocVan, txtTenTrinhDoHocVan);
        
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTrinhDoHocVan.Enabled = val;
            txtTenTrinhDoHocVan.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTrinhDoHocVan.Enabled = val;
        }

        //Them chuc vu        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoHocVanConTrol.ThemDongMoi();
            m_Row["MaTrinhDoHocVan"] = "";
            m_Row["TenTrinhDoHocVan"] = "";
            //m_Row["PhuCap"] = 0;
            m_TrinhDoHocVanConTrol.ThemTrinhDoHocVan(m_Row);
            bindingNavigatorTrinhDoHocVan.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoHocVan.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTrinhDoHocVan.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_TrinhDoHocVanConTrol.LuuTrinhDoHocVan();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
        
    }
}