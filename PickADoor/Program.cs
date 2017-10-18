using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick A Door"); 
            string choice=Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind Door One is an Envelope");
            }
            else if (choice=="2")
            {
                Console.WriteLine("Behind Door Two is a Box");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind Door Three is a Key");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
