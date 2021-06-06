using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using tracnghiem_bs;


namespace Thibanglai_UI
{
    public partial class frmthi : Form
    {
        public frmthi()
        {
            InitializeComponent();
        }

        thisinhbs objts = new thisinhbs();
        DataTable dt;
        public delegate string GetText();
        public GetText Getten;
        public GetText Getngaysinh;
        public GetText Getmonthi;
        public GetText Getsocau;
        public GetText Getmamon;
        public GetText GetMaTS;

        ArrayList Array_Cauhoi = new ArrayList();
        ArrayList Array_Mach = new ArrayList();
        ArrayList Array_hinh = new ArrayList();
        ArrayList Array_Dapan = new ArrayList();
        ArrayList Array_Kieudapan = new ArrayList();



        public int place = 0;
        int sch;


        GroupBox[,] GroupBoXCauHoi = new GroupBox[20, 1];

        RadioButton[,] RadioCauTraLoi = new RadioButton[1, 4];

        string str1 = "";

        static int giay = 00;
        static int phut = 20;
        public void HienThiGroupBox()
        {
            GroupBox GrpBox;
            Size sideGrpBox = new Size(40, 133);


            sch = 15;


            for (int i = 0; i < sch; i++)
                for (int j = 0; j < 1; j++)
                {
                    GrpBox = new GroupBox();
                    int cau = i + 1;
                    GrpBox.Text = cau.ToString();
                    GrpBox.Size = sideGrpBox;
                    GrpBox.BackColor = Color.Transparent;
                    GrpBox.Location = new Point(50 + i * 40, 25 + 133 * j);
                    RadioButton Radiobt;
                    Size sideradio = new Size(20, 20);
                    for (int k = 0; k < 1; k++)
                        for (int l = 0; l < 4; l++)
                        {
                            Radiobt = new RadioButton();
                            Radiobt.Size = sideradio;
                            Radiobt.Location = new Point(14 + k * 20, 20 + l * 27);
                            GrpBox.Controls.Add(Radiobt);
                            RadioCauTraLoi[k, l] = Radiobt;
                        }
                    this.groupBox3.Controls.Add(GrpBox);
                    GroupBoXCauHoi[i, j] = GrpBox;
                }
        }
        public void KetThuc()
        {

            IEnumerator ie = this.groupBox3.Controls.GetEnumerator();
            int i = 0;
            int j = 0;
            GroupBox[] mgroupbox = new GroupBox[sch];
            while (ie.MoveNext())
            {
                i++;
                if (i <= sch)
                {
                    try
                    {
                        GroupBox r = (GroupBox)ie.Current;
                        mgroupbox[j] = r;
                        j++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Khong phai groupbox" + i);
                    }
                }

            }


            int[] mangdapan = new int[sch];

            for (int k = 0; k < mgroupbox.Length; k++)
            {
                RadioButton[] ra = new RadioButton[4];
                IEnumerator ie2 = mgroupbox[k].Controls.GetEnumerator();
                i = 0;
                while (ie2.MoveNext())
                {
                    ra[i] = (RadioButton)ie2.Current;
                    i++;
                }
                mangdapan[k] = XetRadio(ra);
            }

            foreach (object s in madapandung)
            {
                str1 += s.ToString();
            }

            double socaudung = Chamdiem(madapandung, mangdapan);
            Label kq = new Label();
            if (socaudung >= 12)
            {
                kq.Text = "Đậu";
            }
            else
            {
                kq.Text = "Rớt";
            }
            objts.ThemKetQua(lblma.Text, kq.Text, lblmamon.Text);

            frmketqua f = new frmketqua();
            f.GetTen += delegate { return lblten.Text; };
            f.GetSoCau += delegate { return socaudung.ToString(); };
            f.Show();
            this.Hide();
        }
        public int XetRadio(RadioButton[] radio)
        {
            for (int i = 0; i < radio.Length; i++)
            {
                if (radio[i].Checked)
                {
                    return i + 1;
                }
            }
            return 0;

        }
        ArrayList madapandung = new ArrayList();
        public void Label()
        {
            Label a = new Label(); a.Text = "A"; a.Location = new Point(20, 45); groupBox3.Controls.Add(a);
            Label b = new Label(); b.Text = "B"; b.Location = new Point(20, 72); groupBox3.Controls.Add(b);
            Label c = new Label(); c.Text = "C"; c.Location = new Point(20, 99); groupBox3.Controls.Add(c);
            Label d = new Label(); d.Text = "D"; d.Location = new Point(20, 126); groupBox3.Controls.Add(d);
            a.BackColor = Color.Transparent;
            b.BackColor = Color.Transparent;
            c.BackColor = Color.Transparent;
            d.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (giay != 00)
                giay--;
            else
            {
                giay = 59;
                if (phut != 00)
                    phut--;
                else
                {
                    phut = giay = 00;
                    timer1.Stop();
                    MessageBox.Show("Hết Thời Gian !");
                    KetThuc();
                }
            }
            lblphut.Text = phut.ToString();
            lblgiay.Text = giay.ToString();
        }
        private void frmthi_Load(object sender, EventArgs e)
        {   
            lblten.Text = Getten();
            lblma.Text = GetMaTS();
            lblmamon.Text = Getmamon();
            timer1.Interval = 1000;
            timer1.Start();
            lblmacauhoi.Visible = false;
            dt = objts.GetCauHoi().Tables[0];
            for (int i = 0; i < 15; i++)
            {
                Array_Cauhoi.Add(dt.Rows[i]["ndcauhoi"].ToString());
                Array_hinh.Add(dt.Rows[i]["hinh"].ToString());
                Array_Mach.Add(dt.Rows[i]["macauhoi"].ToString());
                DataTable dt2 = objts.GetDapAn(Array_Mach[i].ToString()).Tables[0];
                for (int j = 0; j < 4; j++)
                {
                    Array_Dapan.Add(dt2.Rows[j]["ndcautraloi"].ToString());
                    Array_Kieudapan.Add(dt2.Rows[0]["kieudapan"].ToString());
                    if (dt2.Rows[j][1].ToString().Trim().Equals("1"))
                    {
                        madapandung.Add(Convert.ToString(j + 1));
                    }
                }

            }
            Hienthicauhoi(0);
            

            HienThiGroupBox();
            Label();
            string tr = "";
            foreach (object o in madapandung)
            {
                tr += o.ToString() + ";";
            }
           
        }
        
