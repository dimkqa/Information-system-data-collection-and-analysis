using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.FTP;
using InfSysDCAA.Core.Settings;
using InfSysDCAA.Core.Validation;

namespace InfSysDCAA.Forms.Settings
{
    public partial class Connection_FTP_Data : Form
    {
        private const int Width = (int)300;    //Максимальная ширина окна
        private const int Height = (int)167;   //Максимальная высота окна

        Settings_FTP SFTP = new Settings_FTP();

        private List<TextBox> fields = new List<TextBox>();

        public Connection_FTP_Data()
        {
            InitializeComponent();

            Text = Convert.ToString("Параметры FTP-соединения");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            fields.Add(field_ftp_host);
            fields.Add(field_ftp_login);
            fields.Add(field_ftp_password);

            RecoveryConnectionData(SFTP.ReadDataSettings());
        }

        /// <summary>
        /// Выполняет проверку соеднения с сервером баз данных
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private bool TestConnectToDB(List<TextBox> field)
        {
            //TODO: codereview + error Connect;
            FTP ftpClient = new FTP(field[0].Text, field[1].Text, field[2].Text);
            
            if (!ftpClient.Test())
                return false;
            else
                return true;
        }

        /// <summary>
        /// При удачном соединиении с сервером баз данных 
        /// выполняет сохранение настроек.
        /// </summary>
        /// <param name="textBoxs"></param>
        private void SuccessConnection(List<TextBox> textBoxs)
        {
            MessageBox.Show("Соединение с FTP-сервером было установлено и проверено.", "Успешное соединение с сервером",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Сохранить конфигурацию соединения FTP-сервером?",
                "Сохранение конфигурации параметров соединения",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveDataConnection();
                Close();
            }
        }

        /// <summary>
        /// Соединение с сервером баз данных не удалось осуществить.
        /// </summary>
        private void failureConnection()
        {
            MessageBox.Show("Не удалось соединиться с FTP-сервером.\n " +
                            "Проверьте введеные данные и убедитесь в доступности сервера", "Ошибка соединения с сервером",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button_save_ftp_settings_Click(object sender, EventArgs e)
        {
            //Сохранение настроек подключения
            if (ValidationField.ValidationFields(fields))
            {
                SaveDataConnection();
            }
        }

        /// <summary>
        /// Сохраняет данные 
        /// </summary>
        private void SaveDataConnection()
        {
            foreach (var field in fields)
            {
                SFTP.WriteDataSettings(field.Name, field.Text);
            }
            Close();
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
                foreach (var field in fields)
                {
                    if (field.Name == tmp.Key)
                    {
                        field.Text = tmp.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Выполняет проверку соедиения с сервером. 
        /// В случае удачи, предлагает сохранить настройки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_test_ftp_settings_Click(object sender, EventArgs e)
        {
            if (ValidationField.ValidationFields(fields))
            {
                if (TestConnectToDB(fields))
                    SuccessConnection(fields);
                else
                    failureConnection();
            }
        }
    }
}
