using System;

namespace DestructorStaticMemberIndexerOperatorOverloading
{
    class Indexer
    {
        string ho = "Nguyễn";
        string ten = "Nam";

        // Bộ chỉ mục số nguyên, chỉ mục là 0 hoặc 1 nếu khác sẽ phát sinh Exception
        public string this[int index]
        {
            // Đọc dữ liệu theo chỉ mục
            get {
                if (index == 0) return ho;
                else if (index == 1) return ten;
                else throw new Exception("Chỉ số không tồn tại");
            }

            // Gán dữ liệu theo chỉ mục
            set {
                if (index == 0)  ho = value;
                else if (index == 1) ten = value;
                else throw new Exception("Chỉ số không tồn tại");
            }
        }   
    }
}