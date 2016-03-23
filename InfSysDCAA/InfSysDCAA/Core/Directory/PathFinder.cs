using System;
using System.Collections.Generic;

namespace InfSysDCAA.Core.Directory
{
    public static class PathFinder
    {
        private static string _currentUserName;

        public static string CurrentUserName
        {
            get { return _currentUserName; }
            set { _currentUserName = value; }
        }

        public static void CreateAllPath(string EnviromentUserName)
        {
            CurrentUserName = EnviromentUserName.ToString();
            List<string> AllPath = new List<string>()
            {
                {@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Config"},
                {@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Reports"},
                {@"C:\Users\" + CurrentUserName + @"\Documents\InfSysDCAA\Raw Files"}
            };
 
            foreach (string path in AllPath)
            {
                FolderOperations f = new FolderOperations(path);
                f.CreateFolderInPath();
            }
        }
    }
}
