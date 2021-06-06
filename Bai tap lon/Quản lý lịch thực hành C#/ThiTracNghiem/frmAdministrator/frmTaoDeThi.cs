using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//using DevComponents.DotNetBar;
using BUS_Tier;
using System.IO;
using System.Data.OleDb;
namespace frmAdministrator
{
    public partial class frmTaoDeThi:Form
    {
        public frmTaoDeThi()
        {
            InitializeComponent();
        }
        System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
        frmManHinhDen fe = new frmManHinhDen();//làm đen thui màn hình 
        frmLamBai fbl = new frmLamBai();
        bMaHoavaGiaiMa m;
        bDeThi dethi = new bDeThi();
        bCauHoi cauhoi = new bCauHoi();

        DataTable tbcauhoi;
        string extension = ".Mic";
        List<TabPage> list_Tab = new List<TabPage>();
        List<ListView> list_Lisview = new List<ListView>();
        int time = 0;//thời gian cho 1 câu hỏi
        int songaunhien;//số ngẫu nhiên
        bool state = true;
        private void frmTaoDeThi_Load(object sender, EventArgs e)
        {
            this.tt.ToolTipTitle = this.Text;
            this.tt.ForeColor = Color.Lime;
            this.tt.BackColor = Color.Black;
            Create_tab();
        }
        private void Create_tab()
        {
            //create tabpage
            int max = this.tabControl1.TabCount;
            if (max < 10) //chỉ cho thao tác với 10 tab
            {
                TabPage tp = new TabPage();
                tp.Text = "Untitled " + (max + 1) + extension;
                tabControl1.Controls.Add(tp);
                list_Tab.Add(tp);
                //lisview
                ListView lv = new ListView();
                lv.FullRowSelect = true;
                lv.View = View.Details;
                lv.GridLines = true;
                lv.Dock = DockStyle.Fill;
                lv.Scrollable = true;
                lv.ForeColor = Color.Fuchsia;
                lv.MultiSelect = false;
                lv.MouseClick += new MouseEventHandler(lv_MouseClick);
                tp.Controls.Add(lv);
                list_Lisview.Add(lv);
                //ColumnHeader
                ColumnHeader no = new ColumnHeader(); no.Text = "#";
                ColumnHeader noidung = new ColumnHeader(); noidung.Text = "Nội dung"; noidung.Width = 200;
                ColumnHeader dapan = new ColumnHeader(); dapan.Text = "Đáp án"; dapan.Width = 200;
                ColumnHeader dapandung = new ColumnHeader(); dapandung.Text = "Đáp án đúng"; dapandung.Width = 100;
                ColumnHeader mucdo = new ColumnHeader(); mucdo.Text = "Mức độ"; mucdo.Width = 70;
                ColumnHeader tinchi = new ColumnHeader(); tinchi.Text = "Tín Chỉ"; tinchi.Width = 100;
                lv.Columns.Add(no);
                lv.Columns.Add(noidung);
                lv.Columns.Add(dapan);
                lv.Columns.Add(dapandung);
                lv.Columns.Add(mucdo);
                lv.Columns.Add(tinchi);
                this.tabControl1.SelectedIndex = max;
            }
            else
            {
                MessageBox.Show("Đã quá 10 tab . Hãy tắt bớt tab >.<!", "New Tab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void lv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int n = this.tabControl1.SelectedIndex;
                cms_listview.Show(list_Lisview[n], new Point(e.X, e.Y));
            }
        }

        private void addone(ListView lv, string noidung, string dapan, string dapandung, string mucdo, string linhvuc)
        {
            if (lv != null)
            {
                int n = lv.Items.Count;
                lv.Items.Add((n + 1).ToString());
                lv.Items[n].SubItems.Add(noidung);
                lv.Items[n].SubItems.Add(dapan);
                lv.Items[n].SubItems.Add(dapandung);
                lv.Items[n].SubItems.Add(mucdo);
                lv.Items[n].SubItems.Add(linhvuc);
            }
        }
        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o=new OpenFileDialog();
            o.Title = "Open subject | Administrator";
            o.Filter = "Microstar files (*.mic)|*.mic";
            o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            o.Multiselect = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                for (int j = 0; j < o.SafeFileNames.Length; j++)//gồm nhiều files
                {
                    m = new bMaHoavaGiaiMa();//mã hóa và giải mã                
                    string[] s = File.ReadAllLines(o.FileNames[j]);
                    Create_tab();
                    int n = this.tabControl1.SelectedIndex;
                    this.list_Tab[n].Text = o.SafeFileNames[j];
                    try { this.time = int.Parse(m.giaima(s[0])); }
                    catch { };
                    for (int i = 1; i < s.Length; i++)
                    {
                        s[i] = m.giaima(s[i]);//giải mã từng hàng                    
                        if (s[i] != "" && s[i].IndexOf(';') > 0)
                        {
                            try
                            {
                                string[] s2 = s[i].Split(';');//tách từng nhóm trên 1 dòng                                               
                                addone(list_Lisview[n], s2[0], s2[1] + ";" + s2[2] + ";" + s2[3] + ";" + s2[4], s2[5], s2[6], s2[7].ToString().TrimEnd());
                            }
                            catch { MessageBox.Show("File bi lỗi !"); }
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                int n = this.tabControl1.SelectedIndex;
                if (this.list_Lisview[n].Items.Count > 0)
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.Title = "Save | Administrator";
                    s.Filter = "Microstar files (*.mic)|*.mic";
                    s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    s.FileName = this.tabControl1.SelectedTab.Text;
                    if (s.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            m = new bMaHoavaGiaiMa();//mã hóa và giải mã câu hỏi                            
                            StreamWriter sw = File.CreateText(s.FileName);
                            int pos = this.tabControl1.SelectedIndex;
                            int max = this.list_Lisview[pos].Items.Count;
                            frmThoiGianChoCauHoi ft = new frmThoiGianChoCauHoi();
                            ft.pa = new frmThoiGianChoCauHoi.pass(time_set);
                            ft.settime(time);
                            ft.ShowDialog(this);
                            sw.WriteLine(m.mahoa(time.ToString()));
                            for (int i = 0; i < max; i++)
                            {

                                string temp = "";
                                temp += this.list_Lisview[pos].Items[i].SubItems[1].Text + ";";//noidung
                                temp += this.list_Lisview[pos].Items[i].SubItems[2].Text + ";";//dapan
                                temp += this.list_Lisview[pos].Items[i].SubItems[3].Text + ";";//dapandung
                                temp += this.list_Lisview[pos].Items[i].SubItems[4].Text + ";";//mucdo
                                temp += this.list_Lisview[pos].Items[i].SubItems[5].Text;//linhvuc
                                temp = m.mahoa(temp);
                                sw.WriteLine(temp);
                            }
                            sw.Close();
                        }
                        catch { MessageBox.Show("Có lỗi khi lưu file *.mic (^_^)", "Open File | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error); };
                    }
                }
                else { MessageBox.Show("Đề thi trống rỗng , không có items nào cả (^_^)", "Save | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Không có 1 Tabpage nào cả", "Save | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void time_set(int tim)
        {
            time = tim;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn đóng tệp " + this.tabControl1.SelectedTab.Text + " ?", "Close | Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    int n = this.tabControl1.SelectedIndex;
                    list_Lisview[n].Dispose();//dispose truoc
                    list_Tab[n].Dispose();
                    list_Lisview.RemoveAt(n);//remove sau
                    list_Tab.RemoveAt(n);
                    if (tabControl1.TabPages.Count > 0 && (n - 1) > 0) tabControl1.SelectedIndex = n - 1;
                }
            }
            else { MessageBox.Show("Không có 1 Tabpage nào cả", "Close | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                if (this.list_Lisview[this.tabControl1.SelectedIndex].Items.Count > 0)
                {
                    fe.Show();
                    frmLamBai ft = new frmLamBai();
                    ft.pa = new frmLamBai.pass(get);
                    ft.import(this.list_Lisview[this.tabControl1.SelectedIndex], 15);//mặc định cho 15 giây
                    ft.ShowDialog(fe);
                }
                else MessageBox.Show("Đề trống rỗng mà (^_^) ?", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Bó tay lun . Không có 1 Tabpage nào cả (^_^)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void get()
        {
            fe.Hide();
        }
        public void import(ListView lv, int time)
        {
            try
            {
                ThemTuListView(lv, time);//thêm từ 1 file câu hỏi vào đề thi
                dethi.count = dethi.TongSo();
                fbl.lbCount.Text = "Tổng số câu hỏi  : " + dethi.count;
                fbl.set(); this.time = dethi.count * dethi.time;
            }
            catch { MessageBox.Show("Lỗi khi nhập đề thi từ listview !"); };
        }
    


        //fasfsafaf
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                frmThemCauHoi f = new frmThemCauHoi();
                f.set_flag(3);// tạo cờ =3 cho form question 
                f.set_linhvuc_mucdo();//load item vào các combobox
                //tạo ủy quyền
                f.pa = new frmThemCauHoi.pass(set_question);
                f.ShowDialog(this);
            }
            else MessageBox.Show("Không có 1 Tabpage nào cả", "Add | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void set_question(frmThemCauHoi fa)
        {
            addone(this.list_Lisview[this.tabControl1.SelectedIndex], fa.richTextBox1.Text, fa.tbA.Text + ";" + fa.tbB.Text + ";" + fa.tbC.Text + ";" + fa.tbD.Text , fa.cboMucDo.Text, fa.Dapandung(1), fa.cboTinChi.Text);
            fa.reset();//xóa các nội dung đã nhập vào form
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                try
                {
                    this.btnImport.Enabled = false;
                    int n = this.tabControl1.SelectedIndex;
                    int count = 0;
                    string noidung = "", dapan = "", mucdo = "", dapandung = "", tinchi = "";
                    // đếm tổng số record  trong bảng Thư Viện
                    count = cauhoi.Count_ReCord();
                    //tạo số ngẫu nhiên không trùng nhau
                    List<int>listngaunhien = new List<int>();
                    Random random = new Random();
                    
                    do
                    {
                        songaunhien = random.Next(1, count);
                        if (listngaunhien.Count < count)
                        {
                            if (!listngaunhien.Contains(songaunhien))
                            {
                                listngaunhien.Add(songaunhien);
                                state = false;
                            }
                            else
                            {
                                songaunhien = random.Next(1, count);
                            }
                        }
                    } while (state==true);
                    tbcauhoi = cauhoi.get_Table_CauHoi_NgauNhien(songaunhien);
                    noidung = tbcauhoi.Rows[0]["NoiDung"].ToString();
                    dapan = tbcauhoi.Rows[0]["DapAn"].ToString();
                    dapandung = tbcauhoi.Rows[0]["Ten"].ToString();
                    mucdo = tbcauhoi.Rows[0]["TenMD"].ToString();
                    tinchi = tbcauhoi.Rows[0]["TenTC"].ToString();
                    //thêm vào listview
                    addone(list_Lisview[n], noidung, dapan,dapandung, mucdo,tinchi);
                    this.btnImport.Enabled = true;
                }
                catch { MessageBox.Show("Có lỗi kết nối CSDL (^_^)"); this.btnImport.Enabled = true; }
            }
            else { MessageBox.Show("Không có 1 Tabpage nào cả", "Import | Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error); };            
        }

        private void btnLuaTay_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabCount > 0)
            {
                frmThuVien frmedit = new frmThuVien();//lựa câu hỏi bằng tay thì xài form này                      
                frmedit.Edit();
                frmedit.pa += new frmThuVien.pass(getItems);//delegate : nhận listview từ form thư viện
                frmedit.ShowDialog(this);
            }
            else MessageBox.Show("Bó tay lun . Không có 1 Tabpage nào cả (^_^)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //truyền cả listview về cho nó máu (^_^) ha ha ha
        private void getItems(ListView lv)
        {
            int n = lv.CheckedItems.Count;
            int pos = this.tabControl1.SelectedIndex;
            for (int i = 0; i < n; i++)
            {
                addone(this.list_Lisview[pos], lv.CheckedItems[i].SubItems[1].Text, lv.CheckedItems[i].SubItems[2].Text, lv.CheckedItems[i].SubItems[3].Text, lv.CheckedItems[i].SubItems[4].Text, lv.CheckedItems[i].SubItems[5].Text);
            } uncheck(lv);//sau khi gửi câu hỏi về thì uncheck tất cả các câu vừa check
            MessageBox.Show("Thêm thành công (^_^)!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void uncheck(ListView lv)
        {
            int n = lv.CheckedItems.Count;
            while (n > 0)
            {
                lv.CheckedItems[0].Checked = false;
                n = lv.CheckedItems.Count;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Create_tab();
        }

        private void tsm_edit_Click(object sender, EventArgs e)
        {

            //chỉnh sửa câu hỏi của đề hiện tại
            int n = this.tabControl1.SelectedIndex;
            ListViewItem lvi = this.list_Lisview[n].FocusedItem;
            frmThemCauHoi fa = new frmThemCauHoi();
            fa.set_flag(4);//cờ edit câu hỏi cho bộ đề thi (ko phải cho thư viện)
            fa.set_linhvuc_mucdo();//load các item đến các combo
            fa.pa += new frmThemCauHoi.pass(delegate_edit); //khởi tạo delegate            
            //add nội dung tới form edit
            fa.richTextBox1.Text = lvi.SubItems[1].Text;
            string[] s = lvi.SubItems[2].Text.Split(';');
            fa.tbA.Text = s[0];
            fa.tbB.Text = s[1];
            fa.tbC.Text = s[2];
            fa.tbD.Text = s[3];
            //
            fa.setInfo(lvi.SubItems[3].Text, lvi.SubItems[4].Text, lvi.SubItems[5].Text);
            fa.ShowDialog(this);
        }
        private void delegate_edit(frmThemCauHoi fa)
        {
            //delegate
            ListViewItem lvi = this.list_Lisview[this.tabControl1.SelectedIndex].FocusedItem;
            lvi.SubItems[1].Text = fa.richTextBox1.Text;
            lvi.SubItems[2].Text = fa.tbA.Text + ";" + fa.tbB.Text + ";" + fa.tbC.Text + ";" + fa.tbD.Text;
            lvi.SubItems[3].Text = fa.Dapandung(1);
            lvi.SubItems[4].Text = fa.cboMucDo.Text;
            lvi.SubItems[5].Text = fa.cboTinChi.Text;
            fa.Close();
        }

        //Thực hiện xóa câu hỏi trên listview không xóa dưới csdl
        private void tsm_remove_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa câu hỏi này khỏi đề thi này ?", "Remove | Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                int lis = this.tabControl1.SelectedIndex;
                this.list_Lisview[lis].FocusedItem.Remove();
            }
        }

        private void tsm_removeAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa tất cả câu hỏi trong đề thi này ?", "Remove All | Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                int n = this.tabControl1.SelectedIndex;
                this.list_Lisview[n].Items.Clear();
            }
        }

        #region Xử lý hiện tooltip trên các Button
        private void btnOpen_MouseHover_1(object sender, EventArgs e)
        {
            this.tt.Show("Mở tập tin chứa bộ đề có sẵn trong ỗ đĩa", this.btnOpen, new Point(1, -67));
        }

        private void btnOpen_MouseLeave_1(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnOpen);
        }
        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Tạo một đề thi mới", this.btnNew, new Point(1, -67));
        }

        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnNew);
        }

        private void btnOpen_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Mở một tệp đề thi định dạng *.mic", this.btnOpen, new Point(1, -67));
        }

        private void btnOpen_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnOpen);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Lưu đề thi hiện tại đang được chọn ra tệp *.mic", this.btnSave, new Point(1, -67));
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {

            this.tt.Hide(this.btnSave);

        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Đóng đề thi hiện tại đang được chọn", this.btnClose, new Point(1, -67));
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnClose);
        }

        private void btnTest_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Test đề thi hiện tại đang được chọn", this.btnTest, new Point(1, -67));
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnTest);
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Thêm mới câu hỏi vào đề thi hiện tại đang được chọn", this.btnAdd, new Point(1, -67));
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnAdd);
        }

        private void btnImport_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Import ngẫu nhiên 1 câu hỏi từ thư viện vào đề thi hiện tại đang được chọn", this.btnImport, new Point(1, -67));
        }

        private void btnImport_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnImport);
        }

        private void btnLuaTay_MouseHover(object sender, EventArgs e)
        {
            this.tt.Show("Lựa câu hỏi từ thư viện và import chúng vào đề thi hiện tại đang được chọn", this.btnLuaTay, new Point(1, -67));
        }

        private void btnLuaTay_MouseLeave(object sender, EventArgs e)
        {
            this.tt.Hide(this.btnLuaTay);
        }
        #endregion

        private void btnin_Click(object sender, EventArgs e)
        {
            report.report f = new report.report();
            f.ShowDialog();
        }

        private void cms_listview_Opening(object sender, CancelEventArgs e)
        {

        }
       
    }

}
