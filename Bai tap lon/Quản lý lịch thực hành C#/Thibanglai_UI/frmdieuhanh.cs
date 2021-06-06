using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tracnghiem_bs;

namespace Thibanglai_UI
{
    public partial class frmdieuhanh : Form
    {
        public frmdieuhanh()
        {
            InitializeComponent();
        }
        thisinhbs objts = new thisinhbs();
        nhanvienbs objnv = new nhanvienbs();
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        public Mydlg GetStringFromAnotherFormdn2;
        public int sl;
        public int flag = 0;
        
        private void frmdieuhanh_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            quảnLýToolStripMenuItem.Enabled = false;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;


            label1.Visible = false;
            label3.Visible = false;
            label1.Text = GetStringFromAnotherFormdn();

            DataTable dt = new DataTable();
            dt = objnv.ThongTinNV(label1.Text).Tables[0];
            DataRow dr;
            dr = dt.Rows[0];
            label2.Text = "Tên nhân viên: " + dr[1].ToString();
            label3.Text = dr[4].ToString();
            label12.Text = dr[0].ToString();
            label11.Visible = false;
            label12.Visible = false;
            label4.Visible = false;
            if (label3.Text.ToString().Trim() == "Điều hành")
            {
                quảnLýToolStripMenuItem.Enabled = true;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;

            }

            label_luu.Enabled = false;
            
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdangnhap f = new frmdangnhap();
            f.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ttnganhangcauhoi") == false)
            {
                frmnganhangcauhoi f = new frmnganhangcauhoi();
                f.Name = "ttnganhangcauhoi";

                f.Show();
            }
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ttdsthisinh") == false)
            {
                frmdanhsachts f = new frmdanhsachts();
                f.Name = "ttdsthisinh";
              
                f.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
             if (KiemTraTonTai("ttdsnhanvien") == false)
            {
                frmthongtinnv f = new frmthongtinnv();
                f.Name = "ttdsnhanvien";
                
                f.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("quanlycauhoi") == false)
            {
                frmquanlych f = new frmquanlych();
                f.Name = "quanlycauhoi";
              
                
                f.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
             if (KiemTraTonTai("quanlinv") == false)
            {
                frmquanlynv f = new frmquanlynv();
                f.Name = "quanlinv";
              
                f.Show();
            }
        }
     private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
              if (KiemTraTonTai("xoanv") == false)
            {
                frmxoanv f = new frmxoanv();
                f.Name = "xoanv";
               
                f.Show();
            }
        }
        public void HienTTNV()
        {
            DataTable dt = objnv.GetNhanVien_Ma(label12.Text).Tables[0];
            textBox_ma.Text = dt.Rows[0][0].ToString();
            textBox_ten.Text = dt.Rows[0][1].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_sdt.Text = dt.Rows[0][3].ToString();
            textBox_ns.Text = dt.Rows[0][4].ToString();
        }
        public void TextBox()
        {

            textBox_dc.BorderStyle = BorderStyle.FixedSingle;
            textBox_sdt.BorderStyle = BorderStyle.FixedSingle;
            textBox_ns.BorderStyle = BorderStyle.FixedSingle;
        }
        public void TextBoxF()
        {

            textBox_dc.BorderStyle = BorderStyle.None;
            textBox_sdt.BorderStyle = BorderStyle.None;
            textBox_ns.BorderStyle = BorderStyle.None;
        }
        private void label_luu_Click(object sender, EventArgs e)
        {
            objnv.UpdateNhanvien(textBox_dc.Text.ToString().Trim(), textBox_sdt.Text.ToString().Trim(), textBox_ma.Text.ToString().Trim());


            MessageBox.Show("Đã cập nhật thao tác");
            label_luu.Enabled = false;
            label1_cs.Text = "Chỉnh sửa";
            TextBoxF();
            HienTTNV();
        }

        private void label1_cs_Click(object sender, EventArgs e)
        {
            if (label1_cs.Text == "Chỉnh sửa")
            {
                TextBox();
                label1_cs.Text = "Hủy thao tác";
                label_luu.Enabled = true;
            }
            else
            {
                TextBoxF();
                HienTTNV();
                label1_cs.Text = "Chỉnh sửa";
                label_luu.Enabled = false;
            }
        }
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void label18_Click(object sender, EventArgs e)
        {
            if (label18.Text == "Hiện thông tin cá nhân")
            {
                panel1.Visible = true;
                label18.Text = "Ẩn thông tin cá nhân";
                HienTTNV();
                TextBoxF();
            }
            else
            {
                panel1.Visible = false;
                label18.Text = "Hiện thông tin cá nhân";
                TextBoxF();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            DialogResult OK;
            OK = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            this.Close();
            frmdangnhap f = new frmdangnhap();
            f.ShowDialog();
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ttnganhangcauhoi") == false)
            {
               frmnganhangcauhoi f = new frmnganhangcauhoi();
                f.Name = "ttnganhangcauhoi";

                f.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ttdsthisinh") == false)
            {
                frmdanhsachts f = new frmdanhsachts();
                f.Name = "ttdsthisinh";

                f.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("ttdsnhanvien") == false)
            {
                frmthongtinnv f = new frmthongtinnv();
                f.Name = "ttdsnhanvien";

                f.Show();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("quanlycauhoi") == false)
            {
                frmquanlych f = new frmquanlych();
                f.Name = "quanlycauhoi";


                f.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("quanlinv") == false)
            {
                frmquanlynv f = new frmquanlynv();
                f.Name = "quanlinv";

                f.Show();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("xoanv") == false)
            {
                frmxoanv f = new frmxoanv();
                f.Name = "xoanv";

                f.Show();
            }
        }
    }
}