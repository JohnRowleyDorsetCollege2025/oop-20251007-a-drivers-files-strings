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
        }

        public static void FormattingDemo()
        {
            string name = "Alice";
            string city = "Seattle";

            Console.WriteLine($"{name}:{city}");
        }
    }
}
