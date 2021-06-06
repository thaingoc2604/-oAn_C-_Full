using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmDoiMatKhau : Form
    {
        clsUser cUser = new clsUser();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txtmkcu_Validated(object sender, EventArgs e)
        {
            if (cUser.KiemTraHopLe(frmMain.me.libsql.GetUser(), txtmkcu.Text.Trim()) == false)
            {
                MessageBox.Show("Mật khẩu không hợp lệ!", "Thông báo");
                txtmkcu.Text = "";
            }            
        }

        private void txtmkmoi2_Validated(object sender, EventArgs e)
        {
            if (txtmkmoi.Text.Trim() != txtmkmoi2.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!!!", "Thông báo");
                txtmkmoi2.Text = "";
                txtmkmoi2.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu mật khẩu mới ??", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (txtmkmoi.Text.Trim() != txtmkmoi2.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp!!!", "Thông báo");
                    txtmkmoi2.Text = "";
                    txtmkmoi2.Focus();
                }
                else
                {
                    string sqlupd = "Update tbl_User set pass='" + txtmkmoi2.Text.Trim() + "' where id='" + frmMain.me.libsql.GetUser() + "'";
                    cUser.sc.Open();
                    SqlCommand cmdupd = new SqlCommand(sqlupd, cUser.sc);
                    try
                    {
                        cmdupd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("" + ex.Errors + " " + ex.Number);
                    }
                    cUser.sc.Close();
                }
            }
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            txtmkmoi2.Text = "";
        }

        private void txtmkmoi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
              this.Close();           
        }

        

       
    }
}