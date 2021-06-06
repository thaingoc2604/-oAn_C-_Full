using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class Login : Form
    {
        public static int Sudung = 0;
        fromNhanVien frmNV = new fromNhanVien();
        Form1 frm1 = new Form1();
        public Login()
        {
            InitializeComponent();
            RemoveXButton(this.Handle);
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
        AccessHelper helpaccess = new AccessHelper();

        private void Login_Load(object sender, EventArgs e)
        {
            string TruyVan ="SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien";

            frmNV.TableNhanVien = helpaccess.TaoTable(TruyVan);
            
            AccessHelper.Mo = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMANhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên của bạn vào!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            if(txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của bạn vào!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            int n = 0;
            Login frmlogin = new Login();
            AccessHelper help = new AccessHelper();
            string manhanvien = txtMANhanVien.Text.ToString();
            string matkhau = txtMatKhau.Text.ToString();
            for (int i = 0; i < frmNV.TableNhanVien.Rows.Count; i++)
            {
                if (string.Equals(manhanvien, frmNV.TableNhanVien.Rows[i][0].ToString()) && (string.Equals(matkhau, frmNV.TableNhanVien.Rows[i][4].ToString())))
                {

                    if (Sudung == 0)
                    {
                        Form1 frmchinh = new Form1();
                        n = 1;
                        AccessHelper.TruyCap = 1;
                        AccessHelper.MaNhanVienDangNhap = manhanvien;
                        AccessHelper.TenNhanVienDangNhap = frmNV.TableNhanVien.Rows[i][1].ToString();
                        AccessHelper.Mo = 0;
                        new Form1().Show();
                        this.Hide();
                    }
                    if (Sudung == 1)
                    {
                        n = 1;
                        fromNhanVien frmnhanvien = new fromNhanVien();
                        AccessHelper.Mo = 0;
                        
                        frmnhanvien.Show();
                        this.Hide();
                    }
                                       
                }
                
            }
            if (n == 0)
            { 
                
                
                    MessageBox.Show("Bạn đăng nhập không thành công");
                
            }
        }
        TimKiemSach frmtim = new TimKiemSach();
        LuuTruSach frmSach = new LuuTruSach();
        private void button3_Click(object sender, EventArgs e)
        {
            AccessHelper.TruyCap = 0;

            frmSach.TableSach = frmSach.Doc_DS_Sach();

            frmtim.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sudung == 1)
            {
                AccessHelper.Mo = 0;
                this.Hide();
            }
            else Application.Exit();
        }



    }
}
