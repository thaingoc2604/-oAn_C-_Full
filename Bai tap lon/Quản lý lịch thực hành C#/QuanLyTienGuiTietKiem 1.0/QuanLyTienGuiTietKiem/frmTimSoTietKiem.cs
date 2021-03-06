using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;
using DevComponents.DotNetBar;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmTimSoTietKiem : Office2007Form
    {
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        public frmTimSoTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimSoTietKiem_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThiComboBox(cmbHoTen);
            m_KhachHangCtrl.HienThiComboBox1(cmbCMND);
            m_KhachHangCtrl.HienThiComboBox2(cmbDiaChi);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.TimSoTietKiem(txtMaSoTietKiem, cmbTheoHoTen, cmbHoTen, cmbTheoDiaChi, cmbDiaChi, cmbTheoCMND, cmbCMND, DGVTimSoTietKiem, BindingNavigatorTimSoTK);
            if (DGVTimSoTietKiem.RowCount == 0)
                MessageBoxEx.Show("Không có sổ tiết kiệm cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}