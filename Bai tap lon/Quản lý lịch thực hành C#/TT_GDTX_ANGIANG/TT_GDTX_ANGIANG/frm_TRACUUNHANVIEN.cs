using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.Controller;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_TRACUUNHANVIEN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_TRACUUNHANVIEN()
        {
            InitializeComponent();
        }

        #region frm_TRACUUNHANVIEN_Load   
        #region ctrlNhanVien
        private NhanVienCtrl m_ctrlNhanVien;
        public NhanVienCtrl ctrlNhanVien
        {
            get { return m_ctrlNhanVien; }
            set { m_ctrlNhanVien = value; }
        }
          #endregion
       
        private void frm_TRACUUNHANVIEN_Load(object sender, EventArgs e)
        {
            this.cboChonHoTen.Text = "NONE";
            this.cboChonNamSinh.Text = "NONE";
            this.cboChonCMND.Text = "NONE";
            this.cboChonQueQuan.Text = "NONE";
            this.cboChon_GIOITINH.Text = "NONE";
            this.cboChon_HOCVAN.Text = "NONE";
            this.cboChon_TINHOC.Text = "NONE";
            this.cboChon_NGOAINGU.Text = "NONE";
            this.cboGIOITINH.SelectedText = "Nam";
            this.cboChon.Text = "Nhân Sự";


            #region HienThi Combobox

            PhongBanCtrl ctrlPhongBan = new PhongBanCtrl();
            ctrlPhongBan.HienThiComboBox(this.cboPHONGBAN);



            TrinhDo_HocVanCtrl ctrlHocVan = new TrinhDo_HocVanCtrl();
            ctrlHocVan.HienThiComboBox(this.cboHOCVAN);

            TrinhDo_TinHocCtrl ctrlTinHoc = new TrinhDo_TinHocCtrl();
            ctrlTinHoc.HienThiComboBox(this.cboTINHOC);

            NgoaiNguCtrl ctrlNgoaiNgu = new NgoaiNguCtrl();
            ctrlNgoaiNgu.HienThiComboBox(this.cboNGOAINGU);

            TrinhDo_NgoaiNguCtrl ctrlTDNgoaiNgu = new TrinhDo_NgoaiNguCtrl();
            ctrlTDNgoaiNgu.HienThiComboBox(this.cboTD_NGOAINGU);




            #endregion
        }
        #endregion
        #region TimKiem_toolStripButton_Click        
      
        private void TimKiem_toolStripButton_Click(object sender, EventArgs e)
        {

            int m_trangthai = 1;
            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();

            int m_gioitinh;
            if (cboGIOITINH.Text == "Nam")
            {
                m_gioitinh = 1;
            }
            else
            {
                m_gioitinh = 0;
            }
            if (cboChon.Text == "Nhân Sự")
            {
                m_trangthai = 1; //Dang la nhan vien
            }
            else
            {
                m_trangthai = 0; //Xin Thoi viec hay Cham dut Hop dong lao fong
            } 

            ctrlNhanVien.TraCuu_NhanVien(cboPHONGBAN, m_trangthai, cboChonHoTen, txtTenNV, cboChonCMND,txtCMND, cboChon_GIOITINH, m_gioitinh, cboChon_HOCVAN, cboHOCVAN, cboChon_TINHOC, cboTINHOC, cboChon_NGOAINGU, cboNGOAINGU, cboTD_NGOAINGU, dataGridViewX1);
                this.MauTin_toolStripTextBox.Text = ctrlNhanVien.MauTin.ToString();
           


           
        }
        #endregion

        #region Thoat_toolStripButton_Click        
       
        private void Thoat_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void checkBoxX7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxX6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxX5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChonGioiTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxX4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}