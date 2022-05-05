using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{
    internal class FibonacciS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number till you want to print febonaccis series");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            int feb;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i=1;i<n-1;i++)
            {
                feb = a + b;
                Console.WriteLine(feb);
                a = b;
                b = feb;


            }
        }
    }
}
