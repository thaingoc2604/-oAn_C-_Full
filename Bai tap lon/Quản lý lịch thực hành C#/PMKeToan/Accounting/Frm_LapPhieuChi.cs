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
    public partial class Frm_LapPhieuChi :  Office2007Form
    {
        TKThuChi_BUS _tk_BUS;
        public Frm_LapPhieuChi()
        {
            InitializeComponent();

            _tk_BUS = new TKThuChi_BUS();
        }

       

        private void LapPhieuChi_Load(object sender, EventArgs e)
        {
            DienGiai_BUS dg_BUS = new DienGiai_BUS();
            MaDG_Combo.DataSource = dg_BUS.GetDSDG();
            DTimeNgaylap.Value = DateTime.Now;
            PHIEUCHI_BUS pc = new PHIEUCHI_BUS();
            int id = pc.getIDMax() + 1;
            txtID.Text = id.ToString();
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

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            ChuSoTienLBL.Text = "";
            ChuSoTienLBL.Text = ChuSotien(numSotien.Value);
            
        }

        private void MaDG_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(MaDG_Combo.SelectedValue.ToString());
        }

        private void bttLapPhieu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (_tk_BUS.Kiem_Tra_Ma_Phieu_Chi(int.Parse(txtID.Text)) == 0 && txtHoTen.Text != "" && txtDiaChi.Text != "" && MaDG_Combo.Text!= "" && numSotien.Value!=0 )
           {
                 PHIEUCHI_BUS phieuchi_BUS = new PHIEUCHI_BUS();

                 PHIEUCHI_DTO phieuchi_DTO = new PHIEUCHI_DTO();

                phieuchi_DTO.Maphieuchi = int.Parse(txtID.Text);
                phieuchi_DTO.Diachi=txtDiaChi.Text;
                phieuchi_DTO.Maloaiphieu=2;
                phieuchi_DTO.Sotien=int.Parse(numSotien.Value.ToString());
                phieuchi_DTO.Ngaylap=DTimeNgaylap.Value;
                phieuchi_DTO.Ton=0;
                phieuchi_DTO.Diengiai=MaDG_Combo.Text + " ," + txtHoTen.Text + " ," + txtDiaChi.Text;

                 if (phieuchi_BUS.LapPhieu(phieuchi_DTO)  == 1)
                 {

                     MessageBoxEx.Show("Lập phiếu thành công! :" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     ResetAll();
                 }
            }
            else
            {
                if (txtHoTen.Text == "")
                    errorProvider1.SetError(txtHoTen, "Chưa nhập họ tên!");

                if (txtDiaChi.Text == "")
                    errorProvider1.SetError(txtDiaChi, "Chưa nhập địa chỉ!");

                if (MaDG_Combo.Text == "")
                    errorProvider1.SetError(MaDG_Combo, "Chưa nhập lý do thu!");

                if (numSotien.Value == 0)
                    errorProvider1.SetError(numSotien, "Chưa nhập tiền hoặc số tiền thu phải lớn hơn 0!");

                if(_tk_BUS.Kiem_Tra_Ma_Phieu_Chi(int.Parse(txtID.Text)) >0)
                    errorProvider1.SetError(txtID, "Trùng mã phiếu chi!");

            }
            
        }

        private void ResetAll()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            MaDG_Combo.SelectedIndex = 0;
            numSotien.Value = 0;
            DTimeNgaylap.Value = DateTime.Now;
            PhieuThu_BUS pt = new PhieuThu_BUS();
            int id = pt.getIDMax() + 1;
            txtID.Text = id.ToString();
        }

        string chuanhoachuoi(string chuoi)//chuoi: chuỗi cần chuẩn hoá
        {
            string  s = chuoi;
            ConvertFont convert = new ConvertFont();
            
            convert.Convert(ref s, FontIndex.iTCV, FontIndex.iUNI);
            string a = Microsoft.VisualBasic.Strings.StrConv(s, Microsoft.VisualBasic.VbStrConv.ProperCase, 0);
            a = a.Trim();
            while (Microsoft.VisualBasic.Strings.InStr(a, "  ", 0) > 0)
            {
                a = a.Replace("  ", " ");
            }

            convert.Convert(ref a, FontIndex.iUNI, FontIndex.iTCV);
            return a ;
        }


      

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.Text = chuanhoachuoi(txtHoTen.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LapPhieuChi_Activated(object sender, EventArgs e)
        {
            txtID.Focus();
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
                numSotien.Focus();
            }
        }

        private void numSotien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                DTimeNgaylap.Focus();
            }
        }

        private void ChuSoTienLBL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                DTimeNgaylap.Focus();
            }
        }

        private void DTimeNgaylap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                bttLapPhieu.Focus();
            }
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtDiaChi.Focus();
            }
        }

        private void txtID_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (_tk_BUS.Kiem_Tra_Ma_Phieu_Chi(int.Parse(txtID.Text)) > 0)
            {
                errorProvider1.SetError(txtID, "Trùng mã phiếu chi!");
            }
            else
                errorProvider1.Clear();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtHoTen.Focus();
            }
        } 
    }
}