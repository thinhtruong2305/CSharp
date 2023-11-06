using System;

namespace CS_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo mảng
            //Khai báo biến mảng = khởi tạo new datatype[n] mảng với n phần tử
            int[] mangInt = new int[5];

            // mảng 3 phần tử chuỗi ký tự, mỗi phần tử được gán ngay giá trị chuỗi cụ thể
            string[] productNames = new string[3] {"Iphone", "Samsung", "Nokia"};
            // mảng 3 phần tử double, mỗi phần tử được gán giá trị luôn
            double[] productPrices = new double[3] {100, 200.5, 10.1};

            //Có thể không cần chỉ ra số lượng phần tử trong mảng
            string[] productNames1 = new string[] {"Iphone", "Samsung", "Nokia"};
            double[] productPrices1 = new double[] {100, 200.5, 10.1};

            //Có thể bỏ luôn new
            string[] productNames2 = {"Iphone", "Samsung", "Nokia"};
            double[] productPrices2 = {100, 200.5, 10.1};

            //truy cập phần tử mảng
            //Giá trị phần tử mảng tính từ 0 ... n - 1
            double a = productPrices[0];

            //Thuộc tính và phương thức mảng
            /*
            Length	Thuộc tính cho biết số lượng phần tử trong mảng
            Rank	Thuộc tính cho biết số chiều mảng
            Clone()	Copy (nhân bản) đối tượng mảng
            GetValue(index)	Lấy giá trị phần tử trong mảng

            Thêm thư viện System.Linq sẽ có mấy cái Min, Max, Sum
            Min()	Trả về giá trị nhỏ nhất trong mảng
            Max()	Trả về giá trị lớn nhất trong mảng
            Sum()	Trả về giá trị tổng cộng các phần tử

            Trong Array
            Array.BinarySearch(array, value)	Tìm kiếm phần tử trong mảng đã được sắp xếp, trả về chỉ số nếu tìm thấy
            CopyTo(array, indexStart)	Sao chép phần tử mảng này sang mảng khác
            Array.Clear(array, index, length)	Thiết lập phần tử mảng nhận giá trị mặc định
            bool Exists<T> (array, Predicate<T> match);	Kiểm tra có phần tử trong mảng thỏa mãn match
            Fill<T> (array, value);	Gán các phần tử của mảng bằng value
            T Find<T> (array, Predicate<T> match);	Tìm phần tử mảng
            int FindIndex<T> (array, Predicate<T> match);	Tìm phần tử mảng, trả về chỉ số nếu thấy
            T[] FindAll<T> (array, Predicate<T> match);	Tìm tất cả phần tử mảng
            int IndexOf(array, value)	Tìm chỉ số của phần tử
            ForEach(array, Action<T> action)	Thi hành action trên mỗi phần tử
            Sort(array)	Sắp xếp
            */

            //Duyệt phần tử trong mảng
            //Bằng for
            int[] myArray = {1,3,5,19, 10, 20, 40, 40};
            for (int idx = 0; idx < myArray.Length; idx ++) {
                Console.WriteLine(myArray[idx]);
            }

            //Bằng foreach
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }

            //Mảng đa chiều
            //Khai báo type[, , … ,] varname = new type[size1, size2, …, sizeN];
            int[,] myvar = new int[3,4];

            myvar[0,0] =  1;    // hàng 1, cột 1
            myvar[2,3] =  3;    // hàng 3, cột 4

            // khai báo và khởi tạo mảng 2 chiều
            int[,] myvar1 = new int[3,4] {{1,2,3,4}, {0,3,1,3}, {4,2,3,4}}; 

            for (int i = 0; i <= 2; i ++)     // duyệt qua từng hàng
            {
                for(int j = 0; j <=3; j++)    // duyệt qua từng cột
                {
                    Console.Write(myvar[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Mảng trong mảng
            int[][] myArray1 = new int[][] {
                                new int[] {1,2},
                                new int[] {2,5,6},
                                new int[] {2,3},
                                new int[] {2,3,4,5,5}
                               };
            
            //Duyệt phần tử mảng trong mảng
            foreach (var arr in myArray1) {
                foreach (var e in arr) {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
