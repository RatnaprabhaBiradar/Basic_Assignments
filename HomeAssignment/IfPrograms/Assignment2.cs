using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.IfPrograms
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {

            // 1. LEAP YEAR
            Console.WriteLine("\n**** Leap Year ****");
            Console.WriteLine("\n Enter year to check wether it is leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
                Console.WriteLine("Entered year is leap year");
            else
                Console.WriteLine("Entered year is leap year");

            // 2. Number is DIVISABLE by 5 AND 11 or not
            Console.WriteLine("\n**** Divisable by 5 And 11 *****");
            Console.WriteLine("\nEntered a number To check is it divisable by 5 and 11");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
                Console.WriteLine("Number is divisable by 5 and 11");
            else
                Console.WriteLine("Number is  Not divisable by 5 and 11");

            //  3.Maximum of three numbers
            Console.WriteLine("\n****Maximum of three Numbers****");
            Console.WriteLine("\nEnter value of a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine($"Max={a}");
            else if (b > a && b > c)
                Console.WriteLine($"Max={b}");
            else if (c > a && c > b)
                Console.WriteLine($"Max={c}");
            else
                Console.WriteLine("all Numbers are same");


            //  4.Input Alphabet and check is it vovel or consonant
            Console.WriteLine("\n**** Alphabet is vovel or consonent ****");
            Console.WriteLine("\nEntered Any Alphabet");
            char? ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("Entered alphabet is vovel");
            else
                Console.WriteLine("Entered alphabet is consonant");

            //  5.SIMPLE CALCULATOR
            Console.WriteLine("****CALCULATOR****");
            Console.WriteLine("\t1. ADDITION\n\t2.SUBSTRATION\n\t3.DIVISION\n\t4.MULTIPLICATION\n\t5.MOD");
            Console.WriteLine("enter your choice from above options");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter two numbers");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3;
            if (x == 1)
            {
                x3 = x1 + x2;
                Console.WriteLine($"Addition of {x1} and {x2} is : {x3} ");
            }
            else if (x == 2)
            {
                x3 = x1 - x2;
                Console.WriteLine($"Substration of {x1} and {x2} is : {x3} ");
            }

            else if (x == 3)
            {
                x3 = x1 / x2;
                Console.WriteLine($"Division of {x1} and {x2} is : {x3} ");
            }

            else if (x == 4)
            {
                x3 = x1 * x2;
                Console.WriteLine($"Multiplication of {x1} and {x2} is : {x3} ");
            }

            else if (x == 5)
            {
                x3 = x1 % x2;
                Console.WriteLine($"MOD of {x1} and {x2} is : {x3} ");
            }


            // 6. Number Is negative positive or zero

            Console.WriteLine("\n**** Number Is negative positive or zero ****");
            Console.WriteLine("enter any number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
                Console.WriteLine($"Entered number ({num1} )is a Negative Number");

            else if (num1 > 0)
                Console.WriteLine($"Entered number ({num1} )is a Positive Number");
            else
                Console.WriteLine($"Entered number ({num1} )is equal to Zero");

            // 7. Check Entered Character is Alphabet, Digit or Special Char

            Console.WriteLine("\n**** Check Entered Character is Alphabet, Digit or Special Char ****");
            char? abcd = Convert.ToChar(Console.Read());
            if ((abcd >= 'a' && abcd <= 'z') || (abcd >= 'A' && abcd <= 'Z'))
                Console.WriteLine(" It ia A Alphabet");
            else if (abcd >= '0' && abcd <= '9')
                Console.WriteLine(" It ia A Digit");
            else
                Console.WriteLine(" It ia A Special character");




            // 8. Number is EVEN or ODD

            Console.WriteLine("\n**** Even or ODD ****");
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 % 2 == 0)
                Console.WriteLine("Entered number is Even Number");
            else
                Console.WriteLine("Enterde Number is Odd Number");

            // 10. Input Basic Salary and calculate Gross Salary

            Console.WriteLine("\n**** Input Basic Salary and calculate Gross Salary ****");
            Console.WriteLine("Enter Basic salary");
            float basic = Convert.ToSingle(Console.ReadLine());
            if (basic <= 10000)
            {
                float HRA = basic * 20 / 100;
                float DA = basic * 80 / 100;
                float Gross_sal = basic + HRA + DA;
                Console.WriteLine("Gross salary is  : " + Gross_sal);
            }

            else if (basic <= 20000)
            {
                float HRA = basic * 25 / 100;
                float DA = basic * 90 / 100;
                float Gross_sal = basic + HRA + DA;
                Console.WriteLine("Gross salary is  : " + Gross_sal);
            }
            else if (basic > 20000)
            {
                float HRA = basic * 30 / 100;
                float DA = basic * 95 / 100;
                float Gross_sal = basic + HRA + DA;
                Console.WriteLine("Gross salary is  : " + Gross_sal);
            }
            else
                Console.WriteLine("Enter Valid Salary");

            // 11. Entered number is Three Digit then Add First and Thired Digit

            Console.WriteLine("\n**** Entered number is Three Digit then Add First and Thired Digit ****");
            Console.WriteLine("Enter Any number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 > 99 && num3 < 1000)
            {
                int sum = (num3 % 10) + (num3 / 100);
                Console.WriteLine("Sum of First and Third Digit is : " + sum);
            }
            else
                Console.WriteLine("Number is not A Three Digit Number");

            // 9. Denomination of Input Amount
            Console.WriteLine("\n**** Denomination of Input Amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            int cnt3 = 0;
            int cnt4 = 0;
            int cnt5 = 0;
            int cnt6 = 0;
            int cnt7 = 0;
            int temp = amt;
            while (temp > 0)
            {
                while (temp >= 2000)
                {
                    if (temp >= 2000)
                    {
                        cnt++;
                        temp = temp - 2000;

                    }
                }
                while (temp >= 500)
                {
                    if (temp >= 500)
                    {

                        cnt1++;
                        temp = temp - 500;

                    }
                }
                while (temp >= 200)
                {
                    if (temp >= 200)
                    {

                        cnt2++;
                        temp = temp - 200;

                    }
                }
                while (temp >= 100)
                {
                    if (temp >= 100)
                    {

                        cnt3++;
                        temp = temp - 100;

                    }
                }
                while (temp >= 50)
                {
                    if (temp >= 50)
                    {

                        cnt4++;
                        temp = temp - 50;

                    }
                }
                while (temp >= 20)
                {
                    if (temp >= 20)
                    {

                        cnt5++;
                        temp = temp - 20;

                    }
                }
                while (temp >= 10)
                {
                    if (temp >= 10)
                    {

                        cnt6++;
                        temp = temp - 10;

                    }
                }
                while (temp >= 1)
                {
                    if (temp >= 1)
                    {

                        cnt7++;
                        temp = temp - 1;

                    }
                }

            }


            Console.WriteLine($"Total Denomination :\n{cnt}\t2000 \n{cnt1}\t500  \n{cnt2}\t200  \n{cnt3}\t100 \n{cnt4}\t50 \n{cnt5}\t20 \n{cnt6}\t10 \n{cnt7}\t1  ");


            // 9. Denomination 
            Console.WriteLine("\n**** Denomination of Input Amount");
            int amtx = Convert.ToInt32(Console.ReadLine());
            int cntx = 0;
            int temp1 = amtx;

            while (temp1 > 0)
            {
                if (temp1 >= 2000)
                {
                    cntx = temp1 / 2000;
                    temp = temp1 % 2000;
                    Console.WriteLine($"{cntx}  *  2000");
                }
                else if (temp1 >= 500)
                {
                    cntx = temp1 / 500;
                    temp = temp1 % 500;
                    Console.WriteLine($"{cntx}  *  500");
                }
                else if (temp >= 100)
                {
                    cntx = temp1 / 100;
                    temp = temp1 % 100;
                    Console.WriteLine($"{cntx}  *  100");
                }
                else if (temp1 >= 50)
                {
                    cntx = temp1 / 50;
                    temp = temp1 % 50;
                    Console.WriteLine($"{cntx}  *  50");
                }
                else if (temp1 >= 20)
                {
                    cntx = temp1 / 20;
                    temp = temp1 % 20;
                    Console.WriteLine($"{cntx}  *  20");
                }
                else if (temp1 >= 10)
                {
                    cntx = temp1 / 10;
                    temp = temp1 % 10;
                    Console.WriteLine($"{cntx}  *  10");
                }
                else if (temp1 >= 1)
                {
                    cntx = temp1 / 1;
                    temp = temp1 % 1;
                    Console.WriteLine($"{cntx}  *  1");
                }

            }

            // 9. Denomination 
            Console.WriteLine("\n**** Denomination of Input Amount");
            amtx = Convert.ToInt32(Console.ReadLine());
            cntx = 0;
            temp1 = amtx;
            cntx = temp1 / 2000;
            Console.WriteLine($"{cntx}  *  2000");
            temp1 = temp1 % 2000;
            cntx = temp1 / 500;
            Console.WriteLine($"{cntx}  *  500");
            temp1 = temp1 % 500;
            cntx = temp1 / 100;
            Console.WriteLine($"{cntx}  *  100");
            temp1 = temp1 % 100;
            cntx = temp1 / 50;
            Console.WriteLine($"{cntx}  *  50");
            temp1 = temp1 % 50;
            cntx = temp1 / 20;
            Console.WriteLine($"{cntx}  *  20");
            temp1 = temp1 % 20;
            cntx = temp1 / 10;
            Console.WriteLine($"{cntx}  *  10");
            temp1 = temp1 % 10;
            cntx = temp1 / 1;
            Console.WriteLine($"{cntx}  *  1");
            temp1 = temp1 % 1;
            Console.Read();


        }
    }
}
