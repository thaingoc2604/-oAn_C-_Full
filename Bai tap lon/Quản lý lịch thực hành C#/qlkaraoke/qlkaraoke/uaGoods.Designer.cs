namespace qlkaraoke
{
    partial class uaGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uaGoods));
            this.uaGoodsCBoxKind = new System.Windows.Forms.ComboBox();
            this.goodkindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new qlkaraoke.DataSet1();
            this.goodsTableAdapter = new qlkaraoke.DataSet1TableAdapters.GoodsTableAdapter();
            this.uaGoodsBtnDelete = new System.Windows.Forms.Button();
            this.uaGoodsBtnUpdate = new System.Windows.Forms.Button();
            this.uaGoodsBtnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uaGoodsDGList = new System.Windows.Forms.DataGridView();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodkindIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uaGoodsTxtDescription = new System.Windows.Forms.TextBox();
            this.goodkindTableAdapter = new qlkaraoke.DataSet1TableAdapters.GoodkindTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.uaGoodsTxtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uaGoodsTxtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodkindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uaGoodsDGList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uaGoodsCBoxKind
            // 
            this.uaGoodsCBoxKind.DataSource = this.goodkindBindingSource;
            this.uaGoodsCBoxKind.DisplayMember = "Goodname";
            this.uaGoodsCBoxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uaGoodsCBoxKind.FormattingEnabled = true;
            this.uaGoodsCBoxKind.Location = new System.Drawing.Point(392, 11);
            this.uaGoodsCBoxKind.Name = "uaGoodsCBoxKind";
            this.uaGoodsCBoxKind.Size = new System.Drawing.Size(201, 21);
            this.uaGoodsCBoxKind.TabIndex = 24;
            this.uaGoodsCBoxKind.ValueMember = "Goodkind_ID";
            // 
            // goodkindBindingSource
            // 
            this.goodkindBindingSource.DataMember = "Goodkind";
            this.goodkindBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // uaGoodsBtnDelete
            // 
            this.uaGoodsBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsBtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaGoodsBtnDelete.BackgroundImage")));
            this.uaGoodsBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaGoodsBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsBtnDelete.Location = new System.Drawing.Point(351, 355);
            this.uaGoodsBtnDelete.Name = "uaGoodsBtnDelete";
            this.uaGoodsBtnDelete.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsBtnDelete.TabIndex = 23;
            this.uaGoodsBtnDelete.Text = "Delete";
            this.uaGoodsBtnDelete.UseVisualStyleBackColor = true;
            this.uaGoodsBtnDelete.MouseLeave += new System.EventHandler(this.uaGoodsBtnDelete_MouseLeave);
            this.uaGoodsBtnDelete.MouseEnter += new System.EventHandler(this.uaGoodsBtnDelete_MouseEnter);
            // 
            // uaGoodsBtnUpdate
            // 
            this.uaGoodsBtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsBtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaGoodsBtnUpdate.BackgroundImage")));
            this.uaGoodsBtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaGoodsBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsBtnUpdate.Location = new System.Drawing.Point(265, 355);
            this.uaGoodsBtnUpdate.Name = "uaGoodsBtnUpdate";
            this.uaGoodsBtnUpdate.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsBtnUpdate.TabIndex = 22;
            this.uaGoodsBtnUpdate.Text = "Update";
            this.uaGoodsBtnUpdate.UseVisualStyleBackColor = true;
            this.uaGoodsBtnUpdate.MouseLeave += new System.EventHandler(this.uaGoodsBtnUpdate_MouseLeave);
            this.uaGoodsBtnUpdate.MouseEnter += new System.EventHandler(this.uaGoodsBtnUpdate_MouseEnter);
            // 
            // uaGoodsBtnInsert
            // 
            this.uaGoodsBtnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uaGoodsBtnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uaGoodsBtnInsert.BackgroundImage")));
            this.uaGoodsBtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uaGoodsBtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaGoodsBtnInsert.Location = new System.Drawing.Point(179, 355);
            this.uaGoodsBtnInsert.Name = "uaGoodsBtnInsert";
            this.uaGoodsBtnInsert.Size = new System.Drawing.Size(80, 33);
            this.uaGoodsBtnInsert.TabIndex = 21;
            this.uaGoodsBtnInsert.Text = "Insert";
            this.uaGoodsBtnInsert.UseVisualStyleBackColor = true;
            this.uaGoodsBtnInsert.MouseLeave += new System.EventHandler(this.uaGoodsBtnInsert_MouseLeave);
            this.uaGoodsBtnInsert.Click += new System.EventHandler(this.uaGoodsBtnInsert_Click);
            this.uaGoodsBtnInsert.MouseEnter += new System.EventHandler(this.uaGoodsBtnInsert_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uaGoodsDGList);
            this.groupBox1.Location = new System.Drawing.Point(21, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // uaGoodsDGList
            // 
            this.uaGoodsDGList.AllowUserToDeleteRows = false;
            this.uaGoodsDGList.AutoGenerateColumns = false;
            this.uaGoodsDGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uaGoodsDGList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.goodsnameDataGridViewTextBoxColumn,
            this.goodspriceDataGridViewTextBoxColumn,
            this.goodsdescDataGridViewTextBoxColumn,
            this.goodkindIDDataGridViewTextBoxColumn});
            this.uaGoodsDGList.DataSource = this.goodsBindingSource;
            this.uaGoodsDGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uaGoodsDGList.Location = new System.Drawing.Point(3, 16);
            this.uaGoodsDGList.Name = "uaGoodsDGList";
            this.uaGoodsDGList.ReadOnly = true;
            this.uaGoodsDGList.Size = new System.Drawing.Size(566, 181);
            this.uaGoodsDGList.TabIndex = 0;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "Goods_ID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "Goods ID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsnameDataGridViewTextBoxColumn
            // 
            this.goodsnameDataGridViewTextBoxColumn.DataPropertyName = "Goods_name";
            this.goodsnameDataGridViewTextBoxColumn.HeaderText = "Goods name";
            this.goodsnameDataGridViewTextBoxColumn.Name = "goodsnameDataGridViewTextBoxColumn";
            this.goodsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodspriceDataGridViewTextBoxColumn
            // 
            this.goodspriceDataGridViewTextBoxColumn.DataPropertyName = "Goods_price";
            this.goodspriceDataGridViewTextBoxColumn.HeaderText = "Goods price";
            this.goodspriceDataGridViewTextBoxColumn.Name = "goodspriceDataGridViewTextBoxColumn";
            this.goodspriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsdescDataGridViewTextBoxColumn
            // 
            this.goodsdescDataGridViewTextBoxColumn.DataPropertyName = "Goods_desc";
            this.goodsdescDataGridViewTextBoxColumn.HeaderText = "Goods desc";
            this.goodsdescDataGridViewTextBoxColumn.Name = "goodsdescDataGridViewTextBoxColumn";
            this.goodsdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodkindIDDataGridViewTextBoxColumn
            // 
            this.goodkindIDDataGridViewTextBoxColumn.DataPropertyName = "Goodkind_ID";
            this.goodkindIDDataGridViewTextBoxColumn.HeaderText = "Goodkind ID";
            this.goodkindIDDataGridViewTextBoxColumn.Name = "goodkindIDDataGridViewTextBoxColumn";
            this.goodkindIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.dataSet1;
            // 
            // uaGoodsTxtDescription
            // 
            this.uaGoodsTxtDescription.Location = new System.Drawing.Point(84, 70);
            this.uaGoodsTxtDescription.Multiline = true;
            this.uaGoodsTxtDescription.Name = "uaGoodsTxtDescription";
            this.uaGoodsTxtDescription.Size = new System.Drawing.Size(509, 78);
            this.uaGoodsTxtDescription.TabIndex = 19;
            // 
            // goodkindTableAdapter
            // 
            this.goodkindTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Description";
            // 
            // uaGoodsTxtPrice
            // 
            this.uaGoodsTxtPrice.Location = new System.Drawing.Point(84, 40);
            this.uaGoodsTxtPrice.Name = "uaGoodsTxtPrice";
            this.uaGoodsTxtPrice.Size = new System.Drawing.Size(100, 20);
            this.uaGoodsTxtPrice.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kind";
            // 
            // uaGoodsTxtItemName
            // 
            this.uaGoodsTxtItemName.Location = new System.Drawing.Point(84, 12);
            this.uaGoodsTxtItemName.Name = "uaGoodsTxtItemName";
            this.uaGoodsTxtItemName.Size = new System.Drawing.Size(217, 20);
            this.uaGoodsTxtItemName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item name";
            // 
            // uaGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uaGoodsCBoxKind);
            this.Controls.Add(this.uaGoodsBtnDelete);
            this.Controls.Add(this.uaGoodsBtnUpdate);
            this.Controls.Add(this.uaGoodsBtnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uaGoodsTxtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uaGoodsTxtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uaGoodsTxtItemName);
            this.Controls.Add(this.label1);
            this.Name = "uaGoods";
            this.Size = new System.Drawing.Size(611, 399);
            this.Load += new System.EventHandler(this.uaGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodkindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uaGoodsDGList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uaGoodsCBoxKind;
        private System.Windows.Forms.BindingSource goodkindBindingSource;
        private DataSet1 dataSet1;
        private qlkaraoke.DataSet1TableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.Button uaGoodsBtnDelete;
        private System.Windows.Forms.Button uaGoodsBtnUpdate;
        private System.Windows.Forms.Button uaGoodsBtnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView uaGoodsDGList;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodkindIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.TextBox uaGoodsTxtDescription;
        private qlkaraoke.DataSet1TableAdapters.GoodkindTableAdapter goodkindTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uaGoodsTxtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uaGoodsTxtItemName;
        private System.Windows.Forms.Label label1;
    }
}
