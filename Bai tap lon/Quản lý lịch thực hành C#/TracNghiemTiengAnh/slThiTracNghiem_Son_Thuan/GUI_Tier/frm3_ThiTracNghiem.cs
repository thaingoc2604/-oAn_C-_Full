using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using Entities;

namespace GUI_Tier
{
    public partial class frm3_ThiTracNghiem : Form
    {
        public frm3_ThiTracNghiem()
        {
            InitializeComponent();
        }

        public static string s= "THI TRẮC NGHIỆM TIẾNG ANH                                           ";
        public int place = 0;
        public int socauhoi = 0;  
        public static double Diem = 0;
        public static string mamonthi;
        B_MonThi B_MT = new B_MonThi();
        B_KetQua B_KQ = new B_KetQua();
        DataTable dt_MONTHI = new DataTable();
        DataTable dt_CAUHOI = new DataTable();
        DataTable dt_DAPAN = new DataTable();

        //Khởi tạo mảng lưu các câu hỏi
        ArrayList Array_Cauhoi = new ArrayList();
        ArrayList Array_Mach = new ArrayList();
        //Khởi tạo mảng lưu các đáp án
        ArrayList Array_Dapan = new ArrayList();
        ArrayList Array_Kieudapan = new ArrayList();
        ArrayList madapandung = new ArrayList();

        //Mãng các đáp án thí sinh đánh
        ArrayList DapAn_ThiSinh = new ArrayList();
        
        
        private void frm3_ThiTracNghiem_Load(object sender, EventArgs e)
        {
            ancacbutton(false);
            //---------LOAD CÁC THÔNG TIN CƠ BẢN--------
           
                lblHoten.Text = frm1_DN.TenThiSinhDiThi;
                GRP_THI.Enabled = false;
            
            //lblNgayThi.Text = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();
            pic_NopBaiThi.Enabled = false;
            //-----lấy môn thi đưa vào comboboxmonthi-----------
            dt_MONTHI = new B_MonThi().GetMonThi();
            cboMonThi.DataSource = dt_MONTHI;
            cboMonThi.DisplayMember = "TENMON";
            cboMonThi.ValueMember = "MAMON";

            //--------số câu hỏi----------------------
            cboSoCauHoi.Text = "10";
            lblMaCauHoi.Visible = true;
            
        }

        private void GanCauHoiVaoMang()
        {
            //Lấy giá trị câu hỏi
           
            if (cboSoCauHoi.Text == "10")
            {
                socauhoi = 10;
                proThoiGian.Maximum = 500;               
            }
            else if (cboSoCauHoi.Text == "30")
            {
                socauhoi = 30;
                proThoiGian.Maximum = 10000;
            }
            else
            {
                socauhoi = 60;
                proThoiGian.Maximum =45000;
            }

            //Lấy câu hỏi và lưu vào mảng--------------------------------------------
            
            dt_CAUHOI = new B_CauHoi().RanDomCauHoi(cboSoCauHoi.Text, cboMonThi.SelectedValue.ToString());
            for (int i = 0; i < socauhoi; i++)
            {
                Array_Mach.Add(dt_CAUHOI.Rows[i][0].ToString());//-----mã câu hỏi ở vị trí 0 trong bảng câu hỏi
                Array_Cauhoi.Add(dt_CAUHOI.Rows[i][1].ToString());//------nội dung câu hỏi trong bảng-----
                //Tạo đáp án ảo cho Thí Sinh
                DapAn_ThiSinh.Add("5");

                dt_DAPAN = new B_DapAn().GetDapAn(Array_Mach[i].ToString()).Tables[0];
                
                for (int j = 0; j < 4; j++)
                {
                    Array_Dapan.Add(dt_DAPAN.Rows[j][0].ToString());//--nôi dung các đáp án--------  
                    Array_Kieudapan.Add(dt_DAPAN.Rows[j][1].ToString());//---------kiểu đáp án                   
                    
                    if (dt_DAPAN.Rows[j][1].ToString().Trim().Equals("1"))//----nếu kiểu đáp án =1
                    {
                        //Đáp án lưu theo số thứ tự (Ví dụ A lưu thành 1 và B lưu thành 2)
                        madapandung.Add(Convert.ToString(j + 1));//------add đáp án đúng và lưu vào mảng
                    }                    
                }
            }
           
        }

        //------------HÀM HIỂN THỊ CÂU HỎI------------------
        public void Hienthicauhoi(int cau)
        {
            lbl_noidungcauhoi.Text = "Câu " + (cau + 1) + " : " + Array_Cauhoi[cau].ToString();
            //lblMaCauHoi.Text = Array_Mach[cau].ToString();
            Hienthidapan(cau);
        }

        //--------------------HÀM HIỂN THỊ CÁC ĐÁP ÁN---------------------------
        public void Hienthidapan(int b)
        {
            lblDapAnA.Text = Array_Dapan[0 + (b * 4)].ToString();
            lblDapAnB.Text = Array_Dapan[1 + (b * 4)].ToString();
            lblDapAnC.Text = Array_Dapan[2 + (b * 4)].ToString();
            lblDapAnD.Text = Array_Dapan[3 + (b * 4)].ToString();
        }
      
        


