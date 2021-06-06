using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class ChiTietDocGia : Form
    {
        public DataTable TableDocGiaChiTiet;
        fromDocGia helpchitiet = new fromDocGia();
        public ChiTietDocGia()
        {
            InitializeComponent();
            RemoveXButton(this.Handle);
        }

        private void ChiTietDocGia_Load(object sender, EventArgs e)
        {
            labmadocgia.Text = TableDocGiaChiTiet.Rows[0][0].ToString();
            ladhoten.Text = TableDocGiaChiTiet.Rows[0][1].ToString();
            labdiachi.Text = TableDocGiaChiTiet.Rows[0][2].ToString();
            labhokhau.Text = TableDocGiaChiTiet.Rows[0][4].ToString();
            labdonvi.Text = TableDocGiaChiTiet.Rows[0][5].ToString();
            labngaysinh.Text = TableDocGiaChiTiet.Rows[0][6].ToString();
            lapemail.Text = TableDocGiaChiTiet.Rows[0][7].ToString();
            lapdienthoai.Text = '0'+ TableDocGiaChiTiet.Rows[0][8].ToString();
            lapgioitinh.Text = TableDocGiaChiTiet.Rows[0][9].ToString();
            lapmanhanvien.Text = TableDocGiaChiTiet.Rows[0][10].ToString();
            labngaylapthe.Text = TableDocGiaChiTiet.Rows[0][11].ToString();
            
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