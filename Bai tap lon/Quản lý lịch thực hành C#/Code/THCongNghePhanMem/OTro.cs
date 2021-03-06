using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THCongNghePhanMem
{
    public partial class OTro : Form
    {
        KetNoi kn = new KetNoi();
        DocDuLieu dl = new DocDuLieu();
        public OTro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //nút tìm
        private void button1_Click(object sender, EventArgs e)
        {
            int kq;
            if (this.cbMSSV.Checked==false&&this.cbDiaChi.Checked == false && this.cbChuNha.Checked == false)
            {

                MessageBox.Show("Bạn chưa chọn thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.groupBox2.Focus();
                return;
            }
            else
            {
                if (this.cbMSSV.Checked == true)
                {
                    if (this.cbDiaChi.Checked == true)
                    {
                        if (this.cbChuNha.Checked == true)
                        {
                            kq = TimOTroTheoMSSV_DiaChi_ChuNha(this.tbMSSV.Text, this.tbDiaChi.Text, this.tbChuNha.Text);

                        }
                        else
                        {
                            kq = TimOTroTheoMSSV_DiaChi(this.tbMSSV.Text, this.tbDiaChi.Text);
                            this.tbChuNha.Clear();
                        }

                    }
                    else
                    {
                        if (this.cbChuNha.Checked == true)
                        {
                            kq = TimOTroTheoMSSV_ChuNha(this.tbMSSV.Text, this.tbChuNha.Text);
                            this.tbDiaChi.Clear();
                        }
                        else
                        {
                            kq = TimOTroTheoMSSV(this.tbMSSV.Text);
                            this.tbDiaChi.Clear();
                            this.tbChuNha.Clear();
                        }

                    }
                }
                else
                {
                    if (this.cbDiaChi.Checked == true && this.cbChuNha.Checked == true)
                    {
                        kq = TimOTroTheoDiaChi_ChuNha(this.tbDiaChi.Text, this.tbChuNha.Text);
                        this.tbMSSV.Clear();
                    }
                }
            }
        }
        private int TimOTroTheoDiaChi_ChuNha(string diachi, string chunha)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@diachi", diachi);
            para[1] = new SqlParameter("@chunha", chunha);
            DataTable table = dl.DocDLSP("TimOTroTheoDiaChi_ChuNha", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimOTroTheoMSSV(string masv)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@masv", masv);
            DataTable table = dl.DocDLSP("TimOTroTheoMSSV", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimOTroTheoMSSV_ChuNha(string masv, string chunha)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@masv", masv);
            para[1] = new SqlParameter("@chunha", chunha);
            DataTable table = dl.DocDLSP("TimOTroTheoMSSV_ChuNha", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimOTroTheoMSSV_DiaChi_ChuNha(string maSV, string diaChi, string chuNha)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@masv", maSV);
            para[1] = new SqlParameter("@diachi",diaChi);
            para[2] = new SqlParameter("@chunha",chuNha);
            DataTable table = dl.DocDLSP("TimOTroTheoMSSV_DiaChi_ChuNha", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimOTroTheoMSSV_DiaChi(string masv, string diachi)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@masv", masv);
            para[1] = new SqlParameter("@diachi",diachi);
            DataTable table = dl.DocDLSP("TimOTroTheoMSSV_DiaChi", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            this.tbMSSV.Text = "";
            this.tbMSSV.Focus();
            this.tbDiaChi.Text = "";
            this.tbChuNha.Text = "";
            this.dtNgayDen.Value = DateTime.Now;
            this.dtNgayDi.Value = DateTime.Now;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OTro_Load(object sender, EventArgs e)
        {
           
            //kn.Close();
            
            //this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOTro");
            //kn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NhaTro nt = new NhaTro();
            nt.ShowDialog();
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            kn.Open();
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOTro");
            kn.Close();
        }

        private void cbChon_MouseMove(object sender, MouseEventArgs e)
        {
            this.label6.Text = "(*) Bạn có thể chọn hoặc bỏ chọn ngày đi";
        }

        private void cbChon_MouseHover(object sender, EventArgs e)
        {
            //this.cbChon.Text = "Bạn có thể chọn hoặc bỏ chọn ngay đi";
        }

        private void cbChon_MouseLeave(object sender, EventArgs e)
        {
            this.label6.Text = "";
        }

        private void cbChon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbChon.Checked == true)
                this.dtNgayDi.Visible = false;
            else
                this.dtNgayDi.Visible = true;
        }


        //nút thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            int kq;
            if (this.tbMSSV.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0 && this.tbDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ở trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.tbMSSV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập MSSV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (this.tbDiaChi.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập địa chỉ nhà trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (this.tbChuNha.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập họ và tên chủ nhà trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            if (this.dtNgayDi.Visible == true)
                            {
                                if (this.dtNgayDen.Value > this.dtNgayDi.Value)
                                {
                                    MessageBox.Show("Ngày đến không thể lớn hơn ngày đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.dtNgayDen.Focus();
                                }
                                else
                                {
                                    kq = ThemOTro(this.tbMSSV.Text, this.tbDiaChi.Text, this.tbChuNha.Text, this.dtNgayDen.Value.Date, this.dtNgayDi.Value.Date);
                                    if (kq == 1)
                                    {
                                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOTro");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                kq = ThemOTroKhongNgayDi(this.tbMSSV.Text, this.tbDiaChi.Text, this.tbChuNha.Text, this.dtNgayDen.Value.Date);
                                if (kq == 1)
                                {
                                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOTro");
                                }
                                else
                                {
                                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        
                    }

                }
            }
        }
        private int ThemOTro(string maSV, string diaChi, string chuNha, DateTime ngayDen, DateTime ngayDi)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@masv", KiemTraSinhVien(maSV));
            para[1] = new SqlParameter("@diachi",KiemTraDiaChi( diaChi));
            para[2] = new SqlParameter("@chunha", KiemTraChuNha( chuNha));
            para[3] = new SqlParameter("@ngayden", ngayDen);
            para[4] = new SqlParameter("@ngaydi", ngayDi);
            para[5] = new SqlParameter("@kq", 0);
            para[5].Direction = ParameterDirection.Output;
            int kq = dl.Insert_Delete_UpDate("ThemOTro", para);
            return kq;
        }
        private string KiemTraSinhVien(string masv)
        {
            SqlParameter []paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@masv",masv);
            DataTable table = dl.DocDLSP("TimSVTheoMa", paras);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("MSSV bạn vừa nhập chưa có trong danh sách sinh viên, mời bạn nhập mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SinhVien frm = new SinhVien();
                frm.ShowDialog();
                //this.Close();
            }
            return masv;

        }
        private string KiemTraDiaChi(string diachi)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@diachi", diachi);
            DataTable table = dl.DocDLSP("TimNhaTroTheoDiaChi", paras);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Địa chỉ bạn vừa nhập chưa có trong danh sách nhà trọ, mời bạn nhập mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhaTro frm = new NhaTro();
                frm.ShowDialog();
                //this.Close();
            }
            return diachi;

        }
        private string KiemTraChuNha(string chunha)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@chunha", chunha);
            DataTable table = dl.DocDLSP("TimNhaTroTheoChuNha", paras);
            if (table.Rows.Count == 0)
            {
               MessageBox.Show("Chủ nhà bạn vừa nhập chưa có trong danh sách nhà trọ, mời bạn nhập mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhaTro frm = new NhaTro();
                frm.ShowDialog();
            }
            return chunha;

        }
        private int ThemOTroKhongNgayDi(string maSV, string diaChi, string chuNha, DateTime ngayDen)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@masv", KiemTraSinhVien(maSV));
            para[1] = new SqlParameter("@diachi",KiemTraDiaChi( diaChi));
            para[2] = new SqlParameter("@chunha", KiemTraChuNha( chuNha));
            para[3] = new SqlParameter("@ngayden", ngayDen);
            para[4] = new SqlParameter("@kq", 0);
            para[4].Direction = ParameterDirection.Output;
            int kq = dl.Insert_Delete_UpDate("ThemOTroKhongNgayDi", para);
            return kq;
        }
        
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = int.Parse(e.RowIndex.ToString());
            this.tbMSSV.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.tbDiaChi.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.tbChuNha.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            this.dtNgayDen.Text = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.dtNgayDi.Text = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        //nút xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.tbMSSV.Text.Trim().Length==0&&this.tbDiaChi.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin ở trọ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.tbMSSV.Text.Trim().Length == 0)
                    MessageBox.Show("Bạn chưa nhập MSSV cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (this.tbDiaChi.Text.Trim().Length == 0)
                        MessageBox.Show("Bạn chưa nhập địa chỉ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (this.tbChuNha.Text.Trim().Length == 0)
                            MessageBox.Show("Bạn chưa nhập chủ nhà cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            int kq = XoaOTro(tbMSSV.Text,tbDiaChi.Text, tbChuNha.Text,dtNgayDen.Value);
                            if (kq == 1)
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Thông tin ở trọ bạn đã nhập chưa có trong dang sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOTro");
                        }
                    }
                }
            }
        }
        private int XoaOTro(string maSV, string diaChi, string chuNha, DateTime ngayDen)
        {
            try
            {
                kn.Open();
                SqlParameter[] para = new SqlParameter[4];
                para[0]=new SqlParameter("@masv",maSV);
                para[1] = new SqlParameter("@diachi", diaChi);
                para[2] = new SqlParameter("@chunha", chuNha);
                para[3] = new SqlParameter("@ngayden",ngayDen);
                int kq = dl.Insert_Delete_UpDate("XoaOTro", para);
                kn.Close();
                return kq;
            }
            catch
            {
                return -1;
            }
        }

        //nut Cap nhat
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (this.tbMSSV.Text.Trim().Length==0&&this.tbDiaChi.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ở trọ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (this.tbMSSV.Text.Trim().Length == 0)
                    MessageBox.Show("Bạn chưa nhập MSSV cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (this.tbDiaChi.Text.Trim().Length == 0)
                        MessageBox.Show("Bạn chưa nhập địa chỉ nhà trọ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (this.tbChuNha.Text.Trim().Length == 0)
                            MessageBox.Show("Bạn chưa nhập chủ nhà nhà trọ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            if (CapNhatOTro(this.tbMSSV.Text,this.tbDiaChi.Text, this.tbChuNha.Text, this.dtNgayDen.Value,this.dtNgayDi.Value) > 0)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thông tin ở trọ bạn vừa nhập chưa có trong danh sách, bạn có thể thêm nha trọ này vào danh sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatOtro");
        }
        private int CapNhatOTro(string maSV, string diaChi, string chuNha, DateTime ngayDen, DateTime ngayDi)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@masv", maSV);
            para[1] = new SqlParameter("@diachi", diaChi);
            para[2] = new SqlParameter("@chunha", chuNha);
            para[3] = new SqlParameter("@ngayden",ngayDen);
            para[4] = new SqlParameter("@ngaydi",ngayDi);
            int kq = dl.Insert_Delete_UpDate("CapNhatOTro", para);
            return kq;
        }
    }
}