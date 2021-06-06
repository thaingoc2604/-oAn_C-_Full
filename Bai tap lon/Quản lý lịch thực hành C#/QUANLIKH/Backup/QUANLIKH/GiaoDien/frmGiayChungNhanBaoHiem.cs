using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;

namespace QUANLIKH.GiaoDien
{
    public partial class frmGiayChungNhanBaoHiem : Office2007Form
    {
        public frmGiayChungNhanBaoHiem()
        {
            InitializeComponent();
        }
        ChiTietGiayChungNhanControl anchictrl = new ChiTietGiayChungNhanControl();
        MucBaoHiemControl bhctrl = new MucBaoHiemControl();
        KhachHangControl khctrl = new KhachHangControl();
        TinhTrangGiayChungNhanControl ttctrl = new TinhTrangGiayChungNhanControl();
        QuyenSoControl qsctrl = new QuyenSoControl();
        MucBaoHiemControl phictrl = new MucBaoHiemControl();
              

        private void frmGiayChungNhanBaoHiem_Load(object sender, EventArgs e)
        {
            khctrl.HienThiLenComboBox(cmbMaKhachHang);
            ttctrl.HienThiLenComboBox(cmbMaTinhTrang);
            qsctrl.HienThiLenComboBox(cmbMaQuyen);
            
            //phiTNDSctrl.HienThiDataDridViewComboBoxComlumnTNDS(MALOAITNDS);
            //phiTNNNctrl.HienThiDataDridViewComboBoxComlumnTNNN(MALOAITNNN);
            //phiTNDSctrl.LoadComboBoxColumnPhiTNDS(MALOAITNDS);
            //phiTNNNctrl.LoadComboBoxColumnPhiTNNN(MALOAITNNN);
            anchictrl.HienThi(checkBox1,dgv, bn, txtSoSeri, cmbMaKhachHang, dtNgayCap, cmbMaQuyen, dtNgayBatDau, dtNgayHetHan, cmbMaTinhTrang, txtLyDoHuy, dtNgayHuy, txtThueVat,txtChuaThue,txtThanhToan);
         //   bn.BindingSource.CurrentChanged += new EventHandler(BindingSource_CurrentChanged);
            

        }

        //void BindingSource_CurrentChanged(object sender, EventArgs e)
        //{
        //    int i = 0;
        //}

       

        //void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        //{

        //    long chuathue = 0;
        //    try
        //    {
        //        chuathue = Convert.ToInt64(txtChuaThue.Text);
        //    }
        //    catch { }
        //     if (e.NewValue == CheckState.Checked)
        //        {
        //            long so = Convert.ToInt64(listView1.Items[e.Index].Text);
        //            chuathue += so;
        //        }
        //        else
        //        {
        //            long so = Convert.ToInt64(listView1.Items[e.Index].Text);
        //            chuathue -= so;
        //        }

        //        txtChuaThue.Text = chuathue.ToString();
           
        //}

        private void Luu_Click(object sender, EventArgs e)
        {

            anchictrl.CapNhat();
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        
    }
}