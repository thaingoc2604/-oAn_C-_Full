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
    public partial class frmPhongGiaoDich : Office2007Form
    {
        PhongGiaoDichCtrl m_PhongGiaoDichCtrl = new PhongGiaoDichCtrl();
        public frmPhongGiaoDich()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhongGiaoDich_Load(object sender, EventArgs e)
        {
            m_PhongGiaoDichCtrl.HienThi(DGVPhongGiaoDich, BindingNavigatorPhongGiaoDich);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVPhongGiaoDich.RowCount == 0)
                BindingNavigatorPhongGiaoDich.Enabled = true;
            DataRow m_Row = m_PhongGiaoDichCtrl.ThemDongMoi();
            m_Row["MaPhongGiaoDich"] = "";
            m_Row["TenPhong"] = "";
            m_Row["DiaDiem"] = "";
            m_Row["DienThoai"] = "";
            m_PhongGiaoDichCtrl.ThemMoi(m_Row);
            BindingNavigatorPhongGiaoDich.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVPhongGiaoDich.Rows)
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

            if (KiemTraTruocKhiLuu("colMaPhongGiaoDich") == true &&
                KiemTraTruocKhiLuu("colTenPhong") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_PhongGiaoDichCtrl.LuuPhongGiaoDich();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVPhongGiaoDich.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorPhongGiaoDich.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_PhongGiaoDichCtrl.HienThi(DGVPhongGiaoDich, BindingNavigatorPhongGiaoDich);
            tStxtTimKiem.Text = "";
        }


        #region Tim Kiem nhan vien

        private void timTheoMaPhong_Click(object sender, EventArgs e)
        {
            timTheoMaPhong.Checked = true;
            tìmTheoTenPhong.Checked = false;
            tStxtTimKiem.Text = "";
        }

        private void tìmTheoTenPhong_Click(object sender, EventArgs e)
        {
            timTheoMaPhong.Checked = false;
            tìmTheoTenPhong.Checked = true;
            tStxtTimKiem.Text = "";
        }

        private void tStxtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemPhongGiaoDich();
            }
        }

        private void tStxtTimKiem_Enter(object sender, EventArgs e)
        {
            tStxtTimKiem.Text = "";
            tStxtTimKiem.ForeColor = Color.Black;
        }

        private void tStxtTimKiem_Leave(object sender, EventArgs e)
        {
            TimKiemPhongGiaoDich();
        }

        void TimKiemPhongGiaoDich()
        {
            if (timTheoMaPhong.Checked == true)
            {
                m_PhongGiaoDichCtrl.TiemKiemTheoMaPhongGD(tStxtTimKiem.Text);
            }
            else
            {
                m_PhongGiaoDichCtrl.TiemKiemTheoTenPhongGD(tStxtTimKiem.Text);
            }
        }
        #endregion

    }
}