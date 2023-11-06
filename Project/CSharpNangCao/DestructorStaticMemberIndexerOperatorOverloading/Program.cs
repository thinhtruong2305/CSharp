using System;

namespace DestructorStaticMemberIndexerOperatorOverloading
{
    class Program
    {
        static void TestHamHuy() {
            HamHuy p = new HamHuy("ABC");  // Tạo đối tượng, biến p tham chiếu đến đối tượng
            p = null;
            // Biến p gán bằng null, đối tượng tạo ra phía trên,
            // không còn biến nào tham chiếu đến => Nó được đánh dấu
            // sẽ bị thu hồi bởi GC, lúc nào GC chạy do NET quyết định
        }

        static void Main(string[] args)
        {
            TestHamHuy();
            // Ép  hệ thống thu hồi bộ nhớ (thực tế không cần ép, nó sẽ tự chạy khi cần)
            GC.Collect();

            //Overloading Operator
            MyVector v1 = new MyVector(2,3);
            MyVector v2 = new MyVector(3,4);

            MyVector v3 = v1 + v2;
            v3.ShowXY();

            //Static member
            StaticMember c1 = new StaticMember();
            StaticMember c2 = new StaticMember();

            c1.count();     // CountNumber.num = 1;
            c2.count();     // CountNumber.num = 2;
            c1.count();     // CountNumber.num = 3;
            c2.getNum();    // trả ve 3

            StaticMember.Sum(1,2); // tra về 3 - gọi phương thức mà không cần tạo đối tượng

            //Readonly
            Student s = new Student("Abc");     // khởi tạo biến readonly trong hàm tạo
            string n = s.name;                  // đọc biển readonly
            //s.name = "AA";                    // lỗi - vì không thể gán - chỉ có thể đọc

            //Indexer
            Indexer obj = new Indexer();

            Console.WriteLine(obj[0] + " " + obj[1]);      // đọc obj.ho và obj.ten
            obj[0] = "Đinh";                               // gán obj.ho
            obj[1] = "Quang Hưng";                         // gán obj.name
            Console.WriteLine(obj[0] + " " + obj[1]);      // đọc obj.ho và obj.ten


            // Kết quả chạy:
            // Nguyễn Nam
            // Đinh Quang Hưng
        }
    }
}
