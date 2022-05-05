using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Example
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3];
            // int[] b = { 1, 2, 3, 4, 5 };
            
            
           for(int i=0;i<3;i++)
            {
                Console.WriteLine($"Enter {i} Array elements");
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }


            int max = a[0, 0];
            
            Console.WriteLine("Display Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];

                    }
                }
                   // Console.WriteLine(a[i,j]);
            }

            Console.WriteLine(max);
            
           

        }
    }
}
