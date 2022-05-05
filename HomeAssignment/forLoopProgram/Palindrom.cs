using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{
    internal class Palindrom
    { 
        static void Main(string[] args)
    {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int r,pal = 0;
            int temp = num;
            while(num>0)
            {
                r = num % 10;
                pal = (pal * 10) + r;
                num = num / 10;

            }
            if(temp==pal)
                Console.WriteLine("Number is palindrom");
            else
                Console.WriteLine("Number is not palindrom");

            //palendrom from 100 to 500
            for(int i=100;i<=500;i++)
            {
                int r1, pal1 = 0;
                int temp1 = i;

                while (temp1 > 0)
                {
                    r1 = temp1 % 10;
                    pal1 = (pal1 * 10) + r1;
                    temp1 = temp1 / 10;

                }
                if (i == pal1)
                    Console.WriteLine(i);
                               

            }
        }
    
    }
}
