using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class AddOverloading
    {
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of Int= "+c);
        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("Addition of Int= " + c);
        }
        public void Add(int a,float b)
        {
            float c = a + b;
            Console.WriteLine("Addition of Int= " + c);

        }
    }
    class TestAdd
    {
        static void Main(string[] args)
        {
            AddOverloading a1 = new AddOverloading();
            Console.WriteLine("Enter Two integer number for addition");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a1.Add(a, b);
            Console.WriteLine("Enter Two Floating point numbers for addition");
            float x = Convert.ToSingle(Console.ReadLine());
            float y= Convert.ToSingle(Console.ReadLine());
            a1.Add(x, y);
            Console.WriteLine("Enter one integer and one floating valu for addition");
            int d = Convert.ToInt32(Console.ReadLine());
            float e = Convert.ToSingle(Console.ReadLine());
            a1.Add(d, e);
        }
    }
}
