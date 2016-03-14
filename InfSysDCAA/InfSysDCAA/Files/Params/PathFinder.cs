using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Classes.Files;

namespace InfSysDCAA.Files.Params
{
    public static class PathFinder
    {
        public static readonly List<string> AllPath = new List<string>();

        public static void CreateAllPath()
        {
            foreach (string Path in AllPath)
            {
                FolderOperations f = new FolderOperations(Path);
                f.CreateFolderInPath();
            }
        }
    }
}
