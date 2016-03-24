using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Forms.ProcessingData
{
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
            MessageBox.Show("Вы уверены?", "Отменить обработку данных?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void cancel_analyse(object sender, EventArgs e)
        {

        }

    }
}
