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
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУстройствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addeddatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDirectoryPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.systemToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1320, 24);
            this.topMenu.TabIndex = 2;
            this.topMenu.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУстройствоToolStripMenuItem,
            this.addeddatafileToolStripMenuItem,
            this.toolStripSeparator4,
            this.настройкиToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.nas;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.systemToolStripMenuItem.Text = "Система";
            // 
            // добавитьУстройствоToolStripMenuItem
            // 
            this.добавитьУстройствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.addDeviceFileToolStripMenuItem});
            this.добавитьУстройствоToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.add_device;
            this.добавитьУстройствоToolStripMenuItem.Name = "добавитьУстройствоToolStripMenuItem";
            this.добавитьУстройствоToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.добавитьУстройствоToolStripMenuItem.Text = "Добавить устройство";
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.plus__1_;
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addDeviceToolStripMenuItem.Text = "Добавить через форму";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // addDeviceFileToolStripMenuItem
            // 
            this.addDeviceFileToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.plus__1_;
            this.addDeviceFileToolStripMenuItem.Name = "addDeviceFileToolStripMenuItem";
            this.addDeviceFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addDeviceFileToolStripMenuItem.Text = "Загрузить файл";
            this.addDeviceFileToolStripMenuItem.Click += new System.EventHandler(this.addDeviceFileToolStripMenuItem_Click);
            // 
            // addeddatafileToolStripMenuItem
            // 
            this.addeddatafileToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.add_property;
            this.addeddatafileToolStripMenuItem.Name = "addeddatafileToolStripMenuItem";
            this.addeddatafileToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addeddatafileToolStripMenuItem.Text = "Загрузить файл даных";
            this.addeddatafileToolStripMenuItem.Click += new System.EventHandler(this.addeddatafileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBToolStripMenuItem,
            this.connectToFTPToolStripMenuItem,
            this.changeDirectoryPathToolStripMenuItem});
            this.настройкиToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.engineering;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки...";
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.database;
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.connectToDBToolStripMenuItem.Text = "Соединение с БД";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // connectToFTPToolStripMenuItem
            // 
            this.connectToFTPToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.tool_box;
            this.connectToFTPToolStripMenuItem.Name = "connectToFTPToolStripMenuItem";
            this.connectToFTPToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.connectToFTPToolStripMenuItem.Text = "Соединение с FTP";
            this.connectToFTPToolStripMenuItem.Click += new System.EventHandler(this.connectToFTPToolStripMenuItem_Click);
            // 
            // changeDirectoryPathToolStripMenuItem
            // 
            this.changeDirectoryPathToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.Box_52;
            this.changeDirectoryPathToolStripMenuItem.Name = "changeDirectoryPathToolStripMenuItem";
            this.changeDirectoryPathToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changeDirectoryPathToolStripMenuItem.Text = "Изменение директорий";
            this.changeDirectoryPathToolStripMenuItem.Click += new System.EventHandler(this.changeDirectoryPathToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.multiply;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.system_information;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // openFolderReportsToolStripMenuItem
            // 
            this.openFolderReportsToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.tool_box;
            this.openFolderReportsToolStripMenuItem.Name = "openFolderReportsToolStripMenuItem";
            this.openFolderReportsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openFolderReportsToolStripMenuItem.Text = "Открыть папку";
            this.openFolderReportsToolStripMenuItem.Click += new System.EventHandler(this.openFolderReportsToolStripMenuItem_Click);
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
            this.infoComputerToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.high_importance;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // infoComputerToolStripMenuItem
            // 
            this.infoComputerToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.system_information1;
            this.infoComputerToolStripMenuItem.Name = "infoComputerToolStripMenuItem";
            this.infoComputerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.infoComputerToolStripMenuItem.Text = "О системе...";
            this.infoComputerToolStripMenuItem.Click += new System.EventHandler(this.infoComputerToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = global::InfSysDCAA.Properties.Resources.Info_521;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
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
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
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
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналСобытийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналОшибокToolStripMenuItem;
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
        private System.Windows.Forms.GroupBox groupBox_userInfo;
        private System.Windows.Forms.Label label_status_info;
        private System.Windows.Forms.Label label_secondname_info;
        private System.Windows.Forms.Label label_firstname_info;
        private System.Windows.Forms.Label label_text_status_info;
        private System.Windows.Forms.Label label_text_secondname_info;
        private System.Windows.Forms.Label label_text_firstname_info;
        protected internal System.Windows.Forms.Button button_blocked;
        protected internal System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ToolStripMenuItem infoComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem addeddatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУстройствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToFTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDirectoryPathToolStripMenuItem;


    }
}

