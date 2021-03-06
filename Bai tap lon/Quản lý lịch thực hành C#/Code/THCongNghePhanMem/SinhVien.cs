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
    public partial class SinhVien : Form
    {
        KetNoi kn = new KetNoi();
        DocDuLieu dl = new DocDuLieu();
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

            //kn.Open();

            //this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatDSSV");
            //kn.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            kn.Open();
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatDSSV");
            kn.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (this.tbMSSV.Text.Trim().Length == 7)
            {
                if (this.tbHoTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập họ và tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (DateTime.Now.Year - this.dtNgaySinh.Value.Year < 17 || DateTime.Now.Year - this.dtNgaySinh.Value.Year > 60)
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ.\nTuổi của bạn tính đến hiện nay phải lớn hơn 17 và nhỏ hơn 60", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (this.rdNam.Checked == true || this.rdNu.Checked == true)
                        {
                            string s = "";
                            if (this.rdNam.Checked == true)
                                s = "Nam";
                            else
                                s = "Nu";
                            int kq = ThemSV(this.tbMSSV.Text, this.tbHoTen.Text, this.dtNgaySinh.Value.Date, s, this.tbQue.Text, this.tbLop.Text);
                            if (kq ==1)
                            {
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatDSSV");
                            }
                            else
                                {
                                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                               
                        }

                        else
                        {
                            MessageBox.Show("Bạn chưa chọn giới tính cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tbMSSV.Focus();
                            return;
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("MSSV phải có 7 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int ThemSV(string mssv, string hoten, DateTime ngaysinh, string gioitinh, string quequan, string lop)
        {
            
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@MSSV", mssv);
                para[1] = new SqlParameter("@HoTenSV", hoten);
                para[2] = new SqlParameter("@NgaySinh",ngaysinh);
                para[3] = new SqlParameter("@GioiTinh", gioitinh);
                para[4] = new SqlParameter("@QueQuan", quequan);
                para[5] = new SqlParameter("@Lop", lop);
                para[6] = new SqlParameter("@kq", 0);
                para[6].Direction = ParameterDirection.Output;
                int kq = dl.Insert_Delete_UpDate("Them_SV", para);
                return kq;

        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            this.tbMSSV.Text = "";
            this.tbMSSV.Focus();
            this.tbHoTen.Text = "";
            this.dtNgaySinh.Value = DateTime.Now;
            this.rdNam.Checked = false;
            this.rdNu.Checked = false;
            this.tbQue.Text = "";
            this.tbLop.Text = "";
        }


        //nút tìm
        private void btTim_Click(object sender, EventArgs e)
        {
            
            int kq;
            if (this.cbMSSV.Checked == true)
            {
                kq = TimSinhVienTheoMa(this.tbMSSV.Text);

                this.tbHoTen.Clear();
                this.dtNgaySinh.Value = DateTime.Now.Date;
                this.rdNam.Checked = false;
                this.rdNu.Checked = false;
                this.tbQue.Clear();
                this.tbLop.Clear();

            }
            else
            {
                if (this.cbHoTen.Checked == true)
                {
                    if (this.cbQueQuan.Checked == true)
                    {
                        if (this.cbLop.Checked == true)
                        {
                            kq = TimSVTheoHoTen_QueQuan_Lop(this.tbHoTen.Text, this.tbQue.Text, this.tbLop.Text);
                            this.tbMSSV.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                        }
                        else
                        {
                            kq = TimSVTheoHoTen_QueQuan(this.tbHoTen.Text, this.tbQue.Text);
                            this.tbMSSV.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                            this.tbLop.Clear();
                        }
                    }
                    else
                    {
                        if (this.cbLop.Checked == true)
                        {
                            kq = TimSVTheoHoTen_Lop(this.tbHoTen.Text, this.tbLop.Text);
                            this.tbMSSV.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                        }
                        else
                        {
                            kq = TimSVTheoHoTen(this.tbHoTen.Text);
                            this.tbMSSV.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                            this.tbQue.Clear();
                            this.tbLop.Clear();

                        }
                    }
                }
                else
                {
                    if (this.cbQueQuan.Checked == true)
                    {
                        if (this.cbLop.Checked == true)
                        {
                            kq = TimSVTheoQueQuan_Lop(this.tbQue.Text, this.tbLop.Text);
                            this.tbMSSV.Clear();
                            this.tbHoTen.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                        }
                        else
                        {
                            kq = TimSVTheoQueQuan(this.tbQue.Text);
                            this.tbMSSV.Clear();
                            this.tbHoTen.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                            this.tbLop.Clear();
                        }
                    }
                    else
                    {
                        if (this.cbLop.Checked == true)
                        {
                            kq = TimSVTheoLop(this.tbLop.Text);
                            this.tbMSSV.Clear();
                            this.tbHoTen.Clear();
                            this.rdNam.Checked = false;
                            this.rdNu.Checked = false;
                            this.dtNgaySinh.Value = DateTime.Now.Date;
                            this.tbQue.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.groupBox2.Focus();
                            return;
                        }
                    }
                }
            }
           
        }
        public int TimSinhVienTheoMa(string ma)
        {

                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@masv", ma);
                DataTable table = dl.DocDLSP("TimSVTheoMa", para);
                this.dataGridView1.DataSource = table;
                if (table.Rows.Count != 0)
                    return 1;
                else
                    return -1;

        }
        public int TimSVTheoMaSV_HoTen(string ma, string ten)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@masv", ma);
            para[1] = new SqlParameter("@hoten",ten);
            DataTable table = dl.DocDLSP("TimSVTheoMaSV_HoTen", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoHoTen_QueQuan_Lop(string ten, string que, string lop)
        {
            SqlParameter[] para= new SqlParameter[3];
            para[0] = new SqlParameter("@hoten",ten);
            para[1] = new SqlParameter("@quequan",que);
            para[2] = new SqlParameter("@lop",lop);
            DataTable table = dl.DocDLSP("TimSVTheoHoTen_Que_Lop",para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoHoTen_QueQuan(string ten, string que)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@hoten", ten);
            para[1] = new SqlParameter("@quequan", que);
            DataTable table = dl.DocDLSP("TimSVTheoHoTen_Que", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoHoTen_Lop(string ten, string lop)
        {
            SqlParameter[] para=new SqlParameter[2];
            para[0] = new SqlParameter("@hoten",ten);
            para[1] = new SqlParameter("@lop",lop);
            DataTable table = dl.DocDLSP("TimSVTheoHoTen_Lop",para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoHoTen(string ten)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@hoten", ten);
            DataTable table = dl.DocDLSP("TimSVTheoHoTen", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        
        public int TimSVTheoQueQuan_Lop(string que, string lop)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@quequan", que);
            para[1] = new SqlParameter("@lop", lop);
            DataTable table = dl.DocDLSP("TimSVTheoQueQuan_Lop", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoQueQuan(string que)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@quequan", que);
            DataTable table = dl.DocDLSP("TimSVTheoQueQuan", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        public int TimSVTheoLop(string lop)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Lop", lop);
            DataTable table = dl.DocDLSP("TimSVTheoLop", para);
            this.dataGridView1.DataSource = table;
            if (table.Rows.Count != 0)
                return 1;
            else
                return -1;
        }
        //nút xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.tbMSSV.Text.Trim().Length == 0)
                MessageBox.Show("Bạn chưa nhập MSSV cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int kq = XoaSinhVien(tbMSSV.Text);
                if (kq == 1)
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("MSSV không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatDSSV");
            }
        }
        private int XoaSinhVien(string ma)
        {
            try
            {
                kn.Open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@masv", ma);
                int kq = dl.Insert_Delete_UpDate("XoaSinhVien", para);
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
            string s = "";
            if (this.rdNam.Checked == true)
                s = "Nam";
            else
                s = "Nu";
            if (this.tbMSSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập dữ liệu để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (DateTime.Now.Year - this.dtNgaySinh.Value.Year < 17 || DateTime.Now.Year - this.dtNgaySinh.Value.Year > 60)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CapNhat(this.tbMSSV.Text, this.tbHoTen.Text, this.dtNgaySinh.Value.Date, s, this.tbQue.Text,this.tbLop.Text) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.dataGridView1.DataSource = dl.DocDLStoreprocedure("XuatDSSV");
        }
        private int CapNhat(string mssv, string hoten, DateTime ngaysinh, string gioitinh, string quequan, string lop )
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@MaSV", mssv);
            para[1] = new SqlParameter("@HoTenSV", hoten);
            para[2] = new SqlParameter("@NgaySinh", ngaysinh);
            para[3] = new SqlParameter("@GioiTinh", gioitinh);
            para[4] = new SqlParameter("@QueQuan", quequan);
            para[5] = new SqlParameter("@Lop", lop);
            int kq = dl.Insert_Delete_UpDate("CapNhatSV", para);
            return kq;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = int.Parse(e.RowIndex.ToString());
            this.tbMSSV.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.tbHoTen.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.dtNgaySinh.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (this.dataGridView1.Rows[i].Cells[3].Value.ToString().CompareTo("Nam") == 0)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.tbQue.Text = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.tbLop.Text = this.dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void cbMSSV_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbMSSV.Checked==true)
            //{
            //    this.tbHoTen.ReadOnly = true;
            //    this.tbLop.ReadOnly = true;
            //    this.tbQue.ReadOnly = true;
            //    this.rdNam.Checked = false;
            //    this.rdNu.Checked = false;
            //}
            //else
            //    {
            //        this.tbHoTen.ReadOnly = false;
            //        this.tbLop.ReadOnly = false;
            //        this.tbQue.ReadOnly = false;
            //    }


        }

        private void cbMSSV_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHoTen_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbHoTen.Checked == true)
            //{
            //    this.tbMSSV.ReadOnly = true;
            //    this.tbLop.ReadOnly = true;
            //    this.tbQue.ReadOnly = true;
            //    this.rdNam.Checked = false;
            //    this.rdNu.Checked = false;
            //}
            //else
            //{
            //    this.tbMSSV.ReadOnly = false;
            //    this.tbLop.ReadOnly = false;
            //    this.tbQue.ReadOnly = false;
            //}
        }
    }
}