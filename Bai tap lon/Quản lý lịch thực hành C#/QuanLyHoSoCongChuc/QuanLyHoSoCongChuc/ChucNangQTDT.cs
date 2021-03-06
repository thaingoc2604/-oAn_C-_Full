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
    public partial class ChucNangQTDT : DockContent
    {
        public ChucNangQTDT()
        {
            InitializeComponent();
        }
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        QuaTrinhDaoTaoControl m_QTDTControl = new QuaTrinhDaoTaoControl();
        private void ChucNangQTDT_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
          
            m_QTDTControl.HienThi(dataGridViewDSQTDT, bindingNavigatorQTDT, txtMaQTDT, cmbMaNhanVien, txtTenQTDT, dpThoiGianBatDauDaoTao, dpThoiGianKetThucDaoTao, txtHinhThucDaoTao, txtBangCap);
         
            m_NhanVienCtrl.HienThiComboBox(cmbMaNhanVien);
            this.Allow(false);
        }

        void Allow(bool val)
        {
            txtMaQTDT.Enabled = val;
          
            txtTenQTDT.Enabled = val;
           toolStripLuu.Enabled = val;
           bindingNavigatorDeleteItem.Enabled = val;
           dataGridViewDSQTDT.Enabled = val;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            DataRow m_Row = m_QTDTControl.ThemDongMoi();
            m_Row["MaNhanVien"] = "";
            m_Row["MaQuaTrinhDaoTao"] = "";
            m_Row["TenQuaTrinhDaoTao"] = "";
            m_Row["ThoiGianBatDauDaoTao"] = DateTime.Today;
            m_Row["ThoiGianKetThucDaoTao"] = DateTime.Today;
            m_Row["HinhThucDaoTao"] = "";
            m_Row["BangCap"] = "";
            m_QTDTControl.ThemQTDT(m_Row);
            bindingNavigatorQTDT.BindingSource.MoveLast();
             this.Allow(true);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorQTDT.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorQTDT.BindingSource.MoveNext();

            m_QTDTControl.LuuQTDT();
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

                m_QTDTControl.HienThiDataGridView(dataGridViewDSQTDT);

            }
        }        
    }
}