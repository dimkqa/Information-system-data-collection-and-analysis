namespace InfSysDCAA
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.operationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OperationsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBarDown = new System.Windows.Forms.ToolStripProgressBar();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.groupBoxReportsList = new System.Windows.Forms.GroupBox();
            this.gridViewReportsList = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultrReports = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewReports = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_userInfo = new System.Windows.Forms.GroupBox();
            this.button_blocked = new System.Windows.Forms.Button();
            this.label_status_info = new System.Windows.Forms.Label();
            this.label_secondname_info = new System.Windows.Forms.Label();
            this.label_firstname_info = new System.Windows.Forms.Label();
            this.label_text_status_info = new System.Windows.Forms.Label();
            this.label_text_secondname_info = new System.Windows.Forms.Label();
            this.label_text_firstname_info = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addeddatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.groupBoxReportsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReportsList)).BeginInit();
            this.groupBox_userInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationLabel,
            this.OperationsInfo,
            this.statusProgressBarDown});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1320, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // operationLabel
            // 
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(46, 17);
            this.operationLabel.Text = "Статус:";
            // 
            // OperationsInfo
            // 
            this.OperationsInfo.Name = "OperationsInfo";
            this.OperationsInfo.Size = new System.Drawing.Size(50, 17);
            this.OperationsInfo.Text = "unkown";
            // 
            // statusProgressBarDown
            // 
            this.statusProgressBarDown.Name = "statusProgressBarDown";
            this.statusProgressBarDown.Size = new System.Drawing.Size(100, 16);
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1320, 24);
            this.topMenu.TabIndex = 2;
            this.topMenu.Text = "menuStrip1";
            // 
            // groupBoxReportsList
            // 
            this.groupBoxReportsList.Controls.Add(this.gridViewReportsList);
            this.groupBoxReportsList.Location = new System.Drawing.Point(12, 27);
            this.groupBoxReportsList.Name = "groupBoxReportsList";
            this.groupBoxReportsList.Size = new System.Drawing.Size(903, 677);
            this.groupBoxReportsList.TabIndex = 3;
            this.groupBoxReportsList.TabStop = false;
            this.groupBoxReportsList.Text = "Отчёты";
            // 
            // gridViewReportsList
            // 
            this.gridViewReportsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewReportsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewReportsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReportsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.reportTitle,
            this.createdDate,
            this.createdAuthor,
            this.resultrReports,
            this.viewReports});
            this.gridViewReportsList.Location = new System.Drawing.Point(6, 19);
            this.gridViewReportsList.Name = "gridViewReportsList";
            this.gridViewReportsList.Size = new System.Drawing.Size(891, 652);
            this.gridViewReportsList.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MaxInputLength = 25000;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.ToolTipText = "Номер по порядку";
            this.Number.Width = 50;
            // 
            // reportTitle
            // 
            this.reportTitle.HeaderText = "Название отчёта";
            this.reportTitle.Name = "reportTitle";
            this.reportTitle.ReadOnly = true;
            this.reportTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reportTitle.ToolTipText = "Название отчёта";
            this.reportTitle.Width = 200;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Дата создания";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.createdDate.ToolTipText = "Дата, когда был создан отчёт";
            this.createdDate.Width = 150;
            // 
            // createdAuthor
            // 
            this.createdAuthor.HeaderText = "Пользователь";
            this.createdAuthor.Name = "createdAuthor";
            this.createdAuthor.ReadOnly = true;
            this.createdAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.createdAuthor.ToolTipText = "Данные о том, какой пользователь создал отчёт";
            this.createdAuthor.Width = 150;
            // 
            // resultrReports
            // 
            this.resultrReports.HeaderText = "Результат проверки";
            this.resultrReports.Name = "resultrReports";
            this.resultrReports.ReadOnly = true;
            this.resultrReports.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultrReports.ToolTipText = "Успешно/Провалено";
            this.resultrReports.Width = 150;
            // 
            // viewReports
            // 
            this.viewReports.HeaderText = "Просмотр отчётов";
            this.viewReports.Name = "viewReports";
            this.viewReports.ReadOnly = true;
            this.viewReports.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.viewReports.Text = "Открыть";
            this.viewReports.ToolTipText = "Открыть и просмотреть отчёт";
            this.viewReports.UseColumnTextForButtonValue = true;
            this.viewReports.Width = 150;
            // 
            // groupBox_userInfo
            // 
            this.groupBox_userInfo.Controls.Add(this.button_blocked);
            this.groupBox_userInfo.Controls.Add(this.label_status_info);
            this.groupBox_userInfo.Controls.Add(this.label_secondname_info);
            this.groupBox_userInfo.Controls.Add(this.label_firstname_info);
            this.groupBox_userInfo.Controls.Add(this.label_text_status_info);
            this.groupBox_userInfo.Controls.Add(this.label_text_secondname_info);
            this.groupBox_userInfo.Controls.Add(this.label_text_firstname_info);
            this.groupBox_userInfo.Controls.Add(this.button_logout);
            this.groupBox_userInfo.Location = new System.Drawing.Point(921, 27);
            this.groupBox_userInfo.Name = "groupBox_userInfo";
            this.groupBox_userInfo.Size = new System.Drawing.Size(387, 100);
            this.groupBox_userInfo.TabIndex = 4;
            this.groupBox_userInfo.TabStop = false;
            this.groupBox_userInfo.Text = "Информация о пользователе";
            // 
            // button_blocked
            // 
            this.button_blocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_blocked.Location = new System.Drawing.Point(6, 71);
            this.button_blocked.Name = "button_blocked";
            this.button_blocked.Size = new System.Drawing.Size(176, 23);
            this.button_blocked.TabIndex = 7;
            this.button_blocked.Text = "Заблокировать систему";
            this.button_blocked.UseVisualStyleBackColor = true;
            // 
            // label_status_info
            // 
            this.label_status_info.AutoSize = true;
            this.label_status_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status_info.Location = new System.Drawing.Point(120, 50);
            this.label_status_info.Name = "label_status_info";
            this.label_status_info.Size = new System.Drawing.Size(0, 20);
            this.label_status_info.TabIndex = 6;
            // 
            // label_secondname_info
            // 
            this.label_secondname_info.AutoSize = true;
            this.label_secondname_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_secondname_info.Location = new System.Drawing.Point(266, 19);
            this.label_secondname_info.Name = "label_secondname_info";
            this.label_secondname_info.Size = new System.Drawing.Size(0, 20);
            this.label_secondname_info.TabIndex = 5;
            // 
            // label_firstname_info
            // 
            this.label_firstname_info.AutoSize = true;
            this.label_firstname_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_firstname_info.Location = new System.Drawing.Point(65, 19);
            this.label_firstname_info.Name = "label_firstname_info";
            this.label_firstname_info.Size = new System.Drawing.Size(0, 20);
            this.label_firstname_info.TabIndex = 4;
            // 
            // label_text_status_info
            // 
            this.label_text_status_info.AutoSize = true;
            this.label_text_status_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text_status_info.Location = new System.Drawing.Point(15, 50);
            this.label_text_status_info.Name = "label_text_status_info";
            this.label_text_status_info.Size = new System.Drawing.Size(99, 20);
            this.label_text_status_info.TabIndex = 3;
            this.label_text_status_info.Text = "Должность:";
            // 
            // label_text_secondname_info
            // 
            this.label_text_secondname_info.AutoSize = true;
            this.label_text_secondname_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text_secondname_info.Location = new System.Drawing.Point(183, 19);
            this.label_text_secondname_info.Name = "label_text_secondname_info";
            this.label_text_secondname_info.Size = new System.Drawing.Size(89, 20);
            this.label_text_secondname_info.TabIndex = 2;
            this.label_text_secondname_info.Text = "Фамилия: ";
            // 
            // label_text_firstname_info
            // 
            this.label_text_firstname_info.AutoSize = true;
            this.label_text_firstname_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text_firstname_info.Location = new System.Drawing.Point(15, 19);
            this.label_text_firstname_info.Name = "label_text_firstname_info";
            this.label_text_firstname_info.Size = new System.Drawing.Size(44, 20);
            this.label_text_firstname_info.TabIndex = 1;
            this.label_text_firstname_info.Text = "Имя:";
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(232, 71);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(149, 23);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Выйти из системы";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addeddatafileToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.nas;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // addeddatafileToolStripMenuItem
            // 
            this.addeddatafileToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.add_property;
            this.addeddatafileToolStripMenuItem.Name = "addeddatafileToolStripMenuItem";
            this.addeddatafileToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addeddatafileToolStripMenuItem.Text = "Добавить файл даных";
            this.addeddatafileToolStripMenuItem.Click += new System.EventHandler(this.добавитьОтчётToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // connectSettingsToolStripMenuItem
            // 
            this.connectSettingsToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.engineering;
            this.connectSettingsToolStripMenuItem.Name = "connectSettingsToolStripMenuItem";
            this.connectSettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.connectSettingsToolStripMenuItem.Text = "Настройки соединения";
            this.connectSettingsToolStripMenuItem.Click += new System.EventHandler(this.connectSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.system_information;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.журналСобытийToolStripMenuItem,
            this.журналОшибокToolStripMenuItem});
            this.serviceToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.circuit;
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.database;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.databaseToolStripMenuItem.Text = "База данных";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.line;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.statisticsToolStripMenuItem.Text = "Статистика";
            // 
            // журналСобытийToolStripMenuItem
            // 
            this.журналСобытийToolStripMenuItem.Name = "журналСобытийToolStripMenuItem";
            this.журналСобытийToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.журналСобытийToolStripMenuItem.Text = "Журнал событий";
            // 
            // журналОшибокToolStripMenuItem
            // 
            this.журналОшибокToolStripMenuItem.Name = "журналОшибокToolStripMenuItem";
            this.журналОшибокToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.журналОшибокToolStripMenuItem.Text = "Журнал ошибок";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoComputerToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.high_importance;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // infoComputerToolStripMenuItem
            // 
            this.infoComputerToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.system_information1;
            this.infoComputerToolStripMenuItem.Name = "infoComputerToolStripMenuItem";
            this.infoComputerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoComputerToolStripMenuItem.Text = "О системе...";
            this.infoComputerToolStripMenuItem.Click += new System.EventHandler(this.infoComputerToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 729);
            this.Controls.Add(this.groupBox_userInfo);
            this.Controls.Add(this.groupBoxReportsList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.groupBoxReportsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReportsList)).EndInit();
            this.groupBox_userInfo.ResumeLayout(false);
            this.groupBox_userInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel operationLabel;
        private System.Windows.Forms.ToolStripStatusLabel OperationsInfo;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBarDown;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналСобытийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxReportsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAuthor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resultrReports;
        private System.Windows.Forms.DataGridViewButtonColumn viewReports;
        public System.Windows.Forms.DataGridView gridViewReportsList;
        protected internal System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addeddatafileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_userInfo;
        private System.Windows.Forms.Label label_status_info;
        private System.Windows.Forms.Label label_secondname_info;
        private System.Windows.Forms.Label label_firstname_info;
        private System.Windows.Forms.Label label_text_status_info;
        private System.Windows.Forms.Label label_text_secondname_info;
        private System.Windows.Forms.Label label_text_firstname_info;
        protected internal System.Windows.Forms.Button button_blocked;
        protected internal System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ToolStripMenuItem connectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem infoComputerToolStripMenuItem;


    }
}

