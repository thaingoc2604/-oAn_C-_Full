using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Xml.Linq;

using Business_Tier;
using Entities;

namespace ThiTracNghiem_THDC
{
    public partial class frmThiThu : Form
    {
        private List<CauHoi> arrCauHoi = new List<CauHoi>();
        B_CauHoi objcauhoi = new B_CauHoi();

        CauHoi cautracnghiem = new CauHoi();
        BindingSource bs = new BindingSource();
        public frmThiThu()
        {
            InitializeComponent();
        }
        int cauHienTai = 0;

        int flag = 0;

        bool flaga = false;
        bool flagb = false;
        bool flagc = false;
        bool flagd = false;

        int tongThoiGianThi;

        private DateTime thoiGianThi;
        int soCauDung = 0;//tính số câu đúng
        float diemThi = 0;//tính điểm thi
        private void frmThiThu_Load(object sender, EventArgs e)
        {
            //ok
            //enable các button xem, bắt đầu, câu tiếp,câu trước và kết thúc
            btnXemDapAn.Enabled = false;
            btnBatDau.Enabled = false;
            btnCauTiep.Enabled = false;
            btnCauTruoc.Enabled = false;
            btnKetThuc.Enabled = false;
            Bat_TatRadiobutton(false);
            timer1.Stop();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            KiemTraKetQua();
            btnXemDapAn.Enabled = true;
            btnBatDau.Enabled = false;
            btnDuongDan.Enabled = false;
            Bat_TatRadiobutton(false);
        }
        //ok
        private void Bat_TatRadiobutton(bool p)
        {
            radA.Enabled=p;
            radB.Enabled=p;
            radC.Enabled=p;
            radD.Enabled=p;
        }
        //ok
        private void MoTrangThai_Radiobutton(int radio)
        {
            if (radio == 1)

                radA.Checked = true;
            else if (radio == 2)
                radB.Checked = true;
            else if (radio == 3)
                radC.Checked = true;
            else if (radio == 4)
                radD.Checked = true;
            else
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }
            
        }
        //ok
        //kiểm tra kết quả
        private void KiemTraKetQua()
        {
            for (int i = 0; i < arrCauHoi.Count; i++)
            {
                if (arrCauHoi[i].CauTraLoi == arrCauHoi[i].DapAnDung)
                {
                    soCauDung++;
                    diemThi = diemThi + (float)10 / arrCauHoi.Count;
                }
            }
            lblCauDung.Text = soCauDung.ToString() + "/" + arrCauHoi.Count.ToString();
            lblDiem.Text = diemThi.ToString();
            if (diemThi<5)
            {
                lblDanhGia.Text = "Không đạt yêu cầu !";

            }
            else if(diemThi >=5&& diemThi<=7)
            {
                lblDanhGia.Text = "Đạt yêu cầu .Tốt";
            }
            else if(diemThi>7 && diemThi<=10)
            {
                lblDanhGia.Text = "Đạt yêu cầu .Khá";
            }
        }
        //ok
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Hide();
                frmMain frmve_main = new frmMain();
                frmve_main.ShowDialog();
            }
        }
        //ok
        private int KiemTra_TraLoi()
        {
            if (radA.Checked == true || radB.Checked == true 
                || radC.Checked == true || radD.Checked == true)
                return 1;
            return 0;

        }
        //luu xong
        private void Luu_CauTraLoi()
        {
            if (KiemTra_TraLoi() == 1)
            {
                if (radA.Checked == true)
                    arrCauHoi[cauHienTai].CauTraLoi = 1;
                if (radB.Checked == true)
                    arrCauHoi[cauHienTai].CauTraLoi = 2;
                if (radC.Checked == true)
                    arrCauHoi[cauHienTai].CauTraLoi = 3;
                if (radD.Checked == true)
                    arrCauHoi[cauHienTai].CauTraLoi = 4;

            }
            else
                arrCauHoi[cauHienTai].CauTraLoi = 0;
        }
        //tô xong màu những câu đúng
        private void DoiMauCauDung(int cauHienTai)
        {
            int temp = arrCauHoi[cauHienTai].DapAnDung;
            if (temp==1)
            {
                flaga = true;
                flagb = false;
                flagc = false;
                flagd = false;
            }
            if (temp == 2)
            {
                flaga = false;
                flagb = true;
                flagc = false;
                flagd = false;
            }
            if (temp == 3)
            {
                flaga = false;
                flagb = false;
                flagc = true;
                flagd = false;
            }

            if (temp == 4)
            {
                flaga = false;
                flagb = false;
                flagc = false;
                flagd = true;
            }
            lblDapAnA.BackColor = flaga ? Color.Red : Color.White;
            lblDapAnB.BackColor = flaga ? Color.Red : Color.White;
            lblDapAnC.BackColor = flaga ? Color.Red : Color.White;
            lblDapAnD.BackColor = flaga ? Color.Red : Color.White;
        }

        private void LoadDeThi()
        {
            OpenFileDialog mode = new OpenFileDialog();
         
            mode.Filter = "XML file(*.xml)|*.xml|All file(*.*)|*.*";
            if (mode.ShowDialog()==DialogResult.OK)
            {
                arrCauHoi.Clear();
                string path = mode.FileName;
                txtDuongDan.Text = path;
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlElement root = doc.DocumentElement;
                XmlNodeList rootCauHoi = root.ChildNodes;
                for(int i=0;i<rootCauHoi.Count;i++)
                {
                    CauHoi cautracnghiem = new CauHoi();
                    XmlNode nodeNoiDung = rootCauHoi[i].SelectSingleNode("NoiDung");
                    cautracnghiem.NoiDung = nodeNoiDung.InnerText.ToString();
                    XmlNode nodeDapAnA = rootCauHoi[i].SelectSingleNode("DapAnA");
                    cautracnghiem.DapAnA = nodeNoiDung.InnerText.ToString();
                    XmlNode nodeDapAnB = rootCauHoi[i].SelectSingleNode("DapAnB");
                    cautracnghiem.DapAnB = nodeNoiDung.InnerText.ToString();
                    XmlNode nodeDapAnC = rootCauHoi[i].SelectSingleNode("DapAnC");
                    cautracnghiem.DapAnC = nodeNoiDung.InnerText.ToString();
                    XmlNode nodeDapAnD = rootCauHoi[i].SelectSingleNode("DapAnD");
                    cautracnghiem.DapAnD = nodeNoiDung.InnerText.ToString();
                    XmlNode nodeDapAnDung = rootCauHoi[i].SelectSingleNode("DapAnDung");
                    cautracnghiem.DapAnDung = int.Parse(nodeDapAnDung.InnerText);

                    arrCauHoi.Add(cautracnghiem);
                }
                DialogResult dl=MessageBox.Show("Đề thi được nạp thành công !. Nhấn [Bắt đầu] để làm bài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dl == DialogResult.OK)
                {
                    btnDuongDan.Enabled = false;
                    btnBatDau.Enabled = true;
                    tongThoiGianThi = arrCauHoi.Count * 600;
                    thoiGianThi = new DateTime(2000, 1, 1, 0, tongThoiGianThi / 60, tongThoiGianThi % 60, 0);
                    lblThoiGianConLai.Text = thoiGianThi.Minute.ToString() + " : " + thoiGianThi.Second.ToString();

                }
            }
            else
            {
                DialogResult dl = MessageBox.Show("Đề thi chưa được nạp. Bạn không thể bắt đầu bài thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    btnDuongDan.Enabled = true;
                    btnBatDau.Enabled = false;
                }
            }
        }
        private void btnCauTiep_Click(object sender, EventArgs e)
        {
            if (cauHienTai <= arrCauHoi.Count - 2)
            {
                cauHienTai = cauHienTai + 1;
              MoTrangThai_Radiobutton(arrCauHoi[cauHienTai].CauTraLoi);
                if (flag == 1)
                {
                    DoiMauCauDung(cauHienTai);
                    lblCauHoi.Text = (cauHienTai + 1).ToString() + "." + arrCauHoi[cauHienTai].NoiDung;
                    lblDapAnA.Text = arrCauHoi[cauHienTai].DapAnA;
                    lblDapAnB.Text = arrCauHoi[cauHienTai].DapAnB;
                    lblDapAnC.Text = arrCauHoi[cauHienTai].DapAnC;
                    lblDapAnD.Text = arrCauHoi[cauHienTai].DapAnD;

                }
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Thời gian làm bài bắt đầu đếm ngược.Điểm tối đa là 10 điểm.\n\rĐề thi có" + " " + arrCauHoi.Count.ToString() + " " + "câu hỏi" + " Chúc bạn thi tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                if (dl == DialogResult.OK)
                {
                    timer1.Start();
                    btnBatDau.Enabled = false;
                    btnDuongDan.Enabled = false;
                    btnKetThuc.Enabled = true;
                    btnXemDapAn.Enabled = false;
                    btnCauTiep.Enabled = true;
                    btnCauTruoc.Enabled = true;
                    Bat_TatRadiobutton(true);
                    lblCauHoi.Text = "1. " + arrCauHoi[0].NoiDung;
                    lblDapAnA.Text = arrCauHoi[0].DapAnA;
                    lblDapAnB.Text = arrCauHoi[0].DapAnB;
                    lblDapAnC.Text = arrCauHoi[0].DapAnC;
                    lblDapAnD.Text = arrCauHoi[0].DapAnD;
                }
            }
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if (cauHienTai <= arrCauHoi.Count - 1)
            {
                cauHienTai = cauHienTai - 1;
                if (cauHienTai >= 0)
                {
                    MoTrangThai_Radiobutton(arrCauHoi[cauHienTai].CauTraLoi);
                    if (flag == 1)
                     DoiMauCauDung(cauHienTai);
                    lblCauHoi.Text = (cauHienTai + 1).ToString() + "." + arrCauHoi[cauHienTai].NoiDung;
                    lblDapAnA.Text = arrCauHoi[cauHienTai].DapAnA;
                    lblDapAnB.Text = arrCauHoi[cauHienTai].DapAnB;
                    lblDapAnC.Text = arrCauHoi[cauHienTai].DapAnC;
                    lblDapAnD.Text = arrCauHoi[cauHienTai].DapAnD;
                }
                else
                {
                    cauHienTai = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 1);
            thoiGianThi = thoiGianThi.Subtract(dt);
            lblThoiGianConLai.Text = thoiGianThi.Minute.ToString() + " : " + thoiGianThi.Second.ToString();
            if (thoiGianThi.Minute == 0 && thoiGianThi.Second == 0)
            {
                timer1.Enabled = false;
                DialogResult dl = MessageBox.Show("Thời gian làm bài đã hết.Mời bạn xem kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    if (dl == DialogResult.OK)
                        KiemTraKetQua();
                }
            }
        }

        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            Luu_CauTraLoi();
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {
           Luu_CauTraLoi();
        }

        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            Luu_CauTraLoi();
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            Luu_CauTraLoi();
        }

        private void btnXemDapAn_Click(object sender, EventArgs e)
        {
            flag = 1;
            DoiMauCauDung(cauHienTai);
        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            LoadDeThi();
            btnKetThuc.Enabled = false;
            Bat_TatRadiobutton(false);
        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {

        }
        //kiểm tra kết quả
        
    }
}
