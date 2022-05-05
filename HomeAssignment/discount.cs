using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    internal class discount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount to calculate Discount");
            float amt = Convert.ToSingle(Console.ReadLine());
            float discount = amt * 20 / 100;
            float net_pay = amt - discount;
            Console.WriteLine("Net payable amount after Discount is :"+ net_pay);
            Console.Read();

        }
    }
}
