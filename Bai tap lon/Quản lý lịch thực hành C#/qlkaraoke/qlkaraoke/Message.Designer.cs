namespace qlkaraoke
{
    partial class fMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            this.fMessageTxtContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fMessageLbSendBy = new System.Windows.Forms.Label();
            this.fMessageBtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fMessageLbSender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fMessageUserBtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fMessageLbContent = new System.Windows.Forms.Label();
            this.fMessageUserDGRList = new System.Windows.Forms.DataGridView();
            this.messIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereceiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.fMessageUserBtnDelete = new System.Windows.Forms.Button();
            this.messageTableAdapter = new qlkaraoke.DataSet1TableAdapters.MessageTableAdapter();
            this.fMessageUserBtnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fMessageUserDGRList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fMessageTxtContent
            // 
            this.fMessageTxtContent.Location = new System.Drawing.Point(71, 91);
            this.fMessageTxtContent.Multiline = true;
            this.fMessageTxtContent.Name = "fMessageTxtContent";
            this.fMessageTxtContent.Size = new System.Drawing.Size(443, 125);
            this.fMessageTxtContent.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Send by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "MESSAGE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // fMessageLbSendBy
            // 
            this.fMessageLbSendBy.AutoSize = true;
            this.fMessageLbSendBy.BackColor = System.Drawing.Color.Transparent;
            this.fMessageLbSendBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageLbSendBy.Location = new System.Drawing.Point(68, 66);
            this.fMessageLbSendBy.Name = "fMessageLbSendBy";
            this.fMessageLbSendBy.Size = new System.Drawing.Size(45, 13);
            this.fMessageLbSendBy.TabIndex = 36;
            this.fMessageLbSendBy.Text = "person";
            // 
            // fMessageBtnClose
            // 
            this.fMessageBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageBtnClose.ImageIndex = 1;
            this.fMessageBtnClose.Location = new System.Drawing.Point(220, 228);
            this.fMessageBtnClose.Name = "fMessageBtnClose";
            this.fMessageBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fMessageBtnClose.TabIndex = 37;
            this.fMessageBtnClose.Text = "Close";
            this.fMessageBtnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sender";
            // 
            // fMessageLbSender
            // 
            this.fMessageLbSender.AutoSize = true;
            this.fMessageLbSender.BackColor = System.Drawing.Color.Transparent;
            this.fMessageLbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageLbSender.Location = new System.Drawing.Point(57, 8);
            this.fMessageLbSender.Name = "fMessageLbSender";
            this.fMessageLbSender.Size = new System.Drawing.Size(0, 13);
            this.fMessageLbSender.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Content";
            // 
            // fMessageUserBtnClose
            // 
            this.fMessageUserBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMessageUserBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageUserBtnClose.Location = new System.Drawing.Point(337, 329);
            this.fMessageUserBtnClose.Name = "fMessageUserBtnClose";
            this.fMessageUserBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fMessageUserBtnClose.TabIndex = 40;
            this.fMessageUserBtnClose.Text = "Close";
            this.fMessageUserBtnClose.UseVisualStyleBackColor = true;
            this.fMessageUserBtnClose.MouseLeave += new System.EventHandler(this.fMessageUserBtnClose_MouseLeave);
            this.fMessageUserBtnClose.Click += new System.EventHandler(this.fMessageUserBtnClose_Click);
            this.fMessageUserBtnClose.MouseEnter += new System.EventHandler(this.fMessageUserBtnClose_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.fMessageLbContent);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 102);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // fMessageLbContent
            // 
            this.fMessageLbContent.AutoSize = true;
            this.fMessageLbContent.BackColor = System.Drawing.Color.Transparent;
            this.fMessageLbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageLbContent.Location = new System.Drawing.Point(6, 16);
            this.fMessageLbContent.Name = "fMessageLbContent";
            this.fMessageLbContent.Size = new System.Drawing.Size(0, 13);
            this.fMessageLbContent.TabIndex = 34;
            // 
            // fMessageUserDGRList
            // 
            this.fMessageUserDGRList.AllowUserToAddRows = false;
            this.fMessageUserDGRList.AllowUserToDeleteRows = false;
            this.fMessageUserDGRList.AutoGenerateColumns = false;
            this.fMessageUserDGRList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fMessageUserDGRList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.fMessageUserDGRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fMessageUserDGRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messIDDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.datereceiveDataGridViewTextBoxColumn,
            this.datesendDataGridViewTextBoxColumn,
            this.messcontentDataGridViewTextBoxColumn,
            this.messstatusDataGridViewCheckBoxColumn});
            this.fMessageUserDGRList.DataSource = this.messageBindingSource;
            this.fMessageUserDGRList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fMessageUserDGRList.Location = new System.Drawing.Point(60, 152);
            this.fMessageUserDGRList.Name = "fMessageUserDGRList";
            this.fMessageUserDGRList.Size = new System.Drawing.Size(502, 168);
            this.fMessageUserDGRList.TabIndex = 42;
            this.fMessageUserDGRList.Click += new System.EventHandler(this.fMessageUserDGRList_Click);
            // 
            // messIDDataGridViewTextBoxColumn
            // 
            this.messIDDataGridViewTextBoxColumn.DataPropertyName = "Mess_ID";
            this.messIDDataGridViewTextBoxColumn.HeaderText = "Mess_ID";
            this.messIDDataGridViewTextBoxColumn.Name = "messIDDataGridViewTextBoxColumn";
            this.messIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "Receiver";
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            // 
            // datereceiveDataGridViewTextBoxColumn
            // 
            this.datereceiveDataGridViewTextBoxColumn.DataPropertyName = "Date_receive";
            this.datereceiveDataGridViewTextBoxColumn.HeaderText = "Date_receive";
            this.datereceiveDataGridViewTextBoxColumn.Name = "datereceiveDataGridViewTextBoxColumn";
            // 
            // datesendDataGridViewTextBoxColumn
            // 
            this.datesendDataGridViewTextBoxColumn.DataPropertyName = "Date_send";
            this.datesendDataGridViewTextBoxColumn.HeaderText = "Date_send";
            this.datesendDataGridViewTextBoxColumn.Name = "datesendDataGridViewTextBoxColumn";
            // 
            // messcontentDataGridViewTextBoxColumn
            // 
            this.messcontentDataGridViewTextBoxColumn.DataPropertyName = "Mess_content";
            this.messcontentDataGridViewTextBoxColumn.HeaderText = "Mess_content";
            this.messcontentDataGridViewTextBoxColumn.Name = "messcontentDataGridViewTextBoxColumn";
            // 
            // messstatusDataGridViewCheckBoxColumn
            // 
            this.messstatusDataGridViewCheckBoxColumn.DataPropertyName = "Mess_status";
            this.messstatusDataGridViewCheckBoxColumn.HeaderText = "Mess_status";
            this.messstatusDataGridViewCheckBoxColumn.Name = "messstatusDataGridViewCheckBoxColumn";
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "Message";
            this.messageBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "List";
            // 
            // fMessageUserBtnDelete
            // 
            this.fMessageUserBtnDelete.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMessageUserBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageUserBtnDelete.Location = new System.Drawing.Point(244, 329);
            this.fMessageUserBtnDelete.Name = "fMessageUserBtnDelete";
            this.fMessageUserBtnDelete.Size = new System.Drawing.Size(87, 39);
            this.fMessageUserBtnDelete.TabIndex = 44;
            this.fMessageUserBtnDelete.Text = "Delete";
            this.fMessageUserBtnDelete.UseVisualStyleBackColor = true;
            this.fMessageUserBtnDelete.MouseLeave += new System.EventHandler(this.fMessageUserBtnDelete_MouseLeave);
            this.fMessageUserBtnDelete.Click += new System.EventHandler(this.fMessageUserBtnDelete_Click);
            this.fMessageUserBtnDelete.MouseEnter += new System.EventHandler(this.fMessageUserBtnDelete_MouseEnter);
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // fMessageUserBtnComplete
            // 
            this.fMessageUserBtnComplete.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fMessageUserBtnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fMessageUserBtnComplete.Location = new System.Drawing.Point(151, 329);
            this.fMessageUserBtnComplete.Name = "fMessageUserBtnComplete";
            this.fMessageUserBtnComplete.Size = new System.Drawing.Size(87, 39);
            this.fMessageUserBtnComplete.TabIndex = 45;
            this.fMessageUserBtnComplete.Text = "Complete";
            this.fMessageUserBtnComplete.UseVisualStyleBackColor = true;
            this.fMessageUserBtnComplete.MouseLeave += new System.EventHandler(this.fMessageUserBtnComplete_MouseLeave);
            this.fMessageUserBtnComplete.Click += new System.EventHandler(this.fMessageUserBtnComplete_Click);
            this.fMessageUserBtnComplete.MouseEnter += new System.EventHandler(this.fMessageUserBtnComplete_MouseEnter);
            // 
            // fMessage
            // 
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(574, 375);
            this.Controls.Add(this.fMessageUserBtnComplete);
            this.Controls.Add(this.fMessageUserBtnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fMessageUserDGRList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fMessageUserBtnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fMessageLbSender);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.fMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fMessageUserDGRList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fMessageTxtContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fMessageLbSendBy;
        private System.Windows.Forms.Button fMessageBtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fMessageLbSender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fMessageUserBtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fMessageLbContent;
        private System.Windows.Forms.DataGridView fMessageUserDGRList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fMessageUserBtnDelete;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private qlkaraoke.DataSet1TableAdapters.MessageTableAdapter messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn messIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereceiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn messstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button fMessageUserBtnComplete;
    }
}