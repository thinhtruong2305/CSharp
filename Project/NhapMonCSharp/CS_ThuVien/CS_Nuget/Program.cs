using System;
using Newtonsoft.Json;
using MyLib;

namespace CS_Nuget
{
    class Program
    {
        class Product{
            public string Name;
            public DateTime Expiry;
            public string[] Sizes;
        }
        static void Main(string[] args)
        {
            //add một gói nuget: dotnet add package <<Tên package>> --version 13.0.3
            //hủy một gói nuget: dotnet remove <<Tên package>>
            //Làm mới lại các gói được bỏ hoặc được thêm vào item group: dotnet restore
            //Muốn thêm thư viện từ một Class library: dotnet add tên tệp.csproj reference thư viện.csproj
            //Lưu ý hai project phải dùng cùng framework như net5.0 là cả hai phải net5.0

            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            string productJson = @"{
            'Name': 'Bad Boys',
            'Expiry': '1995-4-7T00:00:00',
            'Sizes': [
                'Large',
                'Medium'
            ]
            }";

            Product m = JsonConvert.DeserializeObject<Product>(productJson);

            string name = m.Name;
            // Bad Boys

            Console.WriteLine(json);
            Console.WriteLine(name);
            Console.WriteLine(Utils.NumberToText(1119917828));
        }
    }
}
