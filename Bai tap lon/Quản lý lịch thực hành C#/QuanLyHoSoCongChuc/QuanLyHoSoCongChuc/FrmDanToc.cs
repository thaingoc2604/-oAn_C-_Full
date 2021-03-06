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
    public partial class FrmDanToc : Office2007Form
    {
        public FrmDanToc()
        {
            InitializeComponent();
        }

        DanTocControl m_DanTocConTrol = new DanTocControl();

        private void FrmDanToc_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_DanTocConTrol.HienThi(DGVDanToc, bindingNavigatorDanToc, txtMaDanToc, txtTenDanToc);
            // m_DanTocCtrl.HienThi(dGVDanToc, bindingNavigatorDanToc, txtMaDanToc, txtTenDanToc, numPC);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaDanToc.Enabled = val;
            txtTenDanToc.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVDanToc.Enabled = val;
        }

      
        //
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            DataRow m_Row = m_DanTocConTrol.ThemDongMoi();
            m_Row["MaDanToc"] = "";
            m_Row["TenDanToc"] = "";
            //m_Row["PhuCap"] = 0;
            m_DanTocConTrol.ThemDanToc(m_Row);
            bindingNavigatorDanToc.BindingSource.MoveLast();
            this.Allow(true);
        }
        
        //
        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDanToc.BindingSource.RemoveCurrent();
            }
        }

        //      
        private void toolStripSua_Click_1(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        //
        private void toolStripLuu_Click_1(object sender, EventArgs e)
        {
            bindingNavigatorDanToc.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_DanTocConTrol.LuuDanToc();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }

        //
        private void toolStripThoat_Click_1(object sender, EventArgs e)
        {
             this.Close();
        }

       

     

      













    }
}