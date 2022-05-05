using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Array1
{
    internal class AssingmentA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            int sum = 0;
            Console.WriteLine($"Enter {size} elements in array");
            for(int i=0;i<ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ar.Length; i++)
                sum = sum + ar[i];
            int Avj = sum / size;
            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i]+" " );
            Console.WriteLine("\n");
            Console.WriteLine("Average=" + Avj);

        }
    }


    class SearchElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];            
            Console.WriteLine($"Enter {size} elements in array");
            for (int j = 0; j < ar.Length; j++)
            {
                ar[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Number to search from array");
            int n = int.Parse(Console.ReadLine());
            int flag = 0;
            int i;
            for ( i = 0; i < ar.Length; i++)
            {
                if (ar[i] == n)
                {
                    flag = 1;
                    break;                

                }
            }
            if(flag==1)
                Console.WriteLine("Element found at index = " + i);
            else
                Console.WriteLine("Element Doesnot found in an Array");


        }
    }
    class Copy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            Console.WriteLine($"Enter {size} elements in array");
            for (int j = 0; j < ar.Length; j++)
            {
                ar[j] = Convert.ToInt32(Console.ReadLine());
            }
            int[] br = new int[size];
            for (int j = 0; j < ar.Length; j++)
            {
                br[j] = ar[j];
            }
            for (int j = 0; j < ar.Length; j++)
            {
                Console.WriteLine($"ar[{j}]= {ar[j]}\tbr[{j}]= {br[j]}");
            }

        }

    }
    class Reverse
    {
        //Print Every Alternate number backwards
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            Console.WriteLine($"Enter {size} elements in array");
            for (int j = 0; j < ar.Length; j++)
            {
                ar[j] = Convert.ToInt32(Console.ReadLine());
            }
            int[] br = new int[size];
              for(int i=ar.Length-1,j=0;i>=0;i--,j++)
              {
                  br[j] = ar[i];
                  Console.WriteLine($"ar[{j}]= {ar[j]}\tbr[{j}]= {br[j]}");
              }

           /* for (int i = ar.Length - 1, j = 0; i >= 0; i--, j++)
            {
                br[j] = ar[i];
                Console.WriteLine($"ar[{j}]= {ar[j]}\tbr[{j}]= {br[j]}");
            }*/
            int x = ar.Length - 1;
            Console.WriteLine("---------------------");
           for(int j=0;j<=ar.Length;j++)
           {
                Console.WriteLine(ar[j]);
                Console.WriteLine(ar[x]);
                x--;
           }
            
        }
    }
    //Insert Element in specific position of array
    class Insert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a1 = new int[20];
            Console.WriteLine($"Enter {size} elements in array");
            for (int j = 0; j < a1.Length; j++)
            {
                a1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter numer to be inserted and index where you want to insert");
            int num = int.Parse(Console.ReadLine());
            int index= int.Parse(Console.ReadLine());
            
            
            /*for(int i=0;i<b1.Length; i++)
            {
                if (index != i)
                {
                    b1[i] = a1[j];
                    j++;
                }
                else
                    b1[i] = num;
            }*/
            if(index==size)
            {
                a1[size] = num;
                size++;

            }
            else if(index>=0&&index<size)
            {
                for (int k = size - 1; k >= index; k--)
                    a1[k + 1] = a1[k];
                a1[index] = num;
            }
            Console.WriteLine($"Array After inserting  {num} at index  {index} ");
            for (int i = 0; i < size; i++)
                Console.WriteLine(a1[i]);
        }
    }

    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] a2 = { 12, 45, 47, 66, 82, 53, 96, 99,57,43 };
            int cnt1=0,cnt2=0;
            for(int i=0;i<a2.Length;i++)
            {
                if (a2[i] % 2 == 0)
                {
                    cnt1++;
                }
                else
                    cnt2++;
            }
            int[] b1 = new int[cnt1];
            int[] c1 = new int[cnt2];
            int j = 0, k = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                if (a2[i] % 2 == 0)
                {
                    b1[j] = a2[i];
                    j++;
                }
                else
                {
                    c1[k] = a2[i];
                    k++;
                }
            }
            Console.WriteLine("Even Elements Array");
            for(int i=0;i<b1.Length;i++)
                Console.WriteLine($"b1[{i}]={b1[i]}");
            Console.WriteLine("Odd Elements Array");
            for (int i = 0; i < c1.Length; i++)
                Console.WriteLine($"c1[{i}]={c1[i]}");

        }
    }
    class MaxMin
    {
        static void Main(string[] args)
        {
            int[] a2 = { 12, 45, 47, 66, 82, 53, 96, 99, 57, 43 };
            int max = 0,min=a2[0];
            for(int i=0;i<a2.Length;i++)
            {
                if(max<a2[i])
                {
                    max = a2[i];
                }
                if(min>a2[i])
                {
                    min = a2[i];
                }
            }
            Console.WriteLine("Max= "+max);
            Console.WriteLine("Min= "+min);
        }
    }
    //Unique pair of Integers
    class Unique
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]+a[j]==7)
                    {
                        
                        Console.WriteLine($"({a[i]},{a[j]})");
                    }
                }
            }
        }
    }
}
