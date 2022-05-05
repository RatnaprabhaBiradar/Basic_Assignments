using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Array1
{
    internal class Assignment2
    {
        //Row wise Max and min  & column wise max and min
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number or row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];
            
            for(int r=0;r<row;r++)
            {
                Console.WriteLine($"Enter elements of {r}th row");
                for(int c=0;c<column;c++)
                {
                    a[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("------------------\n");
            int max=a[0,0] ;
            for (int r = 0; r < row; r++)
            {
                max = a[r,0];
                for (int c = 0; c < column; c++)
                {
                    if(max<a[r,c])
                    {
                        max = a[r, c];
                    }
                    
                }
                Console.WriteLine($"Max in {r}st row = {max} ");
                ;
            }
            int min ;
            for (int r = 0; r < row; r++)
            {
                min = max;
                for (int c = 0; c < column; c++)
                {
                    if (min > a[r, c])
                    {
                        min = a[r, c];
                    }

                }
                Console.WriteLine($"Min in {r}st row = {min} ");             
            }
            Console.WriteLine("\n");
            for (int c = 0; c < column; c++)
            {
                max = 0;
                for (int r = 0; r < row; r++)
                {
                    if (max < a[r, c])
                    {
                        max = a[r, c];
                    }

                }
                Console.WriteLine($"Max in {c}th column = {max} ");          
            }
            for (int c = 0; c < column; c++)
            {
                min = max;
                for (int r = 0; r < row; r++)
                {
                    if (min > a[r, c])
                    {
                        min = a[r, c];
                    }
                }
                Console.WriteLine($"Min in {c}th column = {min} ");
            }


        }
    }

    class Dignoal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number or row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];

            for (int r = 0; r < row; r++)
            {
                Console.WriteLine($"Enter elements of {r}th row");
                for (int c = 0; c < column; c++)
                {
                    a[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Major Digonal elements");
            if (row == column)
            {
                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    {
                        if (r==c)
                        {
                            Console.Write(a[r,c]+" ");
                        }

                    }

                }
            }
            else
                Console.WriteLine("Row and column size id different *Not able to print dignoalelements ");
            Console.WriteLine("\nMinor Digonal Elements");
            if (row == column)
            {
                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    {
                        if (r+c==row-1)
                        {
                            
                            Console.Write(a[r, c] + " ");
                        }

                    }

                }
            }
            else
                Console.WriteLine("Row and column size id different *Not able to print dignoalelements ");
            
        }
    }
    //1. Reverse Row elements
    //2. reverse Column elements
    class ReverseRow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number or row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];
            int[,] acopy = new int[row, column];

            for (int r = 0; r < row; r++)
            {
                Console.WriteLine($"Enter elements of {r}th row");
                for (int c = 0; c < column; c++)
                {
                    a[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0,j=column-1; c < column; c++,j--)
                {
                    acopy[r, c] = a[r, j];
                }
            }
            Console.WriteLine("------------------------\n");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(acopy[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int c = 0; c < column; c++)
            {
                for (int r = 0, j = row - 1; r < row; r++, j--)
                {
                    acopy[r, c] = a[j, c];
                    
                }
                
            }
            Console.WriteLine("------------------------\n");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(acopy[r, c] + " ");
                }
                Console.WriteLine(" ");
            }


        }  
    }
    //seprate zeros
    class Zeroseprate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            int temp;
            Console.WriteLine($"Enter {size} elements in array");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]!=0)
                {

                    ar[j] = ar[i];
                    j++;
                }
               
            }
            while (j < ar.Length)
            {
                ar[j] = 0;
                j++;
            }
            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i] + " ");
        }
    }
    //frequency count of each element in an array
    class  Freqcount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            int temp;
            Console.WriteLine($"Enter {size} elements in array");
            for (int i = 0; i < ar.Length; i++)
            {              
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cnt ;
            for(int i=0;i<ar.Length;i++)
            {
                cnt = 0;
                for(int j=0;j<ar.Length;j++)
                {
                    if (ar[i] == ar[j] && j < i)
                        break;
                    else if(ar[i]==ar[j])
                    {
                        cnt++;
                    }
                }
                if(cnt>0)
                Console.WriteLine($"Frequency of{ar[i]} is {cnt}");
            }
        }

    }
    class  Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            int temp;
            Console.WriteLine($"Enter {size} elements in array");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<ar.Length;i++)
            {
                if(i==0)
                {
                    temp = ar[ar.Length - 1];
                    ar[ar.Length - 1] = ar[i];
                    ar[i] = temp;

                }
                else if(i==1)
                {
                    temp = ar[ar.Length - 2];
                    ar[ar.Length - 2] = ar[i];
                    ar[i] = temp;

                }
            }
            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i] + " ");

        }
    }
    class Mearg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            
            Console.WriteLine($"Enter {size} elements first in array");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] br = new int[size];
           
            Console.WriteLine($"Enter {size} elements insecond  array");

            for (int i = 0; i < br.Length; i++)
            {
                br[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] cr = new int[ar.Length+br.Length];
            for (int i = 0, j = 0, k = 0;i<size;i++,j++)
            {
                cr[k] = ar[i];
                k++;
                
                cr[k] = br[j];
                k++;
            }
            for (int i = 0; i < cr.Length; i++)
                Console.Write(cr[i] + " ");
        }
    }

    class Transpose
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number or row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of column");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];

            for (int r = 0; r < row; r++)
            {
                Console.WriteLine($"Enter elements of {r}th row");
                for (int c = 0; c < column; c++)
                {
                    a[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] b = new int[column, row];
            /*//when rows n column are same
            for(int c=0; c<column;c++)
            {
                for(int r=0;r<row;r++)
                {
                    b[c, r] = a[r, c];
                }
            }*/

            for(int r=0;r<column;r++)
            {
                for(int c=0;c<row;c++)
                {
                    b[r, c] = a[c, r];
                }
            }
            Console.WriteLine("Matrix before Transpose");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Matrix after Transpose");
            for (int r = 0; r < column; r++)
            {
                for (int c = 0; c < row; c++)
                {
                    Console.Write(b[r, c] + " ");
                }
                Console.WriteLine(" ");
            }

        }
    }
    class JaggedArr
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] =new int[3];
            a[1] = new int[2];
            a[2]= new int[4];
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine($"Enter{a[i].Length} Elements  of {i}th row");
                for(int j=0;j<a[i].Length;j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+" "); 
                }
                Console.WriteLine(" ");
            }
        }
    }
    class Pal
    {
        public void palm(string s)
        {
            string t = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                
                t = t + s[i];
            }
            
            if(t==s)
                Console.WriteLine("Palindrom");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            string s1 = "All Men ArA Created Equal";
            string[] s2=s1.Split();
            Pal p = new Pal();

           foreach(string s3 in s2)
            {
                 Console.WriteLine(s3);
                p.palm(s3);

            }


        }
    }
    //Alternate negative and positive
    class AltPN
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 6, 4, -8, -9, -7, 3, -6, 12 ,25,41,21,-92};
            int[] anew = new int[a.Length];
            int p = 0, n = 0;
            for(int i=0;i<anew.Length;)
            {
                while (p < a.Length && a[p] < 0)
                    p++;
                if(p<a.Length)
                {
                    anew[i] = a[p];
                    p++;
                    i++;
                }
                while (n < a.Length && a[n] > 0)
                    n++;
                if(n<a.Length)
                {
                    anew[i] = a[n];
                    n++;
                    i++;
                }
            }
            for(int i=0;i<anew.Length;i++)
                Console.WriteLine(anew[i]);
        }
    }
}
