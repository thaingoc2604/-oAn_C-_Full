using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using DevComponents.DotNetBar;
using BUS_Tier;
namespace frmAdministrator
{
    public partial class frmThemCauHoi : Form
    {
        public frmThemCauHoi()
        {
            InitializeComponent();
        }

        bCauHoi objch = new bCauHoi();
        bTinChi objtc = new bTinChi();
        bMucDo objmd = new bMucDo();

        DataTable tbmucdo, tbtinchi;
        BindingSource bs = new BindingSource();

        //Tạo ủy quyền delegate để cập nhật trên form thư viện
        public delegate void edit_library(int index, string noidung, string dapan, string dapandung, string mucdo, string linhvuc, string mamd, string madad, string matc);
        public edit_library edit_lib;
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            this.richTextBox1.Text = "";
            this.tbA.Text = "";
            this.tbB.Text = "";
            this.tbC.Text = "";
            this.tbD.Text = "";
        }

        //dùng cho form edit câu hỏi từ đề thi
        public void setInfo(string mucdo, string dapandung, string linhvuc)
        {
            //radio
            if (dapandung == "A") this.rbA.Checked = true;
            else if (dapandung == "B") this.rbB.Checked = true;
            else if (dapandung == "C") this.rbC.Checked = true;
            else if (dapandung == "D") this.rbD.Checked = true;
            //mức độ
            for (int i = 0; i < cboMucDo.Items.Count; i++)
            {
                if (cboMucDo.Items[i].ToString() == mucdo) { cboMucDo.SelectedIndex = i; break; }
            }
            //lĩnh vực
            for (int i = 0; i < cboTinChi.Items.Count; i++)
            {
                if (linhvuc == cboTinChi.Items[i].ToString()) { cboTinChi.SelectedIndex = i; break; }
            }
        }
        public string Dapandung(int n)
        {
            if (n == 0)
            {
                if (this.rbA.Checked) return "1";
                else if (this.rbB.Checked) return "2";
                else if (this.rbC.Checked) return "3";
                else if (this.rbD.Checked) return "4";
                else return "0";
            } if (n == 1)
            {
                if (this.rbA.Checked) return "A";
                else if (this.rbB.Checked) return "B";
                else if (this.rbC.Checked) return "C";
                else if (this.rbD.Checked) return "D";
                else return "";
            } return "";
        }
        int edit = 0;//biến cờ dùng để xác định nhiệm vụ của button apply (vì dùng chung 1 form)
        public void set_flag(int update)
        {
            this.edit = update;
        }
        public delegate void pass(frmThemCauHoi f);//add câu hỏi, truyền câu hỏi đến đề thi trong form tạo đề thi
        public pass pa;
        private void btnApply_Click(object sender, EventArgs e)
        {
            CapNhat();
        }
        public string maq = "";//lấy mã câu hỏi trong trường hợp update
        public int index = 0;//trong trường hợp edit listview cần phải biết item nào

