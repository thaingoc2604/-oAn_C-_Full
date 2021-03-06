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
    public partial class frmTimPhieuNhanSach : Form
    {
        PhieuNhanCtrl pn_Ctrl = new PhieuNhanCtrl();
        private PhieuNhanSachInfo m_PN;
        public PhieuNhanSachInfo PN
        {
            get { return m_PN; }

        }

        public frmTimPhieuNhanSach()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimPhieuNhanSach tim = new frmTimPhieuNhanSach();
            tim.dataGridView1.DataBindings.Clear();
            pn_Ctrl.timPhieuNhanSach(txtMaPN, cbChonMaNV, txtMaNV, cbChonNCC, txtMaNCC, cbChonNgay, dtTuNgay, dtDenNgay, dataGridView1);
            toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTimPhieuNhanSach timPN = new frmTimPhieuNhanSach();
            timPN.dataGridView1.Columns.Clear();
            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();
            m_PN = new PhieuNhanSachInfo();
            if (ie.MoveNext())
            {
                DataGridViewRow row = (DataGridViewRow)ie.Current;
                m_PN = new PhieuNhanSachInfo();
                //MessageBox.Show(m_PD.MaPhieuDatSach);
                m_PN.MaPhieuNhanSach = row.Cells[0].Value.ToString();
                //MessageBox.Show(m_PD.MaNhanVien);
                m_PN.MaNhanVien = row.Cells[1].Value.ToString();
                m_PN.MaNhaCC = row.Cells[2].Value.ToString();
                //m_PD.TongTien = Convert.ToInt64(row.Cells[3].Value.ToString());
                m_PN.NgayNhan = Convert.ToDateTime(row.Cells[3].Value.ToString());
                m_PN.MaPhieuDatSach = row.Cells[5].Value.ToString();
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