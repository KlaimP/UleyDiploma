namespace UleyDiploma.Views.Products
{
    partial class selectProductsView
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
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_findProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
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
            this.dataProducts.Location = new System.Drawing.Point(3, 33);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.Size = new System.Drawing.Size(968, 624);
            this.dataProducts.TabIndex = 0;
            this.dataProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducts_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Введите текст";
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_findProducts
            // 
            this.btn_findProducts.Location = new System.Drawing.Point(212, 4);
            this.btn_findProducts.Name = "btn_findProducts";
            this.btn_findProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_findProducts.TabIndex = 2;
            this.btn_findProducts.Text = "Поиск";
            this.btn_findProducts.UseVisualStyleBackColor = true;
            // 
            // selectProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_findProducts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataProducts);
            this.Name = "selectProductsView";
            this.Size = new System.Drawing.Size(974, 660);
            this.Load += new System.EventHandler(this.selectProductsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_findProducts;
    }
}
