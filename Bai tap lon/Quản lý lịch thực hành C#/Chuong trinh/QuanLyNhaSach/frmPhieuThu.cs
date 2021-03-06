using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyNhaSach.Control;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach
{
    public partial class frmPhieuThu : DockContent
    {
        PhieuThuCtrl pt_Ctrl = new PhieuThuCtrl();
        CurrencyManager row;
        DataTable tbl_PhieuThu;
        
        public frmPhieuThu()
        {
            InitializeComponent();
            LoadTable();
            hienthilen_TextBox();
            pt_Ctrl.HienThiListView(livCTPT);
            an_TextBox();
        }

        void LoadTable()
        {
            tbl_PhieuThu = pt_Ctrl.Tbl_PhieuThu();
            row = BindingContext[tbl_PhieuThu] as CurrencyManager;
            dataGridView1.DataSource = tbl_PhieuThu;
        }        
      
       
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {            
            hienthilen_TextBox();
           
        }

        void hienthilen_TextBox()
        {            
            txtMaPT.Text = tbl_PhieuThu.Rows[row.Position]["MAPHIEUTHU"].ToString();
            txtMaNV.Text = tbl_PhieuThu.Rows[row.Position]["MANV"].ToString();
            txtMaKH.Text = tbl_PhieuThu.Rows[row.Position]["MAKH"].ToString();
            dateTimePickerPT.Text = tbl_PhieuThu.Rows[row.Position]["NGAYLAP"].ToString();
            txtLydo.Text = tbl_PhieuThu.Rows[row.Position]["LYDOTHU"].ToString();
            txtTongTien.Text = tbl_PhieuThu.Rows[row.Position]["TONGTIEN"].ToString();
        }

        void an_TextBox()
        {
            txtMaPT.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKH.Enabled = false;
            dateTimePickerPT.Enabled = false;
            txtLydo.Enabled = false;
            txtTongTien.Enabled = false;
        }

        void HienTextBox()
        {
            txtMaPT.Enabled = true;
            txtMaNV.Enabled = true;
            txtMaKH.Enabled = true;
            dateTimePickerPT.Enabled = true;
            txtLydo.Enabled = true;
            txtTongTien.Enabled = true;
        }

        void XoaTextBox()
        {
            txtMaPT.Text= "";
            txtMaNV.Text= "";
            txtMaKH.Text = "";
            dateTimePickerPT.Text = "";
            txtLydo.Text = "";
            txtTongTien.Text = "";
        }

        bool them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {     
            HienTextBox();
            XoaTextBox();
            them = true;       
        }

        bool sua = false;
        string maPT;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTextBox();
            sua = true;
            maPT = txtMaPT.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pt_Ctrl.XoaPT(txtMaPT.Text);
            LoadTable();            
            an_TextBox();
            hienthilen_TextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "" || txtMaNV.Text == "" || txtMaKH.Text == "" || txtLydo.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Thông tin nhập ko được trống");
                txtMaPT.Focus();
            }
            else
            {
                if (them)
                {
                    pt_Ctrl.ThemPT(txtMaPT.Text, txtMaNV.Text, txtMaKH.Text, dateTimePickerPT.Text, txtLydo.Text, txtTongTien.Text);
                    them = false;
                }
                if (sua)
                {
                    PhieuThuInfo pt_Info = new PhieuThuInfo();
                    pt_Info.maPhieuThu = txtMaPT.Text;
                    pt_Info.MaNV = txtMaNV.Text;
                    pt_Info.MaKhachHang = txtMaKH.Text;
                    pt_Info.NgayLap = dateTimePickerPT.Text;
                    pt_Info.LyDoThu = txtLydo.Text;
                    pt_Info.TongTien = txtTongTien.Text;
                    pt_Ctrl.UpdatePT(pt_Info, maPT);
                    sua = false;
                }
                LoadTable();
                pt_Ctrl.HienThiListView(livCTPT);
                hienthilen_TextBox();
                an_TextBox();
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }      
    }
}