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
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Report;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmSoTietKiem : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        LoaiTietKiemCtrl m_LoaiTietKiemCtrl = new LoaiTietKiemCtrl();

        SoDuTietKiemCtrl m_SoDuTietKiemCtrl = new SoDuTietKiemCtrl();
        PhatSinhTietKiemCtrl m_PhatSinhTietKiemCtrl = new PhatSinhTietKiemCtrl();
        ChiTietPhatSinhGDCtrl m_ChiTietPhatSinhGDCtrl = new ChiTietPhatSinhGDCtrl();

        InPhieuThuCtrl m_InPhieuThuCtrl = new InPhieuThuCtrl();

        public frmSoTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmMoSoTietKiem_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThiComboBox(cmbMaKH);
            m_LoaiTietKiemCtrl.HienThiComboBox(cmbMaLoaiTietKiem);

            m_SoTietKiemCtrl.HienThi(DGVSoTietKiem, BindingNavigatorSoTietKiem, txtMaSoTietKiem, cmbMaLoaiTietKiem, cmbMaKH, dtNgayMoSo, dtNgayHieuLuc, dtNgayDenHan, dtNgayTinhLai, dtNgayTaiKiGui,
                                      txtLaiDaTra, txtLaiNhapVon, dtNgayNhapVon,txtPhongToa, cbPhongToa, dtNgayTatToan);  
        }
        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_KhachHangCtrl.HienThiComboBox(cmbMaKH);
            m_LoaiTietKiemCtrl.HienThiComboBox(cmbMaLoaiTietKiem);

            m_SoTietKiemCtrl.HienThi(DGVSoTietKiem, BindingNavigatorSoTietKiem, txtMaSoTietKiem, cmbMaLoaiTietKiem, cmbMaKH, dtNgayMoSo, dtNgayHieuLuc, dtNgayDenHan, dtNgayTinhLai, dtNgayTaiKiGui,
                                      txtLaiDaTra, txtLaiNhapVon, dtNgayNhapVon, txtPhongToa, cbPhongToa, dtNgayTatToan);  
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGVSoTietKiem.Rows[DGVSoTietKiem.Rows.Count - 1];
            string chuoi = row.Cells["colMaSoTietKiem"].Value.ToString();
            string so = chuoi.Substring(3, 6);

            int maso = Convert.ToInt32(so);
            //LoadMain.HienThiMoSoTietKiem(maso);
            //if (DGVSoTietKiem.RowCount == 0)
            //    BindingNavigatorSoTietKiem.Enabled = true;
            //DataRow m_Row = m_SoTietKiemCtrl.ThemDongMoi();
            //m_Row["MaLoaiTietKiem"] = "";
            //m_Row["MaSoTietKiem"] = "";
            //m_Row["NgayMoSo"] = DateTime.Today;
            //m_Row["NgayHieuLuc"] = DateTime.Today;
            //m_Row["NgayDenHan"] = DateTime.Today;
            //m_Row["NgayTinhLaiGanNhat"] = DateTime.Today;
            //m_Row["NgayTaiKyGui"] = DateTime.Today;
            //m_Row["NgayNhapVon"] = DateTime.Today;
            //m_Row["LaiDaTra"] = 0;
            //m_Row["LaiNhapVon"] = 0;
            //m_Row["PhongToa"] = false;
            //m_Row["NgayTatToan"] = DateTime.Today;
            //m_Row["MaKH"] = "";            
            //m_SoTietKiemCtrl.ThemMoi(m_Row);
            //BindingNavigatorSoTietKiem.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVSoTietKiem.Rows)
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

            if (KiemTraTruocKhiLuu("colMaKH") == true &&
                KiemTraTruocKhiLuu("colMaLoaiTietKiem") == true &&
                KiemTraTruocKhiLuu("colMaSoTietKiem") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_SoTietKiemCtrl.LuuSoTietKiem();
            }

            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVSoTietKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (cbPhongToa.Checked == false)
            {
                MessageBoxEx.Show("Sổ chưa tất toán!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                BindingNavigatorSoTietKiem.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        #region Tim Kiem

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemSoTietKiem();
            }
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemSoTietKiem();
            }
        }

        void TimKiemSoTietKiem()
        {
            try
            {
                if (cbMaKH.Checked == true)
                {
                    m_SoTietKiemCtrl.TimTheoTen(txtTimKiem.Text);
                }
                else
                {
                    m_SoTietKiemCtrl.TimTheoMaSo(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void DGVSoTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtPhongToa.Text == "True")
                cbPhongToa.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGVSoTietKiem.Rows[DGVSoTietKiem.Rows.Count - 1];
            //DataRowView row = (DataRowView)BindingNavigatorSoTietKiem.BindingSource.Current;
                if (row != null)
                {
                    
                    string chuoi = row.Cells["colMaSoTietKiem"].Value.ToString();
                    IList<InPhieuThuInfo> Info = InPhieuThuCtrl.LayDsSoTietKiemTheoMa(chuoi);
                    frmPhieuThu_PhieuGui PhieuThu = new frmPhieuThu_PhieuGui();
                    PhieuThu.Show();
                }
        }

        //private void bindingNavigatorPrintItem_Click(object sender, EventArgs e)
        //{
        //    DataRowView row = (DataRowView)BindingNavigatorSoTietKiem.BindingSource.Current;
        //    if (row != null)
        //    {
        //        String MaSo = row["MaSoTietKiem"].ToString();
        //        IList<InPhieuThuInfo> Info = InPhieuThuCtrl.LayDsSoTietKiemTheoMa(MaSo);
        //        frmInPhieuThu_PhieuGui PhieuThu = new frmInPhieuThu_PhieuGui();
        //        PhieuThu.Show();
        //    }
        //}

    }
}