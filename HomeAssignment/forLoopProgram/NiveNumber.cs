using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{
    internal class NiveNumber
    {
        static void Main(string[] args)
        {

            //Given Number is Harshad/Nive eg 18=1+8=9 n 18/9=0
            Console.WriteLine("Enter any Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while(n>0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
             if(temp%sum==0)
            {
                Console.WriteLine("Given number is Harshad/NiveNumber");
            }
             else
                Console.WriteLine("Given number is Not Harshad/NiveNumber");
        }
    }
}
