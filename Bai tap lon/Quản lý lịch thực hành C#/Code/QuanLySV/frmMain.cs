﻿using System;
using System.Drawing;
using System.Windows.Forms;
using QLSV_Database;
using QLSV_Xuly;
using QLSV_GiaoDien;
using QLSV_GiaoDien.UserControls;
using QLSV_GiaoDien.Reports;
namespace QLSV_GiaoDien
{
    public partial class frmMain : Form
    {
        c_XuLyChung qlsv_xl = new c_XuLyChung();
        public frmMain()
        {
            InitializeComponent();
        }

        bool is_panQLSVExpand =true;//khoi tao 1 bien co de xet xem panel dang o che do expand hay collapse
        bool is_panQLMHExpand = true;
        int x_pnQlSV, y_pnQLSV, x_pnQLD, y_pnQLD, x_pnQLMH, y_pnQLMH;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            btnQLSV_collapse.Visible = true;
            btnQLSV_ex.Visible = false;

            btnQLMH_Collapse.Visible = true;
            btnQLMH_ex.Visible = false;

            btnQLDIEM_Collapse.Visible = true;
            btnQLDIEM_ex.Visible = false;

            //pan_MenuMH.Height = 0;
            //pan_MenuQLDIEM.Height = 0;

            x_pnQlSV = pan_QLSV.Location.X;
            y_pnQLSV = pan_QLSV.Location.Y;

            x_pnQLMH = pan_QLMH.Location.X;
            y_pnQLMH = pan_QLMH.Location.Y;

            x_pnQLD = pan_QLDIEM.Location.X;
            y_pnQLD = pan_QLDIEM.Location.Y;

          //  grB_leftMenu.Visible = false;
            grB_leftMenu.Enabled = false;
            menuStrip1.Visible = true;

            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;

            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN";
         
           
        }

        private void btnQLSV_collapse_Click(object sender, EventArgs e)
        {
            btnQLSV_ex.Visible = true;
            btnQLSV_collapse.Visible = false;
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height - 1;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height > 0);
           
                pan_QLMH.BringToFront();
                pan_QLDIEM.BringToFront();
                int new_y_QLMH = pan_MenuQLSV.Location.Y + 10;
                int new_y_QLDiem = pan_MenuMH.Location.Y * 6;//pan_MenuMH.Location.Y*5 + 30;
                pan_QLMH.Location = new Point(x_pnQLMH, new_y_QLMH);
               
