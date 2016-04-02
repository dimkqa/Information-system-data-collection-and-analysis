using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InfSysDCAA.Core.Validation;
using InfSysDCAA.Core.XML.Devices;

namespace InfSysDCAA.Forms.Device.Add_or_Edit
{
    public partial class DeviceStepOne : Form
    {
        private const int Width = (int)706;    //Максимальная ширина окна
        private const int Height = (int)242;   //Максимальная высота окна

        private DeviceStepOne currentForm;

        public DeviceStepOne()
        {
            InitializeComponent();

            Text = Convert.ToString("Добавление нового устройства: Шаг 1 - информация об устройстве");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);

            currentForm = this;
        }

        private void button_save_deviceInfo_Click(object sender, EventArgs e)
        {
            //Если все поля верны - пишем в файл. Сохранять бессмысленно.
            if (ValidationField.ValidationFields(getAllTextBoxFields()))
            {
                ///XmlFileCreatorDeviceInfoPart1 dataPar1 = new XmlFileCreatorDeviceInfoPart1();
                /*currentForm.Close();
                FormChecker.ControlOpenedForm(typeof (DeviceStepTwo));
            */}
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
                    }
                }
            }
            return fields;
        }



        /// <summary>
        /// Очистка всех полей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_deviceInfo_Click(object sender, EventArgs e)
        {
            foreach (Control field in Controls)
            {
                if(field.GetType() == typeof(GroupBox))
                    foreach (Control fieldTextBox in field.Controls)
                    {
                        if (fieldTextBox.GetType() == typeof(TextBox))
                        {
                            fieldTextBox.Text = string.Empty;
                        }
                    }
            }
        }
    }
}
