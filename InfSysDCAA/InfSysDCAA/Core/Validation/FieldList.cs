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
            {"field_descriptionDevice", @"^[А-Яа-я-_ \,\.]{20,1000}$"},
            {"field_reciver_diffInVolt_min",     @"^[0-9\\.]{1,4}$"},
            {"field_reciver_diffInVolt_max",     @"^[0-9\\.]{1,4}$"},
            {"field_temp_min",                   @"^[0-9+-]{1,3}$"},
            {"field_temp_max",                   @"^[0-9+-]{1,3}$"},
            {"field_reciver_diffOutVolt_min",    @"^[0-9\\.]{1,4}$"},
            {"field_reciver_diffOutVolt_max",    @"^[0-9\\.]{1,4}$"},
            {"field_timeToUpDownSignal_min",     @"^[0-9]{2,3}$"},
            {"field_timeToUpDownSignal_typical", @"^[0-9]{2,3}$"},
            {"field_timeToUpDownSignal_max",     @"^[0-9]{2,3}$"},
            {"field_power_plus5V_min",           @"^[0-9]{1,3}$"},
            {"field_power_plus5V_max",           @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_min",        @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_typical",    @"^[0-9]{1,3}$"},
            {"field_power_plus12V_P_max",        @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_min",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_typical",   @"^[0-9]{1,3}$"},
            {"field_power_plus12V_25_max",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_min",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_typical",   @"^[0-9]{1,3}$"},
            {"field_power_plus12V_50_max",       @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_min",      @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_typical",  @"^[0-9]{1,3}$"},
            {"field_power_plus12V_100_max",      @"^[0-9]{1,3}$"},
            {"field_power_minus12V_min",         @"^[0-9]{1,3}$"},
            {"field_power_minus12V_typical",     @"^[0-9]{1,3}$"},
            {"field_power_minus12V_max",         @"^[0-9]{1,3}$"}

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
            {"field_descriptionDevice", "Поле \"Описание устройства\" содержит ошибки:\r\n"},
            {"field_reciver_diffInVolt_min", "Поле \"Дифференциальное входное напряжение: Минимум\" содержит ошибки:\r\n"},
            {"field_reciver_diffInVolt_max","Поле \"Дифференциальное входное напряжение: Максимум\" содержит ошибки:\r\n"},
            {"field_temp_min","Поле \"Температура: Минимум\" содержит ошибки:\r\n"},
            {"field_temp_max","Поле \"Температура: Максимум\" содержит ошибки:\r\n"},
            {"field_reciver_diffOutVolt_min", "Поле \"Дифференциальное выходное напряжение: Минимум\" содержит ошибки:\r\n"},
            {"field_reciver_diffOutVolt_max", "Поле \"Дифференциальное выходное напряжение: Минимум\" содержит ошибки:\r\n"},
            {"field_timeToUpDownSignal_min","Поле \"Время наростания/спада сигнала: Минимум\" содержит ошибки:\r\n"},
            {"field_timeToUpDownSignal_typical", "Поле \"Время наростания/спада сигнала: Рабочее\" содержит ошибки:\r\n"},
            {"field_timeToUpDownSignal_max","Поле \"Время наростания/спада сигнала: Максимум\" содержит ошибки:\r\n"},
            {"field_power_plus5V_min","Поле \"Питание +5В минимум\" содержит ошибки:\r\n"},
            {"field_power_plus5V_max", "Поле \"Питание +5В максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_min","Поле \"Питание +12В в паузе минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_typical","Поле \"Питание +12В рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_P_max","Поле \"Питание +12В максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_min","Поле \"Питание +12В 25% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_typical","Поле \"Питание +12В 25% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_25_max","Поле \"Питание +12В 25% максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_min","Поле \"Питание +12В 50% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_typical","Поле \"Питание +12В 50% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_50_max","Поле \"Питание +12В 50% максимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_min","Поле \"Питание +12В 100% минимум\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_typical","Поле \"Питание +12В 100% рабочее\" содержит ошибки:\r\n"},
            {"field_power_plus12V_100_max","Поле \"Питание +12В 100% максимум\" содержит ошибки:\r\n"},
            {"field_power_minus12V_min","Поле \"Питание -12В минимум\" содержит ошибки:\r\n"},
            {"field_power_minus12V_typical","Поле \"Питание -12В рабочее\" содержит ошибки:\r\n"},
            {"field_power_minus12V_max","Поле \"Питание -12В максимум\" содержит ошибки:\r\n"}
        };
    }
}
