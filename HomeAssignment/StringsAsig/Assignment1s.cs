using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.StringsAsig
{
    internal class Assignment1s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string to check is it palindrome or not");
            string ss = Console.ReadLine();
            
            string[] s1 = ss.Split(" ");
            int max = s1[0].Length;int j = 0;
            string sd = "";
            foreach(string s2 in s1)
            {
                string s = "";
                
                for (int i=s2.Length-1;i>=0;i--)
                {
                    s = s + s2[i];
                }
                
                if(s==s2)
                { 
                    if(sd.Length<s.Length)
                    {
                        sd = s;
                    }                    
                }
                
            }
            Console.WriteLine($"Longest Palindrom is {sd}");
        }

    }
    // Anagram strings
    class Anagrams
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter another string to check anagram");
            string ss = Console.ReadLine();
            s = s.ToLower();
            ss = ss.ToLower();
            char temp ;
            char[] c1 = s.ToCharArray();
            char[] c2 = ss.ToCharArray();
            for (int j = 0; j < s.Length - 1; j++)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (c1[j] > c1[i + 1])
                    {
                        temp = c1[j];
                        c1[j] = c1[i + 1];
                        c1[i + 1] = temp;
                    }
                    if (c2[j] > c2[i + 1])
                    {
                        temp = c2[j];
                        c2[j] = c2[i + 1];
                        c2[i + 1] = temp;
                    }

                }
            }
            for(int i=0;i<s.Length; i++)
            {
                Console.Write(c1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(c2[i]);
            }
            int cnt=0;
            for(int i=0;i<s.Length; i++)
            {
                if (c1[i] == c2[i])
                {
                    cnt++;
                }
                
            }
            if(cnt==s.Length)
                Console.WriteLine("\nAnagram");
            else
                Console.WriteLine("\nNot anagram");
        }

    }

    //Anagram
    class Anagram12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter another string to check anagram");
            string ss = Console.ReadLine();
            s = s.ToLower();
            ss = ss.ToLower();
           
            char[] c1 = s.ToCharArray();
            char[] c2 = ss.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string news = new string(c1);
            string newss = new string(c2);
            if(news.CompareTo(newss)==0)
                Console.WriteLine(" Both strings are anagram");
            else
                Console.WriteLine("Not Anagram");
        }
    }
    //Reverse A string Preaerving space position
    // Input Hepl others
    // OutPut sret thlpeh
    class RevesrseSpace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string ss = Console.ReadLine();
            string s = "";
            for(int i=ss.Length-1;i>=0;i--)
            {
                 s = s + ss[i];
            }
            string[] s5 = ss.Split(" ");
            s = s.Replace(" ", "");
            Console.WriteLine(s);
            string s1 = "";
            for (int i = 0; i < s5.Length; i++) 
            {
                for(int j=0;j<s5[i].Length;j++)
                {
                    s1 = s1 + s[j];
                }
                s1 = s1 + " ";
            }
            Console.WriteLine(s1);
        }
    }

    //Reverse Middle word of a String
    class RMiddle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any String");
            string s = Console.ReadLine();
            string[] sd = s.Split(" ");
            string s1 = "";
            s1 = s1 + sd[0]+" ";
            
            for(int j=1;j<sd.Length;j++)
            {
                string str = sd[j];
                    for (int i = str.Length - 1; i >= 0; i--)
                    {
                        s1 = s1 +str[i] ;
                    }
                   s1 = s1 + " ";

            }

            s1 = s1 + sd[sd.Length-1];
            Console.WriteLine(s1);

        }
    }
    class Largest
    {
        static void Main(string[] args)
        {
            string[] s = { "hello", "ratnaprabha", "thinkquotient", "pune" };
            string s1 = s[0];
            for(int i=0;i<s.Length;i++)
            {
                if(s1.Length<s[i].Length)
                {
                    s1 = s[i];
                }
            }
            Console.WriteLine(s1);
        }
    }
}
