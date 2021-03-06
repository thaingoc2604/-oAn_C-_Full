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
    public partial class FrmChucNangThanNhan : DockContent
    {
        public FrmChucNangThanNhan()
        {
            InitializeComponent();
        }
        ThanNhanControl m_ThanNhanCtrl = new ThanNhanControl();

        private void FrmChucNangThanNhan_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_ThanNhanCtrl.HienThiThanNhan(DGVThanNhan, bindingNavigatorThanNhan, txtMaThanNhan, txtTenThanNhan, cbxTenNhanVien, cbxQuanHe, txtNamSinh, txtDiaChi, txtNgheNghiep, txtNuocDinhCu, txtQuocTich, txtNamDinhCu);
            m_ThanNhanCtrl.HienThiComboBoxThanNhan(cbxTenNhanVien, cbxQuanHe);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaThanNhan.Enabled = val;

            txtTenThanNhan.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_ThanNhanCtrl.ThemDongMoi();
            m_Row["MaThanNhan"] = "";
            m_Row["TenThanNhan"] = "";
            m_Row["MaNhanVien"] = "";
            m_Row["MaQuanHe"] = "";
            m_Row["NamSinh"] = "";
            m_Row["DiaChi"] = "";
            m_Row["NgheNghiep"] = "";
            m_Row["NuocDinhCu"] = "";
            m_Row["QuocTich"] = "";
            m_Row["NamDinhCu"] = "";
            m_ThanNhanCtrl.ThemThanNhan(m_Row);
            bindingNavigatorThanNhan.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorThanNhan.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorThanNhan.BindingSource.MoveNext();

            m_ThanNhanCtrl.LuuThanNhan();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}