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
    public partial class FrmHinhThucTuyenDung : Office2007Form
    {
        public FrmHinhThucTuyenDung()
        {
            InitializeComponent();
        }

        HinhThucTuyenDungControl m_HinhThucTuyenDungConTrol = new HinhThucTuyenDungControl();       
        private void FrmHinhThucTuyenDung_Load_1(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_HinhThucTuyenDungConTrol.HienThi(DGVHinhThucTuyenDung, bindingNavigatorHinhThucTuyenDung, txtMaHinhThucTuyenDung, txtTenHinhThucTuyenDung);
            // m_HinhThucTuyenDungCtrl.HienThi(dGVHinhThucTuyenDung, bindingNavigatorHinhThucTuyenDung, txtMaHinhThucTuyenDung, txtTenHinhThucTuyenDung, numPC);
            this.Allow(false);
        }

        void Allow(bool val)
        {
            txtMaHinhThucTuyenDung.Enabled = val;
            txtTenHinhThucTuyenDung.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVHinhThucTuyenDung.Enabled = val;
        }

      
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HinhThucTuyenDungConTrol.ThemDongMoi();
            m_Row["MaHinhThucTuyenDung"] = "";
            m_Row["TenHinhThucTuyenDung"] = "";
            //m_Row["PhuCap"] = 0;
            m_HinhThucTuyenDungConTrol.ThemHinhThucTuyenDung(m_Row);
            bindingNavigatorHinhThucTuyenDung.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHinhThucTuyenDung.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {

            bindingNavigatorHinhThucTuyenDung.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_HinhThucTuyenDungConTrol.LuuHinhThucTuyenDung();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}