using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mike
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello world!");
            Console.Write("Wjat is your name? ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.Write("Enter number1: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter number2: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Product= {Math.Round((x * y), 2)}");
            Console.WriteLine($"Qoutient= {(x / y).ToString("0.00")}");
            Console.ReadKey();
        }
    }
}
