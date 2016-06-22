using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Config
{
    /// <summary>
    /// Получение информации о соединении с БД
    /// </summary>
    public static class GetConnectionString
    {
        /// <summary>
        /// Возвращает строку соединения с параметрами
        /// </summary>
        /// <returns></returns>
        public static string getStringConnectionData()
        {
            return Convert.ToString("SERVER=" + Properties.Application_data.user.Default.field_db_host + ";" + "DATABASE=" +
                   Properties.Application_data.user.Default.field_db_name + ";" + "UID=" +
                   Properties.Application_data.user.Default.field_db_user + ";" + "PASSWORD=" +
                   Properties.Application_data.user.Default.field_db_password + ";");
        }

        /// <summary>
        /// Собирает строку для коннекта и возвращает её
        /// </summary>
        /// <param name="p1">Сервер</param>
        /// <param name="p2">БД</param>
        /// <param name="p3">Пользователь</param>
        /// <param name="p4">Пароль</param>
        /// <returns></returns>
        public static string getStringConnectionData(string p1, string p2, string p3, string p4)
        {
            return Convert.ToString("SERVER=" + p1 + ";" + "DATABASE=" + p2 + ";" + "UID=" + p3 + ";" + "PASSWORD=" + p4 + ";");
        }
    }
}
