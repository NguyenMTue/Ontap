using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTap
{
    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1, Name="Laptop", Price=1500, Category="Electronics"},
                new Product{Id=2, Name="Mouse", Price=200, Category="Electronics"},
                new Product{Id=3, Name="Keyboard", Price=400, Category="Electronics"},
                new Product{Id=4, Name="Phone", Price=800, Category="Electronics"},
                new Product{Id=5, Name="Table", Price=600, Category="Furniture"},
                new Product{Id=6, Name="Chair", Price=300, Category="Furniture"}
            };

            // Bài 3.1
            var result = products.Where(p => p.Price > 500);
            Console.WriteLine("San pham co gia tren 500:");
            foreach (var p in result)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }

            // Bài 3.2
            var p2 = products.OrderBy(p => p.Price);
            Console.WriteLine("\nSan pham co gia tang dan:");
            foreach (var p in p2)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }

            // Bài 3.3
            var p3 = products.OrderBy(p => p.Price).Take(3);
            Console.WriteLine("\n3 san pham re nhat:");
            foreach (var p in p3)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }

            // Bài 3.4
            Console.Write("\nNhap ten san pham can tim: ");
            string keyword = Console.ReadLine();

            var p4 = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));

            Console.WriteLine("Ket qua tim kiem:");
            foreach (var p in p4)
            {
                Console.WriteLine($"{p.Name} - {p.Price}");
            }

            // Bài 4
            var tong = products.Sum(p => p.Price);
            Console.WriteLine($"\nTong gia tat ca san pham la: {tong}");

            var avg = products.Average(p => p.Price);
            Console.WriteLine($"Trung binh gia tat ca san pham la: {avg}");
        }
    }
}