using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using System.Data.SqlClient;
using QuanLyHoSoCongChuc.Report;

namespace QuanLyHoSoCongChuc
{
     public partial class FrmMain : Office2007Form
    {
         public FrmMain()
        {
          
            InitializeComponent();
        }
         FrmDoiMatKhau m_FrmDoiMatKhau = null;
         NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
         FrmNhanVien ttNhanVien = null;
         FrmQuanLyDonVi ttDonVi = null;
         FrmThanNhan ttThanNhan = null;
         FrmTKNhanVien ttTKNhanVien = null;
         FrmQuaTrinhDaoTao ttQTDT = null;
         FrmThongTinLienHe ttTTLH = null;
         FrmQuaTrinhBoiDuong ttQTBD = null;
         FrmQuaTrinhCongTac ttQTCT = null;        
         FrmDanhSachNangLuong ttLuong = null;
         FrmKhenThuong ttKhenThuong = null;
         FrmKyLuat ttKyLuat = null;
         frmKetNoiCSDL m_Connection = null;
         FrmDangNhap m_FrmDangNhap = new FrmDangNhap();
         FrmReportNhanVien dSNhanVien = new FrmReportNhanVien();
         FrmDSDonVi dSDonVi = new FrmDSDonVi();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (DataService.OpenConnection())
            {
                Disable();
            }
            else
            {
                KetNoi();
            }
           
        }

         //Phan quyen
         private void PhanQuyen(int authority)
         {
             switch(authority)
             {
                 case 2:
                     EnableUser();
                     break;
                 case 1:
                     EnableAdmin();
                     break;
                 default:
                     break;
             }
         }

