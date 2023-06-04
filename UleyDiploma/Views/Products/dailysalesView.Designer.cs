namespace UleyDiploma.Views.Products
{
    partial class dailysalesView
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
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.dataGrid_dailysales = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_dailySales = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailysales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(3, 606);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(79, 48);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "<---";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(942, 606);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(79, 48);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "--->";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // dataGrid_dailysales
            // 
            this.dataGrid_dailysales.AllowUserToAddRows = false;
            this.dataGrid_dailysales.AllowUserToDeleteRows = false;
            this.dataGrid_dailysales.AllowUserToOrderColumns = true;
            this.dataGrid_dailysales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_dailysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dailysales.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_dailysales.Name = "dataGrid_dailysales";
            this.dataGrid_dailysales.ReadOnly = true;
            this.dataGrid_dailysales.Size = new System.Drawing.Size(1018, 545);
            this.dataGrid_dailysales.TabIndex = 3;
            // 
            // dateTimePicker_dailySales
            // 
            this.dateTimePicker_dailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_dailySales.Location = new System.Drawing.Point(416, 612);
            this.dateTimePicker_dailySales.Name = "dateTimePicker_dailySales";
            this.dateTimePicker_dailySales.Size = new System.Drawing.Size(212, 29);
            this.dateTimePicker_dailySales.TabIndex = 4;
            this.dateTimePicker_dailySales.ValueChanged += new System.EventHandler(this.dateTimePicker_dailySales_ValueChanged);
            // 
            // dailysalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker_dailySales);
            this.Controls.Add(this.dataGrid_dailysales);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Name = "dailysalesView";
            this.Size = new System.Drawing.Size(1024, 657);
            this.Load += new System.EventHandler(this.dailysalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailysales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.DataGridView dataGrid_dailysales;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dailySales;
    }
}
