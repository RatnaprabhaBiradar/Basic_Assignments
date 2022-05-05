using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class SimpleIntrest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tProgram to Calculate SimpleIntrest");
            Console.WriteLine("Enter Principal");
            int Principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate");
            float rate= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Time Period");
            float time= Convert.ToSingle(Console.ReadLine());
            float simpleintrest;
            simpleintrest = ((Principal * rate * time) / 100);
            Console.WriteLine("\tSimple Intrest is : "+ simpleintrest);
            Console.Read();

        }
        
    }
}
