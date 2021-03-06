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
    public partial class frmTimSachTon : Form
    {
        TonKhoCtrl tk_Ctrl = new TonKhoCtrl();
        TonKhoInfo tk_Info = new TonKhoInfo();

        private TonKhoInfo m_tk;
        public TonKhoInfo TONKHO
        {
            get { return m_tk; }
            set { m_tk = value; }
        }
        public frmTimSachTon()
        {
            InitializeComponent();
            tk_Ctrl.LoadComboBox(cbMaSach, "MASACH", "MASACH");
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tk_Ctrl.TimSachTon(cbMaSach, dataGridView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();

            if (ie.MoveNext())
            {
                DataGridViewRow row = (DataGridViewRow)ie.Current;
                m_tk = new TonKhoInfo();
                m_tk.MaSach = row.Cells[0].Value.ToString();
                m_tk.Thang = row.Cells[1].Value.ToString();
                m_tk.Nam= row.Cells[2].Value.ToString();
                m_tk.DonGia = row.Cells[4].Value.ToString();
                m_tk.TongNhap = row.Cells[3].Value.ToString();
                m_tk.TongXuat = row.Cells[5].Value.ToString();
                m_tk.TonDauKy = row.Cells[6].Value.ToString();
                m_tk.TonCuoiKy = row.Cells[7].Value.ToString();
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

        private void frmTimSachTon_Load(object sender, EventArgs e)
        {
            cbMaSach.Text = "Chọn mã sách";
            tk_Ctrl.HienThi(dataGridView1, bindingNavigator1);
        }
    }
}