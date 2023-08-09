using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number :");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
