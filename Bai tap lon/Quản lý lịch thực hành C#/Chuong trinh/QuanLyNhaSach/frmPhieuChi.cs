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
    public partial class frmPhieuChi : DockContent
    {
        PhieuChiCtrl pc_Ctrl = new PhieuChiCtrl();
        CurrencyManager row;
        DataTable tbl_PhieuChi;
        
        public frmPhieuChi()
        {
            InitializeComponent();
            LoadTable();
            hienthilen_TextBox();
            pc_Ctrl.HienThiListView(livCTPC);
            an_TextBox();
        }

        void LoadTable()
        {
            tbl_PhieuChi = pc_Ctrl.Tbl_PhieuChi();            
            row = BindingContext[tbl_PhieuChi] as CurrencyManager;
            dataGridView1.DataSource = tbl_PhieuChi;            
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            hienthilen_TextBox();
        }

        void hienthilen_TextBox()
        {
            txtMaPC.Text = tbl_PhieuChi.Rows[row.Position]["MAPC"].ToString();
            txtMaNV.Text = tbl_PhieuChi.Rows[row.Position]["MANV"].ToString();
            txtMaNCC.Text = tbl_PhieuChi.Rows[row.Position]["MANCC"].ToString();
            dateTimePickerPC.Text = tbl_PhieuChi.Rows[row.Position]["NGAYLAP"].ToString();
            txtLyDo.Text = tbl_PhieuChi.Rows[row.Position]["LYDOCHI"].ToString();
            txtTongTien.Text = tbl_PhieuChi.Rows[row.Position]["TONGSOTIEN"].ToString();           
        }

        void an_TextBox()
        {
            txtMaPC.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaNCC.Enabled = false;
            dateTimePickerPC.Enabled = false;
            txtLyDo.Enabled = false;
            txtTongTien.Enabled = false;
        }

        void HienTextBox()
        {
            txtMaPC.Enabled = true;
            txtMaNV.Enabled = true;
            txtMaNCC.Enabled = true;
            dateTimePickerPC.Enabled = true;
            txtLyDo.Enabled = true;
            txtTongTien.Enabled = true;
        }

        void XoaTextBox()
        {
            txtMaNV.Text = "";
            txtMaPC.Text = "";
            txtMaNCC.Text = "";
            dateTimePickerPC.Text = "";
            txtLyDo.Text = "";
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
        string maPC;
        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTextBox();
            sua = true;
            maPC = txtMaPC.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pc_Ctrl.XoaPC(txtMaPC.Text);
            LoadTable();
            an_TextBox();
            hienthilen_TextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text == "" || txtMaNV.Text == "" || txtMaNCC.Text == "" || txtLyDo.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Thông tin nhập ko được trống");
                txtMaPC.Focus();
            }
            else
            {
                if (them)
                {
                    pc_Ctrl.ThemPC(txtMaPC.Text, txtMaNV.Text, txtMaNCC.Text, dateTimePickerPC.Text, txtLyDo.Text, txtTongTien.Text);
                    them = false;
                }
                if (sua)
                {
                    PhieuChiInfo pc_Info = new PhieuChiInfo();
                    pc_Info.maPhieuChi = txtMaPC.Text;
                    pc_Info.MaNV = txtMaNV.Text;
                    pc_Info.MaNCC = txtMaNCC.Text;
                    pc_Info.NgayLap = dateTimePickerPC.Text;
                    pc_Info.LyDoChi = txtLyDo.Text;
                    pc_Info.TongTien = txtTongTien.Text;
                    pc_Ctrl.UpdatePC(pc_Info, maPC);
                    sua = false;
                }
                LoadTable();
                pc_Ctrl.HienThiListView(livCTPC);
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