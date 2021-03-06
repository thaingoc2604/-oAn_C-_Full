using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmChucVu : Office2007Form
    {
        public FrmChucVu()
        {
            InitializeComponent();
        }

        ChucVuControl m_ChucVuConTrol = new ChucVuControl();

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_ChucVuConTrol.HienThi(DGVChucVu, bindingNavigatorChucVu, txtMaChucVu, txtTenChucVu);
            // m_ChucVuCtrl.HienThi(dGVChucVu, bindingNavigatorChucVu, txtMaChucVu, txtTenChucVu, numPC);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaChucVu.Enabled = val;
            txtTenChucVu.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVChucVu.Enabled = val;
        }

        //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_ChucVuConTrol.ThemDongMoi();
            m_Row["MaChucVu"] = "";
            m_Row["TenChucVu"] = "";
            //m_Row["PhuCap"] = 0;
            m_ChucVuConTrol.ThemChucVu(m_Row);
            bindingNavigatorChucVu.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorChucVu.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorChucVu.BindingSource.MoveNext();
      
            m_ChucVuConTrol.LuuChucVu();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //


       
















    }
}