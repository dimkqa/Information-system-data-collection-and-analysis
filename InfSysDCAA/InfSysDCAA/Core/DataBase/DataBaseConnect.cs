using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InfSysDCAA.Core.DataBase
{
    /// <summary>
    /// Основные операции с сервером баз данных
    /// </summary>
    public partial class DataBaseConnect
    {

        /// <summary>
        /// Строка соединения
        /// </summary>
        private string ConnectionString { get; set; }

        /// <summary>
        /// Хранит соединение с базой данных
        /// </summary>
        private MySqlConnection Connection { get; set; }

        /// <summary>
        /// Получаем данные для соединения с сервером баз данных
        /// </summary>
        /// <param name="serverName">Строка, сервер</param>
        /// <param name="databaseName">Строка, база данных</param>
        /// <param name="userName">Строка, пользователь</param>
        /// <param name="password">Строка, пароль</param>
        public DataBaseConnect(string connectionString)
        {
           ConnectionString = connectionString;
        }

        public void InitializeConnect()
        {
            Connection = new MySqlConnection(ConnectionString);
        }

        /// <summary>
        /// Открывает соединение с БД
        /// </summary>
        /// <returns>В случае успеха возвращает true, иначе false</returns>
        private bool OpenConnection()
        {
            string CaptionTextError = "Ошибка соединения";
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException exception)
            {
                switch (exception.Number)
                {
                    case 0:
                    {
                        MessageBox.Show(
                            "Невозможно соединиться с сервером. Попробуйте снова или свяжитесь с администратором.",
                            CaptionTextError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 1042:
                    {
                        MessageBox.Show("Неверный хост подключения, попробуйте еще раз.",
                            CaptionTextError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case 1045:
                    {
                        MessageBox.Show("Неверная пара \"имя пользователя/пароль\", попробуйте еще раз.",
                            CaptionTextError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                    {
                        MessageBox.Show("Возникла неопознанная ошибка. Свяжитесь с администратором.", CaptionTextError,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
                return false;
            }
        }

        /// <summary>
        /// Закрывает соединение с БД
        /// </summary>
        /// <returns>В случае успешного закрытия возвращает true.
        ///          В случае неудачного закрытия возвращет сообщение об ошибке и false</returns>
        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message, exception.ErrorCode.ToString());
                return false;
            }
        }

        /// <summary>
        /// Тест соединения
        /// </summary>
        /// <returns>В случае удачи вовзращает true, иначе false</returns>
        public bool TestConnection()
        {
            InitializeConnect();
            if (OpenConnection())
            {
                CloseConnection();
                return true;
            }
            return false;
        }
    }
}
