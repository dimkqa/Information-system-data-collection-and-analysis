namespace InfSysDCAA.Forms.Settings
{
    partial class Connection_FTP_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection_FTP_Data));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.field_ftp_host = new System.Windows.Forms.TextBox();
            this.field_ftp_login = new System.Windows.Forms.TextBox();
            this.field_ftp_password = new System.Windows.Forms.TextBox();
            this.button_test_ftp_settings = new System.Windows.Forms.Button();
            this.button_save_ftp_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP-адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // field_ftp_host
            // 
            this.field_ftp_host.Location = new System.Drawing.Point(78, 17);
            this.field_ftp_host.Name = "field_ftp_host";
            this.field_ftp_host.Size = new System.Drawing.Size(194, 20);
            this.field_ftp_host.TabIndex = 3;
            // 
            // field_ftp_login
            // 
            this.field_ftp_login.Location = new System.Drawing.Point(78, 43);
            this.field_ftp_login.Name = "field_ftp_login";
            this.field_ftp_login.Size = new System.Drawing.Size(194, 20);
            this.field_ftp_login.TabIndex = 4;
            // 
            // field_ftp_password
            // 
            this.field_ftp_password.Location = new System.Drawing.Point(78, 69);
            this.field_ftp_password.Name = "field_ftp_password";
            this.field_ftp_password.Size = new System.Drawing.Size(194, 20);
            this.field_ftp_password.TabIndex = 5;
            // 
            // button_test_ftp_settings
            // 
            this.button_test_ftp_settings.Location = new System.Drawing.Point(12, 95);
            this.button_test_ftp_settings.Name = "button_test_ftp_settings";
            this.button_test_ftp_settings.Size = new System.Drawing.Size(139, 23);
            this.button_test_ftp_settings.TabIndex = 6;
            this.button_test_ftp_settings.Text = "Проверить соединение";
            this.button_test_ftp_settings.UseVisualStyleBackColor = true;
            this.button_test_ftp_settings.Click += new System.EventHandler(this.button_test_ftp_settings_Click);
            // 
            // button_save_ftp_settings
            // 
            this.button_save_ftp_settings.Location = new System.Drawing.Point(160, 95);
            this.button_save_ftp_settings.Name = "button_save_ftp_settings";
            this.button_save_ftp_settings.Size = new System.Drawing.Size(112, 23);
            this.button_save_ftp_settings.TabIndex = 7;
            this.button_save_ftp_settings.Text = "Сохранить данные";
            this.button_save_ftp_settings.UseVisualStyleBackColor = true;
            this.button_save_ftp_settings.Click += new System.EventHandler(this.button_save_ftp_settings_Click);
            // 
            // Connection_FTP_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.button_save_ftp_settings);
            this.Controls.Add(this.button_test_ftp_settings);
            this.Controls.Add(this.field_ftp_password);
            this.Controls.Add(this.field_ftp_login);
            this.Controls.Add(this.field_ftp_host);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection_FTP_Data";
            this.Text = "Connection_FTP_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox field_ftp_host;
        private System.Windows.Forms.TextBox field_ftp_login;
        private System.Windows.Forms.TextBox field_ftp_password;
        private System.Windows.Forms.Button button_test_ftp_settings;
        private System.Windows.Forms.Button button_save_ftp_settings;
    }
}