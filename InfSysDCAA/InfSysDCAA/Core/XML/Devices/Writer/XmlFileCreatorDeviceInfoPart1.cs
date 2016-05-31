namespace InfSysDCAA.Core.XML.Devices.Writer
{/*
    using System.IO;
    using System.Xml.Linq;
    using InfSysDCAA.Core.Directory;
    
    public class XmlFileCreatorDeviceInfoPart1 : AbstractXmlClass
    {
        private string _pathFile;
        private string _nameFile;
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

        private string Root = "Devices";

        private FolderOperations _fo;

        /// <summary>
        /// В конструктор передаётся полный путь до файла. 
        /// </summary>
        /// <param name="path">String - Путь до XML файла</param>
        public XmlFileCreatorDeviceInfoPart1(string path, string name)
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

        public override bool CreateStructureXmlFile(List<string> xmlFileStructureList)
        {
            XDocument document = new XDocument(
            new XElement(""));
            return true;
        }
    }*/
}