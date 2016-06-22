using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Config;
using MySql.Data.MySqlClient;

namespace InfSysDCAA.Core.DataBase
{
    /// <summary>
    /// Выполнение запросов к БД с возвращением одного параметра
    /// </summary>
    public partial class DataBaseConnect
    {
        /// <summary>
        /// Запрос на выборку данных о пользователе
        /// </summary>
        /// <returns></returns>
        public List<string> getUserInfoFromDataBase(string login, string password)
        {
            int countRead = 0;
            List<string> list = new List<string>();
            string query = "SELECT * FROM employees WHERE login=\"" + login + "\" AND password=\"" + password + "\"";
            //Создаём новое соединение
            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["firstname"] + " ");
                    list.Add(dataReader["secondname"] + " ");
                    list.Add(dataReader["position"] + " ");
                    list.Add(dataReader["login"] + " ");
                    list.Add(dataReader["password"] + " ");
                    countRead++;
                }
                if (countRead == 0)
                {
                    throw new Exception("Пользователь не зарегистрирован в системе.");
                }
                dataReader.Close();
                CloseConnection();
                return list;
            }
            else
            {
                throw new Exception("Возникла ошибка при соединении с сервером.");
                return list;
            }
        }
    }
}
