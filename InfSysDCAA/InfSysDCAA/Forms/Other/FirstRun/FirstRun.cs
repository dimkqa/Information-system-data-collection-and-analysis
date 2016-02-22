using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Forms.FirstRun
{
    public partial class FirstRun : Form
    {
        private const int Width = (int)430;    //Максимальная ширина окна
        private const int Height = (int)400;   //Максимальная высота окна
        private Main _parentForm;        //Родительская форма.
        public FirstRun(Main mainForm)
        {
            _parentForm = mainForm;
            InitializeComponent();
            ///Параметры окна настроек
            this.Text = Convert.ToString("Начальная установка");//Название формы
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Minimized;                           //По умолчанию в маленьком окне
            this.MinimumSize = new System.Drawing.Size(Width, Height);//Минимальный размер окна
            this.MaximumSize = new System.Drawing.Size(Width, Height);//Максимальный размер окна
            ///Параметры содержания формы
            ///Label'ы
        }

        private void btn_settings_step_Click(object sender, EventArgs e)
        {

            _parentForm.btn_first_run();
        }


    }
}
