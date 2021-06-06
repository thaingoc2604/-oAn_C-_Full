namespace qlkaraoke
{
    partial class fReserveRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReserveRoom));
            this.fReserveRoomTxtCustomerName = new System.Windows.Forms.TextBox();
            this.fReserveRoomDTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fReserveRoomTxtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fReserveRoomTxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fReserveRoomTxtPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fReserveRoomBtnClose = new System.Windows.Forms.Button();
            this.fReserveRoomBtnAccept = new System.Windows.Forms.Button();
            this.fReserveRoomTxtMoreDes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fReserveRoomTxtCBoxKindRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.fReserveRoomTxtTime2 = new System.Windows.Forms.TextBox();
            this.reserveroomTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.ReserveroomTableAdapter();
            this.roomTableAdapter = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fReserveRoomTxtCustomerName
            // 
            this.fReserveRoomTxtCustomerName.Location = new System.Drawing.Point(98, 68);
            this.fReserveRoomTxtCustomerName.Name = "fReserveRoomTxtCustomerName";
            this.fReserveRoomTxtCustomerName.Size = new System.Drawing.Size(160, 20);
            this.fReserveRoomTxtCustomerName.TabIndex = 31;
            // 
            // fReserveRoomDTimeFrom
            // 
            this.fReserveRoomDTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.fReserveRoomDTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fReserveRoomDTimeFrom.Location = new System.Drawing.Point(300, 68);
            this.fReserveRoomDTimeFrom.Name = "fReserveRoomDTimeFrom";
            this.fReserveRoomDTimeFrom.Size = new System.Drawing.Size(122, 20);
            this.fReserveRoomDTimeFrom.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date";
            // 
            // fReserveRoomTxtTel
            // 
            this.fReserveRoomTxtTel.Location = new System.Drawing.Point(98, 130);
            this.fReserveRoomTxtTel.MaxLength = 15;
            this.fReserveRoomTxtTel.Name = "fReserveRoomTxtTel";
            this.fReserveRoomTxtTel.Size = new System.Drawing.Size(160, 20);
            this.fReserveRoomTxtTel.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tel";
            // 
            // fReserveRoomTxtAddress
            // 
            this.fReserveRoomTxtAddress.Location = new System.Drawing.Point(300, 130);
            this.fReserveRoomTxtAddress.Name = "fReserveRoomTxtAddress";
            this.fReserveRoomTxtAddress.Size = new System.Drawing.Size(259, 20);
            this.fReserveRoomTxtAddress.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(257, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Address";
            // 
            // fReserveRoomTxtPerson
            // 
            this.fReserveRoomTxtPerson.Location = new System.Drawing.Point(300, 99);
            this.fReserveRoomTxtPerson.MaxLength = 2;
            this.fReserveRoomTxtPerson.Name = "fReserveRoomTxtPerson";
            this.fReserveRoomTxtPerson.Size = new System.Drawing.Size(122, 20);
            this.fReserveRoomTxtPerson.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(257, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Person";
            // 
            // fReserveRoomBtnClose
            // 
            this.fReserveRoomBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fReserveRoomBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fReserveRoomBtnClose.Location = new System.Drawing.Point(290, 239);
            this.fReserveRoomBtnClose.Name = "fReserveRoomBtnClose";
            this.fReserveRoomBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fReserveRoomBtnClose.TabIndex = 39;
            this.fReserveRoomBtnClose.Text = "Close";
            this.fReserveRoomBtnClose.UseVisualStyleBackColor = true;
            this.fReserveRoomBtnClose.MouseLeave += new System.EventHandler(this.fReserveRoomBtnClose_MouseLeave);
            this.fReserveRoomBtnClose.Click += new System.EventHandler(this.fReserveRoomBtnClose_Click);
            this.fReserveRoomBtnClose.MouseEnter += new System.EventHandler(this.fReserveRoomBtnClose_MouseEnter);
            // 
            // fReserveRoomBtnAccept
            // 
            this.fReserveRoomBtnAccept.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fReserveRoomBtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fReserveRoomBtnAccept.Location = new System.Drawing.Point(197, 239);
            this.fReserveRoomBtnAccept.Name = "fReserveRoomBtnAccept";
            this.fReserveRoomBtnAccept.Size = new System.Drawing.Size(87, 39);
            this.fReserveRoomBtnAccept.TabIndex = 38;
            this.fReserveRoomBtnAccept.Text = "Accept";
            this.fReserveRoomBtnAccept.UseVisualStyleBackColor = true;
            this.fReserveRoomBtnAccept.MouseLeave += new System.EventHandler(this.fReserveRoomBtnAccept_MouseLeave);
            this.fReserveRoomBtnAccept.Click += new System.EventHandler(this.fReserveRoomBtnAccept_Click);
            this.fReserveRoomBtnAccept.MouseEnter += new System.EventHandler(this.fReserveRoomBtnAccept_MouseEnter);
            // 
            // fReserveRoomTxtMoreDes
            // 
            this.fReserveRoomTxtMoreDes.Location = new System.Drawing.Point(98, 168);
            this.fReserveRoomTxtMoreDes.Multiline = true;
            this.fReserveRoomTxtMoreDes.Name = "fReserveRoomTxtMoreDes";
            this.fReserveRoomTxtMoreDes.Size = new System.Drawing.Size(461, 62);
            this.fReserveRoomTxtMoreDes.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "More Description";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(58, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(515, 23);
            this.label25.TabIndex = 44;
            this.label25.Text = "RESERVE ROOM";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(454, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Kind room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(10, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 47;
            // 
            // fReserveRoomTxtCBoxKindRoom
            // 
            this.fReserveRoomTxtCBoxKindRoom.DataSource = this.roomBindingSource;
            this.fReserveRoomTxtCBoxKindRoom.DisplayMember = "Room_name";
            this.fReserveRoomTxtCBoxKindRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fReserveRoomTxtCBoxKindRoom.FormattingEnabled = true;
            this.fReserveRoomTxtCBoxKindRoom.Location = new System.Drawing.Point(98, 98);
            this.fReserveRoomTxtCBoxKindRoom.Name = "fReserveRoomTxtCBoxKindRoom";
            this.fReserveRoomTxtCBoxKindRoom.Size = new System.Drawing.Size(160, 21);
            this.fReserveRoomTxtCBoxKindRoom.TabIndex = 49;
            this.fReserveRoomTxtCBoxKindRoom.ValueMember = "Room_ID";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fReserveRoomTxtTime2
            // 
            this.fReserveRoomTxtTime2.Location = new System.Drawing.Point(490, 68);
            this.fReserveRoomTxtTime2.MaxLength = 4;
            this.fReserveRoomTxtTime2.Name = "fReserveRoomTxtTime2";
            this.fReserveRoomTxtTime2.Size = new System.Drawing.Size(69, 20);
            this.fReserveRoomTxtTime2.TabIndex = 50;
            // 
            // reserveroomTableAdapter1
            // 
            this.reserveroomTableAdapter1.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // fReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(574, 288);
            this.Controls.Add(this.fReserveRoomTxtTime2);
            this.Controls.Add(this.fReserveRoomTxtCBoxKindRoom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fReserveRoomTxtMoreDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fReserveRoomBtnClose);
            this.Controls.Add(this.fReserveRoomBtnAccept);
            this.Controls.Add(this.fReserveRoomTxtPerson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fReserveRoomTxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fReserveRoomTxtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fReserveRoomTxtCustomerName);
            this.Controls.Add(this.fReserveRoomDTimeFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fReserveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Room";
            this.Load += new System.EventHandler(this.fReserveRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fReserveRoomTxtCustomerName;
        private System.Windows.Forms.DateTimePicker fReserveRoomDTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fReserveRoomTxtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fReserveRoomTxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fReserveRoomTxtPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fReserveRoomBtnClose;
        private System.Windows.Forms.Button fReserveRoomBtnAccept;
        private System.Windows.Forms.TextBox fReserveRoomTxtMoreDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox fReserveRoomTxtCBoxKindRoom;
        private DataSet1 dataSet1;
        private System.Windows.Forms.TextBox fReserveRoomTxtTime2;
        private qlkaraoke.DataSet1TableAdapters.ReserveroomTableAdapter reserveroomTableAdapter1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
    }
}