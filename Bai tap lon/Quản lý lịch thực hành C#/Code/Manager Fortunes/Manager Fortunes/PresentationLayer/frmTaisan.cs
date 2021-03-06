using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Manager_Fortunes.Datalayer;
using Manager_Fortunes.Controller;


namespace Manager_Fortunes.PresentationLayer
{
    public partial class frmTaisan : DevComponents.DotNetBar.Office2007Form
    {
        TrangThai.TrangThaiForm Khoitao;
        Taisancontrol ctrl = new Taisancontrol();
        Diadiemcontrol ctrldd = new Diadiemcontrol();
        Phongbancontrol ctrlpb = new Phongbancontrol();
        Donvitinhcontrol ctrldvt = new Donvitinhcontrol();
        Mucdichsudungcontrol ctrlmdsd = new Mucdichsudungcontrol();
        Lydotanggiamcontrol ctrlldtg = new Lydotanggiamcontrol();
        Nhomtaisancontrol ctrlnts = new Nhomtaisancontrol();


        public frmTaisan()
        {
            InitializeComponent();
        }

        private void frmTaisan_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
            ctrl.HienthiAutoComboBoxTenTaiSan(cmbtentaisan);
            ctrldd.HienthiAutoComboBoxTenDiaDiem(cmbtendiadiem);
            ctrlmdsd.HienthiAutoComboBoxTenMucDichSuDung(cmbmucdichsudung);
            ctrlpb.HienthiAutoComboBoxTenPhongBan(cmbphongban);
            ctrldvt.HienthiAutoComboBoxTenDonViTinh(cmbdonvitinh);
            ctrlldtg.HienthiAutoComboBoxTenLyDoTangGiam(cmblydotanggiam);
            ctrlnts.HienthiAutoComboBoxTenNhomTaiSan(cmbmanhom);

            
            An_TextBox();
            An_Button();
        }

        private void An_TextBox()
        {
            txtsohoadon.Enabled = false;           
            txtmataisan.Enabled =false;
            cmbtentaisan.Enabled = false;
            cmbmanhom.Enabled = false;
            cmbdonvitinh.Enabled = false;
            txtnuocsx.Enabled = false;
            datetimenamsx.Enabled = false;
            datetimengaykhauhao.Enabled = false;
            cmblydotanggiam.Enabled = false;
            datetimengaytang.Enabled = false;
            numdieuchinhtang.Enabled = false;
            numgiatrisaukhitang.Enabled = false;
            numsonamkhauhao.Enabled = false;
            numnguyengia.Enabled = false;
            nummuckhauhao.Enabled = false;
            numdakhauhao.Enabled = false;
            numconlai.Enabled = false;
            cmbtendiadiem.Enabled = false;
            cmbphongban.Enabled = false;
            cmbmucdichsudung.Enabled = false;
            datetimengaydieuchinh.Enabled = false;
            rtxtghichu.Enabled =false;

        }

        private void An_Button()
        {
            this.taskItemluu.Enabled = false;            
           
        }

        private void Hien_TextBox()
        {
            txtsohoadon.Enabled = true;
            cmbtentaisan.Enabled = true;
            cmbmanhom.Enabled = true;
            cmbdonvitinh.Enabled = true;
            txtnuocsx.Enabled = true;
            datetimenamsx.Enabled = true;
            datetimengaykhauhao.Enabled = true;
            cmblydotanggiam.Enabled = true;
            datetimengaytang.Enabled = true;
            numdieuchinhtang.Enabled = true;
            numgiatrisaukhitang.Enabled = true;
            numsonamkhauhao.Enabled = true;
            numnguyengia.Enabled = true;
            nummuckhauhao.Enabled = true;
            numdakhauhao.Enabled = true;
            numconlai.Enabled = true;
            cmbtendiadiem.Enabled = true;
            cmbphongban.Enabled = true;
            cmbmucdichsudung.Enabled = true;
            datetimengaydieuchinh.Enabled = true;
            rtxtghichu.Enabled = true;

            txtsohoadon.Text = null;
            cmbtentaisan.Text = null;
            cmbmanhom.Text = null;
            cmbdonvitinh.Text = null;
            txtmataisan.Enabled = false;
            txtnuocsx.Text = null;
            datetimenamsx.Text = null;
            datetimengaykhauhao.Text = null;
            cmblydotanggiam.Text = null;
            datetimengaytang.Text = null;
            numdieuchinhtang.Value = 0;
            numgiatrisaukhitang.Value = 0;
            numsonamkhauhao.Text = null;
            numnguyengia.Text = null;
            nummuckhauhao.Text = null;
            numdakhauhao.Text = null;
            numconlai.Text = null;
            cmbtendiadiem.Text = null;
            cmbphongban.Text = null;
            cmbmucdichsudung.Text = null;
            datetimengaydieuchinh.Text = null;
            rtxtghichu.Text = null;
        }

