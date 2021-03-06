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
    public partial class frmSoDuTietKiem : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        SoDuTietKiemCtrl m_SoDuTietKiemCtrl = new SoDuTietKiemCtrl();
        LoaiTietKiemCtrl m_LoaiTietKiemCtrl = new LoaiTietKiemCtrl();

        public frmSoDuTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmSoDuTietKiem_Load(object sender, EventArgs e)
        {
            m_LoaiTietKiemCtrl.HienThiDataGridViewComboBoxColumn(colMaLoaiTietKiem);

            m_SoDuTietKiemCtrl.HienThi(DGVSoDuTietKiem, BindingNavigatorSoDuTietKiem);
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVSoDuTietKiem.RowCount == 0)
                BindingNavigatorSoDuTietKiem.Enabled = true;
            DataRow m_Row = m_SoDuTietKiemCtrl.ThemDongMoi();
            m_Row["MaSoTietKiem"] = "";
            m_Row["MaLoaiTietKiem"] = "";
            m_Row["SoDu"] = 0;
            m_Row["NgayCapNhat"] = DateTime.Today;
            
            
            m_SoDuTietKiemCtrl.ThemMoi(m_Row);
            BindingNavigatorSoDuTietKiem.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVSoDuTietKiem.Rows)
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

            if (KiemTraTruocKhiLuu("colMaLoaiTietKiem") == true &&
                KiemTraTruocKhiLuu("colMaSoTietKiem") == true &&
                KiemTraTruocKhiLuu("colNgayCapNhat") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_SoDuTietKiemCtrl.LuuSoDuTietKiem();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVSoDuTietKiem.RowCount == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorSoDuTietKiem.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}