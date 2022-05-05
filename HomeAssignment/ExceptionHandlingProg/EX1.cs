using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.ExceptionHandlingProg
{
    internal class EX1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Division" + a / b);


            }
            catch (FormatException F)
            {
                Console.WriteLine("Enter integer Value");
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Trying To devide By zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception");
            }

            Console.WriteLine("Hi");
        }
    }
    class B
    {
        public static int m1()
        {
            try 
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                return 0; 
            }
            catch(Exception) { return 9; }
            
        }
        static void Main(string[] args)
        {
            int ans = m1();
            Console.WriteLine(ans);
        }
    }
    class AB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number");
            long a = Convert.ToInt64(Console.ReadLine());
            int cnt = 0;
            while(a!=0)
            {
                cnt++;
                a = a / 10;
            }
            try
            {
                if (cnt != 10)
                    throw new MYEXCEp ("EXception Number Less than 10 dig");
            }
            catch(MYEXCEp m)
            {
                Console.WriteLine(m.Message);
            }

        }
    }
    class MYEXCEp:ApplicationException
    {
        public MYEXCEp(string s):base(s)
        {

        }
    }
    class Nullref
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = null;
                foreach (int i in a)
                    Console.WriteLine(i);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.Message);
            }
           
        }
    }
    class MultiCatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter any number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division= " + a / b);
                int[] arr = { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= arr.Length; i++)
                    Console.WriteLine(arr[i]);

            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Hi In Finally");
                
            }


        }
    }
}

