using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Tier;
using System.Threading;
using System.IO;
namespace frmAdministrator
{
    public partial class frmLamBai : Form
    {
        public frmLamBai()
        {
            InitializeComponent();
        }
        public delegate void pass();
        public pass pa;
        ToolTip tt = new ToolTip();
        int count = 0, time = 0;
        string duoi = ".mic";
        bDeThi dethi = new bDeThi();//tạo 1 đề thi mới
        int dung = 0;//số câu đúng  
        int sai = 0;
        int index = 0;//câu hỏi hiện tại đang thực hiện
        public void set()
        {
            if (index < count)
            {
                this.tt.Hide(this.panel4);
                uncheck();//không check 1 cái nào cả            
                this.rtbCauHoi.Text = this.dethi.cauhoi[index].noi_dung;
                this.tbA.Text = this.dethi.cauhoi[index].tachdapan(1);
                this.tbB.Text = this.dethi.cauhoi[index].tachdapan(2);
                this.tbC.Text = this.dethi.cauhoi[index].tachdapan(3);
                this.tbD.Text = this.dethi.cauhoi[index].tachdapan(4);
                this.lbLinhVuc.Text = "Tín chỉ : " + this.dethi.cauhoi[index].tin_chi;
                this.lbMucDo.Text = "Mức độ : " + this.dethi.cauhoi[index].muc_do;
                this.lbCauHoiSo.Text = "Câu hỏi số : " + (this.index + 1);
            }
        }
        private void uncheck()
        {
            if (this.rbA.Checked) this.rbA.Checked = false;
            else if (this.rbB.Checked) this.rbB.Checked = false;
            else if (this.rbC.Checked) this.rbC.Checked = false;
            else if (this.rbD.Checked) this.rbD.Checked = false;
        }

        private string check()
        {
            if (this.rbA.Checked) { return "A"; }
            else if (this.rbB.Checked) { return "B"; }
            else if (this.rbC.Checked) { return "C"; }
            else if (this.rbD.Checked) { return "D"; }
            else return "";
        }


