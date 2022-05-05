using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class AreaOverloading
    {
        public void area(int s)
        {
            Console.WriteLine($"Area of Square + {s*s}");

        }
        public void area(float r)
        {
            Console.WriteLine($"Area of Circle={r*3.14f}");
        }
        public void area(int l,int b)
        {
            Console.WriteLine($"Area of Rectangle= {l*b}");
        }
    }
    class TestArea
    {
        static void Main(string[] args)
        {
            AreaOverloading a1 = new AreaOverloading();
            Console.WriteLine("Enter Side of Square");
            a1.area(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Radious of Circle");
            a1.area(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter Base n length");
            int b = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            a1.area(b, l);




        }
    }
}
