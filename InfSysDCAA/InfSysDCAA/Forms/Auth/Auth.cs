using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InfSysDCAA.Core.Validation;
using System.Linq;
using InfSysDCAA.Core.Auth;

namespace InfSysDCAA.Forms.Auth
{
    public partial class Auth : Form
    {
        private const int Width = (int)300;    
        private const int Height = (int)204; 

        private List<Control> controlsInForm = new List<Control>();
        private List<TextBox> fields = new List<TextBox>();
        public Auth(List<Control> tmpControlsForm)
        {
            InitializeComponent();

            Text = Convert.ToString("ИСВСК Авторизация");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            controlsInForm = tmpControlsForm;
            fields.Add(field_system_login);
            fields.Add(field_system_password);

            StatusUserUI.StatusFunctionalityPartsOfTheWindow(tmpControlsForm);
        }

        /// <summary>
        /// Обработка события при нажатии на кнопку входа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_system_Click(object sender, EventArgs e)
        {
            //Если валидация успешна
            if (ValidationField.ValidationFields(fields))
            {
                List<Control> fieldsAuth = new List<Control>()
                {
                  field_system_login, field_system_password
                };

                string login = Convert.ToString(field_system_login.Text);
                string password = Convert.ToString(field_system_password.Text);

                StatusUserUI.StatusFunctionalityPartsOfTheWindow(fieldsAuth);
                AuthClass uAuth = new AuthClass(login, password);
                if (!uAuth.LogIn())
                {
                    MessageBox.Show("Неправильный логин", "Ошибка аутентификации", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    StatusUserUI.StatusFunctionalityPartsOfTheWindow(fieldsAuth);
                }
                else
                {
                    this.Hide();
                    StatusUserUI.StatusFunctionalityPartsOfTheWindow(setAllControlsEnabled(controlsInForm));
                }
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
