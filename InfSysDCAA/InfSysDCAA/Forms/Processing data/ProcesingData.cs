namespace InfSysDCAA.Forms.Processing_data
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ProcessAnalyseData : Form
    {
        private const int Width = (int)150;
        private const int Height = (int)400;

        public ProcessAnalyseData()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);
            Text = Convert.ToString("Обработка данных");
        }


        private void button_cancel_analyse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Отменить обработку данных?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }
            else
            {

            }

        }

        private void cancel_analyse(object sender, EventArgs e)
        {

        }

    }
}
