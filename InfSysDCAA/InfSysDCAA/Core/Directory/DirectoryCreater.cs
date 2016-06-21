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
    /// Создатель директорий
    /// </summary>
    public static class DirectoryCreater
    {
        /// <summary>
        /// Текущее имя пользователя
        /// </summary>
        /// 
        private static string _currentUserName;
        /// <summary>
        /// Текущий системный диск
        /// </summary>
        private static string _currentSystemDisk;

        /// <summary>
        /// Лист директорий по умолчанию
        /// </summary>
        private static List<string> defaultPath = new List<string>();

        /// <summary>
        /// Свойство - Текущее имя пользователя
        /// </summary>
        private static string CurrentUserName
        {
            get { return _currentUserName; }
            set { _currentUserName = value; }
        }

        /// <summary>
        /// Свойство - Текущий системный диск (буква)
        /// </summary>
        private static string CurrentSystemDisk
        {
            get { return _currentSystemDisk; }
            set { _currentSystemDisk = value; }
        }

        /// <summary>
        /// Получаем текущие пути по умолчанию вида
        /// \\Documents\\InfSysDCAA\\Raw Files
        /// </summary>
        static DirectoryCreater()
        {
            defaultPath.Add(Properties.Application_data.user.Default.path_doc_reports);
            defaultPath.Add(Properties.Application_data.user.Default.path_doc_config);
            defaultPath.Add(Properties.Application_data.user.Default.path_doc_raw_files);
        }

        /// <summary>
        /// Поулчить путь до директории с отчётами
        /// </summary>
        /// <returns></returns>
        public static string GetReportsFolderPath()
        {
            return defaultPath[0];
        }

        /// <summary>
        /// Анализ путей. Смотрим на конец пути. 
        /// Пример: \\Documents\\InfSysDCAA\\Raw Files
        /// Если он изменен, значит весь путь изменен, 
        /// можно записывать новый путь.
        /// </summary>
        /// <param name="SystemDisk">Буква системного диска</param>
        /// <param name="UserName">Имя пользователя</param>
        public static void PathsAnalyser(string SystemDisk, string UserName)
        {
            DirectoryList.CurrentUserName = UserName;
            DirectoryList.CurrentSystemDisk = SystemDisk;
            DirectoryList.CreateDirectoryList();

            for (int i = 0; i < DirectoryList.GetCountDirectory(); i++)
            {
                if (defaultPath[i] != DirectoryList.PartPath[i])
                {
                    CreatePath(defaultPath[i]);
                }
                else
                {
                    CreatePath(DirectoryList.DefaultPathList[i]);
                }
            }

        }

        /// <summary>
        /// Создание новой директории
        /// </summary>
        /// <param name="path">string - Путь до директории</param>
        private static void CreatePath(string path)
        {
            try
            {
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
