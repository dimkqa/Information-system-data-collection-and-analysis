using InfSysDCAA.Core.Validation;

namespace InfSysDCAA.Forms.DataBase.AddEditDeviceForms
{
    using System;
    using System.Windows.Forms;
    public partial class DeviceStepOne : Form
    {
        private const int Width = (int)706;    //Максимальная ширина окна
        private const int Height = (int)300;   //Максимальная высота окна

        private DeviceStepOne open;

        public DeviceStepOne()
        {
            InitializeComponent();
            Text = Convert.ToString("Добавление нового устройства: Шаг 1");
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(Width, Height);
            open = this;
        }

        private void button_save_deviceInfo_Click(object sender, EventArgs e)
        {
            open.Close();
            FormChecker.ControlOpenedForm(typeof(DeviceStepTwo));
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
                        if (fieldTextBox.GetType() == typeof(TextBox) ||
                            fieldTextBox.GetType() == typeof(MaskedTextBox) ||
                            fieldTextBox.GetType() == typeof(RichTextBox))
                        {
                            fieldTextBox.Text = string.Empty;
                        }
                    }
            }
        }
    }
}
