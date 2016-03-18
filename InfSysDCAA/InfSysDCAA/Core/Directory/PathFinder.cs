using System.Collections.Generic;

namespace InfSysDCAA.Core.Directory
{
    public static class PathFinder
    {
        public static readonly List<string> AllPath = new List<string>();

        public static void CreateAllPath()
        {
            foreach (string path in AllPath)
            {
                FolderOperations f = new FolderOperations(path);
                f.CreateFolderInPath();
            }
        }
    }
}
