using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.IfPrograms
{
    internal class Zodic
    {
        static void Main(string[] args)
        {

            // Zodic sign

            Console.WriteLine("Zodic Sign");
            Console.WriteLine("Enter Date");
            int dd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");

            int mm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int yy = Convert.ToInt32(Console.ReadLine());
            int ab;
            if ((yy % 4 == 0 && yy % 100 != 0) || yy % 400 == 0)
                ab = 29;
            else
                ab = 28;

            if((mm==3 && dd>=21 && dd<=31) ||(mm==4 && dd<=19 && dd>=1))
                Console.WriteLine("Aries");
            else if((mm == 4 && dd >= 20 && dd <= 30) || (mm == 5 && dd <= 20 && dd >= 1))
                Console.WriteLine("Taurus");
            else if ((mm == 5 && dd >= 21 && dd <= 31) || (mm == 6 && dd <= 20 && dd >= 1))
                Console.WriteLine("Gemini");
            else if ((mm == 6 && dd >= 21 && dd <= 30) || (mm == 7 && dd <= 22 && dd >= 1))
                Console.WriteLine("Cancer");
            else if ((mm == 7 && dd >= 23 && dd <= 31) || (mm == 8 && dd <= 22 && dd >= 1))
                Console.WriteLine("Leo");
            else if ((mm == 8 && dd >= 23 && dd <= 31) || (mm == 9 && dd <= 22 && dd >= 1))
                Console.WriteLine("Virgo");
            else if ((mm == 9 && dd >= 23 && dd <= 30) || (mm == 10 && dd <= 22 && dd >= 1))
                Console.WriteLine("Libra");
            else if ((mm == 10 && dd >= 23 && dd <= 31) || (mm == 11 && dd <= 21 && dd >= 1))
                Console.WriteLine("Scorpio");
            else if ((mm == 11 && dd >= 22 && dd <= 30) || (mm == 12 && dd <= 21 && dd >= 1))
                Console.WriteLine("Sagittarius");
            else if ((mm == 12 && dd >= 22 && dd <= 31) || (mm == 1 && dd <= 19 && dd >= 1))
                Console.WriteLine("Capricorn");
            else if ((mm == 1 && dd >= 20 && dd <= 31) || (mm == 2 && dd <= ab && dd >= 1))
                Console.WriteLine("Aquarius");
            else if ((mm ==2  && dd >= ab && dd <= 29) || (mm == 3 && dd <= 20 && dd >= 1))
                Console.WriteLine("Pisces");
            
            /*Console.WriteLine("enter Name");
        string? name = Console.ReadLine(); 
        Console.WriteLine("enter Age");
        int age = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("enter Gender");
        char gender= Convert.ToChar((Console.Read()));
        Console.WriteLine("enter Height");
        float height= Convert.ToSingle((Console.ReadLine()));
        Console.WriteLine("name: "+name);
        Console.WriteLine("age: "+age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("height: " + height);*/
            Console.Read();
        }
    }
}
