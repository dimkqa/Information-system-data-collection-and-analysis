namespace InfSysDCAA.Core.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class ValidationField
    {
        /// <summary>
        /// Валидация TextBox'ов
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static bool ValidationFields(List<TextBox> fields)
        {
            //Содержит Name поля ошибки (для очистки), нормальное описание поля, ошибку.
            Dictionary<string, string[,]> errors = new Dictionary<string, string[,]>();

            foreach (var field in fields)
            {
                errors = Validation.ValidateField(field.Name, field.Text, errors);
            }

            if (errors.Count > 0)
            {
                List<string> messageErr = new List<string>();

                foreach (KeyValuePair<string, string[,]> err in errors)
                {
                    foreach (var field in fields)
                    {
                        if (field.Name == err.Key)
                        {
                            field.Clear();
                        }
                    }

                    //foreach (string errMsg in err.Value)
                    //{
                    //    //messageErr.Add(err.Value[0, 0] + err.Value[0, 1]);
                    //    messageErr.Add(errMsg[0] + errMsg[1]);
                    //}TODO: codereview
                    
                    for (int i = 0; i < err.Value.GetUpperBound(0)+1; i++)
                    {
                        messageErr.Add(err.Value[i,0] + err.Value[i,1]);                      
                    }
                }
                //Если ошибок больше чем 10, то выводим партиями.
                string messageError = "";

                if (messageErr.Count > 10)
                {
                    for (int i = 0; i < messageErr.Count; i++)
                    {   
                        messageError += messageErr[i];
                        if (i % 5 == 0)
                        {
                            MessageBox.Show(messageError, "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            messageError = String.Empty;
                        }
                    }
                    return false;
                }
                else
                {
                    for (int i = 0; i < messageErr.Count; i++)
                        messageError += messageErr[i];
                    MessageBox.Show(messageError, "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
