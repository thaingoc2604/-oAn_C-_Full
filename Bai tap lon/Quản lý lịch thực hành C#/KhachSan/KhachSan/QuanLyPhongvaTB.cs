using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KetNoiDL;
using System.Data.OleDb;

namespace KhachSan
{
    public partial class QuanLyPhongvaTB : Form
    {
        public QuanLyPhongvaTB()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();
        string temDonGia,temGia,temTen,temHangSX;
        string temSoNguoi, temLoaip, temTinhtrang;

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            Load_HangP();
            Load_ThietBi();
        }

        public bool KTThayDoi(string s1,string s2)//True: co su thay doi, false: ko co
        {
            if (s1.Equals(s2))
                return false;
            return true;
        }

#region HangPhong
        public void Load_HangP()
        {
            lvwLoaiPhong.Items.Clear();
            OleDbDataReader da = tt.getDataReader("HangPhong");
            while (da.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = da["LoaiPhong"].ToString();
                i.SubItems.Add(da["DonGia"].ToString());

                lvwLoaiPhong.Items.Add(i);
            }

            if (lvwLoaiPhong.Items.Count > 0)
            {
                txtLoaiPhong.Text = lvwLoaiPhong.Items[0].SubItems[0].Text;
                txtDonGia.Text = lvwLoaiPhong.Items[0].SubItems[1].Text;

                temDonGia = txtDonGia.Text;
            }
        }

        private void lvwLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (btnThemHP.Text == "Thêm Hạng Phòng")
            {
                if (KTThayDoi(txtDonGia.Text, temDonGia) == true)
                {
                    temDonGia = txtDonGia.Text;
                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn lưu thông tin vừa thay đổi?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        try
                        {
                            Convert.ToDouble(txtDonGia.Text);
                            if (txtLoaiPhong.Text.Trim() == "" || txtLoaiPhong.Text.Length > 50)
                                MessageBox.Show("Chưa Nhập Hạng Phòng Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                            else
                            {
                                tt.UpdateHangPhong(txtLoaiPhong.Text, txtDonGia.Text);
                                Load_HangP();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đơn giá phải là số");
                            txtDonGia.Focus();
                        }                       
                    }
                }
            }
            foreach (ListViewItem i in lvwLoaiPhong.SelectedItems)
            {
                txtLoaiPhong.Text = i.Text;
                txtDonGia.Text = i.SubItems[1].Text;

                btnThemHP.Text = "Thêm Hạng Phòng";
                txtLoaiPhong.Enabled = false;
                temDonGia = txtDonGia.Text;
            }
        }

