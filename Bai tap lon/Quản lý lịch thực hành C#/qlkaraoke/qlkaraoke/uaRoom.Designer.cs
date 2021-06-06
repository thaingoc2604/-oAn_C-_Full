namespace qlkaraoke
{
    partial class uaRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uaRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.uaRoomCBoxKind = new System.Windows.Forms.ComboBox();
            this.uaRoomTxtRoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uaRoomTxtDescription = new System.Windows.Forms.TextBox();
            this.uaRoomcboxStatus = new System.Windows.Forms.CheckBox();
            this.uaRoomBtnUpdate = new System.Windows.Forms.Button();
            this.uaRoomBtnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uaRoomBtnDelete = new System.Windows.Forms.Button();
            this.uaRoomDGList = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.kindroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindroomTableAdapter = new qlkaraoke.DataSet1TableAdapters.KindroomTableAdapter();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindroomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uaRoomDGList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room name";
            // 
            // uaRoomCBoxKind
            // 
            this.uaRoomCBoxKind.DataSource = this.kindroomBindingSource;
            this.uaRoomCBoxKind.DisplayMember = "Kind_name";
            this.uaRoomCBoxKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaRoomCBoxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaRoomCBoxKind.FormattingEnabled = true;
            this.uaRoomCBoxKind.Location = new System.Drawing.Point(382, 3);
            this.uaRoomCBoxKind.Name = "uaRoomCBoxKind";
            this.uaRoomCBoxKind.Size = new System.Drawing.Size(279, 21);
            this.uaRoomCBoxKind.TabIndex = 24;
            this.uaRoomCBoxKind.ValueMember = "Kindroom_ID";
            // 
            // uaRoomTxtRoomName
            // 
            this.uaRoomTxtRoomName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaRoomTxtRoomName.Location = new System.Drawing.Point(73, 3);
            this.uaRoomTxtRoomName.Name = "uaRoomTxtRoomName";
            this.uaRoomTxtRoomName.Size = new System.Drawing.Size(269, 20);
            this.uaRoomTxtRoomName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.1453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8547F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uaRoomCBoxKind, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uaRoomTxtRoomName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uaRoomTxtDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uaRoomcboxStatus, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 128);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // uaRoomTxtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uaRoomTxtDescription, 3);
            this.uaRoomTxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaRoomTxtDescription.Location = new System.Drawing.Point(73, 30);
            this.uaRoomTxtDescription.Multiline = true;
            this.uaRoomTxtDescription.Name = "uaRoomTxtDescription";
            this.uaRoomTxtDescription.Size = new System.Drawing.Size(588, 68);
            this.uaRoomTxtDescription.TabIndex = 19;
            // 
            // uaRoomcboxStatus
            // 
            this.uaRoomcboxStatus.AutoSize = true;
            this.uaRoomcboxStatus.Location = new System.Drawing.Point(73, 104);
            this.uaRoomcboxStatus.Name = "uaRoomcboxStatus";
            this.uaRoomcboxStatus.Size = new System.Drawing.Size(15, 14);
            this.uaRoomcboxStatus.TabIndex = 26;
            this.uaRoomcboxStatus.UseVisualStyleBackColor = true;
            // 
            // uaRoomBtnUpdate
            // 
            this.uaRoomBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaRoomBtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaRoomBtnUpdate.BackgroundImage")));
            this.uaRoomBtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaRoomBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaRoomBtnUpdate.Location = new System.Drawing.Point(306, 471);
            this.uaRoomBtnUpdate.Name = "uaRoomBtnUpdate";
            this.uaRoomBtnUpdate.Size = new System.Drawing.Size(93, 38);
            this.uaRoomBtnUpdate.TabIndex = 28;
            this.uaRoomBtnUpdate.Text = "Update";
            this.uaRoomBtnUpdate.UseVisualStyleBackColor = true;
            this.uaRoomBtnUpdate.MouseLeave += new System.EventHandler(this.uaRoomBtnUpdate_MouseLeave);
            this.uaRoomBtnUpdate.Click += new System.EventHandler(this.uaRoomBtnUpdate_Click);
            this.uaRoomBtnUpdate.MouseEnter += new System.EventHandler(this.uaRoomBtnUpdate_MouseEnter);
            // 
            // uaRoomBtnInsert
            // 
            this.uaRoomBtnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaRoomBtnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaRoomBtnInsert.BackgroundImage")));
            this.uaRoomBtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaRoomBtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaRoomBtnInsert.Location = new System.Drawing.Point(207, 471);
            this.uaRoomBtnInsert.Name = "uaRoomBtnInsert";
            this.uaRoomBtnInsert.Size = new System.Drawing.Size(93, 38);
            this.uaRoomBtnInsert.TabIndex = 27;
            this.uaRoomBtnInsert.Text = "Insert";
            this.uaRoomBtnInsert.UseVisualStyleBackColor = true;
            this.uaRoomBtnInsert.MouseLeave += new System.EventHandler(this.uaRoomBtnInsert_MouseLeave);
            this.uaRoomBtnInsert.Click += new System.EventHandler(this.uaRoomBtnInsert_Click);
            this.uaRoomBtnInsert.MouseEnter += new System.EventHandler(this.uaRoomBtnInsert_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uaRoomDGList);
            this.groupBox1.Location = new System.Drawing.Point(22, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 313);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // uaRoomBtnDelete
            // 
            this.uaRoomBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaRoomBtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaRoomBtnDelete.BackgroundImage")));
            this.uaRoomBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaRoomBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaRoomBtnDelete.Location = new System.Drawing.Point(405, 471);
            this.uaRoomBtnDelete.Name = "uaRoomBtnDelete";
            this.uaRoomBtnDelete.Size = new System.Drawing.Size(93, 38);
            this.uaRoomBtnDelete.TabIndex = 29;
            this.uaRoomBtnDelete.Text = "Delete";
            this.uaRoomBtnDelete.UseVisualStyleBackColor = true;
            this.uaRoomBtnDelete.MouseLeave += new System.EventHandler(this.uaRoomBtnDelete_MouseLeave);
            this.uaRoomBtnDelete.Click += new System.EventHandler(this.uaRoomBtnDelete_Click);
            this.uaRoomBtnDelete.MouseEnter += new System.EventHandler(this.uaRoomBtnDelete_MouseEnter);
            // 
            // uaRoomDGList
            // 
            this.uaRoomDGList.AllowUserToDeleteRows = false;
            this.uaRoomDGList.AutoGenerateColumns = false;
            this.uaRoomDGList.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.uaRoomDGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uaRoomDGList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomnameDataGridViewTextBoxColumn,
            this.kindroomIDDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.roomdescDataGridViewTextBoxColumn});
            this.uaRoomDGList.DataSource = this.roomBindingSource;
            this.uaRoomDGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaRoomDGList.GridColor = System.Drawing.Color.Black;
            this.uaRoomDGList.Location = new System.Drawing.Point(3, 16);
            this.uaRoomDGList.MultiSelect = false;
            this.uaRoomDGList.Name = "uaRoomDGList";
            this.uaRoomDGList.ReadOnly = true;
            this.uaRoomDGList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uaRoomDGList.Size = new System.Drawing.Size(658, 294);
            this.uaRoomDGList.TabIndex = 0;
            this.uaRoomDGList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uaRoomDGList_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kindroomBindingSource
            // 
            this.kindroomBindingSource.DataMember = "Kindroom";
            this.kindroomBindingSource.DataSource = this.dataSet1;
            // 
            // kindroomTableAdapter
            // 
            this.kindroomTableAdapter.ClearBeforeFill = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dataSet1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "Room_name";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "Room_name";
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kindroomIDDataGridViewTextBoxColumn
            // 
            this.kindroomIDDataGridViewTextBoxColumn.DataPropertyName = "Kindroom_ID";
            this.kindroomIDDataGridViewTextBoxColumn.HeaderText = "Kindroom_ID";
            this.kindroomIDDataGridViewTextBoxColumn.Name = "kindroomIDDataGridViewTextBoxColumn";
            this.kindroomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "Start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "End_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "End_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomdescDataGridViewTextBoxColumn
            // 
            this.roomdescDataGridViewTextBoxColumn.DataPropertyName = "Room_desc";
            this.roomdescDataGridViewTextBoxColumn.HeaderText = "Room_desc";
            this.roomdescDataGridViewTextBoxColumn.Name = "roomdescDataGridViewTextBoxColumn";
            this.roomdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uaRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uaRoomBtnUpdate);
            this.Controls.Add(this.uaRoomBtnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uaRoomBtnDelete);
            this.Name = "uaRoom";
            this.Size = new System.Drawing.Size(709, 526);
            this.Load += new System.EventHandler(this.uaRoom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uaRoomDGList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uaRoomCBoxKind;
        private System.Windows.Forms.TextBox uaRoomTxtRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uaRoomTxtDescription;
        private System.Windows.Forms.CheckBox uaRoomcboxStatus;
        private System.Windows.Forms.Button uaRoomBtnUpdate;
        private System.Windows.Forms.Button uaRoomBtnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uaRoomBtnDelete;
        private System.Windows.Forms.BindingSource kindroomBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView uaRoomDGList;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindroomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private qlkaraoke.DataSet1TableAdapters.KindroomTableAdapter kindroomTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
    }
}
