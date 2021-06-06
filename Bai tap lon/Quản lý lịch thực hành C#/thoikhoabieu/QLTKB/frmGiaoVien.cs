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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdc.Text = "";
            txtns.Text = "";
            cbgt.Text = "";
            cbcm.Text = "";
        }
        public void Locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdc.Enabled = false;
            txtns.Enabled = false;
            cbgt.Enabled = false;
            cbcm.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtns.Enabled = true;
            cbgt.Enabled = true;
            cbcm.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã GV";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Họ Tên";
            msds.Columns[1].Width = 150;

            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 150;

            msds.Columns[3].HeaderText = "Ngày Sinh";
            msds.Columns[3].Width = 150;

            msds.Columns[4].HeaderText = "Giới Tính";
            msds.Columns[4].Width = 150;

            msds.Columns[5].HeaderText = "Chuyên Môn";
            msds.Columns[5].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblGiaoVien";
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
                string sql = "Select count(*) from tblGiaoVien where MaGV=N'" + txtma.Text + "'";
                if (cn.LoadLable(sql) == "0")
                {
                    cn.ExcuteNonQuery("insert into tblGiaoVien values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtdc.Text + "',N'" + txtns.Text + "',N'" + cbgt.Text + "',N'" + cbcm.Text + "')");
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
                    txtma.Focus();
                }
            }
            else
            {
                cn.ExcuteNonQuery("update tblGiaoVien set TenGV=N'" + txtten.Text + "',DiaChi=N'" + txtdc.Text + "',NgaySinh=N'" + txtns.Text + "',GioiTinh=N'" + cbgt.Text + "',MaMon=N'" + cbcm.Text + "' where MaGV=N'" + txtma.Text + "'");
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
            txtma.Enabled = false;
            Un_locktex();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("delete tblGiaoVien where MaGV=N'" + txtma.Text + "'");
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
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtns.Text = msds.Rows[dong].Cells[3].Value.ToString();
            cbgt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbcm.Text = msds.Rows[dong].Cells[4].Value.ToString();
        }

        private void fr_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
            cn.LoadLenCombobox(cbcm,"Select MaMon from tblMonHoc",0);
        }

        private void cbcm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbten.Text=cn.LoadLable("Select TenMon from tblMonHoc where MaMon=N'"+cbcm.Text+"'");
        }
    }
}
