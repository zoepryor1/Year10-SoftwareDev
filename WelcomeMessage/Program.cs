using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name here:");
            string name = Console.ReadLine();
            Console.Write("Enter your last name here:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Welcome to my program " + name + lastname);
            
            //wait at the end
            Console.ReadKey();
        }
    
    }
}
