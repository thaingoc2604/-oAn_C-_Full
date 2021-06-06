using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BUS_Tier;
namespace frmAdministrator
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
        bMucDo objmd = new bMucDo();
        bTinChi objtc = new bTinChi();
        bDapAn objda = new bDapAn();

        DataTable tbmucdo, tbtinchi, tbdapan;

        BindingSource bs = new BindingSource();
        //truyền chuỗi về form edit
        public delegate void pass(string noidung, int dapandung, int mucdo, int tinchi);
        public pass pa;

        //truyền thông tin đóng form
        public delegate void pass2();
        public pass2 pa2;
        int conf = 0;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pa != null)
            {
                if (this.tbNoidung.Text != "" || this.cbMucdo.SelectedIndex > -1 || this.cbDapandung.SelectedIndex > -1 || this.cbTinChi.SelectedIndex > -1)
                {
                    pa(this.tbNoidung.Text, this.cbDapandung.SelectedIndex, this.cbMucdo.SelectedIndex, this.cbTinChi.SelectedIndex);
                    conf = 1;
                }
                else MessageBox.Show("Bạn phải nhập ít nhất 1 trong các lựa chọn trên (^_^)!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            if (pa2 != null)
            {
                if (conf == 1) { pa2(); conf = 0; };
            }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void ketnoi()
        {
            tbmucdo = objmd.get_table_MuDo();
            tbtinchi = objtc.get_table_TinChi();
            tbdapan = objda.get_table_DapAn();

            try
            {
                tbtinchi = objtc.get_table_TinChi();
                this.cbDapandung.Items.Add("Tất cả đáp án đúng");
                this.cbTinChi.Items.Add("Tất cả tín chỉ");
                this.cbMucdo.Items.Add("Tất cả các mức độ");

                //Xử lý trên combobox tín chỉ
                foreach (DataRow dr in tbtinchi.Rows)
                {
                    cbTinChi.Items.Add(dr["TenTC"].ToString());
                }

                // xử lý trên comboxbox mức độ
                foreach (DataRow dr in tbmucdo.Rows)
                {
                    cbMucdo.Items.Add(dr["TenMD"].ToString());
                }

                //Xử lý trên combobox đáp án đúng
                foreach (DataRow dr in tbdapan.Rows)
                {
                    cbDapandung.Items.Add(dr["Ten"].ToString());

                }

                this.cbDapandung.SelectedIndex = 0;
                this.cbTinChi.SelectedIndex = 0;
                this.cbMucdo.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thực hiện thao tác tìm kiếm", this.btnSearch, new Point(1, -67));
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnSearch);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Đóng giao diện tìm kiếm", this.btnCancel, new Point(1, -67));
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnCancel);
        }


    }
}
