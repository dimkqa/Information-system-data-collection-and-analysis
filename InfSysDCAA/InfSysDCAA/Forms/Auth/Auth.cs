using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InfSysDCAA.Core.Validation;
using System.Linq;

namespace InfSysDCAA.Forms.Auth
{
    public partial class Auth : Form
    {
        private Authorization _authorization;


        private const int Width = (int)300;    
        private const int Height = (int)204; 

        private List<Control> controlsInForm = new List<Control>();

        public Auth(List<Control> tmpControlsForm)
        {
            InitializeComponent();

            controlsInForm = tmpControlsForm;
            Text = Convert.ToString("ИСВСК Авторизация");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            StatusUserUI.StatusFunctionalityPartsOfTheWindow(tmpControlsForm);
        }

        /// <summary>
        /// Обработка нажатия кнопки входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_system_Click(object sender, EventArgs e)
        {
            string login = Convert.ToString(field_system_login.Text);
            string password = Convert.ToString(field_system_password.Text);

            field_system_login.Enabled = false;
            field_system_password.Enabled = false;

            _authorization = new Authorization(login, password);
            if (!_authorization.ScanLogin())
            {
                MessageBox.Show("Неправильный логин", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.None);
                field_system_login.Enabled = true;
                field_system_password.Enabled = true;
            }
            else
            {
                this.Hide();
                StatusUserUI.StatusFunctionalityPartsOfTheWindow(setAllControlsEnabled(controlsInForm));
            }
        }

        /// <summary>
        /// Устанавливает значение всех control на форме в false
        /// </summary>
        /// <param name="arrayControlsForm"></param>
        /// <returns>Возвращает "List"></returns>
       private List<Control> setAllControlsEnabled(List<Control> arrayControlsForm)
        {
           foreach (Control c in arrayControlsForm)
           {
               c.Enabled = false;
           }
            return arrayControlsForm;
        }

        /// <summary>
        /// Обработка нажатия кнопки выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_logout_system_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработка нажатия кнопки выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
