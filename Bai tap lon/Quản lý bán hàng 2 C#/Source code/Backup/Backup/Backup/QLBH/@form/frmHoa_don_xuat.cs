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
    public partial class frmHoa_don_xuat: Form
    {
        ToolTip toolTip1 = null;
        public frmHoa_don_xuat()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 300;
            toolTip1.ShowAlways = true;
            
        }
        public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
        OracleCommand cmdForm = new OracleCommand();
        _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();
        string shd="";
        string edit_shd="";

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            com_ma_kh.SelectedItem = com_ma_kh.Items[0];
            com_ma_nv.SelectedItem = com_ma_nv.Items[0];
            date_xuat.Value = DateTime.Now.Date;
            txt_thanh_tien.Text = "";
            lstv_Function();
            com_ma_kh.Focus();
            edit_shd = "";

        }
        private void lstv_Function()
        {
            clsCon.comboFill(com_ma_kh, "select * from KHACH_HANG", "KHACH_HANG", "TENKH", "MAKH");
            clsCon.comboFill(com_ma_nv, "select * from NHAN_VIEN", "NHAN_VIEN", "HOTENNV", "MANV");
            clsCon.list_DataView("SELECT     HOA_DON_XUAT.SOHDX, HOA_DON_XUAT.MANV, HOA_DON_XUAT.MAKH, HOA_DON_XUAT.NGAYXUAT, HOA_DON_XUAT.THANHTIENXUAT, NHAN_VIEN.HOTENNV, NHAN_VIEN.CHUCVU, KHACH_HANG.TENKH, KHACH_HANG.SODT_KH"
                    +" FROM HOA_DON_XUAT INNER JOIN NHAN_VIEN ON HOA_DON_XUAT.MANV = NHAN_VIEN.MANV INNER JOIN KHACH_HANG ON HOA_DON_XUAT.MAKH = KHACH_HANG.MAKH order by SOHDX", this.lstv_hdx);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lstv_Function();
        }

        private void sohoadon()
        {
            try
            {

                int myID;
                clsCon.connCheck();
                OracleCommand cmddr = new OracleCommand("select max(SOHDX) as id from HOA_DON_XUAT", clsCon.cn);
                OracleDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["id"].ToString();
                    if (strid == "")
                    {
                        shd = "1";
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["id"]) + 1;
                        shd = myID.ToString();
                    }

                }
                dr.Close();
                clsCon.cn.Close();
                cmddr.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            sohoadon();
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into HOA_DON_XUAT values (" + shd + ",'" + com_ma_nv.SelectedValue.ToString() + "','" + com_ma_kh.SelectedValue.ToString() +
                        "',TO_DATE('"+date_xuat.Value.Date.ToShortDateString()+ "','MM-DD-YYYY'),"+txt_thanh_tien.Text+")";
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Thêm thành công", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);
                    return ;

                }
                finally
                {
                    clsCon.cn.Close();
                }

                btn_Cancel_Click(sender, e);
                
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (edit_shd == "")
                clsmyFunction.setCreateError("Chọn một hoá đơn để update!");
            else
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "update HOA_DON_XUAT set SOHDX=" + edit_shd + ", MAKH='" + com_ma_kh.SelectedValue.ToString() + "', MANV='" + com_ma_nv.SelectedValue.ToString() + "', NGAYXUAT=TO_DATE('" + date_xuat.Value.Date.ToShortDateString() + "','MM-DD-YYYY'),THANHTIENXUAT=" + txt_thanh_tien.Text + " where SOHDX=" + edit_shd;
                        clsCon.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Update thành công", 1);
                        btn_Cancel_Click(sender, e);
                    }
                    catch (Exception exp)
                    {
                        clsmyFunction.setCreateError(exp.Message);
                        return;

                    }
                    finally
                    {
                        clsCon.cn.Close();
                    }
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (edit_shd == "")
                clsmyFunction.setCreateError("Chọn một hoá đơn để xoá!");
            else
            {
                DialogResult ret;
                ret = MessageBox.Show("Bạn có muốn xóa mẫu tin này không!", "Xóa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete from HOA_DON_XUAT where SOHDX=" + edit_shd;
                        clsCon.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Xoá thành công", 1);
                        btn_Cancel_Click(sender, e);
                    }
                    catch (Exception exp)
                    {
                        clsmyFunction.setCreateError(exp.Message);
                        return;

                    }
                    finally
                    {
                        clsCon.cn.Close();
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
            edit_shd = lstv_hdx.Items[lstv_hdx.FocusedItem.Index].SubItems[0].Text.Trim();
            com_ma_nv.SelectedValue = lstv_hdx.Items[lstv_hdx.FocusedItem.Index].SubItems[1].Text;
            com_ma_kh.SelectedValue = lstv_hdx.Items[lstv_hdx.FocusedItem.Index].SubItems[2].Text;
            date_xuat.Value = Convert.ToDateTime(lstv_hdx.Items[lstv_hdx.FocusedItem.Index].SubItems[3].Text);
            txt_thanh_tien.Text = lstv_hdx.Items[lstv_hdx.FocusedItem.Index].SubItems[4].Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _forms.frmKhach_hang frm_kh = new frmKhach_hang();
            frm_kh.str = "Adding";
            frm_kh.Show();
        }





        private void frmHoa_don_xuat_Load(object sender, EventArgs e)
        {
            date_xuat.Format = DateTimePickerFormat.Custom;
            date_xuat.CustomFormat = "dd-MM-yyyy";
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

        private void txt_thanh_tien_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
                if (e.KeyCode == Keys.Enter)
                    this.btn_Add_Click(sender, e);

        }

        private void txt_thanh_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back /*& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
        }

        private void lstv_hdx_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
           toolTip1.SetToolTip(lstv_hdx , e.Item.SubItems[6].Text + "  " + e.Item.SubItems[5].Text + "   Khách hàng: " + e.Item.SubItems[7].Text + "   SĐT: " + e.Item.SubItems[8].Text);
        }
    }
}