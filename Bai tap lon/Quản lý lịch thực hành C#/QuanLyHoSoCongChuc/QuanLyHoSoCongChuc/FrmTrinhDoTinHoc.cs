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
    public partial class FrmTrinhDoTinHoc : Office2007Form
    {
        public FrmTrinhDoTinHoc()
        {
            InitializeComponent();
        }

        TrinhDoTinHocControl m_TrinhDoTinHocConTrol = new TrinhDoTinHocControl();

        private void FrmTrinhDoTinHoc_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TrinhDoTinHocConTrol.HienThi(DGVTrinhDoTinHoc, bindingNavigatorTrinhDoTinHoc, txtMaTrinhDoTinHoc, txtTenTrinhDoTinHoc);
           
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaTrinhDoTinHoc.Enabled = val;
            txtTenTrinhDoTinHoc.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTrinhDoTinHoc.Enabled = val;
        }

       //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoTinHocConTrol.ThemDongMoi();
            m_Row["MaTrinhDoTinHoc"] = "";
            m_Row["TenTrinhDoTinHoc"] = "";
            m_TrinhDoTinHocConTrol.ThemTrinhDoTinHoc(m_Row);
            bindingNavigatorTrinhDoTinHoc.BindingSource.MoveLast();
            this.Allow(true);
        }

        //
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoTinHoc.BindingSource.RemoveCurrent();
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
            bindingNavigatorTrinhDoTinHoc.BindingSource.MoveNext();
         
            m_TrinhDoTinHocConTrol.LuuTrinhDoTinHoc();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}