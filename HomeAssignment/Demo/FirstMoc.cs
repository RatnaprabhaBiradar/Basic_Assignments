using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Demo
{
    internal class FirstMoc
    {
        static void Main(string[] args)
        {
            // Find second Largest digit in a given Number
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int x=0,temp,y=0;
            int a = n;
            while(n>0)
            {
                temp = n % 10;
                n = n / 10;
               
                if (y>temp)
                {
                    y = y;
                }
                else
                    y =temp;                                         
            }
            Console.WriteLine("Largest Digit="+y); 
            while(a>0)
            {
                temp = a % 10;
                if(y!=temp)
                {
                    if(x<temp)
                    {
                        x = temp;
                    }
                }
                a = a / 10;
            }
            Console.WriteLine("second Largest="+x);
            
            
        }
    }

    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int cnt = 0,x=1;
            int a = n,sum=0;
            int temp;
            while(n>0)
            {
                cnt++;
                n = n / 10;
            }
            n = a;
            int sq = n * n;
            while(cnt>0)
            {
                x = x * 10;
                cnt--;
            }
            int x1 = sq % x;
            int x2 = sq / x;

            sum = x1 + x2;
            if(sum==a)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
                Console.WriteLine("Not Kaprekar Number");
        }
    }

    class SumEvenFact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n,temp,fact=1,fact1=1;
            int sum = 0,sumood=0;
            while(n>0)
            {
                temp = n % 10;
                if(temp%2==0)
                {    for (int i = 2; i <= temp; i++)
                     fact = fact * i;
                    Console.WriteLine($"fact of{temp}={fact}");
                    sum = sum + fact;
                    fact = 1;
                }
                else
                { for(int i=2;i<=temp;i++)
                        fact1 = fact1 * i;
                    Console.WriteLine($"fact of{temp}={fact1}");
                    sumood = sumood + fact1;
                    fact1 = 1;
                }             
             n = n / 10;
            }
            Console.WriteLine($"Sum of Fact of Even Numbers :{sum}");
            Console.WriteLine($"Sum of Fact of Odd Numbers :{sumood}");
            
        }
    }
}
