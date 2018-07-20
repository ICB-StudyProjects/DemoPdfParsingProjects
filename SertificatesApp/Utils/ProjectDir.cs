namespace SertificatesApp.Utils
{
    using System;
    using System.IO;

    public static class ProjectDir
    {
        static ProjectDir()
        {
            Root = FindRootDir();
        }

        public static string Root { get; private set; }

        private static string FindRootDir()
        {
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            FileInfo fileInfo = new FileInfo(currentDir);

            return fileInfo.Directory.Parent.Parent.FullName;
        }
    }
}
