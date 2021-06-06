using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using KetNoiDL;

namespace KhachSan
{
    public partial class DatTraPhong : Form
    {
        public DatTraPhong()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();
        DataView dv = new DataView();
        bool TraTruoc = false;

        private void DatTraPhong_Load(object sender, EventArgs e)
        {
            Load_ListPhong();
            Load_cmbLoaiPhong();
            Load_cmbKhachHang();
            cmbLoaiPhong.SelectedItem = cmbLoaiPhong.Items[cmbLoaiPhong.Items.Count - 1];
            
        }

        public void Load_ListPhong()
        {        
            dv = tt.getDSPhong();   
            dataGridView1.DataSource = dv;
        }

        public void Load_cmbLoaiPhong()
        {
            DataSet dv = tt.getBang("HangPhong");
            foreach (DataRow r in dv.Tables[0].Rows)
            {
                cmbLoaiPhong.Items.Add(r["LoaiPhong"].ToString());
            }
            cmbLoaiPhong.Items.Add("Tất Cả");
        }

        public void Load_cmbKhachHang()
        {
            DataSet dv = new DataSet();
            dv = tt.getBang("KhachHang");
            foreach (DataRow r in dv.Tables[0].Rows)
            {
                cmbMaKH.Items.Add(r["MaKH"].ToString());
            }
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbLoaiPhong.Text.Equals("Tất Cả"))
            {
                string s = "LoaiPhong='" + cmbLoaiPhong.Text + "'";
                dv.RowFilter = s;               
            }
            else
            {
                dv = tt.getDSPhong();
                dataGridView1.DataSource = dv;
                txtDonGia.Text = "";
                
            }
            DataGridViewRow dr = new DataGridViewRow();
            dr = dataGridView1.CurrentRow;
            txtMaPhong.Text = dr.Cells[0].Value.ToString();
            DataRow ss = tt.getDonGia(dr.Cells[1].Value.ToString());
            txtDonGia.Text = ss["DonGia"].ToString();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.CancelEdit();
            dataGridView1.EndEdit();
        }

        
        private void ckbTraTruoc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTraTruoc.Checked)
                grbTraTruoc.Enabled = true;
            else
                grbTraTruoc.Enabled = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dataGridView1.CurrentRow;
            if (dr.Cells[0].Value.ToString()!="")
            {
                txtMaPhong.Text = dr.Cells[0].Value.ToString();

                DataRow ss = tt.getDonGia(dr.Cells[1].Value.ToString());
                txtDonGia.Text = ss["DonGia"].ToString();
            }
        }

        private void ckbKhachMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhachMoi.Checked)
            {
                btnDatPhong.Enabled = false;
                grbKHMoi.Enabled = true;
                cmbMaKH.Enabled = false;
            }
            else
            {
                btnDatPhong.Enabled = false;
                grbKHMoi.Enabled = false;
                cmbMaKH.Enabled = true;
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpDenNgay_CloseUp(object sender, EventArgs e)
        {
            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show("Ngày Trả Phải Lớn Hơn Ngày Thuê");
                txtDonGia.Text = "";
                txtSoNgayThue.Text = "";
                txtTien.Text = "";
                TraTruoc = false;
            }
            else
            {
                DateTime tungay = dtpTuNgay.Value.Date;
                DateTime denngay = dtpDenNgay.Value.Date;
                string s = denngay - tungay + "";                
                string[] tt= s.Split('.');
                txtSoNgayThue.Text = tt[0];//(dtpDenNgay.Value.Date - dtpTuNgay.Value.Date)+"";
                txtTien.Text = (Convert.ToInt32(txtSoNgayThue.Text) * Convert.ToInt32(txtDonGia.Text))+"";
                TraTruoc = true;
            }
        }

        public bool KTmaKH(string ma)
        {
            if (tt.KTmaKH(ma) == false)
            {
                MessageBox.Show("Đã Có Mã Khách Hàng Này");
                return false;
            }
            if (txtMaKH.Text.Trim() == "" || txtMaKH.Text.Length > 50
                || txtTenKH.Text.Trim() == "" || txtTenKH.Text.Length > 50
                || txtCMND.Text.Trim() == "" || txtCMND.Text.Length > 50
                || txtSDT.Text.Trim() == "" || txtSDT.Text.Length > 50
                || txtDC.Text.Trim() == "" || txtDC.Text.Length > 50)
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                return false;
            }
            return true;

        }

        public bool KTMAHD()
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã hóa đơn");
                return false;
            }
            if (tt.KTHoaDon(txtMaHD.Text) == false)
            {
                MessageBox.Show("Đã có mã HD này");
                return false;
            }
            if (tt.KTCTHoaDon(txtMaHD.Text,txtMaPhong.Text,cmbMaKH.Text)==false)
            {
                MessageBox.Show("Đã có mã CTHD này");
                return false;
            }
            if (cmbMaKH.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
                return false;
            }
            if (tt.KTHDTT(txtMaHD.Text) == false)
            {
                MessageBox.Show("HD này đã thanh toán tiền");
                return false;
            }
            return true;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (KTMAHD())
            {
                tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text);
                if (ckbTraTruoc.Checked && TraTruoc == true)                
                    tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text, dtpDenNgay.Text);
                tt.ThemChiTietHoaDon(txtMaHD.Text, cmbMaKH.Text, txtMaPhong.Text);

                DataGridViewRow dr = new DataGridViewRow();
                dr = dataGridView1.CurrentRow;

                tt.UpdatePhong(txtMaPhong.Text, false);
                Load_ListPhong();
                cmbLoaiPhong.SelectedItem = cmbLoaiPhong.Items[cmbLoaiPhong.Items.Count - 1];
            

                MessageBox.Show("Đã Đặt Phòng");
            }
            

            //if (KTMAHD() == true && cmbMaKH.Text != "")
            //{
            //    if (ckbKhachMoi.Checked)
            //    {
            //        if (tt.KTmaKH(txtMaKH.Text))
            //        {
            //            tt.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDC.Text);
            //            Load_cmbKhachHang();
            //            if (ckbTraTruoc.Checked && TraTruoc == true)
            //            {
            //                if (tt.KTmaHD(txtMaHD.Text))
            //                    tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text, dtpDenNgay.Text);
            //                tt.ThemChiTietHoaDon(txtMaHD.Text, txtMaKH.Text, txtMaPhong.Text);
            //                MessageBox.Show("Thêm Thành Công");
            //                btnInHD.Enabled = true;

            //            }
            //            else
            //            {
            //                if (tt.KTmaHD(txtMaHD.Text))
            //                {
            //                    tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text);
            //                    MessageBox.Show("Thêm Thành Công");
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (ckbTraTruoc.Checked && TraTruoc == true)
            //        {
            //            if (tt.KTmaHD(txtMaHD.Text))
            //                tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text, dtpDenNgay.Text);
            //            tt.ThemChiTietHoaDon(txtMaHD.Text, cmbMaKH.Text, txtMaPhong.Text);
            //            MessageBox.Show("Thêm Thành Công");
            //            btnInHD.Enabled = true;

            //        }
            //        else
            //        {
            //            if (tt.KTmaHD(txtMaHD.Text))
            //            {
            //                tt.ThemHoaDon(txtMaHD.Text, dtpTuNgay.Text);
            //                MessageBox.Show("Thêm Thành Công");
            //            }
            //        }
            //    }
            //}
            //else
            //    MessageBox.Show("Thêm Không Thành Công");
        }

        DataTable tb;

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Load_ListPhong();
            Load_cmbLoaiPhong();
            Load_cmbKhachHang();
            cmbLoaiPhong.SelectedItem = cmbLoaiPhong.Items[cmbLoaiPhong.Items.Count - 1];

            DataView dv2 = tt.getDataView("HoaDon");
            dataGridView2.DataSource = dv2;
            dv2.RowFilter = "NgayTra is null";

            tb = tt.getBang("TraPhong").Tables[0];
            DataGridViewRow dtr = dataGridView2.CurrentRow;
            string mahd = dtr.Cells[0].Value.ToString();

            foreach (DataRow r in tb.Rows)
            {
                if (mahd == r["MaHD"].ToString())
                {
                    txtTraPMaP.Text = r["MaPhong"].ToString();
                    txtTraPLoaiP.Text = r["LoaiPhong"].ToString();
                    txtTraPMaKH.Text = r["MaKH"].ToString();
                    txtTraTuNgay.Text = r["NgayThue"].ToString();
                    txtTraDG.Text = r["DonGia"].ToString();
                }
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dtr = dataGridView2.CurrentRow;
            string mahd = dtr.Cells[0].Value.ToString();

            foreach (DataRow r in tb.Rows)
            {
                if (mahd == r["MaHD"].ToString())
                {
                    txtTraPMaP.Text = r["MaPhong"].ToString();
                    txtTraPLoaiP.Text = r["LoaiPhong"].ToString();
                    txtTraPMaKH.Text = r["MaKH"].ToString();
                    txtTraTuNgay.Text = r["NgayThue"].ToString();
                    txtTraDG.Text = r["DonGia"].ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tt.KTmaKH(txtMaKH.Text))
            {
                tt.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtSDT.Text, txtDC.Text);
                MessageBox.Show("Đã Thêm");
                Load_cmbKhachHang();
                grbKHMoi.Enabled = false;
                btnDatPhong.Enabled = true;
                cmbMaKH.Enabled = true;

                txtMaKH.Text = "";
                txtTenKH.Text = ""; txtCMND.Text = ""; txtDC.Text = ""; txtSDT.Text = "";
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if (dtpTraPDenNgay.Value < Convert.ToDateTime(txtTraTuNgay.Text))
            {
                MessageBox.Show("Ngày Trả Phải Lớn Hơn Ngày Thuê");
                txtTraDG.Text = "";
                txtTraSongaythue.Text = "";
                txtTraTien.Text = "";
            }
            else
            {
                DateTime tungay = Convert.ToDateTime(txtTraTuNgay.Text);
                DateTime denngay = dtpTraPDenNgay.Value.Date;
                string s = denngay - tungay + "";
                string[] tt = s.Split('.');
                txtTraSongaythue.Text = tt[0];//(dtpDenNgay.Value.Date - dtpTuNgay.Value.Date)+"";
                txtTraTien.Text = (Convert.ToInt32(txtTraSongaythue.Text) * Convert.ToInt32(txtTraDG.Text)) + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTraTien.Text != "")
            {
                DataGridViewRow dtr = dataGridView2.CurrentRow;
                tt.UpdateCTHoaDon(dtr.Cells[0].Value.ToString(), dtpTraPDenNgay.Value);
                tt.UpdatePhong(txtTraPMaP.Text, true);

                DataView dv2 = tt.getDataView("HoaDon");
                dataGridView2.DataSource = dv2;
                dv2.RowFilter = "NgayTra is null";

                tb = tt.getBang("TraPhong").Tables[0];
                dtr = dataGridView2.CurrentRow;
                string mahd = dtr.Cells[0].Value.ToString();

                foreach (DataRow r in tb.Rows)
                {
                    if (mahd == r["MaHD"].ToString())
                    {
                        txtTraPMaP.Text = r["MaPhong"].ToString();
                        txtTraPLoaiP.Text = r["LoaiPhong"].ToString();
                        txtTraPMaKH.Text = r["MaKH"].ToString();
                        txtTraTuNgay.Text = r["NgayThue"].ToString();
                        txtTraDG.Text = r["DonGia"].ToString();
                    }
                }
            }
        }     
    }
}