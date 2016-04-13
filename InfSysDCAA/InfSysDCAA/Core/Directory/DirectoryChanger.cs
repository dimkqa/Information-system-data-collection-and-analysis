using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Directory
{
    public static class DirectoryChanger
    {
        private static Dictionary<string, string> SavingData = new Dictionary<string, string>()
        {
            //{"path_doc_reports",}
        };

        public static void ChangePath(string newPath)
        {
            Properties.Application_data.user.Default.path_doc_reports = newPath;
            Properties.Application_data.user.Default.Save();
        }
    }
}
