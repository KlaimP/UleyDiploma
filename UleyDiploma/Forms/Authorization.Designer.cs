namespace UleyDiploma.Forms
{
    partial class Authorization
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
            this.i_login = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.i_password = new System.Windows.Forms.TextBox();
            this.btn_autorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // i_login
            // 
            this.i_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_login.Location = new System.Drawing.Point(137, 47);
            this.i_login.Name = "i_login";
            this.i_login.Size = new System.Drawing.Size(210, 26);
            this.i_login.TabIndex = 0;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(64, 53);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(55, 20);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пароль";
            // 
            // i_password
            // 
            this.i_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_password.Location = new System.Drawing.Point(137, 103);
            this.i_password.Name = "i_password";
            this.i_password.Size = new System.Drawing.Size(210, 26);
            this.i_password.TabIndex = 2;
            // 
            // btn_autorization
            // 
            this.btn_autorization.Location = new System.Drawing.Point(124, 158);
            this.btn_autorization.Name = "btn_autorization";
            this.btn_autorization.Size = new System.Drawing.Size(182, 41);
            this.btn_autorization.TabIndex = 4;
            this.btn_autorization.Text = "Авторизироваться";
            this.btn_autorization.UseVisualStyleBackColor = true;
            this.btn_autorization.Click += new System.EventHandler(this.btn_autorization_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 211);
            this.Controls.Add(this.btn_autorization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.i_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.i_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox i_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox i_password;
        private System.Windows.Forms.Button btn_autorization;
    }
}