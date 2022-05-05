// See https://aka.ms/new-console-template for more information
using System;
namespace First
{
    class Swap
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("\tProgram to SWAP two numbers using thired veriable \n");
                Console.WriteLine("Enter value of a and b\t:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Value before Swap");
                Console.WriteLine(" a=" + a + "\n b= " + b);
            int c = a;
                a = b;
                b = c;
                Console.WriteLine("Value after SWAPING two numbers ");
                Console.WriteLine(" a=" + a + "\n b= " + b);
                Console.WriteLine("\n\tProgram to SWAP two numbers witchot using thired veriable \n");
                Console.WriteLine("Enter value of x and y\t:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value before Swap");
                Console.WriteLine(" x=" + x + "\n y= " + y);
            x = x + y;
            x = x - y;
            y = x - y;
                Console.WriteLine("\tValue after SWAPING two numbers ");
                Console.WriteLine(" x=" + x+"\n y= "+y);
              
        }
    }

}

