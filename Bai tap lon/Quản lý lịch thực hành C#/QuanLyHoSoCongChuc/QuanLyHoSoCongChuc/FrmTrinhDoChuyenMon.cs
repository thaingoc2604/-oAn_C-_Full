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
    public partial class FrmTrinhDoChuyenMon : Office2007Form
    {
        public FrmTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        TrinhDoChuyenMonControl m_TrinhDoChuyenMonConTrol = new TrinhDoChuyenMonControl();

        private void FrmTrinhDoChuyenMon_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TrinhDoChuyenMonConTrol.HienThi(DGVTrinhDoChuyenMon, bindingNavigatorTrinhDoChuyenMon, txtMaTrinhDoChuyenMon, txtTenTrinhDoChuyenMon);
            
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTrinhDoChuyenMon.Enabled = val;
            txtTenTrinhDoChuyenMon.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTrinhDoChuyenMon.Enabled = val;
        }

        //Them chuc vu    
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoChuyenMonConTrol.ThemDongMoi();
            m_Row["MaTrinhDoChuyenMon"] = "";
            m_Row["TenTrinhDoChuyenMon"] = "";
       
            m_TrinhDoChuyenMonConTrol.ThemTrinhDoChuyenMon(m_Row);
            bindingNavigatorTrinhDoChuyenMon.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoChuyenMon.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTrinhDoChuyenMon.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_TrinhDoChuyenMonConTrol.LuuTrinhDoChuyenMon();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}