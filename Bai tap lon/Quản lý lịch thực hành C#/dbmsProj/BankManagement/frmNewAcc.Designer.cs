namespace BankManagement
{
    partial class frmNewAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAcc));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cldOpenDate = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.cboAccTypes = new Janus.Windows.EditControls.UIComboBox();
            this.cboBanks = new Janus.Windows.EditControls.UIComboBox();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtID = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtEmail = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPhone = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtNote = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtMoney = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.SuspendLayout();
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
            this.PanelEx4.TabIndex = 9;
            this.PanelEx4.Text = "Mở tài khoản";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(435, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(346, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.Tooltip = "Mở tài khoản";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(280, 117);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(52, 14);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Số CMND:";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(12, 117);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(39, 14);
            this.LabelX1.TabIndex = 27;
            this.LabelX1.Text = "Họ tên:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(12, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 14);
            this.labelX2.TabIndex = 30;
            this.labelX2.Text = "Loại tài khoản:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(11, 181);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 14);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(12, 144);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 14);
            this.labelX4.TabIndex = 32;
            this.labelX4.Text = "Điện thoại:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Location = new System.Drawing.Point(280, 144);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(33, 14);
            this.labelX6.TabIndex = 32;
            this.labelX6.Text = "Email:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.Location = new System.Drawing.Point(280, 63);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(59, 14);
            this.labelX7.TabIndex = 30;
            this.labelX7.Text = "Ngân hàng:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(12, 90);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(50, 14);
            this.labelX8.TabIndex = 30;
            this.labelX8.Text = "Ngày mở:";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(280, 90);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(59, 14);
            this.labelX9.TabIndex = 30;
            this.labelX9.Text = "Số tiền gửi:";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(11, 227);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(43, 14);
            this.labelX10.TabIndex = 30;
            this.labelX10.Text = "Ghi chú:";
            // 
            // cldOpenDate
            // 
            // 
            // 
            // 
            this.cldOpenDate.DropDownCalendar.Name = "";
            this.cldOpenDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.cldOpenDate.Location = new System.Drawing.Point(92, 87);
            this.cldOpenDate.Name = "cldOpenDate";
            this.cldOpenDate.Size = new System.Drawing.Size(165, 21);
            this.cldOpenDate.TabIndex = 2;
            this.cldOpenDate.Value = new System.DateTime(2007, 10, 30, 0, 0, 0, 0);
            this.cldOpenDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // cboAccTypes
            // 
            this.cboAccTypes.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboAccTypes.Location = new System.Drawing.Point(92, 60);
            this.cboAccTypes.Name = "cboAccTypes";
            this.cboAccTypes.Size = new System.Drawing.Size(165, 21);
            this.cboAccTypes.TabIndex = 0;
            this.cboAccTypes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cboBanks
            // 
            this.cboBanks.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboBanks.Location = new System.Drawing.Point(345, 60);
            this.cboBanks.Name = "cboBanks";
            this.cboBanks.Size = new System.Drawing.Size(165, 21);
            this.cboBanks.TabIndex = 1;
            this.cboBanks.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 114);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 4;
            this.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(345, 114);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 21);
            this.txtID.TabIndex = 5;
            this.txtID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 141);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 21);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 141);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 21);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 168);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(418, 40);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(91, 214);
            this.txtNote.MaxLength = 255;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(419, 40);
            this.txtNote.TabIndex = 9;
            this.txtNote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMoney
            // 
            this.txtMoney.DecimalDigits = 0;
            this.txtMoney.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMoney.Location = new System.Drawing.Point(345, 87);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(165, 21);
            this.txtMoney.TabIndex = 3;
            this.txtMoney.Text = "$0";
            this.txtMoney.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMoney.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmNewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 318);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboBanks);
            this.Controls.Add(this.cboAccTypes);
            this.Controls.Add(this.cldOpenDate);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewAcc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmNewAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnOK;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX6;
        internal DevComponents.DotNetBar.LabelX labelX7;
        internal DevComponents.DotNetBar.LabelX labelX8;
        internal DevComponents.DotNetBar.LabelX labelX9;
        internal DevComponents.DotNetBar.LabelX labelX10;
        private Janus.Windows.CalendarCombo.CalendarCombo cldOpenDate;
        private Janus.Windows.EditControls.UIComboBox cboAccTypes;
        private Janus.Windows.EditControls.UIComboBox cboBanks;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private Janus.Windows.GridEX.EditControls.EditBox txtID;
        private Janus.Windows.GridEX.EditControls.EditBox txtEmail;
        private Janus.Windows.GridEX.EditControls.EditBox txtPhone;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddress;
        private Janus.Windows.GridEX.EditControls.EditBox txtNote;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMoney;
    }
}