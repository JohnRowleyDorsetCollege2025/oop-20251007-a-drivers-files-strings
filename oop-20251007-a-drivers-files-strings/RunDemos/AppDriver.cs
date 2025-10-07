using oop_20251007_a_drivers_files_strings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings.RunDemos
{
    public static class AppDriver
    {
        public static void Run()
        {  
            ShowAppData();
        }

        public static void ShowAppData()
        {
            Console.WriteLine($"{AppData.AppName} : {AppData.AppVersion} : {AppData.AppAuthor}");
        }
    }
}
