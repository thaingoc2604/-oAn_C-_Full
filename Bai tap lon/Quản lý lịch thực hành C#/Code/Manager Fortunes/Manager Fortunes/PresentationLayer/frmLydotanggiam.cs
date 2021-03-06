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
    public partial class frmLydotanggiam : DevComponents.DotNetBar.Office2007Form
    {
        TrangThai.TrangThaiForm Khoitao;
        Lydotanggiamcontrol ctrl = new Lydotanggiamcontrol();
        public frmLydotanggiam()
        {
            InitializeComponent();
        }

        private void frmLydotanggiam_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
            An_TextBox();
            An_Button();
        }
        private void An_TextBox()
        {
            txtmalydotanggiam.Enabled = false;
            txttenlydotanggiam.Enabled = false;            
            txtgiatri.Enabled = false;
        }

        private void An_Button()
        {
            this.taskItemluu.Enabled = false;
        }

        private void Hien_TextBox()
        {
            txtmalydotanggiam.Enabled = true;
            txttenlydotanggiam.Enabled = true;            
            txtgiatri.Enabled = true;

            txtmalydotanggiam.Text = null;
            txttenlydotanggiam.Text = null;            
            txtgiatri.Text = null;
        }

        private void Cho_Sua()
        {
            txtmalydotanggiam.Enabled = true;
            txttenlydotanggiam.Enabled = true;           
            txtgiatri.Enabled = true;
        }
        private void Truyendulieuvaodatagrid()
        {
            DataRow row = ctrl.NewRow();
            row["MALYDOTANGGIAM"] = txtmalydotanggiam.Text;
            row["TENLYDOTANGGIAM"] = txttenlydotanggiam.Text;
            row["GIATRI"] = txtgiatri.Text;
            

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
            if (this.txtmalydotanggiam.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mã lý do tăng giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtmalydotanggiam.Focus();
                return false;
            }
            if (this.txttenlydotanggiam.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập tên lý do tăng giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txttenlydotanggiam.Focus();
                return false;
            }
            if (this.txtgiatri.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtgiatri.Focus();
                return false;
            }
          

            return true;

        }

        private void taskItemXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông tin lý do ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            txtmalydotanggiam.Text = row.Cells[0].Value.ToString();
            txttenlydotanggiam.Text = row.Cells[1].Value.ToString();           
            txtgiatri.Text = row.Cells[2].Value.ToString();
        }

        private void txtgiatri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '1')
                e.Handled = true;
        }
    }
}