         //Dang nhap
         private void ebtnDangNhap_Click(object sender, EventArgs e)
         {
             DataService.OpenConnection();
             this.WindowState = FormWindowState.Maximized;
             //FrmDangNhap m_FrmDangNhap = new FrmDangNhap();
             if (m_FrmDangNhap.ShowDialog() == DialogResult.OK)
             {

                 String username = m_FrmDangNhap.txtUsername.Text;
                 String password = m_FrmDangNhap.txtPassword.Text;
                 NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
                 int ketqua = m_NguoiDungCtrl.DangNhap(username, password);
                 switch (ketqua)
                 {
                     case 0:
                         MessageBox.Show("Người dùng này chưa có trong hệ thống", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         Disable();

                         break;
                     case 1:
                         MessageBox.Show("Bạn đã nhập sai mật khẩu", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         Disable();

                         break;
                     case 2:
                         MessageBoxEx.Show("Chào bạn  " + staticClass.nguoidungStatic.TenNguoiDung + "  vào hệ thống !");
                         lblTenNguoiDung.Text = staticClass.nguoidungStatic.TenNguoiDung;
                         PhanQuyen(staticClass.nguoidungStatic.MaQuyen);
                         break;
                 }
             }
         }
           //
         private void Disable()
         {
             ToolStripMenuItemDangNhap.Enabled = true;
             ebtnDangNhap.Enabled = true;
             ebtnBoiDuong.Enabled = false;
             ebtnCongTac.Enabled = false;
             ebtnDaoTao.Enabled = false;
             ebtnKhenThuong.Enabled = false;
             ebtnKyLuat.Enabled = false;
             MeNuHienThi.Enabled = false;
             btnQuaTrinhCongTac.Enabled = false;
             btnQuaTrinhBoiDuong.Enabled = false;
             //MenuDanhMuc.Enabled = false;
             MenuNghiepVu.Enabled = false;
             MenuBaoCaoThongKe.Enabled = false;
             MenuCongCu.Enabled = false;
             //MenuCuaSo.Enabled = false;
             MenuTroGiup.Enabled = false;
             //            
             ToolStripMenuItemDangXuat.Enabled = false;
             ToolStripMenuItemDoiMatKhau.Enabled = false;
             ToolStripMenuItemThongTinPhongNoiVu.Enabled = false;
             //
             btnCongTac.Enabled = false;
             btnNangLuong.Enabled = false;
             ttNhanVientoolStripButton.Enabled = false;
             btnPhongBan.Enabled = false;
             btnThanNhan.Enabled = false;
             //
             ebtnDangXuat.Enabled = false;
             ebtnDoiMatKhau.Enabled = false;
             ebtnBaoCaoLuong.Enabled = false;
             ebtnDaoTao.Enabled = false;
             ebtnDanhSachNhanVien.Enabled = false;
             ebtnDanhSachPhongBan.Enabled = false;
             ebtnNangLuong.Enabled = false;
             ebtnNhanVien.Enabled = false;
             ebtnPhongBan.Enabled = false;
             ebtnThanNhan.Enabled = false;          
         }

         private void EnableAdmin()
         {
             ToolStripMenuItemDangNhap.Enabled = false;
             ebtnDangNhap.Enabled = false;
             MeNuHienThi.Enabled = true;
             btnQuaTrinhCongTac.Enabled = true;
             btnQuaTrinhBoiDuong.Enabled = true;
             ebtnBoiDuong.Enabled = true;
             ebtnCongTac.Enabled = true;
             ebtnDaoTao.Enabled = true;
             ebtnKhenThuong.Enabled = true;
             ebtnKyLuat.Enabled = true;
             //MenuDanhMuc.Enabled = true;
             MenuNghiepVu.Enabled = true;
             MenuBaoCaoThongKe.Enabled = true;
             MenuCongCu.Enabled = true;
             //MenuCuaSo.Enabled = true;
             MenuTroGiup.Enabled = true;
             //            
             ToolStripMenuItemDangXuat.Enabled = true;
             ToolStripMenuItemDoiMatKhau.Enabled = true;
             ToolStripMenuItemThongTinPhongNoiVu.Enabled = true;
             //
             btnCongTac.Enabled = true;
             btnNangLuong.Enabled = true;
             ttNhanVientoolStripButton.Enabled = true;
             btnPhongBan.Enabled = true;
             btnThanNhan.Enabled = true;
             //
             ebtnDangXuat.Enabled = true;
             ebtnDoiMatKhau.Enabled = true;
             ebtnBaoCaoLuong.Enabled = true;
             ebtnDaoTao.Enabled = true;
             ebtnDanhSachNhanVien.Enabled = true;
             ebtnDanhSachPhongBan.Enabled = true;
             ebtnNangLuong.Enabled = true;
             ebtnNhanVien.Enabled = true;
             ebtnPhongBan.Enabled = true;
             ebtnThanNhan.Enabled = true;  
         }

         private void EnableUser()
         {
           
         }
         private void toolDoiMatKhau_Click(object sender, EventArgs e)
         {
             DataService.OpenConnection();
             if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
                 m_FrmDoiMatKhau = new FrmDoiMatKhau();

             m_FrmDoiMatKhau.txtOldPassword.Text = "";
             m_FrmDoiMatKhau.txtNewPassword.Text = "";
             m_FrmDoiMatKhau.txtReNPassword.Text = "";
             m_FrmDoiMatKhau.lblOldPassError.Text = "";
             m_FrmDoiMatKhau.lblNewPassError.Text = "";
             m_FrmDoiMatKhau.lblReNPassError.Text = "";

             DoiMatKhau();
         }
         public void DoiMatKhau()
         {
         Cont:
             if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
             {
                 if (m_FrmDoiMatKhau.txtOldPassword.Text == "")
                 {
                     m_FrmDoiMatKhau.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                     m_FrmDoiMatKhau.lblNewPassError.Text = "";
                     m_FrmDoiMatKhau.lblReNPassError.Text = "";
                     goto Cont;
                 }

                 if (m_FrmDoiMatKhau.txtNewPassword.Text == "")
                 {
                     m_FrmDoiMatKhau.lblOldPassError.Text = "";
                     m_FrmDoiMatKhau.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                     m_FrmDoiMatKhau.lblReNPassError.Text = "";
                     goto Cont;
                 }

                 if (m_FrmDoiMatKhau.txtReNPassword.Text == "")
                 {
                     m_FrmDoiMatKhau.lblOldPassError.Text = "";
                     m_FrmDoiMatKhau.lblNewPassError.Text = "";
                     m_FrmDoiMatKhau.lblReNPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                     goto Cont;
                 }

                 String username = m_FrmDangNhap.txtUsername.Text;
                 String password = m_FrmDangNhap.txtPassword.Text;

                 String m_OldPassword = m_FrmDoiMatKhau.txtOldPassword.Text;
                 String m_NewPassword = m_FrmDoiMatKhau.txtNewPassword.Text;
                 String m_ReNPassword = m_FrmDoiMatKhau.txtReNPassword.Text;

                 if (password != m_OldPassword)
                 {
                     m_FrmDoiMatKhau.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                     m_FrmDoiMatKhau.lblNewPassError.Text = "";
                     m_FrmDoiMatKhau.lblReNPassError.Text = "";
                     goto Cont;
                 }
                 else if (m_NewPassword != m_ReNPassword)
                 {
                     m_FrmDoiMatKhau.lblOldPassError.Text = "";
                     m_FrmDoiMatKhau.lblNewPassError.Text = "";
                     m_FrmDoiMatKhau.lblReNPassError.Text = "Nhập xác nhận không khớp!";
                     goto Cont;
                 }
                 else
                 {
                     m_NguoiDungCtrl.ChangePassword(username, m_NewPassword);
                     MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             else
                 return;
         }
        
         //Hien thi thanh cong cu
         private void ThanhCongCuToolStripMenuItem_Click(object sender, EventArgs e)
         {
             MenuCheckThanhCongCu.Checked = !MenuCheckThanhCongCu.Checked;
             ThanhCongCu.Visible = MenuCheckThanhCongCu.Checked;
             
         }

         //Hien thi thanh trang thai
         private void MeNuThanhTrangThai_Click(object sender, EventArgs e)
         {
             MeNuCheckThanhTrangThai.Checked = !MeNuCheckThanhTrangThai.Checked;
             ThanhTrangThai.Visible = MeNuCheckThanhTrangThai.Checked;
         }
         private void thanhchucnangToolStripMenuItem_Click(object sender, EventArgs e)
         {
             thanhchucnangToolStripMenuItem.Checked = !thanhchucnangToolStripMenuItem.Checked;
             explorerBar.Visible = thanhchucnangToolStripMenuItem.Checked;
         }

         private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Bạn có muốn thoát không?", "Quản lý hồ sơ công chức!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
             {
                 this.Close();
             }
         }

         //Quan ly nhan vien

         private void ttNhanVientoolStripButton_Click(object sender, EventArgs e)
         {
             if (ttNhanVien == null || ttNhanVien.IsDisposed)
                 ttNhanVien = new FrmNhanVien();
             //ttNhanVien.Show();
             ttNhanVien.MdiParent = this;
             ttNhanVien.Show(dockPanelMain);
             this.Activate();
         }

         private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
         {

             if (ttNhanVien == null || ttNhanVien.IsDisposed)
                 ttNhanVien = new FrmNhanVien();
             ttNhanVien.MdiParent = this;
             ttNhanVien.Show(dockPanelMain);
         }

         private void tiThongTinNV_Click(object sender, EventArgs e)
         {
             if (ttNhanVien == null || ttNhanVien.IsDisposed)
                 ttNhanVien = new FrmNhanVien();
             ttNhanVien.MdiParent = this;
             ttNhanVien.Show(dockPanelMain);
         }
         
         //Quan ly phong ban
         private void ttDonVitoolStripButton_Click(object sender, EventArgs e)
         {
             if (ttDonVi == null || ttDonVi.IsDisposed)
                 ttDonVi = new FrmQuanLyDonVi();
             ttDonVi.MdiParent = this;
             ttDonVi.Show(dockPanelMain);
             this.Activate();
         }

         private void DonViToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (ttDonVi == null || ttDonVi.IsDisposed)
                 ttDonVi = new FrmQuanLyDonVi();
             ttDonVi.MdiParent = this;
             ttDonVi.Show(dockPanelMain);
         }
         private void TtDonVi_Click(object sender, EventArgs e)
         {
             if (ttDonVi == null || ttDonVi.IsDisposed)
                 ttDonVi = new FrmQuanLyDonVi();
             ttDonVi.MdiParent = this;
             ttDonVi.Show(dockPanelMain);
         }

         //Dang xuat
         private void ebtnDangXuat_Click(object sender, EventArgs e)
         {
             Disable();
         }

         private void btnThanNhan_Click(object sender, EventArgs e)
         {

             if (ttThanNhan == null || ttThanNhan.IsDisposed)
                 ttThanNhan = new FrmThanNhan();
                ttThanNhan.MdiParent = this;
                ttThanNhan.Show(dockPanelMain);
             this.Activate();
         }

         private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (ttTKNhanVien == null || ttTKNhanVien.IsDisposed)
                 ttTKNhanVien = new FrmTKNhanVien();
             ttTKNhanVien.MdiParent = this;
             ttTKNhanVien.Show(dockPanelMain);
             this.Activate();
         }

         private void btnDaoTao_Click(object sender, EventArgs e)
         {
             if (ttQTDT == null || ttQTDT.IsDisposed)
                 ttQTDT = new FrmQuaTrinhDaoTao();
             ttQTDT.MdiParent = this;
             ttQTDT.Show(dockPanelMain);
             this.Activate();
         }

         private void DaoTaoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (ttQTDT == null || ttQTDT.IsDisposed)
                 ttQTDT = new FrmQuaTrinhDaoTao();
             ttQTDT.MdiParent = this;
             ttQTDT.Show(dockPanelMain);
         }

        

