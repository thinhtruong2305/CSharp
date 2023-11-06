using System;
using System.IO;
using System.Text;

namespace CS_FileStream
{
    public static class FileGlobal
    {
        public static void GetFileInfomation(string filepath){
            using (var stream = new FileStream( path:filepath, mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.Read))
            {
                Console.WriteLine(stream.Name);
                Console.WriteLine($"Kích thước stream {stream.Length} bytes / Vị trí {stream.Position}");
                Console.WriteLine($"Stream có thể : Đọc {stream.CanRead} -  Ghi {stream.CanWrite} - Seek {stream.CanSeek} - Timeout {stream.CanTimeout} ");
            }
        }

        public static Encoding GetEncoding (Stream stream) {
            byte[] BOMBytes = new byte[4]; // mảng chứa 4 byte để làm bộ nhớ lưu byte đọc được
            int offset = 0; // vị trí (index) trong buffer - nơi ghi byte đầu tiên đọc được
            int count = 4; // đọc 4 byte
            int numberbyte = stream.Read (BOMBytes, offset, count); // bắt đầu đọc 4 đầu tiên lưu vào buffer

            // Di chuyển về vị trí bắt đầu của dữ liệu (đã trừ BOM)
            if (BOMBytes[0] == 0xfe && BOMBytes[1] == 0xff) {
                stream.Seek (2, SeekOrigin.Begin); 
                return Encoding.BigEndianUnicode;
            }
            if (BOMBytes[0] == 0xff && BOMBytes[1] == 0xfe) {
                stream.Seek (2, SeekOrigin.Begin);
                return Encoding.Unicode;
            }

            if (BOMBytes[0] == 0xef && BOMBytes[1] == 0xbb && BOMBytes[2] == 0xbf) {
                stream.Seek (3, SeekOrigin.Begin);
                return Encoding.UTF8;
            }
            if (BOMBytes[0] == 0x2b && BOMBytes[1] == 0x2f && BOMBytes[2] == 0x76) {
                stream.Seek (3, SeekOrigin.Begin);
                return Encoding.UTF7;
            }
            if (BOMBytes[0] == 0xff && BOMBytes[1] == 0xfe && BOMBytes[2] == 0 && BOMBytes[3] == 0) {
                stream.Seek (4, SeekOrigin.Begin);
                return Encoding.UTF32;
            }
            if (BOMBytes[0] == 0 && BOMBytes[1] == 0 && BOMBytes[2] == 0xfe && BOMBytes[3] == 0xff) {
                stream.Seek (4, SeekOrigin.Begin);
                return Encoding.GetEncoding (12001);
            }

            stream.Seek (0, SeekOrigin.Begin);
            return Encoding.Default;
        }

        public static void WriteContentByStream(string filepath){
            using (var stream = new FileStream( path:filepath, mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None))
            {
                //Write BOM - UTF8
                Encoding encoding = Encoding.UTF8;
                byte[] bom = encoding.GetPreamble();
                stream.Write(bom, 0, bom.Length);

                string s1 = "Xuanthulab.net -  Xin chào các bạn! \n";
                string s2 = "Ví dụ - ghi file text bằng stream";

                // Encode chuỗi - lưu vào mảng bytes
                byte[] buffer = encoding.GetBytes(s1);
                stream.Write(buffer, 0, buffer.Length);  // lưu vào stream

                buffer = encoding.GetBytes(s2);
                stream.Write(buffer, 0, buffer.Length);  // lưu vào stream
            }
        }

        public static void ReadContentByStream(string filepath){
            int SIZEBUFFER = 256;
            using (var stream = new FileStream( path:filepath, mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.Read))
            {
                Encoding encoding = GetEncoding(stream);
                Console.WriteLine(encoding.ToString());
                byte[] buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endread = true;
                    if (numberRead < SIZEBUFFER)
                    {
                        Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
                    }
                    string s = encoding.GetString(buffer, 0, numberRead);
                    Console.WriteLine(s);
                } while (!endread);
            }
        }

        public static void CopyByStream(string filepath_des, string filepath_src){
            int SIZEBUFFER = 5;   // tăng lên đọc sẽ nhanh
            using (var streamwrite = File.OpenWrite(filepath_des))
            using (var streamread = File.OpenRead(filepath_src))
            {
                byte[] buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numberRead = streamread.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endread = true;
                    else {
                        streamwrite.Write(buffer, 0, numberRead);
                    }
                } while (!endread);

            }
        }
    }
}