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
    public partial class FrmCongViec : Office2007Form
    {
        public FrmCongViec()
        {
            InitializeComponent();
        }

        CongViecControl m_CongViecConTrol = new CongViecControl();

        private void FrmCongViec_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_CongViecConTrol.HienThi(DGVCongViec, bindingNavigatorCongViec, txtMaCongViec, txtTenCongViec);
            // m_CongViecCtrl.HienThi(dGVCongViec, bindingNavigatorCongViec, txtMaCongViec, txtTenCongViec, numPC);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaCongViec.Enabled = val;
            txtTenCongViec.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVCongViec.Enabled = val;
        }

        //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_CongViecConTrol.ThemDongMoi();
            m_Row["MaCongViec"] = "";
            m_Row["TenCongViec"] = "";
            //m_Row["PhuCap"] = 0;
            m_CongViecConTrol.ThemCongViec(m_Row);
            bindingNavigatorCongViec.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorCongViec.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
             bindingNavigatorCongViec.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_CongViecConTrol.LuuCongViec();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        












    }
}