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

namespace InfSysDCAA
{
    public partial class Main : Form
    {
        private Auth _authForm;

        private const int MaxWidth    = 1336;
        private const int MaxHeight   = 768;
        protected bool authUser = false;
        public Main()
        {

            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(MaxWidth, MaxHeight);
            MaximumSize = new Size(MaxWidth, MaxHeight);
            Text = Convert.ToString("Информационная система сбора и анализа данных");
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
    }
}
