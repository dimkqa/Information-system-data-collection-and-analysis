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
        /*public bool InsertDataDevice(TestDataStructure.TestDataStruct[] resultDataDevices)
        {
            int countDevice = resultDataDevices.Count();    //Число устройств
            int counterDev = 0;
            int maxId;
            List<string> tableList = new List<string>();
            List<int> valueList = new List<int>();

            try
            {

                while (counterDev != countDevice)
                {
                    //Получаем id 
                    maxId = SelectMaxId("minus12v");
                    InsertIntoDeviceParamData("minus12v", SelectMaxId("minus12v"), tableList);
                    InsertIntoDeviceParamData("plus5v", SelectMaxId("plus5v"), tableList);
                    InsertIntoDeviceParamData("	plus12vpause", SelectMaxId("plus12vpause"), tableList);
                    InsertIntoDeviceParamData("plus12v25time", SelectMaxId("plus12v25time"), tableList);
                    InsertIntoDeviceParamData("plus12v50time", SelectMaxId("plus12v50time"), tableList);
                    InsertIntoDeviceParamData("plus12v100time", SelectMaxId("plus12v100time"), tableList);
                    InsertIntoDeviceParamData("reciver_in_diff_v", SelectMaxId("reciver_in_diff_v"), tableList);
                    InsertIntoDeviceParamData("rise_and_fall_time_signal", SelectMaxId("rise_and_fall_time_signal"), tableList);
                    InsertIntoDeviceParamData("out_diff_volt", SelectMaxId("out_diff_volt"), tableList);
                    InsertIntoDeviceParamData("transmitter", SelectMaxId("transmitter"), tableList, valueList);
                    ///Добавка в другую дичь
                    InsertIntoDeviceParamData("temperature", SelectMaxId("temperature"), tableList);
                    //query = "INSERT INTO [counterDev].DeviceInventNumber";
                    counterDev++;
                }
                return true;

                //Min|Max|Aver
            }
            catch (Exception exp)
            {
                return false;
            }
        }*/

        /// <summary>
        /// Вставка данных в таблицу
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="maxId">Предыдущий номер записи в таблице</param>
        /// <param name="paramValue">List параметров</param>
        /// <returns>true в случае удачной вставки</returns>
        private bool InsertIntoDeviceParamData(string table, int maxId, List<double> paramValue)
        {
            string query = "INSERT INTO `" + table + "` (`id`, `minimum`, `medium`, `maximum`) VALUES(" + (maxId + 1) +
                           "," + paramValue[0] + " , " + paramValue[1] + ", " + paramValue[2] + ")";
            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                MySqlCommand mCom = new MySqlCommand(query, Connection);
                mCom.ExecuteScalar();
                CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Вставка данных в таблицу (связка множества подтаблиц в одну
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="paramList">List имён таблиц, которые необходимо вставить</param>
        /// <example>queryPart1 `plus12vPause_id`, `plus5v_id`, `minus12v_id`, `plus12v100time_id`, `plus12v50time_id`, `plus12v25time_id`)</example>
        /// <returns></returns>
        private bool InsertIntoDeviceParamData(string table, int maxId, List<string> tableList, List<int> valueList)
        {
            string query = "INSERT INTO `" + table + "` (`id`,  ";
            //Конструирование строки

            query += GenerationOfFirstPartQueryString(tableList);
            query += GenerationOfTwoPartQueryString(valueList);

            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                MySqlCommand mCom = new MySqlCommand(query, Connection);
                mCom.ExecuteScalar();
                CloseConnection();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Генерация первой части запроса на вставку данных
        /// </summary>
        /// <param name="tableList">List имена таблиц</param>
        /// <returns>Первая часть строки запроса</returns>
        private string GenerationOfFirstPartQueryString(List<string> tableList)
        {
            string str = "";
            for (int i = 0; i < tableList.Count(); i++)
            {
                str += "`" + tableList[i] + "`";
                if (i != tableList.Count())
                {
                    str += ",";
                }
                else
                {
                    str += ") VALUES ";
                }
            }
            return str;
        }

        /// <summary>
        /// Возврат второй части запроса
        /// </summary>
        /// <param name="valueList">List значений</param>
        /// <returns>Возвращает строку с запросом</returns>
        private string GenerationOfTwoPartQueryString(List<int> valueList)
        {
            string str = "(";
            for (int i = 0; i < valueList.Count(); i++)
            {
                str += "" + valueList[i] + "";
                if (i != valueList.Count())
                {
                    str += ",";
                }
                else
                {
                    str += ")";
                }
            }
            return str;
        }

        /* TODO: UPDATE
       private bool InsertIntoDeviceManager(string table, string inventNumber, string id)
        {
            string query = "INSERT INTO `" + table + "` (`" + inventNumber + "`, `"+ id +"`, `"++"`)";
            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                MySqlCommand mCom = new MySqlCommand(query, Connection);
                CloseConnection();
                return true;
            }
            return false;
        }*/

        private int SelectMaxId(string table)
        {
            Connection = new MySqlConnection(GetConnectionString.getStringConnectionData());
            if (OpenConnection())
            {
                string query = "SELECT max(`id`) FROM \"" + table + "\"";
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                CloseConnection();
                return Convert.ToInt32(mySqlCommand.ExecuteScalar().ToString());
            }
            return 0;
        }


        /// <summary>
        /// Получение данных об устройства
        /// </summary>
        /// <param name="param">Параметр поиска (что ищем)</param>
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
