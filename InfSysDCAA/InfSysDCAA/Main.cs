using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Forms.FirstRun;

namespace InfSysDCAA
{
    public partial class Main : Form
    {
        private FirstRun _WindowFirstRun;

        private const int MaxWidth    = 1376;
        private const int MaxHeight   = 768;
        
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
            _WindowFirstRun = new FirstRun(this);
            _WindowFirstRun.FormClosed += FirstRunFormClosed;
            _WindowFirstRun.ShowDialog(this);
        }

        private void FirstRunFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void btn_first_run()
        {
            _WindowFirstRun.Visible = false;
        }
    }
}
