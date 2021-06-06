using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DETAI
{
    public partial class frmQTDieuDong : Form
    {
        //khai báo biến toàn cục
        clsDMTo cTo = new clsDMTo();
        clsdmpb cPhong = new clsdmpb();
        clsnhanvien cnhanvien = new clsnhanvien();
        clsdmchucvu cchucvu = new clsdmchucvu();
        clsdieudong cdieudong = new clsdieudong();
        clsctkyluatkhenthuong cklkt = new clsctkyluatkhenthuong();
        int kklkt; // biến ghi nhận trạng thái lưu hay cập nhật cho tab khen thưởng
        int kdd;// biến ghi nhận trạng thái để biết thêm mới hay cập nhật
        public frmQTDieuDong()
        {
            InitializeComponent();
            cboPhong.DataSource = cPhong.taocombo();
            cboPhong.DisplayMember = "tbl_PhongBan.TenPhong";
            cboPhong.ValueMember = "tbl_PhongBan.MaPhong";
            cboklloai.DataSource = cklkt.layloai();
            cboklloai.DisplayMember = "DMKTKL.TenLoai";
            cboklloai.ValueMember = "DMKTKL.maloai";
            cboklloai.Text = "";
        }

        private void frmQTDieuDong_Load(object sender, EventArgs e)
        {
            setcontroldd(false);
            setcmddd(true);
            setcontrolgrpthongtin(false);
            setcmdkl(true);
            setcontrolgrpklthongtin(false);
            setcontrolgrpnoidung(false);
            kdd =0;
            kklkt = 0;
        }
        //làm rổng các control trong các group
        private void lamrong()
        {
            foreach (Control c in grpklthongtin.Controls)
                if(c.Name.Contains("txt")==true ||c.Name.Contains("cbo")==true)
                    c.Text = "";
            foreach (Control c in grpthongtin.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
            foreach (Control c in grpdieudong.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
            foreach (Control c in grphientai.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
            foreach (Control c in grpnoidung.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
                    
        }
        //
        //list nhân viên
        //

            //hiển thị listNV
        public void HienThiListNV(DataTable dt, ListView lv)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MaNV"].ToString();
                item.SubItems.Add(row["Ho"].ToString());
                item.SubItems.Add(row["Ten"].ToString());
                lv.Items.Add(item);
            }
        }

        private void lstNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = lstNhanvien.FocusedItem.SubItems[0].Text;
            string ho = lstNhanvien.FocusedItem.SubItems[1].Text;
            string ten = lstNhanvien.FocusedItem.SubItems[2].Text;
            txtddmanv.Text = ma;
            txtddhotennv.Text = ho + " " + ten;
            txtklmanv.Text = ma;
            txtklhotennv.Text = ho + " " + ten;
            HienTTNVhientai(ma);
            HienThiTTNVKTKL(ma);
            lamrongttgrpdd();
            grphientai.Text  = "Hiện Tại";
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTo.DataSource = cTo.taocombo(cboPhong.SelectedValue.ToString());
            cboTo.DisplayMember = "DanhMucTo.TenTo";
            cboTo.ValueMember = "DanhMucTo.MaTo";
            cboTo.Text = "";
            lamrong();
            lstNhanvien.Items.Clear();
            HienThiListNV(cPhong.laydlList(cboPhong.SelectedValue.ToString()), lstNhanvien);
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lamrong();
            lstNhanvien.Items.Clear();
            HienThiListNV(cTo.laydlList(cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString()), lstNhanvien);            
        }

        private void setlist(bool b)
        {
            lstNhanvien.Enabled = b;
            cboPhong.Enabled = b;
            cboTo.Enabled = b;
        }

        //
        //tab điều động
        //

        //set control trong tab điều động
        private void setcontroldd(bool b)
        {
            
            foreach (Control c in grpdieudong.Controls)
            {
                if (c.Name.Contains("txtdd") == true ||c.Name.Contains("cbodd")==true)
                {
                    c.Enabled = b;
                }
            }
        }
        private void lamrongttgrpdd()
        {
            foreach (Control c in grpdieudong.Controls)
            {
                if (c.Name.Contains("txtdd") == true || c.Name.Contains("cbodd") == true)
                {
                    c.Text = "";
                }
            }
            txtddsoqd.Text = "";
            txtddngayqd.Text = "";
        }
        //set control trong grpthongtin
        private void setcontrolgrpthongtin(bool b)
        {
            txtddngayqd.Enabled = b;
            txtddsoqd.Enabled = b;
        }
        //tạo thông tin trong tab điều động
        private void taocombodd()
        {
            //Đưa dữ liệu vào combo Chức Vụ Mới
            cboddcvmoi.DataSource = cchucvu.taocombo();
            cboddcvmoi.DisplayMember = "DMChucVu.TenChucVu";
            cboddcvmoi.ValueMember = "DMChucVu.MaChucVu";
            //Đưa dữ liệu vào combo Phòng ban Mới
            cboddpbmoi.DataSource = cPhong.taocombo();
            cboddpbmoi.DisplayMember = "tbl_PhongBan.TenPhong";
            cboddpbmoi.ValueMember = "tbl_PhongBan.MaPhong";
        }

        private void cboddpbmoi_Leave(object sender, EventArgs e)
        {
            cboddtomoi.DataSource = cTo.taocombo(cboddpbmoi.SelectedValue.ToString());
            cboddtomoi.DisplayMember = "DanhMucTo.TenTo";
            cboddtomoi.ValueMember = "DanhMucTo.MaTo";
        }

        private void HienTTNVhientai(string ma)
        {
            cnhanvien.laydl(ma);
            //lấy dữ liệu đưa vào các textbox
            txtddcvcu.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["TenChucVu"].ToString();
            txtddpbcu.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["TenPhong"].ToString();
            txtddtocu.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["TenTo"].ToString();
            dgv_dieudong.DataSource = cdieudong.laydl(ma);
            dgv_dieudong.DataMember = "DieuDong";
            
        }

        private void setcmddd(bool b)
        {
            cmdluu.Enabled  =!b;
            cmdthem.Enabled =b;
            cmdCapnhat.Enabled =b;
            cmdxoa .Enabled =b;

        }

        private void dgv_dieudong_Click(object sender, EventArgs e)
        {
            grphientai.Text = "Trước Khi Điều Động";

            DataGridViewRow row = dgv_dieudong.CurrentRow;
            if (row != null)
            {
                //hiển thị dữ liệu theo từng dòng điều động
                txtddsoqd.Text = Convert.ToString(row.Cells[0].Value);
                txtddngayqd.Text= mysql.NgayToString(Convert.ToString(row.Cells[2].Value));
                txtddcvcu.Text = cchucvu.laytenCV(Convert.ToString(row.Cells[3].Value));
                txtddpbcu.Text = cPhong.laytenPB(Convert.ToString(row.Cells[4].Value));
                txtddtocu.Text = cTo.laytenTo(Convert.ToString(row.Cells[5].Value));
                
                cboddcvmoi.Text = cchucvu.laytenCV(Convert.ToString(row.Cells[6].Value));
                
                cboddpbmoi.Text = cPhong.laytenPB(Convert.ToString(row.Cells[7].Value));
                
                cboddtomoi.Text = cTo.laytenTo(Convert.ToString(row.Cells[8].Value));
                txtddghichu.Text=Convert.ToString(row.Cells[9].Value);

            }
            
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            if (txtddmanv.Text != "")
            {
                taocombodd();
                setcontrolgrpthongtin(true);
                setcontroldd(true);
                txtddsoqd.Text = "";
                txtddngayqd.Text = mysql.NgayToString(DateTime.Today.ToString());
                txtddghichu.Text = "";
                setlist(false);
                setcmddd(false);
                txtddsoqd.Focus();
                kdd = 1;
            }
            else
                MessageBox.Show("Bạn phải chọn nhân viên muốn điều động", "Thông báo");
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            cnhanvien.laydl(txtddmanv.Text.Trim());
            if (txtddsoqd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số quyết định", "Thông Báo");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn lưu thông tin này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (kdd == 1)
                    {
                        if (cboddtomoi.SelectedValue != null)
                        {
                            cdieudong.them(txtddsoqd.Text.Trim(),
                                        txtddmanv.Text.Trim(),
                                        mysql.TraVeNgay(txtddngayqd.Text.Trim(), 1),
                                        int.Parse(cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaChucVu"].ToString()),
                                        cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaPhong"].ToString(),
                                        cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaTo"].ToString(),
                                        int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                        cboddpbmoi.SelectedValue.ToString(),
                                        cboddtomoi.SelectedValue.ToString(),
                                        txtddghichu.Text.Trim());
                            mysql.ExecuteNonQuery("Update_Tbl_NhanVien_Dieudong",
                                       CommandType.StoredProcedure,
                                       "@manv_1", txtddmanv.Text.Trim(),
                                       "@machucvu_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                       "@maphong_3", cboddpbmoi.SelectedValue.ToString(),
                                       "@mato_4", cboddtomoi.SelectedValue.ToString());                           
                        }
                        else
                        {
                            cdieudong.them(txtddsoqd.Text.Trim(),
                                        txtddmanv.Text.Trim(),
                                        mysql.TraVeNgay(txtddngayqd.Text.Trim(), 1),
                                        int.Parse(cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaChucVu"].ToString()),
                                        cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaPhong"].ToString(),
                                        cnhanvien.ds.Tables["NhanVien"].Rows[0]["MaTo"].ToString(),
                                        int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                        cboddpbmoi.SelectedValue.ToString(),
                                        txtddghichu.Text.Trim());
                            mysql.ExecuteNonQuery("Update_Tbl_NhanVien_Dieudong_koTo", 
                                       CommandType.StoredProcedure,
                                       "@manv_1", txtddmanv.Text.Trim(),
                                       "@machucvu_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                       "@MaPhong_3", cboddpbmoi.SelectedValue.ToString());                            
                        }
                    }
                    else if (kdd == 2)
                    {
                        if (cboddtomoi.SelectedValue != null)
                        {
                            mysql.ExecuteNonQuery("Update_tbl_QuaTrinhDieuDong", CommandType.StoredProcedure,
                                               "@SoQD_1", txtddmanv.Text.Trim(),
                                               "@MaCVmoi_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                               "@MaPBmoi_3", cboddpbmoi.SelectedValue.ToString(),
                                               "@Matomoi_4", cboddtomoi.SelectedValue.ToString(),
                                               "@GhiChu_5", txtddghichu.Text.Trim());
                            mysql.ExecuteNonQuery("Update_Tbl_NhanVien_Dieudong",
                                       CommandType.StoredProcedure,
                                       "@manv_1", txtddmanv.Text.Trim(),
                                       "@machucvu_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                       "@maphong_3", cboddpbmoi.SelectedValue.ToString(),
                                       "@mato_4", cboddtomoi.SelectedValue.ToString());
                        }
                        else
                        {
                            mysql.ExecuteNonQuery("Update_tbl_QuaTrinhDieuDong_KoTo",
                                               CommandType.StoredProcedure,
                                               "@SoQD_1", txtddmanv.Text.Trim(),
                                               "@MaCVmoi_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                               "@MaPBmoi_3", cboddpbmoi.SelectedValue.ToString(),
                                               "@GhiChu_4", txtddghichu.Text.Trim());
                            mysql.ExecuteNonQuery("Update_Tbl_NhanVien_Dieudong_KoTo",
                                       CommandType.StoredProcedure,
                                       "@manv_1", txtddmanv.Text.Trim(),
                                       "@machucvu_2", int.Parse(cboddcvmoi.SelectedValue.ToString()),
                                       "@maphong_3", cboddpbmoi.SelectedValue.ToString());

                        }
                    }
                }
            }
            lstNhanvien.Items.Clear();
            HienTTNVhientai(txtddmanv.Text.Trim());
            setcontroldd(false);
            setcmddd(true);
            setcontrolgrpthongtin(false);
            setlist(true);            
            kdd =0;
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_dieudong.CurrentRow == null) MessageBox.Show("Phải chọn dòng trước khi xóa", "Thông báo");
            else
            {
                 DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (rs == DialogResult.Yes)
                 {
                     if (dgv_dieudong.CurrentRow.Index == dgv_dieudong.Rows.Count - 2)
                     {
                         DataGridViewRow row = dgv_dieudong.CurrentRow;
                         //cập nhật lại nhân viên
                         mysql.ExecuteNonQuery("Update_Tbl_NhanVien_Dieudong", CommandType.StoredProcedure,
                                      "@manv_1", txtddmanv.Text.Trim(),
                                      "@machucvu_2", int.Parse(row.Cells[3].Value.ToString()),
                                      "@maphong_3", row.Cells[4].Value.ToString(),
                                      "@mato_4", row.Cells[5].Value == null ? null : row.Cells[5].Value.ToString());
                         //xóa trong điều động
                         cdieudong.xoa(row.Cells[0].Value.ToString());
                     }
                     else
                         MessageBox.Show("Chỉ được xóa dòng cuối", "Thông báo");
                     
                 }
                
                
            }
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_dieudong.CurrentRow == null) MessageBox.Show("Phải chọn dòng cập nhật", "Thông báo");
            else
            {
                taocombodd();
                setcontroldd(true);
                setlist(false);
                setcmddd(false);
                kdd = 2;
                cboddcvmoi.Focus();
            }
        }

        //
        //Tab Khen Thưởng Kỷ Luật
        //

        //setcontrol grpklthongtin
        private void setcontrolgrpklthongtin(bool b)
        {
            txtklsoqd.Enabled = b;
            txtklngayqd.Enabled = b;
        }

        //setcontrol grpnoidung
        private void setcontrolgrpnoidung(bool b)
        {
            foreach (Control c in grpnoidung.Controls )
            {
                if (c.Name.Contains("txtkl") == true || c.Name.Contains("cbokl") == true)
                {
                    c.Enabled = b;
                }
            }
        }

        //làm rỗng các textbox
        private void ronggrpkl()
        {
            foreach (Control c in grpnoidung.Controls)
            {
                if (c.Name.Contains("txtkl") == true || c.Name.Contains("cbokl") == true)
                {
                    c.Text = "";
                }
            }
            txtklsoqd.Text = "";
            txtklngayqd.Text = "";
        }

        //set cmd
        private void setcmdkl(bool b)
        {
            cmdklluu .Enabled = !b;
            cmdklthem.Enabled = b;
            cmdklcapnhat.Enabled = b;
            cmdklxoa.Enabled = b;
        }

        //hiển thị thông tin chi tiết khen thưởng kỷ luật
        private void HienThiTTNVKTKL(string ma)
        {
            cnhanvien.laydl(ma);
            dgv_ctkyluatkhenthuong.DataSource = cklkt.laydl(ma);
            dgv_ctkyluatkhenthuong.DataMember = "NV_KLKT";
        }

        //lấy tên hình thức
        private string laytenhinhthuc(string ma)
        {
            if (ma == "") return "";
            string se = "select tenloai from tbl_DMkhenthuongkyluat where maloai = '" + ma + "'";
            cklkt.sc.Open();
            SqlCommand sel = new SqlCommand(se, cklkt.sc);
            object ten = sel.ExecuteScalar();
            cklkt.sc.Close();
            return ten.ToString();
        }

        //phương thức click của datagirdview dgv_ctkhenthuongkyluat
        private void dgv_ctkyluatkhenthuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_ctkyluatkhenthuong .CurrentRow;
            if (row != null)
            {
                //hiển thị dữ liệu theo từng dòng điều động
                txtklsoqd .Text = Convert.ToString(row.Cells[0].Value);
                txtklngayqd.Text = mysql.NgayToString(Convert.ToString(row.Cells[1].Value));
                txtklnoidung.Text = Convert.ToString(row.Cells[4].Value);
                txtklhinhthuc.Text = Convert.ToString(row.Cells[5].Value);
                txtklsotien .Text  = Convert.ToString(row.Cells[6].Value);
                txtklghichu.Text = Convert.ToString(row.Cells[7].Value);
                cboklloai.Text = laytenhinhthuc(Convert.ToString(row.Cells[8].Value));
            }
        }

        //bộ nút của tab khen thưởng kỷ luật
        private void cmdklthem_Click(object sender, EventArgs e)
        {
            if (txtklmanv.Text != "")
            {
                setcmdkl(false);
                setcontrolgrpklthongtin(true);
                setcontrolgrpnoidung(true);
                ronggrpkl();
                kklkt = 1;
                txtklsoqd.Focus();
                setlist(false);
            }
            else
                MessageBox.Show("Bạn phải chọn nhân viên để thực hiện", "Thông báo");
        }

        private void cmdklcapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_ctkyluatkhenthuong.CurrentRow == null) MessageBox.Show("Phải chọn dòng cập nhật", "Thông báo");
            else
            {
                setcmdkl(false);
                setcontrolgrpnoidung(true);
                kklkt = 2;
                cboklloai.Focus();
                setlist(false);
            }
        }

        private void cmdklxoa_Click(object sender, EventArgs e)
        {
            if (dgv_ctkyluatkhenthuong.CurrentRow == null)
                MessageBox.Show("Phải chọn dòng trước khi xóa", "Thông báo");
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    cklkt.xoa(txtklsoqd.Text.Trim());
                }
            }
            HienThiTTNVKTKL(txtklmanv.Text.Trim());
        }

        private void cmdklluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu thông tin này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                if (kklkt == 1)
                {
                    cklkt.them(txtklsoqd.Text.Trim(),
                               mysql.TraVeNgay(txtklngayqd.Text.Trim(), 1),
                               txtklmanv.Text.Trim(),
                               int.Parse(cboklloai.SelectedValue.ToString()),
                               txtklnoidung.Text.Trim(),
                               txtklhinhthuc.Text.Trim(),
                               int.Parse(txtklsotien.Text.Trim()),
                               txtklghichu.Text.Trim());
                }
                else if (kklkt == 2)
                {
                    cklkt.sua(txtklsoqd.Text.Trim(),
                               mysql.TraVeNgay(txtklngayqd.Text.Trim(), 1),
                               txtklmanv.Text.Trim(),
                               int.Parse(cboklloai.SelectedValue.ToString()),
                               txtklnoidung.Text.Trim(),
                               txtklhinhthuc.Text.Trim(),
                               int.Parse(txtklsotien.Text.Trim()),
                               txtklghichu.Text.Trim());
                }
            }
            else
                lamrong();
            HienThiTTNVKTKL(txtklmanv.Text.Trim());
            setcmdkl(true );
            setcontrolgrpklthongtin(false );
            setcontrolgrpnoidung(false );
            setlist(true );
            kklkt = 0;
        }
    }
}