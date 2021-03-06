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
    public partial class NhaTro : Form
    {
        KetNoi kn = new KetNoi();
        DocDuLieu dl = new DocDuLieu();
        public NhaTro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbDiaChi.Text = "";
            this.tbDiaChi.Focus();
            this.tbChuNha.Text = "";
            this.tbSDT.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhaTro_Load(object sender, EventArgs e)
        {

            //kn.Close();

            //this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatNhaTro");
            //kn.Close();
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            kn.Open();
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatNhaTro");
            kn.Close();
        }
        //nút thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            if (this.tbDiaChi.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin nhà trọ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Bạn chưa nhập họ và tên chủ nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        int kq = ThemNhaTro(this.tbDiaChi.Text, this.tbChuNha.Text, this.tbSDT.Text);
                        if (kq == 1)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatNhaTro");
                        }
                        else
                        {
                            MessageBox.Show("Nhà trọ này đã có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            
        }
        public int ThemNhaTro(string diachi, string chunha, string sdt)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@diachi", diachi);
            para[1] = new SqlParameter("@chunha", chunha);
            para[2] = new SqlParameter("@sodt", sdt);
            para[3] = new SqlParameter("@kq", 0);
            para[3].Direction = ParameterDirection.Output;
            int kq = dl.Insert_Delete_UpDate("ThemNhaTro", para);
            return kq;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = int.Parse(e.RowIndex.ToString());
            this.tbDiaChi.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.tbChuNha.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.tbSDT.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.tbDiaChi.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin nhà trọ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        int kq = XoaNhaTro(tbDiaChi.Text, tbChuNha.Text);
                        if (kq == 1)
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Nhà trọ bạn đã nhập chưa có trong dang sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatNhaTro");
                    }
                }
            }
        }
        public int XoaNhaTro(string diaChi, string chuNha)
        {
            try
            {
                kn.Open();
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@diachi",diaChi);
                para[1] = new SqlParameter("@chunha",chuNha);
                int kq = dl.Insert_Delete_UpDate("XoaNhaTro", para);
                kn.Close();
                return kq;
            }
            catch
            {
                return -1;
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (this.tbDiaChi.Text.Trim().Length == 0 && this.tbChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin nhà trọ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                        if (CapNhatNhaTro(this.tbDiaChi.Text, this.tbChuNha.Text, this.tbSDT.Text) > 0)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nhà trọ bạn vừa nhập chưa có trong danh sách, bạn có thể thêm nha trọ này vào danh sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatNhatro");
        }
        private int CapNhatNhaTro(string diaChi,string chuNha,string sdt)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@diachi", diaChi);
            para[1] = new SqlParameter("@chunha", chuNha);
            para[2] = new SqlParameter("@sdt", sdt);
            int kq = dl.Insert_Delete_UpDate("CapNhatNhaTro", para);
            return kq;
        }

        //nut tim
        private void btTim_Click(object sender, EventArgs e)
        {

            int kq;
            if (this.cbDiaChi.Checked == false && this.cbChuNha.Checked == false)
            {

                MessageBox.Show("Bạn chưa chọn thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.groupBox2.Focus();
                return;
            }
            else
            {
                if (this.cbDiaChi.Checked == true)
                {
                    if (this.cbChuNha.Checked == true)
                    {
                        kq = TimNhaTroTheoDiaChi_ChuNha(this.tbDiaChi.Text, this.tbChuNha.Text);
                        this.tbSDT.Clear();
                    }
                    else
                    {
                        kq = TimNhaTroTheoDiaChi(this.tbDiaChi.Text);
                        this.tbChuNha.Clear();
                        this.tbSDT.Clear();
                    }

                }
                else
                {
                    if (this.cbChuNha.Checked == true)
                    {
                        kq = TimNhaTroTheoChuNha(this.tbChuNha.Text);
                        this.tbDiaChi.Clear();
                        this.tbSDT.Clear();
                    }
                    
                }
            }
        }
        private int TimNhaTroTheoDiaChi_ChuNha(string diaChi, string chuNha)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@diachi",diaChi);
            para[1] = new SqlParameter("@chunha",chuNha);
            DataTable table = dl.DocDLSP("TimNhaTroTheoDiaChi_ChuNha", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimNhaTroTheoDiaChi(string diaChi)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@diachi", diaChi);
            DataTable table = dl.DocDLSP("TimNhaTroTheoDiaChi", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        private int TimNhaTroTheoChuNha(string chuNha)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@chunha", chuNha);
            DataTable table = dl.DocDLSP("TimNhaTroTheoChuNha", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
    }

}