using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Area
    {
        static void Main(string[] args)
        {
            // Area and perimeter of Square 
            Console.WriteLine("\t\t**Area of Square**");
            Console.WriteLine("\nEnter Side of Square");
            float side = Convert.ToSingle(Console.ReadLine());
            float areaofsquare = side * side;
            Console.WriteLine("Area of Square is : " + areaofsquare);
            float sqperi = 4 * side;
            Console.WriteLine("Perimeter of Square is : " + sqperi);
            // Area and perimeter of circle
            Console.WriteLine("\t\t**Area of Circle**");
            Console.WriteLine("\nEnter Redius of Circle");
            float r = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14f;
            float areaofcircle= pi * r;
            Console.WriteLine("Area of circle is : "+ areaofcircle);
            float cirperi = 2 * pi * r;
            Console.WriteLine("Perimeter of Circle is : " + cirperi);
            // Area and perimeter of Triangle
            Console.WriteLine("\n\t\t**Area of triangle**");
            Console.WriteLine("\nEnter hight of Triangle");
            float hight= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter base of Triangle");
            float b = Convert.ToSingle(Console.ReadLine());
            float areaoftriangle = (0.5f * hight * b);
            Console.WriteLine("Area of Triangle is : " + areaoftriangle);
            Console.WriteLine("Enter third side of Triangle");
            float c= Convert.ToSingle(Console.ReadLine());
            float triperi = hight + b + c;
            Console.WriteLine("Perimeter of Triangle is : " + triperi);
            // Area and perimeter  or Rectangle
            Console.WriteLine("\n\t\t**Area of rectangle**");
            Console.WriteLine("\nEnter lenght of rectangle");
            float length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            float breadth = Convert.ToSingle(Console.ReadLine());
            float areaofrectangle = length*breadth;
            Console.WriteLine("Area of Rectangle is : " + areaofrectangle);
            float rectperi = 2*(length+breadth);
            Console.WriteLine("Perimeter of Rectangle is : " + rectperi);

            Console.Read();

        }
    }
}
