using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTKB
{
    public partial class frmXepTKB : Form
    {
        public frmXepTKB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            cbngay.Text = "";
            cbgv.Text = "";
            cblop.Text = "";
            cbmh.Text = "";
            cbph.Text = "";
            cbb.Text = "";
        }
        public void Locktext()
        {
            cbngay.Enabled = false;
            cbgv.Enabled = false;
            cblop.Enabled = false;
            cbmh.Enabled = false;
            cbph.Enabled = false;
            cbb.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            cbngay.Enabled = true;
            cbgv.Enabled = true;
            cblop.Enabled = true;
            cbmh.Enabled = true;
            cbph.Enabled = true;
            cbb.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Ngày";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Giáo Viên";
            msds.Columns[1].Width = 150;

            msds.Columns[2].HeaderText = "Lớp";
            msds.Columns[2].Width = 150;

            msds.Columns[3].HeaderText = "Môn Học";
            msds.Columns[3].Width = 150;

            msds.Columns[4].HeaderText = "Phòng Học";
            msds.Columns[4].Width = 150;

            msds.Columns[5].HeaderText = "Buổi";
            msds.Columns[5].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblTKB";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                string sql = "Select count(*) from tblTKB where Ngay =N'" + cbngay.Text + "' and MaGV =N'" + cbgv.Text + "' and MaLop =N'" + cblop.Text + "' and MaMon =N'" + cbmh.Text + "' and MaPhong =N'" + cbph.Text + "' and Buoi =N'" + cbb.Text + "'";
                if (cn.LoadLable(sql) == "0")
                {
                    cn.ExcuteNonQuery("insert into tblTKB values(N'" + cbngay.Text + "',N'" + cbgv.Text + "',N'" + cblop.Text + "',N'" + cbmh.Text + "',N'" + cbph.Text + "',N'" + cbb.Text + "')");
                    try
                    {
                        hienthi();
                        MessageBox.Show("Lưu Thành Công");
                    }
                    catch
                    {
                        MessageBox.Show("Lưu Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Này Đã Có");
                }
            }
            else
            {
                cn.ExcuteNonQuery("update tblTKB set where Ngay =N'" + cbngay.Text + "',MaGV =N'" + cbgv.Text + "',MaLop =N'" + cblop.Text + "',MaMon =N'" + cbmh.Text + "',MaPhong =N'" + cbph.Text + "',Buoi =N'" + cbb.Text + "' where Ngay =N'" + cbngay.Text + "' and MaGV =N'" + cbgv.Text + "' and MaLop =N'" + cblop.Text + "' and MaMon =N'" + cbmh.Text + "' and MaPhong =N'" + cbph.Text + "' and Buoi =N'" + cbb.Text + "'");
                try
                {
                    hienthi();
                    MessageBox.Show("Sửa Thành Công");
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Un_locktex();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("delete tblTKB where Ngay =N'" + cbngay.Text + "' and MaGV =N'" + cbgv.Text + "' and MaLop =N'" + cblop.Text + "' and MaMon =N'" + cbmh.Text + "' and MaPhong =N'" + cbph.Text + "' and Buoi =N'" + cbb.Text + "'");
            try
            {
                hienthi();
                MessageBox.Show("Xóa Thành Công");
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            cbngay.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbgv.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cblop.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbmh.Text = msds.Rows[dong].Cells[3].Value.ToString();
            cbph.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbb.Text = msds.Rows[dong].Cells[4].Value.ToString();
        }

        private void fr_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
            cn.LoadLenCombobox(cbmh, "Select MaMon from tblMonHoc", 0);
            cn.LoadLenCombobox(cbgv, "Select MaGV from tblGiaoVien", 0);
            cn.LoadLenCombobox(cblop, "Select MaLop from tblLop", 0);
            cn.LoadLenCombobox(cbph, "Select MaPhong from tblPhongHoc", 0);
        }

        private void cbgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbgv.Text = cn.LoadLable("Select TenGV from tblGiaoVien where MaGV=N'" + cbgv.Text + "'");
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblop.Text = cn.LoadLable("Select TenLop from tblLop where MaLop=N'" + cblop.Text + "'");
        }

        private void cbmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbmh.Text = cn.LoadLable("Select TenMon from tblMonHoc where MaMon=N'" + cbmh.Text + "'");
        }

        private void cbph_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbph.Text = cn.LoadLable("Select TenPhong from tblPhongHoc where MaPhong=N'" + cbph.Text + "'");
        }
    }
}
