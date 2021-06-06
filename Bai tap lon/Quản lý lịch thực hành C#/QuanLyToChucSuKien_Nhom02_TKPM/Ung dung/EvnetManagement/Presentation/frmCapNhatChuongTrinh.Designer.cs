namespace EventManager.Presentation
{
    partial class frmCapNhatChuongTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mucPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giaiDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTaPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phuongThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayTTTheoKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayThatSuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCT = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.gridColumn1,
            this.nhanVien,
            this.ngayBD,
            this.ngayKetThuc,
            this.soNguoi,
            this.mucPhat,
            this.gridColumn2,
            this.diaDiem,
            this.khachHang});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.AppearanceCell.Options.UseTextOptions = true;
            this.id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.AppearanceHeader.Options.UseTextOptions = true;
            this.id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.Caption = "Số";
            this.id.FieldName = "ID";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 59;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chương trình";
            this.gridColumn1.FieldName = "MaCT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 93;
            // 
            // nhanVien
            // 
            this.nhanVien.Caption = "Nhân viên";
            this.nhanVien.FieldName = "MaNV";
            this.nhanVien.Name = "nhanVien";
            this.nhanVien.Visible = true;
            this.nhanVien.VisibleIndex = 3;
            this.nhanVien.Width = 105;
            // 
            // ngayBD
            // 
            this.ngayBD.Caption = "Ngày bắt đầu";
            this.ngayBD.FieldName = "NgayBatDau";
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Visible = true;
            this.ngayBD.VisibleIndex = 4;
            this.ngayBD.Width = 93;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.Caption = "Ngày kết thúc";
            this.ngayKetThuc.FieldName = "NgayKetThuc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Visible = true;
            this.ngayKetThuc.VisibleIndex = 5;
            this.ngayKetThuc.Width = 101;
            // 
            // soNguoi
            // 
            this.soNguoi.Caption = "Số người tham gia";
            this.soNguoi.FieldName = "SoNguoiThamGia";
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Visible = true;
            this.soNguoi.VisibleIndex = 6;
            this.soNguoi.Width = 104;
            // 
            // mucPhat
            // 
            this.mucPhat.Caption = "Mức phạt";
            this.mucPhat.FieldName = "MucPhat";
            this.mucPhat.Name = "mucPhat";
            this.mucPhat.Visible = true;
            this.mucPhat.VisibleIndex = 7;
            this.mucPhat.Width = 107;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mô tả";
            this.gridColumn2.FieldName = "MoTa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 206;
            // 
            // diaDiem
            // 
            this.diaDiem.Caption = "Địa điểm";
            this.diaDiem.FieldName = "DiaDiem";
            this.diaDiem.Name = "diaDiem";
            this.diaDiem.Visible = true;
            this.diaDiem.VisibleIndex = 8;
            this.diaDiem.Width = 105;
            // 
            // khachHang
            // 
            this.khachHang.Caption = "Khách hàng";
            this.khachHang.FieldName = "MaKH";
            this.khachHang.Name = "khachHang";
            this.khachHang.Visible = true;
            this.khachHang.VisibleIndex = 1;
            this.khachHang.Width = 87;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenu;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "KeHoachChiTras";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "ChiTietCTs";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1080, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView2});
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuXoa});
            this.contextMenu.Name = "contextMenuEmail";
            this.contextMenu.Size = new System.Drawing.Size(137, 28);
            // 
            // toolStripMenuXoa
            // 
            this.toolStripMenuXoa.Image = global::EventManager.Properties.Resources.Ribbon_Delete_16x16;
            this.toolStripMenuXoa.Name = "toolStripMenuXoa";
            this.toolStripMenuXoa.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuXoa.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuXoa.Text = "Xóa";
            this.toolStripMenuXoa.Click += new System.EventHandler(this.toolStripMenuXoa_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maCT,
            this.tenCT,
            this.moTa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // maCT
            // 
            this.maCT.AppearanceCell.Options.UseTextOptions = true;
            this.maCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maCT.AppearanceHeader.Options.UseTextOptions = true;
            this.maCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maCT.Caption = "Mã dịch vụ";
            this.maCT.FieldName = "MaCT";
            this.maCT.Name = "maCT";
            this.maCT.OptionsColumn.AllowEdit = false;
            this.maCT.Visible = true;
            this.maCT.VisibleIndex = 0;
            this.maCT.Width = 129;
            // 
            // tenCT
            // 
            this.tenCT.Caption = "Tên dịch vụ";
            this.tenCT.FieldName = "TenCT";
            this.tenCT.Name = "tenCT";
            this.tenCT.Visible = true;
            this.tenCT.VisibleIndex = 1;
            this.tenCT.Width = 162;
            // 
            // moTa
            // 
            this.moTa.Caption = "Mô tả";
            this.moTa.FieldName = "MoTaCT";
            this.moTa.Name = "moTa";
            this.moTa.Visible = true;
            this.moTa.VisibleIndex = 2;
            this.moTa.Width = 412;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.giaiDoan,
            this.phi,
            this.moTaPhi,
            this.phuongThucTT,
            this.ngayTTTheoKH,
            this.ngayThatSuTT});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // giaiDoan
            // 
            this.giaiDoan.AppearanceCell.Options.UseTextOptions = true;
            this.giaiDoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.giaiDoan.AppearanceHeader.Options.UseTextOptions = true;
            this.giaiDoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.giaiDoan.Caption = "Giai đoạn";
            this.giaiDoan.FieldName = "GiaiDoan";
            this.giaiDoan.Name = "giaiDoan";
            this.giaiDoan.Visible = true;
            this.giaiDoan.VisibleIndex = 0;
            this.giaiDoan.Width = 73;
            // 
            // phi
            // 
            this.phi.Caption = "Phí";
            this.phi.FieldName = "Phi";
            this.phi.Name = "phi";
            this.phi.Visible = true;
            this.phi.VisibleIndex = 1;
            // 
            // moTaPhi
            // 
            this.moTaPhi.Caption = "Mô tả phí";
            this.moTaPhi.FieldName = "MoTaPhi";
            this.moTaPhi.Name = "moTaPhi";
            this.moTaPhi.Visible = true;
            this.moTaPhi.VisibleIndex = 5;
            this.moTaPhi.Width = 166;
            // 
            // phuongThucTT
            // 
            this.phuongThucTT.Caption = "Phương thức thanh toán";
            this.phuongThucTT.FieldName = "PhuongThucTT";
            this.phuongThucTT.Name = "phuongThucTT";
            this.phuongThucTT.Visible = true;
            this.phuongThucTT.VisibleIndex = 2;
            this.phuongThucTT.Width = 127;
            // 
            // ngayTTTheoKH
            // 
            this.ngayTTTheoKH.Caption = "Ngày phải thanh toán";
            this.ngayTTTheoKH.FieldName = "NgayTTTheoKH";
            this.ngayTTTheoKH.Name = "ngayTTTheoKH";
            this.ngayTTTheoKH.Visible = true;
            this.ngayTTTheoKH.VisibleIndex = 3;
            this.ngayTTTheoKH.Width = 113;
            // 
            // ngayThatSuTT
            // 
            this.ngayThatSuTT.Caption = "Ngày thanh toán";
            this.ngayThatSuTT.FieldName = "NgayThatSuTT";
            this.ngayThatSuTT.Name = "ngayThatSuTT";
            this.ngayThatSuTT.Visible = true;
            this.ngayThatSuTT.VisibleIndex = 4;
            this.ngayThatSuTT.Width = 90;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 202);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1084, 283);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh sách dịch vụ";
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Image = global::EventManager.Properties.Resources.Print_icon;
            this.btnIn.Location = new System.Drawing.Point(931, 139);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 35);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::EventManager.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(789, 139);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 35);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMoTa);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtTenCT);
            this.panelControl1.Controls.Add(this.txtMaCT);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.lblMaKH);
            this.panelControl1.Controls.Add(this.reflectionImage1);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 202);
            this.panelControl1.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.EnterMoveNextControl = true;
            this.txtMoTa.Location = new System.Drawing.Point(279, 99);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Properties.MaxLength = 100;
            this.txtMoTa.Size = new System.Drawing.Size(788, 24);
            this.txtMoTa.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(155, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mô tả:";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenCT.EnterMoveNextControl = true;
            this.txtTenCT.Location = new System.Drawing.Point(279, 61);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenCT.Properties.Appearance.Options.UseFont = true;
            this.txtTenCT.Properties.MaxLength = 50;
            this.txtTenCT.Size = new System.Drawing.Size(498, 24);
            this.txtTenCT.TabIndex = 4;
            // 
            // txtMaCT
            // 
            this.txtMaCT.EnterMoveNextControl = true;
            this.txtMaCT.Location = new System.Drawing.Point(279, 23);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaCT.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaCT.Properties.Appearance.Options.UseFont = true;
            this.txtMaCT.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaCT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaCT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaCT.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaCT.Properties.MaxLength = 5;
            this.txtMaCT.Properties.ReadOnly = true;
            this.txtMaCT.Size = new System.Drawing.Size(127, 24);
            this.txtMaCT.TabIndex = 2;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(155, 64);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 18);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên chương trình:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMaKH.Location = new System.Drawing.Point(155, 26);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(111, 18);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã chương trình:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::EventManager.Properties.Resources.services;
            this.reflectionImage1.Location = new System.Drawing.Point(7, 7);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 229);
            this.reflectionImage1.TabIndex = 0;
            // 
            // frmCapNhatChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 485);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCapNhatChuongTrinh";
            this.Text = "CapNhatChuongTrinh";
            this.Load += new System.EventHandler(this.frmCapNhatChuongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn maCT;
        private DevExpress.XtraGrid.Columns.GridColumn tenCT;
        private DevExpress.XtraGrid.Columns.GridColumn moTa;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenCT;
        private DevExpress.XtraEditors.TextEdit txtMaCT;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn nhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ngayBD;
        private DevExpress.XtraGrid.Columns.GridColumn ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn soNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn mucPhat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn diaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn khachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn giaiDoan;
        private DevExpress.XtraGrid.Columns.GridColumn phi;
        private DevExpress.XtraGrid.Columns.GridColumn moTaPhi;
        private DevExpress.XtraGrid.Columns.GridColumn phuongThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn ngayTTTheoKH;
        private DevExpress.XtraGrid.Columns.GridColumn ngayThatSuTT;
    }
}