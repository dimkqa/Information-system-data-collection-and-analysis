namespace InfSysDCAA.Core.Validation
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /* Божественный код
     * 
     */
    public static class Validation
    {
        /// <summary>
        /// Божественный валидатор полей TextBox
        /// </summary>
        /// <param name="fieldName">String - имя поля</param>
        /// <param name="fieldText">String - текст поля</param>
        /// <param name="errors"> Dictionary<string, string> - словарь ошибок</param>
        /// <returns>Возвращает Dictionary <string, Array> errors, где первый элемент - Name поля, а второй -
        ///  массив из заготовки сообщения и ошибки</returns>
        /// 
        public static Dictionary<string, string[,]> ValidateField(string fieldName, string fieldText,
            Dictionary<string, string [,]> errors) 
        {
            if (fieldText.Equals(""))
            {
                errors.Add(fieldName, new string [,]
                {
                    {FieldList.fieldNamePresenter[fieldName], "Пустое поле\n"}
                });
                return errors;
            }
            if (!FindOfPattern(fieldName, fieldText))
            {
                errors.Add(fieldName, new string [,]
                {
                    {FieldList.fieldNamePresenter[fieldName], "Поле содержит запрещенные символы или не имеет необходимой длины\n"}
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
            Regex regularExpression = new Regex(FieldList.patterns[fieldName]);
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
