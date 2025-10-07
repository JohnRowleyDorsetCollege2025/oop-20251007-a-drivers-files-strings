using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings.RunDemos
{
    public static class StringDriver
    {
        public static void Run()
        {
            Console.WriteLine("StringDriver.Run() called");
            FormattingDemo();
            FormatProducts();
            OutputProductRepository();
        }

        public static void FormattingDemo()
        {
            string name = "Alice";
            string city = "Seattle";

            Console.WriteLine($"{name}:{city}");
            Console.WriteLine($"{name.PadLeft(10)}");
            Console.WriteLine($"{city.PadLeft(10)}");
            Console.WriteLine($"{name.PadLeft(30)}");
            Console.WriteLine($"{city.PadLeft(30)}");

            Console.WriteLine($"{name.PadLeft(10)}{city.PadLeft(10)}");
        }

        public static void FormatProducts()
        {
            string product1 = "Laptop";
            decimal price1 = 999.99m;
            string product2 = "Smartphone";
            decimal price2 = 499.49m;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"{"Product",-15}{"Price",10}");
            Console.WriteLine($"{product1,-15}{price1,10:C}");
            Console.WriteLine($"{product2,-15}{price2,10:C}");
        }

        public static void OutputProductRepository()
        {
    
        }
    }
}
