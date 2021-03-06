using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Manager_Fortunes.Controller;
using Manager_Fortunes.BusinessObject;

namespace Manager_Fortunes.PresentationLayer
{
    public partial class frmNhomtaisan : DevComponents.DotNetBar.Office2007Form
    {
        TrangThai.TrangThaiForm Khoitao;
        Nhomtaisancontrol ctrl = new Nhomtaisancontrol();
        Donvitinhcontrol ctrldvt = new Donvitinhcontrol();
        public frmNhomtaisan()
        {
            InitializeComponent();
        }

        private void frmNhomtaisan_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
            
            An_TextBox();
            An_Button();
        }
        private void An_TextBox()
        {
            
            txtmanhomtaisan.Enabled = false;
            txtmaso.Enabled = false;
            txttennhomtaisan.Enabled = false;
            
        }

        private void An_Button()
        {
            this.taskItemluu.Enabled = false;
        }

        private void Hien_TextBox()
        {
           
            txtmanhomtaisan.Enabled = true;
            txtmaso.Enabled = true;
            txttennhomtaisan.Enabled = true;
           

           
            txtmanhomtaisan.Text = null;
            txtmaso.Text = null;
            txttennhomtaisan.Text = null;
            
        }

        private void Cho_Sua()
        {
    
            txtmanhomtaisan.Enabled = true;
            txtmaso.Enabled = true;
            txttennhomtaisan.Enabled = true;
           
        }
        private void Truyendulieuvaodatagrid()
        {
            DataRow row = ctrl.NewRow();           
            row["MANHOMTAISAN"] = txtmanhomtaisan.Text;
            row["MASOTAISAN"] = txtmaso.Text;           
            row["TENNHOMTAISAN"] = txttennhomtaisan.Text;
           

            Hien_TextBox();
            ctrl.Add(row);
        }

        private void taskItemthem_Click(object sender, EventArgs e)
        {
            Hien_TextBox();
            this.taskItemcapnhat.Enabled = false;
            dataGridView1.Enabled = true;
            taskItemluu.Enabled = true;
            this.Khoitao = TrangThai.TrangThaiForm.Them;
            //ctrl.SinhMaTaiSan(this.txtmataisan);
        }

        private void taskItemluu_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                //TaisanObject taisanObj = new TaisanObject();
                if (this.Khoitao == TrangThai.TrangThaiForm.Them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Truyendulieuvaodatagrid();
                        Capnhatdulieu();
                        MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hien_TextBox();
                        taskItemluu.Enabled = true;
                        dataGridView1.Enabled = true;
                    }
                    else
                    {
                        Hien_TextBox();
                        taskItemluu.Enabled = false;
                        dataGridView1.Enabled = true;
                    }
                }
                if (this.Khoitao == TrangThai.TrangThaiForm.Luu)
                {
                    Truyendulieuvaodatagrid();
                    Capnhatdulieu();
                    MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hien_TextBox();
                    taskItemluu.Enabled = true;
                    dataGridView1.Enabled = true;
                }
                if (this.Khoitao == TrangThai.TrangThaiForm.Sua)
                {
                    //if (MessageBoxEx.Show("Bạn có muốn thay đổi thông tin của hàng hóa này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    //{
                    //    ctrl.SuaThongTinTaiSan(taisanObj);
                    //}
                    ////this.toolStripButtonLuuHH.Enabled = false;
                    ////this.ChoPhepTextBoxComboBox(false);
                    ////this.ChoPhepDataGridView(true);
                    //MessageBoxEx.Show("Đã cập nhật thành công một hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.ChoPhepThemXoaSua(true, true, true);
                    bindingNavigatorPositionItem.Focus();
                    ctrl.Save();
                }
                if (this.Khoitao == TrangThai.TrangThaiForm.Bandau)
                {
                    taskItemluu.Enabled = false;
                }
            }
        }
        private bool KiemTraThongTinNhap()// bool
        {
           
            if (this.txtmanhomtaisan.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mã nhóm tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtmanhomtaisan.Focus();
                return false;
            }
            if (this.txtmaso.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mã số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtmaso.Focus();
                return false;
            }
            if (this.txttennhomtaisan.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập tên nhóm tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txttennhomtaisan.Focus();
                return false;
            }          
          

            return true;

        }

        private void taskItemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông tin tài sản ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
            Capnhatdulieu();
        }
        private void Capnhatdulieu()
        {
            bindingNavigatorPositionItem.Focus();
            ctrl.Save();
        }

        private void taskItemthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taskItemcapnhat_Click(object sender, EventArgs e)
        {
            taskItemcapnhat.Enabled = false;
            Cho_Sua();
            this.taskItemluu.Enabled = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Khoitao = TrangThai.TrangThaiForm.Sua;
            this.taskItemcapnhat.Enabled = true;
            taskItemluu.Enabled = true;

            Cho_Sua();
            An_TextBox();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
           
            txtmanhomtaisan.Text = row.Cells[0].Value.ToString();
            txtmaso.Text = row.Cells[1].Value.ToString();
            txttennhomtaisan.Text = row.Cells[2].Value.ToString();
            
        }

        private void buttonthemdonvitinh_Click(object sender, EventArgs e)
        {
            frmDonvitinh dvt = new frmDonvitinh();
            dvt.Show();
        }
    }
}