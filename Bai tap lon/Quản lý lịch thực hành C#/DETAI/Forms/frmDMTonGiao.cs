using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DETAI
{
    public partial class frmDMTonGiao : Form
    {
        clsdmtongiao c = new clsdmtongiao();
        int k = 0;
        public frmDMTonGiao()
        {
            InitializeComponent();
            c.laydl("tbl_DMTonGiao");
            txtmatg.DataBindings.Add("text", c.ds, "tbl_DMTonGiao.MaTG");
            txttentg.DataBindings.Add("text", c.ds, "tbl_DMTonGiao.TenTG");
            dgv_DMTG.DataSource = c.ds;
            dgv_DMTG.DataMember = "tbl_DMTonGiao";
        }
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void frmDMTonGiao_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmatg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
                txtmatg.Text = "";
                txtmatg.Focus();
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMTG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_DMTonGiao", int.Parse(txtmatg.Text.Trim()), "MaTG");
                    c.laydl("tbl_DMTonGiao");
                    
                }
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmatg.Text = "";
            txttentg.Text = "";
            txtmatg.ReadOnly = false;
            txttentg.ReadOnly = false;
            txtmatg.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMTG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để cập nhật", "Thông Báo");
                return;
            }
            else
            {
                txttentg.ReadOnly = false;
                txttentg.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu không??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmatg.Text == "" || txttentg.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {   //thêm mẩu tin mới vào datagirdview
                        c.them("tbl_dmTonGiao", int.Parse(txtmatg.Text.Trim())
                            , txttentg.Text.Trim());                        
                    }
                }
                else if (k == 2)
                {
                    if (txtmatg.Text == "" || txttentg.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        //cập nhật mẩu tin
                        c.sua("tbl_DMTonGiao", int.Parse(txtmatg.Text.Trim()),
                            txttentg.Text.Trim(), "MaTG", "tenTG");
                    }
                }
            }
            //load lại dữ liệu
            c.laydl("tbl_DMTonGiao");
            txtmatg.ReadOnly = true;
            txttentg.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}
        