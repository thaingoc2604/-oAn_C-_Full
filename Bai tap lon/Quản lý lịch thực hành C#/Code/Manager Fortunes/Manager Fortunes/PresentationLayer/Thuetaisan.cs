using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using Manager_Fortunes.BusinessObject;
using Manager_Fortunes.Controller;

namespace Manager_Fortunes.PresentationLayer
{
    public partial class Thuetaisan : DevComponents.DotNetBar.Office2007Form
    {

        ThueTaiSan ts = new ThueTaiSan();
        NhomTaiSanCongCu nhom = new NhomTaiSanCongCu();
        DonViTinh DVT = new DonViTinh();
        PhongBan phong = new PhongBan();
        DiaDiem diad = new DiaDiem();
        frmTimKiemTaiSanThue timkiem;
        
       Ctrthuetaisan ctr = new Ctrthuetaisan();
        public Thuetaisan()
        {
            InitializeComponent();
            
        }

       

        private void Thuetaisan_Load(object sender, EventArgs e)
        {
           // ctr.HienThi(dataGridViewX1,bindingNavigator1);
           // ctr.HienThi_MaNhom(combomanhom);
           // ctr.HienThi_MaDVT(combomaDVT);
          //  ctr.HienThi_MaDiaDiem(combobophan);
          //  ctr.HienThi_MaPhongBan(combophongban);
           // ctr.HienThi_LyDo(combolydotang);

        }

        public void DienThongTin()
        {
            ts.MaPhieuthue = textmaphieuthue.Text;
            ts.MaTaiSan = textmataisan.Text;
            ts.TenTaiSan = texttentaisan.Text;
            ts.NhomTaiSanCongCu.MaNhom = combomanhom.SelectedValue.ToString();
            ts.DonViTinh.MaDonViTinh = combomaDVT.SelectedValue.ToString();
            ts.SoLuong = Convert.ToInt32(textsoluong.Text);
            ts.GiaThue = Convert.ToInt64(textgiathue.Text);
            ts.ThanhTien = Convert.ToInt64(textthanhtien.Text);
            ts.DaThanhToan = Convert.ToInt64(textdathanhtoan.Text);
            ts.ConLai = Convert.ToInt64(textconlai.Text);
            ts.MucDich = textmucdich.Text;
            ts.LyDoTang.MaLyDo = combolydotang.SelectedValue.ToString();
            ts.NgayTang = dateTimengay.Value;
            ts.ThoigianSudung = dateTimesudung.Value;
            ts.DiaDiem.MaDiaDiem = combobophan.SelectedValue.ToString();
            ts.PhongBan.MaPhong = combophongban.SelectedValue.ToString();
        }
            
        
        
        public void CapNhat()
        {
            this.texttentaisan.Enabled = true;
            this.combomanhom.Enabled = true;
            this.combomaDVT.Enabled = true;
            this.textsoluong.Enabled = true;
            this.textgiathue.Enabled = true;
            this.textthanhtien.Enabled = true;
            this.textdathanhtoan.Enabled = true;
            this.textconlai.Enabled = true;
            this.combolydotang.Enabled = true;
            this.dateTimengay.Enabled = true;
            this.dateTimesudung.Enabled = true;
            this.combobophan.Enabled = true;
            this.combophongban.Enabled = true;
            this.textmucdich.Enabled = true;

        }
        public void KhoiTao()
        {
            textmaphieuthue.Text = "";
            textmataisan.Text = "";
            texttentaisan.Text = "";
            combomanhom.Text = "";
            combomaDVT.Text = "";
            textsoluong.Text = "";
            textgiathue.Text = "";
            textthanhtien.Text = "";
            textdathanhtoan.Text = "";
            textconlai.Text = "";
            combolydotang.Text = "";
            dateTimengay.Text = "";
            dateTimesudung.Text = "";
            combobophan.Text = "";
            combophongban.Text = "";
            textmucdich.Text = "";
        }
        public void KiemTra()
        {
            string loi = "";

            if (textmaphieuthue.Text == "")
                loi += "Chưa thêm mã phiếu thuê.";
            if (texttentaisan.Text == "")
                loi += "Chưa thêm tên tài sản.";
            if (combomanhom.Text == "")
                loi += "Chưa thêm mã nhóm.";
            if (combomaDVT.Text == "")
                loi += "Chưa thêm mã đơn vị tính.";
            if (textsoluong.Text == "")
                loi += "Chưa thêm số lượng.";
            if(textgiathue.Text =="")
                loi+="Chưa thêm giá thuê.";
            if (textdathanhtoan.Text == "")
                loi += "Chưa thêm đã thanh toán.";
            if(textconlai.Text == "")
                loi += "Chưa thêm còn lại giá tiền.";
            if (combolydotang.Text == "")
                loi += "Chưa thêm lý do.";
            if (dateTimengay.Text == "")
                loi += "chưa thêm ngày tăng.";
            if (dateTimesudung.Text == "")
                loi += "Chưa thêm ngày sử dụng.";
            if (combobophan.Text == "")
                loi += "Chưa thêm địa điểm";
            if (combophongban.Text == "")
                loi += "Chưa thêm phong ban.";
            if (textmucdich.Text == "")
                loi += "Chưa thêm mục đích sử dụng.";
            
        }

       

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            this.KiemTra();
            this.DienThongTin();
            ctr.CapNhat(ts);
            ctr.HienThi(dataGridViewX1, bindingNavigator1);
            this.KhoiTao();

        }

       

