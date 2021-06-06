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
    public partial class frmTimKiemHopDongDaiLy : Office2007Form
    {
        public frmTimKiemHopDongDaiLy()
        {
            InitializeComponent();
        }
        DaiLyControl dlctrl = new DaiLyControl();
        private void frmTimKiemHopDongDaiLy_Load(object sender, EventArgs e)
        {
           
          dlctrl.HienThiLenComboBox(cmbDaiLy);
           
            cmbChonDaiLy.SelectedIndex = 0;
        }
        HopDongControl hd = new HopDongControl();
        private void buttontimkh_Click(object sender, EventArgs e)
        {

            hd.TimHopDong(dgv, bindingNavigatorKhachHang, txtSoHopDong, cmbChonDaiLy, cmbDaiLy);
        }

        private void cmbChonDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonDaiLy.SelectedIndex != 0)
                cmbDaiLy.Enabled = true;
            else
                cmbDaiLy.Enabled = false;
        }

     
       
        

      
    }
}