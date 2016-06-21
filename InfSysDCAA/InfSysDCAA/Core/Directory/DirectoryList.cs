using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Directory
{
    /// <summary>
    /// Управление списком директорий
    /// </summary>
    public static class DirectoryList
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        private static string _currentUserName;

        /// <summary>
        /// Текущая буква системного диска 
        /// </summary>
        private static string _currentSystemDisk;

        /// <summary>
        /// List содержит пути по умолчанию
        /// </summary>
        private static List<string> _defaultPath = new List<string>();

        /// <summary>
        /// Имя текущего пользователя
        /// </summary>
        public static string CurrentUserName
        {
            get { return _currentUserName; }
            set { _currentUserName = value; }
        }

        /// <summary>
        /// Буква системного диска
        /// </summary>
        public static string CurrentSystemDisk
        {
            get { return _currentSystemDisk; }
            set { _currentSystemDisk = value; }
        }

        /// <summary>
        /// List путей по умолчанию
        /// </summary>
        public static List<string> DefaultPathList
        {
            get { return _defaultPath; }
            set { _defaultPath = value; }
        }

        /// <summary>
        /// List содержит части путей
        /// </summary>
        public static List<string> PartPath
        {
            get { return _partPath; }
            set { _partPath = value; }
        }
        
        /// <summary>
        /// Поулчаем число директорий
        /// </summary>
        /// <returns>Int, число директорий</returns>
        public static int GetCountDirectory()
        {
            return _partPath.Count;
        }

        /// <summary>
        /// "Жлезобетонно забиваем" адреса директорий внезаивисимости от
        /// буквы диска и имени пользователя
        /// </summary>
        private static List<string> _partPath = new List<string>()
        {
            {@"\Documents\InfSysDCAA\Reports"},
            {@"\Documents\InfSysDCAA\Config"},
            {@"\Documents\InfSysDCAA\Raw Files"}
        }; 

        /// <summary>
        /// Создаём полный путь до директории
        /// </summary>
        public static void CreateDirectoryList()
        {
            for (int i = 0; i < _partPath.Count; i++)
                _defaultPath.Add(CurrentSystemDisk + "Users\\" + CurrentUserName + _partPath[i]);
        }
    }
}

