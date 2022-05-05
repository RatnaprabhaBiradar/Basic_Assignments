using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Array1
{
    internal class TwoDimentionalArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];
            for (int r = 0; r < a.GetLength(0); r++)
            {
                Console.WriteLine($"Enter elements of {r}th Row");
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int r = 0; r < a.GetLength(0); r++)
            {

                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            int max = a[0, 0];
            for (int r = 0; r < a.GetLength(0); r++)
            {

                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (max < a[r, c])
                        max = a[r, c];

                } 
            }
            Console.WriteLine("Max="+max);
        }
    }
}
