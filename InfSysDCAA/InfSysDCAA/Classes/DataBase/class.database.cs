using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InfSysDCAA.Classes.MySQLDataBase
{
    class MySQLDataBase
    {/*
        
        private MySqlConnectionStringBuilder _ConnectParamsString;
        private MySqlConnection _Connection;
        private MySQLDataBase instance;

        public MySQLDataBase GetInstance()
        {
            return instance ?? (instance = new MySQLDataBase());
        }

        /// <summary>
        /// Конструктор заносит в структуру MysqlConnectionStringBuilder параметры
        /// для дальнейшей работы с ними.
        /// </summary>
        /// <param name="mysql_db_host">String имя хоста</param>
        /// <param name="mysql_db_name">String имя базы данных</param>
        /// <param name="mysql_db_user">String имя пользователя</param>
        /// <param name="mysql_db_password">String пароль пользователя</param>
        /// <param name="mysql_db_port">Uint номер порта</param>
        public MySQLDataBase(string mysql_db_host, string mysql_db_name, string mysql_db_user,
            string mysql_db_password, uint mysql_db_port)
        {
            _ConnectParamsString = new MySqlConnectionStringBuilder();

            _ConnectParamsString.Server = mysql_db_host;
            _ConnectParamsString.Database = mysql_db_name;
            _ConnectParamsString.UserID = mysql_db_user;
            _ConnectParamsString.Password = mysql_db_password;
            _ConnectParamsString.Port = mysql_db_port;

            _Connection = new MySqlConnection(_ConnectParamsString.ConnectionString);
        }
        private bool setConnection()
        {
             try
             {
                _Connection.Open();
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
            return true;
        }

        public void getConnection()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void closeConnection()
        {
            try
            {

            }
            catch
            {

            }
        }*/

    }
}
