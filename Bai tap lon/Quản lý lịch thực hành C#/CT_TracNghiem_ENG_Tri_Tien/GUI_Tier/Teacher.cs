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
    public partial class Teacher:Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        CauHoi_Bus ch;
        DapAn_Bus da;
        DeThi_Bus dethi;
        User_Bus us = new User_Bus(DangNhap.TenDangNhap, DangNhap.MatKhau);
        private bool KiemTra_DapAnDung()
        {
            int i = 0;
            if (txtDapAnA.Text == "0")
            {
                i++;
            }
            if (txtDapAnB.Text == "0")
            {
                i++;
            }
            if (txtDapAnC.Text == "0")
            {
                i++;
            }
            if (txtDapAnD.Text == "0")
            {
                i++;
            }
            if (i < 3 || i > 4)
            {
                MessageBox.Show("Đáp án không hợp lý\nĐáp án hợp lý: 3 đáp án 0 - 1 đáp án 1");
                return true;
            }
            return false;
        }
        private bool KiemTra_Rong()
        {
            if (KiemTra_DapAnDung())
            {
                return true;
            }
            if (txtNoiDungCauHoi.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung câu hỏi");
                return true;
            }
            if (txtNoiDungDapAnA.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung đáp án A");
                return true;
            }
            if (txtNoiDungDapAnB.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung đáp án B");
                return true;
            }
            if (txtNoiDungDapAnC.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung đáp án C");
                return true;
            }
            if (txtNoiDungDapAnD.Text == "")
            {
                MessageBox.Show("Vui lòng điền nội dung đáp án D");
                return true;
            }
            if (txtDapAnA.Text == "")
            {
                MessageBox.Show("Vui lòng điền đáp án A");
                return true;
            }
            if (txtDapAnB.Text == "")
            {
                MessageBox.Show("Vui lòng điền đáp án B");
                return true;
            }
            if (txtDapAnC.Text == "")
            {
                MessageBox.Show("Vui lòng điền đáp án C");
                return true;
            }
            if (txtDapAnD.Text == "")
            {
                MessageBox.Show("Vui lòng điền đáp án D");
                return true;
            }
            if (txtMaCauHoi.Text == "CH")
            {
                MessageBox.Show("Vui lòng điền Mã câu hỏi");
                return true;
            }
            return false;
        }
        private void XoaTrang()
        {
            txtDapAnA.Text = "";
            txtDapAnB.Text = "";
            txtDapAnC.Text = "";
            txtDapAnD.Text = "";
            txtMaCauHoi.Text = "CH";
            txtNoiDungCauHoi.Text = "";
            txtNoiDungDapAnA.Text = "";
            txtNoiDungDapAnB.Text = "";
            txtNoiDungDapAnC.Text = "";
            txtNoiDungDapAnD.Text = "";
            txtNoiDungCauHoi.Focus();
        }
       
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void lblTaoBoDe_Click(object sender, EventArgs e)
        {
            Teacher_BoDe frmBoDe = new Teacher_BoDe();
            frmBoDe.ShowDialog();
        }


        private void txtDapAnA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar != '0' && e.KeyChar != '1') && !Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhận giá trị 0 và 1\n0:Không là đáp án\n1:Là đáp án đúng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Close();
        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau frmDoiMK = new DoiMatKhau();
            frmDoiMK.ShowDialog();
        }
        private void Show_All_ID()
        {
            lvwCauHoi.Items.Clear();
            ch = new CauHoi_Bus();
            DataView dtv=ch.Show_CauHoi_ID(DangNhap.TenDangNhap);
            dtv.Sort = "macauhoi";
            foreach (DataRowView dtrv in dtv)
            {
                ListViewItem li = lvwCauHoi.Items.Add(dtrv["macauhoi"].ToString());
                li.SubItems.Add(dtrv["noidungcauhoi"].ToString());
            }
        }
        private void Teacher_Load(object sender, EventArgs e)
        {
            
            if (us.Check_Quyen() != "BGH")
                Show_All_ID();
            else
                Show_All();
        }
        private void Show_All()
        {
            lvwCauHoi.Items.Clear();
            ch = new CauHoi_Bus();
            DataView dtv = ch.Show_All();
            dtv.Sort = "macauhoi";
            foreach (DataRowView dtrv in dtv)
            {
                ListViewItem li = lvwCauHoi.Items.Add(dtrv["macauhoi"].ToString());
                li.SubItems.Add(dtrv["noidungcauhoi"].ToString());
            }
        }
        private void Show_Text()
        {
            if (lvwCauHoi.SelectedItems.Count > 0)
            {
                int flag = 0;
                String macauhoi = lvwCauHoi.SelectedItems[0].Text.Trim().ToString();
                ch = new CauHoi_Bus(macauhoi);
                da = new DapAn_Bus(macauhoi);
                DataTable dtda=da.Show_DapAn().Tables["tb_DapAn"];
                DataTable dtch = ch.Show_CauHoi().Tables["tb_CauHoi"];
                DataRow drch = dtch.Rows[0];
                txtMaCauHoi.Text = drch["macauhoi"].ToString();
                txtNoiDungCauHoi.Text = drch["noidungcauhoi"].ToString();
                foreach (DataRow drda in dtda.Rows)
                {
                    if (flag == 0)
                    {
                        txtNoiDungDapAnA.Text = drda["noidungdapan"].ToString();
                        txtDapAnA.Text = drda["dapandung"].ToString();
                    }
                    else if (flag == 1)
                    {
                        txtNoiDungDapAnB.Text = drda["noidungdapan"].ToString();
                        txtDapAnB.Text = drda["dapandung"].ToString();
                    }
                    else if (flag == 2)
                    {
                        txtNoiDungDapAnC.Text = drda["noidungdapan"].ToString();
                        txtDapAnC.Text = drda["dapandung"].ToString();
                    }
                    else if (flag == 3)
                    {
                        txtNoiDungDapAnD.Text = drda["noidungdapan"].ToString();
                        txtDapAnD.Text = drda["dapandung"].ToString();
                    }
                    flag++;
                }
            }
        }
        private void lvwCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Text();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTra_Rong() == true)
                {
                    return;
                }
                ch = new CauHoi_Bus(txtMaCauHoi.Text.Trim().ToString(), DangNhap.TenDangNhap, txtNoiDungCauHoi.Text.Trim().ToString());
                bool trangthai = true;
                if (ch.Check_MaCauHoi() > 0)
                    trangthai = false;
                ch.Add_Update_CauHoi();
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        da = new DapAn_Bus(txtMaCauHoi.Text.Trim().ToString(), txtMaCauHoi.Text.Trim().ToString() + "a", txtNoiDungDapAnA.Text.Trim().ToString(), Int16.Parse(txtDapAnA.Text.Trim().ToString()));
                        da.Add_Update_DapAn(trangthai);
                    }
                    if (i == 1)
                    {
                        da = new DapAn_Bus(txtMaCauHoi.Text.Trim().ToString(), txtMaCauHoi.Text.Trim().ToString() + "b", txtNoiDungDapAnB.Text.Trim().ToString(), Int16.Parse(txtDapAnB.Text.Trim().ToString()));
                        da.Add_Update_DapAn(trangthai);
                    }
                    if (i == 2)
                    {
                        da = new DapAn_Bus(txtMaCauHoi.Text.Trim().ToString(), txtMaCauHoi.Text.Trim().ToString() + "c", txtNoiDungDapAnC.Text.Trim().ToString(), Int16.Parse(txtDapAnC.Text.Trim().ToString()));
                        da.Add_Update_DapAn(trangthai).ToString();
                    }
                    if (i == 3)
                    {
                        da = new DapAn_Bus(txtMaCauHoi.Text.Trim().ToString(), txtMaCauHoi.Text.Trim().ToString() + "d", txtNoiDungDapAnD.Text.Trim().ToString(), Int16.Parse(txtDapAnD.Text.Trim().ToString()));
                        da.Add_Update_DapAn(trangthai).ToString();
                    }
                }
                XoaTrang();
                if (us.Check_Quyen() != "BGH")
                    Show_All_ID();
                else
                    Show_All();
                MessageBox.Show("Add / Update Thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không phù hợp");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwCauHoi.SelectedItems.Count > 0)
                {
                    da = new DapAn_Bus(lvwCauHoi.SelectedItems[0].Text.Trim().ToString());
                    ch = new CauHoi_Bus(lvwCauHoi.SelectedItems[0].Text.Trim().ToString());
                    dethi = new DeThi_Bus();
                    if (dethi.HienThi_MaDe_By_MaCauHoi(txtMaCauHoi.Text.Trim().ToString()) == false && da.Delete_DapAn() > 0 && ch.Delete_CauHoi() > 0)
                    {
                        XoaTrang();
                        if (us.Check_Quyen() != "BGH")
                            Show_All_ID();
                        else
                            Show_All();
                        MessageBox.Show("Xóa Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng xóa mã đề trước khi xóa câu hỏi");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn câu hỏi muốn xóa");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xãy ra lỗi");
            }
        }

        private void txtMaCauHoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaCauHoi.Text.Length == 2 && e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }
    }
}
