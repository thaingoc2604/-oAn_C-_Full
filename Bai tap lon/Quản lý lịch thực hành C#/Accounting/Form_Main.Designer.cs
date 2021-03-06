namespace Accounting
{
    partial class Form_Main
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
            Janus.Windows.GridEX.GridEXLayout TKThuChiGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.intSoChi = new DevComponents.Editors.IntegerInput();
            this.intSoThu = new DevComponents.Editors.IntegerInput();
            this.intSoDu = new DevComponents.Editors.IntegerInput();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_TinhTon = new System.Windows.Forms.Button();
            this.bttKetChuyen = new System.Windows.Forms.Button();
            this.calendarCombo1 = new Janus.Windows.CalendarCombo.CalendarCombo();
            this.TKThuChiGrid = new Janus.Windows.GridEX.GridEX();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VaoHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanTriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSMãDGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoThangToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DSPhieuHuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoDuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SOQUYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intSoChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoDu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKThuChiGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonClientPanel1.Controls.Add(this.intSoChi);
            this.ribbonClientPanel1.Controls.Add(this.intSoThu);
            this.ribbonClientPanel1.Controls.Add(this.intSoDu);
            this.ribbonClientPanel1.Controls.Add(this.label1);
            this.ribbonClientPanel1.Controls.Add(this.btt_TinhTon);
            this.ribbonClientPanel1.Controls.Add(this.bttKetChuyen);
            this.ribbonClientPanel1.Controls.Add(this.calendarCombo1);
            this.ribbonClientPanel1.Controls.Add(this.TKThuChiGrid);
            this.ribbonClientPanel1.Controls.Add(this.menuStrip1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(-1, 2);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(989, 475);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 2;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            this.ribbonClientPanel1.Click += new System.EventHandler(this.ribbonClientPanel1_Click);
            // 
            // intSoChi
            // 
            // 
            // 
            // 
            this.intSoChi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intSoChi.DisplayFormat = "0,0";
            this.intSoChi.Location = new System.Drawing.Point(559, 47);
            this.intSoChi.MinValue = 0;
            this.intSoChi.Name = "intSoChi";
            this.intSoChi.Size = new System.Drawing.Size(80, 21);
            this.intSoChi.TabIndex = 16;
            this.intSoChi.Visible = false;
            // 
            // intSoThu
            // 
            // 
            // 
            // 
            this.intSoThu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intSoThu.DisplayFormat = "0,0";
            this.intSoThu.Location = new System.Drawing.Point(473, 47);
            this.intSoThu.MinValue = 0;
            this.intSoThu.Name = "intSoThu";
            this.intSoThu.Size = new System.Drawing.Size(80, 21);
            this.intSoThu.TabIndex = 15;
            this.intSoThu.Visible = false;
            // 
            // intSoDu
            // 
            // 
            // 
            // 
            this.intSoDu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intSoDu.DisplayFormat = "0,0";
            this.intSoDu.Location = new System.Drawing.Point(901, 47);
            this.intSoDu.MinValue = -2147483647;
            this.intSoDu.Name = "intSoDu";
            this.intSoDu.Size = new System.Drawing.Size(80, 21);
            this.intSoDu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(818, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số dư đầu kỳ";
            // 
            // btt_TinhTon
            // 
            this.btt_TinhTon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btt_TinhTon.Enabled = false;
            this.btt_TinhTon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_TinhTon.ForeColor = System.Drawing.Color.Black;
            this.btt_TinhTon.Location = new System.Drawing.Point(191, 44);
            this.btt_TinhTon.Name = "btt_TinhTon";
            this.btt_TinhTon.Size = new System.Drawing.Size(75, 23);
            this.btt_TinhTon.TabIndex = 11;
            this.btt_TinhTon.Text = "Tính Tồn";
            this.btt_TinhTon.UseVisualStyleBackColor = false;
            this.btt_TinhTon.Click += new System.EventHandler(this.btt_TinhTon_Click);
            // 
            // bttKetChuyen
            // 
            this.bttKetChuyen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKetChuyen.ForeColor = System.Drawing.Color.Black;
            this.bttKetChuyen.Location = new System.Drawing.Point(97, 44);
            this.bttKetChuyen.Name = "bttKetChuyen";
            this.bttKetChuyen.Size = new System.Drawing.Size(75, 23);
            this.bttKetChuyen.TabIndex = 10;
            this.bttKetChuyen.Text = "Kết chuyển";
            this.bttKetChuyen.UseVisualStyleBackColor = true;
            this.bttKetChuyen.Click += new System.EventHandler(this.bttKetChuyen_Click);
            // 
            // calendarCombo1
            // 
            // 
            // 
            // 
            this.calendarCombo1.DropDownCalendar.Office2007ColorScheme = Janus.Windows.CalendarCombo.Office2007ColorScheme.Silver;
            this.calendarCombo1.Location = new System.Drawing.Point(3, 44);
            this.calendarCombo1.Name = "calendarCombo1";
            this.calendarCombo1.Office2007ColorScheme = Janus.Windows.CalendarCombo.Office2007ColorScheme.Silver;
            this.calendarCombo1.Size = new System.Drawing.Size(81, 21);
            this.calendarCombo1.TabIndex = 8;
            this.calendarCombo1.Value = new System.DateTime(2011, 3, 2, 0, 0, 0, 0);
            this.calendarCombo1.ValueChanged += new System.EventHandler(this.calendarCombo1_ValueChanged);
            // 
            // TKThuChiGrid
            // 
            this.TKThuChiGrid.AllowColumnDrag = false;
            this.TKThuChiGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.TKThuChiGrid.AutomaticSort = false;
            TKThuChiGrid_DesignTimeLayout.LayoutString = resources.GetString("TKThuChiGrid_DesignTimeLayout.LayoutString");
            this.TKThuChiGrid.DesignTimeLayout = TKThuChiGrid_DesignTimeLayout;
            this.TKThuChiGrid.Font = new System.Drawing.Font(".VnTime", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKThuChiGrid.GroupByBoxVisible = false;
            this.TKThuChiGrid.Location = new System.Drawing.Point(3, 88);
            this.TKThuChiGrid.Name = "TKThuChiGrid";
            this.TKThuChiGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver;
            this.TKThuChiGrid.Size = new System.Drawing.Size(980, 384);
            this.TKThuChiGrid.TabIndex = 7;
            this.TKThuChiGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TKThuChiGrid_MouseDoubleClick);
            this.TKThuChiGrid.DoubleClick += new System.EventHandler(this.TKThuChiGrid_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.lậpPhiếuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VaoHeThongToolStripMenuItem,
            this.QuanTriToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.dSMãDGToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ Thống";
            // 
            // VaoHeThongToolStripMenuItem
            // 
            this.VaoHeThongToolStripMenuItem.Name = "VaoHeThongToolStripMenuItem";
            this.VaoHeThongToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.VaoHeThongToolStripMenuItem.Text = "&Vào hệ thống";
            this.VaoHeThongToolStripMenuItem.Click += new System.EventHandler(this.VaoHeThongToolStripMenuItem_Click);
            // 
            // QuanTriToolStripMenuItem
            // 
            this.QuanTriToolStripMenuItem.Enabled = false;
            this.QuanTriToolStripMenuItem.Name = "QuanTriToolStripMenuItem";
            this.QuanTriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.QuanTriToolStripMenuItem.Text = "Quản trị";
            this.QuanTriToolStripMenuItem.Click += new System.EventHandler(this.QuanTriToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Thông tin cá nhân";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // dSMãDGToolStripMenuItem
            // 
            this.dSMãDGToolStripMenuItem.Name = "dSMãDGToolStripMenuItem";
            this.dSMãDGToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dSMãDGToolStripMenuItem.Text = "&Danh mục lý do";
            this.dSMãDGToolStripMenuItem.Click += new System.EventHandler(this.dSMãDGToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.thoátToolStripMenuItem.Text = "&Thoát        Alt+T";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhieuThuToolStripMenuItem,
            this.PhieuChiToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.DSPhieuHuyToolStripMenuItem,
            this.SoDuToolStripMenuItem});
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.lậpPhiếuToolStripMenuItem.Text = "&Quản lý chứng từ";
            // 
            // PhieuThuToolStripMenuItem
            // 
            this.PhieuThuToolStripMenuItem.Name = "PhieuThuToolStripMenuItem";
            this.PhieuThuToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PhieuThuToolStripMenuItem.Text = "Lập Phiếu &Thu";
            this.PhieuThuToolStripMenuItem.Click += new System.EventHandler(this.PhieuThuToolStripMenuItem_Click);
            // 
            // PhieuChiToolStripMenuItem
            // 
            this.PhieuChiToolStripMenuItem.Name = "PhieuChiToolStripMenuItem";
            this.PhieuChiToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PhieuChiToolStripMenuItem.Text = "Lập Phiếu &Chi";
            this.PhieuChiToolStripMenuItem.Click += new System.EventHandler(this.PhieuChiToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SOQUYToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaoCaoThangToolStripMenu});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.báoCáoToolStripMenuItem.Text = "&Báo Cáo";
            // 
            // BaoCaoThangToolStripMenu
            // 
            this.BaoCaoThangToolStripMenu.Name = "BaoCaoThangToolStripMenu";
            this.BaoCaoThangToolStripMenu.Size = new System.Drawing.Size(143, 22);
            this.BaoCaoThangToolStripMenu.Text = "Báo cáo ngày";
            this.BaoCaoThangToolStripMenu.Click += new System.EventHandler(this.BaoCaoThangToolStripMenu_Click);
            // 
            // DSPhieuHuyToolStripMenuItem
            // 
            this.DSPhieuHuyToolStripMenuItem.Name = "DSPhieuHuyToolStripMenuItem";
            this.DSPhieuHuyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.DSPhieuHuyToolStripMenuItem.Text = "Danh sách phiếu đã hủy";
            this.DSPhieuHuyToolStripMenuItem.Visible = false;
            this.DSPhieuHuyToolStripMenuItem.Click += new System.EventHandler(this.DSPhieuHuyToolStripMenuItem_Click);
            // 
            // SoDuToolStripMenuItem
            // 
            this.SoDuToolStripMenuItem.Name = "SoDuToolStripMenuItem";
            this.SoDuToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SoDuToolStripMenuItem.Text = "&Mang sang";
            this.SoDuToolStripMenuItem.Click += new System.EventHandler(this.SoDuToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "&Thông Tin";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns;
            this.gridEXPrintDocument1.GridEX = this.TKThuChiGrid;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.gridEXPrintDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.gridEXPrintDocument1;
            // 
            // gridEXExporter1
            // 
            this.gridEXExporter1.GridEX = this.TKThuChiGrid;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SOQUYToolStripMenuItem
            // 
            this.SOQUYToolStripMenuItem.Name = "SOQUYToolStripMenuItem";
            this.SOQUYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SOQUYToolStripMenuItem.Text = "Sổ Quỹ";
            this.SOQUYToolStripMenuItem.Click += new System.EventHandler(this.SOQUYToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 480);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(933, 509);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intSoChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSoDu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKThuChiGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSMãDGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuChiToolStripMenuItem;
        private Janus.Windows.GridEX.GridEX TKThuChiGrid;
        private Janus.Windows.CalendarCombo.CalendarCombo calendarCombo1;
        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1;
        private System.Windows.Forms.Button bttKetChuyen;
        private System.Windows.Forms.Button btt_TinhTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private DevComponents.Editors.IntegerInput intSoDu;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private DevComponents.Editors.IntegerInput intSoChi;
        private DevComponents.Editors.IntegerInput intSoThu;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoThangToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem VaoHeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanTriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSPhieuHuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoDuToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem SOQUYToolStripMenuItem;
    }
}