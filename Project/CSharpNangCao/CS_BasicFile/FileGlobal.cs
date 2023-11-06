using System;
using System.IO;

namespace CS_BasicFile
{
    public static class FileGlobal
    {
        //Dùng để ghi đè nội dung file không nối thêm
        public static  void testWriteAllText () {
            var filename = "test.txt";
            string contentfile = "Xin chào! xuanthulab.net";

            // Lấy thư mục Document của User trên hệ thống
            var directory_mydoc = Environment.CurrentDirectory.ToString();

            var fullpath = Path.Combine(directory_mydoc, filename);
            File.WriteAllText (filename, contentfile);

            Console.WriteLine ($"File lưu tại {directory_mydoc}{Path.DirectorySeparatorChar}{filename}");

        }

        //Dùng để ghi đè nội dung file có nối thêm
        public static void testAppendAllText() {
            var filename = "test.txt";
            string contentfile = "\nXin chào! xuanthulab.net - " + DateTime.Now.ToString ();

            var directory_mydoc = Environment.CurrentDirectory.ToString();
            var fullpath = Path.Combine (directory_mydoc, filename);

            if (File.Exists (fullpath)) {
                // File đã tồn tại - nối thêm nội dung
                File.AppendAllText (fullpath, contentfile);
            } else {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText (fullpath, contentfile);
            }
            // Đọc nội dung File
            Console.WriteLine (fullpath);
            string s = File.ReadAllText (fullpath);
            Console.WriteLine (s);
        }

        //đệ quy liệt kê tất cả các file, thư mục con trong một thư mục
        public static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }
    }
}