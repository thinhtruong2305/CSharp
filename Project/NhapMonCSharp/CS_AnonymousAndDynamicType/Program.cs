using System;
using System.Collections.Generic;
using System.Linq;
using CS_AnonymousAndDynamicType;

namespace CS_AnonymousAndDynamicType
{
    class Program
    {
        //Biến kiểu động - ngầm định - khai báo với từ khóa dynamic, 
        //thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy
        public static void Print(dynamic obj){
            obj.Hello();
        }

        //Anonymous type - kiểu dữ liệu vô danh
        //Object - thuộc tính chỉ đọc
        //Cú pháp: new{thuộc tính 1 = giá trị 1, thuộc tính 2 = giá trị 2}
        static void Main(string[] args)
        {
            var myProfile = new {
                name  = "Tiến Thịnh",
                age   = 21,
                skill = "ABC"
            };

            System.Console.WriteLine(myProfile.name);

            List<SinhVien> cacSinhVien = new List<SinhVien>(){
                new SinhVien(){HoTen = "Nam", NamSinh = 2003, NoiSinh = "Binh Duong"},
                new SinhVien(){HoTen = "Ninh", NamSinh = 2005, NoiSinh = "Hai Duong"},
                new SinhVien(){HoTen = "Nênh", NamSinh = 2009, NoiSinh = "Binh Dinh"},
                new SinhVien(){HoTen = "lênh", NamSinh = 2007, NoiSinh = "Ho Chi Minh"},
                new SinhVien(){HoTen = "Lam", NamSinh = 2002, NoiSinh = "Ha Noi"}
            };

            var ketQua = from sv in cacSinhVien
                         where sv.NamSinh <= 2005
                         select new{
                            Ten = sv.HoTen,
                            NS = sv.NamSinh
                         };

            foreach(var sv in ketQua){
                System.Console.WriteLine(sv.Ten + " - " + sv.NS);
            }

            Print(new SinhVien(){HoTen = "Lan", NamSinh = 2004, NoiSinh = "Hai Phong"});
        }
    }
}