        private void CapNhat()
        {
            string noidung = this.richTextBox1.Text;
            string dapan = this.tbA.Text + ";" + this.tbB.Text + ";" + this.tbC.Text + ";" + this.tbD.Text;
            string mamd = (this.cboMucDo.SelectedIndex + 1).ToString();
            string madad = Dapandung(0);
            string matc = (this.cboTinChi.SelectedIndex + 1).ToString();
            try
            {

                if (check_luu())
                {
                    //xác định nhiệm vụ của button
                    if (edit == 0)//xác nhận đây là insert câu hỏi vào csdl
                    {

                        //thêm câu hỏi
                        int n = objch.Insert_Question(noidung, dapan, madad, mamd, matc);
                        if(n > 0)
                            MessageBox.Show("Thêm câu hỏi thành công !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                            MessageBox.Show("Thêm câu hỏi thất bại !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }
                    else if (edit == 1)//update câu hỏi vào csdl
                    {
                        //chỉnh sửa câu hỏi
                        int n= objch.Update_Question(noidung, dapan, madad, mamd, matc, maq);
                        if (edit_lib != null)
                        {
                            //delegate
                            edit_lib(index, this.richTextBox1.Text, this.tbA.Text + ";" + this.tbB.Text + ";" + this.tbC.Text + ";" + this.tbD.Text , Dapandung(1),this.cboMucDo.Text, this.cboTinChi.Text, (this.cboMucDo.SelectedIndex + 1).ToString(), Dapandung(0), this.cboTinChi.SelectedIndex.ToString());
                        }
                        if (n > 0)
                        {
                            MessageBox.Show("Update câu hỏi thành công !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Update câu hỏi thất bại !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (edit == 3)//thêm câu hỏi  tới form đề thi
                    {
                        if (pa != null) pa(this);
                    }
                    else if (edit == 4)//edit câu hỏi của form đề thi
                    { if (pa != null) { pa(this); this.Close(); } };
                }
                else MessageBox.Show("Thông tin nhập vào có sự trùng lặp hoặc chưa được nhập !\nLàm lại nhá , đừng ngại (^_^)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception loi) { MessageBox.Show(loi.Message + "\n" + loi.StackTrace, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool check_luu()//kiểm tra điều kiện để lưu vào cơ sở dữ liệu
        {
            //kiểm tra text box
            if (this.tbA.Text == "") return false;
            if (this.tbB.Text == "") return false;
            if (this.tbC.Text == "") return false;
            if (this.tbD.Text == "") return false;
            //kiểm tra các đáp án giống nhau không
            if (this.tbA.Text == this.tbB.Text) return false;
            if (this.tbA.Text == this.tbC.Text) return false;
            if (this.tbA.Text == this.tbD.Text) return false;
            if (this.tbB.Text == this.tbC.Text) return false;
            if (this.tbB.Text == this.tbD.Text) return false;
            if (this.tbC.Text == this.tbD.Text) return false;
            //kiểm tra xem lĩnh vực, mức độ đã chọn chưa ?
            if (cboTinChi.SelectedIndex < 0) return false;
            if (cboMucDo.SelectedIndex < 0) return false;
            //kiểm tra các phương án đã chọn chưa
            if (!rbA.Checked && !rbB.Checked && !rbC.Checked && !rbD.Checked) return false;
            //kiểm tra nội dung xem có rỗng không ?
            if (this.richTextBox1.Text == "") return false;
            //kiểm tra xem các trường dữ liệu có chứa dấu hiệu phân tách không
            if (this.richTextBox1.Text.IndexOf(";") >= 0 || this.tbA.Text.IndexOf(";") >= 0 || this.tbB.Text.IndexOf(";") >= 0 || this.tbC.Text.IndexOf(";") >= 0 || this.tbD.Text.IndexOf(";") > 0)
            {
                MessageBox.Show("Các trường dữ liệu không được chứa dấu ';'", "Check Syntax | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;  // đủ điều kiện          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            if (this.richTextBox1.Text == "") { this.groupBox2.Enabled = false; this.btnApply.Enabled = false; }
            else { this.groupBox2.Enabled = true; this.btnApply.Enabled = true; }
            this.label3.Text = "Còn lại " + (this.richTextBox1.MaxLength - this.richTextBox1.Text.Length) + " kí tự";
        }

        private void frmThemCauHoi_Load(object sender, EventArgs e)
        {
            check();
        }

        public void set_linhvuc_mucdo()
        {
            tbmucdo = objmd.get_table_MuDo();
            tbtinchi = objtc.get_table_TinChi();
            cboTinChi.DataSource = tbtinchi;
            cboMucDo.DataSource = tbmucdo;
            try
            {
                cboTinChi.DisplayMember = "TenTC".ToString();
                cboTinChi.ValueMember = "MaTC".ToString();

                //xừ lý trên combobox mức độ

                cboMucDo.DisplayMember = "TenMD".ToString();
                cboMucDo.ValueMember = "MaMD".ToString();

            }
            catch { }
        }
        public void setcontent(string noidung, string dapan,int dapandung,int mucdo, int linhvuc)
        {
            try
            {
                this.richTextBox1.Text = noidung;
                //dap an dung
                if (dapandung == 1) rbA.Checked = true;
                else if (dapandung == 2) rbB.Checked = true;
                else if (dapandung == 3) rbC.Checked = true;
                else if (dapandung == 4) rbD.Checked = true;
                //Dap an
                string[] dap = dapan.Split(';');
                this.tbA.Text = dap[0];
                this.tbB.Text = dap[1];
                this.tbC.Text = dap[2];
                this.tbD.Text = dap[3];
                check();//kiểm tra enable group box
                set_linhvuc_mucdo();
                this.cboMucDo.SelectedIndex = mucdo - 1;
                this.cboTinChi.SelectedIndex = linhvuc - 1;

            }
            catch { };
        }        

    }
}
