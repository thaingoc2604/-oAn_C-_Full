namespace BankManagement
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference grdUser_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image");
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.grdUser = new Janus.Windows.GridEX.GridEX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEx4.Location = new System.Drawing.Point(0, 0);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(363, 42);
            this.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(108)))), ((int)(((byte)(191)))));
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.Style.MarginLeft = 10;
            this.PanelEx4.TabIndex = 10;
            this.PanelEx4.Text = "Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 51);
            this.panel1.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(274, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(51, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Tooltip = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(89, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(32, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Tooltip = "Lưu";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(127, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Tooltip = "Huỷ bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grdUser
            // 
            this.grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdUser.AlternatingColors = true;
            grdUser_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("grdUser_DesignTimeLayout_Reference_0.Instance")));
            grdUser_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            grdUser_DesignTimeLayout_Reference_0});
            grdUser_DesignTimeLayout.LayoutString = resources.GetString("grdUser_DesignTimeLayout.LayoutString");
            this.grdUser.DesignTimeLayout = grdUser_DesignTimeLayout;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUser.GroupByBoxVisible = false;
            this.grdUser.Location = new System.Drawing.Point(0, 42);
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(363, 176);
            this.grdUser.TabIndex = 12;
            this.grdUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 269);
            this.Controls.Add(this.grdUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelEx4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private Janus.Windows.GridEX.GridEX grdUser;
        private DevComponents.DotNetBar.ButtonX btnDelete;
    }
}