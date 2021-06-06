using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using ConvertDB;

namespace Accounting
{
    public partial class Form_ThongtinPhieu : Office2007Form
    {
        TKThuChi_DTO _tk_DTO;

        public Form_ThongtinPhieu(TKThuChi_DTO tk_DTO)
        {
            InitializeComponent();

            _tk_DTO = tk_DTO;
        }

        private void Form_ThongtinPhieu_Load(object sender, EventArgs e)
        {
            DienGiai_BUS dg_BUS = new DienGiai_BUS();

            MaDG_Combo.DataSource = dg_BUS.GetDSDG();

            MaDG_Combo.SelectedIndex = -1;

            txtHoTen.Text = _tk_DTO.Hoten;

            txtDiaChi.Text = _tk_DTO.DiaChi ;

            DTimeNgaylap.Value = _tk_DTO.Ngaythang;

            txtDienGiai.Text = _tk_DTO.DG;

            if (_tk_DTO.Maloaiphieu == 1)
            {
                numSotien.Value = _tk_DTO.TienThu;

                txtID.Text = _tk_DTO.Maphieuthu.ToString();

                label1.Text += " Thu";

                label2.Text += " nộp tiền";

                label4.Text += " thu";

                this.Text += " Thu";

                groupBox1.Text += " Thu";
            }
            else
            {
                numSotien.Value = _tk_DTO.TienChi;

                txtID.Text = _tk_DTO.Maphieuchi.ToString();

                label1.Text += " Chi";

                label2.Text += " nhận tiền";

                label4.Text += " chi";

                this.Text += " Chi";

                groupBox1.Text += " Chi";
            }

            ChuSoTienLBL.Text = ChuSotien(numSotien.Value);
        }

        public string ChuSotien(decimal number)
        {
            string str = " ";

            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;

            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str = str + "đồng chẵn";

        }

        private void numSotien_Validated(object sender, EventArgs e)
        {
            ChuSoTienLBL.Text = "";
            ChuSoTienLBL.Text = ChuSotien(numSotien.Value);

        }

        string chuanhoachuoi(string chuoi)//chuoi: chuỗi cần chuẩn hoá
        {
            string s = chuoi;
            ConvertFont convert = new ConvertFont();

            convert.Convert(ref s, FontIndex.iTCV, FontIndex.iUNI);
            string a = Microsoft.VisualBasic.Strings.StrConv(s, Microsoft.VisualBasic.VbStrConv.ProperCase, 0);
            a = a.Trim();
            while (Microsoft.VisualBasic.Strings.InStr(a, "  ", 0) > 0)
            {
                a = a.Replace("  ", " ");
            }

            convert.Convert(ref a, FontIndex.iUNI, FontIndex.iTCV);
            return a;
        }

        private void bttLapPhieu_Click(object sender, EventArgs e)
        {
            if (txtDienGiai.Text != ""&& numSotien.Value > 0)
            {
                TKThuChi_BUS TK_BUS = new TKThuChi_BUS();

                if (_tk_DTO.Maloaiphieu == 1)
                {
                    _tk_DTO.TienThu = int.Parse(numSotien.Value.ToString());

                    _tk_DTO.Ngaythang = DTimeNgaylap.Value;
                    _tk_DTO.SoTon = 0;
                    _tk_DTO.DG = txtDienGiai.Text;
                    _tk_DTO.Maphieuthu = int.Parse(txtID.Text);
                    if (TK_BUS.Cap_nhat_Phieu_Thu(_tk_DTO) == 1)
                    {

                        MessageBoxEx.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }


                }
                else
                {
                    _tk_DTO.TienChi = int.Parse(numSotien.Value.ToString());
                    _tk_DTO.Ngaythang = DTimeNgaylap.Value;
                    _tk_DTO.SoTon = 0;
                    _tk_DTO.DG = txtDienGiai.Text;
                    _tk_DTO.Maphieuchi = int.Parse(txtID.Text);
                    if (TK_BUS.Cap_nhat_Phieu_Chi(_tk_DTO) == 1)
                    {

                        MessageBoxEx.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
              
                errorProvider1.Clear();
            }
            else
            {
                if (txtDienGiai.Text == "")
                    errorProvider1.SetError(txtDienGiai, "Chưa nhập nội dung diễn giải!");

                if (numSotien.Value == 0)
                    errorProvider1.SetError(numSotien, "Chưa nhập tiền hoặc số tiền thu phải lớn hơn 0!");
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form_ThongtinPhieu_Activated(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }

        

     
       

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.Text = chuanhoachuoi(txtHoTen.Text);
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                MaDG_Combo.Focus();
            }
        }

        private void MaDG_Combo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtDienGiai.Text = _tk_DTO.DG = MaDG_Combo.Text + " ," + txtHoTen.Text + " ," + txtDiaChi.Text; 
                numSotien.Focus();
            }
        }

        private void numSotien_KeyDown(object sender, KeyEventArgs e)
        {
        //    bttLapPhieu.Focus();
        }

        private void DTimeNgaylap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                bttLapPhieu.Focus();
            }
        }

        private void numSotien_Validated_1(object sender, EventArgs e)
        {
            ChuSoTienLBL.Text = "";
            ChuSoTienLBL.Text = ChuSotien(numSotien.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TKThuChi_BUS TK_BUS = new TKThuChi_BUS();

            Form_Confirm frm = new Form_Confirm("Bạn có muốn xóa?");

            DialogResult rs = frm.ShowDialog();

            if (rs == DialogResult.Yes)
            {
                TK_BUS.Huy_Phieu(_tk_DTO);

                this.DialogResult = DialogResult.Abort;

                Close();
            }

        }

        private void MaDG_Combo_Leave(object sender, EventArgs e)
        {
            txtDienGiai.Text = _tk_DTO.DG = MaDG_Combo.Text + " ," + txtHoTen.Text + " ," + txtDiaChi.Text;
            
        }
    }
}