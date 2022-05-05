using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Strings
{
    internal class stringFirst
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            s = s.ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("\n**************\n");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }
    }

    class StringPalindrom
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter A string");
            s = Console.ReadLine();
            string s1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            if (s == s1)
            {
                Console.WriteLine("Palindrom");
            }
            else
                Console.WriteLine("Not Palindroms");
        }
    }
    class StringPalindrom2
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter A string");
            s = Console.ReadLine();
            bool b = true;
            for (int start = 0, end = s.Length - 1; start < end; start++, end--)
            {
                if (s[start] != s[end])
                {
                    b = false;
                    break;
                }
            }
            if (b == true)
            {
                Console.WriteLine("Palindrom");
            }
            else
                Console.WriteLine("Not palindrom");
        }
    }
    class Reversest
    {
        static void Main(string[] args)
        {

            void rev(string s)
            {
                string sd = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    sd = sd + s[i];
                }
                Console.Write(sd);
                Console.Write(" ");
               
            }

            string s = "mom dad love me";
            string[] s1 = s.Split(new char[] { '@', '_', '.', ' ' });
            foreach (string s3 in s1)
            {
                rev(s3);
            }
        }
    }
    class ABC
    {
        static void Main(string[] args)
        {
            string s = "cats And *Dogs-are Asesome";
            string[] s1 = s.Split(new char[] { ' ', '*', '-' });
            foreach (string s3 in s1)
            {
                Console.Write(s3);
            }


        }
    }
    class UniqueFromArr
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 8, 4, 3, 4, 2, 3, 8 };
            int cnt;
            for (int i = 0; i < a.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] && j < i)
                        break;
                    else if (a[i] == a[j] && i <= j)
                        cnt++;

                }

                /* if(cnt>0)
                     Console.WriteLine($"Frequency of{a[i]}= {cnt}");*/
                if (cnt == 1)
                    Console.WriteLine(a[i]);

            }
        }
    }

    class StringFunctions
    {
        static void Main(string[] args)
        {
            string s = "working with prorigi is fun";
            string[] s1 = s.Split(" ");
            string s2 = s1[0];
            string s3=s1[0];
            for(int i=0;i<s1.Length;i++)
            {
                if (s2.Length < s1[i].Length)
                {
                    s2 = s1[i];
                }
                if(s3.Length>s1[i].Length)
                    s3 = s1[i];
                            
            }
            
            Console.WriteLine($"Max string is : {s2} with length- {s2.Length}");
            Console.WriteLine($"Min string is: {s3}  with length- {s3.Length}");
        }

    }

   
    class LengthPal
    {
        static void Main(string[] args)
        {
            string p1(string s)
            {
                string sd ="";
               
               for(int i=s.Length-1;i>=0;i--)
               {
                    sd = sd + s[i];
               }
                if (sd == s)
                {
                    Console.WriteLine("Pal");
                    return sd;
                }
                else
                    return "";
            }
            string s1 = "mom dad love me too muum";
            string[] s2 = s1.Split(" ");

            int max = 0;
            foreach(string s3 in s2)
            {
                string n=p1(s3);
                if(max<n.Length)
                {
                    max = n.Length;
                }

            }
            Console.WriteLine("Max= "+max);

        }
    }
    class strb
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("abc");
            sb.Append("def");
            Console.WriteLine(sb);
            sb.Insert(1, "Ratna");
            Console.WriteLine(sb);
            sb.Remove(1, 3);
            Console.WriteLine(sb);
            sb.Replace('a', 'j');
            Console.WriteLine(sb);
            string s=sb.ToString();
            StringBuilder s2 = new StringBuilder("hi");
            StringBuilder s3 = new StringBuilder("hi");
            Console.WriteLine(s2==s3);
            string s4 = new string("hi");
            string s5 = new string("hi");
            Console.WriteLine(s4==s5);
        }
    }
    
      
}


