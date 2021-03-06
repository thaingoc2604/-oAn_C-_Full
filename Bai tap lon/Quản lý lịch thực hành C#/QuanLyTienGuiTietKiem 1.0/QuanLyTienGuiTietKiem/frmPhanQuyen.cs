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
    public partial class frmPhanQuyen : Office2007Form
    {
        PhanQuyenCtrl m_PhanQuyenCtrl = new PhanQuyenCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        NhomNguoiDungCtrl m_NhomNguoiDungCtrl = new NhomNguoiDungCtrl();
        public frmPhanQuyen()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colMaNV);
            m_NhomNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaNhomNguoiDung);
            m_PhanQuyenCtrl.HienThi(DGVDPhanQuyen, BindingNavigatorPhanQuyen);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVDPhanQuyen.RowCount == 0)
                BindingNavigatorPhanQuyen.Enabled = true;
            DataRow m_Row = m_PhanQuyenCtrl.ThemDongMoi();
            m_Row["MaQuyen"] = "";
            m_Row["MaNhomNguoiDung"] = "";
            m_Row["MaNV"] = "";
            m_Row["MatKhau"] = "";
            m_Row["TenDangNhap"] = "";
            m_PhanQuyenCtrl.ThemPhanQuyen(m_Row);
            BindingNavigatorPhanQuyen.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVDPhanQuyen.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaQuyen") == true &&
                KiemTraTruocKhiLuu("colMaNhomNguoiDung") == true &&
                KiemTraTruocKhiLuu("colMaNV") == true &&
                KiemTraTruocKhiLuu("colMatKhau") == true &&
                KiemTraTruocKhiLuu("colTenDangNhap") == true)
            bindingNavigatorPositionItem.Focus();
            m_PhanQuyenCtrl.LuuPhanQuyen();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVDPhanQuyen.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorPhanQuyen.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}