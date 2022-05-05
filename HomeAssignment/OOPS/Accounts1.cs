using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Accounts1
    {
        int acc_id;
        string acc_name;
        double acc_balance;
        public void Insert(int acc_id,string acc_name,double acc_balance)
        {
            this.acc_id = acc_id;
            this.acc_name = acc_name;
            this.acc_balance = acc_balance;

        }
        public void Display()
        {
            Console.WriteLine($"Account Id=\t{acc_id}");
            Console.WriteLine($"Acount Holder Name= \t{acc_name}");
            Console.WriteLine($"Account Balance= \t{acc_balance}");

        }
        public void Withdraw(double amt)
        {
            acc_balance = acc_balance - amt;
        
        }
        public void Deposit(int amt)
        {
            acc_balance = acc_balance + amt;
        }
        public void CheckBalance()
        {
            Console.WriteLine("Account Balance="+acc_balance);
        }
    }
    class TestAccount1
    {
        static void Main(string[] args)
        {
            Accounts1 ac1 = new Accounts1();
            Console.WriteLine("Enter Account Id, Name Salary");
            ac1.Insert((Convert.ToInt32(Console.ReadLine())),(Console.ReadLine()),(Convert.ToDouble(Console.ReadLine())));
            ac1.Display();
            Console.WriteLine("Enter Amount to withdraw");
            ac1.Withdraw(Convert.ToInt32(Console.ReadLine()));
            ac1.CheckBalance();
            Console.WriteLine("Enter Amount to Deposit");
            ac1.Deposit(Convert.ToInt32(Console.ReadLine()));
            ac1.CheckBalance();

        }



    }
}
