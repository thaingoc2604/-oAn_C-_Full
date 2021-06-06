﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmbangluong : Form
    {
        //khai báo biến toàn cục        
        clsdmpb cPhong = new clsdmpb();
        clsDMTo cTo = new clsDMTo();
        clsbangluong cluong = new clsbangluong();
        clshieuqua chieuqua = new clshieuqua();
        clsTiLeLuong cTLL = new clsTiLeLuong();
        string thangkt = frmkiemtrabaocao.thangkt;
        string namkt = frmkiemtrabaocao.namkt;
        
        public frmbangluong()
        {
            InitializeComponent();
            cboPhong.DataSource = cPhong.taocombo();
            cboPhong.DisplayMember = "tbl_PhongBan.TenPhong";
            cboPhong.ValueMember = "tbl_PhongBan.MaPhong";
            lblthang.Text = "Bảng Lương Tháng " + thangkt + " năm " + namkt;
        }
        //Hiển thị thông tin nhân viên vào list nhân viên
        private void HienThiListNV(DataTable dt, ListView lv)
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
        //set list
        private void setlist(bool b)
        {
            lstNhanvien.Enabled = b;
            cboPhong.Enabled = b;
            cboTo.Enabled = b;
        }
        //hiển thị thông tin nhân viên
        private void HienThiTTNV(string ma)
        {
            cluong.laydl(thangkt, namkt, ma);
            txtmanv.Text = cluong.ds.Tables["bangluong"].Rows[0]["MaNV"].ToString();
            txtluongcb.Text = cluong.ds.Tables["bangluong"].Rows[0]["LuongCoBan"].ToString();
            txtphucapcv.Text = cluong.ds.Tables["bangluong"].Rows[0]["PhuCapCV"].ToString();
            txtsongaycong.Text = cluong.ds.Tables["bangluong"].Rows[0]["SoNgayLV"].ToString();
            txtsongayphep.Text = cluong.ds.Tables["bangluong"].Rows[0]["SoNgayNghiPhep"].ToString();
            txtot1.Text = cluong.ds.Tables["bangluong"].Rows[0]["SogioTangCa"].ToString();
            txtot2.Text = cluong.ds.Tables["bangluong"].Rows[0]["SoGioTangCaCN"].ToString();
            txtngayngungviec.Text = cluong.ds.Tables["bangluong"].Rows[0]["SoNgayNghiNgungViec"].ToString();
            txtpcsinhhoatcc.Text = cluong.ds.Tables["bangluong"].Rows[0]["PCSinhHoatCC"].ToString();
            txtthuclanh.Text = cluong.ds.Tables["bangluong"].Rows[0]["ThucLanh"].ToString();
            txtpckhac.Text = cluong.ds.Tables["bangluong"].Rows[0]["PhuCapKhac"].ToString();
            txttileccvasinhhoat.Text = cluong.ds.Tables["bangluong"].Rows[0]["TiLeCCvaSinhHoat"].ToString();
            txtluongngaycong.Text = cluong.ds.Tables["bangluong"].Rows[0]["LuongLamViec"].ToString();
            txtluongtangca.Text = cluong.ds.Tables["bangluong"].Rows[0]["LuongTangCa"].ToString();
            txtbhxhvabhyt.Text = cluong.ds.Tables["bangluong"].Rows[0]["BHXHvaBHYT"].ToString();
            //cbophanloai.SelectedItem = cluong.ds.Tables["bangluong"].Rows[0]["MaHieuQua"].ToString();
            cbophanloai.DataSource = cluong.ds;
            cbophanloai.DisplayMember = "bangluong.mahieuqua";
            cbophanloai.ValueMember = "bangluong.mahieuqua";
        }
        //set control trong grpchamcong
        private void setgrpchamcong(bool b)
        {
            foreach (Control c in grpchamcong.Controls)
            {
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                {
                    c.Enabled = b;
                }
            }
        }
        //set nut
        private void setcmd(bool b)
        {
            cmdluu.Enabled = !b;
            cmdchamcong.Enabled = b;
        }
        //taocombophanloai
        private void taocombo()
        {
            cbophanloai.DataSource = chieuqua.taocombo();
            cbophanloai.DisplayMember = "hieuqua.MaHieuQua";
            cbophanloai.ValueMember = "hieuqua.MaHieuQua";
            if(txtmanv.Text!="") cbophanloai.Text=cluong.ds.Tables["bangluong"].Rows[0]["MaHieuQua"].ToString();
            
        }
        //hiển thị dữ liệu lên datagirdview
        private void HienThiTTGird(string thang, string nam, string maphong, string mato)
        {
            dgv_bangluong.DataSource = cluong.laydlgird(thang, nam, maphong, mato);
            dgv_bangluong.DataMember = "bangluong";
        }
        //hiển thi dữ liệu lên datagirdview không có tổ
        private void HienThiTTGird(string thang, string nam, string maphong)
        {
            dgv_bangluong.DataSource = cluong.laydlgird(thang, nam, maphong);
            dgv_bangluong.DataMember = "bangluong";
        }
        //làm rổng các textbox và combobox trong các group
        private void lamrong()
        {
            foreach (Control c in grpttnv.Controls)
            {
                if (c.Name.Contains("txt") == true)
                {
                    c.Text  = "";
                }
            }
            foreach (Control c in grpchamcong.Controls)
            {
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in grpbangluong.Controls)
            {
                if (c.Name.Contains("txt") == true)
                {
                    c.Text = "";
                }
            }

 
        }

        private void frmbangluong_Load(object sender, EventArgs e)
        {

            //maphongin = "";
            //matoin = "";
            foreach (Control c in grpbangluong.Controls)
            {
                if (c.Name.Contains("txt") == true)
                {
                    c.Enabled = false ;
                }
            }
            foreach (Control c in grpttnv.Controls)
            {
                if (c.Name.Contains("txt") == true)
                {
                    c.Enabled = false;
                }
            }
            txtngaycongchuan.Enabled = false;
            txttileluong.Enabled = false;
            setgrpchamcong(false);
            setcmd(true);
            setlist(true);
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //maphongin = cboPhong.SelectedValue.ToString();
            txtngaycongchuan.Text = "";            
            txttileluong.Text = "";
            //Hiển thị dữ liệu nhân viên vào list
            lstNhanvien.Items.Clear();
            HienThiListNV(cPhong.laydlList(cboPhong.SelectedValue.ToString(),thangkt,namkt), lstNhanvien);
            //lấy dữ liệu vào gird 
            HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString());
            //lấy dữ liệu ngày công chuẩn và tỉ lệ lương của phòng
            try
            {
                cTLL.laydl(thangkt, namkt, cboPhong.SelectedValue.ToString(), "");
                txtngaycongchuan.Text = cTLL.ds1.Tables["TiLeLuong"].Rows[0]["SoNgayCongThang"].ToString();
                txttileluong.Text = cTLL.ds1.Tables["TiLeLuong"].Rows[0]["TiLeLuong"].ToString();
            }
            catch { }
            //tạo combobox to
            cboTo.DataSource = cTo.taocombo(cboPhong.SelectedValue.ToString());
            cboTo.DisplayMember = "DanhMucTo.TenTo";
            cboTo.ValueMember = "DanhMucTo.MaTo";
            cboTo.Text = "";
            //làm rổng các textbox
            lamrong();

        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //matoin = cboTo.SelectedValue.ToString();
            txtngaycongchuan.Text = "";
            txttileluong.Text = "";
            //Hiển thị list nhân viên
            lstNhanvien.Items.Clear();
            HienThiListNV(cTo.laydlList(cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString(),thangkt,namkt ), lstNhanvien);
            if (cboTo.Text !="")
            {
                //đưa dữ liệu vào datagirdview
                HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString(),cboTo.SelectedValue.ToString());
                try
                {
                    //lấy dữ liệu ngày công chuẩn và tỉ lệ lương của phòng và tổ
                    txtngaycongchuan.Text = cTLL.laydl(thangkt, namkt, cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString()).Rows[0]["SoNgayCongThang"].ToString();
                    txttileluong.Text = cTLL.laydl(thangkt, namkt, cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString()).Rows[0]["TiLeLuong"].ToString();
                }
                catch { }
            }
            else
            {
                //đưa dữ liệu vào datagirdview
                HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString());
                try
                    {
                        //lấy dữ liệu ngày công chuẩn và tỉ lệ lương của phòng 
                        txtngaycongchuan.Text = cTLL.laydl(thangkt, namkt, cboPhong.SelectedValue.ToString(), "").Rows[0]["SoNgayCongThang"].ToString();
                        txttileluong.Text = cTLL.laydl(thangkt, namkt, cboPhong.SelectedValue.ToString(), "").Rows[0]["TiLeLuong"].ToString();
                    }
                    catch { }
            }
            //làm rổng các textbox
            lamrong();

        }

        private void lstNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = lstNhanvien.FocusedItem.SubItems[0].Text;
            string ho = lstNhanvien.FocusedItem.SubItems[1].Text;
            string ten = lstNhanvien.FocusedItem.SubItems[2].Text;
            txthoten.Text  = ho + " " + ten;
            HienThiTTNV(ma);
        }
        //
        //bột nút của bảng lương
        //
        private void cmdchamcong_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text =="")
            {
                MessageBox.Show("Bạn phải chọn nhân viên chấm công", "Thông Báo");
            }
            else
            {
                setlist(false);
                setgrpchamcong(true);
                setcmd(false);
                taocombo();
                cbophanloai.Focus();
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            cluong.chamcong(thangkt, namkt, txtmanv.Text.Trim(),
                            cbophanloai.SelectedValue.ToString(),
                            txtsongaycong.Text.Trim()!=""? int.Parse(txtsongaycong.Text.Trim()):0,
                            txtot1.Text.Trim()!=""? int.Parse(txtot1.Text.Trim()):0,
                            txtot2.Text.Trim()!=""?int.Parse(txtot2.Text.Trim()):0,
                            txtsongayphep.Text.Trim()!=""? int.Parse(txtsongayphep.Text.Trim()):0,
                            txtngayngungviec.Text.Trim()!=""?int.Parse(txtngayngungviec.Text.Trim()):0,
                            txttileccvasinhhoat.Text.Trim()!=""?double.Parse(txttileccvasinhhoat.Text.Trim()):0,
                            txtpckhac.Text.Trim()!=""?int.Parse(txtpckhac.Text.Trim()):0);
            setlist(true);
            setgrpchamcong(false);
            setcmd(true);
            HienThiTTNV(txtmanv.Text.Trim());
            if (cboTo.Text != "")
            {
                //đưa dữ liệu vào datagirdview
                HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString());
            }
            else
            {
                //đưa dữ liệu vào datagirdview
                HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString());
            }
        }

        private void cmdtinhluong_Click(object sender, EventArgs e)
        {
            if ((txtngaycongchuan.Text == "") || (txttileluong.Text == ""))
            {
                DialogResult rs = MessageBox.Show("Bạn chưa nhập số ngày làm việc trong tháng và tỉ lệ lương.\nMở Form Tỉ lệ lương để nhập vào!!!", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    frmbangtileluong f = new frmbangtileluong();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }

            else
            {
                //kiểm tra chấm công hết chưa
                bool bchamcong = false;
                for (int i = 0; i < dgv_bangluong.Rows.Count - 1; i++)
                {
                    DataGridViewRow dgvrow = dgv_bangluong.Rows[i];
                    if (dgvrow.Cells["mahieuqua"].Value.ToString() == "")
                        bchamcong = true;
                }
                if (bchamcong)
                    MessageBox.Show("Chưa chấm công xong", "Thông Báo");
                else
                //tính lương
                {
                    for (int i = 0; i < dgv_bangluong.Rows.Count - 1; i++)
                    {
                        cluong.tinhluong(thangkt, namkt, dgv_bangluong.Rows[i].Cells["ma"].Value.ToString(),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["luongcb"].Value.ToString()),
                                        double.Parse(dgv_bangluong.Rows[i].Cells["tilehq"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["songaylv"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["soot1"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["soot2"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["ngaynghiphep"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["ngayngungviec"].Value.ToString()),
                                        double.Parse(dgv_bangluong.Rows[i].Cells["tileccvasinhhoat"].Value.ToString()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["phucapcv"].Value.ToString()),
                                        int.Parse(txtngaycongchuan.Text.Trim()),
                                        TileTB(double.Parse(txttileluong.Text.Trim()),
                                        dgv_bangluong.Rows.Count - 1,
                                        LaySNTheoLoai(), chieuqua.tilehq()),
                                        int.Parse(dgv_bangluong.Rows[i].Cells["phucapkhac"].Value.ToString()));
                    }
                    if (cboTo.Text != "")
                    {
                        //đưa dữ liệu vào datagirdview
                        HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString());
                    }
                    else
                    {
                        //đưa dữ liệu vào datagirdview
                        HienThiTTGird(thangkt, namkt, cboPhong.SelectedValue.ToString());
                    }
                    lamrong();
                }
            }  
        }

        //
        //các hàm tính lương
        //

        //hàm trả về mảng lấy tổng số người theo phân loại
        private int[] LaySNTheoLoai()
        {
            string [] Loai=chieuqua.bangphanloai();
            int[] SN=new int[Loai.Length];
            for (int i = 0; i < dgv_bangluong.Rows.Count - 1; i++)
            {
                DataGridViewRow r = dgv_bangluong.Rows[i];
                for (int j = 0; j < Loai.Length; j++)
                {
                    if (Loai[j] == r.Cells["mahieuqua"].Value.ToString().Trim())
                        SN[j] += 1;
                }
            }
            return SN;
        }

        // hàm tính tỉ lệ lương trung bình cho từng người trong phòng hoặc tổ
        private double TileTB(double tileluong, int songuoi,int[] songuoitheopl,double [] TiLeHQ)
        {
            double TongTiLeLuongTheoLoai = 0;
            double TongTiLeLuong = tileluong * songuoi;
            for (int i = 0; i < songuoitheopl.Length; i++)
            {
                TongTiLeLuongTheoLoai += songuoitheopl[i] * TiLeHQ[i];
            }
            return TongTiLeLuong / TongTiLeLuongTheoLoai;
        }

        private void cbophanloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdin_Click(object sender, EventArgs e)
        {
            if(cboPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn phòng để in","Thông báo");
            }
            else
            {
                frmrptluongtheophong f= new frmrptluongtheophong();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}