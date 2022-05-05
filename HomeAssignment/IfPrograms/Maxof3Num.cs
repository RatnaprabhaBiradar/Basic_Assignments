using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.IfPrograms
{
    internal class Maxof3Num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of a numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b numbers");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c numbers");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine($"Max={a}");
            else if (b > a && b > c)
                Console.WriteLine($"Max={b}");
            else if (c > a && c > b)
                Console.WriteLine($"Max={c}");
            else
                Console.WriteLine("all Numbers are same");

        }
    }
}
