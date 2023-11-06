using System;

namespace CS_BasicFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileGlobal.testWriteAllText();
            FileGlobal.testAppendAllText();
            var directory_mydoc = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
            FileGlobal.ListFileDirectory(directory_mydoc);
        }
    }
}