        //Xử lý mở file từ form làm bài
        public void import(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists && (fi.Extension).ToLower() == duoi.ToLower())
            {
                try
                {
                    dethi.ThemTuFile(path);//thêm từ 1 file câu hỏi vào đề thi
                    this.count = dethi.TongSo();
                    lbCount.Text = "Tổng số câu hỏi  : " + this.count;
                    set(); this.time = this.count * dethi.time;
                }
                catch
                {
                    MessageBox.Show("Lỗi nhập khi nhập từ file '" + path);
                }
            }
        }
        public void import(ListView lv, int time)
        {
            try
            {
                ThemTuListView(lv, time);//thêm từ 1 file câu hỏi vào đề thi
                this.count = dethi.TongSo();
                lbCount.Text = "Tổng số câu hỏi  : " + this.count;
                set(); this.time = this.count * dethi.time;
            }
            catch { MessageBox.Show("Lỗi khi nhập đề thi từ listview !"); };
        }
        public void ThemTuListView(ListView lv, int time)
        {
            if (lv.Items.Count > 0)
            {
                try
                {
                    this.time = time;
                    string noidung, dapan, mucdo, dapandung, tinchi;
                    for (int i = 0; i < lv.Items.Count; i++)
                    {
                        noidung = lv.Items[i].SubItems[1].Text;
                        dapan = lv.Items[i].SubItems[2].Text;
                        dapandung = lv.Items[i].SubItems[3].Text;
                        mucdo = lv.Items[i].SubItems[4].Text;
                        tinchi = lv.Items[i].SubItems[5].Text;
                        dethi.Themcauhoi(noidung, dapan, dapandung, mucdo, tinchi, time);
                    }
                }
                catch { }
            }
        }
    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }


        private void btnTraLoi_Click(object sender, EventArgs e)
        {
            if (index < count)
            {
                if (kiemtra())
                {
                    this.tt.ToolTipTitle = "Kết quả";
                    string temp = "";
                    if (dethi.cauhoi[index].dap_an_dung == check())
                    {
                        dung++;
                        temp = "Chính xác (^_^)";
                        this.tt.ForeColor = Color.Lime;
                    }
                    else
                    {
                        sai++;
                        temp = "Đáp án " + this.dethi.cauhoi[index].dap_an_dung + " mới chính xác";
                        this.tt.ForeColor = Color.Orange;
                    }
                    if (temp != "") thongbao(temp);
                    this.lbDung.Text = "Đúng : " + dung;
                    this.lbSai.Text = "Sai : " + sai;
                    index++;//làm tiếp câu tiếp theo
                    if (index == count)//nếu là câu cuối cùng 
                    {
                        timer1.Stop();
                        Thread.Sleep(2000);
                        XepHang();//xếp hạng (khi làm xong đề) 
                    }
                    else Thread.Sleep(2000);//tạm dừng 2 giây để xem kết quả
                    set();//hiện nội dung câu hỏi khác
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.time > 0)
            {
                this.time--;
                this.lbTime.Text = "Thời gian còn lại : " + this.time;
            }
            else
            {
                timer1.Stop();
                //MessageBox.Show("Hết thời gian mất rồi . Xin chia buồn >.<", "Timeout | User");
                this.tt.ForeColor = Color.Red;
                this.tt.ToolTipTitle = "Timeout !";
                thongbao("Hết thời gian làm bài(^_^)");
                Thread.Sleep(4000);
                XepHang();//xếp hạng
                //dừng
            }
        }

        //thông báo
        private void thongbao(string s)
        {
            this.tt.BackColor = Color.Black;
            this.tt.ToolTipIcon = ToolTipIcon.Info;
            this.tt.Show(s, this.panel4, new Point(200, 50));
        }

        //xếp hạng
        private void XepHang()
        {
            string s = "";
            string loai = "";
            int phantram = 0;
            if (count != 0)
            {
                phantram = (int)(dung * 100 / count);
                if (phantram < 50) loai = "Yếu";
                else if (phantram >= 50 && phantram < 60) loai = "Trung Bình";
                else if (phantram >= 60 && phantram < 70) loai = "Trung Bình Khá";
                else if (phantram >= 70 && phantram < 80) loai = "Khá";
                else if (phantram >= 80 && phantram < 90) loai = "Giỏi";
                else if (phantram >= 90 && phantram <= 100) loai = "Xuất sắc";
                s = "Kết thúc quá trình làm bài\nSố câu hỏi : " + count + "\nSố câu đúng : " + dung + " (" + phantram + " %)\nSố câu sai : " + sai + " (" + (100 - phantram) + " %)\nXếp loại : " + loai + " - trong các loại (yếu,trung bình,trung bình khá,khá,giỏi,xuất sắc)";
                this.rtbCauHoi.Text = s;
                this.btnTraLoi.Enabled = false;
                this.panel4.Enabled = false;
                this.tt.Hide(this.panel4);
            }
        }

        private bool kiemtra()//kiểm tra xem đã có đáp án nào được check hay chưa
        {
            if (!this.rbA.Checked && !this.rbB.Checked && !this.rbC.Checked && !this.rbD.Checked)
            {
                MessageBox.Show("Bạn chưa lựa chọn đáp án nào cả >.< ", "Check | User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void frmLamBai_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn dừng việc làm bài ?", "Xác nhận| User", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                if (pa != null) pa();
                this.Dispose();
            }
            else e.Cancel = true;  
        }

        #region Xử lý hiện Tooltip trên các Button chức năng
            private void btnTraLoi_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Nhấn chọn câu trả lời sau cùng", this.btnTraLoi, new Point(1, -67));
            }
            private void btnTraLoi_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnTraLoi);
            }

            private void btnThoat_MouseHover(object sender, EventArgs e)
            {
                this.tt.Show("Dừng việc đánh trắc nghiệm !", this.btnTraLoi, new Point(1, -67));
            }

            private void btnThoat_MouseLeave(object sender, EventArgs e)
            {
                this.tt.Hide(this.btnThoat);
            }
        #endregion

    }
}
