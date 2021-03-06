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
    public partial class FrmChucNangQTBD : DockContent
    {
        public FrmChucNangQTBD()
        {
            InitializeComponent();
        }
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        QuaTrinhBoiDuongControl m_QTBDControl = new QuaTrinhBoiDuongControl();

        private void FrmChucNangQTBD_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();

            m_QTBDControl.HienThi(dataGridViewDSQTBD, bindingNavigatorQTBD, txtMaQTBD, cmbMaNhanVien, txtTenQTBD,txtThoiGian, txtNoiBoiDuong, txtLoaiHinhBoiDuong, txtChungChi );
            m_NhanVienCtrl.HienThiComboBox(cmbMaNhanVien);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaQTBD.Enabled = val;

            txtTenQTBD.Enabled = val;
            toolStripLuu.Enabled = val;
            bindingNavigatorDeleteItem.Enabled = val;
            dataGridViewDSQTBD.Enabled = val;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            DataRow m_Row = m_QTBDControl.ThemDongMoi();
            m_Row["MaNhanVien"] = "";
            m_Row["MaQuaTrinhBoiDuong"] = "";
            m_Row["TenQuaTrinhBoiDuong"] = "";
            m_Row["ThoiGian"] = "";
            m_Row["NoiBoiDuong"] = "";
            m_Row["LoaiHinhBoiDuong"] = "";
            m_Row["ChungChi"] = "";
            m_QTBDControl.ThemQTBD(m_Row);
            bindingNavigatorQTBD.BindingSource.MoveLast();
            this.Allow(true);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorQTBD.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorQTBD.BindingSource.MoveNext();

            m_QTBDControl.LuuQTBD();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewDSNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5))
            {

                m_QTBDControl.HienThiDataGridView(dataGridViewDSQTBD);

            }
        }        
    }
}