using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Collecting_information.System;
using InfSysDCAA.Core.DataBase;
using InfSysDCAA.Core.Directory;
using InfSysDCAA.Core.Processing.Data;
using InfSysDCAA.Core.Processing.Files;
using InfSysDCAA.Core.Validation;
using InfSysDCAA.Forms.Settings;
using InfSysDCAA.Forms.About_system_PC;
using InfSysDCAA.Forms.Auth;
using InfSysDCAA.Forms.Device.Add_or_Edit;

namespace InfSysDCAA
{
    public partial class Main : Form
    {
        private const int MaxWidth    = 1336;
        private const int MaxHeight   = 768;
        protected bool authUser = false;

        private string SNAME;
        private string DBNAME;
        private string UNAME;
        private string PASS;


        public Main()
        {
            InitializeComponent();

            PollCounterLaunchesProgram(Properties.Settings.Default.CountOpeningProgramm);

            Properties.Settings.Default.CountOpeningProgramm = 0;//++;
            Properties.Settings.Default.Save();

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(MaxWidth, MaxHeight);
            MaximumSize = new Size(MaxWidth, MaxHeight);
            Text = Convert.ToString("Информационная система сбора и анализа данных");
            
            DirectoryCreater.PathsAnalyser(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
                Environment.UserName);
            LoadTable();

            CollectSystemInfo.GetSystemInformation();
            TCDB();
           // AuthUser();
        }

        /// <summary>
        /// Опрос счётчика запусков программы. 
        /// Если 0 - запуск в первый раз, вход по дежурному паролю.
        /// Иначе через БД
        /// </summary>
        /// <param name="count">Число запусков программы</param>
        private void PollCounterLaunchesProgram(int count)
        {
            if (count == 0)
            {
                Properties.Application_data.user.Default.field_db_host = "";
                Properties.Application_data.user.Default.field_db_host = "";
                Properties.Application_data.user.Default.field_db_name = "";
                Properties.Application_data.user.Default.field_db_user = "";
                Properties.Application_data.user.Default.field_db_password = "";
            }
            else
            {
                SNAME = Properties.Application_data.user.Default.field_db_host;
                DBNAME = Properties.Application_data.user.Default.field_db_name;
                UNAME = Properties.Application_data.user.Default.field_db_user;
                PASS = Properties.Application_data.user.Default.field_db_password;
            }
        }

        /// <summary>
        /// Тест соединения с БД при запуске.
        /// </summary>
        private void TCDB()
        {
        DataBaseConnect DBC = new DataBaseConnect(SNAME, DBNAME, UNAME, PASS);
            if (!DBC.TestConnection())
            {
                MessageBox.Show("Соединение с базой данных невозможно. Вход только по дежерному паролю",
                    "Сервер баз данных не отвечает", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Пример заполнения таблицы
        /// </summary>
        private void LoadTable()
        {
            gridViewReportsList.Rows.Add(1, "09-04-2016_13-40-26", "09.04.16", "Иванов В.");
            gridViewReportsList.Rows[0].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(2, "09-04-2016_12-55-12", "09.04.16", "Дмитриев С.");
            gridViewReportsList.Rows[1].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(3, "09-04-2016_20-10-12", "09.04.16", "Поляков Н.");
            gridViewReportsList.Rows[2].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(4, "09-04-2016_16-47-00", "09.04.16", "Сырцев Р.");
            gridViewReportsList.Rows[3].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(5, "10-04-2016_08-57-32", "10.04.16", "Иванов В.");
            gridViewReportsList.Rows[4].Cells[4].Value = false;
            gridViewReportsList.Rows.Add(6, "10-04-2016_10-47-26", "10.04.16", "Иванов В.");
            gridViewReportsList.Rows[5].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(7, "10-04-2016_15-32-56", "10.04.16", "Пицель Е.");
            gridViewReportsList.Rows[6].Cells[4].Value = false;
            gridViewReportsList.Rows.Add(8, "10-04-2016_11-41-58", "10.04.16", "Арутенян А.");
            gridViewReportsList.Rows[7].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(9, "11-04-2016_10-47-26", "11.04.16", "Цареградцев А.");
            gridViewReportsList.Rows[8].Cells[4].Value = true;
            gridViewReportsList.Rows.Add(10, "11-04-2016_10-58-26", "11.04.16", "Чучан Х.");
            gridViewReportsList.Rows[9].Cells[4].Value = false;
            gridViewReportsList.Rows[9].Cells[5].Value = "FTP";
            gridViewReportsList.Rows.Add(11, "11-04-2016_14-57-26", "11.04.16", "Данилов Е.");
            gridViewReportsList.Rows[10].Cells[4].Value = true;
        }

        /// <summary>
        /// Открывает форму "О системе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof (AboutOfSystem));
        }

        /// <summary>
        /// Открываем форму добавления устройства.
        /// Состоит из двух форм - добавления данных об устройстве, и его параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof(DeviceStepOne));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void addDeviceFileToolStripMenuItem_Click(object sender, EventArgs e)
         {
             OpenFileDialog dialogAddedFile = new OpenFileDialog();
             dialogAddedFile.Multiselect = false;
             dialogAddedFile.Filter = "Файлы данных устройства |*.dat";
             if (dialogAddedFile.ShowDialog() == DialogResult.OK)
             {
                 StreamReader readFile = new StreamReader(dialogAddedFile.FileName, Encoding.GetEncoding("utf-8"));
                 while (!readFile.EndOfStream)
                 {

                 }
             }
         }

        /// <summary>
        /// Добавляет файл исходных даных для парсинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void addeddatafileToolStripMenuItem_Click(object sender, EventArgs e)
         {
             OpenFileDialog dialogAddedFile = new OpenFileDialog();
             dialogAddedFile.Multiselect = false;
             dialogAddedFile.Filter = "Бинарный файл данных |*.bin";
             if (dialogAddedFile.ShowDialog() == DialogResult.OK)
             {
                ProcessingData ProcData = new ProcessingData(dialogAddedFile.FileName);
             }
         }

        /// <summary>
        /// Обработка кнопки Logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_logout_Click(object sender, EventArgs e)
        {
            //Выход из системы, остановка всех выполняемых операций
            //Открытие окна авторизации
            //LogOutUser();
            AuthUser();
        }
        
        /// <summary>
        /// Открывает форму авторизации
        /// </summary>
        private void AuthUser()
        {
            FormChecker.ControlOpenedForm(typeof(Auth), this, getFormControls());
        }

        /// <summary>
        /// Получает все Control's формы
        /// </summary>
        /// <returns>Возвращает List Control'ов</returns>
        private List<Control> getFormControls()
        {
            List<Control> formControls = new List<Control>();
            foreach (Control c in Controls)
            {
                formControls.Add(c);
            }
            return formControls;
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof(SettingsDB));
        }

        private void connectToFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof(Connection_FTP_Data));
        }

        private void changeDirectoryPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Измените папку сохранения отчётов";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                DirectoryChanger.ChangeReportsPathMessage(FBD.SelectedPath);
                Application.Restart();
            }
        }

        private void openFolderReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryControl.OpenDirectoryOnExplorer(DirectoryCreater.GetReportsFolderPath());
        }
    }
}
