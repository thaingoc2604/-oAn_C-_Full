using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmDienUuTienGiaDinh : Office2007Form
    {
        public FrmDienUuTienGiaDinh()
        {
            InitializeComponent();
        }

        DienUuTienGiaDinhControl m_DienUuTienGiaDinhConTrol = new DienUuTienGiaDinhControl();

        private void FrmDienUuTienGiaDinh_Load_1(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_DienUuTienGiaDinhConTrol.HienThi(DGVDienUuTienGiaDinh, bindingNavigatorDienUuTienGiaDinh, txtMaDienUuTienGiaDinh, txtTenDienUuTienGiaDinh);
            // m_DienUuTienGiaDinhCtrl.HienThi(dGVDienUuTienGiaDinh, bindingNavigatorDienUuTienGiaDinh, txtMaDienUuTienGiaDinh, txtTenDienUuTienGiaDinh, numPC);
            this.Allow(false);
        }  
        void Allow(bool val)
        {
            txtMaDienUuTienGiaDinh.Enabled = val;
            txtTenDienUuTienGiaDinh.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVDienUuTienGiaDinh.Enabled = val;
        }
        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DienUuTienGiaDinhConTrol.ThemDongMoi();
            m_Row["MaDienUuTienGiaDinh"] = "";
            m_Row["TenDienUuTienGiaDinh"] = "";
            //m_Row["PhuCap"] = 0;
            m_DienUuTienGiaDinhConTrol.ThemDienUuTienGiaDinh(m_Row);
            bindingNavigatorDienUuTienGiaDinh.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDienUuTienGiaDinh.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorDienUuTienGiaDinh.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_DienUuTienGiaDinhConTrol.LuuDienUuTienGiaDinh();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}