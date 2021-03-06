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
    public partial class FrmThanhPhanXuatThan : Office2007Form
    {
        public FrmThanhPhanXuatThan()
        {
            InitializeComponent();
        }

        ThanhPhanXuatThanControl m_ThanhPhanXuatThanConTrol = new ThanhPhanXuatThanControl();

        private void FrmThanhPhanXuatThan_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_ThanhPhanXuatThanConTrol.HienThi(DGVThanhPhanXuatThan, bindingNavigatorThanhPhanXuatThan, txtMaThanhPhanXuatThan, txtTenThanhPhanXuatThan);
            // m_ThanhPhanXuatThanCtrl.HienThi(dGVThanhPhanXuatThan, bindingNavigatorThanhPhanXuatThan, txtMaThanhPhanXuatThan, txtTenThanhPhanXuatThan, numPC);
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaThanhPhanXuatThan.Enabled = val;
            txtTenThanhPhanXuatThan.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVThanhPhanXuatThan.Enabled = val;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_ThanhPhanXuatThanConTrol.ThemDongMoi();
            m_Row["MaThanhPhanXuatThan"] = "";
            m_Row["TenThanhPhanXuatThan"] = "";
            //m_Row["PhuCap"] = 0;
            m_ThanhPhanXuatThanConTrol.ThemThanhPhanXuatThan(m_Row);
            bindingNavigatorThanhPhanXuatThan.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorThanhPhanXuatThan.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSuu_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorThanhPhanXuatThan.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            ////m_ThanhPhanXuatThanConTrol.

            m_ThanhPhanXuatThanConTrol.LuuThanhPhanXuatThan();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
   }
    }