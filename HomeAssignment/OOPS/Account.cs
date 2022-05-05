using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Account
    {
        long acount_number;
         string custname;
        public Account()
        {
            acount_number = 00000000000;
            custname = "abc";
            Console.WriteLine("I am in default constructor");
        }
        public Account(long acn,string nm)
        {
            acount_number = acn;
            custname = nm;
            Console.WriteLine("I am i n parameterized Constructor");
        }

    }
    class AccTest
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            Account a1 = new Account(0000000000, "qwe");
        }
    }
}
