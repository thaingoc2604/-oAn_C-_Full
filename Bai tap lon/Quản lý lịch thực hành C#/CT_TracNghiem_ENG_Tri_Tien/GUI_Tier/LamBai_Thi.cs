using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Bus_Tier;
namespace GUI_Tier
{
    public partial class LamBai_Thi : Form
    {
        public LamBai_Thi()
        {
            InitializeComponent();
        }
        public static int vitri = 0;
        bool trangthai = false;
        public static double Diem=0;
        public static String ho;
        public static String ten;
        DeThi_Bus dethi;
        User_Bus us;
        DapAn_Bus da;
        CauHoi_Bus ch;
        ArrayList arr_cauhoi = new ArrayList();
        ArrayList arr_dapan = new ArrayList();
        ArrayList arr_noidung_dapan = new ArrayList();
        ArrayList arr_noidung_cauhoi = new ArrayList();
        ArrayList arr_danh_dapan = new ArrayList();
        private void ThoiGianThi()
        {
            dethi = new DeThi_Bus(Student.made.Trim().ToString());
            proThoiGian.Maximum = dethi.ThoiGian_Thi();
            lblThoiGian.Text = "Thời gian thi:" + proThoiGian.Value + "/" + proThoiGian.Maximum;
        }
        private void NapCauHoi(String macauhoi)
        {
            ch = new CauHoi_Bus(macauhoi);
            DataRow dr = ch.Show_CauHoi().Tables["tb_cauhoi"].Rows[0];
            arr_noidung_cauhoi.Add(dr["noidungcauhoi"].ToString());
        }
        private void tmThoiGian_Tick(object sender, EventArgs e)
        {
            ThoiGianThi();
            proThoiGian.Value++;
            if (proThoiGian.Value == proThoiGian.Maximum)
            {
                ThoiGianThi();
                tmThoiGian.Stop();
                button5_Click(sender, e);
            }
        }
        private void Danh_DapAn()
        {
            if (arr_danh_dapan[vitri].ToString() == "E")
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }
            else
            {
                if (arr_danh_dapan[vitri].ToString() == "A")
                    radA.Checked = true;
                if (arr_danh_dapan[vitri].ToString() == "B")
                    radB.Checked = true;
                if (arr_danh_dapan[vitri].ToString() == "C")
                    radC.Checked = true;
                if (arr_danh_dapan[vitri].ToString() == "D")
                    radD.Checked = true;
            }
        }
        private void CapNhat_DapAn()
        {
            if (radA.Checked == true)
                arr_danh_dapan[vitri] = "A";
            if (radB.Checked == true)
                arr_danh_dapan[vitri] = "B";
            if (radC.Checked == true)
                arr_danh_dapan[vitri] = "C";
            if (radD.Checked == true)
                arr_danh_dapan[vitri] = "D";
        }
        private void NapDapAn(String macauhoi)
        {
            da = new DapAn_Bus(macauhoi);
            DataTable dt=da.Show_DapAn_Ran().Tables["tb_dapan"];
            List<String> li = new List<string>();
            //biến lưu đáp án đúng là A,B,C,D
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                arr_noidung_dapan.Add(dr["noidungdapan"].ToString());
                if (Int16.Parse(dr["dapandung"].ToString()) == 1)
                {
                    if (i == 0)
                        arr_dapan.Add("A");
                    if (i == 1)
                        arr_dapan.Add("B");
                    if (i == 2)
                        arr_dapan.Add("C");
                    if (i == 3)
                        arr_dapan.Add("D");
                }
                    i++;
            }
        }
        private void NapCauHoi()
        {
            dethi = new DeThi_Bus(Student.made.Trim().ToString());
            DataTable dt= dethi.Load_Cau_Hoi().Tables["tb_dethi"];
            foreach (DataRow dr in dt.Rows)
            {
                arr_cauhoi.Add(dr["macauhoi"].ToString().Trim().ToString());
                NapDapAn(dr["macauhoi"].ToString().Trim().ToString());
                NapCauHoi(dr["macauhoi"].ToString().Trim().ToString());
            }
        }
        private void LamBai_Thi_Load(object sender, EventArgs e)
        {
            btnThoat.Enabled = false;
            NapCauHoi();
            ThoiGianThi();
            HienThi_ThongTin();
            HienThi_LenComponent();
        }
        private void NapDapAnGia()
        {
            for(int i=0;i<proThoiGian.Maximum;i++){
                arr_danh_dapan.Add("E");
            }
        }
        private void HienThi_LenComponent()
        {
            if (vitri > proThoiGian.Maximum - 1)
            {
                vitri = proThoiGian.Maximum - 1;
            }
            int k = vitri * 4 + 3;
            NapDapAnGia();
            lblCauHoiHienTai.Text = "Câu hỏi:" + (vitri + 1) + "/" + proThoiGian.Maximum;
            lblNoiDungCauHoi.Text = arr_noidung_cauhoi[vitri].ToString();
            lblDapAnA.Text = arr_noidung_dapan[k - 3].ToString();
            lblDapAnB.Text = arr_noidung_dapan[k - 2].ToString();
            lblDapAnC.Text = arr_noidung_dapan[k - 1].ToString();
            lblDapAnD.Text = arr_noidung_dapan[k].ToString();
        }
        public void HienThi_ThongTin()
        {
            us = new User_Bus(DangNhap.TenDangNhap, DangNhap.MatKhau);
            MemoryStream str = new MemoryStream(us.Ret_Pic());
            picHinhAnhSV_LamBai.Image = Image.FromStream(str);
            DataTable dt = us.Get_ThongTin_User().Tables["tb_user"];
            DataRow dr = dt.Rows[0];
            ho = dr["Ho"].ToString();
            ten = dr["Ten"].ToString();
            lblHoTen_LamBai.Text = dr["Ho"].ToString() + " " + dr["Ten"].ToString();
            lblDiaChi_LamBai.Text = dr["DiaChi"].ToString();
            dtpNgaySinh_LamBai.Value = DateTime.Parse(dr["ngaysinh"].ToString());
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            CapNhat_DapAn();
            vitri++;
            if (vitri <= proThoiGian.Maximum - 1)
            {
                ToMau_Nen_Label();
                Danh_DapAn();
                HienThi_LenComponent();
                Dap_An_Dung();
            }
            else vitri--;
        }
        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            CapNhat_DapAn();
            vitri--;
            if (vitri >= 0)
            {
                ToMau_Nen_Label();
                Danh_DapAn();
                HienThi_LenComponent();
                Dap_An_Dung();
            }
            else vitri++;
        }
        private void btnCauCuoi_Click(object sender, EventArgs e)
        {
            vitri = proThoiGian.Maximum - 1;
            ToMau_Nen_Label();
            Danh_DapAn();
            HienThi_LenComponent();
            Dap_An_Dung();
        }

        private void btnCauDau_Click(object sender, EventArgs e)
        {            
                vitri = proThoiGian.Minimum - 1;
                ToMau_Nen_Label();
                Danh_DapAn();
                HienThi_LenComponent();
                Dap_An_Dung();          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (proThoiGian.Value != proThoiGian.Maximum)
            {
                if (KiemTra_DieuKien_NopBai())
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn muốn nộp bài kết thúc?", "End Test", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        btnThoat.Enabled = true;
                        NopBai();
                        
                    }
                }
            }
            else
            {
                btnThoat.Enabled = true;
                NopBai();
            }
        }
        private void NopBai()
        {
            try
            {
                tmThoiGian.Stop();
                button5.Enabled = false;
                trangthai = true;
                int n = 0;
                vitri = proThoiGian.Maximum - 1;
                CapNhat_DapAn();
                for (int i = 0; i < proThoiGian.Maximum; i++)
                {
                    if (arr_danh_dapan[i].ToString() == arr_dapan[i].ToString())
                    {
                        n++;
                    }
                }
                Diem = 10 / (double)proThoiGian.Maximum * n;
                Diem = Math.Round(Diem, 1);
                XemDiem xemdiem = new XemDiem();
                if (xemdiem.ShowDialog() == DialogResult.OK)
                {
                    ToMau_Nen_Label();
                    Danh_DapAn();
                    HienThi_LenComponent();
                    Dap_An_Dung();
                }
            }
            catch (Exception)
            {
                
            }
        }
        public void Dap_An_Dung()
        {
            if (trangthai == true)
            {
                if (arr_dapan[vitri].ToString() == "A")
                {
                    lblDapAnA.BackColor = Color.Teal;
                }
                if (arr_dapan[vitri].ToString() == "B")
                {
                    lblDapAnB.BackColor = Color.Teal;
                }
                if (arr_dapan[vitri].ToString() == "C")
                {
                    lblDapAnC.BackColor = Color.Teal;
                }
                if (arr_dapan[vitri].ToString() == "D")
                {
                    lblDapAnD.BackColor = Color.Teal;
                }
            }                
        }
        public void ToMau_Nen_Label()
        {
            lblDapAnA.BackColor = Color.Transparent;
            lblDapAnB.BackColor = Color.Transparent;
            lblDapAnC.BackColor = Color.Transparent;
            lblDapAnD.BackColor = Color.Transparent;
        }
        public bool KiemTra_DieuKien_NopBai()
        {
            for (int i = 0; i < proThoiGian.Maximum-1; i++)
            {
                if (arr_danh_dapan[i].ToString() == "E")
                {
                    MessageBox.Show("Vui lòng chọn tất cả đáp án\nNếu nộp bài sớm hơn");
                    return true;
                }
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
