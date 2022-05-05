using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.StringsAsig
{
    internal class String123
    {
    }
    class WordForm
    {
        public static int freq(string s, char ch)
        {
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                    cnt++;
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter second string ");
            string s1 = Console.ReadLine();
            s = s.ToLower();
            s1 = s1.ToLower();
            bool isfound = true;
            foreach (char c in s1)
            {
                int a1 = freq(s, c);
                int b1 = freq(s1, c);
                if (b1 > a1)
                {
                    isfound = false;
                    break;
                }
            }

            if (isfound)
                Console.WriteLine("we can form ");
            else
                Console.WriteLine("We cant");
        }
    }

    //missing from Array
    class MissingNumber
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 6, 7, 8, 9 };
            int cnt = a[0];
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (cnt != a[i])
                    {
                        Console.WriteLine("Missing Element ia =" + cnt);
                        break;

                    }
                    else
                        cnt++;
                }
            }
        }

    }
    class Paterndraw
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 3 - i; k++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(" " + "*");
                Console.WriteLine();
            }
            for (int i = 1; i <= 2; i++)
            {
                for (int k = 1; k <= i; k++)
                    Console.Write(" ");

                for (int j = 2; j >= i; j--)
                    Console.Write(" " + "*");

                Console.WriteLine();
            }
        }
    }
    class Ratna1
    {
        public static int freq1(string s, char ch)
        {
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                    cnt++;
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string s2 = Console.ReadLine();
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool b1 = true;
            foreach (char c in s2)
            {
                int a = freq1(s1, c);
                int b = freq1(s2, c);
                if (b > a)
                {
                    b1 = false;
                    break;
                }
            }
            if (b1 == true)
                Console.WriteLine("Can Form");
            else
                Console.WriteLine("Can not form");
        }
    }
    class Febo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to fing");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            int feb = 0;

            for (int i = 1; i < n; i++)
            {
                feb = a + b;
                a = b; b = feb;
            }
            Console.WriteLine(a);

        }
    }
    class SresortArr
    {
        static void Main(string[] args)
        {
            string s = "ratna";

            Console.WriteLine(s);
            /*string[] s = { "Ratna","Jayvant","Krishang","Biradar"};
            foreach(string s1 in s)
                Console.Write(s1+" ");
            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i].CompareTo(s[j])<0)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach(string c in s)
                Console.Write(c+" ");*/
        }
    }
    class RotaionString
    {
        static void Main(string[] args)
        {
            string s = "ABCDEFG";
            string s1 = "CDEFGAB";
            string s2 = s + s;

            if (s.Length == s1.Length)
            {
                if (s2.IndexOf(s1) > 0)
                    Console.WriteLine("Rotation");
                else
                    Console.WriteLine("not rotation");

            }



        }
    }
}
