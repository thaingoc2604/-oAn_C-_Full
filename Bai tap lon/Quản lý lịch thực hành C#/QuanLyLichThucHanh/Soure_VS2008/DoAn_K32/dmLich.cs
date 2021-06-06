using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BussinessLayer;
namespace DoAn_K32
{
    public partial class dmLich : DevExpress.XtraEditors.XtraUserControl
    {
        public dmLich()
        {
            InitializeComponent();
        }

        private void dmLich_Load(object sender, EventArgs e)
        {
            DataLoad();
            //DateTime.Parse(label1.Text.ToString()) = dtNgay.Value.Day.ToString()+7;
            //dateTimePicker1.Value.Day = dtNgay.Value.Day + 7;
             //if (DateTime.Parse(d.EditValue.ToString()).Year < (DateTime.Today.Year - 18))
        }

        public void DataLoad()
        {
            cbbGiaoVien.DataSource = GiaoVienBus.GetAll_GiaoVien();
            cbbGiaoVien.DisplayMember = "TenGV";
            cbbGiaoVien.ValueMember = "MaGV";
            cbbLop.DataSource = LopBus.GetAll_Lop();
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
            cbbTiet.DataSource = ThoiGianBus.GetAll_ThoiGian();
            cbbTiet.DisplayMember = "Tiet";
            cbbMonHoc.DataSource = MonHocBus.GetAll_MonHoc();
            cbbMonHoc.DisplayMember = "TenMH";
            cbbPhong.DataSource = PhongBus.GetAll_Phong();
            cbbPhong.DisplayMember = "TenPhong";
            //cbbMaLop.DataSource = LopBus.GetAll_Lop();
            //cbbMaLop.DisplayMember = "MaLop";
            txtMaLopp.DataBindings.Add("text", cbbLop.DataSource, "MaLop");
            txtMaGVV.DataBindings.Add("text", cbbGiaoVien.DataSource, "MaGV");
            txtMaMHH.DataBindings.Add("text", cbbMonHoc.DataSource, "MaMH");
            txtTiett.DataBindings.Add("text", cbbTiet.DataSource, "MaTG");
            txtPhongg.DataBindings.Add("text", cbbPhong.DataSource, "MaPHG");
        }
        private void txtTenLop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (LichBus.ThemLich(new Lich_Info(txtMaGVV.Text, txtMaMHH.Text, txtMaLopp.Text, txtPhongg.Text, txtTiett.Text, DateTime.Parse(dtNgay.Value.ToShortDateString()), int.Parse(txtTuan.Text), int.Parse(txtThu.Text))))
            {
                MessageBox.Show("Them Thanh Cong");
            }
            //if (LichBus.TimTuanThuTietLop(int.Parse(txtThu.Text),int.Parse(txtTuan.Text), txtTiett.Text,txtMaLopp.Text).Rows.Count))
            //{
            //    MessageBox.Show("SaiHamTim");

            //}
            //if (LichBus.KiemTraLopTrung(txtMaLopp.Text, int.Parse(txtTuan.Text), int.Parse(txtThu.Text),txtTiett.Text).Rows.Count == 0)
            //{
                //if (LichBus.ThemLich(new Lich_Info(txtMaGVV.Text, txtMaMHH.Text, txtMaLopp.Text,txtPhongg.Text, txtTiett.Text, DateTime.Parse(dtNgay.Value.ToShortDateString()), int.Parse(txtTuan.Text), int.Parse(txtThu.Text)))==false)
                //{
                //    MessageBox.Show("Lop da co lich");

                //    //Lich_Info lich=new Lich_Info(txtMaGVV.Text,txtMaMHH.Text,txtMaLopp.Text,txtPhongg.Text,txtTiett.Text,DateTime.Parse(dtNgay.Value.ToShortDateString()),int.Parse(txtTuan.Text),int.Parse(txtThu.Text));
                //    //if (LichBus.ThemLich(new Lich_Info(txtMaGVV.Text, txtMaMHH.Text, txtMaLopp.Text, txtPhongg.Text, txtTiett.Text, DateTime.Parse(dtNgay.Value.ToShortDateString()), int.Parse(txtTuan.Text), int.Parse(txtThu.Text))))
                //    //{
                //    //    MessageBox.Show("Them Thanh Cong");
                //    //}
                //    //else
                //    //{
                //    //    MessageBox.Show("Khong Them Duoc");
                //    //}
                //}
                //else
                //{
                //    MessageBox.Show("Them thanh cong");
                //}
            //}
            //else
            //{
            //    MessageBox.Show("Lớp đã có lịch");
            //}
        }
    }
}
