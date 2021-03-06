using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using QuanLyNhaSach.Control;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach
{
    public partial class frmTimKhachHang : Form
    {
        KhachHangCtrl kh_Ctrl = new KhachHangCtrl();
        private KhachHangInfo m_kh;
        public KhachHangInfo KH
        {
            get { return m_kh; }
            set { m_kh = value; }
        }
        public frmTimKhachHang()
        {
            InitializeComponent();
            //kh_Ctrl.LoadComboBox(cbMaKH, "MAKH", "MAKH");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimKhachHang tim = new frmTimKhachHang();
            tim.dataGridView1.DataBindings.Clear();
            kh_Ctrl.TimKhachHang(txtHoTenKH, cbDCNC, txtDiaChi, cbDTNC, txtDT, dataGridView1);
            toolStripButton2.Enabled = true;
        }

        //private void frmTimKhachHang_Load(object sender, EventArgs e)
        //{
        //    cbMaKH.Text = "Chọn mã KH";
            
        //    //kh_Ctrl.HienThi(dataGridView1, bindingNavigator1);
        //}

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();

            if (ie.MoveNext())
            {
                DataGridViewRow row = (DataGridViewRow)ie.Current;
                m_kh = new KhachHangInfo();
                m_kh.MaKhachHang = row.Cells[0].Value.ToString();
                m_kh.TenKhachHang = row.Cells[1].Value.ToString();
                m_kh.Phai = row.Cells[2].Value.ToString();
                m_kh.DiaChi = row.Cells[3].Value.ToString();
                m_kh.DienThoai = row.Cells[4].Value.ToString();
                m_kh.MaSoThue = row.Cells[5].Value.ToString();
                m_kh.GhiChu = row.Cells[6].Value.ToString();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}