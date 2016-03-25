namespace InfSysDCAA.Forms.Processing_data
{
    partial class ProcessAnalyseData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessAnalyseData));
            this.progressBar_process_analyse = new System.Windows.Forms.ProgressBar();
            this.label_process_analyse_run = new System.Windows.Forms.Label();
            this.field_output_process_analys_data = new System.Windows.Forms.TextBox();
            this.button_cancel_analyse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar_process_analyse
            // 
            this.progressBar_process_analyse.Location = new System.Drawing.Point(12, 37);
            this.progressBar_process_analyse.Name = "progressBar_process_analyse";
            this.progressBar_process_analyse.Size = new System.Drawing.Size(533, 22);
            this.progressBar_process_analyse.TabIndex = 0;
            // 
            // label_process_analyse_run
            // 
            this.label_process_analyse_run.AutoSize = true;
            this.label_process_analyse_run.Location = new System.Drawing.Point(200, 13);
            this.label_process_analyse_run.Name = "label_process_analyse_run";
            this.label_process_analyse_run.Size = new System.Drawing.Size(161, 13);
            this.label_process_analyse_run.TabIndex = 1;
            this.label_process_analyse_run.Text = "Процесс выполнения анализа";
            // 
            // field_output_process_analys_data
            // 
            this.field_output_process_analys_data.Location = new System.Drawing.Point(12, 65);
            this.field_output_process_analys_data.Multiline = true;
            this.field_output_process_analys_data.Name = "field_output_process_analys_data";
            this.field_output_process_analys_data.ReadOnly = true;
            this.field_output_process_analys_data.Size = new System.Drawing.Size(533, 36);
            this.field_output_process_analys_data.TabIndex = 2;
            // 
            // button_cancel_analyse
            // 
            this.button_cancel_analyse.Location = new System.Drawing.Point(470, 8);
            this.button_cancel_analyse.Name = "button_cancel_analyse";
            this.button_cancel_analyse.Size = new System.Drawing.Size(75, 23);
            this.button_cancel_analyse.TabIndex = 3;
            this.button_cancel_analyse.Text = "Отмена";
            this.button_cancel_analyse.UseVisualStyleBackColor = true;
            this.button_cancel_analyse.Click += new System.EventHandler(this.button_cancel_analyse_Click);
            // 
            // ProcessAnalyseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 113);
            this.Controls.Add(this.button_cancel_analyse);
            this.Controls.Add(this.field_output_process_analys_data);
            this.Controls.Add(this.label_process_analyse_run);
            this.Controls.Add(this.progressBar_process_analyse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessAnalyseData";
            this.Text = "ProcessAnalyseData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_process_analyse;
        private System.Windows.Forms.Label label_process_analyse_run;
        protected internal System.Windows.Forms.TextBox field_output_process_analys_data;
        private System.Windows.Forms.Button button_cancel_analyse;
    }
}