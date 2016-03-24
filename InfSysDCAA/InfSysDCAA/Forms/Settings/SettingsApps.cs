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

        private List<TextBox> fields = new List<TextBox>();

        public SetingsApps()
        {
            InitializeComponent();
        
            Text = Convert.ToString("Параметры соединения с БД");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            fields.Add(field_db_host);
            fields.Add(field_db_name);
            fields.Add(field_db_user);
            fields.Add(field_db_password);
        }

        /// <summary>
        /// Сохраняем настрйоки - проводим валидацию полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_settings_connect_Click(object sender, EventArgs e)
        {
            //Сохранение настроек подключения
            if(!ValidationFieldTextBox.ValidationFields(fields))
            {
                 /*foreach (var field in fields)
                 {
                     SaveSettingsFunctions.SaveDataSettings(field.Name, field.Text);
                 }*/
             }
        }
        private void btn_test_connect_Click(object sender, EventArgs e)
        {
            //Тест соединения с БД
           /*if (!ValidationFieldTextBox.ValidationFields(fields))
            {
            }*/
        }
    }
}
