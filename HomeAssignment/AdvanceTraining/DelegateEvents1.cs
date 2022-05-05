using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.AdvanceTraining
{
    public delegate void MultiDelegate(int a, int b);
    internal class DelegateEvents1
    {
        public void Add(int a,int b)
        {
            Console.WriteLine($"Addition = {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Substruction = {a - b}");
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"Multiplication = {a * b}");
        }

    }
    class TestDel1
    {
        static void Main(string[] args)
        {
            DelegateEvents1 firstob = new DelegateEvents1();
            
            MultiDelegate mul = new MultiDelegate(firstob.Add);
            mul += new MultiDelegate(firstob.Sub);
            mul += new MultiDelegate(firstob.Multiplication);
            Delegate[] d = mul.GetInvocationList();
            foreach (Delegate result in d)
            {
                result.DynamicInvoke(5, 6);
                result.DynamicInvoke(8, 2);
                result.DynamicInvoke(12, 18);
                Console.WriteLine("***************");

            }       
                               
        }
    }
    public delegate void MyNewDel();
    class Bank
    {
       
        public event MyNewDel ZeroBalance;
        public event MyNewDel LowBalance;

        public static double Balance
        {   get;
            set;
        }


        public void Withdraw(double amt)
        {
            if (Balance == 0)
            {
                ZeroBalance();
                Console.WriteLine($"Balance is = {Balance}");
            }
            else if(Balance<amt)
            {
                LowBalance();
                Console.WriteLine($"Balance is = {Balance}");
            }
            else
            {
                Balance = Balance - amt;
                Console.WriteLine($"Balance ={Balance}");
            }

                
        }
    }
    class TestEvent
    {
        static void Main(string[] args)
        {
            Bank.Balance =90000;
            Bank bankobj = new Bank();

            static void ZeroBalance()
            {
                Console.WriteLine("Balance is Zero");

            }
            static void LowBalance()
            {
                Console.WriteLine("Insufficient Balance ");

            }

            bankobj.ZeroBalance += new MyNewDel(ZeroBalance);
            bankobj.LowBalance += new MyNewDel(LowBalance);
            char ch;
            do
            {
                Console.WriteLine("Enter amount to withdraw");
                int with = Convert.ToInt32(Console.ReadLine());
                bankobj.Withdraw(with);
                Console.WriteLine("Do you want to continue");
                ch =(char) Console.Read();
            } while (ch == 'y' || ch == 'Y');

        }
    }
}
