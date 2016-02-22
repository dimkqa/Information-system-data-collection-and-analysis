namespace InfSysDCAA.Forms.FirstRun
{
    partial class FirstRun
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_wellcome = new System.Windows.Forms.Label();
            this.label_info_next = new System.Windows.Forms.Label();
            this.btn_settings_step = new System.Windows.Forms.Button();
            this.panel_first_run = new System.Windows.Forms.Panel();
            this.panel_first_run.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(171, 11);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(35, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "label1";
            // 
            // label_wellcome
            // 
            this.label_wellcome.AutoSize = true;
            this.label_wellcome.Location = new System.Drawing.Point(171, 71);
            this.label_wellcome.Name = "label_wellcome";
            this.label_wellcome.Size = new System.Drawing.Size(35, 13);
            this.label_wellcome.TabIndex = 1;
            this.label_wellcome.Text = "label2";
            // 
            // label_info_next
            // 
            this.label_info_next.AutoSize = true;
            this.label_info_next.Location = new System.Drawing.Point(171, 185);
            this.label_info_next.Name = "label_info_next";
            this.label_info_next.Size = new System.Drawing.Size(35, 13);
            this.label_info_next.TabIndex = 2;
            this.label_info_next.Text = "label3";
            // 
            // btn_settings_step
            // 
            this.btn_settings_step.Location = new System.Drawing.Point(154, 301);
            this.btn_settings_step.Name = "btn_settings_step";
            this.btn_settings_step.Size = new System.Drawing.Size(75, 23);
            this.btn_settings_step.TabIndex = 3;
            this.btn_settings_step.Text = "button1";
            this.btn_settings_step.UseVisualStyleBackColor = true;
            this.btn_settings_step.Click += new System.EventHandler(this.btn_settings_step_Click);
            // 
            // panel_first_run
            // 
            this.panel_first_run.Controls.Add(this.label_title);
            this.panel_first_run.Controls.Add(this.btn_settings_step);
            this.panel_first_run.Controls.Add(this.label_wellcome);
            this.panel_first_run.Controls.Add(this.label_info_next);
            this.panel_first_run.Location = new System.Drawing.Point(12, 12);
            this.panel_first_run.Name = "panel_first_run";
            this.panel_first_run.Size = new System.Drawing.Size(390, 337);
            this.panel_first_run.TabIndex = 4;
            // 
            // FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.panel_first_run);
            this.Name = "FirstRun";
            this.Text = "FirstRun";
            this.panel_first_run.ResumeLayout(false);
            this.panel_first_run.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_wellcome;
        private System.Windows.Forms.Label label_info_next;
        private System.Windows.Forms.Button btn_settings_step;
        private System.Windows.Forms.Panel panel_first_run;
    }
}