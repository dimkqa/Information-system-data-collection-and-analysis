using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.XML
{
    using System;
    using System.Xml.Linq;
    public abstract class AbstractXmlClass
    {
        public abstract string PathFile { get; set; }
        public abstract string NameFile { get; set; }

        protected abstract string FullPath { get; }

        public abstract bool FindFile();
        public abstract int CreateFile();
        public abstract bool CreateStructureXmlFile(List<string> xmlFileStructureList);

        //public abstract FileInfo OpenFile();
    }
}
