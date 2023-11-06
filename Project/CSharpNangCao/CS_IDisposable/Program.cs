using System;

namespace CS_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WriteData writeData = new WriteData("filename.txt")) {
                // do something
                writeData.Dispose();
            }
        }
    }
}
