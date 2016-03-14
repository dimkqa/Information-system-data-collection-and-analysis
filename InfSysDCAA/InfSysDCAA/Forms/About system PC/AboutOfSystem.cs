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
using InfSysDCAA.Classes.Collecting_information.System_information;

namespace InfSysDCAA.Forms.About_system_PC
{
    public partial class AboutOfSystem : Form
    {
        public AboutOfSystem()
        {

            InitializeComponent();
            foreach (KeyValuePair<string, string> kvp in collect_system_info.ForAboutComputerInformation)
            {
                string key = Convert.ToString(kvp.Key);
                string param = Convert.ToString(kvp.Value);
                textBox1.Text += key + param + Environment.NewLine;
            }
        }
    }
}
