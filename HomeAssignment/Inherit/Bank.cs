using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class Bank
    {
        int bankid;
        string bankname;
        public Bank()
        {
            Console.WriteLine("In Base class Constructor");
        }
       public void m1()
        {
            Console.WriteLine("IN Base class");

        }
    }
    class HDFC:Bank
    {
        int hdbankid;
        string custname;
        public HDFC()
        {
            Console.WriteLine("In Derived class constructor");
        }

    }
    class NewBank:HDFC
    {
        public NewBank()
        {
            Console.WriteLine("derived class of HDFC constructor");
        }
    }
    class BTest
    {
        static void Main(string[] args)
        {

            NewBank nb =new NewBank();
            nb.m1();
        }
    }
}
