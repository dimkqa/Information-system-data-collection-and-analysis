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
using InfSysDCAA.Core.Directory;
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

        public Main()
        {
            InitializeComponent();
            //Счётчик запуска программы
            Properties.Settings.Default.CountOpeningProgramm++;
            Properties.Settings.Default.Save();

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(MaxWidth, MaxHeight);
            MaximumSize = new Size(MaxWidth, MaxHeight);
            Text = Convert.ToString("Информационная система сбора и анализа данных");

            CollectSystemInfo.GetSystemInformation();

            DirectoryCreater.PathsAnalyser(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
                Environment.UserName);
            
            //Расскоментируй. Форма авторизации
            //AuthUser();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void addeddatafileToolStripMenuItem_Click(object sender, EventArgs e)
         {
             OpenFileDialog dialogAddedFile = new OpenFileDialog();
             dialogAddedFile.Multiselect = false;
             dialogAddedFile.Filter = "Файлы испытаний |*.isvsk";
             if (dialogAddedFile.ShowDialog() == DialogResult.OK)
             {
                 StreamReader readFile = new StreamReader(dialogAddedFile.FileName, Encoding.GetEncoding("utf-8"));
                 while (!readFile.EndOfStream)
                 {

                 }
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
            FormChecker.ControlOpenedForm(typeof(SetingsApps));
        }

        private void connectToFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof(SetingsApps));
        }

        private void changeDirectoryPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Измените папку сохранения отчётов";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Директория для сохранения отётов изменена на " + FBD.SelectedPath +
                    ". \n После нажатия на кнопку \"ОК\" программа перезапустится",
                    "Изменение директории отчётов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DirectoryChanger.ChangePath(Path.GetFullPath(FBD.SelectedPath));
                Application.Restart();
            }
        }
    }
}