        public void Hienthicauhoi(int cau)
        {

            lblcauhoi.Text = "Câu "+(cau+1)+ ": " + Array_Cauhoi[cau].ToString();
            lblmacauhoi.Text = Array_Mach[cau].ToString();
            pictureBox2.ImageLocation = Array_hinh[cau].ToString();
            Hienthidapan(cau);
        }

        public void Hienthidapan(int b)
        {
            lbldapan1.Text = Array_Dapan[0 + b * 4].ToString();
            lbldapan2.Text = Array_Dapan[1 + b * 4].ToString();
            lbldapan3.Text = Array_Dapan[2 + b * 4].ToString();
            lbldapan4.Text = Array_Dapan[3 + b * 4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (place == 0)
            {
                Hienthicauhoi(0);
            }
            else
            {
                place--;
                Hienthicauhoi(place);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (place == 14)
            {
                Hienthicauhoi(14);
            }
            else
            {
                place++;
                Hienthicauhoi(place);
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult OK;
            OK = MessageBox.Show("Thời gian vẫn còn! Bạn muốn kết thúc bài thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                KetThuc();
            }
            else
            {
                timer1.Start();
                return;
            }
        }
        public int Chamdiem(ArrayList dapan, int[] traloi)
        {
            int dem = 0;
            for (int i = 0; i < dapan.Count; i++)
            {
                if (dapan[i].ToString().Equals(traloi[i].ToString()))
                {
                    dem++;
                }
            }
            return dem;
        }

    }
}