using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Classes.Files
{
    /// <summary>
    /// Класс содержит методы для работы с папками:
    /// Создание каталога - CreataFolderInPath();
    /// В конструктор класса должна приходить условная строка - @"<path>"! 
    /// </summary>
    public class FolderOperations
    {
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _path;

        public FolderOperations(string path)
        {
            this.path = path;
        }
        /// <summary>
        /// Метод создаёт директорию по указанному пути (путь передаётся в конструктор
        /// при создании экзмепляра данного класса).
        /// Если искомая директория не существует, то сдаём её.
        /// </summary>
        public void CreateFolderInPath()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
