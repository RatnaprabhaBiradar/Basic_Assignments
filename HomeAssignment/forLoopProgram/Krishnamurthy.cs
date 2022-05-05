using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{
    internal class Krishnamurthy
    {
        static void Main(string[] args)
        {
            // Given number is Krishnamurthy or not
            //Console.WriteLine("Enter A Number");
            //int n = Convert.ToInt32(Console.ReadLine());
           // int a = n;
            int temp;
            int n ,a=1;
            int fact = 1, add = 0;
            Console.WriteLine("hi");
            while(a<=1000)
            {
               // Console.WriteLine("hi");
                 n = a;

               // Console.WriteLine("hi");
                while (n > 0)
                {
                    //temp = n;
                    temp = n % 10;
                    n = n / 10;
                    fact = 1;
                    add = 0;
                    for (int j = 1; j <= temp; j++)
                        fact = fact * j;
                    add = add + fact;
                    //Console.WriteLine("Add"+add);
                }
                if (a == add)
                    Console.WriteLine("Number is Krishnamurthy"+a);
                //else
                   // Console.WriteLine("Number is Not Krishnamurthy"+a);
                a++;
                Console.WriteLine(a);
            }

        }
        
    }
}
