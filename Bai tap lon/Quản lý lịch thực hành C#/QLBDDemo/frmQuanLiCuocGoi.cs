using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;


namespace QLBDDemo
{
    public partial class frmQuanLiCuocGoi : Form
    {
        private String connString = "server = (local)\\SQLEXPRESS; database = QLBD; Integrated Security = true";
       // private DataSet dsQLBD;
        public int countTime;
        
        public frmQuanLiCuocGoi()
        {
            InitializeComponent();
        }
        //Thuc hien kien tra du lieu nhap vao
        public bool KiemTraDuLieuVao()
        {
            if ((cboLoaiDichVu.ValueMember == "VT01") && (txtSoCanGoi.Text.Length == 6)) return true;
            else if ((cboLoaiDichVu.ValueMember == "VT02") && (txtSoCanGoi.Text.Length == 6)) return true;
            else if ((cboLoaiDichVu.ValueMember == "VT03") && (txtSoCanGoi.Text.Length >= 9) && (txtSoCanGoi.Text.Length <= 11)) return true;
            else if ((cboLoaiDichVu.ValueMember == "VT04") && (txtSoCanGoi.Text.Length >= 10) && (txtSoCanGoi.Text.Length <= 11)) return true;
            else if ((cboLoaiDichVu.ValueMember == "VT05") && (txtSoCanGoi.Text.Length >=15)) return true;
            else return false;
        }

        //thực hiện các chức năng kiểm tra dữ liệu nhập
        public bool checkLoaiDichVu()
        {
            if (cboLoaiDichVu.ValueMember == "")
            {
                
                MessageBox.Show("Bạn chưa chọn loại dịch vụ", "Thong bao");
                return false;
            }
            else return true;
        }

        public bool checkSoCanGoi()
        {
            if (txtSoCanGoi.Text == "")
            {
                
                MessageBox.Show("Bạn chưa nhập số cần gọi", "Thong bao");
                return false;
            }
            else return true;
        }

        public bool checkTyGiaUSD()
        {
            if (txtTyGia.Text == "")
            {
                
                MessageBox.Show("Bạn chưa nhập tỷ giá USD", "Thong bao");
                return false;
            }
            else return true;
        }

