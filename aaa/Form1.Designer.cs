namespace thaujinshinchan
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Product = new System.Windows.Forms.Label();
            this.dtProdukSimpan = new System.Windows.Forms.DataGridView();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtCategory = new System.Windows.Forms.DataGridView();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Nama = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.txtbox_category = new System.Windows.Forms.TextBox();
            this.txtbox_nama = new System.Windows.Forms.TextBox();
            this.txtbox_harga = new System.Windows.Forms.TextBox();
            this.txtbox_stock = new System.Windows.Forms.TextBox();
            this.cbox_category = new System.Windows.Forms.ComboBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cbox_filter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdukSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(35, 14);
            this.lbl_Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(154, 41);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "Product";
            // 
            // dtProdukSimpan
            // 
            this.dtProdukSimpan.AllowUserToAddRows = false;
            this.dtProdukSimpan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProdukSimpan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProdukSimpan.BackgroundColor = System.Drawing.Color.White;
            this.dtProdukSimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProdukSimpan.GridColor = System.Drawing.Color.LightGray;
            this.dtProdukSimpan.Location = new System.Drawing.Point(19, 74);
            this.dtProdukSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.dtProdukSimpan.Name = "dtProdukSimpan";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtProdukSimpan.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtProdukSimpan.RowHeadersVisible = false;
            this.dtProdukSimpan.RowHeadersWidth = 82;
            this.dtProdukSimpan.RowTemplate.Height = 33;
            this.dtProdukSimpan.Size = new System.Drawing.Size(653, 346);
            this.dtProdukSimpan.TabIndex = 1;
            this.dtProdukSimpan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProdukSimpan_CellClick_1);
            this.dtProdukSimpan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProdukSimpan_CellContentClick);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(819, 14);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(141, 35);
            this.lbl_Category.TabIndex = 2;
            this.lbl_Category.Text = "Category";
            // 
            // dtCategory
            // 
            this.dtCategory.AllowUserToAddRows = false;
            this.dtCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCategory.BackgroundColor = System.Drawing.Color.White;
            this.dtCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategory.GridColor = System.Drawing.Color.RosyBrown;
            this.dtCategory.Location = new System.Drawing.Point(689, 74);
            this.dtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dtCategory.Name = "dtCategory";
            this.dtCategory.RowHeadersVisible = false;
            this.dtCategory.RowHeadersWidth = 82;
            this.dtCategory.RowTemplate.Height = 33;
            this.dtCategory.Size = new System.Drawing.Size(271, 262);
            this.dtCategory.TabIndex = 3;
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Location = new System.Drawing.Point(11, 438);
            this.lbl_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(122, 35);
            this.lbl_Details.TabIndex = 4;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_Nama
            // 
            this.lbl_Nama.AutoSize = true;
            this.lbl_Nama.Location = new System.Drawing.Point(686, 351);
            this.lbl_Nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nama.Name = "lbl_Nama";
            this.lbl_Nama.Size = new System.Drawing.Size(53, 16);
            this.lbl_Nama.TabIndex = 5;
            this.lbl_Nama.Text = "Nama : ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(36, 475);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 16);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Nama : ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 509);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category :";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Location = new System.Drawing.Point(35, 539);
            this.lbl_harga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(54, 16);
            this.lbl_harga.TabIndex = 8;
            this.lbl_harga.Text = "Harga : ";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(39, 569);
            this.lbl_Stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(47, 16);
            this.lbl_Stock.TabIndex = 9;
            this.lbl_Stock.Text = "Stock :";
            // 
            // txtbox_category
            // 
            this.txtbox_category.BackColor = System.Drawing.Color.Snow;
            this.txtbox_category.Location = new System.Drawing.Point(758, 351);
            this.txtbox_category.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_category.Name = "txtbox_category";
            this.txtbox_category.Size = new System.Drawing.Size(179, 22);
            this.txtbox_category.TabIndex = 10;
            // 
            // txtbox_nama
            // 
            this.txtbox_nama.BackColor = System.Drawing.Color.Snow;
            this.txtbox_nama.Location = new System.Drawing.Point(97, 475);
            this.txtbox_nama.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_nama.Name = "txtbox_nama";
            this.txtbox_nama.Size = new System.Drawing.Size(301, 22);
            this.txtbox_nama.TabIndex = 11;
            // 
            // txtbox_harga
            // 
            this.txtbox_harga.BackColor = System.Drawing.Color.Snow;
            this.txtbox_harga.Location = new System.Drawing.Point(97, 535);
            this.txtbox_harga.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_harga.Name = "txtbox_harga";
            this.txtbox_harga.Size = new System.Drawing.Size(138, 22);
            this.txtbox_harga.TabIndex = 12;
            this.txtbox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_harga_KeyPress);
            // 
            // txtbox_stock
            // 
            this.txtbox_stock.BackColor = System.Drawing.Color.Snow;
            this.txtbox_stock.Location = new System.Drawing.Point(97, 569);
            this.txtbox_stock.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_stock.Name = "txtbox_stock";
            this.txtbox_stock.Size = new System.Drawing.Size(138, 22);
            this.txtbox_stock.TabIndex = 13;
            this.txtbox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_KeyPress);
            // 
            // cbox_category
            // 
            this.cbox_category.BackColor = System.Drawing.Color.Snow;
            this.cbox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_category.FormattingEnabled = true;
            this.cbox_category.Location = new System.Drawing.Point(97, 503);
            this.cbox_category.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_category.Name = "cbox_category";
            this.cbox_category.Size = new System.Drawing.Size(138, 24);
            this.cbox_category.TabIndex = 14;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addproduct.Location = new System.Drawing.Point(295, 520);
            this.btn_addproduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(80, 58);
            this.btn_addproduct.TabIndex = 15;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_editproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_editproduct.Location = new System.Drawing.Point(385, 520);
            this.btn_editproduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(80, 58);
            this.btn_editproduct.TabIndex = 16;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = false;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_removeproduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_removeproduct.Location = new System.Drawing.Point(479, 520);
            this.btn_removeproduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(80, 58);
            this.btn_removeproduct.TabIndex = 17;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = false;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addcategory.Location = new System.Drawing.Point(758, 377);
            this.btn_addcategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(80, 58);
            this.btn_addcategory.TabIndex = 18;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = false;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.BackColor = System.Drawing.Color.LightCoral;
            this.btn_removecategory.Location = new System.Drawing.Point(857, 377);
            this.btn_removecategory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(80, 58);
            this.btn_removecategory.TabIndex = 19;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = false;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // btn_all
            // 
            this.btn_all.AutoSize = true;
            this.btn_all.BackColor = System.Drawing.Color.Silver;
            this.btn_all.Location = new System.Drawing.Point(343, 31);
            this.btn_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(80, 26);
            this.btn_all.TabIndex = 20;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.AutoSize = true;
            this.btn_filter.BackColor = System.Drawing.Color.Silver;
            this.btn_filter.Location = new System.Drawing.Point(427, 31);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(80, 26);
            this.btn_filter.TabIndex = 21;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cbox_filter
            // 
            this.cbox_filter.BackColor = System.Drawing.Color.LightGray;
            this.cbox_filter.Enabled = false;
            this.cbox_filter.FormattingEnabled = true;
            this.cbox_filter.Location = new System.Drawing.Point(518, 31);
            this.cbox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_filter.Name = "cbox_filter";
            this.cbox_filter.Size = new System.Drawing.Size(129, 24);
            this.cbox_filter.TabIndex = 22;
            this.cbox_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(825, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(564, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1042, 651);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbox_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.cbox_category);
            this.Controls.Add(this.txtbox_stock);
            this.Controls.Add(this.txtbox_harga);
            this.Controls.Add(this.txtbox_nama);
            this.Controls.Add(this.txtbox_category);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Nama);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.dtCategory);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.dtProdukSimpan);
            this.Controls.Add(this.lbl_Product);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProdukSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.DataGridView dtProdukSimpan;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DataGridView dtCategory;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Nama;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox txtbox_category;
        private System.Windows.Forms.TextBox txtbox_nama;
        private System.Windows.Forms.TextBox txtbox_harga;
        private System.Windows.Forms.TextBox txtbox_stock;
        private System.Windows.Forms.ComboBox cbox_category;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cbox_filter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
