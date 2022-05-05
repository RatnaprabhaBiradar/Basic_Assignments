using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class Assignment2Switch
    {
        static void Main(string[] args)
        {
            //  1.Calculator using switch case
            Console.WriteLine("****CALCULATOR****");
            Console.WriteLine("\t1. ADDITION\n\t2.SUBSTRATION\n\t3.DIVISION\n\t4.MULTIPLICATION\n\t5.MOD");
            Console.WriteLine("enter your choice from above options");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter two numbers");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3;
            switch (ch)
            {
                case 1:
                    
                     x3 = x1 + x2;
                    Console.WriteLine($"Addition of {x1} and {x2} is : {x3} ");
                    break;
                case 2:
                    x3 = x1 - x2;
                    Console.WriteLine($"Substration of {x1} and {x2} is : {x3} ");
                    break;
                case 3:
                    x3 = x1 / x2;
                    Console.WriteLine($"Division of {x1} and {x2} is : {x3} ");
                    break;
                case 4:
                    x3 = x1 * x2;
                    Console.WriteLine($"Multiplication of {x1} and {x2} is : {x3} ");
                        break;
                case 5:
                    x3 = x1 % x2;
                    Console.WriteLine($"MOD of {x1} and {x2} is : {x3} ");
                    break;


                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }


            // 2.Day of the Week Corresponding to the number Entered
            Console.WriteLine("\n*****Day of the Week Corresponding to the number Entered*****");
            Console.WriteLine("enter your choice ");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    Console.WriteLine("Monday ");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("Friday ");
                    break;
                case 6:
                    Console.WriteLine("Saturday ");
                    break;
                case 7:
                    Console.WriteLine("Sunday ");
                    break;
                default:
                    Console.WriteLine("Day does not exist");
                    break;

             }

            // 3.  Enter ONE to FIVE and Print in Words
            Console.WriteLine("\n****Enter ONE to FIVE and Print in Words****");
            Console.WriteLine("enter your choice ");
             ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid choice ");
                    break;
            }
            
            // 4. Menu Driven program for calculating Area of Square, Circle, Triangle,Rectangle

            Console.WriteLine("\n****Menu Driven program for calculating Area of Square, Circle, Triangle,Rectangle****");
            char ca;
            
            do
            { 
            Console.WriteLine("\t1.Square\n\t2.Circle\n\t3.Triangle\n\t4.Rectangle");
            Console.WriteLine("enter your choice from above options");
            ch = Convert.ToInt32(Console.ReadLine());
                
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\nEnter Side of Square");
                        float side = Convert.ToSingle(Console.ReadLine());
                        float areaofsquare = side * side;
                        Console.WriteLine("Area of Square is : " + areaofsquare);
                        float sqperi = 4 * side;
                        Console.WriteLine("Perimeter of Square is : " + sqperi);
                        break;
                    case 2:
                        Console.WriteLine("\t\t**Area of Circle**");
                        Console.WriteLine("\nEnter Redius of Circle");
                        float r = Convert.ToSingle(Console.ReadLine());
                        float pi = 3.14f;
                        float areaofcircle = pi * r;
                        Console.WriteLine("Area of circle is : " + areaofcircle);
                        float cirperi = 2 * pi * r;
                        Console.WriteLine("Perimeter of Circle is : " + cirperi);
                        break;
                    case 3:
                        Console.WriteLine("\n\t\t**Area of triangle**");
                        Console.WriteLine("\nEnter hight of Triangle");
                        float hight = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter base of Triangle");
                        float b = Convert.ToSingle(Console.ReadLine());
                        float areaoftriangle = (0.5f * hight * b);
                        Console.WriteLine("Area of Triangle is : " + areaoftriangle);
                        Console.WriteLine("Enter third side of Triangle");
                        float c = Convert.ToSingle(Console.ReadLine());
                        float triperi = hight + b + c;
                        Console.WriteLine("Perimeter of Triangle is : " + triperi);
                        break;
                    case 4:
                        Console.WriteLine("\n\t\t**Area of rectangle**");
                        Console.WriteLine("\nEnter lenght of rectangle");
                        float length = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter breadth of rectangle");
                        float breadth = Convert.ToSingle(Console.ReadLine());
                        float areaofrectangle = length * breadth;
                        Console.WriteLine("Area of Rectangle is : " + areaofrectangle);
                        float rectperi = 2 * (length + breadth);
                        Console.WriteLine("Perimeter of Rectangle is : " + rectperi);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                        Console.WriteLine("Do you want to continue....(Y/N)");
                ca = Convert.ToChar(Console.Read());
                } while (ca == 'y' || ca == 'Y') ;

            
            Console.Read();
        }
        
    }
}
