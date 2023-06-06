namespace UleyDiploma.Views
{
    partial class OrdersView
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
            this.tablePanel_orders = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tablePanel_orders
            // 
            this.tablePanel_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel_orders.ColumnCount = 1;
            this.tablePanel_orders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_orders.Location = new System.Drawing.Point(0, 0);
            this.tablePanel_orders.Name = "tablePanel_orders";
            this.tablePanel_orders.RowCount = 1;
            this.tablePanel_orders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel_orders.Size = new System.Drawing.Size(1024, 657);
            this.tablePanel_orders.TabIndex = 1;
            this.tablePanel_orders.Resize += new System.EventHandler(this.tableLayoutPanel1_Resize);
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel_orders);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.Load += new System.EventHandler(this.OrdersView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel_orders;
    }
}
