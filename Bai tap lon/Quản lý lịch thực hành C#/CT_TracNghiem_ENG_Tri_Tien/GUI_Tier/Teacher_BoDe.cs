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
    public partial class Teacher_BoDe : Form
    {
        public Teacher_BoDe()
        {
            InitializeComponent();
        }
        CauHoi_Bus ch;
        DeThi_Bus dethi;
        User_Bus us;
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (lvwDe_CauHoi.Items.Count > 0)
            {
                if (MessageBox.Show("Nếu bạn thoát dữ liệu hiện tại sẽ bị mất?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    this.DialogResult = DialogResult.Cancel;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }
        private void SangPhai()
        {
            while (lvwToanBoCauHoi.SelectedItems.Count > 0)
            {
                ListViewItem li = lvwToanBoCauHoi.SelectedItems[0];
                lvwToanBoCauHoi.Items.Remove(li);
                lvwDe_CauHoi.Items.Add(li);

            }
            lblSoCauHoi.Text = lvwDe_CauHoi.Items.Count.ToString() + " câu hỏi";
        }
        private void SangTrai()
        {
            while (lvwDe_CauHoi.SelectedItems.Count > 0)
            {
                ListViewItem li = lvwDe_CauHoi.SelectedItems[0];
                lvwDe_CauHoi.Items.Remove(li);
                lvwToanBoCauHoi.Items.Add(li);
            }
            lblSoCauHoi.Text = lvwDe_CauHoi.Items.Count.ToString() + " câu hỏi";
        }
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            SangPhai();
        }
        private void Show_All()
        {
            lvwToanBoCauHoi.Items.Clear();
            ch = new CauHoi_Bus();
            DataView dtv = ch.Show_All();
            dtv.Sort = "macauhoi";
            foreach (DataRowView dtrv in dtv)
            {
                ListViewItem li = lvwToanBoCauHoi.Items.Add(dtrv["macauhoi"].ToString());
                li.SubItems.Add(dtrv["noidungcauhoi"].ToString());
            }
        }
        private void HienThiMaDe()
        {
            us = new User_Bus(DangNhap.TenDangNhap,DangNhap.MatKhau);
            cboMaDe.Items.Clear();
            dethi = new DeThi_Bus();
            DataTable dt = new DataTable();
            if(us.Check_Quyen()!="BGH")
            dt = dethi.HienThi_MaDe(DangNhap.TenDangNhap).Tables["tb_dethi"];
            else
            dt = dethi.HienThi_MaDe_All().Tables["tb_dethi"];
            foreach (DataRow dr in dt.Rows)
            {
                cboMaDe.Items.Add(dr["made"].ToString());
            }
        }
        private void Teacher_BoDe_Load(object sender, EventArgs e)
        {
            HienThiMaDe();
            Show_All();
        }
        private bool TaoDe()
        {

            if (lvwDe_CauHoi.Items.Count != 30 && lvwDe_CauHoi.Items.Count != 60)
            {
                MessageBox.Show("Số câu hỏi không hợp lệ");
                return false;
            }
            else
            {
                for (int i = 0; i < lvwDe_CauHoi.Items.Count; i++)
                {
                    dethi = new DeThi_Bus(cboMaDe.Text, lvwDe_CauHoi.Items[i].Text.Trim().ToString(), DangNhap.TenDangNhap);
                    dethi.TaoDe();
                }
                HienThiMaDe();
                return true;
            }
        }
        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTaoDe.Text == "TẠO ĐỀ")
                {
                    if (cboMaDe.Text.Trim().ToString() == "")
                    {
                        MessageBox.Show("Mã đề chưa nhập");
                        return;
                    }
                    else
                    {
                        if (TaoDe() == true)
                        {
                            lblSoCauHoi.Text = "";
                            MessageBox.Show("Tạo đề thành công");
                            lvwDe_CauHoi.Items.Clear();
                            cboMaDe.Text = "";
                            Show_All();
                        }
                    }
                }
                else
                {
                    SuaDe();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xãy ra lỗi");
            }
        }
        private void SuaDe()
        {
            try
            {
                dethi = new DeThi_Bus(cboMaDe.Text.Trim().ToString());
                dethi.XoaDe();
                if (TaoDe() == true)
                    MessageBox.Show("Cập nhật thành công");
                btnTaoDe.Text = "TẠO ĐỀ";
                lvwDe_CauHoi.Items.Clear();
                cboMaDe.Text = "";
                lblSoCauHoi.Text = "";
                Show_All();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xãy ra lỗi");
            }
        }
        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            SangTrai();
        }
        private void HienThi_List_Combo()
        {
            lvwDe_CauHoi.Items.Clear();
            dethi = new DeThi_Bus();
            DataTable dt = dethi.HienThi_List_Combo(cboMaDe.Text.Trim().ToString()).Tables["tb_DeThi_CauHoi"];
            //dr[0]: mã câu hỏi ở bảng Đề thi
            //dr[1]: nội dung câu hỏi ở bảng Câu Hỏi
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem li = lvwDe_CauHoi.Items.Add(dr[0].ToString());
                li.SubItems.Add(dr[1].ToString());
            }
            lblSoCauHoi.Text = lvwDe_CauHoi.Items.Count.ToString() + " câu hỏi";
            btnTaoDe.Text = "SỬA ĐỀ";
        }
        private void cboMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_All();
            HienThi_List_Combo();
            for (int i = 0; i < lvwDe_CauHoi.Items.Count; i++)
            {
                for (int j = 0; j < lvwToanBoCauHoi.Items.Count; j++)
                {
                    if (lvwDe_CauHoi.Items[i].Text == lvwToanBoCauHoi.Items[j].Text)
                        lvwToanBoCauHoi.Items.RemoveAt(j);
                }
            }
        }

        private void btnXoaCacItemBoDe_Click(object sender, EventArgs e)
        {
            cboMaDe.Text = "";
            lvwDe_CauHoi.Items.Clear();
            lblSoCauHoi.Text = "";
            btnTaoDe.Text = "TẠO ĐỀ";
        }

        private void btnXoaDe_Click(object sender, EventArgs e)
        {
            dethi = new DeThi_Bus(cboMaDe.Text.Trim().ToString());
            if (dethi.XoaDe() > 0)
            {
                MessageBox.Show("Xóa đề thành công");
                lvwDe_CauHoi.Items.Clear();
                cboMaDe.Items.Remove(cboMaDe.Text.Trim().ToString());
                cboMaDe.Text = "";
                HienThiMaDe();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại");
            }
        }

        private void cboMaDe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTaoDe_Click(sender, e);
        }

        private void lvwToanBoCauHoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                btnSangPhai_Click(sender, e);
        }

        private void lvwDe_CauHoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btnSangTrai_Click(sender, e);
        }
    }
}
