using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace QuanLyPhongMach
{
    public partial class FrmChinh : Form
    {
        public BacSiDTO BSi = new BacSiDTO();
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            //#region Nhạc khởi động form
            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\WINDOWS\MEDIA\Windows XP Startup.wav");
            //sp.Play();
            //#endregion            
        }        

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();            

            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                this.bácSĩToolStripMenuItem.Enabled = true;
                this.bệnhNhânToolStripMenuItem.Enabled = true;
                this.xếpGiườngBệnhToolStripMenuItem.Enabled = true;
                this.đăngXuấtToolStripMenuItem.Visible = true;
                this.đăngNhậpToolStripMenuItem.Visible = false;
                this.đơnThuốcToolStripMenuItem.Enabled = true;

                this.label1.Visible = true;                

                this.lbbacsidangnhap.Text = dangnhap.BS.TenBacSi;
                BSi.TenBacSi = dangnhap.BS.TenBacSi;
                BSi.PassWord = dangnhap.BS.PassWord;
                BSi.sttBS = dangnhap.BS.sttBS;
                BSi.DiaChi = dangnhap.BS.DiaChi;
                BSi.SoDienThoai = dangnhap.BS.SoDienThoai;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bácSĩToolStripMenuItem.Enabled = false;
            this.bệnhNhânToolStripMenuItem.Enabled = false;
            this.xếpGiườngBệnhToolStripMenuItem.Enabled = false;
            this.đăngNhậpToolStripMenuItem.Visible = true;
            this.đăngXuấtToolStripMenuItem.Visible = false;
            this.đơnThuốcToolStripMenuItem.Enabled = false;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBenhNhan ThemBN = new ThemBenhNhan();

            ThemBN.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SapGiuongBenh frmSapXep = new SapGiuongBenh();
            frmSapXep.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuBenhNhan frmTraCuu = new frmTraCuuBenhNhan();
            frmTraCuu.ShowDialog();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThemDonThuoc themdonthuoc = new frmThemDonThuoc();
            themdonthuoc.ShowDialog();
        }       

        private void traCứuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuDanhSachBenhNhanDaDieuTri frmTraCuu = new frmTraCuuDanhSachBenhNhanDaDieuTri();
            frmTraCuu.bacsi.sttBS = BSi.sttBS;
            frmTraCuu.ShowDialog();
        }

        private void traCứuThôngTinCácBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuThongTinBacSi frmTraCuu = new frmTraCuuThongTinBacSi();
            frmTraCuu.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiThongTinCaNhan doimatkhau = new frmDoiThongTinCaNhan();

            doimatkhau.bacsi.TenBacSi = BSi.TenBacSi;
            doimatkhau.bacsi.PassWord = BSi.PassWord;
            doimatkhau.bacsi.sttBS = BSi.sttBS;
            doimatkhau.bacsi.DiaChi = BSi.DiaChi;
            doimatkhau.bacsi.SoDienThoai = BSi.SoDienThoai;

            doimatkhau.ShowDialog();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuBenhNhan frmTraCuu = new frmTraCuuBenhNhan();
            frmTraCuu.ShowDialog();
        }

        private void thêmBácSĩMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemBacSi thembacsi = new frmThemBacSi();
            thembacsi.ShowDialog();
        }
    }
}
