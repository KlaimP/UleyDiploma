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
            this.products_panel = new System.Windows.Forms.Panel();
            this.btn_allProducts = new System.Windows.Forms.Button();
            this.btn_addProducts = new System.Windows.Forms.Button();
            this.btn_dailysales = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // products_panel
            // 
            this.products_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.products_panel.Location = new System.Drawing.Point(3, 32);
            this.products_panel.Name = "products_panel";
            this.products_panel.Size = new System.Drawing.Size(1018, 622);
            this.products_panel.TabIndex = 0;
            // 
            // btn_allProducts
            // 
            this.btn_allProducts.Location = new System.Drawing.Point(9, 5);
            this.btn_allProducts.Name = "btn_allProducts";
            this.btn_allProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_allProducts.TabIndex = 1;
            this.btn_allProducts.Text = "Все";
            this.btn_allProducts.UseVisualStyleBackColor = true;
            this.btn_allProducts.Click += new System.EventHandler(this.btn_allProducts_Click);
            // 
            // btn_addProducts
            // 
            this.btn_addProducts.Location = new System.Drawing.Point(90, 5);
            this.btn_addProducts.Name = "btn_addProducts";
            this.btn_addProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_addProducts.TabIndex = 2;
            this.btn_addProducts.Text = "Добавить";
            this.btn_addProducts.UseVisualStyleBackColor = true;
            this.btn_addProducts.Click += new System.EventHandler(this.btn_addProducts_Click);
            // 
            // btn_dailysales
            // 
            this.btn_dailysales.Location = new System.Drawing.Point(171, 5);
            this.btn_dailysales.Name = "btn_dailysales";
            this.btn_dailysales.Size = new System.Drawing.Size(75, 23);
            this.btn_dailysales.TabIndex = 3;
            this.btn_dailysales.Text = "Продажи";
            this.btn_dailysales.UseVisualStyleBackColor = true;
            this.btn_dailysales.Click += new System.EventHandler(this.btn_dailysales_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_allProducts);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_dailysales);
            this.Controls.Add(this.btn_addProducts);
            this.Controls.Add(this.products_panel);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.Load += new System.EventHandler(this.ProductsView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_panel;
        private System.Windows.Forms.Button btn_allProducts;
        private System.Windows.Forms.Button btn_addProducts;
        private System.Windows.Forms.Button btn_dailysales;
        private System.Windows.Forms.Button button4;
    }
}
