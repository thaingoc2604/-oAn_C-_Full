using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manager_Fortunes.BusinessObject;
using Manager_Fortunes.Controller;

namespace Manager_Fortunes.PresentationLayer
{
    public partial class frmTimKiemTaiSanThue : DevComponents.DotNetBar.Office2007Form
    {
        ThueTaiSan ts = new ThueTaiSan();

        Ctrthuetaisan ctr = new Ctrthuetaisan(); 


        public frmTimKiemTaiSanThue()
        {
            InitializeComponent();
        }

        private void checkBoxChontentaisan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChontentaisan.CheckState == CheckState.Checked)
            {
                this.texttentaisan.Enabled = true;
            }
            else
            {
                this.texttentaisan.Enabled = false;
                this.texttentaisan.Text = "";
            }
        }

        private void checkBoxTenNhom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTenNhom.CheckState == CheckState.Checked)
                this.combotennhom.Enabled = true;
            else
                this.combotennhom.Enabled = false;
        }

        private void checkBoxNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxNgay.CheckState == CheckState.Checked)
            {
                this.dateTimetungay.Enabled = true;
                this.dateTimedenngay.Enabled = true;
            }
            else
            {
                this.dateTimetungay.Enabled = false;
                this.dateTimedenngay.Enabled = false;
            }
        }

        private void checkBoxthoigiansudung_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxthoigiansudung.CheckState == CheckState.Checked)
            {
                this.dateTimethoigiansudungtu.Enabled = true;
                this.dateTimethoigiansudungden.Enabled = true;
            }
            else
            {
                this.dateTimethoigiansudungtu.Enabled = false;
                this.dateTimethoigiansudungden.Enabled = false;
            }
        }

        private void checkBoxdiadiem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxdiadiem.CheckState == CheckState.Checked)
                this.combotendiadiem.Enabled = true;
            else
                this.combotendiadiem.Enabled = false;
        }

        private void checkBoxphongban_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxphongban.CheckState == CheckState.Checked)
                this.combophongban.Enabled = true;
            else
                this.combophongban.Enabled = false;
        }

        private void toolStripButtonTimkiem_Click(object sender, EventArgs e)
        {
            String loi="";
            if (this.checkBoxChontentaisan.CheckState != CheckState.Checked && this.checkBoxTenNhom.CheckState != CheckState.Checked && this.checkBoxNgay.CheckState != CheckState.Checked
                 && this.checkBoxthoigiansudung.CheckState != CheckState.Checked && this.checkBoxdiadiem.CheckState != CheckState.Checked && this.checkBoxphongban.CheckState != CheckState.Checked)
                loi += "Chưa chọn thông tin cần tìm kiếm.";

            if (this.checkBoxChontentaisan.CheckState == CheckState.Checked && texttentaisan.Text == "")
                loi += "Chưa nhập tên tài sản cần tìm kiếm.";

            if (this.checkBoxTenNhom.CheckState == CheckState.Checked && combotennhom.Text == "")
                loi += "Chưa chọn tên nhóm tài sản cần tìm kiếm.";

            if (this.checkBoxNgay.CheckState == CheckState.Checked && dateTimetungay.Text == "" && dateTimedenngay.Text =="")
                loi += "Chưa chọn ngày thuê tài sản cần tìm kiếm.";

            if (this.checkBoxthoigiansudung.CheckState == CheckState.Checked && dateTimethoigiansudungtu.Text == "" && dateTimethoigiansudungden.Text == "")
                loi += "Chưa chọn thời gian sử dụng của tài sản cần tìm kiếm.";

            if (this.checkBoxdiadiem.CheckState == CheckState.Checked && combotendiadiem.Text == "")
                loi += "Chưa chọn địa điểm của tài sản cần tìm kiếm.";

            if (this.checkBoxphongban.CheckState == CheckState.Checked && combophongban.Text == "")
                loi += "Chưa chọn phòng ban của tài sản cần tìm kiếm.";

            if (loi == "")
            {
                try
                {
                    ctr.TimKiemTaiSan(texttentaisan,checkBoxTenNhom,ts.NhomTaiSanCongCu.MaNhom,dateTimetungay,dateTimedenngay,dateTimethoigiansudungtu,dateTimethoigiansudungden,combotendiadiem,combophongban,dataGridViewX1);
                }
                catch (Exception et)
                {
                    MessageBox.Show("Thông tin không tìm thấy. Đề nghị nhập lại ." + et.Message, "Nhap thong tin sai");
                }
            }

            else
            {
                MessageBox.Show(loi, "loi khi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DienThongTin()
        {
            
            
        }

        private void frmTimKiemTaiSanThue_Load(object sender, EventArgs e)
        {
           // ctr.HienThi_MaNhom(combotennhom);
           // ctr.HienThi_MaDiaDiem(combotendiadiem);
          //  ctr.HienThi_MaPhongBan(combophongban);
        }

       

       
    }
}