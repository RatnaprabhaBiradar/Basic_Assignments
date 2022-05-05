using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Demo
{
    internal class TRY1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = num;
            int temp, a = 0, b = 0, flag = 0;
            a = num % 10;
            while (num>0)
            {
                num = num / 10;
                b = num % 10;
                if (a > b)
                {
                    a = b;
                }
                else
                {
                    flag = 1;
                    break;
                }
               
            }
            if (flag == 0)
                Console.WriteLine("Increasing Number");
            else
            {
                flag = 0;
                num = x;
                a = num % 10;
                num = num / 10;
                while (num > 0)
                {
                    b = num % 10;
                    num = num / 10;

                    if (a < b)
                    {                      
                        a = b;
                    }
                    else
                    {
                        flag = 1;
                        break;
                    }

                }

                if (flag == 0)
                    Console.WriteLine("Decreasing Number");
                else
                    Console.WriteLine("Buncy Number");


            }
        }
    }
    class AA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp, x,flag=0;
            x = a;
            while(a>0)
            {
                temp = a % 10;
                if(temp%2==0)
                {
                    flag = 1;
                }
                a = a / 10;
            }
            if(flag==0)
                Console.WriteLine("Happy Number");
            else
                Console.WriteLine("Not happy number");
        }
    }
    class Sample
    {
        public int function (int num1)
        {
            return (num1 > 0 ? num1 : num1 * -1);
        }
        public long function(long num2)
        {
            return (num2 > 0 ? num2 : num2 * -1);
        }
        public double function(double num3)
        {
            return (num3 > 0 ? num3 : num3 * -1);
        }
    }
    class prog
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            int i = -25;
            int j;
            long l = -1000001;
            long m;
            double d= -12.34;
            double e;
            j = s.function(i);
            m = s.function(l);
            e = s.function(d);
            Console.WriteLine(j+" "+m+" "+e);
            Console.ReadLine();
        }
    }
    class BB1
    {
        public int i;
        public int j;
        public void fun(int i, int j)
        {
            this.i = i;
            this.j = j;

        }
    }
    class ABC
    { 
        static void Main(string[] args)
        {


            int a1 = 5;
            fun3(ref a1);
            Console.WriteLine(a1);

        }
        static void fun3(ref int a1)
        {
            a1 = a1 * a1;
        }
        
    }
    class abc
    {
        public static void a()
        {
            Console.WriteLine("First method");
        }
        public void b()
        {
            a();
            Console.WriteLine("Second Method");
        }
            public void b(int i)
        {
            Console.WriteLine(i);
            b();
        }

        
    }
    class xyz
    {
        static void Main(string[] args)
        {
            abc k = new abc();
            abc.a();
            k.b(20);
            k.b(20);
        }
    }
}
