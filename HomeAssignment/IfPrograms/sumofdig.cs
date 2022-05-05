using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.IfPrograms
{
    internal class sumofdig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number Whose digits sum you want to calculate");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum=0;
            int i;
                for ( i = 0; temp != 0; i++)
                {
                    sum = sum + (temp % 10);
                    temp = temp / 10;

                }
            Console.WriteLine("sum of digits of  "+num+" is:\t "+sum);
            Console.ReadLine();

        }
    }
}
