using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Array1
{
    internal class ARRData1
    {
        static void Main(string[] args)
        {/*
            int[] a = new int[8];
            int[] b ={ 2, 4, 5 };
            int evn=0, odd=0;
            
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine($"Enter  {i}th element in array ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    evn++;
                else
                    odd++;
            }
            Console.WriteLine("Even Elements in array are= "+evn);
            Console.WriteLine("Odd Elements in array are= " + odd);

            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($" a[{i}]= {a[i]}");
               
            }
            Console.WriteLine("Reverse Array");
            for(int i=a.Length-1,j=0;i>=0;i--,j++)
            {
                Console.WriteLine($" a[{j}]= {a[i]}");
            }
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10,11,12,13 };
           
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                 c[i] = a[i];
             for (int i = a.Length, j = 0; j < b.Length; i++, j++)
                 c[i] = b[j];
             for(int i=0;i<c.Length;i++)
                 Console.WriteLine(c[i]);*/
            Console.WriteLine("Enter Length of first Array");
            int s1 = int.Parse(Console.ReadLine());
            int[] a = new int[s1];
            Console.WriteLine($"enter {s1} elements in array");
            for(int l=0;l<s1;l++)
            {
                a[l] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Length of second Array");
            int s2 = int.Parse(Console.ReadLine());
            int[] b = new int[s2];
            Console.WriteLine($"enter {s2} elements in array");
            for (int l = 0; l < s2; l++)
            {
                b[l] = Convert.ToInt32(Console.ReadLine());
            }
            int[] c = new int[a.Length + b.Length];
            int i,j,k;
            if (a.Length > b.Length)
            {
               for  (i = 0, j = 0, k = 0; j<b.Length; i++)
               {
                    if (i == 0)
                    {
                        c[i] = a[j];
                        j++;
                    }
                    else if (i % 2 != 0)
                    {
                        c[i] = b[k];
                        k++;
                    }
                    else
                    {
                        c[i] = a[j];
                        j++;
                    }
               }
                              
                for (j = b.Length-1; j < a.Length; j++)
                { c[i] = a[j];
                    i++;
                }
            }
            else
            {
                for (i = 0, j = 0, k = 0; j < a.Length; i++)
                {
                    if (i == 0)
                    {
                        c[i] = a[j];
                        j++;
                    }
                    else if (i % 2 != 0)
                    {
                        c[i] = b[k];
                        k++;
                    }
                    else
                    {
                        c[i] = a[j];
                        j++;
                    }
                }
                for (k = a.Length-1; k < b.Length; k++)
                {
                    c[i] = b[k];
                    i++;
                }

            }
            
            for (int z=0;z<c.Length;z++)
          Console.WriteLine(c[z]);
        }
    }

    class testAlter
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10,11,12 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            
            for (int i = 0; i < c.Length; )
            {
                if (k < a.Length && k < b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                }
                else if(k<a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                else
                {
                    c[i] = b[k];
                    i++;
                }
                k++;
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.Write(c[i]+" ");
            }
            
            
        }
    }
}
