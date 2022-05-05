using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClassProgram.March22Class
{
    internal class TernaryOperatorsClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");

            int YY = Convert.ToInt32(Console.ReadLine());
            string abc = ((YY % 4 == 0) ? "leap year" : "Not Leap");
            Console.WriteLine(abc);
        }
    }
}
