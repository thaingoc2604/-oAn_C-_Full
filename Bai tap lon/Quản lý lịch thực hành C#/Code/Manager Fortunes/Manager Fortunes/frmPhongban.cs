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


namespace Manager_Fortunes
{
    public partial class frmPhongban : DevComponents.DotNetBar.Office2007Form
    {
        TrangThai.TrangThaiForm Khoitao;
        Phongbancontrol ctrl = new Phongbancontrol();
        Diadiemcontrol cttrldd = new Diadiemcontrol();

        public frmPhongban()
        {
            InitializeComponent();
        }

        ////private void frmPhongban_Load(object sender, EventArgs e)
        //{
        //    DataService.OpenConnection();
        //    //ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
        //   // cttrldd.HienthiAutoComboBoxTenDiaDiem(cmbmadiadiem);
        //    An_TextBox();
        //    An_Button();
        //}
        private void An_TextBox()
        {
            cmbmadiadiem.Enabled = false;
            txtmaphongban.Enabled = false;
            txttenphongban.Enabled = false;            
            txtsodienthoai.Enabled = false;
        }

        private void An_Button()
        {
            this.taskItemluu.Enabled = false;
        }

        private void Hien_TextBox()
        {
            cmbmadiadiem.Enabled = true;
            txtmaphongban.Enabled = true;
            txttenphongban.Enabled = true;            
            txtsodienthoai.Enabled = true;

            cmbmadiadiem.Text = null;
            txtmaphongban.Text = null;
            txttenphongban.Text = null;            
            txtsodienthoai.Text = null;
        }

        private void Cho_Sua()
        {
            cmbmadiadiem.Enabled = true;
            txtmaphongban.Enabled = true;
            txttenphongban.Enabled = true;            
            txtsodienthoai.Enabled = true;
        }
        private void Truyendulieuvaodatagrid()
        {
            DataRow row = ctrl.NewRow();
            row["MADIADIEM"] = cmbmadiadiem.SelectedValue.ToString();
            row["MAPHONGBAN"] = txtmaphongban.Text;            
            row["TENPHONGBAN"] = txttenphongban.Text;            
            row["SODIENTHOAI"] = txtsodienthoai.Text;

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
            //ctrl.SinhMaPhongBan(this.txtmaphongban);
        }

        private void taskItemluu_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                //PhongbanObject phongbanobj = new PhongbanObject();
                //phongbanobj.Madiadiem = new DiadiemObject(this.cmbmadiadiem.SelectedValue.ToString(),this.cmbmadiadiem.Text);
                //phongbanobj.Maphongban=this.txtmaphongban.Text;
                //phongbanobj.Tenphongban=this.txttenphongban.Text;
                //phongbanobj.Sodienthoai = Convert.ToInt32(this.txtsodienthoai.Text.Trim());
             
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
                    //if (MessageBoxEx.Show("Bạn có muốn thay đổi thông tin của phong ban này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    //{
                    //    ctrl.SuaThongTinPhongBan(phongbanobj);
                    //}
                    //this.toolStripButtonLuuHH.Enabled = false;
                    //this.ChoPhepTextBoxComboBox(false);
                    //this.ChoPhepDataGridView(true);
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
            if (this.cmbmadiadiem.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn mã địa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbmadiadiem.Focus();
                return false;
            }
            if (this.txtmaphongban.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtmaphongban.Focus();
                return false;
            }  
            if (this.txttenphongban.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txttenphongban.Focus();
                return false;
            }           
            if (this.txtsodienthoai.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtsodienthoai.Focus();
                return false;
            }
            string SoDienThoai = this.txtsodienthoai.Text.Trim();
            if (SoDienThoai.Length != 6 && SoDienThoai.Length != 9 && SoDienThoai.Length != 10 && SoDienThoai.Length != 11 && SoDienThoai.Length != 12)
            {
                MessageBox.Show("Bạn đã nhập số điện thoại không đúng với thực tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtsodienthoai.Text = "";
                this.txtsodienthoai.Focus();
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
            txtmaphongban.Enabled = false;
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
            cmbmadiadiem.Text = row.Cells[0].Value.ToString();
            txtmaphongban.Text = row.Cells[1].Value.ToString();
            txttenphongban.Text = row.Cells[2].Value.ToString();
            txtsodienthoai.Text = row.Cells[3].Value.ToString();
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void buttonthemdiadiem_Click(object sender, EventArgs e)
        {
            frmDiadiem dd = new frmDiadiem();
            dd.ShowDialog();
        }

        private void tsbuttoncapnhatkhithem_Click(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
            cttrldd.HienthiAutoComboBoxTenDiaDiem(cmbmadiadiem);
            An_TextBox();
            An_Button();
        }

      
    }
}