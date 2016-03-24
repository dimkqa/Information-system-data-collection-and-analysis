using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Validation
{
    internal static class FieldList
    {
        /// <summary>
        /// patterns - Dictionary<string, string> - содержит Name элемента (здесь, TextBox) и регулярное выражение для проверки
        /// </summary>
        public static readonly Dictionary<string, string> patterns = new Dictionary<string, string>()
        {
            {"field_db_host", @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$"},
            {"field_db_name", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            {"field_db_user", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            {"field_db_password", @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})$"},
            {"field_system_login", @"^[a-zA-Z][a-zA-Z0-9-_]{10}$"},
            {"field_system_password", @"^[a-zA-Z][a-zA-Z0-9-_]{8,15}$"},
            {"field_nameDevice",@"^[a-zA-Z0-9-_ ]{5,15}$"},
            {"field_manufacturerDevice", @"^[a-zA-Z- ]{3,15}$"},
            {"field_inventnumberDevice", @"^[0-9]{10}$"},
            {"field_serialnumberDevice", @"^[a-zA-Z0-9]{5,15}$"},
            {"field_descriptionDevice", @"^[А-Яа-я-_ \,\.]{20,1000}$"}

        };
        /// <summary>
        /// fieldNamePresenter - Dictionary<string, string> - содержит базовые текстовые конструкции для ошибок
        /// </summary>
        public static readonly Dictionary<string, string> fieldNamePresenter = new Dictionary<string, string>()
        {
            {"field_db_host", "Поле \"Хост базы данных\" содержит ошибки:\r\n"},
            {"field_db_name", "Поле \"Имя базы данных\" содержит ошибки:\r\n"},
            {"field_db_user", "Поле \"Имя пользователя базы данных\" содержит ошибки:\r\n"},
            {"field_db_password", "Поле \"Пароль\" содержит ошибки:\r\n"},
            {"field_system_login", "Поле \"Логин\" содержит ошибки:\r\n"},
            {"field_system_password", "Поле \"Пароль\" содержит ошибки:\r\n"},
            {"field_nameDevice", "Поле \"Имя устройства\" содержит ошибки:\r\n"},
            {"field_manufacturerDevice", "Поле \"Производитель устройства\" содержит ошибки:\r\n"},
            {"field_inventnumberDevice", "Поле \"Инвентарный номер\" содержит ошибки:\r\n"},
            {"field_serialnumberDevice", "Поле \"Серийный номер\" содержит ошибки:\r\n"},
            {"field_descriptionDevice", "Поле \"Описание устройства\" содержит ошибки:\r\n"}
        };
    }
}