        public bool checkCall()
        {
            if (txtHienThiSoGiay.Text == "")
            {
                
                MessageBox.Show("Phải bấm nút Bắt Đầu trước khi lưu", "thong bao");
                return false;
            }
            else return true;
        }
        //kết thúc kiểm tra

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (btnBatDau.Text == "Bắt Đầu Gọi")
            {
                //thuc hien chuc nang cua bat dau cuoc goi
                if (txtSoCanGoi.Text != "" && KiemTraDuLieuVao())
                {
                    btnBatDau.Text = "Kết thúc";
                    cboLoaiDichVu.Enabled = false;
                    countTime = 0;
                    txtSoCanGoi.Enabled = false;
                    txtTyGia.Enabled = false;
                    btnCuocGoiMoi.Enabled = false;
                    btnLuuDuLieu.Enabled = false;
                    lblGiay.Visible = true;
                    txtHienThiSoGiay.Visible = true;
                    lblThoiGian.Visible = true;
                    timerChaySoGiay.Start();
                    txtThoiGianBatDau.Text = DateTime.Now.ToLongTimeString();
                }
                else
                {
                    MessageBox.Show("Bạn kiểm tra lại dữ liệu ở dịch vụ, nhập số cần gọi và độ dài của số cần gọi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnBatDau.Text == "Kết thúc")
            {
                //thuc hien voi chuc nang cua 
                txtTongTien.Text = RoundMoney(TongTien()).ToString();
                timerChaySoGiay.Stop();
                btnBatDau.Text = "Bắt Đầu Gọi";
                this.TinhThoiGian(countTime);
                cboLoaiDichVu.Enabled = true;
                btnLuuDuLieu.Enabled = true;
                lblThoiGian.Visible = false;
                lblGiay.Visible = false;
                txtHienThiSoGiay.Visible = false;
                btnCuocGoiMoi.Visible = true;
                txtThoiGianKetThuc.Text = DateTime.Now.ToLongTimeString();
                btnCuocGoiMoi.Enabled = true;
            }
        }

        private void TinhThoiGian(int i)
        {

            double d = Convert.ToDouble(i / 60);
            double SoPhut = Math.Round(d);
            txtTongThoiGian.Text = SoPhut.ToString() + " Phút" + " : " + Convert.ToString(i - d * 60) + "giây";

        }

        private void btnThoatQuanLiCuocGoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //thiết lập valuesMember cho cbo

        private void cboLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueLoaiDichVu = cboLoaiDichVu.SelectedItem.ToString();



            if (cboLoaiDichVu.SelectedItem.ToString() == "Điện thoại nội hạt")
            {
                cboLoaiDichVu.ValueMember = "VT01";
                lblTyGiaUSD.Visible = false;
                txtTyGia.Visible = false;
            }
            else if (cboLoaiDichVu.SelectedItem.ToString() == "Điện thoại nội tỉnh")
            {
                cboLoaiDichVu.ValueMember = "VT02";
                lblTyGiaUSD.Visible = false;
                txtTyGia.Visible = false;
            }
            else if (cboLoaiDichVu.SelectedItem.ToString() == "Điện thoại liên tỉnh")
            {
                cboLoaiDichVu.ValueMember = "VT03";
                lblTyGiaUSD.Visible = false;
                txtTyGia.Visible = false;
            }
            else if (cboLoaiDichVu.SelectedItem.ToString() == "Điện thoại di động")
            {
                cboLoaiDichVu.ValueMember = "VT04";
                lblTyGiaUSD.Visible = false;
                txtTyGia.Visible = false;
            }
            else if (cboLoaiDichVu.SelectedItem.ToString() == "Điện thoại quốc tế")
            {
                cboLoaiDichVu.ValueMember = "VT05";
                lblTyGiaUSD.Visible = true;
                txtTyGia.Visible = true;
            }
            else
            {
                cboLoaiDichVu.SelectedItem = "";
                cboLoaiDichVu.ValueMember = "";
            }

        }

        //Lam tron so tien

        private int RoundMoney(double d)
        {
            int result;
            int temp = Convert.ToInt32(d);
            if (temp <= 500) return 500;
            else if (temp <= 1000 && d > 500) return 1000;
            else if (temp < 10000 && temp > 1000)
                {
                    Math.DivRem(temp, 1000, out result);
                    if (result < 500) return (temp - result + 500);
                    else return (temp - result + 1000);
                }
                else if (temp > 10000)
                {
                    Math.DivRem(temp, 10000, out result);
                    if (result < 500) return (temp - result + 500);
                    else return (temp - result + 1000);
                }
                return 0;
        }
       
        private void frmQuanLiCuocGoi_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connString);
                String sqlCommandString = "";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandString, connString);
                SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra! ");
            }
        }

        //Sinh ra MACUOCGOI
        private string SinhMaCuocGoi()
        {
            string day = DateTime.Now.Day.ToString();
            if (day.Length < 2) day = "0" + day;
            string month = DateTime.Now.Month.ToString();
            if (month.Length < 2) month = "0" + month;
            string year = DateTime.Now.Year.ToString();
            string y = year.Substring(year.Length - 2, 2);
            return (day + month + y );
        }

        //Chuc nang lay so thu tu trong cot ma cuoc goi


        //ham lam tron so phut

        private int RoundSecond()
        {
            int sodu;
            int temp = countTime;
            Math.DivRem(countTime, 60, out sodu);
            if (countTime < 60) return 1;
            else if ( countTime > 60)
            {
                if ( sodu < 30 ) return (temp - sodu)/60;
                else if ( sodu >30 ) return ((temp - sodu)/60 + 1);
            }
            return 0;    
        }

        //phuong thuc luu du lieu

        private void btnLuuDuLieu_Click(object sender, EventArgs e)
        {
            string maCuocGoi = SinhMaCuocGoi() + txtTtCuocGoi.Text;
            string maDichVu = cboLoaiDichVu.ValueMember;
            string soCanGoi = txtSoCanGoi.Text;
            string thoiGianBatDau = txtThoiGianBatDau.Text;
            string thoiGianKetThuc = txtThoiGianKetThuc.Text;
            int sanLuong = RoundSecond();
            string cuocThu = txtTongTien.Text;

            if (checkCall() && checkLoaiDichVu() && checkSoCanGoi() && checkTyGiaUSD())
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(connString);
                    sqlConnection.Open();
                    SqlCommand comm = sqlConnection.CreateCommand();
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "INSERT INTO CUOCGOI(MACUOCGOI, MADV, SOMAYGOI, THOIGIAN_BATDAU, THOIGIAN_KETTHUC, SANLUONG, CUOCTHU) VALUES ('"
                        + maCuocGoi + "', '" + maDichVu + "', '" + soCanGoi + "', '" + thoiGianBatDau + "', '" +
                        thoiGianKetThuc + "', '" + sanLuong + "', '" + cuocThu + " ')";
                    comm.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        
       
        private void btnCuocGoiMoi_Click(object sender, EventArgs e)
        {
            txtSoCanGoi.Enabled = true;
            txtTyGia.Enabled = true;
            txtSoCanGoi.Text = "";
            txtTyGia.Text = "";
            txtThoiGianBatDau.Text = "";
            txtThoiGianKetThuc.Text = "";
            txtTongThoiGian.Text = "";
            txtTongTien.Text = "";
        }

        //Chuc nang tinh tong so tien

        private double TongTien()
        {
            if (cboLoaiDichVu.ValueMember == "VT01")
            {
                //thuc hien tinh cuoc voi truong hop goi noi hat
                return ((countTime * 400) / 60);
            }
            else if (cboLoaiDichVu.ValueMember == "VT02")
            {
                //tinh cuoc goi noi tinh
                return ((countTime * 500) / 60);
            }
            else if (cboLoaiDichVu.ValueMember == "VT03")
            {
                //tinh cuoc voi goi lien tinh
                return ((countTime * 80) / 6);
            }
            else if (cboLoaiDichVu.ValueMember == "VT04")
            {
                //tinh cuoc goi di dong
                return ((countTime * 100) / 6);
            }
            else if (cboLoaiDichVu.ValueMember == "VT05")
            {
                //tinh cuoc goi quoc te
                double tien = Convert.ToDouble(txtTyGia.Text);
                return ((countTime * 0.16 * tien) / 6);
            }
            return 0.0;
        }

        private void timerChaySoGiay_Tick(object sender, EventArgs e)
        {
            countTime += 1;
            txtHienThiSoGiay.Text = countTime.ToString();
        }

        private void gboQuanLiCuocGoi_Enter(object sender, EventArgs e)
        {

        }
    }
}