namespace EventManager.Presentation
{
    partial class frmCapNhatKhachHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chuongTrinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mucPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giaiDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTaPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phuongThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayTTTheoKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayThatSuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.maKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.chuongTrinh,
            this.nhanVien,
            this.ngayBD,
            this.ngayKetThuc,
            this.soNguoi,
            this.mucPhat,
            this.moTa,
            this.diaDiem});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
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
            this.chuongTrinh.VisibleIndex = 1;
            this.chuongTrinh.Width = 93;
            // 
            // nhanVien
            // 
            this.nhanVien.Caption = "Nhân viên";
            this.nhanVien.FieldName = "MaNV";
            this.nhanVien.Name = "nhanVien";
            this.nhanVien.Visible = true;
            this.nhanVien.VisibleIndex = 2;
            this.nhanVien.Width = 105;
            // 
            // ngayBD
            // 
            this.ngayBD.Caption = "Ngày bắt đầu";
            this.ngayBD.FieldName = "NgayBatDau";
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Visible = true;
            this.ngayBD.VisibleIndex = 3;
            this.ngayBD.Width = 93;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.Caption = "Ngày kết thúc";
            this.ngayKetThuc.FieldName = "NgayKetThuc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Visible = true;
            this.ngayKetThuc.VisibleIndex = 4;
            this.ngayKetThuc.Width = 101;
            // 
            // soNguoi
            // 
            this.soNguoi.Caption = "Số người tham gia";
            this.soNguoi.FieldName = "SoNguoiThamGia";
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Visible = true;
            this.soNguoi.VisibleIndex = 5;
            this.soNguoi.Width = 104;
            // 
            // mucPhat
            // 
            this.mucPhat.Caption = "Mức phạt";
            this.mucPhat.FieldName = "MucPhat";
            this.mucPhat.Name = "mucPhat";
            this.mucPhat.Visible = true;
            this.mucPhat.VisibleIndex = 6;
            this.mucPhat.Width = 107;
            // 
            // moTa
            // 
            this.moTa.Caption = "Mô tả";
            this.moTa.FieldName = "MoTa";
            this.moTa.Name = "moTa";
            this.moTa.Visible = true;
            this.moTa.VisibleIndex = 8;
            this.moTa.Width = 206;
            // 
            // diaDiem
            // 
            this.diaDiem.Caption = "Địa điểm";
            this.diaDiem.FieldName = "DiaDiem";
            this.diaDiem.Name = "diaDiem";
            this.diaDiem.Visible = true;
            this.diaDiem.VisibleIndex = 7;
            this.diaDiem.Width = 105;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenu;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode4.LevelTemplate = this.gridView2;
            gridLevelNode4.RelationName = "KeHoachChiTras";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "ChiTietCTs";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1080, 285);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
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
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã khách hàng";
            this.gridColumn2.FieldName = "MaKH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên khách hàng";
            this.gridColumn3.FieldName = "TenKH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 121;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đại chỉ";
            this.gridColumn4.FieldName = "DiaChi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 105;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điện thoại";
            this.gridColumn5.FieldName = "DienThoai";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 93;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Email";
            this.gridColumn6.FieldName = "Email";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 101;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.txtDienThoai);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblDiaChi);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.txtMaKH);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.lblMaKH);
            this.panelControl1.Controls.Add(this.reflectionImage1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 178);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::EventManager.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(783, 138);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Image = global::EventManager.Properties.Resources.Print_icon;
            this.btnIn.Location = new System.Drawing.Point(925, 138);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 35);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.EnterMoveNextControl = true;
            this.txtDienThoai.Location = new System.Drawing.Point(295, 104);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDienThoai.Properties.Appearance.Options.UseFont = true;
            this.txtDienThoai.Properties.Mask.EditMask = "^[a-zA-Z][\\\\w\\\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\\\w\\\\.-]*[a-zA-Z0-9]\\\\.[a-zA-Z][a-zA-Z" +
                "\\\\.]*[a-zA-Z]$";
            this.txtDienThoai.Properties.MaxLength = 20;
            this.txtDienThoai.Size = new System.Drawing.Size(321, 24);
            this.txtDienThoai.TabIndex = 8;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(295, 66);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Mask.BeepOnError = true;
            this.txtDiaChi.Properties.Mask.EditMask = "\\d{4}-\\d\\d\\d\\d-\\d\\d\\d";
            this.txtDiaChi.Properties.MaxLength = 100;
            this.txtDiaChi.Size = new System.Drawing.Size(766, 24);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(749, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Mask.BeepOnError = true;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(312, 24);
            this.txtEmail.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(658, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Địa chỉ email:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(184, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblDiaChi.Location = new System.Drawing.Point(184, 69);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 18);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.EnterMoveNextControl = true;
            this.txtHoTen.Location = new System.Drawing.Point(564, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Size = new System.Drawing.Size(497, 24);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtMaKH
            // 
            this.txtMaKH.EnterMoveNextControl = true;
            this.txtMaKH.Location = new System.Drawing.Point(295, 25);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaKH.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaKH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaKH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaKH.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaKH.Properties.MaxLength = 8;
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(127, 24);
            this.txtMaKH.TabIndex = 2;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(476, 28);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(82, 18);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Khách hàng:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMaKH.Location = new System.Drawing.Point(184, 28);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(105, 18);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::EventManager.Properties.Resources.KhachHang128;
            this.reflectionImage1.Location = new System.Drawing.Point(12, -20);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(144, 252);
            this.reflectionImage1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 178);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1084, 307);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách khách hàng";
            // 
            // maKH
            // 
            this.maKH.AppearanceCell.Options.UseTextOptions = true;
            this.maKH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maKH.AppearanceHeader.Options.UseTextOptions = true;
            this.maKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maKH.Caption = "Mã khách hàng";
            this.maKH.FieldName = "MaKH";
            this.maKH.Name = "maKH";
            this.maKH.OptionsColumn.AllowEdit = false;
            this.maKH.Width = 129;
            // 
            // tenKH
            // 
            this.tenKH.Caption = "Tên khách hàng";
            this.tenKH.FieldName = "TenKH";
            this.tenKH.Name = "tenKH";
            this.tenKH.Width = 231;
            // 
            // dienThoai
            // 
            this.dienThoai.Caption = "Điện thoại";
            this.dienThoai.FieldName = "DienThoai";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.Width = 136;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "Email";
            this.email.Name = "email";
            this.email.Width = 156;
            // 
            // diaChi
            // 
            this.diaChi.Caption = "Địa chỉ";
            this.diaChi.FieldName = "DiaChi";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 412;
            // 
            // frmCapNhatKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 485);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCapNhatKhachHang";
            this.Text = "frmDanhSachKhachHang";
            this.Load += new System.EventHandler(this.frmDanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn giaiDoan;
        private DevExpress.XtraGrid.Columns.GridColumn phi;
        private DevExpress.XtraGrid.Columns.GridColumn moTaPhi;
        private DevExpress.XtraGrid.Columns.GridColumn phuongThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn ngayTTTheoKH;
        private DevExpress.XtraGrid.Columns.GridColumn ngayThatSuTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn maKH;
        private DevExpress.XtraGrid.Columns.GridColumn tenKH;
        private DevExpress.XtraGrid.Columns.GridColumn dienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn chuongTrinh;
        private DevExpress.XtraGrid.Columns.GridColumn nhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ngayBD;
        private DevExpress.XtraGrid.Columns.GridColumn ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn soNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn mucPhat;
        private DevExpress.XtraGrid.Columns.GridColumn moTa;
        private DevExpress.XtraGrid.Columns.GridColumn diaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}