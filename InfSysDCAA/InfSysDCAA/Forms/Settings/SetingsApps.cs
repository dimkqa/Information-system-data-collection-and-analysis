using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Classes.Files;
using InfSysDCAA.Classes.Settings;
using System.Text.RegularExpressions;

namespace InfSysDCAA.Forms.Settings
{
    public partial class SetingsApps : Form
    {
        private SaveSettingsDataBase dbSettings;

        private List<string> dbParamsList = new List<string>();
        private static List<string> regexpList = new List<string>();
        
        //ИЗМЕНИТЬ ПУТЬ!
        //private string pathFile = @"C:\Users\Dmitriy\Documents\GitHub\Information-system-data-collection-and-analysis\InfSysDCAA\InfSysDCAA\Files\Config\database-config.xml";

       
        private const int Width = (int)350;    //Максимальная ширина окна
        private const int Height = (int)250;   //Максимальная высота окна
        
        public SetingsApps()
        {
            InitializeComponent();
            Text = Convert.ToString("Параметры соединения с БД");//Название формы
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);//Минимальный размер окна
            MaximumSize = new System.Drawing.Size(Width, Height);//Максимальный размер окна
            AddRegexp();
        }

        /// <summary>
        /// Считываем информцаию с полей формы и сохраняем в файл конфигурации соединения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbParamsList.Add(name_db_field.Text);
                dbParamsList.Add(host_db_field.Text);
                dbParamsList.Add(user_db_field.Text);
                dbParamsList.Add(password_db_field.Text);
                if (!TestConnectionData(dbParamsList))
                {
                    throw new Exception("Некорректные данные подключения.\n Проверьте и повторите ввод.");
                }

            }
            catch (Exception errException)
            {
                MessageBox.Show(errException.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbSettings = new SaveSettingsDataBase(dbParamsList);
        }



        /// <summary>
        /// Добавляет паттерны для поиска значений:
        /// 1. Имя базы данных - может включать только строчные буквы без спец. символов
        /// 2. Хост - может включать ip адреса IPv4
        /// 3. Имя пользователя БД - может включать только строчные буквы без спец. символов
        /// 4. Пароль пользователя БД - может включать до 255 знаков, включает строчные и заглавные буквы,
        ///                             цифры, знаки и спецсимволы, минимум 8-мь символов
        /// </summary>
        private void AddRegexp()
        {
            regexpList.Add(@"^[a-z]+$");
            regexpList.Add(@"((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)");
            regexpList.Add(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");
        }

        private bool TestConnectionData(List<string> arrayParamLDBist)
        {
            //return true;
            return true;
        }

        private void btn_test_connect_Click(object sender, EventArgs e)
        {

        }
    }
}
