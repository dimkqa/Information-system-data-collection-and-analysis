namespace InfSysDCAA.Core.Validation
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class ValidationFieldTextBox
    {
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
                string messageError = "";
                foreach (KeyValuePair<string, string[,]> err in errors)
                {
                    foreach (var field in fields)
                    {
                        if (field.Name == err.Key)
                        {
                            field.Clear();
                        }
                    }
                    foreach (string errMsg in err.Value)
                    {
                        messageError += errMsg;
                    }
                }
                MessageBox.Show(messageError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
