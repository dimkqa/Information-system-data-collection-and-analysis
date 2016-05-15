using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Core.Directory
{
    public static class DirectoryChanger
    {
        private static Dictionary<string, string> SavingData = new Dictionary<string, string>()
        {
            //{"path_doc_reports",}
        };

        public static void ChangeReportsPathMessage(string selectedPath)
        {
            MessageBox.Show("Директория для сохранения отётов изменена на " + selectedPath +
                    ". \n После нажатия на кнопку \"ОК\" программа перезапустится",
                    "Изменение директории отчётов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ChangeReportsPath(Path.GetFullPath(selectedPath));
        }

        private static void ChangeReportsPath(string newPath)
        {
            Properties.Application_data.user.Default.path_doc_reports = newPath;
            Properties.Application_data.user.Default.Save();
        }
    }
}
