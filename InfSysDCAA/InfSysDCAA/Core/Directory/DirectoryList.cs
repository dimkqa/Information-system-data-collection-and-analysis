using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Directory
{
    public static class DirectoryList
    {
        private static string _currentUserName;
        private static string _currentSystemDisk;
        private static List<string> _defaultPath = new List<string>();

        public static string CurrentUserName
        {
            get { return _currentUserName; }
            set { _currentUserName = value; }
        }

        public static string CurrentSystemDisk
        {
            get { return _currentSystemDisk; }
            set { _currentSystemDisk = value; }
        }

        public static List<string> DefaultPathList
        {
            get { return _defaultPath; }
            set { _defaultPath = value; }
        }

        public static List<string> PartPath
        {
            get { return _partPath; }
            set { _partPath = value; }
        }

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

