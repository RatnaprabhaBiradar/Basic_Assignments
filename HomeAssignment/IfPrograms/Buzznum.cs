using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.IfPrograms
{
    internal class Buzznum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one number to check number is Buzz number or not");
            int num = Convert.ToInt32(Console.ReadLine());
                if(num%7==0 || num%10==7)
                Console.WriteLine("buzz number");
                else
                Console.WriteLine(" not buzz number");
            Console.Read();
           
        }
    }
}
