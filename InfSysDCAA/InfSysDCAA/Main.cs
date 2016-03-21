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

namespace InfSysDCAA
{
    public partial class Main : Form
    {
        private Auth _authForm;

        private const int MaxWidth    = 1336;
        private const int MaxHeight   = 768;
        protected bool authUser = false;

        private static readonly string CurrentUserName = Environment.UserName;

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
            PathFinder.AllPath.Add(@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Config");
            PathFinder.AllPath.Add(@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Reports");
            PathFinder.AllPath.Add(@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Raw Files");
            PathFinder.CreateAllPath();
            AuthUser();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void FirstRunFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void connectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof(SetingsApps));
        }

        private void infoComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChecker.ControlOpenedForm(typeof (AboutOfSystem));
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            //Выход из системы, остановка всех выполняемых операций
            //Открытие окна авторизации
            //LogOutUser();
            AuthUser();
        }
        
        //Открывает форму авторизации
        private void AuthUser()
        {
            _authForm = new Auth(this);
            _authForm.FormClosed += FirstRunFormClosed;
            _authForm.Show(this);
        }
    }
}
