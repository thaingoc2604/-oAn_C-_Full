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
    public partial class FrmTrinhDoQuanLyNhaNuoc : Office2007Form
    {
        public FrmTrinhDoQuanLyNhaNuoc()
        {
            InitializeComponent();
        }

        TrinhDoQuanLyNhaNuocControl m_TrinhDoQuanLyNhaNuocConTrol = new TrinhDoQuanLyNhaNuocControl();

        private void FrmTrinhDoQuanLyNhaNuoc_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TrinhDoQuanLyNhaNuocConTrol.HienThi(DGVTrinhDoQuanLyNhaNuoc, bindingNavigatorTrinhDoQuanLyNhaNuoc, txtMaTrinhDoQuanLyNhaNuoc, txtTenTrinhDoQuanLyNhaNuoc);
         
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTrinhDoQuanLyNhaNuoc.Enabled = val;
            txtTenTrinhDoQuanLyNhaNuoc.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTrinhDoQuanLyNhaNuoc.Enabled = val;
        }

        //Them chuc vu              
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoQuanLyNhaNuocConTrol.ThemDongMoi();
            m_Row["MaTrinhDoQuanLyNhaNuoc"] = "";
            m_Row["TenTrinhDoQuanLyNhaNuoc"] = "";
            //m_Row["PhuCap"] = 0;
            m_TrinhDoQuanLyNhaNuocConTrol.ThemTrinhDoQuanLyNhaNuoc(m_Row);
            bindingNavigatorTrinhDoQuanLyNhaNuoc.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoQuanLyNhaNuoc.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTrinhDoQuanLyNhaNuoc.BindingSource.MoveNext();
          
            m_TrinhDoQuanLyNhaNuocConTrol.LuuTrinhDoQuanLyNhaNuoc();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}