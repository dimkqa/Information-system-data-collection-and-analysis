using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Directory
{
    public static class DirectoryControl
    {
        /// <summary>
        /// Запускает explorer.exe и открывает проводник на нужном пути
        /// </summary>
        /// <param name="path">Путь до папки</param>
        public static void OpenDirectoryOnExplorer(string path)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", path));
        }
    }
}