        private void buttontaomoi_Click(object sender, EventArgs e)
        {
            this.textmaphieuthue.Enabled = true;
            this.textmataisan.Enabled = true;
            this.texttentaisan.Enabled = true;
            this.combomanhom.Enabled = true;
            this.combomaDVT.Enabled = true;
            this.textsoluong.Enabled = true;
            this.textgiathue.Enabled = true;
            this.textthanhtien.Enabled = true;
            this.textdathanhtoan.Enabled = true;
            this.textconlai.Enabled = true;
            this.combolydotang.Enabled = true;
            this.dateTimengay.Enabled = true;
            this.dateTimesudung.Enabled = true;
            this.combobophan.Enabled = true;
            this.combophongban.Enabled = true;
            this.textmucdich.Enabled = true;

            this.buttonLuu.Enabled = true;
            this.KhoiTao();
        }

        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            //this.KiemTra();

            string loi = "";

            if (textmaphieuthue.Text == "")
                loi += "Chưa thêm mã phiếu thuê.";
            if (texttentaisan.Text == "")
                loi += "Chưa thêm tên tài sản.";
            if (combomanhom.Text == "")
                loi += "Chưa thêm mã nhóm.";
            if (combomaDVT.Text == "")
                loi += "Chưa thêm mã đơn vị tính.";
            if (textsoluong.Text == "")
                loi += "Chưa thêm số lượng.";
            if (textgiathue.Text == "")
                loi += "Chưa thêm giá thuê.";
            if (textdathanhtoan.Text == "")
                loi += "Chưa thêm đã thanh toán.";
            if (textconlai.Text == "")
                loi += "Chưa thêm còn lại giá tiền.";
            if (combolydotang.Text == "")
                loi += "Chưa thêm lý do.";
            if (dateTimengay.Text == "")
                loi += "chưa thêm ngày tăng.";
            if (dateTimesudung.Text == "")
                loi += "Chưa thêm ngày sử dụng.";
            if (combobophan.Text == "")
                loi += "Chưa thêm địa điểm";
            if (combophongban.Text == "")
                loi += "Chưa thêm phong ban.";
            if (textmucdich.Text == "")
                loi += "Chưa thêm mục đích sử dụng.";

            if (loi == "")
            {
                try
                {


                    this.DienThongTin();
                    ctr.LuuTaiSanThue(ts);
                    ctr.HienThi(dataGridViewX1, bindingNavigator1);
                    this.KhoiTao();

                }
                catch (Exception et)
                {
                    MessageBox.Show("Thong tin nhap vao khong dung. De nghi nhap lai ." + et.Message, "Nhap thong tin sai");
                }
            }
            else
            {
                MessageBox.Show(loi, "loi khi them", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            string loi = "";
            if (textmaphieuthue.Text == "")
                loi += "Chưa nhập mã phiếu thuê.Không xóa được.";

            if (loi == "")
            {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu này hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ts.MaPhieuthue = textmaphieuthue.Text;
                    ctr.XoaTaiSanThue(ts);
                    ctr.HienThi(dataGridViewX1, bindingNavigator1);
                    KhoiTao();
                }
            }
            else
                MessageBox.Show(loi, "loi khi xoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void dataGridViewX1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                       
                DataGridViewRow rows = dataGridViewX1.Rows[e.RowIndex];

                //textmaphieuthue.Text = rows.Cells[0].Value.ToString();
               // textmataisan.Text = rows.Cells[1].Value.ToString();
            

        }

        private void buttonThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            if (timkiem == null || timkiem.IsDisposed)
                timkiem = new frmTimKiemTaiSanThue();
            timkiem.ShowDialog();
            //timkiem.MdiParent = this;
            //timkiem.Show();
        }

        
        

        

       

        
       

       
        
    }
}