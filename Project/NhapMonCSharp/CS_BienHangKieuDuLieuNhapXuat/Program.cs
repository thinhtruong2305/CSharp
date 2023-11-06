using System;

namespace CS_BienHangKieuDuLieuNhapXuat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Khai báo biến:
                Kiểu dữ liệu + tên biến;
                    Lưu ý khi đặt tên biến:
                    - a...z A...Z
                    - 0...9
                    - _
                    - Không bắt đầu bằng số
                    - Chữ cái đầu có thể viết thường tùy nơi làm việc
            */
            string studentName0909;
            int _student_Age;
            _student_Age = 22;
            string address = "Hà Nội, Hồ Chí Minh";
            /*
                Các từ khóa
                abstract    as	        base	    bool        break	byte	    case
                catch	    char        checked	    class       const	continue    decimal
                default	    delegate	do          double      else	enum	    event
                explicit    extern      false	    finally     fixed	float	    for
                foreach	    goto        if          implicit    in      int
                interface   internal	is          lock        long	namespace   new
                null	    object      operator    out	        out     override    params
                private	    protected	public	    readonly	ref     return	    sbyte
                sealed	    short       sizeof	    stackalloc	static	string	    struct
                switch	    this        throw	    true        try     typeof	    uint
                ulong	    unchecked	unsafe	    ushort      using	virtual	    void
                volatile    while

                add         alias	ascending   descending	dynamic	from	    get
                global      group	into	    join	let	orderby
                partial     remove	select	    set
            */

            /*
                Các kiểu dữ liệu
                int kiểu số nguyên (có dấu, dùng 32 bit biểu diễn, từ -2,147,483,648 đến 2,147,483,647)
                sbyte kiểu số nguyên (có dấu, dùng 8 bit biểu diễn, từ -128 đến 127)
                byte kiểu số nguyên (không dấu, dùng 8 bit biểu diễn, từ 0 đến 255)
                short kiểu số nguyên (có dấu, dùng 16 bit biểu diễn, từ -32,768 đến 32,767)
                ushort kiểu số nguyên (không dấu, dùng 16 bit biểu diễn, từ 0 đến 65,535)
                long kiểu số nguyên (có dấu, dùng 64 bit biểu diễn, từ -9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807)
                ulong kiểu số nguyên (không dấu, dùng 64 bit biểu diễn, từ 0 đến 18,446,744,073,709,551,615)
                float số thực chấm động (dùng 32 bit biểu diễn phù hợp số có bảy chsữ số, độ chính xác số dấu chấm động 1.5 × 10−45 đến 3.4 × 1038)
                double số thực chấm động (dùng 64 bit biểu diễn)
                decimal số thực chấm động (dùng 128 bit biểu diễn)
                char một ký tự (dùng 16 bit biểu diễn ký tự Unicode)
                bool kiểu logic (chỉ nhận giá trị false hoặc true)
                string chuỗi (xâu) ký tự (tập hợp các ký tự theo thứ tự - một văn bản text)
                object đối tượng, biểu diễn các đối tượng C#, nó là kiểu cơ sở - mọi đối tượng C# đều kế thừa từ kiểu này.
            */

            int seconds = 60;                    //khai báo biến số nguyên
            double so_pi = 3.14;                 //khai báo biến số thực
            bool deltaIsSezo = true;             //Khai báo biến logic
            char chooseAction = 'S' ;            //Khai báo biến kiểu ký tự
            string msgResult = "Kết quả giải:" ; // khai báo biến chuỗi

            //Xuát màn hình
            Console.WriteLine();                                                //Xuống dòng
            Console.WriteLine();                                                //Xuống dòng

            Console.ForegroundColor = ConsoleColor.DarkMagenta;                 //Đặt màu chữ
            Console.WriteLine("XIN CHÀO - CHƯƠNG TRÌNH NHẬP XUẤT DỮ LIỆU");     //In dòng chữ
            Console.ResetColor();                                               //Reset màu

            Console.Write("Giá trị biến so_pi là : ");                          //In dòng chữ
            Console.WriteLine(so_pi);                                           //In giá trị biến
            Console.WriteLine();                                                //Xuống dòng

            //Format string
            int a = 123;
            double b = 567.123;
            Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);
            Console.WriteLine($"Biến a = {a}, biến b = {b} - tích là {a * b}");

            //Nhập dữ liệu
            string userLogin;
            Console.Write("Nhập username : ");
            userLogin = Console.ReadLine();
            Console.WriteLine($"Tên nhập vào là: {userLogin}");

            //Chuyển kiểu dữ liệu
            Console.Write("Nhập một số thức : ");
            // Nhập chuỗi - chuyển ngay chuỗi đó thành số thực
            double dinput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Số đã nhập là: {dinput}");

            //Muốn debug được hãy biến nhập dữ liệu và chuyển kiểu dữ liệu thành comment
            //Khai báo biến ngầm định var
            var bien1 = 3.14;                                           // biến sẽ có kiểu double
            var bien2 = 3;                                              // biến sẽ có kiểu int
            var bien3 = "Biến khai báo với var phải khởi tạo ngay";     // string
            var bien4 = (5 < 4);                                        // bool

            //Hằng số
            //Hằng số lưu trữ các giá trị không thay đổi
            const string mon = "Thứ hai";
            Console.WriteLine(mon);
        }
    }
}
