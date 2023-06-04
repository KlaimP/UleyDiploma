namespace UleyDiploma.Views.Products
{
    partial class addProductsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nameProducts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_catalog = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.numeric_discount = new System.Windows.Forms.NumericUpDown();
            this.numeric_upc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_upc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить продукт в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*UPC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Название продукта";
            // 
            // textBox_nameProducts
            // 
            this.textBox_nameProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nameProducts.Location = new System.Drawing.Point(37, 142);
            this.textBox_nameProducts.Name = "textBox_nameProducts";
            this.textBox_nameProducts.Size = new System.Drawing.Size(182, 26);
            this.textBox_nameProducts.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Цена";
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
            this.numeric_price.Location = new System.Drawing.Point(37, 201);
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
            this.numeric_price.TabIndex = 10;
            this.numeric_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Скидка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(34, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Каталог";
            // 
            // comboBox_catalog
            // 
            this.comboBox_catalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_catalog.FormattingEnabled = true;
            this.comboBox_catalog.Location = new System.Drawing.Point(38, 317);
            this.comboBox_catalog.Name = "comboBox_catalog";
            this.comboBox_catalog.Size = new System.Drawing.Size(182, 28);
            this.comboBox_catalog.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Описание";
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(37, 382);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(438, 230);
            this.textBox_description.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(275, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_product.Location = new System.Drawing.Point(890, 608);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(117, 36);
            this.btn_add_product.TabIndex = 21;
            this.btn_add_product.Text = "Добавить";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // numeric_discount
            // 
            this.numeric_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_discount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_discount.Location = new System.Drawing.Point(37, 258);
            this.numeric_discount.Name = "numeric_discount";
            this.numeric_discount.Size = new System.Drawing.Size(183, 26);
            this.numeric_discount.TabIndex = 22;
            // 
            // numeric_upc
            // 
            this.numeric_upc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_upc.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeric_upc.Location = new System.Drawing.Point(37, 84);
            this.numeric_upc.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numeric_upc.Name = "numeric_upc";
            this.numeric_upc.Size = new System.Drawing.Size(183, 26);
            this.numeric_upc.TabIndex = 23;
            // 
            // addProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numeric_upc);
            this.Controls.Add(this.numeric_discount);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.comboBox_catalog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nameProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addProductsView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.Load += new System.EventHandler(this.addProductsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_upc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nameProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_catalog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.NumericUpDown numeric_discount;
        private System.Windows.Forms.NumericUpDown numeric_upc;
    }
}
