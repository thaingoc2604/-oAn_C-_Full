namespace qlkaraoke
{
    partial class uaCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uaCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uaCustomerTxtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uaCustomerTxtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uaCustomerTxtEmail = new System.Windows.Forms.TextBox();
            this.uaCustomerTxtIDNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uaCustomerTxtPhone = new System.Windows.Forms.TextBox();
            this.uaCustomerCboKind = new System.Windows.Forms.ComboBox();
            this.kindcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uaCustomerDGList = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindcustomerTableAdapter = new qlkaraoke.DataSet1TableAdapters.KindcustomerTableAdapter();
            this.customerTableAdapter = new qlkaraoke.DataSet1TableAdapters.CustomerTableAdapter();
            this.uaCustomerBtnDelete = new System.Windows.Forms.Button();
            this.uaCustomerBtnUpdate = new System.Windows.Forms.Button();
            this.uaCustomerBtnInsert = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uaCustomerDGList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerTxtFullname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerTxtAddress, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerTxtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerTxtIDNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerTxtPhone, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.uaCustomerCboKind, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uaCustomerTxtFullname
            // 
            this.uaCustomerTxtFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerTxtFullname.Location = new System.Drawing.Point(105, 3);
            this.uaCustomerTxtFullname.Name = "uaCustomerTxtFullname";
            this.uaCustomerTxtFullname.Size = new System.Drawing.Size(321, 21);
            this.uaCustomerTxtFullname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // uaCustomerTxtAddress
            // 
            this.uaCustomerTxtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerTxtAddress.Location = new System.Drawing.Point(489, 87);
            this.uaCustomerTxtAddress.Name = "uaCustomerTxtAddress";
            this.uaCustomerTxtAddress.Size = new System.Drawing.Size(322, 21);
            this.uaCustomerTxtAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // uaCustomerTxtEmail
            // 
            this.uaCustomerTxtEmail.BackColor = System.Drawing.Color.White;
            this.uaCustomerTxtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerTxtEmail.Location = new System.Drawing.Point(105, 87);
            this.uaCustomerTxtEmail.Name = "uaCustomerTxtEmail";
            this.uaCustomerTxtEmail.Size = new System.Drawing.Size(321, 21);
            this.uaCustomerTxtEmail.TabIndex = 10;
            // 
            // uaCustomerTxtIDNumber
            // 
            this.uaCustomerTxtIDNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerTxtIDNumber.Location = new System.Drawing.Point(105, 45);
            this.uaCustomerTxtIDNumber.Name = "uaCustomerTxtIDNumber";
            this.uaCustomerTxtIDNumber.Size = new System.Drawing.Size(321, 21);
            this.uaCustomerTxtIDNumber.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // uaCustomerTxtPhone
            // 
            this.uaCustomerTxtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerTxtPhone.Location = new System.Drawing.Point(489, 45);
            this.uaCustomerTxtPhone.Name = "uaCustomerTxtPhone";
            this.uaCustomerTxtPhone.Size = new System.Drawing.Size(322, 21);
            this.uaCustomerTxtPhone.TabIndex = 6;
            // 
            // uaCustomerCboKind
            // 
            this.uaCustomerCboKind.DataSource = this.kindcustomerBindingSource;
            this.uaCustomerCboKind.DisplayMember = "Kind_name";
            this.uaCustomerCboKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerCboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaCustomerCboKind.FormattingEnabled = true;
            this.uaCustomerCboKind.Location = new System.Drawing.Point(489, 3);
            this.uaCustomerCboKind.Name = "uaCustomerCboKind";
            this.uaCustomerCboKind.Size = new System.Drawing.Size(322, 23);
            this.uaCustomerCboKind.TabIndex = 8;
            this.uaCustomerCboKind.ValueMember = "KindCustomer_ID";
            // 
            // kindcustomerBindingSource
            // 
            this.kindcustomerBindingSource.AllowNew = true;
            this.kindcustomerBindingSource.DataMember = "Kindcustomer";
            this.kindcustomerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Card ID Number";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 44);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uaCustomerDGList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // uaCustomerDGList
            // 
            this.uaCustomerDGList.AllowUserToDeleteRows = false;
            this.uaCustomerDGList.AutoGenerateColumns = false;
            this.uaCustomerDGList.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.uaCustomerDGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uaCustomerDGList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cardnumberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kindCustomerIDDataGridViewTextBoxColumn});
            this.uaCustomerDGList.DataSource = this.customerBindingSource;
            this.uaCustomerDGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaCustomerDGList.GridColor = System.Drawing.Color.Black;
            this.uaCustomerDGList.Location = new System.Drawing.Point(3, 17);
            this.uaCustomerDGList.MultiSelect = false;
            this.uaCustomerDGList.Name = "uaCustomerDGList";
            this.uaCustomerDGList.ReadOnly = true;
            this.uaCustomerDGList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uaCustomerDGList.Size = new System.Drawing.Size(744, 328);
            this.uaCustomerDGList.TabIndex = 0;
            this.uaCustomerDGList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uaCustomerDGList_CellClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardnumberDataGridViewTextBoxColumn
            // 
            this.cardnumberDataGridViewTextBoxColumn.DataPropertyName = "Card_number";
            this.cardnumberDataGridViewTextBoxColumn.HeaderText = "Card_number";
            this.cardnumberDataGridViewTextBoxColumn.Name = "cardnumberDataGridViewTextBoxColumn";
            this.cardnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kindCustomerIDDataGridViewTextBoxColumn
            // 
            this.kindCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "KindCustomer_ID";
            this.kindCustomerIDDataGridViewTextBoxColumn.HeaderText = "KindCustomer_ID";
            this.kindCustomerIDDataGridViewTextBoxColumn.Name = "kindCustomerIDDataGridViewTextBoxColumn";
            this.kindCustomerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.AllowNew = true;
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dataSet1;
            // 
            // kindcustomerTableAdapter
            // 
            this.kindcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // uaCustomerBtnDelete
            // 
            this.uaCustomerBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaCustomerBtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaCustomerBtnDelete.BackgroundImage")));
            this.uaCustomerBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaCustomerBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaCustomerBtnDelete.Location = new System.Drawing.Point(485, 540);
            this.uaCustomerBtnDelete.Name = "uaCustomerBtnDelete";
            this.uaCustomerBtnDelete.Size = new System.Drawing.Size(93, 38);
            this.uaCustomerBtnDelete.TabIndex = 7;
            this.uaCustomerBtnDelete.Text = "Delete";
            this.uaCustomerBtnDelete.UseVisualStyleBackColor = true;
            this.uaCustomerBtnDelete.MouseLeave += new System.EventHandler(this.uaCustomerBtnDelete_MouseLeave);
            this.uaCustomerBtnDelete.Click += new System.EventHandler(this.uaCustomerBtnDelete_Click);
            this.uaCustomerBtnDelete.MouseEnter += new System.EventHandler(this.uaCustomerBtnDelete_MouseEnter);
            // 
            // uaCustomerBtnUpdate
            // 
            this.uaCustomerBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaCustomerBtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaCustomerBtnUpdate.BackgroundImage")));
            this.uaCustomerBtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaCustomerBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaCustomerBtnUpdate.Location = new System.Drawing.Point(385, 540);
            this.uaCustomerBtnUpdate.Name = "uaCustomerBtnUpdate";
            this.uaCustomerBtnUpdate.Size = new System.Drawing.Size(93, 38);
            this.uaCustomerBtnUpdate.TabIndex = 5;
            this.uaCustomerBtnUpdate.Text = "Update";
            this.uaCustomerBtnUpdate.UseVisualStyleBackColor = true;
            this.uaCustomerBtnUpdate.MouseLeave += new System.EventHandler(this.uaCustomerBtnUpdate_MouseLeave);
            this.uaCustomerBtnUpdate.Click += new System.EventHandler(this.uaCustomerBtnUpdate_Click);
            this.uaCustomerBtnUpdate.MouseEnter += new System.EventHandler(this.uaCustomerBtnUpdate_MouseEnter);
            // 
            // uaCustomerBtnInsert
            // 
            this.uaCustomerBtnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaCustomerBtnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaCustomerBtnInsert.BackgroundImage")));
            this.uaCustomerBtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaCustomerBtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaCustomerBtnInsert.Location = new System.Drawing.Point(285, 540);
            this.uaCustomerBtnInsert.Name = "uaCustomerBtnInsert";
            this.uaCustomerBtnInsert.Size = new System.Drawing.Size(93, 38);
            this.uaCustomerBtnInsert.TabIndex = 6;
            this.uaCustomerBtnInsert.Text = "Insert";
            this.uaCustomerBtnInsert.UseVisualStyleBackColor = true;
            this.uaCustomerBtnInsert.MouseLeave += new System.EventHandler(this.uaCustomerBtnDelete_MouseLeave);
            this.uaCustomerBtnInsert.Click += new System.EventHandler(this.uaCustomerBtnInsert_Click);
            this.uaCustomerBtnInsert.MouseEnter += new System.EventHandler(this.uaCustomerBtnInsert_MouseEnter);
            // 
            // uaCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uaCustomerBtnDelete);
            this.Controls.Add(this.uaCustomerBtnUpdate);
            this.Controls.Add(this.uaCustomerBtnInsert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uaCustomer";
            this.Size = new System.Drawing.Size(863, 598);
            this.Load += new System.EventHandler(this.uaCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uaCustomerDGList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uaCustomerTxtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uaCustomerTxtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uaCustomerTxtEmail;
        private System.Windows.Forms.TextBox uaCustomerTxtIDNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uaCustomerTxtPhone;
        private System.Windows.Forms.ComboBox uaCustomerCboKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kindcustomerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private qlkaraoke.DataSet1TableAdapters.KindcustomerTableAdapter kindcustomerTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button uaCustomerBtnDelete;
        private System.Windows.Forms.Button uaCustomerBtnUpdate;
        private System.Windows.Forms.Button uaCustomerBtnInsert;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindCustomerIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView uaCustomerDGList;
    }
}
