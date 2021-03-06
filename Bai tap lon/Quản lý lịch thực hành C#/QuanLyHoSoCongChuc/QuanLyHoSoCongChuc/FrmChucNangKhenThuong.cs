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
    public partial class FrmChucNangKhenThuong : DockContent
    {
        public FrmChucNangKhenThuong()
        {
            InitializeComponent();
        }
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        KhenThuongControl m_KhenThuongControl = new KhenThuongControl();
        private void FrmChucNangKhenThuong_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();

            m_KhenThuongControl.HienThi(dataGridViewDSKhenThuong, bindingNavigatorKhenThuong, txtMaKhenThuong, cmbMaNhanVien, txtLoaiKhenThuong, txtHinhThucKhenThuong, txtCapKhenThuong, mtxtNam);
            m_NhanVienCtrl.HienThiComboBox(cmbMaNhanVien);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaKhenThuong.Enabled = val;
            //cmbMaNhanVien.Enabled = val;
            txtHinhThucKhenThuong.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            //dataGridViewDSKhenThuong.Enabled = val;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            DataRow m_Row = m_KhenThuongControl.ThemDongMoi();
            m_Row["MaNhanVien"] = "";
            m_Row["MaKhenThuong"] = "";
            m_Row["LoaiKhenThuong"]= "";
            m_Row["HinhThucKhenThuong"] = "";
            m_Row["CapKhenThuong"] = "";
            m_Row["Nam"] = "";
            m_KhenThuongControl.ThemKhenThuong(m_Row);
            bindingNavigatorKhenThuong.BindingSource.MoveLast();
            this.Allow(true);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhenThuong.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorKhenThuong.BindingSource.MoveNext();

            m_KhenThuongControl.LuuKhenThuong();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}