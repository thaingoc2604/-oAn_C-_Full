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
    public partial class frmTimKiemNhanVien : Form
    {
        NhanVienCtrl nv_Ctrl = new NhanVienCtrl();
        NhanVienInfo nv_Info = new NhanVienInfo();

        private NhanVienInfo m_nv;
        public NhanVienInfo NV
        {
            get { return m_nv; }
            set { m_nv = value; }
        }
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
            //nv_Ctrl.LoadComboBox(cbMaNV, "MANV", "MANV");
            //nv_Ctrl.LoadComboBox(cbPhai, "PHAI", "MANV");
            //nv_Ctrl.LoadComboBox(cbChucVu, "CHUCVU", "MANV");
        }      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien tim = new frmTimKiemNhanVien();
            tim.dataGridView1.DataBindings.Clear();
            nv_Ctrl.TimNhanVien( txtHoten,cbCVNC, txtCV, dataGridView1);
            toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();

            if (ie.MoveNext())
            {
                DataGridViewRow row = (DataGridViewRow)ie.Current;
                m_nv = new NhanVienInfo();
                m_nv.MaNhanVien = row.Cells[0].Value.ToString();
                m_nv.TenNhanVien = row.Cells[1].Value.ToString();
                m_nv.Phai = row.Cells[2].Value.ToString();
                m_nv.DiaChi = row.Cells[4].Value.ToString();
                m_nv.ChucVu = row.Cells[3].Value.ToString();
                m_nv.DienThoai = row.Cells[5].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            //cbMaNV.Text = "Chọn mã NV";
            //cbPhai.Text = "Chọn Phái";
            //cbChucVu.Text = "Chọn Chức vụ";
            
            //nv_Ctrl.HienThi(dataGridView1, bindingNavigator1);
  
        }

        
    }
}