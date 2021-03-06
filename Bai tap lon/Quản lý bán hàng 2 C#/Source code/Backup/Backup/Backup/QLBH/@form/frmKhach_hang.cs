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
    public partial class frmKhach_hang : Form
    {
        public frmKhach_hang()
        {
            InitializeComponent();
        }
        public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
        string edit_MA_KH = "";
        OracleCommand cmdForm = new OracleCommand();
        _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            txt_ma_kh.Text = "";
            txt_ht_kh.Text = "";
            txt_dt.Text = "";
            txt_dc.Text = "";
            edit_MA_KH = "";
            txt_ma_kh.Focus();

        }
        private void lstv_kh_Function()
        {
            this.clsCon.list_DataView("select * from KHACH_HANG ORDER BY MAKH", this.lstv_Khach_hang);

        }
      
        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            lstv_kh_Function();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            if (this.txt_ma_kh.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã khách hàng rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "INSERT INTO KHACH_HANG " +
                    "VALUES ('" + txt_ma_kh.Text + "', '" + txt_ht_kh.Text.Trim() + "', '" + txt_dc.Text.Trim() + "', '" + txt_dt.Text.Trim() + "')";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    if (exp.Message.Contains("00001"))
                        clsmyFunction.setCreateError("Trùng mã khách hàng!");
                    else
                        clsmyFunction.setCreateError(exp.Message);
                    return;

                }
                finally
                {
                    clsCon.cn.Close();
                }
            }
            lstv_kh_Function();
            this.txt_ma_kh.Text = "";
            this.txt_ht_kh.Text = "";
            txt_dc.Text = "";
            txt_dt.Text = "";
            txt_ma_kh.Focus();
        }


        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_KH == "")
                clsmyFunction.setCreateError("Chọn một mã khách hàng để update!");
            else
                if (this.txt_ma_kh.Text.Trim().Length != 5)
                {
                    clsmyFunction.setCreateError("Nhập sai quy ước!");
                    return;
                }
                else
                {
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "UPDATE KHACH_HANG SET MAKH='" + txt_ma_kh.Text + "', TENKH='" + txt_ht_kh.Text.Trim() +
                        "', DIACHIKH='" + txt_dc.Text.Trim() + "', SODT_KH='" + txt_dt.Text.Trim() + "' WHERE MAKH='" + edit_MA_KH + "'";
                        clsCon.cmdClose(cmdForm);

                        clsmyFunction.setMessageBox("Update thành công", 1);
                        this.txt_ma_kh.Text = "";
                        this.txt_ht_kh.Text = "";
                        txt_dc.Text = "";
                        txt_dt.Text = "";
                        edit_MA_KH = "";


                    }
                    catch (Exception exp)
                    {
                          clsmyFunction.setCreateError(exp.Message);

                    }
                    finally
                    {
                        clsCon.cn.Close();
                    }
                    lstv_kh_Function();
                }
        }



        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (edit_MA_KH == "")
                clsmyFunction.setCreateError("Chọn một khách hàng để xoá!");
            else
            {

                DialogResult ret;
                ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    if (this.txt_ma_kh.Text.Trim().Length != 5)
                        clsmyFunction.setCreateError("Nhập sai quy ước!");

                    else
                    {
                        try
                        {
                            clsCon.cmdOpen(cmdForm);
                            cmdForm.CommandText = "delete from KHACH_HANG where MAKH='" + txt_ma_kh.Text + "'";
                            clsCon.cmdClose(cmdForm);
                            clsmyFunction.setMessageBox("Xóa dữ liệu thành công", 1);
                            this.txt_ma_kh.Text = "";
                            this.txt_ht_kh.Text = "";
                            txt_dc.Text = "";
                            txt_dt.Text = "";
                            edit_MA_KH = "";

                        }
                        catch (Exception exp)
                        {
                            clsmyFunction.setCreateError(exp.Message);

                        }
                        finally
                        {
                            clsCon.cn.Close();
                        }
                        lstv_kh_Function();
                    }
                }
            }
        }







        private void frmKhach_hang_Load(object sender, EventArgs e)
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
            lstv_kh_Function();

        }

        private void txt_ma_kh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void lstv_Khach_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                edit_MA_KH = txt_ma_kh.Text = lstv_Khach_hang.Items[lstv_Khach_hang.FocusedItem.Index].SubItems[0].Text;
                txt_ht_kh.Text = lstv_Khach_hang.Items[lstv_Khach_hang.FocusedItem.Index].SubItems[1].Text;
                txt_dc.Text = lstv_Khach_hang.Items[lstv_Khach_hang.FocusedItem.Index].SubItems[2].Text;
                txt_dt.Text = lstv_Khach_hang.Items[lstv_Khach_hang.FocusedItem.Index].SubItems[3].Text;
            }

        }

        private void txt_dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void lstv_Khach_hang_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_dc_KeyDown(object sender, KeyEventArgs e)
        {
            if (str == "Modifying") return;
            if (e.KeyCode == Keys.Enter)
                btn_Add_Click_1(sender, e);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