                is_panQLSVExpand = false;
                if (is_panQLMHExpand == false && is_panQLSVExpand == false)
                {
                    pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH / 2);
                }
                else
                {
                    pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
                }
               
            
        }

        private void btnQLSV_ex_Click(object sender, EventArgs e)
        {
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height + 1;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height <= 120);
            btnQLSV_ex.Visible = false;
            btnQLSV_collapse.Visible = true;
           
                pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
                pan_QLMH.Location = new Point(x_pnQLMH, y_pnQLMH);
                is_panQLSVExpand = true;
                if (is_panQLMHExpand == false && is_panQLSVExpand == true)
                {
                    int new_y_QLDiem = pan_MenuMH.Location.Y * 6;
                    pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
                }
           
        }

        private void btnQLMH_ex_Click(object sender, EventArgs e)
        {
            
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height + 1;
                Application.DoEvents();
            } while (pan_MenuMH.Height <= 120);
            btnQLMH_ex.Visible = false;
            btnQLMH_Collapse.Visible = true;
          

            if (is_panQLSVExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH + 40);
            }
           
            else
            {
                pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
            }
            is_panQLMHExpand = true;

        }

        private void btnQLMH_Collapse_Click(object sender, EventArgs e)
        {
            btnQLMH_ex.Visible = true;
            btnQLMH_Collapse.Visible = false ;
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height - 1;
                Application.DoEvents();
            } while (pan_MenuMH.Height >0);
            is_panQLMHExpand = false;
         
            if (is_panQLSVExpand == false && is_panQLMHExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, pan_MenuMH.Location.Y + 50);
            }
            else
            {
                int new_y_QLDiem = pan_MenuMH.Location.Y + pan_QLMH.Location.Y;
                pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
            }
         
        }

        private void btnQLDIEM_ex_Click(object sender, EventArgs e)
        {
           
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height + 1;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height <= 120);
            btnQLDIEM_ex.Visible = false;
            btnQLDIEM_Collapse.Visible = true;
        }

        private void btnQLDIEM_Collapse_Click(object sender, EventArgs e)
        {
            btnQLDIEM_ex.Visible = true;
            btnQLDIEM_Collapse.Visible = false ;
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height - 1;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height >0);
        }

     

      

        #region Add User control

        private void lnk_QuanlySv_lop_mh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lí Sinh Viên - Lớp - Môn học";
            uc_SinhVien_Lop_MonHoc slv = new uc_SinhVien_Lop_MonHoc();
            qlsv_xl.AddControl(pan_Main, slv);
            
        }

        //private void lnk_DangKyMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    lblTitle.Text = "Đăng Ký Môn Học";
        //    uc_DK_MonHoc DKMH = new uc_DK_MonHoc(); 
            
        //        qlsv_xl.AddControl(pan_Main, DKMH);
            
        //}

        private void lnkGV_K_e_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lí Giáo Viên - Khoa - Khóa học - Hệ";
            uc_GiaoVien_KhoaHoc_Khoa_He gkh = new uc_GiaoVien_KhoaHoc_Khoa_He();
            qlsv_xl.AddControl(pan_Main, gkh);
            
        }

       
        #endregion


        //hàm nhận tham số truyền về từ delegate Login
        public void enable_groupbox(bool kq)
        {
            grB_leftMenu.Enabled = kq;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Login frmLogin = new Login())
            {
                frmLogin.setGroupbox = new Login.EnableGroupbox(enable_groupbox);
                //nhận tham so truyen ve tu ham delegate EnableGroupbox
                frmLogin.ShowDialog();
            }
            if (grB_leftMenu.Enabled == true)
            {
                DangNhapToolStripMenuItem.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = true;
                pan_Main.Enabled = true;
                quanlyTK_ToolStripMenuItem.Enabled = true;
                TacVuToolStripMenuItem.Enabled = true;
                báoCáoToolStripMenuItem.Enabled = true;
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            uc_User user = new uc_User();
            
                qlsv_xl.AddControl(pan_Main, user);
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
            pan_Main.BackgroundImage = Properties.Resources.bg1;
            lblTitle.Text = "Chương trình quản lý sinh viên";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnk_TraCuuSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //UserControl1 uc1 = new UserControl1();
            //pan_Main.Controls.Add(uc1);
        }

        private void lnkXoaSv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uc_SinhVien_Lop_MonHoc slv = new uc_SinhVien_Lop_MonHoc();
            qlsv_xl.AddControl(pan_Main, slv);
            
         
        }

        private void pan_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            uc_User user = new uc_User();

            qlsv_xl.AddControl(pan_Main, user);
        }

        private void lnkNhapDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Nhập Điểm";
            uc_NhapDiem nhapdiem = new uc_NhapDiem();
            qlsv_xl.AddControl(pan_Main, nhapdiem);
        }

        private void lnkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
            pan_Main.BackgroundImage = Properties.Resources.bg1;
            lblTitle.Text = "Chương trình quản lý sinh viên";
        }

        private void lnkTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.Orange;
        }

        private void lnkTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkXuatSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReportSinhVien frm = new frmReportSinhVien();
            frm.Show();
        }

        private void lnkXuatDSMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBaocaoMH frmMH = new frmBaocaoMH();
            frmMH.Show();
        }

        private void lnkXemDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBaocaoDiem frmDiem = new frmBaocaoDiem();
            frmDiem.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quanliSV_L_MH_NGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lí Sinh Viên - Lớp - Môn học";
            uc_SinhVien_Lop_MonHoc slv = new uc_SinhVien_Lop_MonHoc();
            qlsv_xl.AddControl(pan_Main, slv);
        }

        private void quanliGV_Khoa_khoahoc_HEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lí Giáo Viên - Khoa - Khóa học - Hệ";
            uc_GiaoVien_KhoaHoc_Khoa_He gkh = new uc_GiaoVien_KhoaHoc_Khoa_He();
            qlsv_xl.AddControl(pan_Main, gkh);
        }

        private void nhapDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhập Điểm";
            uc_NhapDiem nhapdiem = new uc_NhapDiem();
            qlsv_xl.AddControl(pan_Main, nhapdiem);
        }

        private void xuatDSMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmBaocaoMH frmMH = new frmBaocaoMH();
            frmMH.Show();
        }

        private void xuatDSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSinhVien frm = new frmReportSinhVien();
            frm.Show();
        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocaoDiem frmDiem = new frmBaocaoDiem();
            frmDiem.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutme ab = new Aboutme();
            ab.Show();
        }

       
    }
}
