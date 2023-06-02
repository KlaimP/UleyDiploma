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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_allProducts);
            this.Controls.Add(this.products_panel);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_panel;
        private System.Windows.Forms.Button btn_allProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
