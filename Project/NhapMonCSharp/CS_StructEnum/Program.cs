using System;

namespace CS_StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Product  productA = new Product();
            productA.name = "Iphone";
            productA.price = 1000;

            Product productB = productA; // gán struct, là sao chép giá trị chứ không tham chiếu như lớp
            productB.name = "Laptop";

            Console.WriteLine(productA.ToString());
            Console.WriteLine(productB.ToString());
            // In ra:
            // Iphone : 1000$
            // Laptop : 1000$

            int a = (int)HocLuc.Kha;  // cast enum thành int
            Console.WriteLine(a);

            test_enum();

            HocLuc hoc = (HocLuc)2;
            Console.WriteLine(hoc); //Kha

            HocLuc hocluc_hocsinhA = HocLuc.Kha;
            int hocluc_hocsinhB = 2;

            System.Console.WriteLine(hocluc_hocsinhA);
            System.Console.WriteLine(hocluc_hocsinhB);
        }

        static void test_enum () 
        {
            HocLuc hocluc = HocLuc.Kha; // khai báo biến hocluc kiểu enum và khởi tạo giá trị bằng HocLuc.Kha
            switch (hocluc) {
                case HocLuc.Kem:
                    Console.WriteLine ("Học lực kém");
                    break;
                case HocLuc.Kha:
                    Console.WriteLine ("Học lực Kha");
                    break;
                case HocLuc.Gioi:
                    Console.WriteLine ("Học lực Giỏi");
                    break;
                default:
                    Console.WriteLine ("Học lực TB");
                    break;

            }
        }
    }
}
