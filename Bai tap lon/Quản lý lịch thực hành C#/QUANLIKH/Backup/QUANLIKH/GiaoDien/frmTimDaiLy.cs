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
    public partial class frmTimDaiLy : Office2007Form
    {
        public frmTimDaiLy()
        {
            InitializeComponent();
        }
        NhanVienControl nvctrl = new NhanVienControl();
        private void frmTimDaiLy_Load(object sender, EventArgs e)
        {
            nvctrl.HienThiLenComboBox(cmbNVQL);
            cmbChonMaNVQL.SelectedIndex = 0;
            cmbChonDiaChi.SelectedIndex = 0;
        }

        private void cmbChonMaNVQL_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbChonMaNVQL.SelectedIndex != 0)
                cmbNVQL.Enabled = true;
            else
                cmbNVQL.Enabled = false;
        }

        private void cmbChonDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonDiaChi.SelectedIndex == 0)
                txtDiaChi.Enabled = false;
            else
                txtDiaChi.Enabled = true;
        }
        DaiLyControl dlctrl = new DaiLyControl();
        private void buttontimkh_Click(object sender, EventArgs e)
        {
            dlctrl.TimDaiLy(dgv, bindingNavigatorTimKiemDaiLy, txtHoTenDaiLy, cmbChonMaNVQL, cmbNVQL, cmbChonDiaChi, txtDiaChi);
        }

    }
}