        private void btnDau_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            place = 0;
            Hienthicauhoi(place);
            Danh_Dap_An_ThiSinh();
        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {            
            if (place == 0)
            {
                Hienthicauhoi(0);
                Danh_Dap_An_ThiSinh();
            }
            else
            {
                LuuDapAn();
                place--;
                Danh_Dap_An_ThiSinh();
                Hienthicauhoi(place);
            }
        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (place == socauhoi - 1)
            {
                LuuDapAn();
                Hienthicauhoi(socauhoi-1);
                Danh_Dap_An_ThiSinh();
            }
            else
            {
                LuuDapAn();
                place++;
                Danh_Dap_An_ThiSinh();
                Hienthicauhoi(place);
            }
           
        }
        private void btnCuoi_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            place = socauhoi - 1;
            Hienthicauhoi(socauhoi - 1);
            Danh_Dap_An_ThiSinh();
        }

        private void LuuDapAn()
        {
            String answer = "";
            if (radA.Checked == true)
            {
                answer = "1";
            }
            if (radB.Checked == true)
            {
                answer = "2";
            }
            if (radC.Checked == true)
            {
                answer = "3";
            }
            if (radD.Checked == true)
            {
                answer = "4";
            }
            DapAn_ThiSinh[place] = answer;
        }
        //Đánh đáp án của thí sinh đã đánh vào trắc nghiệm
        private void Danh_Dap_An_ThiSinh()
        {
            if (DapAn_ThiSinh[place].ToString() == "1")
            {
                radA.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "2")
            {
                radB.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "3")
            {
                radC.Checked = true;
            }
            else if (DapAn_ThiSinh[place].ToString() == "4")
            {
                radD.Checked = true;
            }
            else
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }
        }

        
        

        
        private void tmThoiGianThi_Tick(object sender, EventArgs e)
        {
            proThoiGian.Value++;
            if (proThoiGian.Value == proThoiGian.Maximum)
            {
                tmThoiGianThi.Stop();
                MessageBox.Show("Đã Hết Giờ Làm Bài !!!");
                proThoiGian.Value = 1;
                nopbaithi_ketqua();
                if (MessageBox.Show("Bạn Có Muốn Trở Về Giao Diện Chính Không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                    frm.Show();
                    this.Hide(); 
                }
            }
        }

        private void CHUCHAY_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void cboSoCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            mamonthi = cboMonThi.SelectedValue.ToString();
        }
        private void ancacbutton(bool an)
        {
            btnCuoi.Enabled = an;
            btnDau.Enabled = an;
            btnTiep.Enabled = an;
            btnTruoc.Enabled = an;
        }

        private void pic_BatDauThi_Click(object sender, EventArgs e)
        {
            try
            {
                ancacbutton(true);
                lbldapan.Visible = true;
                // lblMaCauHoi.te;
                GRP_THI.Enabled = true;
                // lblMaCauHoi.Visible = false;
                lblHoten.Text = frm1_DN.TenThiSinhDiThi;
                //----enable button nopbai
                pic_NopBaiThi.Enabled = true;
                //--------gán câu hỏi vào mảng----
                GanCauHoiVaoMang();
                //Hiển thị câu hỏi đầu tiên
                Hienthicauhoi(0);
                //--------bắt đầu tính thời gian-------------
                tmThoiGianThi.Start();
                //for (int i = 0; i < socauhoi; i++)
                //{
                //    lbldapan.Text += madapandung[i].ToString() + " ";

                //}
                pic_BatDauThi.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Load Câu Hỏi Thất Bại !!\n Bạn Vui Lòng Load Lại Trang Thi Trắc Nghiệm ","Thông Báo");
                frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
                frm.Show();
                this.Hide();
            }
        }

        private void nopbaithi_ketqua()
        {
            try
            {
                //-----------dừng thời gian thi lại-------
                LuuDapAn();
                tmThoiGianThi.Stop();
                double diem = 0;
                int socaudung = 0;
                for (int i = 0; i < socauhoi; i++)
                {
                    // MessageBox.Show(DapAn_ThiSinh[i].ToString() + "@" + madapandung[i].ToString());
                    if (DapAn_ThiSinh[i].ToString() == madapandung[i].ToString())
                    {
                        socaudung++;
                    }
                }

                diem = Math.Pow((10 / (double)socauhoi * socaudung), 1);

                if (frm1_DN.chon == "Thí Sinh")
                {
                    //-----------lưu điểm lại cho người thi rồi load điểm lại cho họ xem---------
                    //MessageBox.Show("ma mon thi :" + mamonthi);
                    KetQua kqt = new KetQua(frm1_DN.mathisinh, frm1_DN.TenThiSinhDiThi, mamonthi, diem, dtpic.Value);
                    if (B_KQ.LuuKetQua_B(kqt) > 0)
                    {
                        MessageBox.Show("Bạn " + lblHoten.Text + " Thi Được : " + diem, "Kết Quả Thi !!");
                        pic_BatDauThi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Lưu Kết Quả ", "Thông Báo !!");
                    }

                }

                else
                {
                    MessageBox.Show("Bạn " + lblHoten.Text + " Thi Được : " + diem, "Kết Quả Thi");
                    pic_BatDauThi.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Lưu Kết Quả ", "Thông Báo !!");
            }
        }
        private void pic_NopBaiThi_Click(object sender, EventArgs e)
        {
            nopbaithi_ketqua();
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
            frm.Show();
            this.Hide();
        }
    }
}
