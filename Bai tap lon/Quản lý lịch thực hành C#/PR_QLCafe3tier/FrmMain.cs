using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PR_QLCafe3tier
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        #region "FormMain_Load"

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        #endregion

        #region "Hàm kiểm tra form đã tồn tại chưa"

        Boolean kiemtratontai(string Frmname)
        {
            foreach (Form Frm in this.MdiChildren)
            {
                if (Frm.Name.Equals(Frmname))
                {
                    Frm.Activate();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region "FrmMain_FormClosing-Event"

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Là Thoát Ứng Dụng?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DlgHoi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Thoát Ứng Dụng Lúc right Click lên Icon
        /// Trong ConTextMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Timer Lấy Ngày-giờ"

        /// <summary>
        /// Trong Sự Kiện Click Gọi TimerTick
        /// Để Gán các Giá Trị Ngày Giờ Hệ Thống
        /// Vào Thanh StatusStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            Hienngay(ref a, ref b, ref c);
            TTlbTime0.Text = a;
            TTlbTime1.Text = b;
            TTlbTime3.Text = c;
        }

        #endregion

        #region "Hiển Thị Ngày Tháng "

        /// <summary>
        /// Phương thức hiển thị giờ.
        /// </summary>
        /// <param name="Ngaythangnam">Đưa ra ngày tháng</param>
        /// <param name="Gio">Đưa ra giờ hệ thống</param>
        /// <param name="timeofday">Thời gian của ngày</param>
        public void Hienngay(ref string Ngaythangnam, ref string Gio, ref string timeofday)
        {
            string[] a = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] b = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string[] c = { "AM", "PM" };
            string[] d = { "Sáng-Trưa", "Chiều-Tối" };
            string thu = "";
            string tgngay = "";
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string thoigian = DateTime.Now.ToString().Substring(9, 9);
            //
            for (int i = 0; i < c.Length; i++)
            {
                if (DateTime.Now.ToString().Substring(DateTime.Now.ToString().Length - 2, 2).ToLower().Trim() == c[i].ToLower().Trim())
                { tgngay = d[i]; }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToLower().Trim() == a[i].ToLower().Trim())
                { thu = b[i]; }

            }
            Ngaythangnam = thu + ", " + ngay + "/" + thang + "/" + nam;
            Gio = thoigian;
            timeofday = tgngay;
        }

        #endregion

        #region "Thay đổi giao diện"

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black)
            {
                if (MessageBox.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)
            {
                if (MessageBox.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue)
            {
                if (MessageBox.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            if (this.ribbonControl1.Office2007ColorTable != DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver)
            {
                if (MessageBox.Show("Bạn có muốn thay đổi màu nền cho ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
            }
        }

        #endregion

        #region "Tạo Icon Trên toolBar"

        /// <summary>
        /// Gọi Sự Kiện DoubleClick Trong Công Cụ
        /// NotifyIcon Để Khi Form ở Trạng Thái Ẩn
        /// sẽ Trả về Trạng Thái Ban Đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Khi Form Ẩn sẽ Thu Nhỏ Thanh Icon Lưu Trú
        /// Dưới Thanh TabBar Của WinDow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnHide_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion


        #region"Gọi office Word & Excel"

        private void btnMWord_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void btnMExcel_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }


        #endregion

        #region "Gán Tất cả form con vào cha"

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmNhanVien") == false)
            {
                FrmNhanVien f = new FrmNhanVien();
                f.MdiParent = this;
                f.Name = "FrmNhanVien";
                f.Show();

            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmSanPham") == false)
            {
                FrmSanPham f = new FrmSanPham();
                f.MdiParent = this;
                f.Name = "FrmSanPham";
                f.Show();

            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmHoaDon") == false)
            {
                FrmHoaDon f = new FrmHoaDon();
                f.MdiParent = this;
                f.Name = "FrmHoaDon";
                f.Show();

            }
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmNCC") == false)
            {
                FrmNCC f = new FrmNCC();
                f.MdiParent = this;
                f.Name = "FrmNCC";
                f.Show();

            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmThongTin") == false)
            {
                FrmThongTin f = new FrmThongTin();
                f.MdiParent = this;
                f.Name = "FrmThongTin";
                f.Show();

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmDangNhap") == false)
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Name = "FrmDangNhap";
                f.Show();

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("FrmThanhToan") == false)
            {
                FrmThanhToan f = new FrmThanhToan();
                f.MdiParent = this;
                f.Name = "FrmThanhToan";
                f.Show();

            }
        }

        #endregion












    }
}