using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient ;
namespace QLBH._forms
{
    public partial class frmChange_pass : Form
    {
        
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        Timer t = new Timer();
        public frmChange_pass()
        {
            InitializeComponent();
            t.Interval = 2;
            t.Tick += new System.EventHandler(t_Tick);
        }
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            t.Enabled = true;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity <= 0) this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ckb_admin.Checked == true)
            {
                if (txt_admin_new.Text.Trim() == txt_confim_admin.Text.Trim())
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update USER_ set pass='" + txt_admin_new.Text.Trim() + "' where usr='admin'";
                    clsCon.cmdClose(cmdForm);

                }
                else
                {
                    MessageBox.Show("Password nhập lại không đúng");
                    return;
                }
            }
            if (ckb_nhanvien.Checked == true)
            {
                if (txt_nhanvien_new.Text.Trim() == txt_confim_nhanvien.Text.Trim())
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update USER_ set pass='" + txt_nhanvien_new.Text.Trim() + "' where usr='nhanvien'";
                    clsCon.cmdClose(cmdForm);

                }
                else
                {
                    MessageBox.Show("Password nhập lại không đúng");
                    return;
                }
            }
            t.Enabled = true;
        }

        private void frmChange_pass_Load(object sender, EventArgs e)
        {
            try
            {
                clsCon.cmdOpen(cmdForm);
                cmdForm.CommandText = "select * from user_";
                OracleDataReader dr = cmdForm.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["USR"].ToString().ToLower() == "admin")
                        txt_admin_old.Text = dr["PASS"].ToString();
                    else txt_nhanvien_old.Text = dr["PASS"].ToString();
                }
                dr.Close();
                dr.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckb_nhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_admin_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       

    }
}