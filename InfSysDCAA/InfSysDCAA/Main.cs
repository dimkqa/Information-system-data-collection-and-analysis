using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Forms.FirstRun;
using InfSysDCAA.Forms.Settings;
using InfSysDCAA.Files.Params;
using InfSysDCAA.Classes.Collecting_information.System_information;
using InfSysDCAA.Forms.About_system_PC;

namespace InfSysDCAA
{
            
    public partial class Main : Form
    {
        private Auth _authForm;
        private SetingsApps _settingsForm;
        private AboutOfSystem sysInfoForms;

        private const int MaxWidth    = 1336;
        private const int MaxHeight   = 768;
        protected bool authUser = false;
        
        private static readonly string currentUserName = Environment.UserName;

        public Main()
        {

            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(MaxWidth, MaxHeight);
            MaximumSize = new Size(MaxWidth, MaxHeight);
            Text = Convert.ToString("Информационная система сбора и анализа данных");
            collect_system_info.getSystemInformation();
            PathFinder.AllPath.Add(@"C:\Users\" + currentUserName + @"\Documents\InfSysDCAA\Config");
            PathFinder.AllPath.Add(@"C:\Users\" + currentUserName + @"\Documents\InfSysDCAA\Reports");
            PathFinder.AllPath.Add(@"C:\Users\" + currentUserName + @"\Documents\InfSysDCAA\Raw Files");
            PathFinder.CreateAllPath();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _authForm = new Auth(this);
            _authForm.FormClosed += FirstRunFormClosed;
            _authForm.Show(this);
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
            _settingsForm = new SetingsApps();
            _settingsForm.Show();
        }

        private void infoComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sysInfoForms = new AboutOfSystem();
            sysInfoForms.Show();
        }
    }
}
