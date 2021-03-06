namespace BankManagement
{
    partial class frmRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRule));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMinMoney = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtTransDays = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtOtherBank = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtSameBank = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMinWithdrawTran = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtMaxWithdrawTran = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtMaxTimeWithdrawDay = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.txtMaxWithdrawDay = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtMinSend = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(504, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 5;
            this.PanelEx4.Text = "Thay đổi quy định";
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(8, 7);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(78, 14);
            this.labelX12.TabIndex = 49;
            this.labelX12.Text = "Số dư tối thiểu:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(8, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 14);
            this.labelX1.TabIndex = 49;
            this.labelX1.Text = "Gửi tối thiểu:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(251, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(119, 14);
            this.labelX2.TabIndex = 49;
            this.labelX2.Text = "Số lần rút tối đa / ngày:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(8, 33);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 14);
            this.labelX3.TabIndex = 49;
            this.labelX3.Text = "Rút tối đa / ngày:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(251, 60);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(121, 14);
            this.labelX4.TabIndex = 49;
            this.labelX4.Text = "Rút tối thiểu / giao dịch:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(8, 60);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(109, 14);
            this.labelX5.TabIndex = 49;
            this.labelX5.Text = "Rút tối đa / giao dịch:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(8, 7);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(86, 14);
            this.labelX6.TabIndex = 49;
            this.labelX6.Text = "Cùng ngân hàng:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(8, 34);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(85, 14);
            this.labelX7.TabIndex = 49;
            this.labelX7.Text = "Khác ngân hàng:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(8, 34);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(116, 14);
            this.labelX8.TabIndex = 49;
            this.labelX8.Text = "Số ngày xem giao dịch:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtMinMoney);
            this.groupPanel1.Controls.Add(this.txtTransDays);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.DrawTitleBox = false;
            this.groupPanel1.Location = new System.Drawing.Point(12, 48);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(242, 87);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Tài khoản";
            // 
            // txtMinMoney
            // 
            this.txtMinMoney.DecimalDigits = 0;
            this.txtMinMoney.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMinMoney.Location = new System.Drawing.Point(128, 4);
            this.txtMinMoney.Name = "txtMinMoney";
            this.txtMinMoney.Size = new System.Drawing.Size(99, 21);
            this.txtMinMoney.TabIndex = 0;
            this.txtMinMoney.Text = "$0";
            this.txtMinMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinMoney.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTransDays
            // 
            this.txtTransDays.Location = new System.Drawing.Point(128, 31);
            this.txtTransDays.Minimum = 1;
            this.txtTransDays.Name = "txtTransDays";
            this.txtTransDays.Size = new System.Drawing.Size(99, 21);
            this.txtTransDays.TabIndex = 1;
            this.txtTransDays.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.txtTransDays.Value = 1;
            this.txtTransDays.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtOtherBank);
            this.groupPanel2.Controls.Add(this.txtSameBank);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.DrawTitleBox = false;
            this.groupPanel2.Location = new System.Drawing.Point(266, 48);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(223, 87);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Chi phí chuyển khoản";
            // 
            // txtOtherBank
            // 
            this.txtOtherBank.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent;
            this.txtOtherBank.Location = new System.Drawing.Point(105, 31);
            this.txtOtherBank.Name = "txtOtherBank";
            this.txtOtherBank.Size = new System.Drawing.Size(99, 21);
            this.txtOtherBank.TabIndex = 1;
            this.txtOtherBank.Text = "0.00 %";
            this.txtOtherBank.Value = 0F;
            this.txtOtherBank.ValueType = Janus.Windows.GridEX.NumericEditValueType.Single;
            this.txtOtherBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSameBank
            // 
            this.txtSameBank.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent;
            this.txtSameBank.Location = new System.Drawing.Point(105, 4);
            this.txtSameBank.Name = "txtSameBank";
            this.txtSameBank.Size = new System.Drawing.Size(99, 21);
            this.txtSameBank.TabIndex = 0;
            this.txtSameBank.Text = "0.00 %";
            this.txtSameBank.Value = 0F;
            this.txtSameBank.ValueType = Janus.Windows.GridEX.NumericEditValueType.Single;
            this.txtSameBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.txtMinWithdrawTran);
            this.groupPanel3.Controls.Add(this.txtMaxWithdrawTran);
            this.groupPanel3.Controls.Add(this.txtMaxTimeWithdrawDay);
            this.groupPanel3.Controls.Add(this.txtMaxWithdrawDay);
            this.groupPanel3.Controls.Add(this.txtMinSend);
            this.groupPanel3.Controls.Add(this.labelX1);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.labelX5);
            this.groupPanel3.Controls.Add(this.labelX4);
            this.groupPanel3.DrawTitleBox = false;
            this.groupPanel3.Location = new System.Drawing.Point(12, 142);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(477, 113);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 2;
            this.groupPanel3.Text = "Giao dịch";
            // 
            // txtMinWithdrawTran
            // 
            this.txtMinWithdrawTran.DecimalDigits = 0;
            this.txtMinWithdrawTran.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMinWithdrawTran.Location = new System.Drawing.Point(375, 57);
            this.txtMinWithdrawTran.Name = "txtMinWithdrawTran";
            this.txtMinWithdrawTran.Size = new System.Drawing.Size(83, 21);
            this.txtMinWithdrawTran.TabIndex = 4;
            this.txtMinWithdrawTran.Text = "$0";
            this.txtMinWithdrawTran.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinWithdrawTran.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMaxWithdrawTran
            // 
            this.txtMaxWithdrawTran.DecimalDigits = 0;
            this.txtMaxWithdrawTran.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMaxWithdrawTran.Location = new System.Drawing.Point(128, 57);
            this.txtMaxWithdrawTran.Name = "txtMaxWithdrawTran";
            this.txtMaxWithdrawTran.Size = new System.Drawing.Size(99, 21);
            this.txtMaxWithdrawTran.TabIndex = 3;
            this.txtMaxWithdrawTran.Text = "$0";
            this.txtMaxWithdrawTran.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaxWithdrawTran.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMaxTimeWithdrawDay
            // 
            this.txtMaxTimeWithdrawDay.Location = new System.Drawing.Point(375, 30);
            this.txtMaxTimeWithdrawDay.Minimum = 1;
            this.txtMaxTimeWithdrawDay.Name = "txtMaxTimeWithdrawDay";
            this.txtMaxTimeWithdrawDay.Size = new System.Drawing.Size(83, 21);
            this.txtMaxTimeWithdrawDay.TabIndex = 2;
            this.txtMaxTimeWithdrawDay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.txtMaxTimeWithdrawDay.Value = 1;
            this.txtMaxTimeWithdrawDay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMaxWithdrawDay
            // 
            this.txtMaxWithdrawDay.DecimalDigits = 0;
            this.txtMaxWithdrawDay.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMaxWithdrawDay.Location = new System.Drawing.Point(128, 30);
            this.txtMaxWithdrawDay.Name = "txtMaxWithdrawDay";
            this.txtMaxWithdrawDay.Size = new System.Drawing.Size(99, 21);
            this.txtMaxWithdrawDay.TabIndex = 1;
            this.txtMaxWithdrawDay.Text = "$0";
            this.txtMaxWithdrawDay.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaxWithdrawDay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMinSend
            // 
            this.txtMinSend.DecimalDigits = 0;
            this.txtMinSend.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtMinSend.Location = new System.Drawing.Point(128, 3);
            this.txtMinSend.Name = "txtMinSend";
            this.txtMinSend.Size = new System.Drawing.Size(99, 21);
            this.txtMinSend.TabIndex = 0;
            this.txtMinSend.Text = "$0";
            this.txtMinSend.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinSend.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(414, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(333, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmRule_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        internal DevComponents.DotNetBar.LabelX labelX12;
        internal DevComponents.DotNetBar.LabelX labelX1;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX labelX6;
        internal DevComponents.DotNetBar.LabelX labelX7;
        internal DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMinMoney;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown txtTransDays;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtOtherBank;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtSameBank;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMinSend;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown txtMaxTimeWithdrawDay;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMaxWithdrawDay;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMaxWithdrawTran;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtMinWithdrawTran;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnSave;
    }
}