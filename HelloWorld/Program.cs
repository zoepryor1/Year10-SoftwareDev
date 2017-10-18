using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MY PROGRAM-HELLO WORLD";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Beep(4000, 2000);
            Console.WriteLine("Hello World :)");
            Console.Read();
        }
     
    }
}


