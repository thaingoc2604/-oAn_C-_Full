namespace BankManagement
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.txtUID = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPWD = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtConfirm = new Janus.Windows.GridEX.EditControls.EditBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chkPermit = new Janus.Windows.EditControls.UICheckBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(272, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 9;
            this.PanelEx4.Text = "New user";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(92, 54);
            this.txtUID.MaxLength = 50;
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(165, 21);
            this.txtUID.TabIndex = 0;
            this.txtUID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(12, 57);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(55, 14);
            this.LabelX1.TabIndex = 29;
            this.LabelX1.Text = "Username:";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(92, 81);
            this.txtPWD.MaxLength = 50;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '•';
            this.txtPWD.Size = new System.Drawing.Size(165, 21);
            this.txtPWD.TabIndex = 1;
            this.txtPWD.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(92, 108);
            this.txtConfirm.MaxLength = 50;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '•';
            this.txtConfirm.Size = new System.Drawing.Size(165, 21);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(12, 84);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 14);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Password:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(12, 111);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 14);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Confirm:";
            // 
            // chkPermit
            // 
            this.chkPermit.Location = new System.Drawing.Point(92, 135);
            this.chkPermit.Name = "chkPermit";
            this.chkPermit.Size = new System.Drawing.Size(95, 21);
            this.chkPermit.TabIndex = 3;
            this.chkPermit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(12, 138);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 14);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "Is admin:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(182, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(92, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkPermit);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        private Janus.Windows.GridEX.EditControls.EditBox txtUID;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        private Janus.Windows.GridEX.EditControls.EditBox txtPWD;
        private Janus.Windows.GridEX.EditControls.EditBox txtConfirm;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX3;
        private Janus.Windows.EditControls.UICheckBox chkPermit;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.ButtonX btnCancel;
        internal DevComponents.DotNetBar.ButtonX btnSave;
    }
}