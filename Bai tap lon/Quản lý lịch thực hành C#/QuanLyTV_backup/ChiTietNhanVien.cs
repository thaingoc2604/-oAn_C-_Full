using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class ChiTietNhanVien : Form
    {
        public DataTable TableNhanVienChiTiet;
        fromDocGia helpchitiet = new fromDocGia();
        public ChiTietNhanVien()
        {
            InitializeComponent();
            RemoveXButton(this.Handle);
        }

        private void ChiTietNhanVien_Load(object sender, EventArgs e)
        {
            labmanhanvien.Text = TableNhanVienChiTiet.Rows[0][0].ToString();
            ladhoten.Text = TableNhanVienChiTiet.Rows[0][1].ToString();
            labdiachi.Text = TableNhanVienChiTiet.Rows[0][2].ToString();

            labhokhau.Text = TableNhanVienChiTiet.Rows[0][4].ToString();
            labngaysinh.Text = TableNhanVienChiTiet.Rows[0][5].ToString();
            lapemail.Text = TableNhanVienChiTiet.Rows[0][6].ToString();
            labchucvu.Text = TableNhanVienChiTiet.Rows[0][7].ToString();
            
            
            
            
            lapdienthoai.Text = '0' + TableNhanVienChiTiet.Rows[0][8].ToString();
            lapgioitinh.Text = TableNhanVienChiTiet.Rows[0][9].ToString();
            labmatkhau.Text = TableNhanVienChiTiet.Rows[0][10].ToString();
            labngayvaolam.Text = TableNhanVienChiTiet.Rows[0][11].ToString();
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}