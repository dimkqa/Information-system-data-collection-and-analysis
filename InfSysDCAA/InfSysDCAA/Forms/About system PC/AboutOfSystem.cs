using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Collecting_information.System;

namespace InfSysDCAA.Forms.About_system_PC
{
    public partial class AboutOfSystem : Form
    {
        public AboutOfSystem()
        {
            InitializeComponent();
            PrintSystemInfo();
        }

        private void PrintSystemInfo()
        {
            foreach (KeyValuePair<string, string> kvp in CollectSystemInfo.ForAboutComputerInformation)
            {
                string key = Convert.ToString(kvp.Key);
                string param = Convert.ToString(kvp.Value);
                textBox1.Text += key + param + Environment.NewLine;
            }
        }
    }
}
