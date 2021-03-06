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
    public partial class frmNha_cung_cap : Form
    {
        public frmNha_cung_cap()
        {
            InitializeComponent();
        }
       public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
       string  edit_MA_NCC="";
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
       _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.txt_ma_ncc.Text = "";
            this.txt_hten_ncc.Text = "";
            txt_dc_ncc.Text = "";
            txt_dt_ncc.Text = "";
            edit_MA_NCC = "";
            lstv_ncc_Function();
            this.txt_ma_ncc.Focus();

        }

        private void lstv_ncc_Function()
        {
            this.clsCon.list_DataView("select * from NHA_CUNG_CAP ORDER BY MANCC", this.lstv_nha_cung_cap);

        }
        private void save_nha_cung_cap()
        {
            if (this.txt_ma_ncc.Text.Trim().Length !=5)
            {
                MessageBox.Show("Mã nhà cung cấp rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "INSERT INTO NHA_CUNG_CAP (MANCC,TENNCC,DIACHINCC, SODT_NCC)"+
                    "VALUES ('"+txt_ma_ncc.Text+"', '"+txt_hten_ncc.Text.Trim()+"', '"+txt_dc_ncc.Text.Trim()+"','"+txt_dt_ncc.Text.Trim()+"')";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
            }
        }
        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            lstv_ncc_Function();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            save_nha_cung_cap();
            lstv_ncc_Function();
            this.txt_ma_ncc.Text = "";
            this.txt_hten_ncc.Text = "";
            txt_dc_ncc.Text = "";
            txt_dt_ncc.Text = "";
            txt_ma_ncc.Focus();
        }


        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_NCC == "")
                clsmyFunction.setCreateError("Chọn một mã nhà cung cấp để update!");
            else
            if (this.txt_ma_ncc.Text.Trim().Length != 5)
            {
                clsmyFunction.setCreateError("Nhập sai quy ước!");
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "UPDATE NHA_CUNG_CAP SET MANCC='" + txt_ma_ncc.Text + "', TENNCC='" + txt_hten_ncc.Text.Trim() +
                    "', DIACHINCC='" + txt_dc_ncc.Text.Trim()+ "', SODT_NCC='" + txt_dt_ncc.Text.Trim() + "' WHERE MANCC='" + edit_MA_NCC + "'";

                    
                    clsCon.cmdClose(cmdForm);
                    
                    clsmyFunction.setMessageBox("Update thành công", 1);
                    this.txt_ma_ncc.Text = "";
                    this.txt_hten_ncc.Text = "";
                    txt_dc_ncc.Text = "";
                    txt_dt_ncc.Text = "";
                    edit_MA_NCC= "";
                    

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
                lstv_ncc_Function();
            }
        }

        

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_NCC== "")
                clsmyFunction.setCreateError("Chọn một mã nhà cung cấp để xoá!");
            else
                {
 
                    DialogResult ret;
                    ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {

                        if (this.txt_ma_ncc.Text.Trim().Length != 5 )
                            {
                                clsmyFunction.setCreateError("Nhập sai quy ước!");
                                return;
                            }
                        else
                            {
                                try
                                    {
                                        clsCon.cmdOpen(cmdForm);
                                        cmdForm.CommandText = "delete from NHA_CUNG_CAP where MANCC='"+txt_ma_ncc.Text+"'";
                                        clsCon.cmdClose(cmdForm);
                                        clsmyFunction.setMessageBox("Xóa dữ liệu thành công", 1);
                                        this.txt_ma_ncc.Text = "";
                                        this.txt_hten_ncc.Text = "";
                                        txt_dc_ncc.Text = "";
                                        txt_dt_ncc.Text = "";
                                        edit_MA_NCC = "";

                                     }
                                 catch (Exception exp)
                                    {
                                        clsmyFunction.setCreateError(exp.Message);

                                     }
                                    finally
                                    {
                                         clsCon.cn.Close();
                                    }
                                lstv_ncc_Function();
                                }

                }
            
            else
            {
                btn_Cancel_Click_1(sender, e);
            }
        }
        
        }


        
        

        private void frmNha_cung_cap_Load(object sender, EventArgs e)
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
            lstv_ncc_Function();
        }


        private void lstv_nha_cung_cap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (str == "Adding")
                return;
            edit_MA_NCC = this.txt_ma_ncc.Text = (this.lstv_nha_cung_cap.Items[lstv_nha_cung_cap.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_hten_ncc.Text = (this.lstv_nha_cung_cap.Items[lstv_nha_cung_cap.FocusedItem.Index].SubItems[1].Text.Trim());
            txt_dc_ncc.Text = (this.lstv_nha_cung_cap.Items[lstv_nha_cung_cap.FocusedItem.Index].SubItems[2].Text.Trim());
            txt_dt_ncc.Text = (this.lstv_nha_cung_cap.Items[lstv_nha_cung_cap.FocusedItem.Index].SubItems[3].Text.Trim());
        }
       
        /*
         Mã xử lý chỉ cho nhập số tại textbox số đt
         */
        private void txt_dt_ncc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void txt_ma_ncc_Leave(object sender, EventArgs e)
        {
            if (txt_ma_ncc.Text.Trim().Length != 5)
            {
                errorProvider1.SetError(txt_ma_ncc, "Sai qui ước");
                txt_ma_ncc.Focus();
            }
            else errorProvider1.Clear();
        }

        

        private void txt_dc_ncc_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Add_Click_1(sender,e);
                }
                else
                {
                    return;
                }
            }

        }

    }
}