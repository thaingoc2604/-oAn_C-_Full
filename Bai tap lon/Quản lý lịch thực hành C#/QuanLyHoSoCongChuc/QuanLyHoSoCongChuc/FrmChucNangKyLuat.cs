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
    public partial class FrmChucNangKyLuat : DockContent
    {
        public FrmChucNangKyLuat()
        {
            InitializeComponent();
        }
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        KyLuatControl m_KyLuatControl = new KyLuatControl();
        private void FrmChucNangKyLuat_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();

            m_KyLuatControl.HienThi(dataGridViewDSKyLuat, bindingNavigatorKyLuat, txtMaKyLuat, cmbMaNhanVien, txtHinhThucKyLuat, dtNgayKyLuat, txtCoQuanRaQuyetDinh, txtNguyenNhan, txtCoQuanSauKyLuat );
            m_NhanVienCtrl.HienThiComboBox(cmbMaNhanVien);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaKyLuat.Enabled = val;

            txtHinhThucKyLuat.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            dataGridViewDSKyLuat.Enabled = val;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            DataRow m_Row = m_KyLuatControl.ThemDongMoi();
            m_Row["MaNhanVien"] = "";
            m_Row["MaKyLuat"] = "";
            m_Row["HinhThucKyLuat"] = "";
            m_Row["NgayKyLuat"] = DateTime.Today;
            m_Row["CoQuanRaQuyetDinh"] = "";
            m_Row["NguyenNhan"] = "";
            m_Row["CoQuanSauKyLuat"] = "";
            m_KyLuatControl.ThemKyLuat(m_Row);
            bindingNavigatorKyLuat.BindingSource.MoveLast();
            this.Allow(true);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKyLuat.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorKyLuat.BindingSource.MoveNext();

            m_KyLuatControl.LuuKyLuat();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}