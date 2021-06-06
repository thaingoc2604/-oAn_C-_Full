using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manager_Fortunes.PresentationLayer;

namespace Manager_Fortunes
{
    public partial class MainForm_Manager : DevComponents.DotNetBar.Office2007RibbonForm
    {
        frmDangNhap frmdangnhap = null;
        frmDoiMatKhau frmdoimatkhau = null;
        frmQuanLyNhanVien nhanvien = null;
        Thuetaisan frmtaisanthue = null;
        frmThueCongCu frmthuecongcu = null;

        frmTimKiemTaiSanThue frmtimkiemTS = null;
        frmTimKiemCongCu frmtimkiemcc = null;

        frmDiadiem frmdiadiem = null;
        frmDonvitinh frmdonvitinh = null;
        frmPhongban frmphongban = null;

        public MainForm_Manager()
        {
            InitializeComponent();
        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void HETHONG_Click(object sender, EventArgs e)
        {

        }

        private void CONGCU_Click(object sender, EventArgs e)
        {

        }

        private void BT_ADDCC_Click(object sender, EventArgs e)
        {
            frm_NhapCongCu addcongcu = new frm_NhapCongCu();
           //addcongcu.MdiParent=this;
           addcongcu.Show();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            frmThoikhauhaoTSCD thoikhtscd = new frmThoikhauhaoTSCD();
            thoikhtscd.Show();
        }

        private void BT_DN_Click(object sender, EventArgs e)
        {
            if (this.frmdangnhap == null || this.frmdangnhap.IsDisposed)
                frmdangnhap = new frmDangNhap();
           
            frmdangnhap.Show();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_PASS_Click(object sender, EventArgs e)
        {
            if(frmdoimatkhau ==null || this.frmdoimatkhau.IsDisposed)
                frmdoimatkhau = new frmDoiMatKhau();
            //frmdoimatkhau.MdiParent = this;
            frmdoimatkhau.Show();
        }

        private void BT_ADDNV_Click(object sender, EventArgs e)
        {
            if (nhanvien == null || this.nhanvien.IsDisposed)
                nhanvien = new frmQuanLyNhanVien();
            //nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            if (this.frmtaisanthue == null || this.frmtaisanthue.IsDisposed)
                frmtaisanthue = new Thuetaisan();
            //frmtaisanthue.MdiParent = this;
            frmtaisanthue.Show();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            if (this.frmthuecongcu == null || this.frmthuecongcu.IsDisposed)
                frmthuecongcu = new frmThueCongCu();
           // frmthuecongcu.MdiParent = this;
            frmthuecongcu.Show();
        }

        private void labelItem1_Click(object sender, EventArgs e)
        {
            if (this.frmtimkiemTS == null || this.frmtimkiemTS.IsDisposed)
                frmtimkiemTS = new frmTimKiemTaiSanThue();
            //frmtimkiemTS.MdiParent = this;
            frmtimkiemTS.Show();
        }

        private void labelItem2_Click(object sender, EventArgs e)
        {
            if (this.frmtimkiemcc == null || this.frmtimkiemcc.IsDisposed)
                frmtimkiemcc = new  frmTimKiemCongCu();
            //frmtimkiemcc.MdiParent = this;
            frmtimkiemcc.Show();
        }

        private void buttonItem34_Click(object sender, EventArgs e)
        {
            if (this.frmdiadiem == null || this.frmdiadiem.IsDisposed)
                frmdiadiem = new frmDiadiem();
            //frmdiadiem.MdiParent = this;
            frmdiadiem.Show();
        }

        private void buttonItem36_Click(object sender, EventArgs e)
        {
            if (this.frmdonvitinh == null || this.frmdonvitinh.IsDisposed)
                frmdonvitinh = new frmDonvitinh();
            //frmdonvitinh .MdiParent = this;
            frmdonvitinh.Show();
        }

        private void buttonItem35_Click(object sender, EventArgs e)
        {
            if (this.frmphongban== null || this.frmphongban.IsDisposed)
                frmphongban = new frmPhongban();
            //frmphongban .MdiParent = this;
            frmphongban.Show();
        }

        private void BT_UPCC_Click(object sender, EventArgs e)
        {
            frm_SuaCongCu suacongcu = new frm_SuaCongCu();
            suacongcu.Show();
        }

        private void BT_DMCC_Click(object sender, EventArgs e)
        {
            frm_DatMuaCongCu dtmua = new frm_DatMuaCongCu();
            dtmua.Show();
        }

        private void BT_LPTLCC_Click(object sender, EventArgs e)
        {
            frm_ThanhLyCongCu thanhly = new frm_ThanhLyCongCu();
            thanhly.Show();
        }

        private void BT_LPTKCC_Click(object sender, EventArgs e)
        {
            frm_ThongKe thongke = new frm_ThongKe();
            thongke.Show();
        }

        private void BT_LPXCC_Click(object sender, EventArgs e)
        {

        }

        private void BT_DCCC_Click(object sender, EventArgs e)
        {
            frm_ChuyenPhong chuyenphong = new frm_ChuyenPhong();
            chuyenphong.Show();

        }

        private void BT_XP_Click(object sender, EventArgs e)
        {
            frm_XepPhong xepphong = new frm_XepPhong();
            xepphong.Show();
        }

        private void BT_IN_Click(object sender, EventArgs e)
        {
            frm_InKiemKe inkiemke = new frm_InKiemKe();
            inkiemke.Show();
        }

        private void BT_DG_Click(object sender, EventArgs e)
        {
            frm_DanhGiaCongCu danhgia = new frm_DanhGiaCongCu();
            danhgia.Show();
        }

        private void BT_TCChung_Click(object sender, EventArgs e)
        {
            frm_TraCuuChung chung = new frm_TraCuuChung();
            chung.Show();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            frmTaisan taisan = new frmTaisan();
            taisan.Show();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            frmTaisanphantram taisan1 = new frmTaisanphantram();
            taisan1.Show();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            frmKhaibaochothanhly chotl = new frmKhaibaochothanhly();
            chotl.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {

        }

       
    }
}