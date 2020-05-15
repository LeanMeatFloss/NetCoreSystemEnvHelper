using System;
using System.IO;
using System.Reflection;

namespace NetCoreSystemEnvHelper
{
    public static class FileSysHelper
    {
        public static string GetAppHome ()
        {
            return GetHome (Assembly.GetEntryAssembly ().GetName ().Name);
        }
        public static string GetHome (string relativePath)
        {
            string rootPath = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
            string path = rootPath + @"\" + relativePath;
            if (!Directory.Exists (path))
            {
                Directory.CreateDirectory (path);
            }
            return path;
        }
        public static void SaveFileToPath (string fileName, string path, string saveStr)
        {
            File.WriteAllText (path + @"\" + fileName, saveStr);
        }
        public static string GetCurrentAppLocationPath ()
        {
            return Path.GetDirectoryName (Assembly.GetEntryAssembly ().Location);
        }

    }
}