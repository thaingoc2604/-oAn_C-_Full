namespace QUANLYNHANSU
{
    partial class frmPhanQuyenNguoiDungMoi
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRepass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.node6 = new DevComponents.AdvTree.Node();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.node7 = new DevComponents.AdvTree.Node();
            this.node8 = new DevComponents.AdvTree.Node();
            this.node9 = new DevComponents.AdvTree.Node();
            this.node10 = new DevComponents.AdvTree.Node();
            this.node11 = new DevComponents.AdvTree.Node();
            this.node12 = new DevComponents.AdvTree.Node();
            this.node13 = new DevComponents.AdvTree.Node();
            this.node14 = new DevComponents.AdvTree.Node();
            this.node15 = new DevComponents.AdvTree.Node();
            this.node16 = new DevComponents.AdvTree.Node();
            this.node17 = new DevComponents.AdvTree.Node();
            this.node18 = new DevComponents.AdvTree.Node();
            this.node19 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bntTao = new DevComponents.DotNetBar.ButtonX();
            this.bntExit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(27, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Username";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(27, 86);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(102, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Xác nhận password";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(27, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Password";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Location = new System.Drawing.Point(151, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Location = new System.Drawing.Point(151, 60);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtRepass
            // 
            // 
            // 
            // 
            this.txtRepass.Border.Class = "TextBoxBorder";
            this.txtRepass.Location = new System.Drawing.Point(151, 89);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Size = new System.Drawing.Size(100, 20);
            this.txtRepass.TabIndex = 6;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(12, 130);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(252, 35);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Chọn các quyền hạn mà người dùng này \r\nđược truy cập vào";
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advTree1.ForeColor = System.Drawing.Color.DarkViolet;
            this.advTree1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.advTree1.HotTracking = true;
            this.advTree1.Location = new System.Drawing.Point(46, 183);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node6,
            this.node1,
            this.node7,
            this.node12,
            this.node15});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.advTree1.Size = new System.Drawing.Size(205, 302);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.SuspendPaint = false;
            this.advTree1.TabIndex = 9;
            this.advTree1.Text = "advTree1";
            // 
            // node6
            // 
            this.node6.CheckBoxVisible = true;
            this.node6.Expanded = true;
            this.node6.Name = "node6";
            this.node6.Text = "Người dùng(Admin)";
            // 
            // node1
            // 
            this.node1.CheckBoxVisible = true;
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2,
            this.node3,
            this.node4,
            this.node5});
            this.node1.Text = "Thông tin";
            this.node1.NodeClick += new System.EventHandler(this.node1_NodeClick);
            this.node1.NodeDoubleClick += new System.EventHandler(this.node1_NodeDoubleClick);
            // 
            // node2
            // 
            this.node2.CheckBoxVisible = true;
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Text = "Nhân viên";
            // 
            // node3
            // 
            this.node3.CheckBoxVisible = true;
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Text = "Phòng ban";
            // 
            // node4
            // 
            this.node4.CheckBoxVisible = true;
            this.node4.Expanded = true;
            this.node4.Name = "node4";
            this.node4.Text = "Nghĩ việc";
            // 
            // node5
            // 
            this.node5.CheckBoxVisible = true;
            this.node5.Expanded = true;
            this.node5.Name = "node5";
            this.node5.Text = "Nghĩ dài hạn";
            // 
            // node7
            // 
            this.node7.CheckBoxVisible = true;
            this.node7.Expanded = true;
            this.node7.Name = "node7";
            this.node7.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node8,
            this.node9,
            this.node10,
            this.node11});
            this.node7.Text = "Quản lý";
            this.node7.NodeClick += new System.EventHandler(this.node7_NodeClick);
            this.node7.NodeDoubleClick += new System.EventHandler(this.node7_NodeDoubleClick);
            // 
            // node8
            // 
            this.node8.CheckBoxVisible = true;
            this.node8.Expanded = true;
            this.node8.Name = "node8";
            this.node8.Text = "Sổ quyết định";
            // 
            // node9
            // 
            this.node9.CheckBoxVisible = true;
            this.node9.Expanded = true;
            this.node9.Name = "node9";
            this.node9.Text = "Chức vụ";
            // 
            // node10
            // 
            this.node10.CheckBoxVisible = true;
            this.node10.Expanded = true;
            this.node10.Name = "node10";
            this.node10.Text = "Đợt đào tạo";
            // 
            // node11
            // 
            this.node11.CheckBoxVisible = true;
            this.node11.Expanded = true;
            this.node11.Name = "node11";
            this.node11.Text = "Công việc";
            // 
            // node12
            // 
            this.node12.CheckBoxVisible = true;
            this.node12.Expanded = true;
            this.node12.Name = "node12";
            this.node12.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node13,
            this.node14});
            this.node12.Text = "Lương bổng";
            this.node12.NodeClick += new System.EventHandler(this.node12_NodeClick);
            this.node12.NodeDoubleClick += new System.EventHandler(this.node12_NodeDoubleClick);
            // 
            // node13
            // 
            this.node13.CheckBoxVisible = true;
            this.node13.Expanded = true;
            this.node13.Name = "node13";
            this.node13.Text = "Bảng chấm công";
            // 
            // node14
            // 
            this.node14.CheckBoxVisible = true;
            this.node14.Expanded = true;
            this.node14.Name = "node14";
            this.node14.Text = "Bảng chi lương";
            // 
            // node15
            // 
            this.node15.CheckBoxVisible = true;
            this.node15.Expanded = true;
            this.node15.Name = "node15";
            this.node15.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node16,
            this.node17,
            this.node18,
            this.node19});
            this.node15.Text = "Tuyển dụng";
            this.node15.NodeClick += new System.EventHandler(this.node15_NodeClick);
            this.node15.NodeDoubleClick += new System.EventHandler(this.node15_NodeDoubleClick);
            // 
            // node16
            // 
            this.node16.CheckBoxVisible = true;
            this.node16.Expanded = true;
            this.node16.Name = "node16";
            this.node16.Text = "Đợt phỏng vấn";
            // 
            // node17
            // 
            this.node17.CheckBoxVisible = true;
            this.node17.Expanded = true;
            this.node17.Name = "node17";
            this.node17.Text = "Đợt tuyển dụng";
            // 
            // node18
            // 
            this.node18.CheckBoxVisible = true;
            this.node18.Expanded = true;
            this.node18.Name = "node18";
            this.node18.Text = "Ứng viên";
            // 
            // node19
            // 
            this.node19.CheckBoxVisible = true;
            this.node19.Expanded = true;
            this.node19.Name = "node19";
            this.node19.Text = "Chuyển nhân viên";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // bntTao
            // 
            this.bntTao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntTao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntTao.Location = new System.Drawing.Point(27, 501);
            this.bntTao.Name = "bntTao";
            this.bntTao.Size = new System.Drawing.Size(94, 23);
            this.bntTao.TabIndex = 10;
            this.bntTao.Text = "Tạo người dùng";
            this.bntTao.Click += new System.EventHandler(this.bntTao_Click);
            // 
            // bntExit
            // 
            this.bntExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntExit.Location = new System.Drawing.Point(189, 501);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 11;
            this.bntExit.Text = "Thoát";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // frmPhanQuyenNguoiDungMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 536);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntTao);
            this.Controls.Add(this.advTree1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmPhanQuyenNguoiDungMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng và phân quyền";
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRepass;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node5;
        private DevComponents.DotNetBar.ButtonX bntTao;
        private DevComponents.DotNetBar.ButtonX bntExit;
        private DevComponents.AdvTree.Node node6;
        private DevComponents.AdvTree.Node node7;
        private DevComponents.AdvTree.Node node8;
        private DevComponents.AdvTree.Node node9;
        private DevComponents.AdvTree.Node node10;
        private DevComponents.AdvTree.Node node11;
        private DevComponents.AdvTree.Node node12;
        private DevComponents.AdvTree.Node node13;
        private DevComponents.AdvTree.Node node14;
        private DevComponents.AdvTree.Node node15;
        private DevComponents.AdvTree.Node node16;
        private DevComponents.AdvTree.Node node17;
        private DevComponents.AdvTree.Node node18;
        private DevComponents.AdvTree.Node node19;
    }
}