namespace BankManagement
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonMain = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.biNewUser = new DevComponents.DotNetBar.ButtonItem();
            this.biRule = new DevComponents.DotNetBar.ButtonItem();
            this.biNewQAEmu = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.biSend = new DevComponents.DotNetBar.ButtonItem();
            this.biWithdraw = new DevComponents.DotNetBar.ButtonItem();
            this.biTransfer = new DevComponents.DotNetBar.ButtonItem();
            this.biViewTrans = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.biNewAcc = new DevComponents.DotNetBar.ButtonItem();
            this.biCloseAcc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.biTypes = new DevComponents.DotNetBar.ButtonItem();
            this.biBanks = new DevComponents.DotNetBar.ButtonItem();
            this.biUsers = new DevComponents.DotNetBar.ButtonItem();
            this.biChangePass = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.biAccs = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.ItemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.biAbout = new DevComponents.DotNetBar.ButtonItem();
            this.biHelp = new DevComponents.DotNetBar.ButtonItem();
            this.biQAEmu = new DevComponents.DotNetBar.ButtonItem();
            this.biRestart = new DevComponents.DotNetBar.ButtonItem();
            this.biExit = new DevComponents.DotNetBar.ButtonItem();
            this.pnClient = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonMain.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.pnClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.CaptionVisible = true;
            this.ribbonMain.Controls.Add(this.ribbonPanel1);
            this.ribbonMain.Controls.Add(this.ribbonPanel2);
            this.ribbonMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonMain.Location = new System.Drawing.Point(4, 1);
            this.ribbonMain.Name = "ribbonMain";
            this.ribbonMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonMain.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1});
            this.ribbonMain.Size = new System.Drawing.Size(722, 154);
            this.ribbonMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonMain.TabGroupHeight = 14;
            this.ribbonMain.TabIndex = 0;
            this.ribbonMain.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar4);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(722, 97);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biNewUser,
            this.biRule,
            this.biNewQAEmu});
            this.ribbonBar4.Location = new System.Drawing.Point(397, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(198, 94);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 2;
            this.ribbonBar4.Text = "Hệ thống";
            // 
            // biNewUser
            // 
            this.biNewUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biNewUser.Image = ((System.Drawing.Image)(resources.GetObject("biNewUser.Image")));
            this.biNewUser.ImagePaddingHorizontal = 8;
            this.biNewUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biNewUser.KeyTips = "U";
            this.biNewUser.Name = "biNewUser";
            this.biNewUser.SubItemsExpandWidth = 14;
            this.biNewUser.Text = "Thêm người dùng";
            this.biNewUser.Click += new System.EventHandler(this.biNewUser_Click);
            // 
            // biRule
            // 
            this.biRule.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biRule.Image = ((System.Drawing.Image)(resources.GetObject("biRule.Image")));
            this.biRule.ImagePaddingHorizontal = 8;
            this.biRule.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biRule.KeyTips = "R";
            this.biRule.Name = "biRule";
            this.biRule.RibbonWordWrap = false;
            this.biRule.SubItemsExpandWidth = 14;
            this.biRule.Text = "Quy định";
            this.biRule.Click += new System.EventHandler(this.biRule_Click);
            // 
            // biNewQAEmu
            // 
            this.biNewQAEmu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biNewQAEmu.Image = ((System.Drawing.Image)(resources.GetObject("biNewQAEmu.Image")));
            this.biNewQAEmu.ImagePaddingHorizontal = 8;
            this.biNewQAEmu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biNewQAEmu.Name = "biNewQAEmu";
            this.biNewQAEmu.RibbonWordWrap = false;
            this.biNewQAEmu.SubItemsExpandWidth = 14;
            this.biNewQAEmu.Text = "Chạy &QAEmu";
            this.biNewQAEmu.Click += new System.EventHandler(this.biNewQAEmu_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biSend,
            this.biWithdraw,
            this.biTransfer,
            this.biViewTrans});
            this.ribbonBar2.Location = new System.Drawing.Point(163, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(234, 94);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Giao dịch";
            // 
            // biSend
            // 
            this.biSend.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biSend.Image = ((System.Drawing.Image)(resources.GetObject("biSend.Image")));
            this.biSend.ImagePaddingHorizontal = 8;
            this.biSend.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biSend.KeyTips = "S";
            this.biSend.Name = "biSend";
            this.biSend.RibbonWordWrap = false;
            this.biSend.SubItemsExpandWidth = 14;
            this.biSend.Text = "Gửi tiền";
            this.biSend.Click += new System.EventHandler(this.biSend_Click);
            // 
            // biWithdraw
            // 
            this.biWithdraw.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("biWithdraw.Image")));
            this.biWithdraw.ImagePaddingHorizontal = 8;
            this.biWithdraw.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biWithdraw.KeyTips = "W";
            this.biWithdraw.Name = "biWithdraw";
            this.biWithdraw.RibbonWordWrap = false;
            this.biWithdraw.SubItemsExpandWidth = 14;
            this.biWithdraw.Text = "Rút tiền";
            this.biWithdraw.Click += new System.EventHandler(this.biWithdraw_Click);
            // 
            // biTransfer
            // 
            this.biTransfer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biTransfer.Image = ((System.Drawing.Image)(resources.GetObject("biTransfer.Image")));
            this.biTransfer.ImagePaddingHorizontal = 8;
            this.biTransfer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biTransfer.KeyTips = "T";
            this.biTransfer.Name = "biTransfer";
            this.biTransfer.RibbonWordWrap = false;
            this.biTransfer.SubItemsExpandWidth = 14;
            this.biTransfer.Text = "Chuyển khoản";
            // 
            // biViewTrans
            // 
            this.biViewTrans.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biViewTrans.Image = ((System.Drawing.Image)(resources.GetObject("biViewTrans.Image")));
            this.biViewTrans.ImagePaddingHorizontal = 8;
            this.biViewTrans.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biViewTrans.KeyTips = "V";
            this.biViewTrans.Name = "biViewTrans";
            this.biViewTrans.SubItemsExpandWidth = 14;
            this.biViewTrans.Text = "Xem giao dịch";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biNewAcc,
            this.biCloseAcc});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(160, 94);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Tài khoản";
            // 
            // biNewAcc
            // 
            this.biNewAcc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biNewAcc.Image = ((System.Drawing.Image)(resources.GetObject("biNewAcc.Image")));
            this.biNewAcc.ImagePaddingHorizontal = 8;
            this.biNewAcc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biNewAcc.KeyTips = "O";
            this.biNewAcc.Name = "biNewAcc";
            this.biNewAcc.RibbonWordWrap = false;
            this.biNewAcc.SubItemsExpandWidth = 14;
            this.biNewAcc.Text = "Mở tài khoản";
            this.biNewAcc.Click += new System.EventHandler(this.biNewAcc_Click);
            // 
            // biCloseAcc
            // 
            this.biCloseAcc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biCloseAcc.Image = ((System.Drawing.Image)(resources.GetObject("biCloseAcc.Image")));
            this.biCloseAcc.ImagePaddingHorizontal = 8;
            this.biCloseAcc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biCloseAcc.KeyTips = "C";
            this.biCloseAcc.Name = "biCloseAcc";
            this.biCloseAcc.RibbonWordWrap = false;
            this.biCloseAcc.SubItemsExpandWidth = 14;
            this.biCloseAcc.Text = "Đóng tài khoản";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar5);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(722, 97);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biTypes,
            this.biBanks,
            this.biUsers,
            this.biChangePass});
            this.ribbonBar5.Location = new System.Drawing.Point(64, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(200, 94);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar5.TabIndex = 4;
            this.ribbonBar5.Text = "Hệ thống";
            // 
            // biTypes
            // 
            this.biTypes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biTypes.Image = ((System.Drawing.Image)(resources.GetObject("biTypes.Image")));
            this.biTypes.ImagePaddingHorizontal = 8;
            this.biTypes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biTypes.Name = "biTypes";
            this.biTypes.SubItemsExpandWidth = 14;
            this.biTypes.Text = "&Loại tài khoản";
            this.biTypes.Click += new System.EventHandler(this.biTypes_Click);
            // 
            // biBanks
            // 
            this.biBanks.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biBanks.Image = ((System.Drawing.Image)(resources.GetObject("biBanks.Image")));
            this.biBanks.ImagePaddingHorizontal = 8;
            this.biBanks.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biBanks.Name = "biBanks";
            this.biBanks.RibbonWordWrap = false;
            this.biBanks.SubItemsExpandWidth = 14;
            this.biBanks.Text = "&Ngân hàng";
            this.biBanks.Click += new System.EventHandler(this.biBanks_Click);
            // 
            // biUsers
            // 
            this.biUsers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biUsers.Image = ((System.Drawing.Image)(resources.GetObject("biUsers.Image")));
            this.biUsers.ImagePaddingHorizontal = 8;
            this.biUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biUsers.Name = "biUsers";
            this.biUsers.SubItemsExpandWidth = 14;
            this.biUsers.Text = "&Users";
            this.biUsers.Click += new System.EventHandler(this.biUsers_Click);
            // 
            // biChangePass
            // 
            this.biChangePass.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biChangePass.Image = ((System.Drawing.Image)(resources.GetObject("biChangePass.Image")));
            this.biChangePass.ImagePaddingHorizontal = 8;
            this.biChangePass.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biChangePass.KeyTips = "C";
            this.biChangePass.Name = "biChangePass";
            this.biChangePass.SubItemsExpandWidth = 14;
            this.biChangePass.Text = "Đổi mật khẩu";
            this.biChangePass.Click += new System.EventHandler(this.biChangePass_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biAccs});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(61, 94);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 3;
            this.ribbonBar3.Text = "Tài khoản";
            // 
            // biAccs
            // 
            this.biAccs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biAccs.Image = ((System.Drawing.Image)(resources.GetObject("biAccs.Image")));
            this.biAccs.ImagePaddingHorizontal = 8;
            this.biAccs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.biAccs.Name = "biAccs";
            this.biAccs.SubItemsExpandWidth = 14;
            this.biAccs.Text = "&Tài khoản Giao dịch";
            this.biAccs.Click += new System.EventHandler(this.biAccs_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "&Home";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "&Quản lý";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Image = ((System.Drawing.Image)(resources.GetObject("office2007StartButton1.Image")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemContainer2});
            // 
            // ItemContainer2
            // 
            // 
            // 
            // 
            this.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.ItemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ItemContainer2.MinimumSize = new System.Drawing.Size(200, 0);
            this.ItemContainer2.Name = "ItemContainer2";
            this.ItemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biAbout,
            this.biHelp,
            this.biQAEmu,
            this.biRestart,
            this.biExit});
            // 
            // biAbout
            // 
            this.biAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biAbout.Image = ((System.Drawing.Image)(resources.GetObject("biAbout.Image")));
            this.biAbout.ImagePaddingHorizontal = 15;
            this.biAbout.Name = "biAbout";
            this.biAbout.Text = "&About";
            this.biAbout.Click += new System.EventHandler(this.biAbout_Click);
            // 
            // biHelp
            // 
            this.biHelp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biHelp.Image = ((System.Drawing.Image)(resources.GetObject("biHelp.Image")));
            this.biHelp.ImagePaddingHorizontal = 15;
            this.biHelp.Name = "biHelp";
            this.biHelp.Text = "&Trợ giúp";
            this.biHelp.Click += new System.EventHandler(this.biHelp_Click);
            // 
            // biQAEmu
            // 
            this.biQAEmu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biQAEmu.Image = ((System.Drawing.Image)(resources.GetObject("biQAEmu.Image")));
            this.biQAEmu.ImagePaddingHorizontal = 15;
            this.biQAEmu.Name = "biQAEmu";
            this.biQAEmu.Text = "&Query Analyzer Emulator";
            this.biQAEmu.Click += new System.EventHandler(this.biQAEmu_Click);
            // 
            // biRestart
            // 
            this.biRestart.BeginGroup = true;
            this.biRestart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biRestart.Image = ((System.Drawing.Image)(resources.GetObject("biRestart.Image")));
            this.biRestart.ImagePaddingHorizontal = 15;
            this.biRestart.Name = "biRestart";
            this.biRestart.Text = "&Restart";
            this.biRestart.Click += new System.EventHandler(this.biRestart_Click);
            // 
            // biExit
            // 
            this.biExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.biExit.Image = ((System.Drawing.Image)(resources.GetObject("biExit.Image")));
            this.biExit.ImagePaddingHorizontal = 15;
            this.biExit.Name = "biExit";
            this.biExit.Text = "E&xit";
            this.biExit.Click += new System.EventHandler(this.biExit_Click);
            // 
            // pnClient
            // 
            this.pnClient.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnClient.Controls.Add(this.pictureBox1);
            this.pnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnClient.Location = new System.Drawing.Point(4, 155);
            this.pnClient.Name = "pnClient";
            this.pnClient.Size = new System.Drawing.Size(722, 349);
            // 
            // 
            // 
            this.pnClient.Style.Class = "RibbonClientPanel";
            this.pnClient.TabIndex = 1;
            this.pnClient.Text = "ribbonClientPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.pnClient);
            this.Controls.Add(this.ribbonMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý ngân hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonMain.ResumeLayout(false);
            this.ribbonMain.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.pnClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonMain;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        internal DevComponents.DotNetBar.ItemContainer ItemContainer2;
        internal DevComponents.DotNetBar.ButtonItem biAbout;
        internal DevComponents.DotNetBar.ButtonItem biHelp;
        internal DevComponents.DotNetBar.ButtonItem biQAEmu;
        internal DevComponents.DotNetBar.ButtonItem biRestart;
        internal DevComponents.DotNetBar.ButtonItem biExit;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem biSend;
        private DevComponents.DotNetBar.ButtonItem biWithdraw;
        private DevComponents.DotNetBar.ButtonItem biTransfer;
        private DevComponents.DotNetBar.ButtonItem biNewAcc;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem biNewQAEmu;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem biAccs;
        private DevComponents.DotNetBar.ButtonItem biNewUser;
        private DevComponents.DotNetBar.ButtonItem biViewTrans;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem biTypes;
        private DevComponents.DotNetBar.ButtonItem biBanks;
        private DevComponents.DotNetBar.ButtonItem biUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonItem biChangePass;
        public DevComponents.DotNetBar.Ribbon.RibbonClientPanel pnClient;
        private DevComponents.DotNetBar.ButtonItem biRule;
        private DevComponents.DotNetBar.ButtonItem biCloseAcc;
    }
}

