using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLIKH.Controller;

namespace QUANLIKH.GiaoDien
{
    public partial class frmThuAnChi : Office2007Form
    {
        public frmThuAnChi()
        {
            InitializeComponent();
        }
        NhanVienControl nvctrl = new NhanVienControl();
        DaiLyControl dlctrl = new DaiLyControl();
        QuyenSoControl qsctrl = new QuyenSoControl();
        private void frmThuAnChi_Load(object sender, EventArgs e)
        {
            nvctrl.HienThiLenComboBox(cmbChonNhanVien);
            dlctrl.HienThiLenComboBox(cmbChonDaiLy);
            qsctrl.HienThiLenComboBox(cmbChonQuyenSo);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ChiTietGiayChungNhanControl anchictrl = new ChiTietGiayChungNhanControl();

        private void cmbChonNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dlctrl.HienThiLenComboBox(cmbChonDaiLy, cmbChonNhanVien.SelectedValue.ToString());
        }

        private void cmbChonDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbChonDaiLy.SelectedValue != null)
                qsctrl.HienThiLenComboBox(cmbChonQuyenSo, cmbChonDaiLy.SelectedValue.ToString());
        }

        private void cmbChonQuyenSo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbChonQuyenSo.SelectedValue != null)
                anchictrl.HienThiChonTheoQuyen(dgv, bn, cmbChonQuyenSo);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            anchictrl.CapNhat();
        }
        //private void cmbChonNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    anchictrl.HienThi(dgv,bn,cmbDai
        //}
    }
}