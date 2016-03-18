namespace InfSysDCAA.Core.Files
{
    public abstract class WorkWithFiles
    {
        public abstract string PathFile { get; set; }
        public abstract string NameFile { get; set; }
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

        protected abstract string FullPath { get; }

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
