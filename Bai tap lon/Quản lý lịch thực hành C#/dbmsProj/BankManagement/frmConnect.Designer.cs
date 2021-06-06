namespace BankManagement
{
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnConnect = new DevComponents.DotNetBar.ButtonX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkIntegrated = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkStartService = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDatabase = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(348, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 7;
            this.PanelEx4.Text = "Connection Info";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(256, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(161, 261);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Location = new System.Drawing.Point(161, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "Password";
            // 
            // txtUID
            // 
            // 
            // 
            // 
            this.txtUID.Border.Class = "TextBoxBorder";
            this.txtUID.Location = new System.Drawing.Point(161, 169);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(170, 21);
            this.txtUID.TabIndex = 2;
            this.txtUID.WatermarkText = "Login name";
            // 
            // chkIntegrated
            // 
            this.chkIntegrated.AutoSize = true;
            this.chkIntegrated.Location = new System.Drawing.Point(158, 229);
            this.chkIntegrated.Name = "chkIntegrated";
            this.chkIntegrated.Size = new System.Drawing.Size(115, 16);
            this.chkIntegrated.TabIndex = 4;
            this.chkIntegrated.Text = "Integrated Security";
            this.chkIntegrated.CheckedChanged += new System.EventHandler(this.chkIntegrated_CheckedChanged);
            // 
            // chkStartService
            // 
            this.chkStartService.AutoSize = true;
            this.chkStartService.Location = new System.Drawing.Point(157, 113);
            this.chkStartService.Name = "chkStartService";
            this.chkStartService.Size = new System.Drawing.Size(174, 16);
            this.chkStartService.TabIndex = 18;
            this.chkStartService.Text = "Start SQL Server if it is stopped";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 59);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // LabelX3
            // 
            this.LabelX3.AutoSize = true;
            this.LabelX3.Location = new System.Drawing.Point(73, 199);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(52, 14);
            this.LabelX3.TabIndex = 23;
            this.LabelX3.Text = "Password:";
            // 
            // LabelX4
            // 
            this.LabelX4.AutoSize = true;
            this.LabelX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX4.Location = new System.Drawing.Point(12, 146);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(99, 16);
            this.LabelX4.TabIndex = 21;
            this.LabelX4.Text = "Authentication";
            // 
            // LabelX2
            // 
            this.LabelX2.AutoSize = true;
            this.LabelX2.Location = new System.Drawing.Point(73, 172);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(63, 14);
            this.LabelX2.TabIndex = 22;
            this.LabelX2.Text = "Login name:";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(95, 62);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(60, 14);
            this.LabelX1.TabIndex = 20;
            this.LabelX1.Text = "SQL Server:";
            // 
            // txtDatabase
            // 
            // 
            // 
            // 
            this.txtDatabase.Border.Class = "TextBoxBorder";
            this.txtDatabase.Location = new System.Drawing.Point(161, 85);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(170, 21);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.WatermarkText = "Database";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(95, 88);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(52, 14);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "Database:";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Location = new System.Drawing.Point(161, 59);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(170, 21);
            this.txtServer.TabIndex = 0;
            this.txtServer.WatermarkText = "Server";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 310);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.PanelEx4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.chkIntegrated);
            this.Controls.Add(this.chkStartService);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LabelX3);
            this.Controls.Add(this.LabelX4);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.LabelX1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to SQL Server";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnConnect;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtUID;
        internal DevComponents.DotNetBar.Controls.CheckBoxX chkIntegrated;
        internal DevComponents.DotNetBar.Controls.CheckBoxX chkStartService;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal DevComponents.DotNetBar.LabelX LabelX3;
        internal DevComponents.DotNetBar.LabelX LabelX4;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDatabase;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtServer;
    }
}