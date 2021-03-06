using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyNhaSach.Builder_layer;
using QuanLyNhaSach.Control;


namespace QuanLyNhaSach
{
    public partial class frmPhieuNhanSach : DockContent
    {
        public frmPhieuNhanSach()
        {
            InitializeComponent();
        }
        ThongTinSachInfo ttsach;
        PhieuNhanSachInfo pn_info = new PhieuNhanSachInfo();
        NhanVienCtrl nv_Ctrl = new NhanVienCtrl();
        NhaCungCapCtrl ncc_Ctrl = new NhaCungCapCtrl();
        PhieuNhanCtrl pn_Ctrl = new PhieuNhanCtrl();
        PhieuDatCtrl pd_Ctrl = new PhieuDatCtrl();
        int capnhat = 0;
        long tongtien = 0;

        public void hienstt(ListView lv)
        {
            int soitem = lv.Items.Count;
            for (int i = 0; i < soitem; i++)
                lv.Items[i].Text = (i + 1).ToString();
        }

        private void frmPhieuNhanSach_Load(object sender, EventArgs e)
        {
            pn_Ctrl.hiethi_lv_pn(lvpn);
            //ncc.Load_ncc_lenhanghoa(comboNhaCungCap);
            ncc_Ctrl.HienThiCB(cbMaNCC);
            nv_Ctrl.HienThiCB(cbMaNV);
            pd_Ctrl.HienThiCB(cbMaPD);
            //kh.HienThi(comboKhachHang);
            txtMaPN.Text = "Mã Phiếu xuất";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmChonSach chonSach = new frmChonSach();
            DialogResult rs = chonSach.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ttsach = chonSach.ttSach;
                txtTenSach.Text = ttsach.TenSach;
            }
        }

        private void lvpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            capnhat = 1;
            txtMaPN.ReadOnly = true;
            // comboNhaCungCap.Enabled = false;
            // comboNhanVien.Enabled = false;
            txtTenSach.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";
            btnSua.Enabled = true;


