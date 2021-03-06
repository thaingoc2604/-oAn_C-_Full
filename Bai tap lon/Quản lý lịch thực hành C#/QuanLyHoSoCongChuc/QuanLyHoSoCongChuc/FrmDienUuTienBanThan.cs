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
    public partial class FrmDienUuTienBanThan : Office2007Form
    {
        public FrmDienUuTienBanThan()
        {
            InitializeComponent();
        }

        DienUuTienBanThanControl m_DienUuTienBanThanConTrol = new DienUuTienBanThanControl();

        private void FrmDienUuTienBanThan_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_DienUuTienBanThanConTrol.HienThi(DGVDienUuTienBanThan, bindingNavigatorDienUuTienBanThan, txtMaDienUuTienBanThan, txtTenDienUuTienBanThan);
            // m_DienUuTienBanThanCtrl.HienThi(dGVDienUuTienBanThan, bindingNavigatorDienUuTienBanThan, txtMaDienUuTienBanThan, txtTenDienUuTienBanThan, numPC);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaDienUuTienBanThan.Enabled = val;
            txtTenDienUuTienBanThan.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVDienUuTienBanThan.Enabled = val;
        }       
        //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DienUuTienBanThanConTrol.ThemDongMoi();
            m_Row["MaDienUuTienBanThan"] = "";
            m_Row["TenDienUuTienBanThan"] = "";
            //m_Row["PhuCap"] = 0;
            m_DienUuTienBanThanConTrol.ThemDienUuTienBanThan(m_Row);
            bindingNavigatorDienUuTienBanThan.BindingSource.MoveLast();
            this.Allow(true);
        }

        //
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDienUuTienBanThan.BindingSource.RemoveCurrent();
            }
        }

        //
        private void toolStripSua_Click(object sender, EventArgs e)
        {
             this.Allow(true);
        }

        //
        private void toolStripLuu_Click(object sender, EventArgs e)
        {
              bindingNavigatorDienUuTienBanThan.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_DienUuTienBanThanConTrol.LuuDienUuTienBanThan();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        //
        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVDienUuTienBanThan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }
    }
}