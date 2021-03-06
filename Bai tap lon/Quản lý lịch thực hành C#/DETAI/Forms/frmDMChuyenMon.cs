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
    public partial class frmDMChuyenMon : Form
    {
        //khai báo biến toàn cục
        clsdmchuyenmon c = new clsdmchuyenmon();
        int k = 0;
        public frmDMChuyenMon()
        {
            InitializeComponent();
            c.laydl("tbl_DMChuyenMon");
            //lấy dữ liệu ra textbox
            txtmaCM.DataBindings.Add("text", c.ds, "tbl_DMChuyenMon.MaChuyenMon");
            txttenCM.DataBindings.Add("text", c.ds, "tbl_DMChuyenMon.TenChuyenMon");
            dgv_DMchuyenmon.DataSource = c.ds;
            dgv_DMchuyenmon.DataMember = "tbl_DMChuyenMon";
        }
        
        public void setbutton(bool b)
        {
            cmdcapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        private void frmDMChuyenMon_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmaCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmaCM.Text = "";
            txttenCM.Text = "";
            txtmaCM.ReadOnly = false;
            txttenCM.ReadOnly = false;
            txtmaCM.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMchuyenmon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_DMChuyenMon", int.Parse(txtmaCM.Text.Trim()), "MaChuyenMon");
                    c.laydl("tbl_DMChuyenMon");
                   
                }
            }
        }

        private void cmdcapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMchuyenmon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để cập nhật", "Thông Báo");
                return;
            }
            else
            {
                txttenCM.ReadOnly = false;
                txttenCM.Focus();
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
                    if (txtmaCM.Text == "" || txttenCM.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                    }
                    else
                    {
                        //them moi
                        c.them("tbl_dmchuyenmon", int.Parse(txtmaCM.Text.Trim()), txttenCM.Text.Trim());
                        c.laydl("tbl_DMChuyenMon");
                        txtmaCM.ReadOnly = true;
                        txttenCM.ReadOnly = true;
                        k = 0;
                        setbutton(true);
                    }


                }
                else if (k == 2)              
                    if (txtmaCM.Text == "" || txttenCM.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                    }
                    else                    
                        //update
                        c.sua("tbl_DMChuyenMon", int.Parse(txtmaCM.Text.Trim()), txttenCM.Text.Trim(),
                            "machuyenmon", "tenchuyenmon");
            }
                    c.laydl("tbl_DMChuyenMon");
                    txttenCM.ReadOnly = true;
                    setbutton(true);                   
                    k = 0;
            }
        }
    }