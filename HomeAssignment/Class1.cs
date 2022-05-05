using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Class1
    { //97-65
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter an alpphabet");
             char ch = Convert.ToChar(Console.Read());
             if (ch>=65 && ch<=90)
             {
                 ch = (char)(ch +32);
                 Console.WriteLine("Ch= "+ch);
             }
             else if(ch>=97 && ch<=122)
             {
                 ch = (char)(ch - 32);
                 Console.WriteLine("Ch= "+ch);
             }

             else
                 Console.WriteLine("Not an Alphabet");*/
            Console.WriteLine("Enter year");

            int YY = Convert.ToInt32(Console.ReadLine());
            string abc = ((YY % 4 == 0) ? "leap year" : "Not Leap");
            Console.WriteLine(abc);

        }
    }
    
}
