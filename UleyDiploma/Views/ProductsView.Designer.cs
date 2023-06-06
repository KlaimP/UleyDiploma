namespace UleyDiploma.Views
{
    partial class ProductsView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_products = new System.Windows.Forms.TabControl();
            this.tp_all = new System.Windows.Forms.TabPage();
            this.btn_findProducts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.tp_addProduct = new System.Windows.Forms.TabPage();
            this.numeric_upc = new System.Windows.Forms.NumericUpDown();
            this.numeric_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.comboBox_catalog = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nameProducts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_dailySales = new System.Windows.Forms.TabPage();
            this.dateTimePicker_dailySales = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_dailysales = new System.Windows.Forms.DataGridView();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.tabControl_products.SuspendLayout();
            this.tp_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.tp_addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_upc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            this.tp_dailySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailysales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_products
            // 
            this.tabControl_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_products.Controls.Add(this.tp_all);
            this.tabControl_products.Controls.Add(this.tp_addProduct);
            this.tabControl_products.Controls.Add(this.tp_dailySales);
            this.tabControl_products.Location = new System.Drawing.Point(3, 3);
            this.tabControl_products.Name = "tabControl_products";
            this.tabControl_products.SelectedIndex = 0;
            this.tabControl_products.Size = new System.Drawing.Size(1021, 651);
            this.tabControl_products.TabIndex = 0;
            this.tabControl_products.SelectedIndexChanged += new System.EventHandler(this.tabControl_products_SelectedIndexChanged);
            // 
            // tp_all
            // 
            this.tp_all.Controls.Add(this.btn_findProducts);
            this.tp_all.Controls.Add(this.textBox1);
            this.tp_all.Controls.Add(this.dataProducts);
            this.tp_all.Location = new System.Drawing.Point(4, 22);
            this.tp_all.Name = "tp_all";
            this.tp_all.Padding = new System.Windows.Forms.Padding(3);
            this.tp_all.Size = new System.Drawing.Size(1013, 625);
            this.tp_all.TabIndex = 0;
            this.tp_all.Text = "Все";
            this.tp_all.UseVisualStyleBackColor = true;
            // 
            // btn_findProducts
            // 
            this.btn_findProducts.Location = new System.Drawing.Point(215, 2);
            this.btn_findProducts.Name = "btn_findProducts";
            this.btn_findProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_findProducts.TabIndex = 5;
            this.btn_findProducts.Text = "Поиск";
            this.btn_findProducts.UseVisualStyleBackColor = true;
            this.btn_findProducts.Click += new System.EventHandler(this.btn_findProducts_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Введите текст";
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(6, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToOrderColumns = true;
            this.dataProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Location = new System.Drawing.Point(6, 31);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.Size = new System.Drawing.Size(1001, 588);
            this.dataProducts.TabIndex = 3;
            // 
            // tp_addProduct
            // 
            this.tp_addProduct.Controls.Add(this.numeric_upc);
            this.tp_addProduct.Controls.Add(this.numeric_discount);
            this.tp_addProduct.Controls.Add(this.btn_add_product);
            this.tp_addProduct.Controls.Add(this.pictureBox1);
            this.tp_addProduct.Controls.Add(this.button1);
            this.tp_addProduct.Controls.Add(this.label8);
            this.tp_addProduct.Controls.Add(this.textBox_description);
            this.tp_addProduct.Controls.Add(this.comboBox_catalog);
            this.tp_addProduct.Controls.Add(this.label7);
            this.tp_addProduct.Controls.Add(this.label6);
            this.tp_addProduct.Controls.Add(this.numeric_price);
            this.tp_addProduct.Controls.Add(this.label5);
            this.tp_addProduct.Controls.Add(this.label3);
            this.tp_addProduct.Controls.Add(this.textBox_nameProducts);
            this.tp_addProduct.Controls.Add(this.label2);
            this.tp_addProduct.Controls.Add(this.label1);
            this.tp_addProduct.Location = new System.Drawing.Point(4, 22);
            this.tp_addProduct.Name = "tp_addProduct";
            this.tp_addProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tp_addProduct.Size = new System.Drawing.Size(1013, 625);
            this.tp_addProduct.TabIndex = 1;
            this.tp_addProduct.Text = "Добавить";
            this.tp_addProduct.UseVisualStyleBackColor = true;
            // 
            // numeric_upc
            // 
            this.numeric_upc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_upc.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeric_upc.Location = new System.Drawing.Point(23, 61);
            this.numeric_upc.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numeric_upc.Name = "numeric_upc";
            this.numeric_upc.Size = new System.Drawing.Size(183, 26);
            this.numeric_upc.TabIndex = 39;
            // 
            // numeric_discount
            // 
            this.numeric_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_discount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_discount.Location = new System.Drawing.Point(23, 235);
            this.numeric_discount.Name = "numeric_discount";
            this.numeric_discount.Size = new System.Drawing.Size(183, 26);
            this.numeric_discount.TabIndex = 38;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_product.Location = new System.Drawing.Point(877, 583);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(117, 36);
            this.btn_add_product.TabIndex = 37;
            this.btn_add_product.Text = "Добавить";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(261, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Описание";
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(23, 360);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(438, 259);
            this.textBox_description.TabIndex = 33;
            // 
            // comboBox_catalog
            // 
            this.comboBox_catalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_catalog.FormattingEnabled = true;
            this.comboBox_catalog.Location = new System.Drawing.Point(24, 294);
            this.comboBox_catalog.Name = "comboBox_catalog";
            this.comboBox_catalog.Size = new System.Drawing.Size(182, 28);
            this.comboBox_catalog.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "*Каталог";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Скидка";
            // 
            // numeric_price
            // 
            this.numeric_price.DecimalPlaces = 2;
            this.numeric_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_price.Location = new System.Drawing.Point(23, 178);
            this.numeric_price.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_price.Name = "numeric_price";
            this.numeric_price.Size = new System.Drawing.Size(183, 26);
            this.numeric_price.TabIndex = 29;
            this.numeric_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "*Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "*Название продукта";
            // 
            // textBox_nameProducts
            // 
            this.textBox_nameProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nameProducts.Location = new System.Drawing.Point(23, 119);
            this.textBox_nameProducts.Name = "textBox_nameProducts";
            this.textBox_nameProducts.Size = new System.Drawing.Size(182, 26);
            this.textBox_nameProducts.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "*UPC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Добавить продукт в систему";
            // 
            // tp_dailySales
            // 
            this.tp_dailySales.Controls.Add(this.dateTimePicker_dailySales);
            this.tp_dailySales.Controls.Add(this.dataGrid_dailysales);
            this.tp_dailySales.Controls.Add(this.btn_right);
            this.tp_dailySales.Controls.Add(this.btn_left);
            this.tp_dailySales.Location = new System.Drawing.Point(4, 22);
            this.tp_dailySales.Name = "tp_dailySales";
            this.tp_dailySales.Size = new System.Drawing.Size(1013, 625);
            this.tp_dailySales.TabIndex = 2;
            this.tp_dailySales.Text = "Продажи";
            this.tp_dailySales.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dailySales
            // 
            this.dateTimePicker_dailySales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_dailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_dailySales.Location = new System.Drawing.Point(416, 552);
            this.dateTimePicker_dailySales.Name = "dateTimePicker_dailySales";
            this.dateTimePicker_dailySales.Size = new System.Drawing.Size(212, 29);
            this.dateTimePicker_dailySales.TabIndex = 8;
            this.dateTimePicker_dailySales.ValueChanged += new System.EventHandler(this.dateTimePicker_dailySales_ValueChanged);
            // 
            // dataGrid_dailysales
            // 
            this.dataGrid_dailysales.AllowUserToAddRows = false;
            this.dataGrid_dailysales.AllowUserToDeleteRows = false;
            this.dataGrid_dailysales.AllowUserToOrderColumns = true;
            this.dataGrid_dailysales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_dailysales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_dailysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dailysales.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_dailysales.Name = "dataGrid_dailysales";
            this.dataGrid_dailysales.ReadOnly = true;
            this.dataGrid_dailysales.Size = new System.Drawing.Size(1018, 511);
            this.dataGrid_dailysales.TabIndex = 7;
            // 
            // btn_right
            // 
            this.btn_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_right.Location = new System.Drawing.Point(931, 542);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(79, 48);
            this.btn_right.TabIndex = 6;
            this.btn_right.Text = "--->";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_left.Location = new System.Drawing.Point(3, 542);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(79, 48);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "<---";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_products);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.Load += new System.EventHandler(this.ProductsView_Load);
            this.tabControl_products.ResumeLayout(false);
            this.tp_all.ResumeLayout(false);
            this.tp_all.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.tp_addProduct.ResumeLayout(false);
            this.tp_addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_upc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            this.tp_dailySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailysales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_products;
        private System.Windows.Forms.TabPage tp_all;
        private System.Windows.Forms.TabPage tp_addProduct;
        private System.Windows.Forms.TabPage tp_dailySales;
        private System.Windows.Forms.Button btn_findProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.NumericUpDown numeric_upc;
        private System.Windows.Forms.NumericUpDown numeric_discount;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.ComboBox comboBox_catalog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nameProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dailySales;
        private System.Windows.Forms.DataGridView dataGrid_dailysales;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
    }
}
