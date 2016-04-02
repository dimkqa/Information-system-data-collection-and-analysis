using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.XML
{
    public class XmlClassPath
    {
        private List<string> XmlListPath;

        public XmlClassPath(string UserName)
        {
            List<string> AllPath = new List<string>()
            {
                {@"C:\Users\" + UserName + @"\Documents\InfSysDCAA\Config"},
            };
        }
    }
}