         private void btnNangLuong_Click(object sender, EventArgs e)
         {
             if (ttLuong == null || ttLuong.IsDisposed)
                 ttLuong = new FrmDanhSachNangLuong();
             ttLuong.MdiParent = this;
             ttLuong.Show(dockPanelMain);
             this.Activate();
         }

         private void ebtnNangLuong_Click(object sender, EventArgs e)
         {
             if (ttLuong == null || ttLuong.IsDisposed)
                 ttLuong = new FrmDanhSachNangLuong();
             ttLuong.MdiParent = this;
             ttLuong.Show(dockPanelMain);
             
         }

         private void ToolStripMenuItemQuanLyNangLuong_Click(object sender, EventArgs e)
         {
             if (ttLuong == null || ttLuong.IsDisposed)
                 ttLuong = new FrmDanhSachNangLuong();
             ttLuong.MdiParent = this;
             ttLuong.Show(dockPanelMain);
         }
         public void KetNoi()
         {
             MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

             if (m_Connection == null || m_Connection.IsDisposed)
                 m_Connection = new frmKetNoiCSDL();

             if (m_Connection.ShowDialog() == DialogResult.OK)
             {
                 MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }
             else
                 return;
         }
         private void toolPhucHoi_Click(object sender, EventArgs e)
         {
             if (restoreDialog.ShowDialog() == DialogResult.OK)
             {
                 System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + Utilities.DatabaseName + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'");
                 DataService data = new DataService();
                 data.Load(cmd);
                 MessageBoxEx.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
                 return;
         }

         private void toolSaoLuu_Click(object sender, EventArgs e)
         {
             if (backupDialog.ShowDialog() == DialogResult.OK)
             {
                 System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + Utilities.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                 DataService data = new DataService();
                 data.Load(cmd);
                 MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
                 return;
         }

         private void thôngTinLiênHệToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (ttTTLH == null || ttTTLH.IsDisposed)
                 ttTTLH = new FrmThongTinLienHe();
             ttTTLH.MdiParent = this;
             ttTTLH.Show(dockPanelMain);
         }

         private void btnQuaTrinhBoiDuong_Click(object sender, EventArgs e)
         {
             if (ttQTBD == null || ttQTBD.IsDisposed)
                 ttQTBD = new FrmQuaTrinhBoiDuong();
             ttQTBD.MdiParent = this;
             ttQTBD.Show(dockPanelMain);
         }

         private void btnQuaTrinhCongTac_Click(object sender, EventArgs e)
         {
             if (ttQTCT == null || ttQTCT.IsDisposed)
                 ttQTCT = new FrmQuaTrinhCongTac();
             ttQTCT.MdiParent = this;
             ttQTCT.Show(dockPanelMain);
         }

         private void ebtnKhenThuong_Click(object sender, EventArgs e)
         {
             if (ttKhenThuong == null || ttKhenThuong.IsDisposed)
                 ttKhenThuong = new FrmKhenThuong();
             ttKhenThuong.MdiParent = this;
             ttKhenThuong.Show(dockPanelMain);
         }

         private void ebtnKyLuat_Click(object sender, EventArgs e)
         {
             if (ttKyLuat == null || ttKyLuat.IsDisposed)
                 ttKyLuat = new FrmKyLuat();
             ttKyLuat.MdiParent = this;
             ttKyLuat.Show(dockPanelMain);
         }

         private void thốngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if ( dSNhanVien == null || dSNhanVien.IsDisposed )
                 dSNhanVien = new FrmReportNhanVien();
             dSNhanVien.MdiParent = this;
             dSNhanVien.Show(dockPanelMain);
             this.Activate();
         }

