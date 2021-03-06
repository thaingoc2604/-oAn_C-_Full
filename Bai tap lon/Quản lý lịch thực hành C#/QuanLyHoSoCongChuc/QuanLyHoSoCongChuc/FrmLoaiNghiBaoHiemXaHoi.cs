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
    public partial class FrmLoaiNghiBaoHiemXaHoi : Office2007Form
    {
        public FrmLoaiNghiBaoHiemXaHoi()
        {
            InitializeComponent();
        }

        LoaiNghiBaoHiemXaHoiControl m_LoaiNghiBaoHiemXaHoiConTrol = new LoaiNghiBaoHiemXaHoiControl();

        private void FrmLoaiNghiBaoHiemXaHoi_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_LoaiNghiBaoHiemXaHoiConTrol.HienThi(DGVLoaiNghiBaoHiemXaHoi, bindingNavigatorLoaiNghiBaoHiemXaHoi, txtMaLoaiNghiBaoHiemXaHoi, txtTenLoaiNghiBaoHiemXaHoi);
       
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaLoaiNghiBaoHiemXaHoi.Enabled = val;
            txtTenLoaiNghiBaoHiemXaHoi.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVLoaiNghiBaoHiemXaHoi.Enabled = val;
        }        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_LoaiNghiBaoHiemXaHoiConTrol.ThemDongMoi();
            m_Row["MaLoaiNghiBaoHiemXaHoi"] = "";
            m_Row["TenLoaiNghiBaoHiemXaHoi"] = "";
            m_LoaiNghiBaoHiemXaHoiConTrol.ThemLoaiNghiBaoHiemXaHoi(m_Row);
            bindingNavigatorLoaiNghiBaoHiemXaHoi.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiNghiBaoHiemXaHoi.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorLoaiNghiBaoHiemXaHoi.BindingSource.MoveNext();
      
            m_LoaiNghiBaoHiemXaHoiConTrol.LuuLoaiNghiBaoHiemXaHoi();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}