            IEnumerator ie = lvpn.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                txtMaPN.Text = item.SubItems[1].Text;
                dtNgayLap.Text = item.SubItems[2].Text;
                cbMaNV.Text = item.SubItems[3].Text;
                cbMaNCC.Text = item.SubItems[5].Text;
                txtTongTien.Text = item.SubItems[7].Text;
                tongtien = Convert.ToInt32(txtTongTien.Text);
                pn_Ctrl.hiethi_lv_ctpn(lvchitiet, item.SubItems[1].Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (capnhat == 0)
                pn_Ctrl.luuphieunhan(txtMaPN.Text, dtNgayLap.Value, cbMaNV.SelectedValue.ToString(), cbMaNCC.SelectedValue.ToString(), tongtien, cbMaPD.SelectedValue.ToString());
            else
            {
                pn_Ctrl.capnhatphieunhan(txtMaPN.Text, cbMaNV.Text, cbMaNCC.Text, dtNgayLap.Value, tongtien,cbMaPD.Text);
                pn_Ctrl.xoactpn(txtMaPN.Text);
            }
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < lvchitiet.Items.Count; i++)
            {
                item = lvchitiet.Items[i];
                ChiTietPhieuNhanSachInfo ct_Info = new ChiTietPhieuNhanSachInfo();

                ct_Info = (ChiTietPhieuNhanSachInfo)item.Tag;
                pn_Ctrl.luuchitietphieunhan(txtMaPN.Text, ct_Info.sach_getset.MaSach, ct_Info.dongia_getset, ct_Info.soluong_getset, ct_Info.thanhtien_getset);

            }
            txtMaPN.Text = "Mã Phiếu Nhận";            
            lvchitiet.Items.Clear();
            txtTongTien.Text = "";
            tongtien = 0;
            capnhat = 0;
            lvpn.Items.Clear();
            pn_Ctrl.hiethi_lv_pn(lvpn);
            button4.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
                MessageBox.Show("Mã phiếu nhận không được trống");
            else
            {
                pn_info.MaPhieuNhanSach = txtMaPN.Text;
                pn_info.nhacungcap_getset.MaNhaCungCap = cbMaNCC.SelectedValue.ToString();
                pn_info.nhanvien_getset.MaNhanVien = cbMaNV.SelectedValue.ToString();
                pn_info.NgayNhan = dtNgayLap.Value;
                pn_info.phieudatsach_getset.MaPhieuDatSach = cbMaPD.SelectedValue.ToString();
                //pd_info.TongTien= Convert.ToInt64(txtTongTien.Text);
                pn_Ctrl.ThemPhieuNhan(pn_info);
                btnThem.Enabled = false;
                lvchitiet.Enabled = true;
                lvpn.Enabled = true;
                pn_Ctrl.hiethi_lv_pn(lvpn);
                txtMaPN.Enabled = false;
                txtTongTien.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //ctrl.xoapb(textMaPhieuBan.Text);
            pn_info.MaPhieuNhanSach = txtMaPN.Text;
            pn_info.nhanvien_getset.MaNhanVien = cbMaNV.SelectedValue.ToString();
            pn_info.nhacungcap_getset.MaNhaCungCap = cbMaNCC.SelectedValue.ToString();
            pn_info.NgayNhan = dtNgayLap.Value;
            pn_info.phieudatsach_getset.MaPhieuDatSach = cbMaPD.SelectedValue.ToString();
            //pb.tongtien_getset = Convert.ToInt64(textTongTien.Text);
            pn_Ctrl.hiethi_lv_pn(lvpn);
            pn_Ctrl.XoaPhieuNhan(pn_info);
            lvchitiet.Items.Clear();
            pn_Ctrl.hiethi_lv_pn(lvpn);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = true;
            txtMaPN.ReadOnly = false;
            cbMaNCC.Enabled = true;
            cbMaNV.Enabled = true;
            txtMaPN.Text = "";
            txtTongTien.Text = "0";
            cbMaNV.Text = "Chọn Mã Nhân Viên";
            cbMaNCC.Text = "Chọn Mã Nhà Cung Cấp";
            cbMaPD.Text = "Chọn Mã Phiếu đặt";
            btnThem.Enabled = true;
            lvchitiet.Enabled = false;
            lvpn.Enabled = false;
            
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtGia.Text != "" && txtSL.Text != "")
            {
                ListViewItem item = new ListViewItem();
                ChiTietPhieuNhanSachInfo ctpninfo = new ChiTietPhieuNhanSachInfo();
                ctpninfo.sach_getset = ttsach;
                ctpninfo.dongia_getset = Convert.ToInt64(txtGia.Text);
                ctpninfo.soluong_getset = Convert.ToInt32(txtSL.Text);
                ctpninfo.thanhtien_getset = (long)ctpninfo.soluong_getset * ctpninfo.dongia_getset;

                //item.SubItems.Add(pn_info.MaPhieuNhanSach);
                //item.SubItems.Add(ttsach.MaSach);
                item.SubItems.Add(ttsach.TenSach);
                item.SubItems.Add(txtGia.Text);
                item.SubItems.Add(txtSL.Text);
                item.SubItems.Add(ctpninfo.thanhtien_getset.ToString());
                tongtien += ctpninfo.thanhtien_getset;
                item.Tag = ctpninfo;
                lvchitiet.Items.Add(item);
                hienstt(lvchitiet);
                button4.Enabled = true;
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            IEnumerator ie = lvchitiet.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                long temp = Convert.ToInt64(item.SubItems[4].Text);
                tongtien -= temp;
                lvchitiet.Items.Remove(item);

            }
            hienstt(lvchitiet);
            button4.Enabled = true;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã chắc chắn thoát!", "QUANLYNHASACH", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pn_info.MaPhieuNhanSach = txtMaPN.Text;
            pn_info.nhanvien_getset.MaNhanVien = cbMaNV.SelectedValue.ToString();
            pn_info.nhacungcap_getset.MaNhaCungCap = cbMaNCC.SelectedValue.ToString();
            pn_info.NgayNhan = dtNgayLap.Value;
            //pd_info.TongTien= Convert.ToInt64(txtTongTien.Text);
            pn_info.phieudatsach_getset.MaPhieuDatSach = cbMaPD.SelectedValue.ToString();            
            pn_Ctrl.capnhatphieunhan(txtMaPN.Text, cbMaNV.Text, cbMaNCC.Text, dtNgayLap.Value, tongtien,cbMaPD.Text);
            btnThem.Enabled = false;
            lvchitiet.Enabled = true;
            lvpn.Enabled = true;
            pn_Ctrl.hiethi_lv_pn(lvpn);
            txtMaPN.Enabled = false;
            txtTongTien.Enabled = false;
            btnSua.Enabled = false;
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            frmTimPhieuNhanSach tk = new frmTimPhieuNhanSach();
            tk.ShowDialog();
            if (tk.DialogResult == DialogResult.OK)
            {
                //-- tao moi doi tuong tra ve
                PhieuNhanSachInfo pn = tk.PN;
                //--bo thong tin vao cac object                
                txtMaPN.Text = pn.MaPhieuNhanSach;
                cbMaNV.Text = pn.MaNhanVien;
                cbMaNCC.Text = pn.MaNhaCC;
                dtNgayLap.Value = pn.NgayNhan;
                //txtTongTien.te = pd.TongTien;
                cbMaPD.Text = pn.MaPhieuDatSach;
            }
        }
     
       
    }
}