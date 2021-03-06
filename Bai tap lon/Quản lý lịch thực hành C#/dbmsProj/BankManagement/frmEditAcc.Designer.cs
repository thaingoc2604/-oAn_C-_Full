namespace BankManagement
{
    partial class frmEditAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAcc));
            this.txtMoney = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtEmail = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtID = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtNote = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPhone = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cboBanks = new Janus.Windows.EditControls.UIComboBox();
            this.cboAccTypes = new Janus.Windows.EditControls.UIComboBox();
            this.cldOpenDate = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cldExpired = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtAccNo = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPIN = new Janus.Windows.GridEX.EditControls.EditBox();
            this.chkIsClosed = new Janus.Windows.EditControls.UICheckBox();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.DecimalDigits = 0;
            this.txtMoney.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMoney.Location = new System.Drawing.Point(350, 109);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(165, 21);
            this.txtMoney.TabIndex = 36;
            this.txtMoney.Text = "$0";
            this.txtMoney.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMoney.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(350, 163);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 21);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(350, 136);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 21);
            this.txtID.TabIndex = 1;
            this.txtID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(97, 263);
            this.txtNote.MaxLength = 255;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(418, 40);
            this.txtNote.TabIndex = 5;
            this.txtNote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 217);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(418, 40);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 163);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 21);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 136);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 0;
            this.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cboBanks
            // 
            this.cboBanks.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboBanks.Location = new System.Drawing.Point(350, 82);
            this.cboBanks.Name = "cboBanks";
            this.cboBanks.ReadOnly = true;
            this.cboBanks.Size = new System.Drawing.Size(165, 21);
            this.cboBanks.TabIndex = 34;
            this.cboBanks.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cboAccTypes
            // 
            this.cboAccTypes.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboAccTypes.Location = new System.Drawing.Point(97, 82);
            this.cboAccTypes.Name = "cboAccTypes";
            this.cboAccTypes.ReadOnly = true;
            this.cboAccTypes.Size = new System.Drawing.Size(165, 21);
            this.cboAccTypes.TabIndex = 33;
            this.cboAccTypes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cldOpenDate
            // 
            // 
            // 
            // 
            this.cldOpenDate.DropDownCalendar.Name = "";
            this.cldOpenDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.cldOpenDate.Location = new System.Drawing.Point(97, 109);
            this.cldOpenDate.Name = "cldOpenDate";
            this.cldOpenDate.ReadOnly = true;
            this.cldOpenDate.Size = new System.Drawing.Size(165, 21);
            this.cldOpenDate.TabIndex = 35;
            this.cldOpenDate.Value = new System.DateTime(2007, 10, 30, 0, 0, 0, 0);
            this.cldOpenDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Location = new System.Drawing.Point(285, 166);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(33, 14);
            this.labelX6.TabIndex = 54;
            this.labelX6.Text = "Email:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(17, 166);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 14);
            this.labelX4.TabIndex = 55;
            this.labelX4.Text = "Điện thoại:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(17, 230);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 14);
            this.labelX3.TabIndex = 53;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(17, 276);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(43, 14);
            this.labelX10.TabIndex = 50;
            this.labelX10.Text = "Ghi chú:";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(285, 112);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(35, 14);
            this.labelX9.TabIndex = 51;
            this.labelX9.Text = "Số dư:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(17, 112);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 14);
            this.labelX8.TabIndex = 52;
            this.labelX8.Text = "Ngày mở:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.Location = new System.Drawing.Point(285, 85);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(59, 14);
            this.labelX7.TabIndex = 49;
            this.labelX7.Text = "Ngân hàng:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(17, 85);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 14);
            this.labelX2.TabIndex = 48;
            this.labelX2.Text = "Loại tài khoản:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(285, 139);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(52, 14);
            this.labelX5.TabIndex = 47;
            this.labelX5.Text = "Số CMND:";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(17, 139);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(39, 14);
            this.LabelX1.TabIndex = 46;
            this.LabelX1.Text = "Họ tên:";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(440, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(351, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Tooltip = "Lưu thông tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(527, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 42;
            this.PanelEx4.Text = "Chỉnh sửa tài khoản";
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.Location = new System.Drawing.Point(17, 193);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(74, 14);
            this.labelX11.TabIndex = 52;
            this.labelX11.Text = "Ngày đáo hạn:";
            // 
            // cldExpired
            // 
            // 
            // 
            // 
            this.cldExpired.DropDownCalendar.Name = "";
            this.cldExpired.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.cldExpired.Location = new System.Drawing.Point(97, 190);
            this.cldExpired.Name = "cldExpired";
            this.cldExpired.Nullable = true;
            this.cldExpired.ReadOnly = true;
            this.cldExpired.Size = new System.Drawing.Size(165, 21);
            this.cldExpired.TabIndex = 35;
            this.cldExpired.Value = new System.DateTime(2007, 10, 30, 0, 0, 0, 0);
            this.cldExpired.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.Location = new System.Drawing.Point(17, 58);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(67, 14);
            this.labelX12.TabIndex = 48;
            this.labelX12.Text = "Số tài khoản:";
            // 
            // labelX13
            // 
            this.labelX13.AutoSize = true;
            this.labelX13.Location = new System.Drawing.Point(285, 58);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(39, 14);
            this.labelX13.TabIndex = 49;
            this.labelX13.Text = "Số PIN:";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(97, 55);
            this.txtAccNo.MaxLength = 10;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.ReadOnly = true;
            this.txtAccNo.Size = new System.Drawing.Size(165, 21);
            this.txtAccNo.TabIndex = 37;
            this.txtAccNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(350, 55);
            this.txtPIN.MaxLength = 10;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(165, 21);
            this.txtPIN.TabIndex = 38;
            this.txtPIN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsClosed
            // 
            this.chkIsClosed.Enabled = false;
            this.chkIsClosed.Location = new System.Drawing.Point(351, 190);
            this.chkIsClosed.Name = "chkIsClosed";
            this.chkIsClosed.Size = new System.Drawing.Size(161, 21);
            this.chkIsClosed.TabIndex = 56;
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            this.labelX14.Location = new System.Drawing.Point(285, 193);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(48, 14);
            this.labelX14.TabIndex = 54;
            this.labelX14.Text = "Đã đóng:";
            // 
            // frmEditAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 361);
            this.Controls.Add(this.chkIsClosed);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboBanks);
            this.Controls.Add(this.cboAccTypes);
            this.Controls.Add(this.cldExpired);
            this.Controls.Add(this.cldOpenDate);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditAcc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmEditAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMoney;
        private Janus.Windows.GridEX.EditControls.EditBox txtEmail;
        private Janus.Windows.GridEX.EditControls.EditBox txtID;
        private Janus.Windows.GridEX.EditControls.EditBox txtNote;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddress;
        private Janus.Windows.GridEX.EditControls.EditBox txtPhone;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private Janus.Windows.EditControls.UIComboBox cboBanks;
        private Janus.Windows.EditControls.UIComboBox cboAccTypes;
        private Janus.Windows.CalendarCombo.CalendarCombo cldOpenDate;
        internal DevComponents.DotNetBar.LabelX labelX6;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX10;
        internal DevComponents.DotNetBar.LabelX labelX9;
        internal DevComponents.DotNetBar.LabelX labelX8;
        internal DevComponents.DotNetBar.LabelX labelX7;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.ButtonX btnClose;
        internal DevComponents.DotNetBar.ButtonX btnSave;
        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        internal DevComponents.DotNetBar.LabelX labelX11;
        private Janus.Windows.CalendarCombo.CalendarCombo cldExpired;
        internal DevComponents.DotNetBar.LabelX labelX12;
        internal DevComponents.DotNetBar.LabelX labelX13;
        private Janus.Windows.GridEX.EditControls.EditBox txtAccNo;
        private Janus.Windows.GridEX.EditControls.EditBox txtPIN;
        private Janus.Windows.EditControls.UICheckBox chkIsClosed;
        internal DevComponents.DotNetBar.LabelX labelX14;
    }
}