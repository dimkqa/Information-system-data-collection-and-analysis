namespace InfSysDCAA.Forms.Auth
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.button_login = new System.Windows.Forms.Button();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_field = new System.Windows.Forms.TextBox();
            this.label_login_field = new System.Windows.Forms.Label();
            this.label_password_field = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.ckba_logo_text_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_login.Location = new System.Drawing.Point(16, 114);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(81, 39);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Вход";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_field.Location = new System.Drawing.Point(120, 77);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(149, 31);
            this.password_field.TabIndex = 2;
            // 
            // login_field
            // 
            this.login_field.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_field.Location = new System.Drawing.Point(120, 40);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(149, 31);
            this.login_field.TabIndex = 1;
            // 
            // label_login_field
            // 
            this.label_login_field.AutoSize = true;
            this.label_login_field.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login_field.Location = new System.Drawing.Point(12, 38);
            this.label_login_field.Name = "label_login_field";
            this.label_login_field.Size = new System.Drawing.Size(70, 22);
            this.label_login_field.TabIndex = 6;
            this.label_login_field.Text = "Логин:";
            // 
            // label_password_field
            // 
            this.label_password_field.AutoSize = true;
            this.label_password_field.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_field.Location = new System.Drawing.Point(12, 76);
            this.label_password_field.Name = "label_password_field";
            this.label_password_field.Size = new System.Drawing.Size(85, 22);
            this.label_password_field.TabIndex = 7;
            this.label_password_field.Text = "Пароль:";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button_exit.Location = new System.Drawing.Point(188, 114);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(81, 39);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выйти";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // ckba_logo_text_1
            // 
            this.ckba_logo_text_1.AutoSize = true;
            this.ckba_logo_text_1.BackColor = System.Drawing.Color.Transparent;
            this.ckba_logo_text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckba_logo_text_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckba_logo_text_1.Location = new System.Drawing.Point(36, -3);
            this.ckba_logo_text_1.Name = "ckba_logo_text_1";
            this.ckba_logo_text_1.Size = new System.Drawing.Size(246, 20);
            this.ckba_logo_text_1.TabIndex = 9;
            this.ckba_logo_text_1.Text = "Центральное Конструкторское";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Бюро Автоматики";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InfSysDCAA.Properties.Resources.login2;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckba_logo_text_1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.login_field);
            this.Controls.Add(this.label_login_field);
            this.Controls.Add(this.label_password_field);
            this.Controls.Add(this.button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.Text = "Auth system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Label label_login_field;
        private System.Windows.Forms.Label label_password_field;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label ckba_logo_text_1;
        private System.Windows.Forms.Label label1;



    }
}