        public bool KTHangPhong()
        {
            try
            {
                Convert.ToDouble(txtDonGia.Text);
                if (tt.KiemTraHangPhong(txtLoaiPhong.Text) == false)
                {
                    MessageBox.Show("Đã Có Hạng Phòng Này");
                    return false;
                }
                if (txtLoaiPhong.Text.Trim() == "" || txtLoaiPhong.Text.Length>50)
                {
                    MessageBox.Show("Chưa Nhập Hạng Phòng Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                    return false;
                }
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Đơn giá phải là số");
                txtDonGia.Focus();
                return false;
            }
        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            if (btnThemHP.Text.Equals("Thêm Hạng Phòng"))
            {
                txtLoaiPhong.Text = "";
                txtDonGia.Text = "";

                btnThemHP.Text = "Lưu";
                txtLoaiPhong.Enabled = true;
                txtLoaiPhong.Focus();
            }
            else
            {
                if (KTHangPhong() == true)
                {
                    tt.ThemHangPhong(txtLoaiPhong.Text, Convert.ToDouble(txtDonGia.Text));
                    Load_HangP();

                    btnThemHP.Text = "Thêm Hạng Phòng";
                    txtLoaiPhong.Enabled = false;
                }
            }
        }

        private void btnXoaHP_Click(object sender, EventArgs e)
        {
            if (btnThemHP.Text == "Lưu" || lvwLoaiPhong.SelectedItems.Count < 1)
                MessageBox.Show("Chưa Chọn Hạng Phòng Cần Xóa");
            else
            {
                DialogResult d = MessageBox.Show("Xóa Dữ Liệu Này Có Thể Gây Mất Dữ Liệu Ở Bảng Khác \n Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (btnThemHP.Text == "Thêm Hạng Phòng")
                    {
                        tt.XoaHangPhong(txtLoaiPhong.Text);
                        Load_HangP();
                    }
                }
            }
        }
#endregion HangPhong

#region ThietBi
        public void Load_ThietBi()
        {
            lvwThietBi.Items.Clear();
            OleDbDataReader da = tt.getDataReader("ThietBi");
            while (da.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = da["MaTB"].ToString();
                i.SubItems.Add(da["Ten"].ToString());
                i.SubItems.Add(da["HangSX"].ToString());
                i.SubItems.Add(da["Gia"].ToString());

                lvwThietBi.Items.Add(i);
            }

            if (lvwThietBi.Items.Count > 0)
            {
                txtMaTB.Text = lvwThietBi.Items[0].SubItems[0].Text;
                txtTen.Text = lvwThietBi.Items[0].SubItems[1].Text;
                txtHangSX.Text = lvwThietBi.Items[0].SubItems[2].Text;
                txtGia.Text = lvwThietBi.Items[0].SubItems[3].Text;

                temGia = txtGia.Text;
                temHangSX = txtHangSX.Text;
                temTen = txtTen.Text;
            }
        }

        private void lvwThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (btnThemTB.Text == "Thêm Thiết Bị")
            {
                if (KTThayDoi(txtTen.Text,temTen) == true || KTThayDoi(txtGia.Text,temGia) == true ||KTThayDoi(txtHangSX.Text,temHangSX) == true)
                {
                    temGia = txtGia.Text;
                    temHangSX = txtHangSX.Text;
                    temTen = txtTen.Text;

                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn lưu thông tin vừa thay đổi?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes && KTRong()==true)
                    {
                        try
                        {
                            Convert.ToDouble(txtGia.Text);
                            if (txtMaTB.Text.Trim() == "" || txtMaTB.Text.Length > 50 ||
                               txtTen.Text.Trim() == "" || txtTen.Text.Length > 50 ||
                               txtHangSX.Text.Trim() == "" || txtHangSX.Text.Length > 50)
                                MessageBox.Show("Chưa Nhập Đủ Thông Tin Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                            else
                            {
                                tt.UpdateThietBi(txtMaTB.Text, txtTen.Text, txtHangSX.Text, txtGia.Text);
                                Load_ThietBi();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Giá Thiết Bị Phải Nhập Số");
                        }
                        
                    }
                }
            }

            foreach (ListViewItem i in lvwThietBi.SelectedItems)
            {
                txtMaTB.Text = i.Text;
                txtTen.Text = i.SubItems[1].Text;
                txtHangSX.Text = i.SubItems[2].Text;
                txtGia.Text = i.SubItems[3].Text;

                btnThemTB.Text = "Thêm Thiết Bị";
                txtMaTB.Enabled = false;

                temGia = txtGia.Text;
                temHangSX = txtHangSX.Text;
                temTen = txtTen.Text;
            }

        }

        public bool KTMaTB()
        {
            try
            {
                Convert.ToDouble(txtGia.Text);
                if (tt.KiemTraMaTB(txtMaTB.Text) == false)
                {
                    MessageBox.Show("Đã Có Mã Thiết Bị Này");
                    return false;
                }
                
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Giá Thiết Bị Phải Nhập Số");
                txtGia.Focus();
                return true;
            }
        }

        public bool KTRong()
        {
            if (txtMaTB.Text.Trim() == "" || txtMaTB.Text.Length > 50 ||
                               txtTen.Text.Trim() == "" || txtTen.Text.Length > 50 ||
                               txtHangSX.Text.Trim() == "" || txtHangSX.Text.Length > 50)
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin Hoặc Nhập Quá Nhiều Kí Tự (<50)");
                return false;
            }
            return true;
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            if (btnThemTB.Text.Equals("Thêm Thiết Bị"))
            {
                txtMaTB.Text = "";
                txtTen.Text = "";
                txtHangSX.Text = "";
                txtGia.Text = "";


                btnThemTB.Text = "Lưu";
                txtMaTB.Enabled = true;
                txtMaTB.Focus();
            }
            else
            {
                if (KTMaTB() == true && KTRong()==true)
                {
                    tt.ThemThietBi(txtMaTB.Text, txtTen.Text, txtHangSX.Text, Convert.ToDouble(txtGia.Text));
                    Load_ThietBi();

                    btnThemTB.Text = "Thêm Thiết Bị";
                    txtMaTB.Enabled = false;
                }
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if (btnThemTB.Text == "Lưu" || lvwThietBi.SelectedItems.Count < 1)
                MessageBox.Show("Chưa Chọn Hạng Phòng Cần Xóa");
            else
            {
                DialogResult d = MessageBox.Show("Xóa Dữ Liệu Này Có Thể Gây Mất Dữ Liệu Ở Bảng Khác \n Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (btnThemTB.Text == "Thêm Thiết Bị")
                    {
                        tt.XoaThietBi(txtMaTB.Text);
                        Load_ThietBi();
                    }
                }
            }
        }
        #endregion ThietBi

#region Phong                                  
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DataTable tb = tt.getBang("HangPhong").Tables[0];
            
            cmbQLPLoaiP.Items.Clear();                     
            foreach (DataRow r in tb.Rows)
            {
                cmbQLPLoaiP.Items.Add(r["LoaiPhong"].ToString());
            }

            Load_Phong();
        }

