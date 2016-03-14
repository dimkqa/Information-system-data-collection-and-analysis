using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InfSysDCAA.Classes.Files
{
    public abstract class workWithFiles
    {
        public abstract string pathFile { get; set; }
        public abstract string nameFile { get; set; }
        /* public string pathFile
        {
            get { return _pathFile; }
            set { _pathFile = value; }
        }

        public string nameFile
        {
            get { return _nameFile; }
            set { _nameFile = value; }
        }*/

        protected abstract string fullPath { get; }

        /// <summary>
        /// FileInfo возврщает специфический объект
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public abstract bool FindFile();
        public abstract int CreateFile();
        //public abstract FileStream OpenFile();
        //public abstract FileInfo EditFile(string path);
        //public abstract FileInfo DelteFile(string path);
        //public abstract FileInfo FindFile(string path);
        //public abstract BinaryReader BinaryCreateFile();
    }
}
