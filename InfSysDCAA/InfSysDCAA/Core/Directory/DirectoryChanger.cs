using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Core.Directory
{
    /// <summary>
    /// Обработка изменения директории
    /// </summary>
    public static class DirectoryChanger
    {
        /// <summary>
        /// Сохраняемый словарь
        /// </summary>
        private static Dictionary<string, string> SavingData = new Dictionary<string, string>()
        {
            //{"path_doc_reports",}
        };

        /// <summary>
        /// Сообщение об изменении директории
        /// </summary>
        /// <param name="selectedPath"></param>
        public static void ChangeReportsPathMessage(string selectedPath)
        {
            MessageBox.Show("Директория для сохранения отётов изменена на " + selectedPath +
                    ". \n После нажатия на кнопку \"ОК\" программа перезапустится",
                    "Изменение директории отчётов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ChangeReportsPath(Path.GetFullPath(selectedPath));
        }

        /// <summary>
        /// Сохранение пути до директории
        /// </summary>
        /// <param name="newPath"></param>
        private static void ChangeReportsPath(string newPath)
        {
            Properties.Application_data.user.Default.path_doc_reports = newPath;
            Properties.Application_data.user.Default.Save();
        }
    }
}
