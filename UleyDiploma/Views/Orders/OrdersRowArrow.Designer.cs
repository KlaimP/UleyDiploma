namespace UleyDiploma.Views.Orders
{
    partial class OrdersRowArrow
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
            this.btn_orderLeft = new System.Windows.Forms.Button();
            this.btn_orderRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_orderLeft
            // 
            this.btn_orderLeft.Location = new System.Drawing.Point(3, 3);
            this.btn_orderLeft.Name = "btn_orderLeft";
            this.btn_orderLeft.Size = new System.Drawing.Size(75, 34);
            this.btn_orderLeft.TabIndex = 0;
            this.btn_orderLeft.Text = "<--";
            this.btn_orderLeft.UseVisualStyleBackColor = true;
            this.btn_orderLeft.Click += new System.EventHandler(this.btn_orderLeft_Click);
            // 
            // btn_orderRight
            // 
            this.btn_orderRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orderRight.Location = new System.Drawing.Point(946, 3);
            this.btn_orderRight.Name = "btn_orderRight";
            this.btn_orderRight.Size = new System.Drawing.Size(75, 34);
            this.btn_orderRight.TabIndex = 1;
            this.btn_orderRight.Text = "-->";
            this.btn_orderRight.UseVisualStyleBackColor = true;
            this.btn_orderRight.Click += new System.EventHandler(this.btn_orderRight_Click);
            // 
            // OrdersRowArrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_orderRight);
            this.Controls.Add(this.btn_orderLeft);
            this.Name = "OrdersRowArrow";
            this.Size = new System.Drawing.Size(1024, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_orderLeft;
        private System.Windows.Forms.Button btn_orderRight;
    }
}
