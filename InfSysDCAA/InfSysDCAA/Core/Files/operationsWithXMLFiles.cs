using System.IO;
using System.Xml.Linq;
using InfSysDCAA.Core.Directory;

namespace InfSysDCAA.Core.Files
{

    public class OperationsWithXml : WorkWithFiles
    {
        private string _pathFile;
        private string _nameFile;
        /// <summary>
        /// Придумать универсальный способ обхода и создания ХМЛ файла.
        /// Заходим в корень.
        /// Максимум может быть 
        /// </summary>
 
        public override string PathFile
        {
            get { return _pathFile; }
            set { _pathFile = value; }
        }

        public override string NameFile
        {
            get { return _nameFile; }
            set { _nameFile = value; }
        }

        protected override string FullPath
        {
            get { return Path.Combine(_pathFile + @"\" + NameFile); }
        }

        private FolderOperations _fo;

        /// <summary>
        /// В конструктор передаётся полный путь до файла. 
        /// </summary>
        /// <param name="path">String - Путь до XML файла</param>
        public OperationsWithXml(string path, string name)
        {
            PathFile = path;
            NameFile = name;
        }

        /// <summary>
        /// Создаёт или открывает файл по заданной 
        /// </summary>
        /// <returns></returns>
        public override int CreateFile()
        {
            if (!System.IO.Directory.Exists(PathFile))
            {
                _fo = new FolderOperations(PathFile);
                _fo.CreateFolderInPath();
            }
            else
            {
                //Полный путь до файла, включая сам файл
                FileInfo fileInfo = new FileInfo(FullPath);
                fileInfo.Create();
            }
            return 0;
        }

        /// <summary>
        /// Поиск файла в каталоге по полному пути.
        /// Если файл не найден - создать его, и вернуть что он там есть.
        /// Если найден - вернуть что файл найден.
        /// </summary>
        /// <returns></returns>
        public override bool FindFile()
        {
            if (!File.Exists(FullPath))
            {
                CreateFile();
                return true;
            }
            return true;
        }

        public void CreateXmlFileSettings()
        {
            XDocument document = new XDocument(
                new XElement(""));
        }
    }
}
