namespace BankManagement
{
    partial class frmSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSend));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.txtEmail = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtID = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtNote = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPhone = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMoney = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.cldSendDate = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtAccNo = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(526, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 6;
            this.PanelEx4.Text = "Gửi tiền";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(344, 133);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 21);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(344, 106);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 21);
            this.txtID.TabIndex = 4;
            this.txtID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(91, 206);
            this.txtNote.MaxLength = 255;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(418, 40);
            this.txtNote.TabIndex = 8;
            this.txtNote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 160);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(418, 40);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 133);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 21);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 106);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 3;
            this.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Location = new System.Drawing.Point(279, 136);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(33, 14);
            this.labelX6.TabIndex = 43;
            this.labelX6.Text = "Email:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(11, 136);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 14);
            this.labelX4.TabIndex = 44;
            this.labelX4.Text = "Điện thoại:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(10, 173);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 14);
            this.labelX3.TabIndex = 42;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(10, 219);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(43, 14);
            this.labelX10.TabIndex = 41;
            this.labelX10.Text = "Ghi chú:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(279, 109);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(52, 14);
            this.labelX5.TabIndex = 40;
            this.labelX5.Text = "Số CMND:";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(11, 109);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(39, 14);
            this.LabelX1.TabIndex = 39;
            this.LabelX1.Text = "Họ tên:";
            // 
            // txtMoney
            // 
            this.txtMoney.DecimalDigits = 0;
            this.txtMoney.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMoney.Location = new System.Drawing.Point(344, 79);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(165, 21);
            this.txtMoney.TabIndex = 2;
            this.txtMoney.Text = "$0";
            this.txtMoney.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMoney.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cldSendDate
            // 
            // 
            // 
            // 
            this.cldSendDate.DropDownCalendar.Name = "";
            this.cldSendDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.cldSendDate.Location = new System.Drawing.Point(91, 79);
            this.cldSendDate.Name = "cldSendDate";
            this.cldSendDate.Size = new System.Drawing.Size(165, 21);
            this.cldSendDate.TabIndex = 1;
            this.cldSendDate.Value = new System.DateTime(2007, 10, 30, 0, 0, 0, 0);
            this.cldSendDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(279, 82);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(59, 14);
            this.labelX9.TabIndex = 48;
            this.labelX9.Text = "Số tiền gửi:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(11, 82);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 14);
            this.labelX8.TabIndex = 47;
            this.labelX8.Text = "Ngày gửi:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(12, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 14);
            this.labelX2.TabIndex = 48;
            this.labelX2.Text = "Số tài khoản:";
            // 
            // txtAccNo
            // 
            this.txtAccNo.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
            this.txtAccNo.ButtonText = ">";
            this.txtAccNo.Location = new System.Drawing.Point(91, 52);
            this.txtAccNo.MaxLength = 10;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(165, 21);
            this.txtAccNo.TabIndex = 0;
            this.txtAccNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtAccNo.ButtonClick += new System.EventHandler(this.txtAccNo_ButtonClick);
            this.txtAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccNo_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(434, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(353, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cldSendDate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSend";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        private Janus.Windows.GridEX.EditControls.EditBox txtEmail;
        private Janus.Windows.GridEX.EditControls.EditBox txtID;
        private Janus.Windows.GridEX.EditControls.EditBox txtNote;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddress;
        private Janus.Windows.GridEX.EditControls.EditBox txtPhone;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        internal DevComponents.DotNetBar.LabelX labelX6;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX10;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMoney;
        private Janus.Windows.CalendarCombo.CalendarCombo cldSendDate;
        internal DevComponents.DotNetBar.LabelX labelX9;
        internal DevComponents.DotNetBar.LabelX labelX8;
        internal DevComponents.DotNetBar.LabelX labelX2;
        private Janus.Windows.GridEX.EditControls.EditBox txtAccNo;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnOK;
    }
}