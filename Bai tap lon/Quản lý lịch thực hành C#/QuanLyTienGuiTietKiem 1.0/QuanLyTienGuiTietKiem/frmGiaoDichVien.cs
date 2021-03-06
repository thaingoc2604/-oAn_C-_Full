using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmGiaoDichVien : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        GiaoDichVienCtrl m_gdvctrl = new GiaoDichVienCtrl();
        GiaoDichVienData m_GiaoDichVienData = new GiaoDichVienData();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();

        public frmGiaoDichVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmGiaoDichVien_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colMaNV);

            m_gdvctrl.HienThi(DGVGiaoDichVien, BindingNavigatorGiaoDichVien, txtMaNV, txtHanmucthu, txtHanmucchi, txtMuctonquy);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVGiaoDichVien.RowCount == 0)
                BindingNavigatorGiaoDichVien.Enabled = true;
            DataRow m_Row = m_gdvctrl.ThemDongMoi();

            m_Row["MaNV"] = "";
            m_Row["HanMucThu"] = 0;
            m_Row["HanMucChi"] = 0;
            m_Row["HanMucTonQuy"] = 0;

            m_gdvctrl.ThemMoi(m_Row);
            BindingNavigatorGiaoDichVien.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVGiaoDichVien.Rows)
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

        public void KiemTraLuuGDV()
        {
            //IEnumerator ie= DGVGiaoDichVien.SelectedColumns.GetEnumerator();
            //while(ie.MoveNext())
            //{
            //    DataGridView oldItem = m_gdvctrl;
            //    DataGridView newItem = new DataGridView();

            //    bool state = false; 

            //    DataTable dT = new DataTable();
            //    foreach (DataRow row in dT.Rows)
            //    {
            //        if (oldItem.SelectedRows[0].ToString() == row["MaNV"].ToString())
            //        {
            //            MessageBoxEx.Show("Nhan vien " + row["MaNV"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            state = true;
            //            goto Cont;
            //        }
            //    }
            //}
        }

        public Boolean KiemTraTrungNV()
        {
            foreach (DataGridViewRow row in DGVGiaoDichVien.Rows)
            {
                DataTable oldItem = m_GiaoDichVienData.GetGiaoDichVien();
                DataTable newItem = new DataTable();

                if (newItem.Rows[0]["MaNV"].ToString() == oldItem.Rows[0]["MaNV"].ToString())
                {
                    MessageBoxEx.Show("Nhan vien " + oldItem.Rows[0]["MaNV"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (KiemTraTruocKhiLuu("colMaNV") == true)
            {
                KiemTraTrungNV();         
                bindingNavigatorPositionItem.Focus();
                m_gdvctrl.LuuGiaoDichVien();
            }
            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVGiaoDichVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorGiaoDichVien.BindingSource.RemoveCurrent();
                }
        }


        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}