using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Diagnostics;
namespace QuanLyTV
{
    public partial class Form1 : Form
    {
        public static int[] DaMo = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0 , 0 ,0};

        
        public Form1()
        {
            InitializeComponent();
            RemoveXButton(this.Handle);
            StripNgayGio.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int GetSystemMenu(IntPtr hwnd, int bRevert);
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);
        public const int SC_CLOSE = 61536;
        public const int MF_BYCOMMAND = 0;

        int RemoveXButton(IntPtr iHWND)
        {
            int iSysMenu; 
            iSysMenu = GetSystemMenu(iHWND, 0);
            return RemoveMenu(iSysMenu, SC_CLOSE, MF_BYCOMMAND);
        }
        AccessHelper accesshelp = new AccessHelper();
        private void Form1_Load(object sender, EventArgs e)
        {
            accesshelp.KetNoiData();
            if (accesshelp.KetNoi == 1)
            {
                StripKetNoi.Text = "Đã kết nối cơ sở dữ liệu  ";
                StripMaDangNhap.Text  = "  Mã Nhân Viên Đăng Nhập : "+AccessHelper.MaNhanVienDangNhap +" " ;
                StripTenDangNhap.Text ="  Tên Nhân Viên Đăng Nhập : " + AccessHelper.TenNhanVienDangNhap + " ";
                StripNgayGio.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
            }
            else StripKetNoi.Text = "Chưa Kết Nối Dữ liệu";
        }
        void HamLogout()
        {
            for (int i = 0; i < DaMo.Length; i++)
            {
                if (DaMo[i] == 1)
                {
                    if (MessageBox.Show("Còn cửa sổ đang mở,bạn có muốn tắt trước khi logout không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        return;
                    }
                }
       }
            if (MessageBox.Show("Bạn thật sự muốn logout???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AccessHelper.TruyCap = 0;
                Login.Sudung = 0;

                Login frmlogin = new Login();
                
                frmlogin.button1.Text = "Đăng Nhập";
                frmlogin.button2.Text = "Thoát";
                frmlogin.Text = "Login";
                frmlogin.button3.Enabled = true;
                frmlogin.Show();
                this.Hide();
            }
        }
        private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == toolBar.Buttons[0])
            {
                HamLogout();
            }
            if (e.Button == toolBar.Buttons[1] && DaMo[0]==0 )
            {
                fromDocGia frmDocGia = new fromDocGia();
                frmDocGia.MdiParent = this;
                frmDocGia.Show();
            }
            if (e.Button == toolBar.Buttons[2] && DaMo[1] == 0)
            {
                MoNhanVien();
            }
            if (e.Button == toolBar.Buttons[3] && DaMo[4] == 0)
            {
                QuanLyMuonSach frmQuanLy = new QuanLyMuonSach();
                frmQuanLy.MdiParent = this;
                frmQuanLy.Show();
            }
            if (e.Button == toolBar.Buttons[4] && DaMo[2]== 0 )
            {
                LuuTruSach frmSach = new LuuTruSach();
                frmSach.MdiParent = this;

                frmSach.Show();
            }
            if (e.Button == toolBar.Buttons[5] && DaMo[10]==0)
            {
                ThongKe tk = new ThongKe();
                tk.Show();
            }

        }
        void MoNhanVien()
        {
            if (AccessHelper.Mo == 0)
            {
                Login frmlogin = new Login();
                frmlogin.button1.Text = "Xác Nhận";
                frmlogin.button2.Text = "Hủy";
                frmlogin.Text = "Xác Nhận Lại Mật Khẩu";
                frmlogin.button3.Enabled = false;
                Login.Sudung = 1;
                frmlogin.Show();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DaMo.Length; i++)
            {
                if (DaMo[i] == 1)
                {
                    if (MessageBox.Show("Còn cửa sổ đang mở,bạn có muốn tắt trước khi thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        return;
                    }
                }



            }
            
            if (MessageBox.Show("Bạn thật sự muốn thoát mà không logout khỏi chương trình???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                Application.Exit();
                
            }
            

        }
        private void danhMụcĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[0] == 0)
            {
                fromDocGia frmDocGia = new fromDocGia();
                frmDocGia.MdiParent = this;
                frmDocGia.Show();
            }

        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[1] == 0)
            {
                MoNhanVien();
            }
        }
        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[2] == 0)
            {
                LuuTruSach frmSach = new LuuTruSach();
                frmSach.MdiParent = this;
                frmSach.Show();
            }
        }
        private void tùyChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[3] == 0)
            {
                Options frmoption = new Options();
                frmoption.MdiParent = this;
                frmoption.Show();
            }
        }
        private void mượnVàTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[4] == 0)
            {
                QuanLyMuonSach frmQuanLy = new QuanLyMuonSach();
                frmQuanLy.MdiParent = this;
                frmQuanLy.Show();
            }
        }
        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[5] == 0)
            {
                TimKiemSach frmTimSach = new TimKiemSach();
                frmTimSach.MdiParent = this;
                frmTimSach.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            StripNgayGio.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }
        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs f)//Toolbar Thong Ke ben tay phai
        {
            if (f.Button == toolBar1.Buttons[0] && DaMo[7] == 0)
            {
                TKDocGia docgia = new TKDocGia();
                docgia.MdiParent = this;
                docgia.Show();
            }
            if (f.Button == toolBar1.Buttons[1] && DaMo[8] == 0)
            {
                TKNhanVien nhanvien = new TKNhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            if (f.Button == toolBar1.Buttons[2] && DaMo[9] == 0)
            {
                TKSach sach = new TKSach();
                sach.MdiParent = this;

                sach.Show();
            }
            if (f.Button == toolBar1.Buttons[3] && DaMo[6] == 0)
            {
                TKDangMuonSach muonsach = new TKDangMuonSach();
                muonsach.MdiParent = this;
                muonsach.Show();
            }

        }
        private void máyTínhNhéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Run = new ProcessStartInfo();
            Run.FileName = "MayTinh.exe";
            Run.Arguments = "Chaydi";
            Run.WorkingDirectory = "MayTinh.exe";
            Run.WindowStyle = ProcessWindowStyle.Normal;
            Run.ErrorDialog = true;
            Process App = new Process();
            App.StartInfo = Run;
            try
            {
                App.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi rồi!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
		}
        private void cờCaroNhéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Run = new ProcessStartInfo();
            Run.FileName = "GomokuGame.exe";
            Run.Arguments = "Chay di";
            Run.WorkingDirectory = "GomokuGame.exe";
            Run.WindowStyle = ProcessWindowStyle.Normal;
            Run.ErrorDialog = true;
            Process App = new Process();
            App.StartInfo = Run;
            try
            {
                App.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi rồi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void danhMụcĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DaMo[0] == 0)
            {
                fromDocGia frmDocGia = new fromDocGia();
                frmDocGia.MdiParent = this;
                frmDocGia.Show();
            }

        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DaMo[1] == 0)
            {
                MoNhanVien();
            }
        }

        private void tìmSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DaMo[2] == 0)
            {
                LuuTruSach frmSach = new LuuTruSach();
                frmSach.MdiParent = this;
                frmSach.Show();
            }
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[4] == 0)
            {
                QuanLyMuonSach frmQuanLy = new QuanLyMuonSach();
                frmQuanLy.MdiParent = this;
                frmQuanLy.Show();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[10] == 0)
            {
                ThongKe tk = new ThongKe();
                tk.Show();
            }
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[5] == 0)
            {
                TimKiemSach frmTimSach = new TimKiemSach();
                frmTimSach.MdiParent = this;
                frmTimSach.Show();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[3] == 0)
            {
                Options frmoption = new Options();
                frmoption.MdiParent = this;
                frmoption.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HamLogout();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DaMo.Length; i++)
            {
                if (DaMo[i] == 1)
                {
                    if (MessageBox.Show("Còn cửa sổ đang mở,bạn có muốn tắt trước khi thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        return;
                    }
                }



            }

            if (MessageBox.Show("Bạn thật sự muốn thoát mà không logout khỏi chương trình???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[12] == 0)
            {
                AboutCT frmabout = new AboutCT();
                frmabout.MdiParent = this;
                frmabout.Show();
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello sir!!!");

        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[12] == 0)
            {
                AboutCT frmabout = new AboutCT();
                frmabout.MdiParent = this;
                frmabout.Show();
            }
            
        }

        private void tìmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[11] == 0)
            {
                TimDocGia frmtimdocgia = new TimDocGia();
                frmtimdocgia.MdiParent = this;
                frmtimdocgia.Show();
            }
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DaMo[11] == 0)
            {
                TimDocGia frmtimdocgia = new TimDocGia();
                frmtimdocgia.MdiParent = this;
                frmtimdocgia.Show();
            }
        }

       

       
       
       

      
     
      

       
    }
}
