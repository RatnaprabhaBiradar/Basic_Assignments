using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Demo
{
    internal class Arrpal1
    {
        static void Main(string[] args)
        {
            string st = "ratar";
            string s="";

         
           // Console.WriteLine(arr.Length);
            for(int i=st.Length-1, j=0;i>=0;i--,j++)
            {
                Console.WriteLine(st[i].ToString());
                s += st[i];
               // Console.WriteLine(s);
            }
            Console.WriteLine(s);
            if (st==s)
            {
                Console.WriteLine("palindrom");
            }
            else
                Console.WriteLine("not equl");

        }
    }
     class pal1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string ss = Console.ReadLine();
            string sd="";
           
            for(int i=ss.Length-1;i>=0;i--)
            {
                
                sd = sd + ss[i];
            }
            
            if(ss==sd)
                Console.WriteLine("Pal");
        }
    }
}
