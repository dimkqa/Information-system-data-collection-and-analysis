using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InfSysDCAA.Classes.Files
{

    public class operationsWithXML : workWithFiles
    {
        private string _pathFile;
        private string _nameFile;
        /// <summary>
        /// Придумать универсальный способ обхода и создания ХМЛ файла.
        /// Заходим в корень.
        /// Максимум может быть 
        /// </summary>
 
        public override string pathFile
        {
            get { return _pathFile; }
            set { _pathFile = value; }
        }

        public override string nameFile
        {
            get { return _nameFile; }
            set { _nameFile = value; }
        }

        protected override string fullPath
        {
            get { return Path.Combine(_pathFile + @"\" + nameFile); }
        }

        private FolderOperations _FO;

        /// <summary>
        /// В конструктор передаётся полный путь до файла. 
        /// </summary>
        /// <param name="path">String - Путь до XML файла</param>
        public operationsWithXML(string path, string name)
        {
            pathFile = path;
            nameFile = name;
        }

        /// <summary>
        /// Создаёт или открывает файл по заданной 
        /// </summary>
        /// <returns></returns>
        public override int CreateFile()
        {
            if (!Directory.Exists(pathFile))
            {
                _FO = new FolderOperations(pathFile);
                _FO.CreateFolderInPath();
            }
            else
            {
                //Полный путь до файла, включая сам файл
                FileInfo fileInfo = new FileInfo(fullPath);
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
            if (!File.Exists(fullPath))
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
