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
    public partial class frmHang_hoa : Form
    {
        public frmHang_hoa()
        {
            InitializeComponent();
            
        }
        public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
        string edit_ml = "", edit_mh = "";
        OracleCommand cmdForm = new OracleCommand();
        _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void btn_close_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            com_ml.SelectedItem = com_ml.Items[0];
            txt_mh.Text = "";
            txt_ten_hang.Text = "";
            com_dvt.SelectedItem = com_dvt.Items[0];
            txt_ten_nsx.Text = "";
            txt_gia.Text = "";
            edit_mh = edit_ml = "";
            lstv_Function();
            com_ml.Focus();

        }
        private void lstv_Function()
        {
            com_dvt.SelectedItem = com_dvt.Items[0];
            clsCon.comboFill(com_ml, "select * from LOAI_HANG", "LOAI_HANG", "MALOAI", "MALOAI");
            clsCon.list_DataView("select * from HANG_HOA ORDER BY MALOAI, MAHANG", this.lstv_hh);
        }
        private bool save_Loai_hang()
        {
            if (txt_mh.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã hàng sai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into HANG_HOA values ('" + com_ml.Text + "','" + txt_mh.Text + "','" + txt_ten_hang.Text.Trim() +
                        "','" + com_dvt.Text + "','" + txt_ten_nsx.Text.Trim() + "'," + txt_gia.Text.Trim() + ")";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);
                    return false;

                }
                finally
                {
                    clsCon.cn.Close();
                }

                return true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!save_Loai_hang())
                return;
            lstv_Function();
            com_ml.SelectedItem = com_ml.Items[0];
            txt_mh.Text = "";
            txt_ten_hang.Text = "";
            com_dvt.SelectedItem = com_dvt.Items[0];
            txt_ten_nsx.Text = "";
            txt_gia.Text = "";
            com_ml.Focus();
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (edit_mh == "" || edit_ml == "")
                clsmyFunction.setCreateError("Chọn một mã hàng để update!");
            else
                if (txt_mh.Text.Trim().Length != 5)
                {
                    clsmyFunction.setCreateError("Nhập sai quy ước!");
                    return;
                }
                else
                {
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "update HANG_HOA set MALOAI='" + com_ml.Text + "',MAHANG='" + txt_mh.Text + "',TENHANG='" + txt_ten_hang.Text.Trim() + "',DONVITINH='" + com_dvt.Text+ "',GIADENGHI=" + txt_gia.Text.Trim() +
                            ",TENNHASX='"+txt_ten_nsx.Text.Trim()+"' where MALOAI='" + edit_ml + "' AND MAHANG='" + edit_mh + "'";
                        clsCon.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Update thành công", 1);
                        com_ml.SelectedItem = com_ml.Items[0];
                        txt_mh.Text = "";
                        txt_ten_hang.Text = "";
                        com_dvt.SelectedItem = com_dvt.Items[0];
                        txt_ten_nsx.Text = "";
                        txt_gia.Text = "";
                    }
                    catch (Exception exp)
                    {
                        clsmyFunction.setCreateError(exp.Message);

                    }
                    finally
                    {
                        clsCon.cn.Close();
                    }
                    lstv_Function();
                }
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (edit_mh == "" || edit_ml == "")
                clsmyFunction.setCreateError("Chọn một mã hàng để xoá!");
            else
            {

                DialogResult ret;
                ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    if (txt_mh.Text.Trim().Length != 5)
                    {
                        clsmyFunction.setCreateError("Nhập sai quy ước!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            clsCon.cmdOpen(cmdForm);
                            cmdForm.CommandText = "delete from HANG_HOA where MALOAI='" + com_ml.Text + "' AND MAHANG='" + txt_mh.Text.Trim() + "'";
                            clsCon.cmdClose(cmdForm);
                            clsmyFunction.setMessageBox("Xóa dữ liệu thành công", 1);
                            com_ml.SelectedItem = com_ml.Items[0];
                            txt_mh.Text = "";
                            txt_ten_hang.Text = "";
                            com_dvt.SelectedItem = com_dvt.Items[0];
                            txt_ten_nsx.Text = "";
                            txt_gia.Text = "";

                        }
                        catch (Exception exp)
                        {
                            clsmyFunction.setCreateError(exp.Message);

                        }
                        finally
                        {
                            clsCon.cn.Close();
                        }
                        lstv_Function();
                    }

                }

                else
                {
                    btn_Cancel_Click(sender, e);
                }
            }

        }


        private void lstv_Loai_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_ml = com_ml.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[0].Text;
            edit_mh = txt_mh.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[1].Text;
            txt_ten_hang.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[2].Text;
            com_dvt.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[3].Text;
            txt_ten_nsx.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[4].Text;
            txt_gia.Text = lstv_hh.Items[lstv_hh.FocusedItem.Index].SubItems[5].Text;
        }





        

        private void frmLoai_hang_Load_1(object sender, EventArgs e)
        {
            if (str == "Adding")
            {
                this.lbl_Mode.Text = str;
                btn_Update.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
            }
            else
            {
                if (str == "Modifying")
                {
                    this.lbl_Mode.Text = str;
                    btn_Add.Visible = false;
                    side1.Visible = false;
                }
            }

            lstv_Function();
        }

        private void txt_ten_nsx_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
                if (e.KeyCode == Keys.Enter)
                    this.btn_Add_Click(sender, e);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _forms.frmLoai_hang frm_lh = new _forms.frmLoai_hang();
            frm_lh.str = "Adding";
           frm_lh.Show();
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }
    }
}