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
    public partial class FrmTrinhDoChinhTri : Office2007Form
    {
        public FrmTrinhDoChinhTri()
        {
            InitializeComponent();
        }

        TrinhDoChinhTriControl m_TrinhDoChinhTriConTrol = new TrinhDoChinhTriControl();

        private void FrmTrinhDoChinhTri_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_TrinhDoChinhTriConTrol.HienThi(DGVTrinhDoChinhTri, bindingNavigatorTrinhDoChinhTri, txtMaTrinhDoChinhTri, txtTenTrinhDoChinhTri);
            // m_TrinhDoChinhTriCtrl.HienThi(dGVTrinhDoChinhTri, bindingNavigatorTrinhDoChinhTri, txtMaTrinhDoChinhTri, txtTenTrinhDoChinhTri, numPC);
            this.Allow(false);
        }
        void Allow(bool val)
        {
            txtMaTrinhDoChinhTri.Enabled = val;
            txtTenTrinhDoChinhTri.Enabled = val;
            // toolStripLuu.Enabled = val;
            // toolStripXoa.Enabled = val;
            //DGVTrinhDoChinhTri.Enabled = val;
        }

        //
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoChinhTriConTrol.ThemDongMoi();
            m_Row["MaTrinhDoChinhTri"] = "";
            m_Row["TenTrinhDoChinhTri"] = "";
            //m_Row["PhuCap"] = 0;
            m_TrinhDoChinhTriConTrol.ThemTrinhDoChinhTri(m_Row);
            bindingNavigatorTrinhDoChinhTri.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoChinhTri.BindingSource.RemoveCurrent();
            }           
        }

        private void toolStripSua_Click_1(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click_1(object sender, EventArgs e)
        {
            bindingNavigatorTrinhDoChinhTri.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_TrinhDoChinhTriConTrol.LuuTrinhDoChinhTri();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }    


    }
}