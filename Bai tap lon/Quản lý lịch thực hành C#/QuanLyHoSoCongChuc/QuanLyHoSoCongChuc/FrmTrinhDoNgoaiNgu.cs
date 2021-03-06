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
    public partial class FrmTrinhDoNgoaiNgu : Office2007Form
    {
        public FrmTrinhDoNgoaiNgu()
        {
            InitializeComponent();
        }

        TrinhDoNgoaiNguControl m_TrinhDoNgoaiNguConTrol = new TrinhDoNgoaiNguControl();

        private void FrmTrinhDoNgoaiNgu_Load_2(object sender, EventArgs e)
        {
            DataService.OpenConnection();
           
            m_TrinhDoNgoaiNguConTrol.HienThi(DGVTrinhDoNgoaiNgu, bindingNavigatorTrinhDoNgoaiNgu, txtMaTrinhDoNgoaiNgu, txtTenTrinhDoNgoaiNgu);
          
            this.Allow(false);
        }
        
        void Allow(bool val)
        {
            txtMaTrinhDoNgoaiNgu.Enabled = val;
            txtTenTrinhDoNgoaiNgu.Enabled = val;
             toolStripLuu.Enabled = val;
             bindingNavigatorDeleteItem.Enabled = val;
            DGVTrinhDoNgoaiNgu.Enabled = val;
        }

        //
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_TrinhDoNgoaiNguConTrol.ThemDongMoi();
            m_Row["MaTrinhDoNgoaiNgu"] = "";
            m_Row["TenTrinhDoNgoaiNgu"] = "";
            //m_Row["PhuCap"] = 0;
            m_TrinhDoNgoaiNguConTrol.ThemTrinhDoNgoaiNgu(m_Row);
            bindingNavigatorTrinhDoNgoaiNgu.BindingSource.MoveLast();
            this.Allow(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTrinhDoNgoaiNgu.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            this.Allow(true);
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorTrinhDoNgoaiNgu.BindingSource.MoveNext();
            //bindingNavigatorPositionItem.Focus();
            m_TrinhDoNgoaiNguConTrol.LuuTrinhDoNgoaiNgu();
            MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}