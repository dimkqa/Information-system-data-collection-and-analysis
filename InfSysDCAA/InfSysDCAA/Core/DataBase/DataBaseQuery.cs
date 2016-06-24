using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Config;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing.Test;
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

        /// <summary>
        /// Отправка в базу данных результатов тестирования 
        /// </summary>
        /// <param name="resultDataDevices">TestDataStructure.TestDataStruct[] - массив результатов</param>
        /// <returns></returns>
        public bool InsertDataDevice(TestDataStructure.TestDataStruct[] resultDataDevices)
        {

            return true;
        }

        /// <summary>
        /// Получение имени устройства
        /// </summary>
        /// <param name="InventoryNumber">Инвентарный номер устройства</param>
        /// <returns></returns>
        public string getGetDeviceData(string param, string InventoryNumber)
        {
            int countRead = 0;
            string deviceData = " ";
            string query = "SELECT " + param + " FROM device_manager WHERE inventnumber = \"" + InventoryNumber + "\"";
            //Создаём новое соединение
            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    deviceData = Convert.ToString(dataReader[param] + "");
                    countRead++;
                }
                if (countRead == 0)
                {
                    throw new Exception("Устройство с заданым id не найдено!");
                }
                dataReader.Close();
                CloseConnection();
                return deviceData;
            }
            else
            {
                throw new Exception("Возникла ошибка при соединении с сервером.");
                return deviceData;
            }
        }
    }
}
