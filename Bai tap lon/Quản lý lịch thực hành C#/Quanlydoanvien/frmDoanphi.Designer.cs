namespace Quanlydoanvien
{
    partial class frmDoanphi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanphi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.txtmadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmadp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsotien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgdp = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnlamoi = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txthientai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnchon = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnlamtuoi = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgdp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(178, 9);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 28);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa ";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(71, 9);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(67, 28);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmadv
            // 
            // 
            // 
            // 
            this.txtmadv.Border.Class = "TextBoxBorder";
            this.txtmadv.Location = new System.Drawing.Point(77, 38);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.ReadOnly = true;
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 5;
            this.txtmadv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmadv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmadv_KeyDown);
            // 
            // txtmadp
            // 
            this.balloonTip1.SetBalloonCaption(this.txtmadp, null);
            this.balloonTip1.SetBalloonText(this.txtmadp, "Nhập cẩn thận! Vì không sửa được");
            // 
            // 
            // 
            this.txtmadp.Border.Class = "TextBoxBorder";
            this.txtmadp.Location = new System.Drawing.Point(76, 5);
            this.txtmadp.Name = "txtmadp";
            this.txtmadp.Size = new System.Drawing.Size(100, 20);
            this.txtmadp.TabIndex = 1;
            this.txtmadp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsotien
            // 
            this.balloonTip1.SetBalloonCaption(this.txtsotien, null);
            this.balloonTip1.SetBalloonText(this.txtsotien, "Nhập số 0 nếu đoàn viên đó chưa đóng đoàn phí");
            // 
            // 
            // 
            this.txtsotien.Border.Class = "TextBoxBorder";
            this.txtsotien.Location = new System.Drawing.Point(244, 5);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(109, 20);
            this.txtsotien.TabIndex = 3;
            this.txtsotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsotien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsotien_KeyPress);
            // 
            // txtnh
            // 
            // 
            // 
            // 
            this.txtnh.Border.Class = "TextBoxBorder";
            this.txtnh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtnh.Location = new System.Drawing.Point(244, 39);
            this.txtnh.Name = "txtnh";
            this.txtnh.ReadOnly = true;
            this.txtnh.Size = new System.Drawing.Size(109, 20);
            this.txtnh.TabIndex = 7;
            this.txtnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnh_KeyDown);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Location = new System.Drawing.Point(190, 7);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 16);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Số tiền";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(191, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 21);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Năm học";
            // 
            // dgdp
            // 
            this.dgdp.AllowUserToOrderColumns = true;
            this.dgdp.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgdp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdp.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdp.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgdp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgdp.Location = new System.Drawing.Point(6, 174);
            this.dgdp.Name = "dgdp";
            this.dgdp.ReadOnly = true;
            this.dgdp.Size = new System.Drawing.Size(385, 183);
            this.dgdp.TabIndex = 3;
            this.dgdp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdp_CellClick);
            this.dgdp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdp_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaToolStripMenuItem.Image")));
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Location = new System.Drawing.Point(4, 7);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(61, 12);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Mã đoàn phí";
            // 
            // btnlamoi
            // 
            this.btnlamoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlamoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlamoi.Image = ((System.Drawing.Image)(resources.GetObject("btnlamoi.Image")));
            this.btnlamoi.Location = new System.Drawing.Point(257, 9);
            this.btnlamoi.Name = "btnlamoi";
            this.btnlamoi.Size = new System.Drawing.Size(78, 28);
            this.btnlamoi.TabIndex = 0;
            this.btnlamoi.Text = "Thêm mới";
            this.btnlamoi.Click += new System.EventHandler(this.btnlamoi_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(4, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 14);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Mã đoàn viên";
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(3, 9);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(66, 28);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Lưu ";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Location = new System.Drawing.Point(255, 2);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(433, 50);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "DANH MỤC QUẢN LÝ ĐOÀN PHÍ";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.pictureBox4);
            this.groupPanel1.Controls.Add(this.pictureBox3);
            this.groupPanel1.Controls.Add(this.btnlamoi);
            this.groupPanel1.Controls.Add(this.btnsua);
            this.groupPanel1.Controls.Add(this.btnxoa);
            this.groupPanel1.Controls.Add(this.btnthem);
            this.groupPanel1.Location = new System.Drawing.Point(6, 358);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(385, 67);
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
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.TabIndex = 34;
            this.groupPanel1.Text = "Các chức năng";
            // 
            // pictureBox4
            // 
            this.balloonTip1.SetBalloonCaption(this.pictureBox4, null);
            this.balloonTip1.SetBalloonText(this.pictureBox4, "Kích hoạt tính năng Sửa dữ liệu");
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(140, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.balloonTip1.SetBalloonCaption(this.pictureBox3, null);
            this.balloonTip1.SetBalloonText(this.pictureBox3, "Kích hoạt tính năng thêm dữ liệu");
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(340, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txthientai);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.btnchon);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtmadv);
            this.groupPanel2.Controls.Add(this.txtmadp);
            this.groupPanel2.Controls.Add(this.txtsotien);
            this.groupPanel2.Controls.Add(this.txtnh);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Location = new System.Drawing.Point(6, 62);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(385, 110);
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
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "Nhập dữ liệu";
            // 
            // txthientai
            // 
            this.txthientai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txthientai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txthientai.DisplayMember = "Text";
            this.txthientai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txthientai.FormattingEnabled = true;
            this.txthientai.ItemHeight = 14;
            this.txthientai.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.txthientai.Location = new System.Drawing.Point(244, 66);
            this.txthientai.Name = "txthientai";
            this.txthientai.Size = new System.Drawing.Size(109, 20);
            this.txthientai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txthientai.TabIndex = 10;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Đã đóng";
            this.comboItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Chưa đóng";
            this.comboItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(191, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(51, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Hiện tại";
            // 
            // btnchon
            // 
            this.btnchon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchon.Location = new System.Drawing.Point(60, 61);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(117, 27);
            this.btnchon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn mã đoàn viên!";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // balloonTip1
            // 
            this.balloonTip1.DefaultBalloonWidth = 300;
            this.balloonTip1.InitialDelay = 250;
            this.balloonTip1.ShowCloseButton = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.balloonTip1.SetBalloonCaption(this.pictureBox1, null);
            this.balloonTip1.SetBalloonText(this.pictureBox1, "Hehe! Vui ghê chưa nè");
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.balloonTip1.SetBalloonCaption(this.pictureBox5, null);
            this.balloonTip1.SetBalloonText(this.pictureBox5, "Click vào MADP bên kia và xem bên dưới là chi tiết đoàn viên mà bạn muốn xem (Lưu" +
                    " ý là nếu có trục trặc thì bấm Refresh nhé!)");
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(196, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.balloonTip1.SetBalloonCaption(this.pictureBox2, null);
            this.balloonTip1.SetBalloonText(this.pictureBox2, "Hehe! Vui ghê chưa nè");
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(679, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 137);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.Size = new System.Drawing.Size(526, 77);
            this.dataGridViewX1.TabIndex = 37;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnlamtuoi);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.pictureBox5);
            this.groupPanel3.Controls.Add(this.dataGridViewX1);
            this.groupPanel3.Location = new System.Drawing.Point(397, 72);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(532, 348);
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
            this.groupPanel3.Style.Class = "";
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.Class = "";
            this.groupPanel3.TabIndex = 38;
            this.groupPanel3.Text = "Chi tiết / Lý lịch đoàn viên";
            // 
            // btnlamtuoi
            // 
            this.btnlamtuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlamtuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlamtuoi.Location = new System.Drawing.Point(226, 294);
            this.btnlamtuoi.Name = "btnlamtuoi";
            this.btnlamtuoi.Size = new System.Drawing.Size(75, 23);
            this.btnlamtuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlamtuoi.TabIndex = 40;
            this.btnlamtuoi.Text = "Refresh";
            this.btnlamtuoi.Click += new System.EventHandler(this.btnlamtuoi_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(164, 246);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(286, 23);
            this.labelX3.TabIndex = 39;
            // 
            // frmDoanphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(935, 432);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.dgdp);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoanphi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đoàn Phí";
            this.Load += new System.EventHandler(this.frmDoanphi_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoanphi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgdp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadp;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsotien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnh;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgdp;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnlamoi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnchon;
       
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txthientai;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX btnlamtuoi;
    }
}