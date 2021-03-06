namespace BankManagement
{
    partial class frmWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdraw));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.txtMoney = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.cldWithdrawDate = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtAccNo = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtNote = new Janus.Windows.GridEX.EditControls.EditBox();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtPin = new Janus.Windows.GridEX.EditControls.EditBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.jsp = new Janus.Windows.Common.JanusSuperTip(this.components);
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(530, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 7;
            this.PanelEx4.Text = "Rút tiền";
            // 
            // txtMoney
            // 
            this.txtMoney.DecimalDigits = 0;
            this.txtMoney.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMoney.Location = new System.Drawing.Point(344, 82);
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
            // cldWithdrawDate
            // 
            // 
            // 
            // 
            this.cldWithdrawDate.DropDownCalendar.Name = "";
            this.cldWithdrawDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.cldWithdrawDate.Location = new System.Drawing.Point(91, 82);
            this.cldWithdrawDate.Name = "cldWithdrawDate";
            this.cldWithdrawDate.Size = new System.Drawing.Size(165, 21);
            this.cldWithdrawDate.TabIndex = 2;
            this.cldWithdrawDate.Value = new System.DateTime(2007, 10, 30, 0, 0, 0, 0);
            this.cldWithdrawDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(12, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 14);
            this.labelX2.TabIndex = 53;
            this.labelX2.Text = "Số tài khoản:";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(279, 85);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(57, 14);
            this.labelX9.TabIndex = 54;
            this.labelX9.Text = "Số tiền rút:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(11, 85);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(48, 14);
            this.labelX8.TabIndex = 52;
            this.labelX8.Text = "Ngày rút:";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(91, 55);
            this.txtAccNo.MaxLength = 10;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(165, 21);
            this.txtAccNo.TabIndex = 0;
            this.txtAccNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(434, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(353, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(91, 109);
            this.txtNote.MaxLength = 255;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(418, 40);
            this.txtNote.TabIndex = 4;
            this.txtNote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(10, 122);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(43, 14);
            this.labelX10.TabIndex = 58;
            this.labelX10.Text = "Ghi chú:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(344, 55);
            this.txtPin.MaxLength = 10;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(165, 21);
            this.txtPin.TabIndex = 1;
            this.txtPin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(279, 58);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(24, 14);
            this.labelX1.TabIndex = 53;
            this.labelX1.Text = "PIN:";
            // 
            // jsp
            // 
            this.jsp.AutoPopDelay = 2000;
            this.jsp.ImageList = null;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cldWithdrawDate);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWithdraw";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMoney;
        private Janus.Windows.CalendarCombo.CalendarCombo cldWithdrawDate;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX9;
        internal DevComponents.DotNetBar.LabelX labelX8;
        private Janus.Windows.GridEX.EditControls.EditBox txtAccNo;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnOK;
        private Janus.Windows.GridEX.EditControls.EditBox txtNote;
        internal DevComponents.DotNetBar.LabelX labelX10;
        private Janus.Windows.GridEX.EditControls.EditBox txtPin;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private Janus.Windows.Common.JanusSuperTip jsp;
    }
}