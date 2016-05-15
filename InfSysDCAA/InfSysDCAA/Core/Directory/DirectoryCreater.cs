using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Directory
{
    public static class DirectoryCreater
    {
        private static string _currentUserName;
        private static string _currentSystemDisk;
        private static List<string> defaultPath = new List<string>();
        private static string CurrentUserName
        {
            get { return _currentUserName; }
            set { _currentUserName = value; }
        }

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
            }

        }

        /// <summary>
        /// Создание новой директории
        /// </summary>
        /// <param name="path">string - Путь до директории</param>
        private static void CreatePath(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
        }
    }
}
