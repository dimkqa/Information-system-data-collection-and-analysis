using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InfSysDCAA.Core.Validation;

namespace InfSysDCAA.Forms.Device.Add_or_Edit
{
    public partial class DeviceStepTwo : Form
    {
        private const int Width = (int)832;
        private const int Height = (int)367;

        public DeviceStepTwo()
        {
            InitializeComponent();

            Text = Convert.ToString("Добавление нового устройства: Шаг 2 - стандартные значения параметров");
            StartPosition = FormStartPosition.CenterScreen;

            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);
        }

        /// <summary>
        /// Получает все TextBox'ы формы
        /// </summary>
        /// <returns></returns>
        private List<TextBox> getAllTextBoxFields()
        {
            List<TextBox> fields = new List<TextBox>();

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                {
                    foreach (Control txtbox in c.Controls)
                    {
                        if (txtbox.GetType() == typeof(TextBox))
                        {
                            TextBox textboxField = (TextBox)txtbox;
                            fields.Add(textboxField);
                        }
                        else if (txtbox.GetType() == typeof (GroupBox))
                        {
                            foreach (Control txtbox2 in txtbox.Controls)
                            {
                                if (txtbox2.GetType() == typeof(TextBox))
                                {
                                    TextBox textboxField = (TextBox)txtbox2;
                                    fields.Add(textboxField);
                                }
                            }
                        }
                    }
                }
            }
            return fields;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Если все поля верны - пишем в файл.
            if (ValidationField.ValidationFields(getAllTextBoxFields()))
            {
                this.Close();
            }
        }
    }
}
