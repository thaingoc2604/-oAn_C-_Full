namespace QuanLyTienGuiTietKiem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            System.Windows.Forms.DialogResult rs;
            rs = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình Quản lý gửi tiền tiết kiệm không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLoaiTietKiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnPSTietKiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSoDuTK = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.btnNhomNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuyen = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanNhom = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanQuyen = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.btnPhongGiaoDich = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuayGiaoDich = new DevComponents.DotNetBar.ButtonItem();
            this.btnNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnGiaoDichVien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDSSoTK = new DevComponents.DotNetBar.ButtonItem();
            this.btnMoSoTietKiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnRutTietKiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuiThemTienSoKKH = new DevComponents.DotNetBar.ButtonItem();
            this.btnKhachHang = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar13 = new DevComponents.DotNetBar.RibbonBar();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.btnCalculator = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar11 = new DevComponents.DotNetBar.RibbonBar();
            this.btnTimSoTK = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar10 = new DevComponents.DotNetBar.RibbonBar();
            this.btnTimNV = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar15 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDSSoLap = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDSNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar14 = new DevComponents.DotNetBar.RibbonBar();
            this.btnInSoCoKyHan = new DevComponents.DotNetBar.ButtonItem();
            this.btnSoTKKhongKyhan = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar12 = new DevComponents.DotNetBar.RibbonBar();
            this.btnPhieuLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnBangKeTinh = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnPhieuThu = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhieuChi = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel6 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLaiSuatTK = new DevComponents.DotNetBar.ButtonItem();
            this.btnTaiKhoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnDuyetSoGopVon = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDMChiTietPSGD = new DevComponents.DotNetBar.ButtonItem();
            this.btnDMKyLaiTK = new DevComponents.DotNetBar.ButtonItem();
            this.btnDMLoaiGiaoDich = new DevComponents.DotNetBar.ButtonItem();
            this.btnDMLoaiTien = new DevComponents.DotNetBar.ButtonItem();
            this.btnDMTaiKhoan = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem6 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnChangePass = new DevComponents.DotNetBar.ButtonItem();
            this.btnBackUp = new DevComponents.DotNetBar.ButtonItem();
            this.btnRestor = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanel1);
            this.ribbonControl.Controls.Add(this.ribbonPanel4);
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Controls.Add(this.ribbonPanel5);
            this.ribbonControl.Controls.Add(this.ribbonPanel2);
            this.ribbonControl.Controls.Add(this.ribbonPanel6);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem6,
            this.ribbonTabItem2,
            this.ribbonTabItem5,
            this.ribbonTabItem3,
            this.ribbonTabItem4});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.qatCustomizeItem1});
            this.ribbonControl.Size = new System.Drawing.Size(1083, 154);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            this.ribbonControl.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar6);
            this.ribbonPanel1.Controls.Add(this.ribbonBar5);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLoaiTietKiem,
            this.btnPSTietKiem,
            this.btnSoDuTK});
            this.ribbonBar7.Location = new System.Drawing.Point(905, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(183, 94);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar7.TabIndex = 7;
            // 
            // btnLoaiTietKiem
            // 
            this.btnLoaiTietKiem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmLoaiTK;
            this.btnLoaiTietKiem.ImagePaddingHorizontal = 8;
            this.btnLoaiTietKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnLoaiTietKiem.Name = "btnLoaiTietKiem";
            this.btnLoaiTietKiem.SubItemsExpandWidth = 14;
            this.btnLoaiTietKiem.Text = "<div align=\"center\">Loại tiết <br />kiệm</div>";
            this.btnLoaiTietKiem.Click += new System.EventHandler(this.btnLoaiTietKiem_Click);
            // 
            // btnPSTietKiem
            // 
            this.btnPSTietKiem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhatSinhTK;
            this.btnPSTietKiem.ImagePaddingHorizontal = 8;
            this.btnPSTietKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPSTietKiem.Name = "btnPSTietKiem";
            this.btnPSTietKiem.SubItemsExpandWidth = 14;
            this.btnPSTietKiem.Text = "<div align=\"center\">Phát sinh<br /> tiết kiệm</div>";
            this.btnPSTietKiem.Click += new System.EventHandler(this.btnPSTietKiem_Click);
            // 
            // btnSoDuTK
            // 
            this.btnSoDuTK.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmSoDuTK;
            this.btnSoDuTK.ImagePaddingHorizontal = 8;
            this.btnSoDuTK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnSoDuTK.Name = "btnSoDuTK";
            this.btnSoDuTK.SubItemsExpandWidth = 14;
            this.btnSoDuTK.Text = "<div align=\"center\">Số dư tiết<br/> kiệm</div>";
            this.btnSoDuTK.Click += new System.EventHandler(this.btnSoDuTK_Click);
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNhomNguoiDung,
            this.btnQuyen,
            this.btnPhanNhom,
            this.btnPhanQuyen});
            this.ribbonBar6.Location = new System.Drawing.Point(647, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(258, 94);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar6.TabIndex = 6;
            // 
            // btnNhomNguoiDung
            // 
            this.btnNhomNguoiDung.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmNhomNguoiDung;
            this.btnNhomNguoiDung.ImagePaddingHorizontal = 8;
            this.btnNhomNguoiDung.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnNhomNguoiDung.Name = "btnNhomNguoiDung";
            this.btnNhomNguoiDung.SubItemsExpandWidth = 14;
            this.btnNhomNguoiDung.Text = "<div align =\"center\">Nhóm người<br />dùng</div>";
            this.btnNhomNguoiDung.Click += new System.EventHandler(this.btnNhomNguoiDung_Click);
            // 
            // btnQuyen
            // 
            this.btnQuyen.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmQuyen;
            this.btnQuyen.ImagePaddingHorizontal = 8;
            this.btnQuyen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.SubItemsExpandWidth = 14;
            this.btnQuyen.Text = "Quyền";
            this.btnQuyen.Click += new System.EventHandler(this.btnQuyen_Click);
            // 
            // btnPhanNhom
            // 
            this.btnPhanNhom.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhanNhom;
            this.btnPhanNhom.ImagePaddingHorizontal = 8;
            this.btnPhanNhom.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhanNhom.Name = "btnPhanNhom";
            this.btnPhanNhom.SubItemsExpandWidth = 14;
            this.btnPhanNhom.Text = "Phân nhóm";
            this.btnPhanNhom.Click += new System.EventHandler(this.btnPhanNhom_Click);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhanQuyen;
            this.btnPhanQuyen.ImagePaddingHorizontal = 8;
            this.btnPhanQuyen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.SubItemsExpandWidth = 14;
            this.btnPhanQuyen.Text = "Phân quyền";
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPhongGiaoDich,
            this.btnQuayGiaoDich,
            this.btnNhanVien,
            this.btnGiaoDichVien});
            this.ribbonBar5.Location = new System.Drawing.Point(395, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(252, 94);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar5.TabIndex = 1;
            // 
            // btnPhongGiaoDich
            // 
            this.btnPhongGiaoDich.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmQuayGD;
            this.btnPhongGiaoDich.ImagePaddingHorizontal = 8;
            this.btnPhongGiaoDich.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhongGiaoDich.Name = "btnPhongGiaoDich";
            this.btnPhongGiaoDich.SubItemsExpandWidth = 14;
            this.btnPhongGiaoDich.Text = "<div align =\"center\">Phòng giao<br /> dịch</div>";
            this.btnPhongGiaoDich.Click += new System.EventHandler(this.btnPhongGiaoDich_Click);
            // 
            // btnQuayGiaoDich
            // 
            this.btnQuayGiaoDich.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmQuayGD1;
            this.btnQuayGiaoDich.ImagePaddingHorizontal = 8;
            this.btnQuayGiaoDich.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnQuayGiaoDich.Name = "btnQuayGiaoDich";
            this.btnQuayGiaoDich.SubItemsExpandWidth = 14;
            this.btnQuayGiaoDich.Text = "<div align=\"center\">Quầy giao<br/>dịch</div>";
            this.btnQuayGiaoDich.Click += new System.EventHandler(this.btnQuayGiaoDich_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmNhanVien;
            this.btnNhanVien.ImagePaddingHorizontal = 8;
            this.btnNhanVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.SubItemsExpandWidth = 14;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnGiaoDichVien
            // 
            this.btnGiaoDichVien.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmGiaoDichVien1;
            this.btnGiaoDichVien.ImagePaddingHorizontal = 8;
            this.btnGiaoDichVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnGiaoDichVien.Name = "btnGiaoDichVien";
            this.btnGiaoDichVien.SubItemsExpandWidth = 14;
            this.btnGiaoDichVien.Text = "<div align = \"center\">Giao dịch <br />viên</div>";
            this.btnGiaoDichVien.Click += new System.EventHandler(this.btnGiaoDichVien_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDSSoTK,
            this.btnMoSoTietKiem,
            this.btnRutTietKiem,
            this.btnGuiThemTienSoKKH,
            this.btnKhachHang});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(392, 94);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            // 
            // btnDSSoTK
            // 
            this.btnDSSoTK.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDanhSachSoTK;
            this.btnDSSoTK.ImagePaddingHorizontal = 8;
            this.btnDSSoTK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDSSoTK.Name = "btnDSSoTK";
            this.btnDSSoTK.SubItemsExpandWidth = 14;
            this.btnDSSoTK.Text = "<div align =\"center\">Danh sách sổ <br /> tiết kiệm</div>";
            this.btnDSSoTK.Click += new System.EventHandler(this.btnDSSoTK_Click);
            // 
            // btnMoSoTietKiem
            // 
            this.btnMoSoTietKiem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmMoSoTietKiem;
            this.btnMoSoTietKiem.ImagePaddingHorizontal = 8;
            this.btnMoSoTietKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnMoSoTietKiem.Name = "btnMoSoTietKiem";
            this.btnMoSoTietKiem.SubItemsExpandWidth = 14;
            this.btnMoSoTietKiem.Text = "<div align=\"center\">Mở sổ tiết<br /> kiệm</div>";
            this.btnMoSoTietKiem.Click += new System.EventHandler(this.btnMoSoTietKiem_Click);
            // 
            // btnRutTietKiem
            // 
            this.btnRutTietKiem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmRutTienTietKiem;
            this.btnRutTietKiem.ImagePaddingHorizontal = 8;
            this.btnRutTietKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnRutTietKiem.Name = "btnRutTietKiem";
            this.btnRutTietKiem.SubItemsExpandWidth = 14;
            this.btnRutTietKiem.Text = "<div align = \"center\">Rút tiền tiền <br />tiết kiệm</div>";
            this.btnRutTietKiem.Click += new System.EventHandler(this.btnRutTietKiem_Click);
            // 
            // btnGuiThemTienSoKKH
            // 
            this.btnGuiThemTienSoKKH.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmGuiThemVon;
            this.btnGuiThemTienSoKKH.ImagePaddingHorizontal = 8;
            this.btnGuiThemTienSoKKH.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnGuiThemTienSoKKH.Name = "btnGuiThemTienSoKKH";
            this.btnGuiThemTienSoKKH.SubItemsExpandWidth = 14;
            this.btnGuiThemTienSoKKH.Text = "<div align=\"center\">Gửi thêm tiền sổ <br />không kỳ hạn</div>";
            this.btnGuiThemTienSoKKH.Click += new System.EventHandler(this.btnGuiThemTienSoKKH_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmKhachHang;
            this.btnKhachHang.ImagePaddingHorizontal = 8;
            this.btnKhachHang.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.SubItemsExpandWidth = 14;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel4.Controls.Add(this.ribbonBar9);
            this.ribbonPanel4.Controls.Add(this.ribbonBar13);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = true;
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAbout});
            this.ribbonBar9.Location = new System.Drawing.Point(112, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(98, 94);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar9.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.AboutMe;
            this.btnAbout.ImagePaddingHorizontal = 8;
            this.btnAbout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SubItemsExpandWidth = 14;
            this.btnAbout.Text = "<div align=\"center\">Thông tin phần <br />mêm</div>";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // ribbonBar13
            // 
            this.ribbonBar13.AutoOverflowEnabled = true;
            this.ribbonBar13.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar13.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHelp,
            this.btnCalculator});
            this.ribbonBar13.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar13.Name = "ribbonBar13";
            this.ribbonBar13.Size = new System.Drawing.Size(109, 94);
            this.ribbonBar13.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar13.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmhelp;
            this.btnHelp.ImagePaddingHorizontal = 8;
            this.btnHelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.btnHelp.SubItemsExpandWidth = 14;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCalculator.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmCalculator;
            this.btnCalculator.ImagePaddingHorizontal = 8;
            this.btnCalculator.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.PopupFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.PopupWidth = 300;
            this.btnCalculator.SubItemsExpandWidth = 20;
            this.btnCalculator.Text = "Máy tính";
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Controls.Add(this.ribbonBar11);
            this.ribbonPanel3.Controls.Add(this.ribbonBar10);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel3.TabIndex = 6;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonBar11
            // 
            this.ribbonBar11.AutoOverflowEnabled = true;
            this.ribbonBar11.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar11.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimSoTK});
            this.ribbonBar11.Location = new System.Drawing.Point(76, 0);
            this.ribbonBar11.Name = "ribbonBar11";
            this.ribbonBar11.Size = new System.Drawing.Size(87, 94);
            this.ribbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar11.TabIndex = 1;
            // 
            // btnTimSoTK
            // 
            this.btnTimSoTK.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmTimSo;
            this.btnTimSoTK.ImagePaddingHorizontal = 8;
            this.btnTimSoTK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnTimSoTK.Name = "btnTimSoTK";
            this.btnTimSoTK.SubItemsExpandWidth = 14;
            this.btnTimSoTK.Text = "<div align=\"center\">Tìm kiếm sổ <br />tiết kiệm</div>";
            this.btnTimSoTK.Click += new System.EventHandler(this.btnTimSoTK_Click);
            // 
            // ribbonBar10
            // 
            this.ribbonBar10.AutoOverflowEnabled = true;
            this.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar10.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimNV});
            this.ribbonBar10.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar10.Name = "ribbonBar10";
            this.ribbonBar10.Size = new System.Drawing.Size(73, 94);
            this.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar10.TabIndex = 0;
            // 
            // btnTimNV
            // 
            this.btnTimNV.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmTimNhanVien;
            this.btnTimNV.ImagePaddingHorizontal = 8;
            this.btnTimNV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.SubItemsExpandWidth = 14;
            this.btnTimNV.Text = "<div align=\"center\">Tìm kiếm <br />nhân viên</div>";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel5.Controls.Add(this.ribbonBar15);
            this.ribbonPanel5.Controls.Add(this.ribbonBar4);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel5.TabIndex = 8;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonBar15
            // 
            this.ribbonBar15.AutoOverflowEnabled = true;
            this.ribbonBar15.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar15.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDSSoLap});
            this.ribbonBar15.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar15.Name = "ribbonBar15";
            this.ribbonBar15.Size = new System.Drawing.Size(115, 94);
            this.ribbonBar15.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar15.TabIndex = 1;
            // 
            // btnDSSoLap
            // 
            this.btnDSSoLap.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDanhSachSoCuaNgay;
            this.btnDSSoLap.ImagePaddingHorizontal = 8;
            this.btnDSSoLap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDSSoLap.Name = "btnDSSoLap";
            this.btnDSSoLap.SubItemsExpandWidth = 14;
            this.btnDSSoLap.Text = "<div align=\"center\">Danh sách sổ được<br /> lập trong ngày</div>";
            this.btnDSSoLap.Click += new System.EventHandler(this.btnDSSoLap_Click);
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDSNhanVien});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(100, 94);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 0;
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDanhSachNV;
            this.btnDSNhanVien.ImagePaddingHorizontal = 8;
            this.btnDSNhanVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.SubItemsExpandWidth = 14;
            this.btnDSNhanVien.Text = "<div align=\"center\">Danh sách nhân <br />viên</div>";
            this.btnDSNhanVien.Click += new System.EventHandler(this.btnDSNhanVien_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar14);
            this.ribbonPanel2.Controls.Add(this.ribbonBar12);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar14
            // 
            this.ribbonBar14.AutoOverflowEnabled = true;
            this.ribbonBar14.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar14.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInSoCoKyHan,
            this.btnSoTKKhongKyhan});
            this.ribbonBar14.Location = new System.Drawing.Point(268, 0);
            this.ribbonBar14.Name = "ribbonBar14";
            this.ribbonBar14.Size = new System.Drawing.Size(190, 94);
            this.ribbonBar14.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar14.TabIndex = 2;
            // 
            // btnInSoCoKyHan
            // 
            this.btnInSoCoKyHan.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmSoCoKyHan;
            this.btnInSoCoKyHan.ImagePaddingHorizontal = 8;
            this.btnInSoCoKyHan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnInSoCoKyHan.Name = "btnInSoCoKyHan";
            this.btnInSoCoKyHan.SubItemsExpandWidth = 14;
            this.btnInSoCoKyHan.Text = "<div align=\"center\">Lập sổ tiết kiệm <br />có kỳ hạn</div>";
            this.btnInSoCoKyHan.Click += new System.EventHandler(this.btnInSoCoKyHan_Click);
            // 
            // btnSoTKKhongKyhan
            // 
            this.btnSoTKKhongKyhan.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmSoKhongKHan;
            this.btnSoTKKhongKyhan.ImagePaddingHorizontal = 8;
            this.btnSoTKKhongKyhan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnSoTKKhongKyhan.Name = "btnSoTKKhongKyhan";
            this.btnSoTKKhongKyhan.SubItemsExpandWidth = 14;
            this.btnSoTKKhongKyhan.Text = "<div align=\"center\">Lập sổ tiết kiệm <br />không kỳ hạn</div>";
            this.btnSoTKKhongKyhan.Click += new System.EventHandler(this.btnSoTKKhongKyhan_Click);
            // 
            // ribbonBar12
            // 
            this.ribbonBar12.AutoOverflowEnabled = true;
            this.ribbonBar12.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar12.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPhieuLuu,
            this.btnBangKeTinh});
            this.ribbonBar12.Location = new System.Drawing.Point(129, 0);
            this.ribbonBar12.Name = "ribbonBar12";
            this.ribbonBar12.Size = new System.Drawing.Size(139, 94);
            this.ribbonBar12.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar12.TabIndex = 1;
            // 
            // btnPhieuLuu
            // 
            this.btnPhieuLuu.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhieuLuu;
            this.btnPhieuLuu.ImagePaddingHorizontal = 8;
            this.btnPhieuLuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhieuLuu.Name = "btnPhieuLuu";
            this.btnPhieuLuu.SubItemsExpandWidth = 14;
            this.btnPhieuLuu.Text = "Phiếu lưu";
            this.btnPhieuLuu.Click += new System.EventHandler(this.btnPhieuLuu_Click);
            // 
            // btnBangKeTinh
            // 
            this.btnBangKeTinh.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmBangKeTinhLai;
            this.btnBangKeTinh.ImagePaddingHorizontal = 8;
            this.btnBangKeTinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnBangKeTinh.Name = "btnBangKeTinh";
            this.btnBangKeTinh.SubItemsExpandWidth = 14;
            this.btnBangKeTinh.Text = "<div align=\"center\">Bảng tính kê<br /> lãi tiết kiệm</div>";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPhieuThu,
            this.btnPhieuChi});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(126, 94);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 0;
            // 
            // btnPhieuThu
            // 
            this.btnPhieuThu.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhieuThu;
            this.btnPhieuThu.ImagePaddingHorizontal = 8;
            this.btnPhieuThu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhieuThu.Name = "btnPhieuThu";
            this.btnPhieuThu.SubItemsExpandWidth = 14;
            this.btnPhieuThu.Text = "Phiếu thu";
            this.btnPhieuThu.Click += new System.EventHandler(this.btnPhieuThu_Click);
            // 
            // btnPhieuChi
            // 
            this.btnPhieuChi.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmPhieuChi;
            this.btnPhieuChi.ImagePaddingHorizontal = 8;
            this.btnPhieuChi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnPhieuChi.Name = "btnPhieuChi";
            this.btnPhieuChi.SubItemsExpandWidth = 14;
            this.btnPhieuChi.Text = "Phiếu chi";
            this.btnPhieuChi.Click += new System.EventHandler(this.btnPhieuChi_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel6.Controls.Add(this.ribbonBar8);
            this.ribbonPanel6.Controls.Add(this.ribbonBar2);
            this.ribbonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel6.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel6.Size = new System.Drawing.Size(1083, 97);
            this.ribbonPanel6.TabIndex = 7;
            this.ribbonPanel6.Visible = false;
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLaiSuatTK,
            this.btnTaiKhoan,
            this.btnDuyetSoGopVon});
            this.ribbonBar8.Location = new System.Drawing.Point(295, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(216, 94);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar8.TabIndex = 7;
            // 
            // btnLaiSuatTK
            // 
            this.btnLaiSuatTK.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDMLaiSuatTK;
            this.btnLaiSuatTK.ImagePaddingHorizontal = 8;
            this.btnLaiSuatTK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnLaiSuatTK.Name = "btnLaiSuatTK";
            this.btnLaiSuatTK.SubItemsExpandWidth = 14;
            this.btnLaiSuatTK.Text = "<div align=\"center\">Lãi xuất tiết <br />kiệm</div>";
            this.btnLaiSuatTK.Click += new System.EventHandler(this.btnLaiSuatTK_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmTaiKhoan;
            this.btnTaiKhoan.ImagePaddingHorizontal = 8;
            this.btnTaiKhoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.SubItemsExpandWidth = 14;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDuyetSoGopVon
            // 
            this.btnDuyetSoGopVon.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDuyetSo;
            this.btnDuyetSoGopVon.ImagePaddingHorizontal = 8;
            this.btnDuyetSoGopVon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDuyetSoGopVon.Name = "btnDuyetSoGopVon";
            this.btnDuyetSoGopVon.SubItemsExpandWidth = 14;
            this.btnDuyetSoGopVon.Text = "<div align=\"center\">Duyệt sổ góp <br />vốn</div>";
            this.btnDuyetSoGopVon.Click += new System.EventHandler(this.btnDuyetSoGopVon_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDMChiTietPSGD,
            this.btnDMKyLaiTK,
            this.btnDMLoaiGiaoDich,
            this.btnDMLoaiTien,
            this.btnDMTaiKhoan});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(292, 94);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 6;
            // 
            // btnDMChiTietPSGD
            // 
            this.btnDMChiTietPSGD.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmChiTietPSGD;
            this.btnDMChiTietPSGD.ImagePaddingHorizontal = 8;
            this.btnDMChiTietPSGD.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDMChiTietPSGD.Name = "btnDMChiTietPSGD";
            this.btnDMChiTietPSGD.SubItemsExpandWidth = 14;
            this.btnDMChiTietPSGD.Text = "<div align =\"center\">DM Chi tiết<br/> phát sinh GD</div>";
            this.btnDMChiTietPSGD.Click += new System.EventHandler(this.btnDMChiTietPSGD_Click);
            // 
            // btnDMKyLaiTK
            // 
            this.btnDMKyLaiTK.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDMKyLaiTK;
            this.btnDMKyLaiTK.ImagePaddingHorizontal = 8;
            this.btnDMKyLaiTK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDMKyLaiTK.Name = "btnDMKyLaiTK";
            this.btnDMKyLaiTK.SubItemsExpandWidth = 14;
            this.btnDMKyLaiTK.Text = "<div align=\"center\">DM Ky lãi <br />tiết kiệm</div>";
            this.btnDMKyLaiTK.Click += new System.EventHandler(this.btnDMKyLaiTK_Click);
            // 
            // btnDMLoaiGiaoDich
            // 
            this.btnDMLoaiGiaoDich.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDMLoaiGiaoDich;
            this.btnDMLoaiGiaoDich.ImagePaddingHorizontal = 8;
            this.btnDMLoaiGiaoDich.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDMLoaiGiaoDich.Name = "btnDMLoaiGiaoDich";
            this.btnDMLoaiGiaoDich.SubItemsExpandWidth = 14;
            this.btnDMLoaiGiaoDich.Text = "<div align=\"center\">DM Loai <br />giao dịch</div>";
            this.btnDMLoaiGiaoDich.Click += new System.EventHandler(this.btnDMLoaiGiaoDich_Click);
            // 
            // btnDMLoaiTien
            // 
            this.btnDMLoaiTien.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDMLoaiTien;
            this.btnDMLoaiTien.ImagePaddingHorizontal = 8;
            this.btnDMLoaiTien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDMLoaiTien.Name = "btnDMLoaiTien";
            this.btnDMLoaiTien.SubItemsExpandWidth = 14;
            this.btnDMLoaiTien.Text = "<div align=\"center\">DM Loai <br />tiền</div>";
            this.btnDMLoaiTien.Click += new System.EventHandler(this.btnDMLoaiTien_Click);
            // 
            // btnDMTaiKhoan
            // 
            this.btnDMTaiKhoan.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDMTaiKhoan;
            this.btnDMTaiKhoan.ImagePaddingHorizontal = 8;
            this.btnDMTaiKhoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnDMTaiKhoan.Name = "btnDMTaiKhoan";
            this.btnDMTaiKhoan.SubItemsExpandWidth = 14;
            this.btnDMTaiKhoan.Text = "<div align=\"center\">DM tài <br />khoản</div>";
            this.btnDMTaiKhoan.Click += new System.EventHandler(this.btnDMTaiKhoan_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltQ);
            this.ribbonTabItem1.Text = "Quản lý";
            // 
            // ribbonTabItem6
            // 
            this.ribbonTabItem6.ImagePaddingHorizontal = 8;
            this.ribbonTabItem6.Name = "ribbonTabItem6";
            this.ribbonTabItem6.Panel = this.ribbonPanel6;
            this.ribbonTabItem6.Text = "Quản lý chi tiết";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltT);
            this.ribbonTabItem2.Text = "Lập phiếu ";
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.ImagePaddingHorizontal = 8;
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Panel = this.ribbonPanel5;
            this.ribbonTabItem5.Text = "Thống kê";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.ImagePaddingHorizontal = 8;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "Tìm kiếm";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.ImagePaddingHorizontal = 8;
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "Giúp đỡ";
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frm;
            this.buttonFile.ImagePaddingHorizontal = 2;
            this.buttonFile.ImagePaddingVertical = 2;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.buttonFile.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.BorderLeftWidth = 10;
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 120);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnChangePass,
            this.btnBackUp,
            this.btnRestor,
            this.btnClose});
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangNhap.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDangNhap;
            this.btnDangNhap.ImagePaddingHorizontal = 8;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SubItemsExpandWidth = 30;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangXuat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDangXuat;
            this.btnDangXuat.ImagePaddingHorizontal = 8;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 24;
            this.btnDangXuat.Text = "Đăng xuất ";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BeginGroup = true;
            this.btnChangePass.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChangePass.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmDoimatkhau;
            this.btnChangePass.ImagePaddingHorizontal = 8;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BeginGroup = true;
            this.btnBackUp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBackUp.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmBackup;
            this.btnBackUp.ImagePaddingHorizontal = 8;
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Text = "Sao lưu dữ liệu";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnRestor
            // 
            this.btnRestor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRestor.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmRestore;
            this.btnRestor.ImagePaddingHorizontal = 8;
            this.btnRestor.Name = "btnRestor";
            this.btnRestor.Text = "Phục hồi dữ liệu";
            this.btnRestor.Click += new System.EventHandler(this.btnRestor_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.frmExit;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Đóng ứng dụng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Location = new System.Drawing.Point(4, 155);
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabStrip.Size = new System.Drawing.Size(1083, 25);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabIndex = 1;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2});
            this.contextMenuBar1.Location = new System.Drawing.Point(49, 210);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(102, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 2;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.AutoExpandOnClick = true;
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5});
            // 
            // buttonItem5
            // 
            this.buttonItem5.ImagePaddingHorizontal = 8;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "Đóng ứng dụng";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Location = new System.Drawing.Point(853, 29);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(222, 21);
            this.lblTenNguoiDung.TabIndex = 8;
            this.lblTenNguoiDung.Text = "Đăng nhập vào phần mềm để có thể sử dụng";
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "GuiTietKiem";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "GuiTietKiem.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTienGuiTietKiem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 650);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ GIAO DỊCH TIỀN GỬI TIẾT KIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.ButtonItem btnDangNhap;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem btnBackUp;
        private DevComponents.DotNetBar.ButtonItem btnRestor;
        private DevComponents.DotNetBar.ButtonItem btnChangePass;
        private DevComponents.DotNetBar.ButtonItem btnDSSoTK;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem btnPhongGiaoDich;
        private DevComponents.DotNetBar.ButtonItem btnQuayGiaoDich;
        private DevComponents.DotNetBar.ButtonItem btnNhanVien;
        private DevComponents.DotNetBar.ButtonItem btnGiaoDichVien;
        private DevComponents.DotNetBar.ButtonItem btnPhieuThu;
        private DevComponents.DotNetBar.ButtonItem btnPhieuChi;
        private DevComponents.DotNetBar.ButtonItem btnKhachHang;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.ButtonItem btnNhomNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnQuyen;
        private DevComponents.DotNetBar.ButtonItem btnPhanNhom;
        private DevComponents.DotNetBar.ButtonItem btnPhanQuyen;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel6;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnLoaiTietKiem;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnDMChiTietPSGD;
        private DevComponents.DotNetBar.ButtonItem btnDMKyLaiTK;
        private DevComponents.DotNetBar.ButtonItem btnDMLoaiGiaoDich;
        private DevComponents.DotNetBar.ButtonItem btnDMLoaiTien;
        private DevComponents.DotNetBar.ButtonItem btnDMTaiKhoan;
        private DevComponents.DotNetBar.ButtonItem btnPSTietKiem;
        private DevComponents.DotNetBar.ButtonItem btnSoDuTK;
        private DevComponents.DotNetBar.RibbonBar ribbonBar8;
        private DevComponents.DotNetBar.ButtonItem btnLaiSuatTK;
        private DevComponents.DotNetBar.ButtonItem btnTaiKhoan;
        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private System.Windows.Forms.SaveFileDialog backupDialog;
        private System.Windows.Forms.OpenFileDialog restoreDialog;
        private DevComponents.DotNetBar.RibbonBar ribbonBar10;
        private DevComponents.DotNetBar.ButtonItem btnTimNV;
        private DevComponents.DotNetBar.RibbonBar ribbonBar12;
        private DevComponents.DotNetBar.RibbonBar ribbonBar11;
        private DevComponents.DotNetBar.ButtonItem btnTimSoTK;
        private DevComponents.DotNetBar.ButtonItem btnPhieuLuu;
        private DevComponents.DotNetBar.ButtonItem btnBangKeTinh;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        private DevComponents.DotNetBar.RibbonBar ribbonBar13;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private DevComponents.DotNetBar.ButtonItem btnCalculator;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem btnRutTietKiem;
        private DevComponents.DotNetBar.ButtonItem btnGuiThemTienSoKKH;
        private DevComponents.DotNetBar.ButtonItem btnDuyetSoGopVon;
        private DevComponents.DotNetBar.RibbonBar ribbonBar14;
        private DevComponents.DotNetBar.ButtonItem btnInSoCoKyHan;
        private DevComponents.DotNetBar.ButtonItem btnSoTKKhongKyhan;
        private DevComponents.DotNetBar.ButtonItem btnMoSoTietKiem;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnDSNhanVien;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar15;
        private DevComponents.DotNetBar.ButtonItem btnDSSoLap;

    }
}