        private void Cho_Sua()
        {
            txtsohoadon.Enabled = true;
            cmbtentaisan.Enabled = true;
            cmbmanhom.Enabled = true;
            cmbdonvitinh.Enabled = true;
            txtnuocsx.Enabled = true;
            datetimenamsx.Enabled = true;
            datetimengaykhauhao.Enabled = true;
            cmblydotanggiam.Enabled = true;
            datetimengaytang.Enabled = true;
            numdieuchinhtang.Enabled = true;
            numgiatrisaukhitang.Enabled = true;
            numsonamkhauhao.Enabled = true;
            numnguyengia.Enabled = true;
            nummuckhauhao.Enabled = true;
            numdakhauhao.Enabled = true;
            numconlai.Enabled = true;
            cmbtendiadiem.Enabled = true;
            cmbphongban.Enabled = true;
            cmbmucdichsudung.Enabled = true;
            datetimengaydieuchinh.Enabled = true;
            rtxtghichu.Enabled = true;
        }
  
        private void taskItemthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Truyendulieuvaodatagrid()
        {
            DataRow row = ctrl.NewRow();
            row["SOHOADON"] = txtsohoadon.Text;
            row["MATAISAN"] = txtmataisan.Text;
            row["TENTAISAN"] = cmbtentaisan.Text;
            row["MASOTAISAN"] = cmbmanhom.SelectedValue.ToString();
            row["MADONVITINH"] = cmbdonvitinh.SelectedValue.ToString();
            row["SONAMKHAUHAO"] = numsonamkhauhao.Text;
            row["NGUYENGIA"] = numnguyengia.Text;
            row["MUCKHAUHAO"] = nummuckhauhao.Text;
            row["DAKHAUHAO"] = numdakhauhao.Text;
            row["CONLAI"] = numconlai.Text;           
            row["MADIADIEM"] = cmbtendiadiem.SelectedValue.ToString();
            row["MAPHONGBAN"] = cmbphongban.SelectedValue.ToString();
            row["NUOCSX"] = txtnuocsx.Text;
            row["NAMSX"] = datetimenamsx.Text.ToString();
            row["MALYDOTANGGIAM"] = cmblydotanggiam.SelectedValue.ToString();
            row["NGAYTANG"] = datetimengaytang.Text.ToString();
            row["NGAYKHAUHAO"] = datetimengaykhauhao.Text.ToString();
            row["DIEUCHINHTANG"] = numdieuchinhtang.Text;
            row["GIATRISAUKHITANGGIAM"] = numgiatrisaukhitang.Text;
            row["MAMUCDICHSUDUNG"] = cmbmucdichsudung.SelectedValue.ToString();
            row["NGAYDIEUCHINH"] = datetimengaydieuchinh.Text.ToString();
            row["GHICHU"] = rtxtghichu.Text;         

            Hien_TextBox();
            ctrl.Add(row);
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

        private void taskItemthem_Click(object sender, EventArgs e)
        {
            Hien_TextBox();
            this.taskItemcapnhat.Enabled = false;
            dataGridView1.Enabled = true;
            taskItemluu.Enabled = true;
            this.Khoitao = TrangThai.TrangThaiForm.Them;
            ctrl.SinhMaTaiSan(this.txtmataisan);
            DataService.OpenConnection();
            
        }
      
        private void Hien_Button()
        {
            this.taskItemluu.Enabled = false;
           
        }      

        private void taskItemcapnhat_Click(object sender, EventArgs e)
        {
            taskItemcapnhat.Enabled = false;
            Cho_Sua();
            this.taskItemluu.Enabled = true;
        }

       
       
        private bool KiemTraThongTinNhap()// bool
        {
            if (this.txtsohoadon.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập số hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtsohoadon.Focus();
                return false;
            }
            if (this.cmbtentaisan.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn tên tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbtentaisan.Focus();
                return false;
            }
            if (this.cmbmanhom.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn nhóm tài sản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbmanhom.Focus();
                return false;
            }
            if (this.cmbdonvitinh.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbdonvitinh.Focus();
                return false;
            }
            if (this.numsonamkhauhao.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập số năm khấu hao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.numsonamkhauhao.Focus();
                if (this.numsonamkhauhao.Value > 50)
                {
                    MessageBoxEx.Show("Bạn nên nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.numsonamkhauhao.Focus();
                }
                return false;
            }
          
            if (this.numnguyengia.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.numnguyengia.Focus();
                //if (this.numnguyengia.Value < 9999)
                //{
                //    MessageBoxEx.Show("Bạn nên nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    this.numnguyengia.Focus();
                //    return false;
                //}
                return false;
            }
            if (this.nummuckhauhao.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập mức khấu hao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nummuckhauhao.Focus();
                return false;
            }
            if (this.numdakhauhao.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập đã khấu hao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.numdakhauhao.Focus();
                return false;
            }
            if (this.cmbtendiadiem.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn địa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbtendiadiem.Focus();
                return false;
            }
            if (this.cmbphongban.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbphongban.Focus();
                return false;
            }
           
            if (this.cmblydotanggiam.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn lý do tăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmblydotanggiam.Focus();
                return false;
            }
            if (this.datetimengaykhauhao.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa nhập ngày khấu hao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.datetimengaykhauhao.Focus();
                return false;
            }
          
            if (this.cmbmucdichsudung.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn mục đích sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbmucdichsudung.Focus();
                return false;
            }
            return true;

        }

       
      
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void txtnguyengia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void txthansudung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void numnguyengia_ValueChanged(object sender, EventArgs e)
        {
            nummuckhauhao.Value = numnguyengia.Value / numsonamkhauhao.Value;
        }
        private void numdakhauhao_ValueChanged(object sender, EventArgs e)
        {
            numconlai.Value = numnguyengia.Value - numdakhauhao.Value;
        }
        
       

        private void buttonthemdiadiem_Click(object sender, EventArgs e)
        {
            frmDiadiem dd = new frmDiadiem();
            dd.ShowDialog();
        }

        private void buttonthemphong_Click(object sender, EventArgs e)
        {
            frmPhongban pb = new frmPhongban();
            pb.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmDonvitinh dvt = new frmDonvitinh();
            dvt.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Khoitao = TrangThai.TrangThaiForm.Sua;
            this.taskItemcapnhat.Enabled = true;
            taskItemluu.Enabled = true;

            Cho_Sua();
            An_TextBox();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtsohoadon.Text = row.Cells[0].Value.ToString();
            txtmataisan.Text = row.Cells[1].Value.ToString();
            cmbtentaisan.Text = row.Cells[2].Value.ToString();
            cmbmanhom.Text = row.Cells[3].Value.ToString();
            cmbdonvitinh.Text = row.Cells[4].Value.ToString();
            numsonamkhauhao.Text = row.Cells[5].Value.ToString();
            numnguyengia.Text = row.Cells[6].Value.ToString();
            nummuckhauhao.Text = row.Cells[7].Value.ToString();
            numdakhauhao.Text = row.Cells[8].Value.ToString();
            numconlai.Text = row.Cells[9].Value.ToString();
            cmbtendiadiem.Text = row.Cells[10].Value.ToString();
            cmbphongban.Text = row.Cells[11].Value.ToString();
            txtnuocsx.Text = row.Cells[12].Value.ToString();
            datetimenamsx.Text = row.Cells[13].Value.ToString();
            cmblydotanggiam.Text = row.Cells[14].Value.ToString();
            datetimengaytang.Text = row.Cells[15].Value.ToString();
            datetimengaykhauhao.Text = row.Cells[16].Value.ToString();
            numdieuchinhtang.Text = row.Cells[17].Value.ToString();
            numgiatrisaukhitang.Text = row.Cells[18].Value.ToString();
            cmbmucdichsudung.Text = row.Cells[19].Value.ToString();
            datetimengaydieuchinh.Text = row.Cells[20].Value.ToString();
            rtxtghichu.Text = row.Cells[21].Value.ToString();
        }

        private void tsbuttoncapnhatkhithem_Click(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            ctrl.HienThiDataGridView(dataGridView1, bindingNavigator1);
            ctrl.HienthiAutoComboBoxTenTaiSan(cmbtentaisan);
            ctrldd.HienthiAutoComboBoxTenDiaDiem(cmbtendiadiem);           
            ctrlpb.HienthiAutoComboBoxTenPhongBan(cmbphongban);
            ctrldvt.HienthiAutoComboBoxTenDonViTinh(cmbdonvitinh);
            An_TextBox();
            An_Button();
        }

        private void buttonthemlydotanggiam_Click(object sender, EventArgs e)
        {
            frmLydotanggiam ldtg = new frmLydotanggiam();
            ldtg.Show();
        }

        private void buttonthemmanhom_Click(object sender, EventArgs e)
        {
            frmNhomtaisan nts = new frmNhomtaisan();
            nts.Show();
        }

        private void buttonthemmucdichsudung_Click(object sender, EventArgs e)
        {
            frmMucdichsudung mdsd = new frmMucdichsudung();
            mdsd.Show();
        }

      
      


           

       

   

      
        //private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    ctrl.HienThiTaiSanDuocChon(this.dataGridView1, this.txtsohoadon,
        //    this.txtmataisan,
        //    this.cmbtentaisan,
        //    this.cmbmanhom,
        //    this.cmbdonvitinh,
        //    this.txtnuocsx,
        //    this.datatimenamsx,
        //    this.txthansudung,
        //    this.cmblydotang,
        //    this.datetimengaytang,
        //    this.numdieuchinhtang,
        //    this.numgiatrisaukhitang,
        //    this.txtsoluong,
        //    this.txtnguyengia,
        //    this.nummuckhauhao,
        //    this.numdakhauhao,
        //    this.numconlai,
        //    this.cmbbophansudung,
        //    this.cmbphongban,
        //    this.cmbmucdichsudung,
        //    this.rtxtghichu );
        //}

       
       

      
      
    }
}