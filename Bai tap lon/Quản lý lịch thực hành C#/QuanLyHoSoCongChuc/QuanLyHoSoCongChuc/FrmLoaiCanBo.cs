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
    public partial class FrmLoaiCanBo : Office2007Form
    {
        public FrmLoaiCanBo()
        {
            InitializeComponent();
        }

        LoaiCanBoControl m_LoaiCanBoConTrol = new LoaiCanBoControl();

        private void FrmLoaiCanBo_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_LoaiCanBoConTrol.HienThi(DGVLoaiCanBo, bindingNavigatorLoaiCanBo, txtMaLoaiCanBo, txtTenLoaiCanBo);
          
            this.Allow(false);
        }        

        void Allow(bool val)
        {
            txtMaLoaiCanBo.Enabled = val;
            txtTenLoaiCanBo.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            DGVLoaiCanBo.Enabled = val;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_LoaiCanBoConTrol.ThemDongMoi();
            m_Row["MaLoaiCanBo"] = "";
            m_Row["TenLoaiCanBo"] = "";
    
            m_LoaiCanBoConTrol.ThemLoaiCanBo(m_Row);
            bindingNavigatorLoaiCanBo.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiCanBo.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorLoaiCanBo.BindingSource.MoveNext();
        
            m_LoaiCanBoConTrol.LuuLoaiCanBo();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}