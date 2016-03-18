using System;
using System.Windows.Forms;

namespace InfSysDCAA.Forms.Auth
{
    public partial class Auth : Form
    {
        private readonly Main _parentForm;               //Родительская форма.
        private readonly Auth _currentForm;              //Текущая форма 
        private Authorization _authorization;


        private const int Width = (int)300;    //Максимальная ширина окна
        private const int Height = (int)204;   //Максимальная высота окна

        /// <summary>
        /// Публичный конструктор формы. Устанвливает начальные параметры отображения окна.
        /// </summary>
        /// <param name="mainForm">Main ссылка на главную форму</param>
        public Auth(Main mainForm)
        {
            _parentForm = mainForm;
            InitializeComponent();
            ///Параметры окна
            Text = Convert.ToString("ИСВСК Авторизация");//Название формы
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);//Минимальный размер окна
            MaximumSize = new System.Drawing.Size(Width, Height);//Максимальный размер окна
            StatusFunctionalityPartsOfTheWindow(false);
            //testMemberAuth();
            _parentForm.TopMost = false;
            _currentForm = this;
        }

        /// <summary>
        /// Обработка нажатия кнопки входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            string login = Convert.ToString(login_field.Text);
            string password = Convert.ToString(password_field.Text);

            login_field.Enabled = false;
            password_field.Enabled = false;

            _authorization = new Authorization(login, password);
            if (!_authorization.ScanLogin())
            {
                MessageBox.Show("Неправильный логин", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.None);
                login_field.Enabled = true;
                password_field.Enabled = true;
            }
            else
            {
                _currentForm.Hide();
               StatusFunctionalityPartsOfTheWindow(true);
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Отвечает за доступ к функциональным полям главной формы
        /// </summary>
        /// <param name="enabled">BOOL включено или выключено.</param>
        private void StatusFunctionalityPartsOfTheWindow(bool enabled)
        {
            if (!enabled)
            {
                _parentForm.gridViewReportsList.Enabled = false;
                _parentForm.addeddatafileToolStripMenuItem.Enabled = false;
                _parentForm.reportsToolStripMenuItem.Enabled = false;
                _parentForm.serviceToolStripMenuItem.Enabled = false;
                _parentForm.helpToolStripMenuItem.Enabled = false;
                _parentForm.button_blocked.Enabled = false;
                _parentForm.button_logout.Enabled = false;
            }
            else
            {
                _parentForm.gridViewReportsList.Enabled = true;
                _parentForm.addeddatafileToolStripMenuItem.Enabled = true;
                _parentForm.reportsToolStripMenuItem.Enabled = true;
                _parentForm.serviceToolStripMenuItem.Enabled = true;
                _parentForm.helpToolStripMenuItem.Enabled = true;
                _parentForm.button_blocked.Enabled = true;
                _parentForm.button_logout.Enabled = true;
            }
        }
    }
}
