namespace EventManager.Presentation
{
    partial class frmDanhMucHopDong
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giaiDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTaPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phuongThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayTTTheoKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayThatSuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chuongTrinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mucPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChuongTrinh = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.numricMucPhat = new DevExpress.XtraEditors.SpinEdit();
            this.numricSoNguoi = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblHeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaDiem = new DevExpress.XtraEditors.TextEdit();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChuongTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricMucPhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricSoNguoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.giaiDoan,
            this.phi,
            this.moTaPhi,
            this.phuongThucTT,
            this.ngayTTTheoKH,
            this.ngayThatSuTT});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "KeHoachChiTras";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1080, 238);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.chuongTrinh,
            this.nhanVien,
            this.ngayBD,
            this.ngayKetThuc,
            this.soNguoi,
            this.mucPhat,
            this.moTa,
            this.diaDiem,
            this.khachHang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // chuongTrinh
            // 
            this.chuongTrinh.Caption = "Chương trình";
            this.chuongTrinh.FieldName = "MaCT";
            this.chuongTrinh.Name = "chuongTrinh";
            this.chuongTrinh.Visible = true;
            this.chuongTrinh.VisibleIndex = 2;
            this.chuongTrinh.Width = 93;
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
            // moTa
            // 
            this.moTa.Caption = "Mô tả";
            this.moTa.FieldName = "MoTa";
            this.moTa.Name = "moTa";
            this.moTa.Visible = true;
            this.moTa.VisibleIndex = 9;
            this.moTa.Width = 206;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChuongTrinh);
            this.panelControl1.Controls.Add(this.cmbNhanVien);
            this.panelControl1.Controls.Add(this.cmbKhachHang);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.numricMucPhat);
            this.panelControl1.Controls.Add(this.numricSoNguoi);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.lblHeSoLuong);
            this.panelControl1.Controls.Add(this.dateNgayKT);
            this.panelControl1.Controls.Add(this.dateNgayBD);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblNgaySinh);
            this.panelControl1.Controls.Add(this.txtDiaDiem);
            this.panelControl1.Controls.Add(this.txtMoTa);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtID);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lblID);
            this.panelControl1.Controls.Add(this.reflectionImage1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 225);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbChuongTrinh
            // 
            this.cmbChuongTrinh.Location = new System.Drawing.Point(295, 58);
            this.cmbChuongTrinh.Name = "cmbChuongTrinh";
            this.cmbChuongTrinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbChuongTrinh.Properties.Appearance.Options.UseFont = true;
            this.cmbChuongTrinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbChuongTrinh.Properties.DisplayMember = "TenCT";
            this.cmbChuongTrinh.Properties.ValueMember = "MaCT";
            this.cmbChuongTrinh.Size = new System.Drawing.Size(337, 24);
            this.cmbChuongTrinh.TabIndex = 74;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNhanVien.Location = new System.Drawing.Point(751, 58);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cmbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhanVien.Properties.DisplayMember = "TenNV";
            this.cmbNhanVien.Properties.ValueMember = "MaNV";
            this.cmbNhanVien.Size = new System.Drawing.Size(316, 24);
            this.cmbNhanVien.TabIndex = 74;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKhachHang.Location = new System.Drawing.Point(510, 20);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbKhachHang.Properties.Appearance.Options.UseFont = true;
            this.cmbKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKhachHang.Properties.DisplayMember = "TenKH";
            this.cmbKhachHang.Properties.ValueMember = "MaKH";
            this.cmbKhachHang.Size = new System.Drawing.Size(498, 24);
            this.cmbKhachHang.TabIndex = 74;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Image = global::EventManager.Properties.Resources.Print_icon;
            this.btnIn.Location = new System.Drawing.Point(295, 169);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(138, 35);
            this.btnIn.TabIndex = 72;
            this.btnIn.Text = "In danh mục";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // numricMucPhat
            // 
            this.numricMucPhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numricMucPhat.EnterMoveNextControl = true;
            this.numricMucPhat.Location = new System.Drawing.Point(989, 96);
            this.numricMucPhat.Name = "numricMucPhat";
            this.numricMucPhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numricMucPhat.Properties.Appearance.Options.UseFont = true;
            this.numricMucPhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numricMucPhat.Properties.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numricMucPhat.Properties.Mask.BeepOnError = true;
            this.numricMucPhat.Properties.Mask.EditMask = "n0";
            this.numricMucPhat.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numricMucPhat.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numricMucPhat.Size = new System.Drawing.Size(83, 24);
            this.numricMucPhat.TabIndex = 3;
            // 
            // numricSoNguoi
            // 
            this.numricSoNguoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numricSoNguoi.EnterMoveNextControl = true;
            this.numricSoNguoi.Location = new System.Drawing.Point(807, 96);
            this.numricSoNguoi.Name = "numricSoNguoi";
            this.numricSoNguoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numricSoNguoi.Properties.Appearance.Options.UseFont = true;
            this.numricSoNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numricSoNguoi.Properties.Mask.BeepOnError = true;
            this.numricSoNguoi.Properties.Mask.EditMask = "n0";
            this.numricSoNguoi.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numricSoNguoi.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numricSoNguoi.Size = new System.Drawing.Size(68, 24);
            this.numricSoNguoi.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Location = new System.Drawing.Point(916, 99);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 18);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "Mức phạt:";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHeSoLuong.Location = new System.Drawing.Point(675, 99);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(123, 18);
            this.lblHeSoLuong.TabIndex = 65;
            this.lblHeSoLuong.Text = "Số người tham gia:";
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.EditValue = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dateNgayKT.EnterMoveNextControl = true;
            this.dateNgayKT.Location = new System.Drawing.Point(536, 96);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateNgayKT.Properties.Appearance.Options.UseFont = true;
            this.dateNgayKT.Properties.Appearance.Options.UseTextOptions = true;
            this.dateNgayKT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayKT.Properties.NullDate = new System.DateTime(1993, 1, 1, 21, 15, 49, 0);
            this.dateNgayKT.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNgayKT.Size = new System.Drawing.Size(110, 24);
            this.dateNgayKT.TabIndex = 1;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.EditValue = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dateNgayBD.EnterMoveNextControl = true;
            this.dateNgayBD.Location = new System.Drawing.Point(295, 96);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateNgayBD.Properties.Appearance.Options.UseFont = true;
            this.dateNgayBD.Properties.Appearance.Options.UseTextOptions = true;
            this.dateNgayBD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBD.Properties.NullDate = new System.DateTime(1993, 1, 1, 21, 15, 49, 0);
            this.dateNgayBD.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNgayBD.Size = new System.Drawing.Size(110, 24);
            this.dateNgayBD.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(433, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 18);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "Ngày kết thúc:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNgaySinh.Location = new System.Drawing.Point(184, 99);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(95, 18);
            this.lblNgaySinh.TabIndex = 61;
            this.lblNgaySinh.Text = "Ngày bắt đầu:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.EnterMoveNextControl = true;
            this.txtDiaDiem.Location = new System.Drawing.Point(295, 136);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaDiem.Properties.Appearance.Options.UseFont = true;
            this.txtDiaDiem.Properties.Mask.EditMask = "^[a-zA-Z][\\\\w\\\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\\\w\\\\.-]*[a-zA-Z0-9]\\\\.[a-zA-Z][a-zA-Z" +
                "\\\\.]*[a-zA-Z]$";
            this.txtDiaDiem.Properties.MaxLength = 100;
            this.txtDiaDiem.Size = new System.Drawing.Size(235, 24);
            this.txtDiaDiem.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.EnterMoveNextControl = true;
            this.txtMoTa.Location = new System.Drawing.Point(616, 136);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Properties.Mask.BeepOnError = true;
            this.txtMoTa.Properties.MaxLength = 100;
            this.txtMoTa.Size = new System.Drawing.Size(451, 24);
            this.txtMoTa.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(563, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Mô tả:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(184, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Địa điểm:";
            // 
            // txtID
            // 
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(295, 20);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.Appearance.Options.UseForeColor = true;
            this.txtID.Properties.Appearance.Options.UseTextOptions = true;
            this.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtID.Properties.MaxLength = 10;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(86, 24);
            this.txtID.TabIndex = 48;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Location = new System.Drawing.Point(184, 61);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 18);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Chương trình:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Location = new System.Drawing.Point(409, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 18);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Khách hàng:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(675, 61);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(70, 18);
            this.lblTenKH.TabIndex = 51;
            this.lblTenKH.Text = "Nhân viên:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(409, 23);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 18);
            this.labelControl5.TabIndex = 52;
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblID.Location = new System.Drawing.Point(184, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 18);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "Hợp đồng số:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::EventManager.Properties.Resources.contract128;
            this.reflectionImage1.Location = new System.Drawing.Point(12, -25);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 47;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 225);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1084, 260);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh mục các hợp đồng";
            // 
            // frmDanhMucHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 485);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDanhMucHopDong";
            this.Text = "frmDanhMucHopDong";
            this.Load += new System.EventHandler(this.frmDanhMucHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChuongTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricMucPhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricSoNguoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbChuongTrinh;
        private DevExpress.XtraEditors.LookUpEdit cmbKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SpinEdit numricMucPhat;
        private DevExpress.XtraEditors.SpinEdit numricSoNguoi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblHeSoLuong;
        private DevExpress.XtraEditors.DateEdit dateNgayKT;
        private DevExpress.XtraEditors.DateEdit dateNgayBD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtDiaDiem;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn chuongTrinh;
        private DevExpress.XtraGrid.Columns.GridColumn nhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ngayBD;
        private DevExpress.XtraGrid.Columns.GridColumn ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn soNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn mucPhat;
        private DevExpress.XtraGrid.Columns.GridColumn moTa;
        private DevExpress.XtraGrid.Columns.GridColumn diaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn khachHang;
        private DevExpress.XtraEditors.LookUpEdit cmbNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn giaiDoan;
        private DevExpress.XtraGrid.Columns.GridColumn phi;
        private DevExpress.XtraGrid.Columns.GridColumn moTaPhi;
        private DevExpress.XtraGrid.Columns.GridColumn phuongThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn ngayTTTheoKH;
        private DevExpress.XtraGrid.Columns.GridColumn ngayThatSuTT;
    }
}