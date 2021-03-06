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

using System.Diagnostics;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmNhomNguoiDung : Office2007Form
    {
        NhomNguoiDungCtrl m_NhomNguoiDungCtrl = new NhomNguoiDungCtrl();
        public frmNhomNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            
            m_NhomNguoiDungCtrl.HienThi(DGVNhomNguoDung, BindingNavigatorNhomNguoDung);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVNhomNguoDung.RowCount == 0)
                BindingNavigatorNhomNguoDung.Enabled = true;
            DataRow m_Row = m_NhomNguoiDungCtrl.ThemDongMoi();
            m_Row["MaNhomNguoiDung"] = "";
            m_Row["TenNhomNguoiDung"] = "";
            m_NhomNguoiDungCtrl.ThemMoi(m_Row);
            BindingNavigatorNhomNguoDung.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVNhomNguoDung.Rows)
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
            if(KiemTraTruocKhiLuu("colMaNhomNguoiDung") == true && 
                KiemTraTruocKhiLuu("colTenNhomNguoiDung") == true)
            bindingNavigatorPositionItem.Focus();
        m_NhomNguoiDungCtrl.LuuNguoiDung();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVNhomNguoDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorNhomNguoDung.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}