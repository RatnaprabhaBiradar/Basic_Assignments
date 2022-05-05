using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.forLoopProgram
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int x, a = n,add=0,mult=1;
            int cnt=0;
            while(a>0)
            {
                a = a / 10;
                cnt++;
       
            }
            
            int m = cnt;
            while(temp>0)
            {
                
                x = temp % 10;
                
                temp = temp / 10;
                
                while(cnt>0)
                {
                    mult = mult * x;
                    
                    cnt--;

                }
               
                add = add + mult;
                cnt = m;
                mult = 1;
            }
            Console.WriteLine(add);
            if(n==add)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
                Console.WriteLine("Not an Armstrong Number");
        }
    }
}
