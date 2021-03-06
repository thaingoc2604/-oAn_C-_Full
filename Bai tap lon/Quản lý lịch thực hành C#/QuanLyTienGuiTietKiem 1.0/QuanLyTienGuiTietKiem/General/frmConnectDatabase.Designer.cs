namespace QuanLyTienGuiTietKiem.General
{
    partial class frmConnectDatabase
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbKetNoi = new System.Windows.Forms.ComboBox();
            this.txtSever = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblServer = new DevComponents.DotNetBar.LabelX();
            this.lblAuthentication = new DevComponents.DotNetBar.LabelX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTest = new DevComponents.DotNetBar.ButtonX();
            this.cmbDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblDatabase = new DevComponents.DotNetBar.LabelX();
            this.btnBrower = new DevComponents.DotNetBar.ButtonX();
            this.txtBrower = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cmbAuthentication = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(193, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Chọn loại kết nối:";
            // 
            // cmbKetNoi
            // 
            this.cmbKetNoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKetNoi.FormattingEnabled = true;
            this.cmbKetNoi.Items.AddRange(new object[] {
            "Microsoft SQL Server (SqlClient)",
            "Microsoft Access Database File (OLE DB)"});
            this.cmbKetNoi.Location = new System.Drawing.Point(300, 25);
            this.cmbKetNoi.Name = "cmbKetNoi";
            this.cmbKetNoi.Size = new System.Drawing.Size(205, 21);
            this.cmbKetNoi.TabIndex = 3;
            this.cmbKetNoi.SelectedIndexChanged += new System.EventHandler(this.cmbKetNoi_SelectedIndexChanged);
            // 
            // txtSever
            // 
            // 
            // 
            // 
            this.txtSever.Border.Class = "TextBoxBorder";
            this.txtSever.Location = new System.Drawing.Point(300, 60);
            this.txtSever.Name = "txtSever";
            this.txtSever.Size = new System.Drawing.Size(205, 20);
            this.txtSever.TabIndex = 4;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(195, 57);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(75, 23);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server: ";
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.Location = new System.Drawing.Point(191, 96);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(92, 20);
            this.lblAuthentication.TabIndex = 6;
            this.lblAuthentication.Text = "Authentication:";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(191, 127);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 23);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Location = new System.Drawing.Point(300, 127);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 20);
            this.txtUserName.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(191, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 26);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Location = new System.Drawing.Point(300, 164);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(193, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTest.Location = new System.Drawing.Point(397, 199);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 27);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test Connection";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DisplayMember = "Text";
            this.cmbDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.ItemHeight = 14;
            this.cmbDatabase.Location = new System.Drawing.Point(300, 241);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(205, 20);
            this.cmbDatabase.TabIndex = 13;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(191, 241);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(75, 23);
            this.lblDatabase.TabIndex = 14;
            this.lblDatabase.Text = "Database:";
            // 
            // btnBrower
            // 
            this.btnBrower.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrower.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrower.Location = new System.Drawing.Point(407, 122);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(98, 25);
            this.btnBrower.TabIndex = 15;
            this.btnBrower.Text = "Brower";
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtBrower
            // 
            // 
            // 
            // 
            this.txtBrower.Border.Class = "TextBoxBorder";
            this.txtBrower.Location = new System.Drawing.Point(185, 122);
            this.txtBrower.Multiline = true;
            this.txtBrower.Name = "txtBrower";
            this.txtBrower.Size = new System.Drawing.Size(216, 25);
            this.txtBrower.TabIndex = 16;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(257, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Chấp nhận";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(397, 289);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Location = new System.Drawing.Point(191, 278);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(324, 1);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 18;
            // 
            // cmbAuthentication
            // 
            this.cmbAuthentication.FormattingEnabled = true;
            this.cmbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cmbAuthentication.Location = new System.Drawing.Point(300, 95);
            this.cmbAuthentication.Name = "cmbAuthentication";
            this.cmbAuthentication.Size = new System.Drawing.Size(205, 21);
            this.cmbAuthentication.TabIndex = 19;
            // 
            // frmConnectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 324);
            this.Controls.Add(this.cmbAuthentication);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBrower);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtSever);
            this.Controls.Add(this.cmbKetNoi);
            this.Controls.Add(this.labelX2);
            this.Name = "frmConnectDatabase";
            this.Text = "KẾT NỐI DỮ LIỆU";
            this.Load += new System.EventHandler(this.frmConnectDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cmbKetNoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSever;
        private DevComponents.DotNetBar.LabelX lblServer;
        private DevComponents.DotNetBar.LabelX lblAuthentication;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private DevComponents.DotNetBar.ButtonX btnTest;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDatabase;
        private DevComponents.DotNetBar.LabelX lblDatabase;
        private DevComponents.DotNetBar.ButtonX btnBrower;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBrower;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ComboBox cmbAuthentication;
    }
}