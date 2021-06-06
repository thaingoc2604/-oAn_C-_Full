namespace qlkaraoke
{
    partial class fRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoom));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fRoomTxtStartTime = new System.Windows.Forms.TextBox();
            this.fRoomTxtEndTime = new System.Windows.Forms.TextBox();
            this.fRoomTxtPersonNumber = new System.Windows.Forms.TextBox();
            this.fRoomCBoxPromotion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fRoomTxtVat = new System.Windows.Forms.TextBox();
            this.fRoomTxtTotal = new System.Windows.Forms.TextBox();
            this.fRoomBtnBill = new System.Windows.Forms.Button();
            this.fRoomBtnPayment = new System.Windows.Forms.Button();
            this.fRoomBtnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fRoomCBoxKindCustomer = new System.Windows.Forms.ComboBox();
            this.kindcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.label10 = new System.Windows.Forms.Label();
            this.fRoomTxtCBoxKindRoom = new System.Windows.Forms.ComboBox();
            this.kindroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.fRoomCBoxListDishes = new System.Windows.Forms.CheckedListBox();
            this.fRoomCBoxListBeberage = new System.Windows.Forms.CheckedListBox();
            this.billsTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.BillsTableAdapter();
            this.kindcustomerTableAdapter = new qlkaraoke.DataSet1TableAdapters.KindcustomerTableAdapter();
            this.kindroomTableAdapter = new qlkaraoke.DataSet1TableAdapters.KindroomTableAdapter();
            this.promotionTableAdapter = new qlkaraoke.DataSet1TableAdapters.PromotionTableAdapter();
            this.roomTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            this.goodsTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.GoodsTableAdapter();
            this.customerTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "ROOM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(297, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "End time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Promotion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(297, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Beberage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(297, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dishes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Person number";
            // 
            // fRoomTxtStartTime
            // 
            this.fRoomTxtStartTime.Location = new System.Drawing.Point(98, 66);
            this.fRoomTxtStartTime.Name = "fRoomTxtStartTime";
            this.fRoomTxtStartTime.Size = new System.Drawing.Size(178, 20);
            this.fRoomTxtStartTime.TabIndex = 22;
            // 
            // fRoomTxtEndTime
            // 
            this.fRoomTxtEndTime.Location = new System.Drawing.Point(380, 66);
            this.fRoomTxtEndTime.Name = "fRoomTxtEndTime";
            this.fRoomTxtEndTime.Size = new System.Drawing.Size(180, 20);
            this.fRoomTxtEndTime.TabIndex = 23;
            // 
            // fRoomTxtPersonNumber
            // 
            this.fRoomTxtPersonNumber.Location = new System.Drawing.Point(98, 97);
            this.fRoomTxtPersonNumber.Name = "fRoomTxtPersonNumber";
            this.fRoomTxtPersonNumber.Size = new System.Drawing.Size(178, 20);
            this.fRoomTxtPersonNumber.TabIndex = 24;
            // 
            // fRoomCBoxPromotion
            // 
            this.fRoomCBoxPromotion.FormattingEnabled = true;
            this.fRoomCBoxPromotion.Location = new System.Drawing.Point(99, 193);
            this.fRoomCBoxPromotion.Name = "fRoomCBoxPromotion";
            this.fRoomCBoxPromotion.Size = new System.Drawing.Size(177, 21);
            this.fRoomCBoxPromotion.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Vat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(20, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total";
            // 
            // fRoomTxtVat
            // 
            this.fRoomTxtVat.Location = new System.Drawing.Point(98, 225);
            this.fRoomTxtVat.Name = "fRoomTxtVat";
            this.fRoomTxtVat.Size = new System.Drawing.Size(178, 20);
            this.fRoomTxtVat.TabIndex = 30;
            // 
            // fRoomTxtTotal
            // 
            this.fRoomTxtTotal.Location = new System.Drawing.Point(97, 254);
            this.fRoomTxtTotal.Name = "fRoomTxtTotal";
            this.fRoomTxtTotal.Size = new System.Drawing.Size(179, 20);
            this.fRoomTxtTotal.TabIndex = 31;
            // 
            // fRoomBtnBill
            // 
            this.fRoomBtnBill.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fRoomBtnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fRoomBtnBill.Location = new System.Drawing.Point(244, 292);
            this.fRoomBtnBill.Name = "fRoomBtnBill";
            this.fRoomBtnBill.Size = new System.Drawing.Size(87, 39);
            this.fRoomBtnBill.TabIndex = 35;
            this.fRoomBtnBill.Text = "Bill";
            this.fRoomBtnBill.UseVisualStyleBackColor = true;
            this.fRoomBtnBill.MouseLeave += new System.EventHandler(this.fRoomBtnBill_MouseLeave);
            this.fRoomBtnBill.Click += new System.EventHandler(this.fRoomBtnBill_Click);
            this.fRoomBtnBill.MouseEnter += new System.EventHandler(this.fRoomBtnBill_MouseEnter);
            // 
            // fRoomBtnPayment
            // 
            this.fRoomBtnPayment.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fRoomBtnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fRoomBtnPayment.Location = new System.Drawing.Point(151, 292);
            this.fRoomBtnPayment.Name = "fRoomBtnPayment";
            this.fRoomBtnPayment.Size = new System.Drawing.Size(87, 39);
            this.fRoomBtnPayment.TabIndex = 34;
            this.fRoomBtnPayment.Text = "Payment";
            this.fRoomBtnPayment.UseVisualStyleBackColor = true;
            this.fRoomBtnPayment.MouseLeave += new System.EventHandler(this.fRoomBtnPayment_MouseLeave);
            this.fRoomBtnPayment.Click += new System.EventHandler(this.fRoomBtnPayment_Click);
            this.fRoomBtnPayment.MouseEnter += new System.EventHandler(this.fRoomBtnPayment_MouseEnter);
            // 
            // fRoomBtnClose
            // 
            this.fRoomBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fRoomBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fRoomBtnClose.Location = new System.Drawing.Point(337, 292);
            this.fRoomBtnClose.Name = "fRoomBtnClose";
            this.fRoomBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fRoomBtnClose.TabIndex = 32;
            this.fRoomBtnClose.Text = "Close";
            this.fRoomBtnClose.UseVisualStyleBackColor = true;
            this.fRoomBtnClose.MouseLeave += new System.EventHandler(this.fRoomBtnClose_MouseLeave);
            this.fRoomBtnClose.Click += new System.EventHandler(this.fRoomBtnClose_Click);
            this.fRoomBtnClose.MouseEnter += new System.EventHandler(this.fRoomBtnClose_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
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
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // fRoomCBoxKindCustomer
            // 
            this.fRoomCBoxKindCustomer.DataSource = this.kindcustomerBindingSource;
            this.fRoomCBoxKindCustomer.DisplayMember = "Kind_name";
            this.fRoomCBoxKindCustomer.FormattingEnabled = true;
            this.fRoomCBoxKindCustomer.Location = new System.Drawing.Point(98, 129);
            this.fRoomCBoxKindCustomer.Name = "fRoomCBoxKindCustomer";
            this.fRoomCBoxKindCustomer.Size = new System.Drawing.Size(178, 21);
            this.fRoomCBoxKindCustomer.TabIndex = 37;
            this.fRoomCBoxKindCustomer.ValueMember = "KindCustomer_ID";
            // 
            // kindcustomerBindingSource
            // 
            this.kindcustomerBindingSource.DataMember = "Kindcustomer";
            this.kindcustomerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(20, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Customer";
            // 
            // fRoomTxtCBoxKindRoom
            // 
            this.fRoomTxtCBoxKindRoom.DataSource = this.kindroomBindingSource;
            this.fRoomTxtCBoxKindRoom.DisplayMember = "Kind_name";
            this.fRoomTxtCBoxKindRoom.FormattingEnabled = true;
            this.fRoomTxtCBoxKindRoom.Location = new System.Drawing.Point(98, 161);
            this.fRoomTxtCBoxKindRoom.Name = "fRoomTxtCBoxKindRoom";
            this.fRoomTxtCBoxKindRoom.Size = new System.Drawing.Size(178, 21);
            this.fRoomTxtCBoxKindRoom.TabIndex = 39;
            this.fRoomTxtCBoxKindRoom.ValueMember = "Kindroom_ID";
            // 
            // kindroomBindingSource
            // 
            this.kindroomBindingSource.DataMember = "Kindroom";
            this.kindroomBindingSource.DataSource = this.dataSet1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(20, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Kind room";
            // 
            // fRoomCBoxListDishes
            // 
            this.fRoomCBoxListDishes.FormattingEnabled = true;
            this.fRoomCBoxListDishes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fRoomCBoxListDishes.Location = new System.Drawing.Point(380, 193);
            this.fRoomCBoxListDishes.Name = "fRoomCBoxListDishes";
            this.fRoomCBoxListDishes.Size = new System.Drawing.Size(180, 94);
            this.fRoomCBoxListDishes.TabIndex = 40;
            // 
            // fRoomCBoxListBeberage
            // 
            this.fRoomCBoxListBeberage.FormattingEnabled = true;
            this.fRoomCBoxListBeberage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fRoomCBoxListBeberage.Location = new System.Drawing.Point(380, 97);
            this.fRoomCBoxListBeberage.Name = "fRoomCBoxListBeberage";
            this.fRoomCBoxListBeberage.Size = new System.Drawing.Size(180, 79);
            this.fRoomCBoxListBeberage.TabIndex = 41;
            // 
            // billsTableAdapter1
            // 
            this.billsTableAdapter1.ClearBeforeFill = true;
            // 
            // kindcustomerTableAdapter
            // 
            this.kindcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // kindroomTableAdapter
            // 
            this.kindroomTableAdapter.ClearBeforeFill = true;
            // 
            // promotionTableAdapter
            // 
            this.promotionTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // fRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(574, 339);
            this.Controls.Add(this.fRoomCBoxListBeberage);
            this.Controls.Add(this.fRoomCBoxListDishes);
            this.Controls.Add(this.fRoomTxtCBoxKindRoom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fRoomCBoxKindCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fRoomBtnBill);
            this.Controls.Add(this.fRoomBtnPayment);
            this.Controls.Add(this.fRoomBtnClose);
            this.Controls.Add(this.fRoomTxtTotal);
            this.Controls.Add(this.fRoomTxtVat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fRoomCBoxPromotion);
            this.Controls.Add(this.fRoomTxtPersonNumber);
            this.Controls.Add(this.fRoomTxtEndTime);
            this.Controls.Add(this.fRoomTxtStartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL KARAOKE - Room";
            this.Load += new System.EventHandler(this.fRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindroomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fRoomTxtStartTime;
        private System.Windows.Forms.TextBox fRoomTxtEndTime;
        private System.Windows.Forms.TextBox fRoomTxtPersonNumber;
        private System.Windows.Forms.ComboBox fRoomCBoxPromotion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fRoomTxtVat;
        private System.Windows.Forms.TextBox fRoomTxtTotal;
        private System.Windows.Forms.Button fRoomBtnBill;
        private System.Windows.Forms.Button fRoomBtnPayment;
        private System.Windows.Forms.Button fRoomBtnClose;
        private System.Windows.Forms.ComboBox fRoomCBoxKindCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox fRoomTxtCBoxKindRoom;
        private System.Windows.Forms.Label label11;
        private qlkaraoke.DataSet1TableAdapters.BillsTableAdapter billsTableAdapter1;
        private System.Windows.Forms.CheckedListBox fRoomCBoxListDishes;
        private System.Windows.Forms.CheckedListBox fRoomCBoxListBeberage;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource kindcustomerBindingSource;
        private qlkaraoke.DataSet1TableAdapters.KindcustomerTableAdapter kindcustomerTableAdapter;
        private System.Windows.Forms.BindingSource kindroomBindingSource;
        private qlkaraoke.DataSet1TableAdapters.KindroomTableAdapter kindroomTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.PromotionTableAdapter promotionTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter roomTableAdapter1;
        private qlkaraoke.DataSet1TableAdapters.GoodsTableAdapter goodsTableAdapter1;
        private qlkaraoke.DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}