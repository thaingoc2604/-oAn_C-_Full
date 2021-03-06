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

namespace QuanLyHoSoCongChuc
{
    public partial class FrmChucNangQTCT : DockContent
    {
        public FrmChucNangQTCT()
        {
            InitializeComponent();
        }
        NhanVienControl m_NhanVienControl = new NhanVienControl();
        QuaTrinhCongTacControl m_QTCTControl = new QuaTrinhCongTacControl();

        private void FrmChucNangQTCT_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_QTCTControl.HienThi(dataGridViewDSCongTac, bindingNavigatorCongTac, txtMaQTCT, cmbMaNhanVien, txtTenQTCT, dpThoiGianBatDau, dpThoiGianKetThuc);
            m_NhanVienControl.HienThiComboBox(cmbMaNhanVien);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaQTCT.Enabled = val;
            cmbMaNhanVien.Enabled = val;
            txtTenQTCT.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            toolStripLuu.Enabled = val;
            dataGridViewDSCongTac.Enabled = val;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_QTCTControl.ThemDongMoi();
            m_Row["MaNhanVien"] = "";
            m_Row["MaQuaTrinhCongTac"] = "";
            m_Row["TenQuaTrinhCongTac"] = "";
            m_Row["ThoiGianBatDau"] = DateTime.Today;
            m_Row["ThoiGianKetThuc"] = DateTime.Today;
          
            m_QTCTControl.ThemQTCT(m_Row);
            bindingNavigatorCongTac.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorCongTac.BindingSource.RemoveCurrent();
            }
        }
        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorCongTac.BindingSource.MoveNext();
        
            m_QTCTControl.LuuQTCT();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}