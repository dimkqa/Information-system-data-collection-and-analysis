using System.Collections.Generic;

namespace InfSysDCAA.Core.Settings
{
    public static class SettingsFunctions
    {
        private static List<string> tmpList = new List<string>()
        {
            "field_db_host","field_db_name","field_db_user","field_db_password"
        };
        /// <summary>
        /// Производит запись данных соединения в конфигурационный файл приложения
        /// </summary>
        /// <param name="name">string Имя поля</param>
        /// <param name="value">value Значение поля</param>
        public static void WriteDataSettings(string name, string value)
        {
            Properties.Application_data.user.Default[name] = value;
            Properties.Application_data.user.Default.Save();
        }

        /// <summary>
        /// Производит чтение данных соединения из конфигурационный файла приложения
        /// </summary>
        /// <returns>Возвращает словарь с данными</returns>
        public static Dictionary<string, string> ReadDataSettings()
        {
            Dictionary<string, string> connectDictionary = new Dictionary<string, string>()
            {
                {tmpList[0], Properties.Application_data.user.Default.field_db_host},
                {tmpList[1], Properties.Application_data.user.Default.field_db_name},
                {tmpList[2], Properties.Application_data.user.Default.field_db_user},
                {tmpList[3], Properties.Application_data.user.Default.field_db_password}
            };
             return connectDictionary;
        }
    }
}
