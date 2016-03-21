using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core;
using InfSysDCAA.Core.Validation;

namespace InfSysDCAA.Forms.Settings
{
    public partial class SetingsApps : Form
    {
        private const int Width = (int)350;    //Максимальная ширина окна
        private const int Height = (int)250;   //Максимальная высота окна

        public SetingsApps()
        {
            InitializeComponent();
            Text = Convert.ToString("Параметры соединения с БД");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);
        }

        /// <summary>
        /// Сохраняем настрйоки - проводим валидацию полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_settings_connect_Click(object sender, EventArgs e)
        {
            List<TextBox> fields = new List<TextBox>()
            {
                field_db_host, field_db_name, field_db_user, field_db_password
            };

            //Содержит Name поля ошибки (для очистки), нормальное описание поля, ошибку.
            Dictionary<string, Dictionary<string, string>> errors = new Dictionary<string, Dictionary<string, string>>();

            foreach (var field in fields)
            {
                errors = Validation.ValidateField(field.Name, field.Text, errors);
            }

            if (errors.Count > 0)
            {
                string messageError = "";
                foreach (KeyValuePair<string, Dictionary<string, string>> err in errors)
                {
                    foreach (var field in fields)
                    {
                        if (field.Name == err.Key)
                        {
                            field.Clear();
                        }
                    }
                    //re
                    foreach (KeyValuePair<string, string> errMsg in err.Value)
                    {
                        messageError += errMsg.Key + " " + errMsg.Value + "\r\n";
                    }
                }
                MessageBox.Show(messageError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* else
             {
                 foreach (var field in fields)
                 {
                     SaveSettingsFunctions.SaveDataSettings(field.Name, field.Text);
                 }
             }*/
        }
        private void btn_test_connect_Click(object sender, EventArgs e)
        {

        }
    }
}
