using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Pattern
{
    internal class RightAngledPattern
    {
        static void Main(string[] args)
        {
            /*
             * * * * *
             * * * *
             * * *
             * *
             * *
            
             */
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }


        }
    }

    class P1
    {
        /*
         1 1 1 1 1
         2 2 2 2
         3 3 3
         4 4
         5
        */
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 5; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                    Console.Write(c);
                Console.WriteLine("");
                c++;
            }
        }
    }
    class P2
    {
        /*
         1 2 3 4 5
         1 2 3 4
         1 2 3
         1 2
         1
        */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine("");
            }

        }
    }
    class P3
    {
        /*
         1  2   3   4   5
         2  3   4   5
         3  4   5
         4 5
         5
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = (5 - (i - 1)); j <= 5; j++)
                    Console.Write(j);

                Console.WriteLine("");
            }
        }
    }
    class P4
    {
        /*
         5 5 5 5 5
         4 4 4 4
         3 3 3
         2 2
         1
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine("");
            }
        }
    }
    class P5
    {
        /*
         5 4 3 2 1
         5 4 3 2
         5 4 3
         5 4
         5
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }
    class P6
    {
        /*
         5 4 3 2 1
         4 3 2 1
         3 2 1
         2 1
         1
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = (5 - (i - 1)); j >= 1; j--)
                    Console.Write(j);
                Console.WriteLine("");

            }
        }
    }
    class P7
    {
        /*
         5
         5 4
         5 4 3 
         5 4 3 2
         5 4 3 2 1
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }
    class P8
    {
        /*
         A A A A A
         B B B B
         C C C
         D D
         E
         */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                    Console.Write(i);
                Console.WriteLine("");
            }
        }
    }
    class P9
    {
        /*
         A B C D E
         A B C D
         A B C
         A B
         A
         */
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }
    class P10
    {  /*
         E D C B A
         E D B C
         E D C
         E D
         E
        */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }
    class P11
    {
        /*
        E E E E E
        D D D D
        C C C 
        B B 
        A 
         */
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine("");
            }
        }
    }
    class P12
    {
        /*
         A
         A B
         A B C
         A B C D
         A B C D E
         */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }
    }

    class P13
    {
        /*
               1
              12
             123
            1234
           12345
         */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int k = 1; k <= 5 - i; k++)
                    Console.Write(" ");
                for (int j=1;j<=i;j++)
                {
                    
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
    class P14
    {
        /*
                    6
                  5 6
                4 5 6
              3 4 5 6
            2 3 4 5 6
          1 2 3 4 5 6
         */
        static void Main(string[] args)
        {


            for (int i =6 ; i >= 1; i--)
            {
                for (int k = 1; k <= i-1; k++)
                    Console.Write(" ");
                for (int j =i ;j<=6 ; j++)
                {

                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
    class P15
    {
        /*
         * 
         * * *
         * * * * *
         * * * * * * *
         * * * * * * * *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for (int j = 1; j < i*2; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    class P16
    {  
        /*
         
                 * 
               * * *
             * * * * *
           * * * * * * *
         * * * * * * * * *
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k <= row - i; k++)
                    Console.Write(" ");
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
    class P17
    {
        /*
                        1
                      1 2 3
                    1 2 3 4 5
                  1 2 3 4 5 6 7 
                1 2 3 4 5 6 7 8 9
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k <= row - i; k++)
                    Console.Write(" ");
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }

    }
    class P18
    {
        /*
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i =row; i >= 1; i--)
            {
                for (int k = 1; k <= row - i; k++)
                    Console.Write(" ");
                for (int j = 1; j <=2*i-1 ; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("");
            }
        }
    }
    class P19
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                if(i%2==0)
                {
                   
                }
                else
                {
                    
                }
            }
            Console.WriteLine(" ");
        }
    }

    class P22
    {/*
      1
      2  3
      4  5  6
      7  8  9
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine(" ");
                    
            }
        }
    }
    /*
              1
            2 3 2
          3 4 5 4 3
        4 5 6 7 6 5 4
     
     */
    class P23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1;i<=row;i++)
            {
                for(int k=1;k<=row-i;k++)
                    Console.Write(" ");
                for(int j=i;j<i*2;j++)
                {
                    Console.Write(j);
                }
                for(int l=2*i-2;l>i;l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine("");
            }

            /*for(char i='A';i<='E';i++)
            {
                for(char k='A';k<='E'-i;k++)
                    Console.Write(" ");
                for(char j='A';j<=i;j++)
                    Console.Write(j);

                Console.WriteLine( );
            }*/
        }

    }
    class P24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int k=1;k<=row-i;k++)
                    Console.Write(" ");
                for(int j=i;j<=i&&j>0;j--)
                    Console.Write(j);
                Console.WriteLine(" ");
            }
        }
    }

    class P25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for(int i=0;i<row;i++)
            {
                for(int k=1;k<=row-i;k++)
                    Console.Write(" ");
                for(int j=0;j<=i;j++)
                {
                    if(j==0&&i==0)
                    {
                        x = 1;
                    }
                    else
                    {
                        x = x * (i - j + 1 / j);
                        Console.Write(x);
                    }
                }
                Console.WriteLine(" ");
            }

        }
    }
    /*  1
   2 1
  3 2 1
 4 3 2 1
-------------
4 3 2 1
4 3 2
4 3
4
------------
    1
   1 2
  1 2 3
 1 2 3 4
*/
    class mm
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= 1; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------");
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4 - i; k++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(" " + j);

                Console.WriteLine();
            }
        }

    }
    class ABC
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
        label:
            i++;
            j += i;
            if(i<10)
            {
                Console.Write(i+" ");
                goto label;
            }
        }
    }
}