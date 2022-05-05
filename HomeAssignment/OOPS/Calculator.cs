using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Calculator
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition =" + c);

        }
        public float SimpIntrest(int p,float r,int y)
        {
            float si = (p * r * y) / 100;
            return si;
        }
        bool Isleep(int year)
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Enter two numbers to calculate addition");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            c1.Add(a, b);
            Console.WriteLine("Enter Principal");
            int Principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate");
            float rate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Time Period");
            int year = Convert.ToInt32(Console.ReadLine());
            float si=c1.SimpIntrest(Principal, rate, year);
            Console.WriteLine("simple Intrest ="+si);
            Console.WriteLine("Enter year to check Leep year or Not");
            int yy = Convert.ToInt32(Console.ReadLine());
            bool b1 = c1.Isleep(yy);
            if(b1)
            {
                Console.WriteLine("Leep year");
            }
            else
                Console.WriteLine("Leep year");



        }
    }
}
