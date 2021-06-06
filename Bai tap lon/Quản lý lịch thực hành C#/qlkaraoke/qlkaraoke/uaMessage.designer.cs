namespace qlkaraoke
{
    partial class uaMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uaMessage));
            this.uaMessageCboxReceiver = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uaMessageTxtTitle = new System.Windows.Forms.TextBox();
            this.uaMessageRtxtContent = new System.Windows.Forms.RichTextBox();
            this.uaMessageBtnSend = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter();
            this.messageTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.MessageTableAdapter();
            this.uaMessageBtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uaMessageCboxReceiver
            // 
            this.uaMessageCboxReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uaMessageCboxReceiver.DataSource = this.employeeBindingSource;
            this.uaMessageCboxReceiver.DisplayMember = "Full_name";
            this.uaMessageCboxReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaMessageCboxReceiver.FormattingEnabled = true;
            this.uaMessageCboxReceiver.Location = new System.Drawing.Point(83, 36);
            this.uaMessageCboxReceiver.Name = "uaMessageCboxReceiver";
            this.uaMessageCboxReceiver.Size = new System.Drawing.Size(220, 21);
            this.uaMessageCboxReceiver.TabIndex = 0;
            this.uaMessageCboxReceiver.ValueMember = "Full_name";
            this.uaMessageCboxReceiver.SelectedIndexChanged += new System.EventHandler(this.uaMessageCboxReceiver_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receiver";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content";
            // 
            // uaMessageTxtTitle
            // 
            this.uaMessageTxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uaMessageTxtTitle.Location = new System.Drawing.Point(83, 77);
            this.uaMessageTxtTitle.Name = "uaMessageTxtTitle";
            this.uaMessageTxtTitle.Size = new System.Drawing.Size(509, 20);
            this.uaMessageTxtTitle.TabIndex = 3;
            // 
            // uaMessageRtxtContent
            // 
            this.uaMessageRtxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uaMessageRtxtContent.Location = new System.Drawing.Point(83, 118);
            this.uaMessageRtxtContent.Name = "uaMessageRtxtContent";
            this.uaMessageRtxtContent.Size = new System.Drawing.Size(509, 169);
            this.uaMessageRtxtContent.TabIndex = 4;
            this.uaMessageRtxtContent.Text = "";
            // 
            // uaMessageBtnSend
            // 
            this.uaMessageBtnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaMessageBtnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaMessageBtnSend.BackgroundImage")));
            this.uaMessageBtnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaMessageBtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaMessageBtnSend.Location = new System.Drawing.Point(223, 332);
            this.uaMessageBtnSend.Name = "uaMessageBtnSend";
            this.uaMessageBtnSend.Size = new System.Drawing.Size(80, 33);
            this.uaMessageBtnSend.TabIndex = 37;
            this.uaMessageBtnSend.Text = "Send";
            this.uaMessageBtnSend.UseVisualStyleBackColor = true;
            this.uaMessageBtnSend.MouseLeave += new System.EventHandler(this.uaMessageBtnSend_MouseLeave);
            this.uaMessageBtnSend.Click += new System.EventHandler(this.uaMessageBtnSend_Click);
            this.uaMessageBtnSend.MouseEnter += new System.EventHandler(this.uaMessageBtnSend_MouseEnter);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // messageTableAdapter1
            // 
            this.messageTableAdapter1.ClearBeforeFill = true;
            // 
            // uaMessageBtnReset
            // 
            this.uaMessageBtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaMessageBtnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaMessageBtnReset.BackgroundImage")));
            this.uaMessageBtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaMessageBtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaMessageBtnReset.Location = new System.Drawing.Point(309, 332);
            this.uaMessageBtnReset.Name = "uaMessageBtnReset";
            this.uaMessageBtnReset.Size = new System.Drawing.Size(80, 33);
            this.uaMessageBtnReset.TabIndex = 38;
            this.uaMessageBtnReset.Text = "Reset";
            this.uaMessageBtnReset.UseVisualStyleBackColor = true;
            this.uaMessageBtnReset.MouseLeave += new System.EventHandler(this.uaMessageBtnReset_MouseLeave);
            this.uaMessageBtnReset.Click += new System.EventHandler(this.uaMessageBtnReset_Click);
            this.uaMessageBtnReset.MouseEnter += new System.EventHandler(this.uaMessageBtnReset_MouseEnter);
            // 
            // uaMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uaMessageBtnReset);
            this.Controls.Add(this.uaMessageBtnSend);
            this.Controls.Add(this.uaMessageRtxtContent);
            this.Controls.Add(this.uaMessageTxtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uaMessageCboxReceiver);
            this.Name = "uaMessage";
            this.Size = new System.Drawing.Size(611, 399);
            this.Load += new System.EventHandler(this.uaMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uaMessageCboxReceiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uaMessageTxtTitle;
        private System.Windows.Forms.RichTextBox uaMessageRtxtContent;
        private System.Windows.Forms.Button uaMessageBtnSend;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSet1 dataSet1;
        private qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.MessageTableAdapter messageTableAdapter1;
        private System.Windows.Forms.Button uaMessageBtnReset;
    }
}
