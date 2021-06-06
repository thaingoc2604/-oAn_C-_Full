namespace EventManager.Presentation
{
    partial class frmThongTinNV
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoCTDky = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soCTDky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCTDky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnReload);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.txtSoCTDky);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTenNV);
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.lblMaNV);
            this.panelControl1.Controls.Add(this.reflectionImage1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(776, 158);
            this.panelControl1.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Image = global::EventManager.Properties.Resources.reload;
            this.btnReload.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnReload.Location = new System.Drawing.Point(573, 103);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 35);
            this.btnReload.TabIndex = 10;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Image = global::EventManager.Properties.Resources.Print_icon;
            this.btnIn.Location = new System.Drawing.Point(617, 103);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 35);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtSoCTDky
            // 
            this.txtSoCTDky.EnterMoveNextControl = true;
            this.txtSoCTDky.Location = new System.Drawing.Point(357, 100);
            this.txtSoCTDky.Name = "txtSoCTDky";
            this.txtSoCTDky.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSoCTDky.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSoCTDky.Properties.Appearance.Options.UseBackColor = true;
            this.txtSoCTDky.Properties.Appearance.Options.UseFont = true;
            this.txtSoCTDky.Properties.Mask.EditMask = "n0";
            this.txtSoCTDky.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoCTDky.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoCTDky.Properties.MaxLength = 20;
            this.txtSoCTDky.Properties.ReadOnly = true;
            this.txtSoCTDky.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoCTDky.Size = new System.Drawing.Size(102, 24);
            this.txtSoCTDky.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(184, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(155, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Số hợp đồng phụ trách:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.EnterMoveNextControl = true;
            this.txtTenNV.Location = new System.Drawing.Point(295, 54);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Properties.MaxLength = 50;
            this.txtTenNV.Properties.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(458, 24);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.EnterMoveNextControl = true;
            this.txtMaNV.Location = new System.Drawing.Point(295, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaNV.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaNV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaNV.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaNV.Properties.MaxLength = 8;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(127, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(184, 57);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(70, 18);
            this.lblTenKH.TabIndex = 13;
            this.lblTenKH.Text = "Nhân viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMaNV.Location = new System.Drawing.Point(184, 15);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 18);
            this.lblMaNV.TabIndex = 12;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::EventManager.Properties.Resources.user_info_icon;
            this.reflectionImage1.Location = new System.Drawing.Point(12, -20);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(144, 252);
            this.reflectionImage1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 296);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maNV,
            this.tenNV,
            this.soCTDky});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // maNV
            // 
            this.maNV.AppearanceCell.Options.UseTextOptions = true;
            this.maNV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maNV.AppearanceHeader.Options.UseTextOptions = true;
            this.maNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maNV.Caption = "Mã nhân viên";
            this.maNV.FieldName = "MaNV";
            this.maNV.Name = "maNV";
            this.maNV.OptionsColumn.AllowEdit = false;
            this.maNV.Visible = true;
            this.maNV.VisibleIndex = 0;
            this.maNV.Width = 81;
            // 
            // tenNV
            // 
            this.tenNV.Caption = "Tên nhân viên";
            this.tenNV.FieldName = "TenNV";
            this.tenNV.Name = "tenNV";
            this.tenNV.Visible = true;
            this.tenNV.VisibleIndex = 1;
            this.tenNV.Width = 121;
            // 
            // soCTDky
            // 
            this.soCTDky.Caption = "Số hợp đồng phụ trách";
            this.soCTDky.FieldName = "SoCTDky";
            this.soCTDky.Name = "soCTDky";
            this.soCTDky.Visible = true;
            this.soCTDky.VisibleIndex = 2;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // frmThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 454);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThongTinNV";
            this.Text = "frmThongTinNV";
            this.Load += new System.EventHandler(this.frmThongTinNV_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCTDky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.TextEdit txtSoCTDky;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn maNV;
        private DevExpress.XtraGrid.Columns.GridColumn tenNV;
        private DevExpress.XtraGrid.Columns.GridColumn soCTDky;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}