        public void Load_Phong()
        {
            listView1.Items.Clear();
            DataTable phong = tt.getBang("Phong").Tables[0];
            foreach (DataRow r in phong.Rows)
            {
                ListViewItem i = new ListViewItem();
                i.Text = r["MaPhong"].ToString();
                i.SubItems.Add(r["LoaiPhong"].ToString());
                i.SubItems.Add(r["SoNguoi"].ToString());
                i.SubItems.Add(((bool)r["TinhTrang"] == true) ? "Trống" : "Đầy");

                listView1.Items.Add(i);
            }
            if (listView1.Items.Count > 0)
            {
                txtQLPMaP.Text = listView1.Items[0].SubItems[0].Text;
                cmbQLPLoaiP.Text = listView1.Items[0].SubItems[1].Text;
                txtQLPSoNguoi.Text = listView1.Items[0].SubItems[2].Text;
                cmbQLPTinhTrang.Text = listView1.Items[0].SubItems[3].Text;

                temSoNguoi = txtQLPSoNguoi.Text;
                temTinhtrang= cmbQLPTinhTrang.Text;
                temLoaip= cmbQLPLoaiP.Text;
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnTPhong.Text == "Thêm Phòng")
            {
                if (KTThayDoi(txtQLPSoNguoi.Text, temSoNguoi) == true || KTThayDoi(cmbQLPTinhTrang.Text, temTinhtrang) == true || KTThayDoi(cmbQLPLoaiP.Text, temLoaip) == true)
                {
                    temSoNguoi = txtQLPSoNguoi.Text;
                    temTinhtrang = cmbQLPTinhTrang.Text;
                    temLoaip = cmbQLPLoaiP.Text;

                    DialogResult d;
                    d = MessageBox.Show("Bạn có muốn lưu thông tin vừa thay đổi?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes && KTRong() == true)
                    {
                        try
                        {
                            Convert.ToInt32(txtQLPSoNguoi.Text);
                            if (txtMaTB.Text.Trim() == "" ||txtTen.Text.Trim() == "" || txtHangSX.Text.Trim() == "")
                                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
                            else
                            {
                                tt.UpdatePhong(txtQLPMaP.Text, cmbQLPLoaiP.Text, Convert.ToInt32(txtQLPSoNguoi.Text), cmbQLPTinhTrang.Text == "Trống" ? true : false);
                                Load_Phong();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Số Người Phải Nhập Số");
                        }

                    }
                }
            }
           
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                txtQLPMaP.Text = i.SubItems[0].Text;
                cmbQLPLoaiP.Text = i.SubItems[1].Text;
                txtQLPSoNguoi.Text = i.SubItems[2].Text;
                cmbQLPTinhTrang.Text = i.SubItems[3].Text;

                temSoNguoi = txtQLPSoNguoi.Text;
                temTinhtrang = cmbQLPTinhTrang.Text;
                temLoaip = cmbQLPLoaiP.Text;
            }
        }

        public bool KTPhong()
        {
            try
            {
                Convert.ToInt32(txtQLPSoNguoi.Text);
                if (txtQLPMaP.Text.Trim() == "" || txtQLPSoNguoi.Text.Trim() == "" 
                    || cmbQLPLoaiP.Text=="" || cmbQLPTinhTrang.Text=="")
                {
                    MessageBox.Show("Chưa nhập đử thông tin");
                    return false;
                }
                if (tt.KiemTraMaPhong(txtQLPMaP.Text) == false)
                {
                    MessageBox.Show("Đã có mã phòng này");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Số Người Phải Nhập Số");
                return false;
            }
        }

        private void btnTPhong_Click(object sender, EventArgs e)
        {
            if (btnTPhong.Text == "Thêm Phòng")
            {
                btnTPhong.Text = "Lưu";
                txtQLPSoNguoi.Text = "";
                txtQLPMaP.Text = "";
                cmbQLPTinhTrang.Text = "";
                cmbQLPLoaiP.Text = "";
            }
            else
            {
                if (KTPhong())
                {
                    tt.ThemPhong(txtQLPMaP.Text, cmbQLPLoaiP.Text, Convert.ToInt32(txtQLPSoNguoi.Text), cmbQLPTinhTrang.Text == "Trống" ? true : false);
                    Load_Phong();
                    btnTPhong.Text = "Thêm Phòng";
                }
            }
        }
        
        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (btnTPhong.Text == "Lưu" || listView1.SelectedItems.Count < 1)
                MessageBox.Show("Chưa Chọn Phòng Cần Xóa");
            else
            {
                DialogResult d = MessageBox.Show("Xóa Dữ Liệu Này Có Thể Gây Mất Dữ Liệu Ở Bảng Khác \n Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (btnTPhong.Text == "Thêm Phòng")
                    {
                        tt.XoaPhong(txtQLPMaP.Text);
                        Load_Phong();
                    }
                }
            }
        }
#endregion Phong        

        

        

        
    }
}