using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Demo
{
    internal class KalyanimamAssignment
    {
    }

    class MinFromArray
    {
        static void Main(string[] args)
        {
            int[] ar = { 3, 24, 6, 48, 9, 1, 5, 78 };
            int min = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (min > ar[i])
                    min = ar[i];
            }
            Console.WriteLine(min);
        }
    }

    class OddFromArr
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2, 4, 6, 9, 45, 63, 99, 24, 27 };
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    cnt++;
            }
            Console.WriteLine($" Number of Odd elements in array are " + cnt);
        }
    }

    //given element present in Array or not
    class Search
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2, 4, 6, 9, 45, 63, 99, 24, 27 };
            Console.WriteLine("Enter number to be searched in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0, i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag != 0)
                Console.WriteLine("Number Fount At position " + i + 1);
            else
                Console.WriteLine("Not Found");
        }
    }
    // find the longest word from the string
    class LongestWord
    {
        static void Main(string[] args)
        {
            string ss = "i like java ";
            string[] s = ss.Split(" ");
            string sd = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (sd.Length < s[i].Length)
                {
                    sd = s[i];
                }
            }
            Console.WriteLine($"Longest word is {sd} with length = {sd.Length}");
        }
    }
    //Number of vowels in a given string
    class Vowels
    {
        static void Main(string[] args)
        {
            string sv = "help others and othersoooooo";
            int cnt = 0;
            for (int i = 0; i < sv.Length; i++)
            {
                if (sv[i] == ('a') || sv[i] == 'e' || sv[i] == 'i' || sv[i] == 'o' || sv[i] == 'u')
                    cnt++;

            }
            Console.WriteLine(cnt);
        }
    }
    //find the average of digit present in string
    class DIgitAvgINstring
    {
        static void Main(string[] args)
        {
            string s = "h8i m7y nam4e i2s Ratna56";
            int add = 0, cnt = 0;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                /*if (ch[i] > '0' && ch[i] < '9')
                {
                    add = add + (ch[i]-'0');
                    cnt++;
                }
                */
                if (char.IsDigit(ch[i]))
                {
                    add = add + (ch[i] - '0');
                    cnt++;

                }
            }

            Console.WriteLine("Average of digits present in string = " + (add / cnt));
        }
    }
    //Frequency of Each Char element in Char Array
    class FrequencyInCharARR
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'a', 'c', 'r', 'a', 't', 'n', 'b' };
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j] && j < i)
                        break;
                    else if (ch[i] == ch[j])
                        cnt++;

                }
                if (cnt > 0)
                    Console.WriteLine($"frequency of {ch[i]} is = {cnt}");

            }
        }
    }

    // Unique Character elements in an array
    class UniqueChar
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'a', 'c', 'r', 'a', 't', 'n', 'b' };
            int cnt = 0;
            Console.Write($"Unique Characters in a given array of characters is : ");
            for (int i = 0; i < c.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[i] == c[j] && j < i)
                        break;
                    else if (c[i] == c[j])
                        cnt++;
                }
                if (cnt == 1)
                    Console.Write(c[i] + " ");
            }
        }
    }

    //Frequency of each char in string
    class FreqString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] && j < i)
                        break;
                    else if (s[i] == s[j])
                        cnt++;
                }
                if (cnt > 0)
                    Console.WriteLine($"Frequency of {s[i]} = {cnt} ");
            }
        }
    }
    class NonZeroARRy
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 9, 0, 3, 4, 0, 7, 0, 8 };
            int j = 0, k = 0;
            for (int i = 0; i < a.Length;)
            {
                if (a[i] != 0)
                {
                    a[j] = a[i];
                    i++;
                    j++;
                }
                else
                    i++;

            }
            while (j < a.Length)
            {
                a[j] = 0;
                j++;
            }
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
        }
    }
    //duplicate words and occurrencea in a string
    class DuplicateString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();
            string[] s1 = str.Split(" ");
            for (int i = 0; i < s1.Length; i++)
            {
                int cnt = 0;

                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j] && j < i)
                        break;
                    else if (s1[i] == s1[j])
                        cnt++;

                }
                if (cnt > 0)
                    Console.WriteLine($"Occerance of {s1[i]} = {cnt} ");
            }
        }
    }
    //Number of words in a string
    class Words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();
            string[] s1 = str.Split(" ");
            Console.WriteLine($"Number of words in a string are : " + s1.Length);
        }
    }
    //Array of 10 Names and sord in desending order
    class SortString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();
            string[] s1 = str.Split(" ");
            string s = "";

            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1[i].Length < s1[i + 1].Length)
                {
                    s = s1[i];
                    s1[i] = s1[i + 1];
                    s1[i + 1] = s;
                }

            }

        }
    }

    // total number of alpha bets digits and special char
    class SpecialString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            int s = 0, d = 0, a = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (Char.IsDigit(c[i]))
                {
                    d++;
                }
                else if (Char.IsLetter(c[i]))
                {
                    a++;
                }
                else
                    s++;

            }
            Console.WriteLine($"Total Number of Alphabets = {a}\n \t\tDigits = {d}\n \t\tSpecial char = {s}");
        }
    }
    //Upper case to Lower Case
    class UpperToLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string in Upper Case");
            string str = Console.ReadLine();
            str = str.ToLower();
            Console.WriteLine($"Lower case String : " + str);
        }
    }

    //Array Reverse
    class ArrReverse
    {
        static void Main(string[] args)
        {
            int[] ar = { 3, 90, 45, 29, 37, 78 };
            for (int i = 0; i < ar.Length / 2; i++)
            {

                int temp = ar[i];
                ar[i] = ar[ar.Length - 1 - i];
                ar[ar.Length - 1 - i] = temp;
            }
            for (int i = 0; i < ar.Length; i++)
                Console.WriteLine(ar[i]);
        }

    }

    // Mearg 2 arry to 3rd arry should not have same values
    class MeargTwoARR
    {
        static void Main(string[] args)
        {
            int[] a = { 21, 32, 78, 96, 33, 56 };
            int[] b = { 3, 90, 45, 29, 37, 77, 12, 102, 221, 213, 2045 };
            int[] c = new int[a.Length + b.Length];
            int j = 0, k = 0, i = 0;

            if (a.Length > b.Length)
            {
                for (k = 0; k < b.Length;)
                {
                    c[i] = a[j];
                    i++;
                    j++;

                    c[i] = b[k];
                    i++;
                    k++;

                }

                while (j < a.Length)
                {
                    c[i] = a[j];
                    i++; j++;
                }
            }
            else if (b.Length > a.Length)
            {
                for (k = 0; j < a.Length;)
                {
                    c[i] = a[j];
                    i++;
                    j++;

                    c[i] = b[k];
                    i++;
                    k++;

                }
                while (k < b.Length)
                {
                    c[i] = b[k];
                    i++; k++;
                }
            }
            else
            {

                for (k = 0; k < b.Length;)
                {
                    c[i] = a[j];
                    i++;
                    j++;

                    c[i] = b[k];
                    i++;
                    k++;

                }
            }

            for (i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);

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
            if (news.CompareTo(newss) == 0)
                Console.WriteLine(" Both strings are anagram");
            else
                Console.WriteLine("Not Anagram");
        }
    }
    //sort array in assending order
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, 9, 29, 5, 25, 44, 7, 49 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array in Assending order");
            foreach (int a1 in a)
                Console.Write(a1 + " ");
            int[] a2 = { 12, 3, 9, 29, 5, 25, 44, 7, 49 };
            for (int i = 0; i < a2.Length; i++)
            {
                for (int j = i + 1; j < a2.Length; j++)
                {
                    if (a2[i] < a2[j])
                    {
                        int temp = a2[i];
                        a2[i] = a2[j];
                        a2[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted array in Desending order");
            foreach (int a1 in a2)
                Console.Write(a1 + " ");
        }
    }

    //Replace All Zeros with Onece
    class ZeroByONe
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 1;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
    //Negative value by its imediate left square
    class WithSquare
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
        }
    }
    class Toggel
    {
        static void Main(string[] args)
        {
            /* string input = "chain khuli ki main khuli ki chain khuli ";
            // input = input.ToLower();
             string s ="khuli";
             //s = s.ToLower();
            string[] s1 = input.Split();
             int c = 0;
             for(int i=0;i<s1.Length;i++)
             {
                 if (s1[i]==s)
                 {
                     c++;}
             Console.WriteLine(c);*/

            string s = "Com@123PUTer";
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                    s1 = s1 + char.ToLower(s[i]);
                else if (s[i] >= 'a' && s[i] <= 'z')
                    s1 = s1 + char.ToUpper(s[i]);
                else
                    s1 = s1 + s[i];

            }
            Console.WriteLine(s);
            Console.WriteLine(s1);
        }
    }
    class ANAGRAM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter frist string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string s1 = Console.ReadLine();
            s = s.ToLower();
            s1 = s1.ToLower();
            char[] c = s.ToCharArray();
            char[] c1 = s1.ToCharArray();
            Array.Sort(c);
            Array.Sort(c1);
            string news = new string(c);
            string news1 = new string(c1);
            if (news == news1)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");

        }
    }




    class SubARRy
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < a.Length; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            int j, max = 0, zero = 0, one = 0;
            for (int i = 0; i < a.Length; i++)
            {
                zero = 0;
                one = 0;
                for (j = i; j < a.Length; j++)
                {
                    if (a[j] == 0)
                        zero++;
                    else
                        one++;
                    if (zero == one)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
    class AP
    {
        static void Main(string[] args)
    {
        int a = 2;
        int d = 1;
            Console.WriteLine("enter n");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            Console.Write(a+" ");
            a = a + d;

        }
         }
    }
    class COOK
    {
        public int coo(int s)
        {
            if(s==1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }
            return s;
        }
        static void Main(string[] args)
        {
            

            COOK ck = new COOK();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int cu1 = 0;int cu2 = 1;
            if(n==1)
            {
                Console.WriteLine("0");
            }
            else if(n==2)
            {
                Console.WriteLine("1");
            }
            else if(n>2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }


        }
    }
    class RRR
    {
        static void Main(string[] args)
        {
           
            
        }
    }
}

