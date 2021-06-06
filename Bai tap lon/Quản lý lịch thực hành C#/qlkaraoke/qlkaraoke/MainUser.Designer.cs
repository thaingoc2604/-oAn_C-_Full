namespace qlkaraoke
{
    partial class fMainUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainUser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fMainUserListView1 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.fMainUserBtnView = new System.Windows.Forms.Button();
            this.fMainUserBtnStart = new System.Windows.Forms.Button();
            this.fMainUserBtnClose = new System.Windows.Forms.Button();
            this.fMainUseStatus = new System.Windows.Forms.StatusStrip();
            this.fMainUseStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fMainUseStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fMainUseStatus3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fMainUseUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.fMainUseMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.fMainUseDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.roomTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            this.billsTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.BillsTableAdapter();
            this.messageTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.MessageTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.fMainUseStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRoomToolStripMenuItem1,
            this.paymentToolStripMenuItem1,
            this.promotionToolStripMenuItem,
            this.printOrderToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.serviceToolStripMenuItem.Text = "Services";
            // 
            // viewRoomToolStripMenuItem1
            // 
            this.viewRoomToolStripMenuItem1.Name = "viewRoomToolStripMenuItem1";
            this.viewRoomToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.viewRoomToolStripMenuItem1.Text = "View room";
            this.viewRoomToolStripMenuItem1.Click += new System.EventHandler(this.viewRoomToolStripMenuItem1_Click);
            // 
            // paymentToolStripMenuItem1
            // 
            this.paymentToolStripMenuItem1.Name = "paymentToolStripMenuItem1";
            this.paymentToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.paymentToolStripMenuItem1.Text = "Payment";
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.promotionToolStripMenuItem.Text = "Promotion";
            // 
            // printOrderToolStripMenuItem
            // 
            this.printOrderToolStripMenuItem.Name = "printOrderToolStripMenuItem";
            this.printOrderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.printOrderToolStripMenuItem.Text = "Print order";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chageRoomToolStripMenuItem,
            this.reserveRoomToolStripMenuItem,
            this.leaveFormToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // chageRoomToolStripMenuItem
            // 
            this.chageRoomToolStripMenuItem.Name = "chageRoomToolStripMenuItem";
            this.chageRoomToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.chageRoomToolStripMenuItem.Text = "Chage room";
            this.chageRoomToolStripMenuItem.Click += new System.EventHandler(this.chageRoomToolStripMenuItem_Click);
            // 
            // reserveRoomToolStripMenuItem
            // 
            this.reserveRoomToolStripMenuItem.Name = "reserveRoomToolStripMenuItem";
            this.reserveRoomToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.reserveRoomToolStripMenuItem.Text = "Reserve room";
            this.reserveRoomToolStripMenuItem.Click += new System.EventHandler(this.reserveRoomToolStripMenuItem_Click);
            // 
            // leaveFormToolStripMenuItem
            // 
            this.leaveFormToolStripMenuItem.Name = "leaveFormToolStripMenuItem";
            this.leaveFormToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.leaveFormToolStripMenuItem.Text = "Leave form";
            this.leaveFormToolStripMenuItem.Click += new System.EventHandler(this.leaveFormToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportsToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportsToolStripMenuItem
            // 
            this.supportsToolStripMenuItem.Name = "supportsToolStripMenuItem";
            this.supportsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supportsToolStripMenuItem.Text = "Check for updates";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // fiToolStripMenuItem
            // 
            this.fiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            this.fiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fiToolStripMenuItem.Text = "File";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.lToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRoomToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.printToolStripMenuItem,
            this.prToolStripMenuItem,
            this.addItemsToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.servicesToolStripMenuItem.Text = "Service";
            // 
            // viewRoomToolStripMenuItem
            // 
            this.viewRoomToolStripMenuItem.Name = "viewRoomToolStripMenuItem";
            this.viewRoomToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewRoomToolStripMenuItem.Text = "View Room";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.printToolStripMenuItem.Text = "Print Order";
            // 
            // prToolStripMenuItem
            // 
            this.prToolStripMenuItem.Name = "prToolStripMenuItem";
            this.prToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.prToolStripMenuItem.Text = "Promotion";
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addItemsToolStripMenuItem.Text = "Add Dishes";
            // 
            // toosToolStripMenuItem
            // 
            this.toosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histToolStripMenuItem,
            this.bookRoomToolStripMenuItem,
            this.changeRoomToolStripMenuItem});
            this.toosToolStripMenuItem.Name = "toosToolStripMenuItem";
            this.toosToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.toosToolStripMenuItem.Text = "Tool";
            // 
            // histToolStripMenuItem
            // 
            this.histToolStripMenuItem.Name = "histToolStripMenuItem";
            this.histToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.histToolStripMenuItem.Text = "History";
            // 
            // bookRoomToolStripMenuItem
            // 
            this.bookRoomToolStripMenuItem.Name = "bookRoomToolStripMenuItem";
            this.bookRoomToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.bookRoomToolStripMenuItem.Text = "Book Room";
            // 
            // changeRoomToolStripMenuItem
            // 
            this.changeRoomToolStripMenuItem.Name = "changeRoomToolStripMenuItem";
            this.changeRoomToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changeRoomToolStripMenuItem.Text = "Change Room";
            // 
            // hepToolStripMenuItem
            // 
            this.hepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hepToolStripMenuItem1,
            this.abutToolStripMenuItem});
            this.hepToolStripMenuItem.Name = "hepToolStripMenuItem";
            this.hepToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.hepToolStripMenuItem.Text = "Hep";
            // 
            // hepToolStripMenuItem1
            // 
            this.hepToolStripMenuItem1.Name = "hepToolStripMenuItem1";
            this.hepToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.hepToolStripMenuItem1.Text = "Hep";
            // 
            // abutToolStripMenuItem
            // 
            this.abutToolStripMenuItem.Name = "abutToolStripMenuItem";
            this.abutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.abutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.fMainUserListView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room";
            // 
            // fMainUserListView1
            // 
            this.fMainUserListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMainUserListView1.LargeImageList = this.imageList2;
            this.fMainUserListView1.Location = new System.Drawing.Point(3, 16);
            this.fMainUserListView1.MultiSelect = false;
            this.fMainUserListView1.Name = "fMainUserListView1";
            this.fMainUserListView1.ShowItemToolTips = true;
            this.fMainUserListView1.Size = new System.Drawing.Size(546, 322);
            this.fMainUserListView1.TabIndex = 0;
            this.fMainUserListView1.UseCompatibleStateImageBehavior = false;
            this.fMainUserListView1.DoubleClick += new System.EventHandler(this.fMainUserListView1_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ChatRoom.gif");
            this.imageList2.Images.SetKeyName(1, "icon-room.gif");
            // 
            // fMainUserBtnView
            // 
            this.fMainUserBtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fMainUserBtnView.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMainUserBtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMainUserBtnView.Location = new System.Drawing.Point(151, 431);
            this.fMainUserBtnView.Name = "fMainUserBtnView";
            this.fMainUserBtnView.Size = new System.Drawing.Size(87, 39);
            this.fMainUserBtnView.TabIndex = 5;
            this.fMainUserBtnView.Text = "View";
            this.fMainUserBtnView.UseVisualStyleBackColor = true;
            this.fMainUserBtnView.MouseLeave += new System.EventHandler(this.fMainUserBtnView_MouseLeave);
            this.fMainUserBtnView.Click += new System.EventHandler(this.fMainUserBtnView_Click);
            this.fMainUserBtnView.MouseEnter += new System.EventHandler(this.fMainUserBtnView_MouseEnter);
            // 
            // fMainUserBtnStart
            // 
            this.fMainUserBtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fMainUserBtnStart.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMainUserBtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMainUserBtnStart.Location = new System.Drawing.Point(244, 431);
            this.fMainUserBtnStart.Name = "fMainUserBtnStart";
            this.fMainUserBtnStart.Size = new System.Drawing.Size(87, 39);
            this.fMainUserBtnStart.TabIndex = 6;
            this.fMainUserBtnStart.Text = "Start";
            this.fMainUserBtnStart.UseVisualStyleBackColor = true;
            this.fMainUserBtnStart.MouseLeave += new System.EventHandler(this.fMainUserBtnStart_MouseLeave);
            this.fMainUserBtnStart.Click += new System.EventHandler(this.fMainUserBtnStart_Click);
            this.fMainUserBtnStart.MouseEnter += new System.EventHandler(this.fMainUserBtnStart_MouseEnter);
            // 
            // fMainUserBtnClose
            // 
            this.fMainUserBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fMainUserBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMainUserBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMainUserBtnClose.Location = new System.Drawing.Point(337, 431);
            this.fMainUserBtnClose.Name = "fMainUserBtnClose";
            this.fMainUserBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fMainUserBtnClose.TabIndex = 7;
            this.fMainUserBtnClose.Text = "Exit";
            this.fMainUserBtnClose.UseVisualStyleBackColor = true;
            this.fMainUserBtnClose.MouseLeave += new System.EventHandler(this.fMainUserBtnClose_MouseLeave);
            this.fMainUserBtnClose.Click += new System.EventHandler(this.fMainUserBtnClose_Click);
            this.fMainUserBtnClose.MouseEnter += new System.EventHandler(this.fMainUserBtnClose_MouseEnter);
            // 
            // fMainUseStatus
            // 
            this.fMainUseStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fMainUseStatus1,
            this.fMainUseStatus2,
            this.fMainUseStatus3});
            this.fMainUseStatus.Location = new System.Drawing.Point(0, 477);
            this.fMainUseStatus.Name = "fMainUseStatus";
            this.fMainUseStatus.Size = new System.Drawing.Size(574, 22);
            this.fMainUseStatus.TabIndex = 9;
            // 
            // fMainUseStatus1
            // 
            this.fMainUseStatus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseStatus1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fMainUseStatus1.Name = "fMainUseStatus1";
            this.fMainUseStatus1.Size = new System.Drawing.Size(0, 17);
            this.fMainUseStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fMainUseStatus2
            // 
            this.fMainUseStatus2.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.fMainUseStatus2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseStatus2.Name = "fMainUseStatus2";
            this.fMainUseStatus2.Size = new System.Drawing.Size(559, 17);
            this.fMainUseStatus2.Spring = true;
            this.fMainUseStatus2.Click += new System.EventHandler(this.fMainUseStatus2_Click);
            // 
            // fMainUseStatus3
            // 
            this.fMainUseStatus3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseStatus3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fMainUseStatus3.Name = "fMainUseStatus3";
            this.fMainUseStatus3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fMainUseStatus3.Size = new System.Drawing.Size(0, 17);
            this.fMainUseStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fMainUseUserName
            // 
            this.fMainUseUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fMainUseUserName.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.fMainUseUserName.Name = "fMainUseUserName";
            this.fMainUseUserName.Size = new System.Drawing.Size(58, 17);
            this.fMainUseUserName.Text = "User name";
            this.fMainUseUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fMainUseMessage
            // 
            this.fMainUseMessage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fMainUseMessage.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.fMainUseMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseMessage.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.fMainUseMessage.Name = "fMainUseMessage";
            this.fMainUseMessage.Size = new System.Drawing.Size(471, 17);
            this.fMainUseMessage.Spring = true;
            this.fMainUseMessage.Text = "Message";
            // 
            // fMainUseDate
            // 
            this.fMainUseDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fMainUseDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fMainUseDate.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.fMainUseDate.Name = "fMainUseDate";
            this.fMainUseDate.Size = new System.Drawing.Size(30, 17);
            this.fMainUseDate.Text = "Date";
            this.fMainUseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(59, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(515, 23);
            this.label25.TabIndex = 12;
            this.label25.Text = "MAIN USER";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // billsTableAdapter1
            // 
            this.billsTableAdapter1.ClearBeforeFill = true;
            // 
            // messageTableAdapter1
            // 
            this.messageTableAdapter1.ClearBeforeFill = true;
            // 
            // fMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(574, 499);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fMainUseStatus);
            this.Controls.Add(this.fMainUserBtnClose);
            this.Controls.Add(this.fMainUserBtnStart);
            this.Controls.Add(this.fMainUserBtnView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL KARAOKE - Main User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMainUser_FormClosed);
            this.Load += new System.EventHandler(this.fMainUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.fMainUseStatus.ResumeLayout(false);
            this.fMainUseStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fMainUserBtnView;
        private System.Windows.Forms.Button fMainUserBtnStart;
        private System.Windows.Forms.Button fMainUserBtnClose;
        private System.Windows.Forms.StatusStrip fMainUseStatus;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseUserName;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseMessage;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseDate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter roomTableAdapter1;
        private System.Windows.Forms.ListView fMainUserListView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private qlkaraoke.DataSet1TableAdapters.BillsTableAdapter billsTableAdapter1;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseStatus1;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseStatus2;
        private System.Windows.Forms.ToolStripStatusLabel fMainUseStatus3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private qlkaraoke.DataSet1TableAdapters.MessageTableAdapter messageTableAdapter1;
    }
}