namespace QuanLyHoSoCongChuc
{
    partial class FrmQuaTrinhDaoTao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuaTrinhDaoTao));
            this.treeViewNhanVien = new System.Windows.Forms.TreeView();
            this.dataGridViewDSQTDT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuaTrinhDaoTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuaTrinhDaoTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDauDaoTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThucDaoTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucDaoTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Thoat = new DevComponents.DotNetBar.ButtonX();
            this.ChucNang = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSQTDT)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewNhanVien
            // 
            this.treeViewNhanVien.Location = new System.Drawing.Point(0, 0);
            this.treeViewNhanVien.Name = "treeViewNhanVien";
            this.treeViewNhanVien.Size = new System.Drawing.Size(252, 290);
            this.treeViewNhanVien.TabIndex = 0;
            this.treeViewNhanVien.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewNhanVien_NodeMouseClick);
            // 
            // dataGridViewDSQTDT
            // 
            this.dataGridViewDSQTDT.AllowUserToAddRows = false;
            this.dataGridViewDSQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSQTDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNhanVien,
            this.MaQuaTrinhDaoTao,
            this.TenQuaTrinhDaoTao,
            this.ThoiGianBatDauDaoTao,
            this.ThoiGianKetThucDaoTao,
            this.HinhThucDaoTao,
            this.BangCap});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDSQTDT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDSQTDT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewDSQTDT.Location = new System.Drawing.Point(3, 12);
            this.dataGridViewDSQTDT.Name = "dataGridViewDSQTDT";
            this.dataGridViewDSQTDT.Size = new System.Drawing.Size(556, 278);
            this.dataGridViewDSQTDT.TabIndex = 1;
            this.dataGridViewDSQTDT.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDSQTDT_RowsAdded);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaQuaTrinhDaoTao
            // 
            this.MaQuaTrinhDaoTao.DataPropertyName = "MaQuaTrinhDaoTao";
            this.MaQuaTrinhDaoTao.HeaderText = "Mã quá trình đào tạo";
            this.MaQuaTrinhDaoTao.Name = "MaQuaTrinhDaoTao";
            // 
            // TenQuaTrinhDaoTao
            // 
            this.TenQuaTrinhDaoTao.DataPropertyName = "TenQuaTrinhDaoTao";
            this.TenQuaTrinhDaoTao.HeaderText = "Tên quá trình đào tạo";
            this.TenQuaTrinhDaoTao.Name = "TenQuaTrinhDaoTao";
            // 
            // ThoiGianBatDauDaoTao
            // 
            this.ThoiGianBatDauDaoTao.DataPropertyName = "ThoiGianBatDauDaoTao";
            this.ThoiGianBatDauDaoTao.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDauDaoTao.Name = "ThoiGianBatDauDaoTao";
            // 
            // ThoiGianKetThucDaoTao
            // 
            this.ThoiGianKetThucDaoTao.DataPropertyName = "ThoiGianKetThucDaoTao";
            this.ThoiGianKetThucDaoTao.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThucDaoTao.Name = "ThoiGianKetThucDaoTao";
            // 
            // HinhThucDaoTao
            // 
            this.HinhThucDaoTao.DataPropertyName = "HinhThucDaoTao";
            this.HinhThucDaoTao.HeaderText = "Hình thức đào tạo";
            this.HinhThucDaoTao.Name = "HinhThucDaoTao";
            // 
            // BangCap
            // 
            this.BangCap.DataPropertyName = "BangCap";
            this.BangCap.HeaderText = "Bằng cấp";
            this.BangCap.Name = "BangCap";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.Thoat);
            this.groupPanel1.Controls.Add(this.ChucNang);
            this.groupPanel1.Controls.Add(this.dataGridViewDSQTDT);
            this.groupPanel1.Location = new System.Drawing.Point(267, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(571, 391);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Quá trình đào tạo";
            // 
            // Thoat
            // 
            this.Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Thoat.Location = new System.Drawing.Point(319, 313);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(114, 40);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // ChucNang
            // 
            this.ChucNang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ChucNang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ChucNang.Location = new System.Drawing.Point(157, 313);
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Size = new System.Drawing.Size(114, 40);
            this.ChucNang.TabIndex = 2;
            this.ChucNang.Text = "Chức Năng";
            this.ChucNang.Click += new System.EventHandler(this.ChucNang_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.treeViewNhanVien);
            this.groupPanel2.Location = new System.Drawing.Point(6, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(258, 308);
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
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Danh Sách Nhân Viên";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.Controls.Add(this.labelX1);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(852, 74);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.Color = System.Drawing.Color.Peru;
            this.panelEx4.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(852, 74);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "QUÁ TRÌNH ĐÀO TẠO";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.groupPanel3);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 74);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(852, 427);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 24;
            // 
            // groupPanel3
            // 
            this.groupPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.groupPanel2);
            this.groupPanel3.Controls.Add(this.groupPanel1);
            this.groupPanel3.Location = new System.Drawing.Point(0, 6);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(846, 418);
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
            this.groupPanel3.TabIndex = 1;
            this.groupPanel3.Text = "Thông Tin Đào tạo";
            // 
            // FrmQuaTrinhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 501);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuaTrinhDaoTao";
            this.TabText = "FrmQuaTrinhDaoTao";
            this.Text = "Quá trình đào tạo";
            this.Load += new System.EventHandler(this.FrmQuaTrinhDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSQTDT)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewNhanVien;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewDSQTDT;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuaTrinhDaoTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuaTrinhDaoTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDauDaoTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThucDaoTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucDaoTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn BangCap;
        private DevComponents.DotNetBar.ButtonX ChucNang;
        private DevComponents.DotNetBar.ButtonX Thoat;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
    }
}