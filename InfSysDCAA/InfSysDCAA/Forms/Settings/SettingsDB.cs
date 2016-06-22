using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core;
using InfSysDCAA.Core.Config;
using InfSysDCAA.Core.DataBase;
using MySql.Data.MySqlClient;
using InfSysDCAA.Core.Settings;
using InfSysDCAA.Core.Validation;

namespace InfSysDCAA.Forms.Settings
{
    public partial class SettingsDB : Form
    {
        private const int Width = (int)350;    
        private const int Height = (int)250;

        Settings_DB _sdb = new Settings_DB();

        private List<TextBox> _fields = new List<TextBox>();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SettingsDB()
        {
            InitializeComponent();

            Text = Convert.ToString("Параметры соединения с БД");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            _fields.Add(field_db_host);
            _fields.Add(field_db_name);
            _fields.Add(field_db_user);
            _fields.Add(field_db_password);
            RecoveryConnectionData(_sdb.ReadDataSettings());
        }

        /// <summary>
        /// В зависимости от результатов валидации полей выдаёт ошибку,
        /// или сохраняет данные соединения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_settings_connect_Click(object sender, EventArgs e)
        {
            //Сохранение настроек подключения
            if (ValidationField.ValidationFields(_fields))
            {
                SaveDataConnection();
                Close();
            }
        }

        /// <summary>
        /// Выполняет проверку соедиения с сервером. 
        /// В случае удачи, предлагает сохранить настройки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_test_connect_Click(object sender, EventArgs e)
        {
            if (ValidationField.ValidationFields(_fields))
            {
                if (TestConnectToDb(_fields))
                    SuccessConnection();
            }
        }

        /// <summary>
        /// Сохраняет данные о конфигурации соединения с сервером баз данных
        /// </summary>
        private void SaveDataConnection()
        {
            if (ValidationField.ValidationFields(_fields))
            {
                foreach (var field in _fields)
                {
                    _sdb.WriteDataSettings(field.Name, field.Text);
                }
                Close();
            }
        }

        /// <summary>
        /// Выполняет проверку соеднения с сервером баз данных
        /// </summary>
        /// <param name="field">List textbox'ов</param>
        /// <returns>Если соединение установлено, возвращает true, иначе false</returns>
        private bool TestConnectToDb(List<TextBox> field)
        {
            //TODO: codereview + error Connect;

            DataBaseConnect DBC =
                new DataBaseConnect(GetConnectionString.getStringConnectionData(field[0].Text, field[1].Text,
                    field[2].Text, field[3].Text));
            if (DBC.TestConnection())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// При загрузке формы "Настройки" извлекает из файла-конфигурации
        /// параметры последнего соединения и заполняет ими поля формы.
        /// </summary>
        /// <param name="tmpDictionary"></param>
        private void RecoveryConnectionData(Dictionary<string, string> tmpDictionary)
        {
            foreach (KeyValuePair<string, string> tmp in tmpDictionary)
            {
                foreach (var field in _fields)
                {
                    if (field.Name == tmp.Key)
                    {
                        field.Text = tmp.Value;
                    }
                }
            }
        }

        /// <summary>
        /// При удачном соединиении с сервером баз данных 
        /// выполняет сохранение настроек.
        /// </summary>
        /// <param name="textBoxs"></param>
        private void SuccessConnection()
        {
            MessageBox.Show("Соединение с сервером баз данных было установлено и проверено.", "Успешное соединение с сервером",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Сохранить конфигурацию соединения с сервером баз данных?",
                "Сохранение конфигурации параметров соединения",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveDataConnection();
                Close();
            }
        }
    }
}
