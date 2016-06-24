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
            {"field_db_host", @"^"},
            {"field_db_name", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            {"field_db_user", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            //{"field_db_password", @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})$"}, real
            {"field_db_password", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},    //test

            {"field_system_login", @"^[a-zA-Z][a-zA-Z0-9-_]{1,10}$"},
            {"field_system_password", @"^[a-zA-Z][a-zA-Z0-9-_]{8,15}$"},

            {"field_nameDevice",@"^[a-zA-Z0-9-_ ]{5,15}$"},
            {"field_manufacturerDevice", @"^[a-zA-Z- ]{3,15}$"},
            {"field_inventnumberDevice", @"^[0-9]{10}$"},
            {"field_serialnumberDevice", @"^[a-zA-Z0-9]{5,15}$"},
            {"field_descriptionDevice", @"^[А-Яа-я-_ \,\.]{20,1000}$"},

            {"field_receiver_diffInVolt_min", @"^[0-9\\.]{1,4}$" },
            {"field_reciever_diffInVolt_max", @"^[0-9\\.]{1,4}$" },
            {"field_reciever_epsilon", @"^[0-9\\.]{1,4}$" },

            {"field_transmitter_diffOutVolt_min", @"^[0-9\\.]{1,4}$" },
            {"field_transmitter_diffOutVolt_max", @"^[0-9\\.]{1,4}$" },
            {"field_transmitter_epsilon",       @"^[0-9\\.]{1,4}$" },
            {"field_transmitter_rise_min",      @"^[0-9]{2,3}$" },
            {"field_transmitter_rise_max",      @"^[0-9]{2,3}$" },
            {"field_transmitter_rise_epsilon",  @"^[0-9\\.]{1,4}$" },

            {"field_temperature_min",           @"^[0-9]{1,3}$" },
            {"field_temperature_max",           @"^[0-9]{1,3}$" },
            {"field_temperature_epsilon",       @"^[0-9\\.]{1,4}$" },

            {"field_power_plus5V_max",           @"^[0-9]{1,3}$"},
            {"field_power_plus5V_epsilon",       @"^[0-9\\.]{1,4}$"},

            {"field_power_plus12V_P_min",        @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_typical",    @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_max",        @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_epsilon",    @"^[0-9\\.]{1,4}$"},

            {"field_power_plus12V_25_min",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_typical",   @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_max",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_epsilon",   @"^[0-9\\.]{1,4}$"}
            ,
            {"field_power_plus12V_50_min",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_typical",   @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_max",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_epsilon",   @"^[0-9\\.]{1,4}$"},

            {"field_power_plus12V_100_min",      @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_typical",  @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_max",      @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_epsilon",  @"^[0-9\\.]{1,4}$"},

            {"field_power_minus12V_max",         @"^[0-9]{1,3}$"},
            {"field_power_minus12V_epsilon",     @"^[0-9\\.]{1,4}$"},

            {"field_ftp_host",                   @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$"},
            {"field_ftp_login",                  @"^[a-zA-Z]"},
            {"field_ftp_password",               @"^[a-zA-Z]"}

        };
        /// <summary>
        /// fieldNamePresenter - Dictionary<string, string> - содержит базовые текстовые конструкции для ошибок
        /// </summary>
        public static readonly Dictionary<string, string> fieldNamePresenter = new Dictionary<string, string>()
        {
            {"field_db_host",                   "Поле \"Хост базы данных\" содержит ошибки:\r\n"},
            {"field_db_name",                   "Поле \"Имя базы данных\" содержит ошибки:\r\n"},
            {"field_db_user",                   "Поле \"Имя пользователя базы данных\" содержит ошибки:\r\n"},
            {"field_db_password",               "Поле \"Пароль\" содержит ошибки:\r\n"},
            {"field_system_login",              "Поле \"Логин\" содержит ошибки:\r\n"},
            {"field_system_password",           "Поле \"Пароль\" содержит ошибки:\r\n"},
            {"field_nameDevice",                "Поле \"Имя устройства\" содержит ошибки:\r\n"},
            {"field_manufacturerDevice",        "Поле \"Производитель устройства\" содержит ошибки:\r\n"},
            {"field_inventnumberDevice",        "Поле \"Инвентарный номер\" содержит ошибки:\r\n"},
            {"field_serialnumberDevice",        "Поле \"Серийный номер\" содержит ошибки:\r\n"},
            {"field_descriptionDevice",         "Поле \"Описание устройства\" содержит ошибки:\r\n"},

            {"field_reciever_diffInVolt_min",   "Поле \"Дифференциальное входное напряжение: Минимум\" содержит ошибки:\r\n"},
            {"field_reciever_diffInVolt_max",   "Поле \"Дифференциальное входное напряжение: Максимум\" содержит ошибки:\r\n"},
            {"field_reciever_epsilon",          "Поле \" Допуск дифференциального входного напряжения\" содержит ошибки:\r\n"},


            {"field_transmitter_diffOutVolt_min",   "Поле \"Дифференциальное выходное напряжение: Минимум\" содержит ошибки:\r\n"},
            {"field_transmitter_diffOutVolt_max",   "Поле \"Дифференциальное выходное напряжение: Максимум\" содержит ошибки:\r\n"},
            {"field_transmitter_diffOutVolt_typical",   "Поле \"Дифференциальное выходное напряжение: Рабочее\" содержит ошибки:\r\n"},
            {"field_transmitter_epsilon",           "Поле \"Допуск дифференциального выходного напряжения\" содержит ошибки:\r\n"},
            {"field_transmitter_rise_min",          "Поле \"Время нарастания и спада сиганла: Минимум\" содержит ошибки:\r\n"},
            {"field_transmitter_rise_max",          "Поле \"Время нарастания и спада сиганла: Максимум\" содержит ошибки:\r\n"},
            {"field_transmitter_rise_typical",          "Поле \"Время нарастания и спада сиганла: Рабочее\" содержит ошибки:\r\n"},
            {"field_transmitter_rise_epsilon",      "Поле \"Допуск по времени нарастания и спада сигнала\" содержит ошибки:\r\n"},

            {"field_temperature_min",               "Поле \"Температура: Минимум\" содержит ошибки:\r\n"},
            {"field_temperature_max",               "Поле \"Температура: Максимум\" содержит ошибки:\r\n"},
            {"field_temperature_epsilon",           "Поле \"Допуск по температуре\" содержит ошибки:\r\n"},

            {"field_power_plus5V_max",          "Поле \"Питание +5В минимум\" содержит ошибки:\r\n"},
            {"field_power_plus5V_epsilon",      "Поле \"Допуск по питанию +5В\" содержит ошибки:\r\n"},

            {"field_power_plus12V_P_min",       "Поле \"Питание +12В в паузе минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_typical",   "Поле \"Питание +12В рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_max",       "Поле \"Питание +12В максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_epsilon",   "Поле \"Допуск по питанию +12В\" содержит ошибки:\r\n"},

            {"field_power_plus12V_25_min",      "Поле \"Питание +12В 25% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_typical",  "Поле \"Питание +12В 25% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_max",      "Поле \"Питание +12В 25% максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_epsilon",  "Поле \"Допуск по питанию +12В 25%\" содержит ошибки:\r\n"},

            {"field_power_plus12V_50_min",      "Поле \"Питание +12В 50% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_typical",  "Поле \"Питание +12В 50% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_max",      "Поле \"Питание +12В 50% максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_epsilon",  "Поле \"Допуск по питанию +12В 50%\" содержит ошибки:\r\n"},

            {"field_power_plus12V_100_min",     "Поле \"Питание +12В 100% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_typical", "Поле \"Питание +12В 100% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_max",     "Поле \"Питание +12В 100% максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_epsilon", "Поле \"Допуск по питанию +12В 100%\" содержит ошибки:\r\n"},

            {"field_power_minus12V_max",        "Поле \"Питание -12В минимум\" содержит ошибки:\r\n"},
            {"field_power_minus12V_epsilon",    "Поле \"Допуск по питанию -12В\" содержит ошибки:\r\n"},

            {"field_ftp_host",                  "Поле \"FTP-хост\" содержит ошибки:\r\n" },
            {"field_ftp_login",                 "Поле \"FTP-логин\" содержит ошибки:\r\n"},
            {"field_ftp_password",               "Поле \"FTP-пароль\" содержит ошибки:\r\n"}
        };
    }
}
