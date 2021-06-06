using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;
namespace GUI_Tier
{
    public partial class SuaThongTin : Form
    {
        public SuaThongTin()
        {
            InitializeComponent();
        }
        User_Bus us;
        String sapxep = "asc";
        private void SuaThongTin_Load(object sender, EventArgs e)
        {
            Show_All_User("ID");
        }
        private void XoaTrang()
        {
            txtChuoiBiMat.Text = "";
            txtDiaChi.Text = "";
            txtHo.Text = "";
            txtMatKhau.Text = "";
            txtSoCMND.Text = "";
            txtTen.Text = "";
            txtID.Text = "";
            txtID.Focus();
        }
        private bool Check_Empty()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập chưa được nhập!");
                return true;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật Khẩu chưa được nhập!");
                return true;
            }
            if (txtChuoiBiMat.Text == "")
            {
                MessageBox.Show("Chuỗi bí mật chưa được nhập!");
                return true;
            }
            if (txtHo.Text == "")
            {
                MessageBox.Show("Họ chưa được nhập!");
                return true;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên chưa được nhập!");
                return true;
            }
            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Số CMND chưa được nhập!");
                return true;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ chưa được nhập!");
                return true;
            }
            return false;
        }
        private void picXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (Check_Empty())
                return;
            else
            {
                us = new User_Bus(txtID.Text);
                if (us.Del_User()>0)
                {
                    Show_All_User("ID");
                    XoaTrang();
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw.SelectedItems.Count > 0)
            {
                txtID.Text =lvw.SelectedItems[0].Text;
                txtMatKhau.Text =lvw.SelectedItems[0].SubItems[1].Text;
                txtSoCMND.Text =lvw.SelectedItems[0].SubItems[2].Text;
                txtChuoiBiMat.Text =lvw.SelectedItems[0].SubItems[3].Text;
                txtHo.Text =lvw.SelectedItems[0].SubItems[4].Text;
                txtTen.Text=lvw.SelectedItems[0].SubItems[5].Text;
                txtDiaChi.Text=lvw.SelectedItems[0].SubItems[6].Text;
                DateTime dtp = new DateTime();
                dtp = DateTime.Parse(lvw.SelectedItems[0].SubItems[7].Text);
                dtpNgaySinh.Value=dtp;
                cboQuyen.Text = lvw.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void picThem_Click(object sender, EventArgs e)
        {
            if (Check_Empty())
                return;
            else
            {
                DateTime dtp = new DateTime();
                dtp = dtpNgaySinh.Value;
                dtp.ToString("dd/MM/yyyy");
                us = new User_Bus(txtID.Text, txtMatKhau.Text, txtSoCMND.Text, txtChuoiBiMat.Text, txtHo.Text, txtTen.Text, txtDiaChi.Text, dtp, cboQuyen.SelectedItem.ToString());
                if (us.Edit_User() > 0)
                {
                    Show_All_User("ID");
                    XoaTrang();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    if (us.DK_User() > 0)
                    {
                        Show_All_User("ID");
                        XoaTrang();
                        MessageBox.Show("Đăng ký thành công");
                    }
                    else
                        MessageBox.Show("sadasd");
                }
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Show_All_User(String tencot)
        {
            lvw.Items.Clear();
            us = new User_Bus();
            DataView dv = new DataView();
            dv.Table = us.Get_All();
            if (sapxep == "desc")
            {
                sapxep = "asc";
                dv.Sort = tencot + " " + sapxep;
            }
            else
            {
                sapxep = "desc";
                dv.Sort = tencot + " " + sapxep; ;
            }
            foreach (DataRowView drv in dv)
            {
                ListViewItem li = lvw.Items.Add(drv["id"].ToString());
                li.SubItems.Add(drv["matkhau"].ToString());
                li.SubItems.Add(drv["socmnd"].ToString());
                li.SubItems.Add(drv["chuoibimat"].ToString());
                li.SubItems.Add(drv["ho"].ToString());
                li.SubItems.Add(drv["ten"].ToString());
                li.SubItems.Add(drv["diachi"].ToString());
                li.SubItems.Add(drv["ngaysinh"].ToString());
                li.SubItems.Add(drv["quyen"].ToString());
            }
        }
        private void lvw_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                Show_All_User("ID");
            }
            if (e.Column == 1)
            {
                Show_All_User("MatKhau");
            }
            if (e.Column == 2)
            {
                Show_All_User("SoCMND");
            }
            if (e.Column == 3)
            {
                Show_All_User("ChuoiBiMat");
            }
            if (e.Column == 4)
            {
                Show_All_User("Ho");
            }
            if (e.Column == 5)
            {
                Show_All_User("Ten");
            }
            if (e.Column == 6)
            {
                Show_All_User("DiaChi");
            }
            if (e.Column == 7)
            {
                Show_All_User("NgaySinh");
            }
            if (e.Column == 8)
            {
                Show_All_User("Quyen");
            }
        }
    }
}
