using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLTS.Controller;
using QLTS.BusinessObject;
using QLTS;


namespace Manager_Fortunes
{
    public partial class frmDonvitinh : DevComponents.DotNetBar.Office2007Form
    {
        TrangThai.TrangThaiForm Khoitao;
        Donvitinhcontrol ctrl = new Donvitinhcontrol();
        public frmDonvitinh()
        {
            InitializeComponent();
        }

        private void An_TextBox()
        {
            txtmadonvitinh.Enabled = false;
            txttendonvitinh.Enabled = false;           
        }

        private void An_Button()
        {
            this.taskItemluu.Enabled = false;
        }

        private void Hien_TextBox()
        {
            txtmadonvitinh.Enabled = true;
            txttendonvitinh.Enabled = true;              

            txtmadonvitinh.Text = null;
            txttendonvitinh.Text = null;                   
        }

        private void Cho_Sua()
        {
            txtmadonvitinh.Enabled = true;           
            txttendonvitinh.Enabled = true;                     
        }
        private void Truyendulieuvaodatagrid()
        {
            DataRow row = ctrl.NewRow();
            row["MADONVITINH"] = txtmadonvitinh.Text;
            row["TENDONVITINH"] = txttendonvitinh.Text;                      

            Hien_TextBox();
            ctrl.Add(row);
        }    
    
        private void Capnhatdulieu()
        {
            bindingNavigatorPositionItem.Focus();
            ctrl.Save();
        }
       
        //private void frmDonvitinh_Load(object sender, EventArgs e)
        //{

        //    DataService.OpenConnection();
        //    ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
        //    An_TextBox();
        //    An_Button();
        //}

        private void taskItemthem_Click_1(object sender, EventArgs e)
        {
            Hien_TextBox();
            this.taskItemcapnhat.Enabled = false;
            dataGridView1.Enabled = true;
            taskItemluu.Enabled = true;
            this.Khoitao = TrangThai.TrangThaiForm.Them;
            //ctrl.SinhMaTaiSan(this.txtmataisan);
        }

        private void taskItemluu_Click_1(object sender, EventArgs e)
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
            if (this.txtmadonvitinh.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mã đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtmadonvitinh.Focus();
                return false;
            }
            if (this.txttendonvitinh.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập tên đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txttendonvitinh.Focus();
                return false;
            }         

            return true;

        }

        private void taskItemcapnhat_Click_1(object sender, EventArgs e)
        {
            taskItemcapnhat.Enabled = false;
            Cho_Sua();
            this.taskItemluu.Enabled = true;
        }

        private void taskItemXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông tin tài sản ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
            Capnhatdulieu();
        }

        private void taskItemthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Khoitao = TrangThai.TrangThaiForm.Sua;
            this.taskItemcapnhat.Enabled = true;
            taskItemluu.Enabled = true;

            Cho_Sua();
            An_TextBox();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtmadonvitinh.Text = row.Cells[0].Value.ToString();
            txttendonvitinh.Text = row.Cells[1].Value.ToString();
          
        }
    }
}