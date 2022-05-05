using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Percentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Percentage");
            int per = Convert.ToInt32(Console.ReadLine());
            if(per>75)
                Console.WriteLine("Distinction Class");
            else if(per>60)
                Console.WriteLine("Fist Class");
            else if (per >50)
                Console.WriteLine("Second Class");
            else
                Console.WriteLine("Fail Class");


        }
    }
}
