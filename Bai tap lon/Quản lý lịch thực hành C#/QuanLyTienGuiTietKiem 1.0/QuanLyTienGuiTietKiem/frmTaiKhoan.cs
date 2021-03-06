using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmTaiKhoan : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        TaiKhoanCtrl m_TaiKhoanCtrl = new TaiKhoanCtrl();
        DMTaiKhoanCtrl m_DMTaiKhoanCtrl = new DMTaiKhoanCtrl();
        public frmTaiKhoan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            
            m_DMTaiKhoanCtrl.HienThiDataGridViewComboBoxColumn(colSoHieuTaiKhoan);
            m_DMTaiKhoanCtrl.HienThiComboBox(cmbSoHieuTaiKhoan);

            m_TaiKhoanCtrl.HienThi(DGVTaiKhoan,BindingNavigatorTaiKhoan,dtNgayCapNhat,txtSoDuDauNgay,txtSoPhatSinhNo,txtSoPhatSinhCo,cmbSoHieuTaiKhoan);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVTaiKhoan.RowCount == 0)
                BindingNavigatorTaiKhoan.Enabled = true;
            DataRow m_Row = m_TaiKhoanCtrl.ThemDongMoi();
            m_Row["SoHieuTaiKhoan"] = "";
            m_Row["SoDuDauNgay"] = 0;
            m_Row["SoPhatSinhNo"] = 0;
            m_Row["SoPhatSinhCo"] = 0;
            m_Row["NgayCapNhat"] = DateTime.Today;
            
            
            m_TaiKhoanCtrl.ThemMoi(m_Row);
            BindingNavigatorTaiKhoan.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVTaiKhoan.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (KiemTraTruocKhiLuu("colSoHieuTaiKhoan") == true &&
                KiemTraTruocKhiLuu("colSoDuDauNgay") == true &&
                KiemTraTruocKhiLuu("colSoPhatSinhNo") == true &&
                KiemTraTruocKhiLuu("colSoPhatSinhCo") == true &&
                KiemTraTruocKhiLuu("colNgayCapNhat") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_TaiKhoanCtrl.LuuTaiKhoan();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVTaiKhoan.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorTaiKhoan.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDMTaiKhoan();
        }
    }
}