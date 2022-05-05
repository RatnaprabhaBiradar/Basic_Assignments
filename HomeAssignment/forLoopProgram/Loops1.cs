using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{

    internal class Loops1
    {
        static void Main(string[] args)
        {
             // Alphabet from a to Z

              Console.WriteLine("Print Alphabet from A To Z");
              for(char c='a';c<='z';c++)
                  Console.WriteLine(c);
              for(char ca='A';ca<='Z';ca++)
                  Console.WriteLine(ca);

            /*  //Print Table of Entered Number
              Console.WriteLine("Enter any number whose Table u want to print");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*****Table of {0}*****",n);
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine($"{n}*{i}={n*i}\n");

                }


            //sum of  First 10 ODD numbers numbers
            int sum = 0, ct = 1; ;
              for(int i=1;i<=10;i++)
              {
                sum = sum + ct;
                ct += 2;
              }
              Console.WriteLine($"sum={sum}");

            // Accept Base and index and calculate a^b
            Console.WriteLine("Enter base numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Index numbers");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result =result*a;
            }
            Console.WriteLine($"{a}^{b}= {result}");
            //Print n^2+1

            Console.WriteLine("Print the series (n^2)+1");
            Console.WriteLine("Enter a number Till you want to print series");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int sum1;
            for(int i=1;i<=n1;i++)
            {
                sum1 = i * i + 1;
                Console.WriteLine(sum1);
    
            }

            
             //Common Factors from two Numbers
              Console.WriteLine("Enter First number to calculate Factor");
              int m1 = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Enter second number to calculate Factor");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of " + m1+"\tand\t"+m2);
            if (m1 > m2)
            {
                for (int i = 1; i <= m1; i++)

                {
                    if (m1 % i == 0 && m2 % i == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i <= m2; i++)
                {
                    if (m1 % i == 0 && m2 % i == 0)
                        Console.WriteLine(i);
                }
            } 

            //Print Even Numbers from 121 to 229
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
            

            //Odd numbers from 521 To 229
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
          

            // use of break
              Console.WriteLine("Enter a Number");
              int numb = Convert.ToInt32(Console.ReadLine());
              int flag = 0;
              for(int i=2;i<=numb/2;i++)
              {
                  if (numb % i == 0)
                  {
                      flag = 1;
                    break;
                   
                      //Console.WriteLine("Number is Not Prime");
                  }

              }
             if(flag==0)
                Console.WriteLine("Number {0} is prime ",numb);
             else
                  Console.WriteLine("Number {0} is Not Prime",numb);
            //Sum of All Even numbers from 1 to n
            Console.WriteLine("Enter value of n to set the limit to find sum of even sumbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum1=0;
            for (int i = 2; i <= x; i += 2)

                sum1 = sum1 + i;

            Console.WriteLine(sum1);


            //Odd numbers betn 1 to N

            Console.WriteLine("Enter value of n to set the limit to find sum of even sumbers");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int sum2 = 0;
            for (int i = 1; i <= x1; i += 2)

                sum2 = sum2 + i;
            
            Console.WriteLine(sum2);  

            // count Number of digits in any number
            Console.WriteLine("Enter any number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            while(num1>0)
            {
                num1 = num1 / 10;
                cont++;
            }
            Console.WriteLine(cont);
            
            // Product of Digits of given number
            Console.WriteLine("Enter any number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int prod =1 ;
            int q;
            while (num1 > 0)
            {
                q = num1 % 10;
                prod *= q;
                num1 = num1 / 10;
                                
            }
            Console.WriteLine($"Product of digits of given number = {prod}");
            */
            // Prime numbers betn 400 to 300
            Console.WriteLine("Prime numbers betn 400 to 300");
            int flag ;
            int J = 2;
            int cn = 0;
            for (int i = 400; i >= 300; i--)
            {
                flag = 0;
                for (J = 2; J <= i / 2; J++)
                {
                    if (i % J == 0)
                    {
                        flag = 1;
                        break;

                    }
                }
                if (flag == 0)
                    cn++;


            }

            Console.WriteLine($"count {cn}");

            /*
            //Square from 1 To 20
            int squa;
            Console.WriteLine("Square of ");
            for (int i = 1; i <= 20; i++)
            {
                squa = i * i;
                Console.WriteLine($"\tSquare of {i}={squa}");
            }

            
            //Series of factorial


            Console.WriteLine("Enter A number to calculate Factorial");
            int x = Convert.ToInt32(Console.ReadLine());
            int i,j,fact = 1;
            int add=0;
            for ( j = x; j >= 1; j--)
            {
                fact = 1;
                for ( i = 1; i <=j; i++)
                    fact = fact * i;

                add += fact;
            }
            Console.WriteLine(add);
            
            */
            
        }
    }

}