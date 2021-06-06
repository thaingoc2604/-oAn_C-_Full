namespace qlkaraoke
{
    partial class uaEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uaEmployee));
            this.lblName = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.uaEmployeeBtnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uaEmployeeTxtSalary = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtPhone = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtJobtitle = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtAddress = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtPassword = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtFullName = new System.Windows.Forms.TextBox();
            this.uaEmployeeTxtUserName = new System.Windows.Forms.TextBox();
            this.uaEmployeeDateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.uaEmployeeCboPermission = new System.Windows.Forms.ComboBox();
            this.uaEmployeeCboSex = new System.Windows.Forms.ComboBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uaEmployeeBtnDelete = new System.Windows.Forms.Button();
            this.uaEmployeeBtnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uaEmployeeDGList = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.employeeTableAdapter = new qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uaEmployeeDGList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 15);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Full Name";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(3, 39);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(61, 15);
            this.lblNgaySinh.TabIndex = 19;
            this.lblNgaySinh.Text = "Birth Date";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(3, 78);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(28, 15);
            this.lblGioiTinh.TabIndex = 18;
            this.lblGioiTinh.Text = "Sex";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(3, 117);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 15);
            this.lblDiaChi.TabIndex = 21;
            this.lblDiaChi.Text = "Address";
            // 
            // uaEmployeeBtnUpdate
            // 
            this.uaEmployeeBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaEmployeeBtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaEmployeeBtnUpdate.BackgroundImage")));
            this.uaEmployeeBtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaEmployeeBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaEmployeeBtnUpdate.Location = new System.Drawing.Point(378, 582);
            this.uaEmployeeBtnUpdate.Name = "uaEmployeeBtnUpdate";
            this.uaEmployeeBtnUpdate.Size = new System.Drawing.Size(93, 38);
            this.uaEmployeeBtnUpdate.TabIndex = 41;
            this.uaEmployeeBtnUpdate.Text = "Update";
            this.uaEmployeeBtnUpdate.UseVisualStyleBackColor = true;
            this.uaEmployeeBtnUpdate.MouseLeave += new System.EventHandler(this.uaEmployeeBtnUpdate_MouseLeave);
            this.uaEmployeeBtnUpdate.Click += new System.EventHandler(this.uaEmployeeBtnUpdate_Click);
            this.uaEmployeeBtnUpdate.MouseEnter += new System.EventHandler(this.uaEmployeeBtnUpdate_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(10, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 216);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNgaySinh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGioiTinh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDiaChi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtSalary, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtJobtitle, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtPassword, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtFullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeTxtUserName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeDateTimeBirth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLuong, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblChucVu, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeCboPermission, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uaEmployeeCboSex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPermission, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 197);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // uaEmployeeTxtSalary
            // 
            this.uaEmployeeTxtSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtSalary.Location = new System.Drawing.Point(501, 159);
            this.uaEmployeeTxtSalary.Name = "uaEmployeeTxtSalary";
            this.uaEmployeeTxtSalary.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtSalary.TabIndex = 29;
            // 
            // uaEmployeeTxtPhone
            // 
            this.uaEmployeeTxtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtPhone.Location = new System.Drawing.Point(100, 159);
            this.uaEmployeeTxtPhone.Name = "uaEmployeeTxtPhone";
            this.uaEmployeeTxtPhone.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtPhone.TabIndex = 30;
            // 
            // uaEmployeeTxtJobtitle
            // 
            this.uaEmployeeTxtJobtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtJobtitle.Location = new System.Drawing.Point(501, 120);
            this.uaEmployeeTxtJobtitle.Name = "uaEmployeeTxtJobtitle";
            this.uaEmployeeTxtJobtitle.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtJobtitle.TabIndex = 32;
            // 
            // uaEmployeeTxtAddress
            // 
            this.uaEmployeeTxtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtAddress.Location = new System.Drawing.Point(100, 120);
            this.uaEmployeeTxtAddress.Name = "uaEmployeeTxtAddress";
            this.uaEmployeeTxtAddress.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtAddress.TabIndex = 31;
            // 
            // uaEmployeeTxtPassword
            // 
            this.uaEmployeeTxtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtPassword.Location = new System.Drawing.Point(501, 81);
            this.uaEmployeeTxtPassword.Name = "uaEmployeeTxtPassword";
            this.uaEmployeeTxtPassword.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtPassword.TabIndex = 24;
            // 
            // uaEmployeeTxtFullName
            // 
            this.uaEmployeeTxtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtFullName.Location = new System.Drawing.Point(100, 3);
            this.uaEmployeeTxtFullName.Name = "uaEmployeeTxtFullName";
            this.uaEmployeeTxtFullName.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtFullName.TabIndex = 23;
            // 
            // uaEmployeeTxtUserName
            // 
            this.uaEmployeeTxtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeTxtUserName.Location = new System.Drawing.Point(501, 42);
            this.uaEmployeeTxtUserName.Name = "uaEmployeeTxtUserName";
            this.uaEmployeeTxtUserName.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeTxtUserName.TabIndex = 25;
            // 
            // uaEmployeeDateTimeBirth
            // 
            this.uaEmployeeDateTimeBirth.CustomFormat = "";
            this.uaEmployeeDateTimeBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeDateTimeBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uaEmployeeDateTimeBirth.Location = new System.Drawing.Point(100, 42);
            this.uaEmployeeDateTimeBirth.Name = "uaEmployeeDateTimeBirth";
            this.uaEmployeeDateTimeBirth.Size = new System.Drawing.Size(311, 21);
            this.uaEmployeeDateTimeBirth.TabIndex = 27;
            this.uaEmployeeDateTimeBirth.Value = new System.DateTime(2007, 11, 23, 0, 0, 0, 0);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(417, 156);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(78, 15);
            this.lblLuong.TabIndex = 17;
            this.lblLuong.Text = "Salary (USD)";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(417, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(417, 117);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 15);
            this.lblChucVu.TabIndex = 20;
            this.lblChucVu.Text = "Job Title";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(417, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 15);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // uaEmployeeCboPermission
            // 
            this.uaEmployeeCboPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeCboPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaEmployeeCboPermission.FormattingEnabled = true;
            this.uaEmployeeCboPermission.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.uaEmployeeCboPermission.Location = new System.Drawing.Point(501, 3);
            this.uaEmployeeCboPermission.Name = "uaEmployeeCboPermission";
            this.uaEmployeeCboPermission.Size = new System.Drawing.Size(311, 23);
            this.uaEmployeeCboPermission.TabIndex = 22;
            this.uaEmployeeCboPermission.SelectedIndexChanged += new System.EventHandler(this.uaEmployeeCboPermission_SelectedIndexChanged);
            // 
            // uaEmployeeCboSex
            // 
            this.uaEmployeeCboSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeCboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaEmployeeCboSex.FormattingEnabled = true;
            this.uaEmployeeCboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.uaEmployeeCboSex.Location = new System.Drawing.Point(100, 81);
            this.uaEmployeeCboSex.Name = "uaEmployeeCboSex";
            this.uaEmployeeCboSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uaEmployeeCboSex.Size = new System.Drawing.Size(311, 23);
            this.uaEmployeeCboSex.TabIndex = 28;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Location = new System.Drawing.Point(417, 0);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(69, 15);
            this.lblPermission.TabIndex = 11;
            this.lblPermission.Text = "Permission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phone Number";
            // 
            // uaEmployeeBtnDelete
            // 
            this.uaEmployeeBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaEmployeeBtnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.uaEmployeeBtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaEmployeeBtnDelete.BackgroundImage")));
            this.uaEmployeeBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaEmployeeBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaEmployeeBtnDelete.Location = new System.Drawing.Point(485, 582);
            this.uaEmployeeBtnDelete.Name = "uaEmployeeBtnDelete";
            this.uaEmployeeBtnDelete.Size = new System.Drawing.Size(93, 38);
            this.uaEmployeeBtnDelete.TabIndex = 42;
            this.uaEmployeeBtnDelete.Text = "Delete";
            this.uaEmployeeBtnDelete.UseVisualStyleBackColor = false;
            this.uaEmployeeBtnDelete.MouseLeave += new System.EventHandler(this.uaEmployeeBtnDelete_MouseLeave);
            this.uaEmployeeBtnDelete.Click += new System.EventHandler(this.uaEmployeeBtnDelete_Click);
            this.uaEmployeeBtnDelete.MouseEnter += new System.EventHandler(this.uaEmployeeBtnDelete_MouseEnter);
            // 
            // uaEmployeeBtnInsert
            // 
            this.uaEmployeeBtnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaEmployeeBtnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaEmployeeBtnInsert.BackgroundImage")));
            this.uaEmployeeBtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaEmployeeBtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaEmployeeBtnInsert.Location = new System.Drawing.Point(267, 582);
            this.uaEmployeeBtnInsert.Name = "uaEmployeeBtnInsert";
            this.uaEmployeeBtnInsert.Size = new System.Drawing.Size(93, 38);
            this.uaEmployeeBtnInsert.TabIndex = 40;
            this.uaEmployeeBtnInsert.Text = "Insert";
            this.uaEmployeeBtnInsert.UseVisualStyleBackColor = true;
            this.uaEmployeeBtnInsert.MouseLeave += new System.EventHandler(this.uaEmployeeBtnInsert_MouseLeave);
            this.uaEmployeeBtnInsert.Click += new System.EventHandler(this.uaEmployeeBtnInsert_Click);
            this.uaEmployeeBtnInsert.MouseEnter += new System.EventHandler(this.uaEmployeeBtnInsert_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.uaEmployeeDGList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 303);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // uaEmployeeDGList
            // 
            this.uaEmployeeDGList.AllowUserToDeleteRows = false;
            this.uaEmployeeDGList.AutoGenerateColumns = false;
            this.uaEmployeeDGList.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.uaEmployeeDGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uaEmployeeDGList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.permissionDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.uaEmployeeDGList.DataSource = this.employeeBindingSource;
            this.uaEmployeeDGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaEmployeeDGList.GridColor = System.Drawing.Color.Black;
            this.uaEmployeeDGList.Location = new System.Drawing.Point(3, 17);
            this.uaEmployeeDGList.MultiSelect = false;
            this.uaEmployeeDGList.Name = "uaEmployeeDGList";
            this.uaEmployeeDGList.ReadOnly = true;
            this.uaEmployeeDGList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uaEmployeeDGList.Size = new System.Drawing.Size(812, 283);
            this.uaEmployeeDGList.TabIndex = 0;
            this.uaEmployeeDGList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uaEmployeeDGList_CellClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "Permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            this.permissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            this.jobtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // uaEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uaEmployeeBtnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uaEmployeeBtnDelete);
            this.Controls.Add(this.uaEmployeeBtnInsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "uaEmployee";
            this.Size = new System.Drawing.Size(843, 650);
            this.Load += new System.EventHandler(this.uaEmployee_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uaEmployeeDGList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button uaEmployeeBtnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uaEmployeeTxtSalary;
        private System.Windows.Forms.TextBox uaEmployeeTxtPhone;
        private System.Windows.Forms.TextBox uaEmployeeTxtJobtitle;
        private System.Windows.Forms.TextBox uaEmployeeTxtAddress;
        private System.Windows.Forms.TextBox uaEmployeeTxtPassword;
        private System.Windows.Forms.TextBox uaEmployeeTxtFullName;
        private System.Windows.Forms.TextBox uaEmployeeTxtUserName;
        private System.Windows.Forms.DateTimePicker uaEmployeeDateTimeBirth;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox uaEmployeeCboPermission;
        private System.Windows.Forms.ComboBox uaEmployeeCboSex;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uaEmployeeBtnDelete;
        private System.Windows.Forms.Button uaEmployeeBtnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView uaEmployeeDGList;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSet1 dataSet1;
        private qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
