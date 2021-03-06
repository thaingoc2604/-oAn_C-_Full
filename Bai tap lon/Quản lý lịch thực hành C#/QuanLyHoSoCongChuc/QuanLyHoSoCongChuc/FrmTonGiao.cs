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
    public partial class FrmTonGiao : Office2007Form
    {
        public FrmTonGiao()
        {
            InitializeComponent();
        }

        TonGiaoControl m_TonGiaoConTrol = new TonGiaoControl();

        private void FrmTonGiao_Load_1(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TonGiaoConTrol.HienThi(DGVTonGiao, bindingNavigatorTonGiao, txtMaTonGiao, txtTenTonGiao);
            // m_TonGiaoCtrl.HienThi(dGVTonGiao, bindingNavigatorTonGiao, txtMaTonGiao, txtTenTonGiao, numPC);
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTonGiao.Enabled = val;
            txtTenTonGiao.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTonGiao.Enabled = val;
        }

        //Them chuc vu
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TonGiaoConTrol.ThemDongMoi();
            m_Row["MaTonGiao"] = "";
            m_Row["TenTonGiao"] = "";
            //m_Row["PhuCap"] = 0;
            m_TonGiaoConTrol.ThemTonGiao(m_Row);
            bindingNavigatorTonGiao.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTonGiao.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTonGiao.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_TonGiaoConTrol.LuuTonGiao();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}