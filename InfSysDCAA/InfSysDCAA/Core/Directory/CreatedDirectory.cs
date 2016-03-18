namespace InfSysDCAA.Core.Directory
{
    /// <summary>
    /// Класс содержит методы для работы с папками:
    /// Создание каталога - CreataFolderInPath();
    /// В конструктор класса должна приходить условная строка - @"<path>"! 
    /// </summary>
    public class FolderOperations
    {
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _path;

        public FolderOperations(string path)
        {
            this.Path = path;
        }
        /// <summary>
        /// Метод создаёт директорию по указанному пути (путь передаётся в конструктор
        /// при создании экзмепляра данного класса).
        /// Если искомая директория не существует, то сдаём её.
        /// </summary>
        public void CreateFolderInPath()
        {
            if (!System.IO.Directory.Exists(Path))
            {
                System.IO.Directory.CreateDirectory(Path);
            }
        }
    }
}
