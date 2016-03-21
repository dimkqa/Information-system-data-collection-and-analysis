using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace InfSysDCAA.Core.Validation
{
    /* Божественный код
     * 
     */
    public static class Validation
    {
        /// <summary>
        /// patterns - Dictionary<string, string> - содержит Name элемента (здесь, TextBox) и регулярное выражение для проверки
        /// </summary>
        private static readonly Dictionary<string, string> patterns = new Dictionary<string, string>()
        {
            {"field_db_host", @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$"},
            {"field_db_name", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            {"field_db_user", @"^[a-zA-Z][a-zA-Z0-9-_]{3,8}$"},
            {"field_db_password", @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})$"}

        };
        /// <summary>
        /// fieldNamePresenter - Dictionary<string, string> - содержит базовые текстовые конструкции для ошибок
        /// </summary>
        private static readonly Dictionary<string, string> fieldNamePresenter = new Dictionary<string, string>()
        {
            {"field_db_host", "Поле \"Хост базы данных\" содержит ошибки:\r\n"},
            {"field_db_name", "Поле \"Имя базы данных\" содержит ошибки:\r\n"},
            {"field_db_user", "Поле \"Имя пользователя базы данных\" содержит ошибки:\r\n"},
            {"field_db_password", "Поле \"Пароль\" содержит ошибки:\r\n"}
        };
        /// <summary>
        /// Божественный валидатор полей TextBox
        /// </summary>
        /// <param name="fieldName">String - имя поля</param>
        /// <param name="fieldText">String - текст поля</param>
        /// <param name="errors"> Dictionary<string, string> - словарь ошибок</param>
        /// <returns>Возвращает Dictionary <string, Array> errors, где первый элемент - Name поля, а второй -
        ///  массив из заготовки сообщения и ошибки</returns>
        /// 
        public static Dictionary<string, Dictionary<string, string>> ValidateField(string fieldName, string fieldText,
            Dictionary<string, Dictionary<string, string>> errors) 
        {
            if (fieldText.Equals(""))
            {
                errors.Add(fieldName, new Dictionary<string, string>()
                {
                    {fieldNamePresenter[fieldName], "Пустое поле"}
                });
                return errors;
            }
            if (!FindOfPattern(fieldName, fieldText))
            {
                errors.Add(fieldName, new Dictionary<string, string>()
                {
                    {fieldNamePresenter[fieldName], "Поле содержит запрещенные символы или не имеет необходимой длины"}
                });
            }
            return errors;
        }

        /// <summary>
        /// FindOfPattern - поиск вхождений по паттернам
        /// </summary>
        /// <param name="fieldName">String, содержит имя поля</param>
        /// <param name="fieldText">String, содержит текст поля для проверки</param>
        /// <returns></returns>
        private static bool FindOfPattern(string fieldName, string fieldText)
        {
            Regex regularExpression = new Regex(patterns[fieldName]);
            MatchCollection matches = regularExpression.Matches(fieldText);
            foreach (Match m in matches)
            {
                if (m.Success)
                    return true;
                return false;
            }
            return false;
        }
    }
}
