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
using QuanLyNhaSach.Builder_layer;
using QuanLyNhaSach.Data;

namespace QuanLyNhaSach
{
    public partial class frmTimPhieuXuatSach : Form
    {
        PhieuXuatCtrl px_Ctrl = new PhieuXuatCtrl();
        private PhieuXuatSachInfo m_PX;
        public PhieuXuatSachInfo PX
        {
            get { return m_PX; }

        }
        public frmTimPhieuXuatSach()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimPhieuXuatSach tim = new frmTimPhieuXuatSach();
            tim.dataGridView1.DataBindings.Clear();
            px_Ctrl.timPhieuXuatSach(txtMaPX, cbChonMaNV, txtMaNV, cbChonNCC, txtMaKH, cbChonNgay, dtTuNgay, dtDenNgay, dataGridView1);
            toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTimPhieuXuatSach timPX = new frmTimPhieuXuatSach();
            timPX.dataGridView1.Columns.Clear();
            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();
            m_PX = new PhieuXuatSachInfo();
            if (ie.MoveNext())
            {
                DataGridViewRow row = (DataGridViewRow)ie.Current;
                m_PX = new PhieuXuatSachInfo();
                //MessageBox.Show(m_PD.MaPhieuDatSach);
                m_PX.MaPhieuXuatSach = row.Cells[0].Value.ToString();
                //MessageBox.Show(m_PD.MaNhanVien);
                m_PX.MaNhanVien = row.Cells[1].Value.ToString();
                m_PX.MaKhachHang = row.Cells[2].Value.ToString();
                m_PX.NgayLap = Convert.ToDateTime(row.Cells[3].Value.ToString());
                //m_PX.TongTien = Convert.ToInt64(row.Cells[4].Value.ToString());
                
            }
            this.DialogResult = DialogResult.OK;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
    }
}