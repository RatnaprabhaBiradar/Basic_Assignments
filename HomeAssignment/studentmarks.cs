using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class studentmarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of Student");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Marks of Math");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of English");
            int e1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of Science");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of computer studies");
            int cs1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of History");
            int h1 = Convert.ToInt32(Console.ReadLine());
            float avj = ((m1 + e1 + s1 + cs1 + h1) / 5);
            Console.WriteLine("Average marks of  "+name+"  : "+avj);
            Console.Read();

        }
    }
}
