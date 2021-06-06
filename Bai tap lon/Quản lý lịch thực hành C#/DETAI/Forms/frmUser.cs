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
    public partial class frmUser : Form
    {
        //khai báo biến toàn cục
        clsUser c = new clsUser();
        clsnhomnguoidung cnhom = new clsnhomnguoidung();
        int k = 0;
        DataSet ds1 = new DataSet();
        clsDMForm cDMform = new clsDMForm();
        public frmUser()
        {            
            InitializeComponent();
            cbogroup.DataSource = cnhom.taocombo();
            cbogroup.DisplayMember = "nhom";
            cbogroup.ValueMember = "nhom";
            txtusername.DataBindings.Add("text",laydl(), "tbl_user.ID");
            txtpassword.DataBindings.Add("text", laydl(), "tbl_user.pass");
            dgvUser.DataSource = laydl();
            dgvUser.DataMember = "tbl_user";
        }

        private void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthoat.Enabled = b;
            cmdthem.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void setcontrol(bool b)
        {
            txtusername.Enabled  = b;
            txtpassword.Enabled  = b;
            cbogroup.Enabled = b;
        }

        private DataSet laydl()
        {
            ds1.Clear();
            //câu lệnh select
            string sel_ = "Select * from tbl_User where id<>'administrator'";
            //mở csdl
            c.sc.Open();
            SqlCommand sel = new SqlCommand(sel_, c.sc);
            c.sda.SelectCommand = sel;
            c.sda.Fill(ds1, "tbl_user");
            c.sc.Close();
            return ds1;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            setbutton(true);
            setcontrol(false );
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            setbutton(false);
            setcontrol(true);
            txtusername.Focus();
            txtusername.Text= "";
            txtpassword.Text = "";
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            setbutton(false);
            txtpassword.Enabled = true;
            cbogroup.Enabled = true;
            txtpassword.Focus();
            k=2;
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa(txtusername.Text.Trim());
                }
            }
            dgvUser.DataSource = laydl();
            dgvUser.DataMember = "tbl_user";
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                if (k == 1)
                {
                    if (txtusername.Text == "" || txtpassword.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {

                        c.them(txtusername.Text.Trim(),
                               txtpassword.Text.Trim(),
                               cbogroup.SelectedValue.ToString());
                        int dong = cDMform.laydl().Tables["DMform"].Rows.Count;
                        for (int i = 0; i < dong; i++)
                        {
                            int m = i + 1;
                            try
                            {
                                cDMform.insert(txtusername.Text.Trim(), m.ToString(), 0);
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627)
                                    MessageBox.Show("Bạn đã có mã này rồi", "Thông Báo");
                                break;
                            }
                        }
                    }
                }
                else if (k == 2)
                {
                    if (txtusername.Text == "" || txtpassword.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.sua(txtusername.Text.Trim(),
                               txtpassword.Text.Trim(),
                               cbogroup.SelectedValue.ToString());
                    }
                }
            }
            k = 0;
            setbutton(true);
            setcontrol(false);
            dgvUser.DataSource = laydl();
            dgvUser.DataMember = "tbl_user";
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}