         private void danhSáchHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (dSDonVi == null || dSDonVi.IsDisposed)
                 dSDonVi = new FrmDSDonVi();
             dSDonVi.MdiParent = this;
             dSDonVi.Show(dockPanelMain);
             this.Activate();
         }

         private void ebtnDanhSachNhanVien_Click(object sender, EventArgs e)
         {
             if (dSNhanVien == null || dSNhanVien.IsDisposed)
                 dSNhanVien = new FrmReportNhanVien();
             dSNhanVien.MdiParent = this;
             dSNhanVien.Show(dockPanelMain);
         }

         private void ebtnDanhSachPhongBan_Click(object sender, EventArgs e)
         {
             if (dSDonVi == null || dSDonVi.IsDisposed)
                 dSDonVi = new FrmDSDonVi();
             dSDonVi.MdiParent = this;
             dSDonVi.Show(dockPanelMain);
         }

         private void hướngDãnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Help.ShowHelp(this, "Helps.chm");
         }
         FrmReportLuong ReportLuong = null;
         private void báoCáoLươngToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (ReportLuong == null || ReportLuong.IsDisposed)
                 ReportLuong = new FrmReportLuong();
             ReportLuong.MdiParent = this;
             ReportLuong.Show(dockPanelMain);
             this.Activate();
         }

         private void ebtnBaoCaoLuong_Click(object sender, EventArgs e)
         {
             if (ReportLuong == null || ReportLuong.IsDisposed)
                 ReportLuong = new FrmReportLuong();
             ReportLuong.MdiParent = this;
             ReportLuong.Show(dockPanelMain);
         }
         FrmThongTinPhongNoiVu ttPhongNoiVu = new FrmThongTinPhongNoiVu();
         private void ToolStripMenuItemThongTinPhongNoiVu_Click(object sender, EventArgs e)
         {
             if (ttPhongNoiVu == null || ttPhongNoiVu.IsDisposed)
                 ttPhongNoiVu = new FrmThongTinPhongNoiVu();
             ttPhongNoiVu.MdiParent = this;
             ttPhongNoiVu.Show(dockPanelMain);
             this.Activate();
         }

        
            
            
     }   
}