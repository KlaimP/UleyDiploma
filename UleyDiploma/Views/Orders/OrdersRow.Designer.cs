namespace UleyDiploma.Views.Orders
{
    partial class OrdersRow
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
            this.panel = new System.Windows.Forms.Panel();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_productaName = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_upc = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_providers = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.lbl_providers);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.lbl_price);
            this.panel.Controls.Add(this.lbl_upc);
            this.panel.Controls.Add(this.lbl_quantity);
            this.panel.Controls.Add(this.lbl_productaName);
            this.panel.Controls.Add(this.btn_update);
            this.panel.Controls.Add(this.btn_accept);
            this.panel.Location = new System.Drawing.Point(0, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1024, 79);
            this.panel.TabIndex = 0;
            // 
            // btn_accept
            // 
            this.btn_accept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_accept.Location = new System.Drawing.Point(935, 15);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 49);
            this.btn_accept.TabIndex = 0;
            this.btn_accept.Text = "Применить";
            this.btn_accept.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_update.Location = new System.Drawing.Point(841, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 49);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Изменить";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // lbl_productaName
            // 
            this.lbl_productaName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_productaName.AutoSize = true;
            this.lbl_productaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_productaName.Location = new System.Drawing.Point(13, 15);
            this.lbl_productaName.Name = "lbl_productaName";
            this.lbl_productaName.Size = new System.Drawing.Size(61, 24);
            this.lbl_productaName.TabIndex = 2;
            this.lbl_productaName.Text = "Name";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_quantity.Location = new System.Drawing.Point(206, 48);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(91, 16);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Количество: ";
            // 
            // lbl_upc
            // 
            this.lbl_upc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_upc.AutoSize = true;
            this.lbl_upc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_upc.Location = new System.Drawing.Point(14, 48);
            this.lbl_upc.Name = "lbl_upc";
            this.lbl_upc.Size = new System.Drawing.Size(41, 16);
            this.lbl_upc.TabIndex = 4;
            this.lbl_upc.Text = "UPC: ";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_price.Location = new System.Drawing.Point(419, 23);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(46, 16);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Цена: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(419, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена(С учетом НДС): ";
            // 
            // lbl_providers
            // 
            this.lbl_providers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_providers.AutoSize = true;
            this.lbl_providers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_providers.Location = new System.Drawing.Point(206, 23);
            this.lbl_providers.Name = "lbl_providers";
            this.lbl_providers.Size = new System.Drawing.Size(85, 16);
            this.lbl_providers.TabIndex = 7;
            this.lbl_providers.Text = "Поставщик: ";
            // 
            // OrdersRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "OrdersRow";
            this.Size = new System.Drawing.Size(1024, 85);
            this.Load += new System.EventHandler(this.OrdersRow_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_upc;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_productaName;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_providers;
    }
}
