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
    public partial class frmLop : Form
    {
        public frmLop()
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
            txtss.Text = "0";
            cbkhoa.Text = "";
        }
        public void Locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtss.Enabled = false;
            cbkhoa.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtss.Enabled = true;
            cbkhoa.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Lớp";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Tên Lớp";
            msds.Columns[1].Width = 150;

            msds.Columns[2].HeaderText = "Sỉ Số";
            msds.Columns[2].Width = 150;

            msds.Columns[3].HeaderText = "Khoa";
            msds.Columns[3].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblLop";
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
                string sql = "Select count(*) from tblLop where MaLop=N'" + txtma.Text + "'";
                if (cn.LoadLable(sql) == "0")
                {
                    cn.ExcuteNonQuery("insert into tblLop values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtss.Text + "',N'" + cbkhoa.Text + "')");
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
                cn.ExcuteNonQuery("update tblLop set TenLop=N'" + txtten.Text + "',SiSo=N'" + txtss.Text + "',MaKhoa=N'" + cbkhoa.Text + "' where MaLop=N'" + txtma.Text + "'");
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
            cn.ExcuteNonQuery("delete tblLop where MaLop=N'" + txtma.Text + "'");
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
            txtss.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbkhoa.Text = msds.Rows[dong].Cells[3].Value.ToString();
        }

        private void fr_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
            cn.LoadLenCombobox(cbkhoa, "select MaKhoa from tblKhoa", 0);
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbten.Text = cn.LoadLable("select TenKhoa from tblKhoa where MaKhoa=N'"+cbkhoa.Text+"'");
        }
    }
}
