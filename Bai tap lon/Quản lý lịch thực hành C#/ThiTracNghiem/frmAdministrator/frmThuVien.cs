using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS_Tier;
namespace frmAdministrator
{
    public partial class frmThuVien : Form
    {
        public frmThuVien()
        {
            InitializeComponent();
        }
        public delegate void pass(ListView lv);// truyền listview về form tạo đề thi
        public pass pa;
        System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();//hiện helps
        frmTimKiem f = new frmTimKiem();//form nhập liệu để tìm kiếm
        bThuVien objtv = new bThuVien();
        DataTable tbtv;
        private void frmThuVien_Load(object sender, EventArgs e)
        {
            tbtv = objtv.get_ThuVien_KetHop();
            addtolistview(tbtv);
        }


        private void btnReconnect_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn load lại thư viện câu hỏi ?", "Reconnect | Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                DataTable tbupdate = objtv.get_ThuVien_KetHop();
                addtolistview(tbupdate);
            }
        }


        private void addtolistview(DataTable tbtv)
        {
            listView1.Items.Clear();
            foreach (DataRow dr in tbtv.Rows)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan,tenmucdo,tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }

        #region Xử lý tìm kiếm 
        private void addtolistview_theo_noidung(DataTable tbtv, string chuoibosung)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("NoiDung Like '%"+chuoibosung+"%'");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_noidung_tc_md_dapandung(DataTable tbtv, string chuoibosung, int mucdo, int tinchi, int dapandung)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("NoiDung Like '%" + chuoibosung + "%' AND MaMD="+mucdo+" AND MaTC="+tinchi+" AND MaDA="+dapandung+"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_mucdo(DataTable tbtv, int mucdo)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaMD="+ mucdo +"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_tinchi(DataTable tbtv, int tinchi)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaTC=" + tinchi + "");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_dapandung(DataTable tbtv, int dapandung)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaDA=" + dapandung + "");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_noidung_mucdo(DataTable tbtv, string noi_dung, int mucdo)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaMD="+ mucdo +" AND NoiDung like '%"+noi_dung+"%'");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }

        private void addtolistview_theo_noidung_tinchi(DataTable tbtv, string noi_dung, int tinchi)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaTC=" + tinchi + " AND NoiDung like '%" + noi_dung + "%'");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_noidung_dapandung(DataTable tbtv, string noi_dung, int dapan_dung)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaDA=" + dapan_dung + " AND NoiDung like '%" + noi_dung + "%'");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }

        private void addtolistview_theo_mucdo_tinchi(DataTable tbtv, int tinchi, int mucdo)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaMD=" + mucdo + " AND MaMD="+mucdo+"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_mucdo_dapandung(DataTable tbtv, int dapan_dung, int mucdo)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaMD=" + mucdo + " AND MaDA="+dapan_dung+"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_dapandung_tinchi(DataTable tbtv, int tinchi, int dapan_dung)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaTC=" + tinchi + " AND MaDA="+dapan_dung+"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        private void addtolistview_theo_dapandung_tinchi_mucdo(DataTable tbtv, int tinchi, int dapan_dung, int mucdo)
        {
            listView1.Items.Clear();
            DataRow[] dtr = tbtv.Select("MaTC=" + tinchi + " AND MaDA=" + dapan_dung + " AND MaMD="+mucdo+"");
            foreach (DataRow dr in dtr)
            {

                string noidung = dr["NoiDung"].ToString();
                string dapan = dr["DapAn"].ToString();
                string tendapan = dr["Ten"].ToString();
                string tenmucdo = dr["TenMD"].ToString();
                string tentinchi = dr["TenTC"].ToString();
                string macauhoi = dr["MaCH"].ToString();
                string madapan = dr["MaDA"].ToString();
                string mamucdo = dr["MaMD"].ToString();
                string matinchi = dr["MaTC"].ToString();
                addone(noidung, dapan, tendapan, tenmucdo, tentinchi, mamucdo, madapan, matinchi, macauhoi);
            }
        }
        #endregion

        private void addone(string noidung, string dapan, string dapandung, string mucdo, string tinchi, string mamd, string madad, string matc, string maq)
        {
            int max = this.listView1.Items.Count;
            this.listView1.Items.Add((max + 1).ToString());
            this.listView1.Items[max].SubItems.Add(noidung);
            this.listView1.Items[max].SubItems[1].Tag = maq;//lưu mã câu hỏi vào nội dung để khi edit còn biết là nó mã ? trong csdl
            this.listView1.Items[max].SubItems.Add(dapan);
            this.listView1.Items[max].SubItems.Add(dapandung);
            this.listView1.Items[max].SubItems[3].Tag = madad;
            this.listView1.Items[max].SubItems.Add(mucdo);
            this.listView1.Items[max].SubItems[4].Tag = mamd;
            this.listView1.Items[max].SubItems.Add(tinchi);
            this.listView1.Items[max].SubItems[5].Tag = matc;
            this.listView1.Items[max].ToolTipText = "Nội dung : " + noidung + "\nĐáp án : " + dapan + "\nMức độ : " + dapandung + "\nĐáp án đúng : " + mucdo + "\nTín chỉ : " + tinchi;
        }

        #region Zoom listview
        float maxsize = 18;
        float minsize = 10;
        int height = 4;
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (this.listView1.Font.Size < maxsize)
                zoom(this.listView1.Font.Size + height);
            check_zoom();
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (this.listView1.Font.Size > minsize)
                zoom(this.listView1.Font.Size - height);
            check_zoom();
        }
        private void zoom(float n)
        {
            this.listView1.Font = new Font("Tohoma", n);
        }
        private void check_zoom()
        {
            float cur = this.listView1.Font.Size;
            if (cur == minsize) { this.btnZoomOut.Enabled = false; }
            else if (cur == maxsize) { this.btnZoomIn.Enabled = false; }
            else if (cur > minsize && maxsize > cur) { this.btnZoomIn.Enabled = true; this.btnZoomOut.Enabled = true; }
        } 
        #endregion

       
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) this.contextMenuStrip1.Show(listView1, new Point(e.X, e.Y));
        }

        private void etsm_Edit_Click(object sender, EventArgs e)
        {
            //edit câu hỏi
            f.Hide();//giấu form tìm kiếm
            int n = this.listView1.FocusedItem.Index;
            string noidung = this.listView1.Items[n].SubItems[1].Text;
            string dapan = this.listView1.Items[n].SubItems[2].Text;
            int dapandung = int.Parse(this.listView1.Items[n].SubItems[3].Tag.ToString());
            int mucdo = int.Parse(this.listView1.Items[n].SubItems[4].Tag.ToString());
            int tinchi = int.Parse(this.listView1.Items[n].SubItems[5].Tag.ToString());
            frmThemCauHoi f2 = new frmThemCauHoi();
            f2.Text = "Edit Question | Administrator";
            //khởi tạo ủy quyền
            //f2.edit_lib = new frmThemCauHoi.edit_library(get);
            f2.set_flag(1);//cờ update
            //mã câu hỏi được lưu trong tag của cột nội dung
            f2.maq = this.listView1.Items[n].SubItems[1].Tag.ToString();//gửi mã câu hỏi sang form edit
            f2.index = n;//gửi index của item cần edit đến form edit để sau còn gửi lại 
            f2.setcontent(noidung, dapan, dapandung, mucdo, tinchi); f2.ShowDialog(this);
        }

        private void btnTaoDeThi_Click(object sender, EventArgs e)
        {
            int max = this.listView1.CheckedItems.Count;
            if (max <= 0)
            {
                MessageBox.Show("Hãy Tick vào một số câu hỏi ở trên rồi hãy bấm vào đây (^_^)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (pa != null) pa(listView1);
            }            
        }

        public void Edit()//chỉnh khi dùng với library view , thêm vào đề thi
        {
            this.btnTaoDeThi.Enabled = true;
            this.btnAdd.Visible = false;
            this.listView1.Columns[0].Width += 10;
            this.listView1.CheckBoxes = true;
            this.btnTaoDeThi.Visible = true;
            //trừ phương thức vì bình thường đã cho cộng để xử lý edit form
            this.listView1.MouseClick -= new MouseEventHandler(listView1_MouseClick);//không cho edit câu hỏi nên trừ phương thức này           
        }

        private void get3()
        {
            if (this.listView1.Items.Count <= 0) 
                addtolistview(tbtv);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            f.pa = new frmTimKiem.pass(get2);
            f.pa2 = new frmTimKiem.pass2(get3);
            f.Show();
        }

        private void get2(string noidung, int dapandung, int mucdo, int tinchi)
        {
            try
            {
                DataTable tbtv = objtv.get_ThuVien_KetHop(); 
                string chuoibosung = "";
                string chuoi_noidung = "";
                int tin_chi;
                int muc_do;
                int dap_an_dung;
                this.listView1.Items.Clear();
                if (mucdo > 0 || dapandung > 0 || tinchi > 0 || noidung != "")
                {
                    if (noidung != "" && mucdo <= 0 && dapandung <= 0 && tinchi <= 0)
                    {
                        chuoibosung = noidung;
                        MessageBox.Show(chuoibosung);
                        addtolistview_theo_noidung(tbtv, chuoibosung);
                    }
                    //muc do
                    if (mucdo > 0 && noidung == "" && tinchi <= 0 && dapandung <= 0)
                    {
                        int value_md = mucdo;
                        addtolistview_theo_mucdo(tbtv, value_md);
                    }
                    //dap an
                    if (dapandung > 0 && noidung == "" && tinchi <= 0 && mucdo <= 0)
                    {
                        int value_dapan = dapandung;
                        addtolistview_theo_dapandung(tbtv, value_dapan);
                    }
                    //linh vuc
                    if (tinchi > 0 && noidung == "" && dapandung <= 0 && mucdo <= 0)
                    {
                        int value_tc = tinchi;
                        addtolistview_theo_tinchi(tbtv, value_tc);
                    }
                    if (tinchi > 0 && noidung != "" && mucdo > 0 && dapandung > 0)
                    {
                        chuoi_noidung = noidung;
                        tin_chi = tinchi;
                        muc_do = mucdo;
                        dap_an_dung = dapandung;
                        addtolistview_noidung_tc_md_dapandung(tbtv, chuoi_noidung, muc_do, tin_chi, dap_an_dung);
                    }
                    if (mucdo > 0 && tinchi > 0 && noidung == "" && dapandung <= 0)
                    {
                        tin_chi = tinchi;
                        muc_do = mucdo;
                        addtolistview_theo_mucdo_tinchi(tbtv, tin_chi, muc_do);
                    }
                    if (mucdo > 0 && dapandung > 0 && noidung == "" && tinchi <= 0)
                    {
                        dap_an_dung = dapandung;
                        muc_do = mucdo;
                        addtolistview_theo_mucdo_dapandung(tbtv, dap_an_dung, muc_do);
                    }
                    if (noidung != "" && mucdo > 0 && tinchi <= 0 && dapandung <= 0)
                    {
                        chuoi_noidung = noidung;
                        muc_do = mucdo;
                        addtolistview_theo_noidung_mucdo(tbtv, chuoi_noidung, muc_do);
                    }
                    if (tinchi > 0 && dapandung > 0 && noidung == "" && mucdo <= 0)
                    {
                        tin_chi = tinchi;
                        dap_an_dung = dapandung;
                        addtolistview_theo_dapandung_tinchi(tbtv, tin_chi, dap_an_dung);
                    }
                    if (tinchi > 0 && mucdo > 0 && dapandung > 0 && noidung == "")
                    {
                        tin_chi = tinchi;
                        muc_do = mucdo;
                        dap_an_dung = dapandung;
                        addtolistview_theo_dapandung_tinchi_mucdo(tbtv, tin_chi, dap_an_dung, muc_do);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm (^_^)");
                }
            }
            catch (Exception loi) { MessageBox.Show(loi.StackTrace + loi.Message); };
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //insert câu hỏi
            frmThemCauHoi f = new frmThemCauHoi();
            f.set_flag(0);//cho insert vào csdl
            f.set_linhvuc_mucdo();
            //khởi tạo ủy quyền delegate
            f.edit_lib = new frmThemCauHoi.edit_library(get);
            f.ShowDialog(this);
        }

        private void get(int index, string noidung, string dapan,  string mucdo, string dapandung, string tinchi, string mamd, string madad, string matc)
        {
            this.listView1.Items[index].SubItems[1].Text = noidung;
            this.listView1.Items[index].SubItems[2].Text = dapan;
            this.listView1.Items[index].SubItems[4].Text = dapandung;
            this.listView1.Items[index].SubItems[4].Tag = madad;
            this.listView1.Items[index].SubItems[3].Text = mucdo;
            this.listView1.Items[index].SubItems[3].Tag = mamd;
            this.listView1.Items[index].SubItems[5].Text = tinchi;
            this.listView1.Items[index].SubItems[2].Tag = matc;
        }

        private void etsm_Remove_Click(object sender, EventArgs e)
        {
            //xóa câu hỏi trong CSDL
            f.Hide();//giấu form tìm kiếm
            int n = this.listView1.FocusedItem.Index;
            int maq = Convert.ToInt32(this.listView1.FocusedItem.SubItems[1].Tag.ToString());//lấy mã câu hỏi trong thư viện
            if (DialogResult.Yes == MessageBox.Show("Thao tác này sẽ xóa câu hỏi này vĩnh viễn khỏi Cơ sở dữ liệu\nBạn có chắc chắn muốn xóa câu hỏi này ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                int result = objtv.delete_question(maq);
                try
                {
                    this.listView1.Items.RemoveAt(n);
                    MessageBox.Show("Xóa câu hỏi thành công (^_^)", "Delete question", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch { MessageBox.Show("Không thể xóa được câu hỏi này\nCó lỗi trong quá trình xóa", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        #region Xử lý hiện Tooltip trên các Button chức năng
        private void btnTaoDeThi_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thêm những câu hỏi đã đươc check vào đề thi", this.btnTaoDeThi, new Point(1, -67));
        }

        private void btnTaoDeThi_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnTaoDeThi);
        }
        private void btnReconnect_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnReconnect);
        }

        private void btnReconnect_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Load lại thư viện câu hỏi từ cơ sở dữ liệu", this.btnReconnect, new Point(1, -67));
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Tìm kiếm câu hỏi trong thư viện", this.btnSearch, new Point(1, -67));
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnSearch);
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thêm câu hỏi vào thư viện", this.btnAdd, new Point(1, -67));
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnAdd);
        }

        private void btnZoomIn_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Tăng kích thước font chữ", this.btnZoomIn, new Point(1, -67));
        }

        private void btnZoomIn_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnZoomIn);
        }

        private void btnZoomOut_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Giảm kích thước font chữ", this.btnZoomOut, new Point(1, -67));
        }

        private void btnZoomOut_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnZoomOut);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thoát khỏi thư viện", this.btnCancel, new Point(1, -67));
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnCancel);
        }
        #endregion

        private void btnin_Click(object sender, EventArgs e)
        {
            report.report f = new report.report();
            f.ShowDialog();
        }


    }

}
