using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Pattern
{
    internal class pattern1
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter number of Rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int c = Convert.ToInt32(Console.ReadLine());*/

            /*/ Print Pattern E
            for (int r = 1; r <= 5; r++)
            { 
                for (int c = 1; c <= 5; c++)
                {
                    if (r==1||c==1||(r==3)||r==5)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            // Print F
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (r == 1 || c == 1 || (r == 3) )
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            //print B
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if ((r==2 && c==5)||(r==5&&c==5))
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            // Print A
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c==1||c==5||r==1||r==3)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int r = 1; r <= row; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("");

            }

            for (int r = row; r <= 1; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }

            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                    Console.Write(j);
                Console.WriteLine("");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine("");
            }
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                    Console.Write(j);
                Console.WriteLine("");
            }
            for (int i = 5; i>= 1; i--)
            {
                for (int j = i;j<=5; j++)
                    Console.Write(j);
                Console.WriteLine("");
            }*/
            for(int i=1;i<=9;i+=2)
            {
                for(int j=1;j<=i;j+=2)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }
}
