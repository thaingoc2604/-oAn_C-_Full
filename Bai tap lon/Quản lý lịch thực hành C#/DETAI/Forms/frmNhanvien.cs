using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DETAI
{
    public partial class frmNhanvien : Form
    {   
        //Khai báo biến toàn cục
        clsDMTo cTo = new clsDMTo();
        clsdmpb cPhong = new clsdmpb();
        clsnhanvien cnhanvien = new clsnhanvien();
        clsDMDanToc cDanToc = new clsDMDanToc();
        clsdmchucvu cchucvu = new clsdmchucvu();
        clsdmtongiao ctongiao = new clsdmtongiao();
        clschitietchuyenmon cchuyenmon = new clschitietchuyenmon();
        clschitietngoaingu cngoaingu = new clschitietngoaingu();
        clsdmchuyenmon cdmcm = new clsdmchuyenmon();
        clsdmngoaingu cdmnn = new clsdmngoaingu();
        clsdmhd cloaihd = new clsdmhd();
        clsdmtrinhdo cdmtd = new clsdmtrinhdo();
        clschitiethopdong ccthopdong = new clschitiethopdong();
        clsdmhd cdmhd = new clsdmhd();
        clshosoluong chsluong = new clshosoluong();
        static public string bienmanv;
        string filename = "";//ten file hinh anh
        int ksy = 0;//khoi tao gia tri de biet trang thai luu hoac them
        int khd = 0;//khoi tao gia tri de biet trang thai luu hoac them
        int kluong = 0; //khoi tao gia tri de biet trang thai luu hoac them cua tab ho so luong
        public frmNhanvien()
        {
            InitializeComponent();
            //đưa dữ liệu vào cbophong
            cboPhong.DataSource = cPhong.taocombo();
            cboPhong.DisplayMember = "tbl_PhongBan.TenPhong";
            cboPhong.ValueMember = "tbl_PhongBan.MaPhong";          
        }

        //làm rổng các control trong các group
        private void lamrong()
        {
            foreach (Control c in grpsoyeu1.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                {
                    c.Text = "";
                }
            foreach (Control c in grpsoyeu2.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                        c.Text = "";
            foreach (Control c in grpTTTD.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
            foreach (Control c in grphsl.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                    c.Text = "";
            foreach (Control c in grphopdong.Controls)
                if (c.Name.Contains("txt") == true || c.Name.Contains("cbo") == true)
                     c.Text = "";
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            cbosytinhtrang.Items.AddRange(new string[] { "Độc Thân", "Có Gia Đình", "Đã Kết Hôn" });
            setcontrolsy(false);
            setcontrolhd(false);
            setcontrolhsl(false);
            txthslngayll.Enabled =false ;
            ksy = 0; khd = 0; kluong = 0;
            setcmd(true);
            setcmdhd(true);
            setcmdhsl(true);
            bienmanv = "";
        }

        //
        //List Nhân Viên
        //
        //Hiển thị thông tin nhân viên vào list nhân viên
        private void HienThiListNV(DataTable dt, ListView lv)
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MaNV"].ToString();
                item.SubItems.Add(row["Ho"].ToString());
                item.SubItems.Add(row["Ten"].ToString());
                lv.Items.Add(item);
            }
        }
            
        private void lstNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = lstNhanvien.FocusedItem.SubItems[0].Text;
            string ho = lstNhanvien.FocusedItem.SubItems[1].Text;
            string ten = lstNhanvien.FocusedItem.SubItems[2].Text;
            bienmanv = ma;
            //trang so yeu ly lich
            HienthiTTNhanVien(ma);
            //trang trình độ
            txtknmanv.Text = ma;
            txtknhotennv.Text = ho + " " + ten;
            HienThiDLKN(ma);
            //trang hợp đồng
            txthdmanv.Text = ma;
            txthdhotennv.Text = ho + " " + ten;
            HienThiTTHopDong(ma);
            // trang hồ sơ lương
            txthslmanv.Text = ma;
            txthslhotennv.Text = ho + " " + ten;
            HienThiTTHoSoLuong(ma);

        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTo.DataSource = cTo.taocombo(cboPhong.SelectedValue.ToString());
            cboTo.DisplayMember = "DanhMucTo.TenTo";
            cboTo.ValueMember = "DanhMucTo.MaTo";
            cboTo.Text = "";
            lstNhanvien.Items.Clear();
            HienThiListNV(cPhong.laydlList(cboPhong.SelectedValue.ToString()), lstNhanvien);
            lamrong();
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lamrong();
            lstNhanvien.Items.Clear();
            HienThiListNV(cTo.laydlList(cboPhong.SelectedValue.ToString(), cboTo.SelectedValue.ToString()), lstNhanvien);
           
        }

        private void setlist(bool b)
        {
            lstNhanvien.Enabled = b;
            cboPhong.Enabled = b;
            cboTo.Enabled = b;
        }

        //
        //tab sơ yếu lý lịch
        //
        //setcontrol so yeu ly lich
        private  void setcontrolsy(bool b)
        {
            foreach (Control c in grpsoyeu1.Controls )
            {
                if (c.Name.Contains("txtsy")==true ||c.Name.Contains("cbosy")==true)
                    c.Enabled = b;
            }
            foreach (Control c in grpsoyeu2.Controls)
            {
                if (c.Name.Contains("txtsy") == true || c.Name.Contains("cbosy") == true)
                    c.Enabled = b;
            }
              
        }

        //phương thức làm mờ bộ nút của tabsoyeu
        private  void setcmd(bool b)
        {
            btnbrowser.Enabled = !b;
            cmdthem.Enabled = b;
            cmdCapnhat.Enabled= b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
            btnInNhanvien.Enabled = b;
        }

        //đưa trạng thái textbox về rỗng tabsoyeu
        private  void settextboxrong()
        {
            foreach (Control c in grpsoyeu1.Controls )
            {
                if (c.Name.Contains("txtsy") == true)
                    c.Text = "";
            }
            foreach (Control c in grpsoyeu2.Controls)
            {
                if (c.Name.Contains("txtsy") == true)
                    c.Text = "";
            }
        }

        //khởi tạo dữ liệu cho các combobox cho tabsoyeu
        private  void taocombosy()
        {
            //đưa dữ liệu vào cbosyphong
            cbosyphong.DataSource = cPhong.taocombo();
            cbosyphong.DisplayMember = "tbl_PhongBan.TenPhong";
            cbosyphong.ValueMember = "tbl_PhongBan.MaPhong";
            if(txtsymanv.Text!="")
            cbosyphong.SelectedValue = laydulieutheoma(txtsymanv.Text.Trim(), "MaPhong");
            //đưa dữ liệu vào cbosydantoc
            cbosydantoc.DataSource = cDanToc.taocombo();
            cbosydantoc.DisplayMember = "DMDanToc.TenDT";
            cbosydantoc.ValueMember = "DMDanToc.MaDT";
            if (txtsymanv.Text != "")
            cbosydantoc.SelectedValue = int.Parse(laydulieutheoma(txtsymanv.Text.Trim(), "MaDT"));
            //đưa dữ liệu vào cbosychucvu
            cbosychucvu.DataSource = cchucvu.taocombo();
            cbosychucvu.DisplayMember = "DMChucVu.TenChucVu";
            cbosychucvu.ValueMember = "DMChucVu.MaChucVu";
            if (txtsymanv.Text != "")
            cbosychucvu.SelectedValue = int.Parse(laydulieutheoma(txtsymanv.Text.Trim(), "MaChucVu"));
            //đưa dữ liệu vào cbosytongiao
            cbosytongiao.DataSource = ctongiao.taocombo();
            cbosytongiao.DisplayMember = "DMTonGiao.TenTG";
            cbosytongiao.ValueMember = "DMTonGiao.MaTG";
            if (txtsymanv.Text != "")
            cbosytongiao.SelectedValue = int.Parse(laydulieutheoma(txtsymanv.Text.Trim(), "MaTG"));
        }
        
        //hiển thị dữ liệu nhân viên vào trang sơ yếu lý lịch
        private  void HienthiTTNhanVien(string ma)
        {
            cnhanvien.laydl(ma);
            //
            //lấy dữ liệu vào các textbox
            //
            try
            {
                txtsymanv.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["MaNV"].ToString();
                txtsyhonv.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["Ho"].ToString();
                txtsytennv.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["Ten"].ToString();
                txtsyngaysinh.Text = mysql.NgayToString(cnhanvien.ds.Tables["nhanvien"].Rows[0]["Ngaysinh"].ToString());
                txtsynoisinh.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["Noisinh"].ToString();
                txtsysocmnd.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["SoCMND"].ToString();
                txtsyhokhau.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["HokhauTT"].ToString();
                txtsychohientai.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["ChoOHienTai"].ToString();
                txtsydienthoai.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["DienThoai"].ToString();
                txtsydtdd.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["DTDD"].ToString();
                txtsysoBHXH.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["SoBHXH"].ToString();
                txtsysoBHYT.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["SoBHYT"].ToString();
                txtsysotheATM.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["SotheATM"].ToString();
                txtsyngayvl.Text = mysql.NgayToString(cnhanvien.ds.Tables["nhanvien"].Rows[0]["Ngayvaolam"].ToString());
                txtsyghichu.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["GhiChu"].ToString();
                //
                //lấy dữ liệu vào các combobox
                //khác với phương thức taocombo ở trên vì đây là đi theo mỗi nhân viên
                cbosydantoc.DataSource = cnhanvien.ds;
                cbosydantoc.ValueMember = "nhanvien.madt";
                cbosydantoc.DisplayMember = "nhanvien.tendt";
                cbosytongiao.DataSource = cnhanvien.ds;
                cbosytongiao.ValueMember = "nhanvien.MaTG";
                cbosytongiao.DisplayMember = "nhanvien.TenTG";
                cbosytinhtrang.Text = cnhanvien.ds.Tables["nhanvien"].Rows[0]["Tinhtranghonnhan"].ToString();
                cbosyphong.DataSource = cnhanvien.ds;
                cbosyphong.ValueMember = "nhanvien.MaPhong";
                cbosyphong.DisplayMember = "nhanvien.tenphong";
                cbosyto.DataSource = cnhanvien.ds;
                cbosyto.ValueMember = "nhanvien.Mato";
                cbosyto.DisplayMember = "nhanvien.TenTo";
                cbosychucvu.DataSource = cnhanvien.ds;
                cbosychucvu.ValueMember = "nhanvien.MaChucVu";
                cbosychucvu.DisplayMember = "NhanVien.TenChucVu";
                //
                //lấy dữ liệu vào optgioitinh
                //
                if (cnhanvien.ds.Tables["nhanvien"].Rows[0]["GioiTinh"].ToString() == "1")
                    optNam.Checked = true;
                else
                    optNu.Checked = true;
                //hien thi hinh anh

                filename = cnhanvien.ds.Tables["nhanvien"].Rows[0]["hinhanh"].ToString();
                if (filename != "")
                    picHinh.Image = new Bitmap(Application.StartupPath + @"\Hinh\" + filename);
                else
                {
                    filename = "";
                    picHinh.Image = null;
                }
            }
            catch { }
        }

        //lấy dữ liệu cho các combobox trong tabsoyeu theo mã nhân viên
        private  string laydulieutheoma(string ma,string macombo)
        {
            cnhanvien.sc.Open();
            string sql = "select " + macombo + " from Tbl_nhanvien where MaNV='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, cnhanvien.sc);
            object o = cmd.ExecuteScalar();
            cnhanvien.sc.Close();
            return o.ToString();    
        }

        //lấy mã nhân viên tự động
        private string laymatudong(string s)
        {
            string kq = "";
            int so = int.Parse(s.Substring(2));
            if (so + 1 <= 999)
                kq = "NV" + (so + 1);
            if (so + 1 < 100)
                kq = "NV0" + (so + 1);
            if (so + 1 < 10)
                kq = "NV00" + (so + 1);
            return kq;
        }   

        //bộ nút của tab sơ yếu lý lịch

        private void cmdluu_Click(object sender, EventArgs e)
        {   
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                if (ksy == 1)
                {
                    if (cbosyto.SelectedItem != null)
                        //them nhan vien neu nhu phong do co to
                        cnhanvien.ThemNV(txtsymanv.Text.Trim(),
                                 txtsyhonv.Text.Trim(),
                                 txtsytennv.Text.Trim(),
                                 optNam.Checked ? '1' : '0',
                                 txtsysocmnd.Text.Trim(),
                                 txtsyngaysinh.Text.Trim() == "" ? DateTime.Today : mysql.TraVeNgay(txtsyngaysinh.Text.Trim(), 1),
                                 txtsynoisinh.Text.Trim(),
                                 int.Parse(cbosytongiao.SelectedValue.ToString()),
                                 int.Parse(cbosydantoc.SelectedValue.ToString()),
                                 txtsydienthoai.Text.Trim(),
                                 txtsydtdd.Text.Trim(),
                                 txtsyhokhau.Text.Trim(),
                                 txtsychohientai.Text.Trim(),
                                 cbosytinhtrang.Text.Trim(),
                                 filename.ToString(),
                                 int.Parse(cbosychucvu.SelectedValue.ToString()),
                                 cbosyphong.SelectedValue.ToString(),
                                 cbosyto.SelectedValue.ToString(),
                                 txtsyngayvl.Text.Trim() == "" ? DateTime.Today : mysql.TraVeNgay(txtsyngayvl.Text.Trim(), 1),
                                 txtsysoBHYT.Text.Trim(), txtsysoBHXH.Text.Trim(),
                                 txtsysotheATM.Text.Trim(), txtsyghichu.Text.Trim());
                    else
                        //them nhan vien neu nhu phong do khong co to
                        cnhanvien.ThemNV(txtsymanv.Text.Trim(),
                                 txtsyhonv.Text.Trim(),
                                 txtsytennv.Text.Trim(),
                                 optNam.Checked ? '1' : '0',
                                 txtsysocmnd.Text.Trim(),
                                 txtsyngaysinh.Text.Trim() == "" ? DateTime.Today :mysql.TraVeNgay(txtsyngaysinh.Text.Trim(), 1),
                                 txtsynoisinh.Text.Trim(),
                                 int.Parse(cbosytongiao.SelectedValue.ToString()),
                                 int.Parse(cbosydantoc.SelectedValue.ToString()),
                                 txtsydienthoai.Text.Trim(),
                                 txtsydtdd.Text.Trim(),
                                 txtsyhokhau.Text.Trim(),
                                 txtsychohientai.Text.Trim(),
                                 cbosytinhtrang.Text.Trim(),
                                 filename.ToString(),
                                 int.Parse(cbosychucvu.SelectedValue.ToString()),
                                 cbosyphong.SelectedValue.ToString(),
                                 txtsyngayvl.Text.Trim() == "" ? DateTime.Today : mysql.TraVeNgay(txtsyngayvl.Text.Trim(), 1),
                                 txtsysoBHYT.Text.Trim(), txtsysoBHXH.Text.Trim(),
                                 txtsysotheATM.Text.Trim(), txtsyghichu.Text.Trim());
                }
                else if (ksy == 2)
                {                    
                    if (cbosyto.SelectedItem != null)
                        if (cbosyto.Text != "")
                            //sua nhan vien neu nhu nhan vien do co to
                            cnhanvien.SuaNV(txtsymanv.Text.Trim(),
                                    txtsyhonv.Text.Trim(),
                                    txtsytennv.Text.Trim(),
                                    optNam.Checked ? '1' : '0',
                                    txtsysocmnd.Text.Trim(),
                                    mysql.TraVeNgay(txtsyngaysinh.Text.Trim(), 1),
                                    txtsynoisinh.Text.Trim(),
                                    int.Parse(cbosytongiao.SelectedValue.ToString()),
                                    int.Parse(cbosydantoc.SelectedValue.ToString()),
                                    txtsydienthoai.Text.Trim(),
                                    txtsydtdd.Text.Trim(),
                                    txtsyhokhau.Text.Trim(),
                                    txtsychohientai.Text.Trim(),
                                    cbosytinhtrang.Text.Trim(),
                                    filename.ToString(),
                                    int.Parse(cbosychucvu.SelectedValue.ToString()),
                                    cbosyphong.SelectedValue.ToString(),
                                    cbosyto.SelectedValue.ToString(),
                                    mysql.TraVeNgay(txtsyngayvl.Text.Trim(), 1),
                                    txtsysoBHYT.Text.Trim(), txtsysoBHXH.Text.Trim(),
                                    txtsysotheATM.Text.Trim(), txtsyghichu.Text.Trim());
                        else 
                        {
                            //sua nhan vien neu nhu nhan vien do khong co ma to
                            cnhanvien.SuaNV(txtsymanv.Text.Trim(),
                                    txtsyhonv.Text.Trim(),
                                    txtsytennv.Text.Trim(),
                                    optNam.Checked ? '1' : '0',
                                    txtsysocmnd.Text.Trim(),
                                    mysql.TraVeNgay(txtsyngaysinh.Text.Trim(), 1),
                                    txtsynoisinh.Text.Trim(),
                                    int.Parse(cbosytongiao.SelectedValue.ToString()),
                                    int.Parse(cbosydantoc.SelectedValue.ToString()),
                                    txtsydienthoai.Text.Trim(),
                                    txtsydtdd.Text.Trim(),
                                    txtsyhokhau.Text.Trim(),
                                    txtsychohientai.Text.Trim(),
                                    cbosytinhtrang.Text.Trim(),
                                    filename.ToString(),
                                    int.Parse(cbosychucvu.SelectedValue.ToString()),
                                    cbosyphong.SelectedValue.ToString(),
                                    mysql.TraVeNgay(txtsyngayvl.Text.Trim(), 1),
                                    txtsysoBHYT.Text.Trim(), txtsysoBHXH.Text.Trim(),
                                    txtsysotheATM.Text.Trim(), txtsyghichu.Text.Trim());
                            cnhanvien.sc.Open();
                            string ins_mato = "update tbl_nhanvien set mato =null where MaNV='" + txtsymanv.Text.Trim() + "'";
                            SqlCommand cmd_ins = new SqlCommand(ins_mato, cnhanvien.sc);
                            try
                            {
                                cmd_ins.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Errors + " " + ex.Number);
                            }
                            cnhanvien.sc.Close();
                        }
                    else
                    { //sua nhan vien neu nhu nhan vien do khong co ma to
                        cnhanvien.SuaNV(txtsymanv.Text.Trim(),
                                txtsyhonv.Text.Trim(),
                                txtsytennv.Text.Trim(),
                                optNam.Checked ? '1' : '0',
                                txtsysocmnd.Text.Trim(),
                                mysql.TraVeNgay(txtsyngaysinh.Text.Trim(), 1),
                                txtsynoisinh.Text.Trim(),
                                int.Parse(cbosytongiao.SelectedValue.ToString()),
                                int.Parse(cbosydantoc.SelectedValue.ToString()),
                                txtsydienthoai.Text.Trim(),
                                txtsydtdd.Text.Trim(),
                                txtsyhokhau.Text.Trim(),
                                txtsychohientai.Text.Trim(),
                                cbosytinhtrang.Text.Trim(),
                                filename.ToString(),
                                int.Parse(cbosychucvu.SelectedValue.ToString()),
                                cbosyphong.SelectedValue.ToString(),
                                mysql.TraVeNgay(txtsyngayvl.Text.Trim(), 1),
                                txtsysoBHYT.Text.Trim(), txtsysoBHXH.Text.Trim(),
                                txtsysotheATM.Text.Trim(), txtsyghichu.Text.Trim());
                        cnhanvien.sc.Open();
                        string ins_mato = "update tbl_nhanvien set mato =null where MaNV='" + txtsymanv.Text.Trim() + "'";
                        SqlCommand cmd_ins = new SqlCommand(ins_mato, cnhanvien.sc);
                        try
                        {
                            cmd_ins.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Errors + " " + ex.Number);
                        }
                        cnhanvien.sc.Close();
                    }
                }
            }
            else
            {
                HienthiTTNhanVien(bienmanv);
            }
            ksy = 0;
            setcontrolsy(false);
            setlist(true);
            setcmd(true);
            lstNhanvien.Items.Clear();
            HienThiListNV(cPhong.laydlList(cboPhong.SelectedValue.ToString()), lstNhanvien);
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            settextboxrong();
            setcontrolsy(true);
            setlist(false);
            taocombosy();
            txtsyhonv.Focus();
            setcmd(false);
            ksy = 1;
            filename = "no_image2.jpg";
            if (filename != "")
                picHinh.Image = new Bitmap(Application.StartupPath + @"\Hinh\" + filename);
            else
            {
                filename = "";
                picHinh.Image = null;
            }
            if (int.Parse(laymatudong(cnhanvien.laynvcuoi()).Substring(2)) > 999)
            {
                MessageBox.Show("Chương trình chỉ được nhận dưới 1000 nhân viên", "Thông báo");
            }
            else txtsymanv.Text = laymatudong(cnhanvien.laynvcuoi());
        }

        private void txtsymanv_Validated(object sender, EventArgs e)
        {
            txtsymanv.Text = txtsymanv.Text.Trim().ToUpper();
        }

        private void cbosyphong_Leave(object sender, EventArgs e)
        {
            cbosyto.DataSource = cTo.taocombo(cbosyphong.SelectedValue.ToString());
            cbosyto.DisplayMember = "DanhMucTo.TenTo";
            cbosyto.ValueMember = "DanhMucTo.MaTo";
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa mẩu tin này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                cnhanvien.XoaNV(txtsymanv.Text.Trim());
            lstNhanvien.Items.Clear();
            HienThiListNV(cPhong.laydlList(cboPhong.SelectedValue.ToString()), lstNhanvien);
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (txtsymanv.Text == "")
                MessageBox.Show("Bạn phải chọn nhân viên cập nhật", "Thông Báo");
            else
            {
                ksy = 2;
                setcontrolsy(true);
                setlist(false);
                taocombosy();
                txtsyhonv.Focus();
                setcmd(false);               
            }
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath + @"\hinh";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.FileName.Substring(dlg.FileName.LastIndexOf("\\") + 1, dlg.FileName.Length - dlg.FileName.LastIndexOf("\\") - 1);
                try
                {
                    picHinh.Image = new Bitmap(Application.StartupPath + @"\hinh\" + filename);
                }
                catch
                {
                    MessageBox.Show(this, "Hình chọn không đúng", "Information");
                }
            }
        }

        //kiểm tra việc nhập ngày sinh
        private void txtsyngaysinh_Validated(object sender, EventArgs e)
        {
            string s = txtsyngaysinh.Text.Trim();
            if (s != "")
            {
                if (!mysql.KiemTraNgay(s))
                {
                    MessageBox.Show("Bạn nhập ngày sai", "Thông báo");
                    txtsyngaysinh.Text = "";
                    txtsyngaysinh.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập ngày", "Thông báo");
                txtsyngaysinh.Text = "";
                txtsyngaysinh.Focus();
            }
        }

        //kiểm tra việc nhập ngày vào làm
        private void txtsyngayvl_Validated(object sender, EventArgs e)
        {
            string s = txtsyngayvl.Text.Trim();
            if (s != "")
            {
                if (!mysql.KiemTraNgay(s))
                {
                    MessageBox.Show("Bạn nhập ngày sai", "Thông báo");
                    txtsyngayvl.Text = "";
                    txtsyngayvl.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập ngày", "Thông báo");
                txtsyngayvl.Text = "";
                txtsyngayvl.Focus();
            }
        }
        //
        //tab Trình độ
        //

        //Hiển thị dữ liệu vào trang kinh nghiệm
        private  void HienThiDLKN(string ma)
        {
            cngoaingu.CapNhatNN(ma);
            cchuyenmon.CapNhatCM(ma);
            dgv_ChitietCM.DataSource = cchuyenmon.ds;
            dgv_ChitietCM.DataMember = "NV_ChuyenMon1";
            dgv_ChitietNN.DataSource = cngoaingu.ds;
            dgv_ChitietNN.DataMember = "NV_NgoaiNgu1";
            //tạo combo ngoại ngữ trong dgv_ChiTietNN
            DataGridViewComboBoxColumn grdCCNN = new DataGridViewComboBoxColumn();
            grdCCNN.HeaderText = "Tên ngoại ngữ";
            grdCCNN.Name = "cbongoaingu";
            grdCCNN.Width = 140;
            grdCCNN.FlatStyle = FlatStyle.Popup;
            grdCCNN.DataPropertyName = "mangoaingu";
            grdCCNN.DataSource = cdmnn.taocombonn();
            grdCCNN.DisplayMember = "tenngoaingu";
            grdCCNN.ValueMember = "mangoaingu";
            if(dgv_ChitietNN.Columns[2].Name!="cbongoaingu")
                dgv_ChitietNN.Columns.Insert(2, grdCCNN);
            //Tạo combo chuyên môn trong dgv_ChiTietChuyenMon
            DataGridViewComboBoxColumn grdCCCM = new DataGridViewComboBoxColumn();
            grdCCCM.HeaderText = "Tên Chuyên Môn";
            grdCCCM.Name = "cbochuyenmon";
            grdCCCM.Width = 150;
            grdCCCM.FlatStyle = FlatStyle.Popup;
            grdCCCM.DataPropertyName = "machuyenmon";
            grdCCCM.DataSource = cdmcm.taocombocm();
            grdCCCM.DisplayMember = "tenchuyenmon";
            grdCCCM.ValueMember = "machuyenmon";
            if (dgv_ChitietCM.Columns[2].Name != "cbochuyenmon")
                dgv_ChitietCM.Columns.Insert(2, grdCCCM);
            //Tạo combo trình độ trong dgv_ChiTietChuyenMon
            DataGridViewComboBoxColumn grdCCTD = new DataGridViewComboBoxColumn();
            grdCCTD.HeaderText = " Tên Trình Độ";
            grdCCTD.Name = "cbotrinhdo";
            grdCCTD.Width = 140;
            grdCCTD.FlatStyle = FlatStyle.Popup;
            grdCCTD.DataPropertyName = "matrinhdo";
            grdCCTD.DataSource = cdmtd.taocombotd();
            grdCCTD.DisplayMember = "tentrinhdo";
            grdCCTD.ValueMember = "matrinhdo";
            if (dgv_ChitietCM.Columns[3].Name != "cbotrinhdo")
                dgv_ChitietCM.Columns.Insert(3, grdCCTD);          
        }
    
        private void cmdcapnhatnn_Click(object sender, EventArgs e)
        {
            cngoaingu.sc.Open();
            try
            {
                cngoaingu.sda.Update(cngoaingu.ds, "NV_ngoaingu1");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("ID này đang tồn tại", "Thông Báo");
                else
                    MessageBox.Show("Không Thực Hiện Được", "Thông Báo");
            }
            cngoaingu.sc.Close();
        }

        private void cmdcapnhatbc_Click(object sender, EventArgs e)
        {
            cchuyenmon.sc.Open();
            try
            {
                cchuyenmon.sda.Update(cchuyenmon.ds, "NV_ChuyenMon1");
            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("ID này đang tồn tại", "Thông Báo");
                else
                    MessageBox.Show("Không Thực Hiện Được", "Thông Báo");
            }
            cchuyenmon.sc.Close();
        }

        private void dgv_ChitietNN_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e != null) MessageBox.Show("  Bạn đã nhập sai kiểu dữ liệu \n Xem hướng đẫn phần tên cột", "Thông báo");
        }

        private void dgv_ChitietCM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e != null) MessageBox.Show("  Bạn đã nhập sai kiểu dữ liệu \n Xem hướng đẫn phần tên cột", "Thông báo");
        }
        //
        //tab Hợp đồng
        //

        //setcontrol tab hợp đồng 
        private  void setcontrolhd(bool b)
        {
            foreach (Control c in grphopdong.Controls)
            {
                if (c.Name.Contains("txthd") == true || c.Name.Contains("cbohd") == true)
                    c.Enabled = b;
            }
        }

        private string layloaihdtheoma(string ma)
        {
            cnhanvien.sc.Open();
            string sql = "select maloaihd  from Tbl_chitiethopdong where SoHD='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, cnhanvien.sc);
            object o = cmd.ExecuteScalar();
            cnhanvien.sc.Close();
            return o.ToString();
        }

        //tạo combobox loaihd
        private  void taocomboloaihd()
        {
            cbohdloaihd.DataSource = cdmhd.taocombohd();
            cbohdloaihd.DisplayMember = "TenLoaiHD";
            cbohdloaihd.ValueMember = "MaLoaiHD";
            if (txthdmahd.Text != "")
                cbohdloaihd.SelectedValue = int.Parse(layloaihdtheoma(txthdmahd.Text.Trim())); 
        }

        //set bộ nút của tab hợp đồng
        private  void setcmdhd(bool b)
        {
            cmdhdthem . Enabled = b;
            cmdhdCapnhat.Enabled = b;
            cmdhdxoa.Enabled = b;
            cmdhdluu.Enabled = !b;
        }

        //hiển thị dữ liệu của tab hợp đồng
        private  void HienThiTTHopDong(string ma)

        {
            dgv_ChiTietHopDong.DataSource = ccthopdong.laydl(ma);
            dgv_ChiTietHopDong.DataMember = "NV_HopDong";
            if (ccthopdong.kiemtra(ma) == true)
            {
                txthdmahd.Text = ccthopdong.ds.Tables["NV_HopDong"].Rows[0]["SoHD"].ToString();
                txthdngaykt.Text = mysql.NgayToString(ccthopdong.ds.Tables["NV_HopDong"].Rows[0]["NgayKetThuc"].ToString());
                txthdngayky.Text = mysql.NgayToString(ccthopdong.ds.Tables["NV_HopDong"].Rows[0]["NgayKy"].ToString());
                txthdluongcb.Text = ccthopdong.ds.Tables["NV_HopDong"].Rows[0]["LuongCoBan"].ToString();
                //tạo combo
                cbohdloaihd.DataSource = ccthopdong.laydl(ma);
                cbohdloaihd.DisplayMember = "NV_HopDong.TenLoaiHD";
                cbohdloaihd.ValueMember = "NV_HopDong.MaLoaiHD";
            }
            else
            {
                txthdmahd.Text = "";
                txthdngaykt.Text = "";
                txthdngayky.Text ="";
                txthdluongcb.Text = "";
            }
        }
        //lấy mã nhân viên tự động
        private string laysohdtudong(string s)
        {
            string kq = "";
            int so = int.Parse(s.Substring(2));
            if (so + 1 <= 99999999)
                kq = "HD0" + (so + 1);
            if (so + 1 < 1000000)
                kq = "NV00" + (so + 1);
            if (so + 1 < 100000)
                kq = "NV000" + (so + 1);
            if (so + 1 < 10000)
                kq = "NV0000" + (so + 1);
            if (so + 1 < 1000)
                kq = "NV00000" + (so + 1);
            if (so + 1 < 100)
                kq = "NV000000" + (so + 1);
            if (so + 1 < 10)
                kq = "NV0000000" + (so + 1);
            return kq;
        }   

        private void txthdmahd_Validated(object sender, EventArgs e)
        {
            txthdmahd.Text = txthdmahd.Text.Trim().ToUpper();
        }

        private void cmdhdthem_Click(object sender, EventArgs e)
        {
           
            khd = 1;
            setcontrolhd(true);
            setlist(false);
            taocomboloaihd();
            setcmdhd(false);
            txthdluongcb.Text = "";
            txthdmahd.Text = "";
            txthdngayky.Text = mysql.NgayToString(DateTime.Today.ToString());
            txthdngaykt.Text = mysql.NgayToString(DateTime.Today.ToString());
            cbohdloaihd.Focus();
            if (int.Parse(laysohdtudong(ccthopdong.laysohd()).Substring(2)) > 99999999)
            {
                MessageBox.Show("Chương trình chỉ được nhận dưới 1000 nhân viên", "Thông báo");
            }
            else txthdmahd.Text = laysohdtudong(ccthopdong.laysohd());

        }

        private void cmdhdCapnhat_Click(object sender, EventArgs e)
        {
            if (txthdmanv.Text == "")
                MessageBox.Show("Bạn phải chọn nhân viên chấm công", "Thông Báo");
            else
            {
                khd = 2;
                taocomboloaihd();
                setcontrolhd(true);
                setlist(false);
                setcmdhd(false);
                txthdmahd.ReadOnly = true;
                cbohdloaihd.Focus();
            }

        }

        private void cmdhdxoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa mẩu tin này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ccthopdong.xoa(txthdmahd.Text.Trim());
            
            HienThiTTHopDong(bienmanv);
        }

        private void cmdhdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                if (khd == 1)
                {
                    ccthopdong.them(txthdmahd.Text.Trim(),
                                    int.Parse(cbohdloaihd.SelectedValue.ToString()),
                                    txthdmanv.Text.Trim(),
                                    mysql.TraVeNgay(txthdngayky.Text.Trim(), 1),
                                    mysql.TraVeNgay(txthdngaykt.Text.Trim(), 1),
                                    txthdluongcb.Text !="" ? int.Parse(txthdluongcb.Text.Trim()) : 0 );
                }
                else if (khd == 2)
                {
                    ccthopdong.sua(txthdmahd.Text.Trim(),
                                    int.Parse(cbohdloaihd.SelectedValue.ToString()),
                                    txthdmanv.Text.Trim(),
                                    mysql.TraVeNgay(txthdngayky.Text.Trim(), 1) ,
                                    mysql.TraVeNgay(txthdngaykt.Text.Trim(), 1) ,
                                    txthdluongcb.Text != "" ? int.Parse(txthdluongcb.Text.Trim()) : 0);
                }
            }
            else
            {
                HienThiTTHopDong(bienmanv);
               
            }
            khd = 0;
            setcmdhd(true);
            setlist(true);
            setcontrolhd(false);
            txthdmahd.ReadOnly = false;
            HienThiTTHopDong(bienmanv);
        }

        private void txthdluongcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txthdngayky.Text = mysql.NgayToString(textBox1.Text.Trim());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txthdngaykt.Text = mysql.NgayToString(textBox2.Text.Trim());
        }

        private void dgv_ChiTietHopDong_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_ChiTietHopDong.CurrentRow;
            if (row != null)
            {
                txthdmahd.Text = Convert.ToString(row.Cells[0].Value);
                textBox1.Text = Convert.ToString(row.Cells[2].Value);
                textBox2.Text = Convert.ToString(row.Cells[3].Value);
                txthdluongcb.Text = Convert.ToString(row.Cells[4].Value);
            }
           
        }

        //kiểm tra việc nhập ngày ký 
        private void txthdngayky_Validated(object sender, EventArgs e)
        {
            string s = txthdngayky.Text.Trim();
            if (s != "")
            {
                if (!mysql.KiemTraNgay(s))
                {
                    MessageBox.Show("Bạn nhập ngày sai", "Thông báo");
                    txthdngayky.Text = "";
                    txthdngayky.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập ngày", "Thông báo");
                txthdngayky.Text = "";
                txthdngayky.Focus();
            }
            
        }

        //kiểm tra việc nhập ngày kết thúc hợp đồng
        private void txthdngaykt_Validated(object sender, EventArgs e)
        {
            string s = txthdngaykt.Text.Trim();
            if (s != "")
            {
                if (!mysql.KiemTraNgay(s))
                {
                    MessageBox.Show("Bạn nhập ngày sai", "Thông báo");
                    txthdngaykt.Text = "";
                    txthdngaykt.Focus();
                }
                else
                    if (mysql.TraVeNgay(s, 1) <= mysql.TraVeNgay(txthdngayky.Text.Trim(), 1))
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày ký hợp đồng", "Thông báo");
                    }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập ngày", "Thông báo");
                txthdngaykt.Text = "";
                txthdngaykt.Focus();
            }
        }       
        //
        //tab ho so luong
        //
        //set bộ nút của tab hồ sơ lương
        private void setcmdhsl(bool b)
        {
            cmdluongthem.Enabled = b;
            cmdluongcapnhat.Enabled = b;
            cmdluongxoa.Enabled = b;
            cmdluongluu.Enabled = !b;
        }

        //setcontrol tab hồ sơ lương 
        private void setcontrolhsl(bool b)
        {
            txthslmucluong.Enabled =b;
            txthslngayll.Enabled = b;
            cbohslsohd.Enabled =b;
        }

        //tạo combo số hợp đồng
        private void taocombosohd(string ma)
        {
            cbohslsohd.DataSource = chsluong.taocombo(ma);
            cbohslsohd.DisplayMember = "sohd";
            cbohslsohd.ValueMember = "sohd";
            if (txthslngayll.Text != "")
                cbohslsohd.SelectedValue = dgv_Hosoluong.CurrentRow.Cells[0].Value.ToString();
        }

        //hiển thị dữ liệu của tab hồ sơ lương
        private void HienThiTTHoSoLuong(string ma)
        {
            dgv_Hosoluong.DataSource = chsluong.laydl(ma);

            if (chsluong.kiemtra(ma) == true)
            {

                txthslngayll.Text = mysql.NgayToString(chsluong.laydl(ma).Rows[0]["ngayll"].ToString());
                txthslmucluong.Text = chsluong.laydl(ma).Rows[0]["mucluong"].ToString();
                //tạo combo
                cbohslsohd.DataSource = chsluong.taocombohd(ma);
                cbohslsohd.DisplayMember = "sohd";
                cbohslsohd.ValueMember = "sohd";
            }
            else
            {
                txthslmucluong.Text = "";
                txthslngayll.Text = "";
                cbohslsohd.Text = "";
            }
        }
        //
        private void dgv_Hosoluong_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_Hosoluong.CurrentRow;
            if (row != null)
            {
                cbohslsohd.Text = Convert.ToString(row.Cells[0].Value);
                textBox3.Text = Convert.ToString(row.Cells[1].Value);
                txthslmucluong.Text = Convert.ToString(row.Cells[2].Value);
            }
        }
        //
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txthslngayll.Text = mysql.NgayToString(textBox3.Text.Trim());
        }
        //
        private void cmdluongthem_Click(object sender, EventArgs e)
        {
            setlist(false);
            taocombosohd(bienmanv);
            setcmdhsl(false);
            setcontrolhsl(true);
            txthslngayll.Text = mysql.NgayToString(DateTime.Today.ToString());
            txthslmucluong.Text = "0";
            cbohslsohd.Focus();
            kluong = 1;
        }
        //
        private void cmdluongxoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa mẩu tin này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    chsluong.xoa(cbohslsohd.SelectedValue.ToString(), mysql.TraVeNgay(txthslngayll.Text.Trim(), 1));
                }
                catch
                { }
            }
            HienThiTTHoSoLuong(bienmanv);
        }
        //
        private void cmdluongcapnhat_Click(object sender, EventArgs e)
        {
            if (txthslmanv.Text == "")
                MessageBox.Show("Bạn phải chọn nhân viên chấm công", "Thông Báo");
            else
            {
                kluong = 2;
                taocombosohd(bienmanv);
                setlist(false);
                setcmdhsl(false);
                txthslmucluong.Enabled = true;
                txthslmucluong.Focus();
            }

        }
        //
        private void cmdluongluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn lưu thông tin này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                if (kluong == 1)
                {
                    chsluong.them(cbohslsohd.SelectedValue.ToString(),
                                  mysql.TraVeNgay(txthslngayll.Text.Trim(), 1),
                                  txthslmucluong.Text != "" ? int.Parse(txthslmucluong.Text.Trim()) : 0);
                }
                else if (kluong == 2)
                {
                    chsluong.sua(cbohslsohd.SelectedValue.ToString(),
                                   mysql.TraVeNgay(txthslngayll.Text.Trim(), 1),
                                   txthslmucluong.Text != "" ? int.Parse(txthslmucluong.Text.Trim()) : 0);
                }
            }
            else
            {
                HienThiTTHoSoLuong(bienmanv);
            }
            kluong = 0;
            setcmdhsl(true);
            setlist(true);
            setcontrolhsl(false);
            HienThiTTHoSoLuong(bienmanv);
        }
        //
        //tra cứu thông tin
        //
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmtracuutt));
            if (frm != null)
                frm.Activate();
            else
            {
                frmtracuutt f = new frmtracuutt();
                f.MdiParent = this.MdiParent ;
                f.Show();
            }
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiParent.MdiChildren) 
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        private void txttkmanv_TextChanged(object sender, EventArgs e)
        {
            string ma = txttkmanv.Text.Trim();
            lstNhanvien.Items.Clear();
            HienThiListNV(cnhanvien.timkiem(ma), lstNhanvien);
        }
        
        private void btnInNhanvien_Click(object sender, EventArgs e)
        {
            if (txtsymanv.Text == "")
            {
                MessageBox.Show("bạn phải chọn nhân viên để in", "Thông báo");
            }
            else
            {
                bienmanv = txtsymanv.Text.Trim();
                frmrpthsnhanvien f = new frmrpthsnhanvien();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

       

        

       

        
        


        

        
        

        

        
    }
}