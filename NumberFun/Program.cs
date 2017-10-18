using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x Value:");
            float xvalue = float.Parse( Console.ReadLine());
            Console.WriteLine("Enter y Value:");
            float yvalue = float.Parse( Console.ReadLine());
            Console.WriteLine(xvalue + "+"+ yvalue + "= " + (xvalue + yvalue));
            Console.WriteLine(xvalue + "x" + yvalue + "=" + xvalue*yvalue);
            Console.WriteLine(xvalue+ "minus" +yvalue+ "= " + (xvalue - yvalue));
            Console.WriteLine(xvalue+ "divided by" +yvalue+ "=" + xvalue / yvalue);
            Console.ReadKey();
        }
    }
}
