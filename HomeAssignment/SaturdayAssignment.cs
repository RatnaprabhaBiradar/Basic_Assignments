using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    internal class SaturdayAssignment
    {
        static void Main(string[] args)
        {
           /*/ Spy Number or not
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, result = 1,x;
            int a = n;
            while(n>0)
            {
                x = n % 10;
                sum = sum + x;
                n = n / 10;
            }
            Console.WriteLine("sum="+sum);
            while(a>0)
            {
                x = a % 10;
                result = result * x;
                a = a / 10;
            }
            Console.WriteLine("multipluction="+result);
            if(sum==result)
                Console.WriteLine(" Given number is Spy Number");
            else
                Console.WriteLine(" Given number is  Not Spy Number");

            // WAP to print numbers from 1 to 50 if number is even print sum if odd print square

                for(int i=1;i<=50; i++)
                {
                    if(i%2==0)
                    {
                    Console.WriteLine("Number= "+i);

                    }
                    else 
                    {
                    Console.WriteLine("square= "+i*i);
                    }
                 
                }
            // pring 1 to 100 when fact of 3 &5 "REDBlue" if only 3"Red" n 5"Blue"

            for (int i = 1; i <= 100; i++)
            {

 // Console.WriteLine(i % 3 == 0 && i % 5 == 0? "RedBlue":(i%3==0?"red":(i%5==0?"Blue":"Invalid Choice")));

                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("RedBlue");
                else if (i % 3 == 0)
                    Console.WriteLine("Red");
                else if (i % 5 == 0)
                    Console.WriteLine("Blue");
                else
                    Console.WriteLine("Number " + i);
            }
            
            //Ambicable Number or Not
            Console.WriteLine("Enter First Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 1; i < n1; i++)
            {
                if (n1 % i == 0)
                    sum1 = sum1 + i;
                if (n2 % i == 0)
                    sum2 = sum2 + i;
            }
            if(sum1==n2 && sum2==n1)
                Console.WriteLine("Entered Number is Ambicable Number");
            else
                Console.WriteLine("Entered Number is Not Ambicable Number");
            
            //Find Trimporphic Number or Not
            Console.WriteLine("Enter Any Number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int cube;
            cube = n3 * n3 * n3;
            Console.WriteLine("Cube ="+cube);
            cube = cube % 10;
            if(n3==cube)
                Console.WriteLine("Enterde Number is Trimporphic Number");
            else
                Console.WriteLine("Enterde Number is Not Trimporphic Number");
            
            //Twin Prime Number
            Console.WriteLine("Enter First Number");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int p2 = Convert.ToInt32(Console.ReadLine());
            int fp1 = 0,fp2 = 0;
            for(int i=2;i<=p1/2 ;i++)
            {
                if (p1 % i == 0)
                {
                    fp1 = 1;
                    break;
                }
            }
            Console.WriteLine(fp1);
            for (int i = 2; i <= p2 / 2; i++)
            {
                if (p2 % i == 0)
                {
                    fp2 = 1;
                    break;
                }
            }
            Console.WriteLine(fp2);

            if (fp1==0 && fp2==0 && p2-p1==2)
                Console.WriteLine("Entered Number is Twin Prime");
            else
                Console.WriteLine("Entered Number is Not Twin Prime");
            

            // IMEI Number
            Console.WriteLine("Enter IMEI Number");
            long w = Convert.ToInt64(Console.ReadLine());
            long sum5 = 0;
            long t, s = w;


            for(int i=1;i<=10;i++)
            {
                t = s % 10;
                sum5 = sum5 + t;
                s = s / 10;              
            }
            if(sum5%10==0)
                Console.WriteLine("Entered Number is IMEI Number");
            else
                Console.WriteLine("Entered Number is Not IMEI Number"); */

            //IMEI is valid or not

            Console.WriteLine("Enter IMEI Number");
            long ax = Convert.ToInt64(Console.ReadLine());
            
            int cnt=0;
            while(ax>0)
            {
                cnt++;
                ax = ax / 10;

            }
            Console.WriteLine("Count="+cnt);
            if(cnt==15)
            {
                int sum = 0;
                for(int i=1;i<=15;i++)
                {
                    int d = (int)ax % 10;
                    ax = ax / 10;
                    if (d % 2 == 0)
                    {
                        d = 2 * d;
                        if (d > 9)
                        {
                            sum = sum + d % 10 + d / 10;
                        }
                        else
                            sum = sum + d;
                    }
                    else
                        sum = sum + d;
                    
                }
                if (sum % 10 == 0)
                    Console.WriteLine(" Valid IMEI Number");
                else
                    Console.WriteLine(" Not Valid IMEI Number");

            }

            /*
             //long sum5 = 0;
            //long t,d1,d2=0, s = w;
            while(s>0)
            {
                sum5 = sum5  + s % 10;
                t = s /10;
                t = t % 10;
                t = t + t;
                Console.WriteLine(t);
                if (t > 9)
                {
                    while (t > 0)
                    {
                        d1 = t % 10;
                        t = t / 10;
                        
                        sum5 = sum5 + d1;
                        
                    }

                    
                }
                else
                {
                    sum5 = sum5 + t;
                    
                }
                   
                s = s / 100;

            }
            Console.WriteLine("sum ="+sum5);
            if(sum5%10==0)
                Console.WriteLine("Given IMEI Number is valid");
            else
                Console.WriteLine("Given IMEI Number is Not valid");*/

        }

    }
}
